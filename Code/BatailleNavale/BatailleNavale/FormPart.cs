using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Apache.NMS;
using Apache.NMS.Util;
using System.Threading;

namespace BatailleNavale
{
    public partial class FormPart : Form
    {
        //création du delegate
        public delegate void GetResponse(string response);

        private bool gameStarted = false;

        private bool playerIsReady = false;
        private bool playerTwoIsReady = false;

        public delegate void BackToForm();



        List<Player> players = new List<Player>();

        Player player = new Player(FormNewPart.NamePlayer, "192.168.0.1");
        Player player2 = new Player("robot", "192.168.0.2");

        Grid grid;

        public FormPart()
        {
            InitializeComponent();
        }

        private void FormPart_Load(object sender, EventArgs e)
        {
            players.Add(player);
            players.Add(player2);

            grid = new Grid(player, 50, FormNewPart.NbCells, 50, 50);
            grid.MouseClick += new MouseEventHandler(ClickOnPictureBox);
            
            this.Controls.Add(grid);

            foreach (Tuple<string, int> item in FormNewPart.Ship)
            {
                player.AddShip(new Ship(item.Item1, item.Item2, Orientation.Horizontal));
            }

            foreach (Ship playerShip in player.Ships)
            {
                lstPlayerShip.Items.Add(playerShip.Name + " " + playerShip.Size + " cases");
            }

            if(FormNewPart.IsMultiplayer)
            {
                Thread thRead = new Thread(ReadNextMessageQueue); //création du thread
                thRead.Start(); //lancement du thread
            }
         
        }

        #region public methods
        public void ClickOnPictureBox(object sender, MouseEventArgs e)
        {
            PictureBox pbx = sender as PictureBox;
            
            Point mouse_position = new Point(); // position de la souris par rapport à la grille
            mouse_position.X = e.X;
            mouse_position.Y = e.Y;

            int pictureBox_top = pbx.Top;
            int pictureBox_left = pbx.Left;
            int pictureBox_bottom = pbx.Bottom;
            int pictureBox_right = pbx.Right;

            int pictureBox_width = pictureBox_bottom - pictureBox_top;
            int pictureBox_height = pictureBox_right - pictureBox_left;

            int nbCells_x = pictureBox_width / grid.CellSize;
            int nbCells_y = pictureBox_height / grid.CellSize;

            //décompose la grille pour la mettre sous forme de cellule (A1, D4)
            for (int i = 0, ii = 0; i < pictureBox_width; i += grid.CellSize, ii++)
            {
                if (mouse_position.X >= i && mouse_position.X <= i + grid.CellSize)
                {
                    grid.HorizontalPosition = (char)(ii + 65);

                    for (int j = 0, jj = 1; j < pictureBox_height; j += grid.CellSize, jj++)
                    {
                        if (mouse_position.Y >= j && mouse_position.Y <= j + grid.CellSize)
                        {
                            grid.VerticalPosition = jj;
                            break;
                        }
                    }
                }
                else continue;

                break;
            }

            //position du tir du joueur
            grid.LastPosition = grid.HorizontalPosition.ToString() + grid.VerticalPosition;

            if (gameStarted)
            {
                bool hited = true;

                Point point = new Point();
                point = grid.cellToPositions(grid.LastPosition);

                if (!player2.Shoot(player, grid.LastPosition))
                {
                    hited = false;
                }
                    
                Target target = new Target(point.X, point.Y, grid.CellSize, grid.CellSize, hited);
                this.Controls.Add(target);
                target.BringToFront();
            }
            else
            {
                if(lstPlayerShip.SelectedIndex != -1)
                {
                    grid.PlaceShip(player.Ships[lstPlayerShip.SelectedIndex]);
                }
            }
        }
        #endregion

