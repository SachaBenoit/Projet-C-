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
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace BatailleNavale
{
    public partial class FormNewPart : Form
    {
        private static List<Tuple<string, int>> listShip = new List<Tuple<string, int>>();

        private static string namePart;
        private static string namePlayer;

        private static int nbCells;

        private static string computerName;

        private FormPart PartForm;

        private static bool isMultiplayer = false;

        private static int idPlayer = 1;


        #region Accesseurs

        public static string NamePart
        {
            get { return namePart; }
        }

        public static string NamePlayer
        {
            get { return namePlayer; }
        }

        public static int NbCells
        {
            get { return nbCells; }
        }

        public static List<Tuple<string, int>> Ship
        {
            get { return listShip; }
        }

        public static string ComputerName
        {
            get
            {
                return computerName;
            }
        }

        public static bool IsMultiplayer
        {
            get
            {
                return isMultiplayer;
            }
        }

        public static int IdPlayer
        {
            get
            {
                return idPlayer;
            }
        }

        #endregion

        public FormNewPart()
        {
            InitializeComponent();
        }

        private void FormNewPart_Load(object sender, EventArgs e)
        {
            
            listShip.Add(new Tuple<string, int>("Porte-avion", 5));
            listShip.Add(new Tuple<string, int>("Croiseur", 4));
            listShip.Add(new Tuple<string, int>("Contre-torpilleur", 3));
            listShip.Add(new Tuple<string, int>("Sous-marin", 3));
            listShip.Add(new Tuple<string, int>("Torpilleur", 2));

            foreach (Tuple<string, int> item in listShip)
            {
                lstShip.Items.Add(item);
            }

            gboxGameMode.Controls.Add(rdbPartOnline);
            gboxGameMode.Controls.Add(rdbPartLocal);

            gboxPlayerMode.Controls.Add(rdbHost);
            gboxPlayerMode.Controls.Add(rdbClient);

            gboxPlayerMode.Visible = false;

            txtComputerName.Visible = false;
            lblComputerName.Visible = false;
        }


        private void cmdPlay_Click(object sender, EventArgs e)
        {
            if (rdbPartOnline.Checked)
            {
                if (rdbHost.Checked)
                {
                    computerName = Environment.MachineName;
                    StartGame();
                }
                else if (rdbClient.Checked)
                {
                    if (PingTest()) //si le nom de l'ordinateur est pingable
                    {
                        computerName = txtComputerName.Text;
                        StartGame();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez choisir un type de joueur");
                }
            }
            else
            {
                StartGame();
            }



        }

        private void StartGame()
        {
            namePart = txtNamePart.Text;
            namePlayer = txtPlayerOne.Text;

            nbCells = Convert.ToInt32(nudNbCells.Value);

            
            PartForm = new FormPart();
            PartForm.Show();
            this.Hide();
            
        }

        #region Methode Ship

        private void AddShip(string Text, decimal Size)
        {
            if (Text != "")
            {
                listShip.Add(new Tuple<string, int>(Text, Convert.ToInt32(Size)));
                lstShip.Items.Add(listShip.Last());

                txtShip.Clear();
            }
        }

        private void cmdAddShip_Click(object sender, EventArgs e)
        {
            AddShip(txtShip.Text, nudSizeShip.Value);
        }

        private void txtShip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddShip(txtShip.Text, nudSizeShip.Value);
        }

        private void cmdRemoveShip_Click(object sender, EventArgs e)
        {
            listShip.RemoveAt(lstShip.SelectedIndex);
            lstShip.Items.Remove(lstShip.SelectedItem);
        }

        #endregion



        private void rdbPartOnline_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbPartOnline.Checked)
            {
                isMultiplayer = true;

                gboxPlayerMode.Visible = true;
            }
            else
            {
                isMultiplayer = false;

                gboxPlayerMode.Visible = false;

                txtComputerName.Visible = false;
                lblComputerName.Visible = false;
            }
        }

        private void rdbClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbClient.Checked)
            {
                txtComputerName.Visible = true;
                lblComputerName.Visible = true;
                idPlayer = 0;
            }
            else
            {
                txtComputerName.Visible = false;
                lblComputerName.Visible = false;
                idPlayer = 1;

            }
        }

        /// <summary>
        /// test si le nom (ou l'adresse ip) de l'ordinateur est pingable 
        /// </summary>
        /// <returns></returns>
        private bool PingTest()
        {
            Ping ping = new Ping();
            bool pingable = false;

            try
            {
                PingReply reply = ping.Send(txtComputerName.Text); //ping la machine
                pingable = reply.Status == IPStatus.Success; // si le ping à fonctionné
            }
            catch(PingException)
            {

            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Le champ \"Nom de la machine\" ne peut pas être vide");
            }
            finally
            {
                if(ping != null)
                {
                    ping.Dispose();
                }
            }

            return pingable;
        }


    }
}