        #region private methods
        private void lstPlayerShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblOrientation.Text = "Orientation du bateau : " + player.Ships[lstPlayerShip.SelectedIndex].Orientation;
                Console.WriteLine(lstPlayerShip.SelectedIndex);
            }
            catch (Exception exc)
            {
                Console.WriteLine("erreur : " + exc);
            }
        }

        private void cmdSetOrientation_Click(object sender, EventArgs e)
        {
            try
            {
                player.Ships[lstPlayerShip.SelectedIndex].SetOrientation();
                lblOrientation.Text = "Orientation du bateau : " + player.Ships[lstPlayerShip.SelectedIndex].Orientation;
            }
            catch
            {
                MessageBox.Show("Aucun Bateau sélectionné");
            }
        }
        
        private void cmdReady_Click(object sender, EventArgs e)
        {
            playerIsReady = true; 

            if(FormNewPart.IsMultiplayer)
            {
                SendNewMessageQueue("ready");
            }
            else
            {
                StartGame();
            }
        }

        public void StartGame()
        {
            try
            {
                MessageBox.Show("START" + " ID du joueur : " + FormNewPart.IdPlayer);

                gameStarted = true;

                grid.CleanGrid();

                Controls.Remove(cmdReady);

                CreateButtonSave();
            }
            catch(Exception ex)
            {
                return;
            }
            
        }

        private void CreateButtonSave()
        {
            Button button = new Button();

            button.Name = "cmdSavePart";
            button.Text = "Sauvegarder";
            button.Location = new Point(613, 415);

            button.Click += new EventHandler(cmdSavePart_Click);

            this.Controls.Add(button);
        }

        private void cmdSavePart_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartObject();

                writer.WritePropertyName("Partname");
                writer.WriteValue(FormNewPart.NamePart);

                writer.WritePropertyName("Playername");
                writer.WriteValue(FormNewPart.NamePlayer);

                writer.WritePropertyName("Ships");
                writer.WriteStartArray();
                writer.WriteValue("1");
                writer.WriteValue("3");
                writer.WriteValue("A2");
                writer.WriteEnd();
                writer.WriteEndObject();
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter(@"" + FormNewPart.NamePart + ".json");
            file.WriteLine(sb.ToString()); // "sb" is the StringBuilder
            file.Close();
        }
        #endregion


        #region NetWork methods
        private void ReadNextMessageQueue()
        {
            while (true)
            {
                //Attention, lit les messages dans la queue de l'autre joueur
                //queuename = "Q" + idOtherPlayer.
                string queueName = "Q" + FormNewPart.IdPlayer;
                Console.WriteLine(queueName);

                string brokerUri = $"activemq:tcp://SC-C315-PC07:61616";  // Default port
                NMSConnectionFactory factory = new NMSConnectionFactory(brokerUri);

                using (IConnection connection = factory.CreateConnection())
                {
                    connection.Start();
                    using (ISession session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge))
                    using (IDestination dest = session.GetQueue(queueName))
                    using (IMessageConsumer consumer = session.CreateConsumer(dest))
                    {
                        IMessage msg = consumer.Receive();
                        if (msg is ITextMessage)
                        {
                            ITextMessage txtMsg = msg as ITextMessage;
                            string body = txtMsg.Text;

                            Console.WriteLine($"Received message: {txtMsg.Text}");

                            string value = "";
                            if(gameStarted)
                            {
                                Console.WriteLine("Partie lancée");
                            }
                            else
                            {
                                if(txtMsg.Text == "ready")
                                {
                                    if(playerIsReady)
                                    {
                                        
                                        Invoke((BackToForm)StartGame);
                                        SendNewMessageQueue("startGame");
                                        
                                    }
                                }
                                else if(txtMsg.Text == "startGame")
                                {
                                    Invoke((BackToForm)StartGame);
                                }

                            }

                            try
                            {
                                //On invoque le delegate pour qu'il effectue la tâche sur le temps de l'autre thread.
                                Invoke((GetResponse)DisplayResponse, value);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Erreur invoke" + ex.Message);
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Unexpected message type: " + msg.GetType().Name);
                        }
                    }
                }
            }
        }

        private void SendNewMessageQueue(string text)
        {
            //Envoie les messages dans sa propre queue
            //queuename = "Q" + idPlayer.
            string queueName = "Q" + ((FormNewPart.IdPlayer + 1) % 2);

            Console.WriteLine($"Adding message to queue topic: {queueName}");

            string brokerUri = $"activemq:tcp://sc-c315-pc07:61616";  // Default port
            NMSConnectionFactory factory = new NMSConnectionFactory(brokerUri);

            using (IConnection connection = factory.CreateConnection())
            {
                connection.Start();

                using (ISession session = connection.CreateSession(AcknowledgementMode.AutoAcknowledge))
                using (IDestination dest = session.GetQueue(queueName))
                using (IMessageProducer producer = session.CreateProducer(dest))
                {
                    producer.DeliveryMode = MsgDeliveryMode.NonPersistent;

                    producer.Send(session.CreateTextMessage(text));
                    Console.WriteLine($"Sent {text} messages");
                }
            }
        }

        private void DisplayResponse(string res)
        {
            
        }



        #endregion


    }
}
