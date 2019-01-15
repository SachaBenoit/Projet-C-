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

namespace BatailleNavale
{
    public partial class FormNewPart : Form
    {
        private static List<Tuple<string, int>> listShip = new List<Tuple<string, int>>();

        private static string namePart;
        private static string namePlayer;
        private static string localIP;

        private static int nbCells;

        private FormPart PartForm;

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

            IPAdress();
        }

        private void IPAdress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                    break;
                }
            }
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            namePart = txtNamePart.Text;
            namePlayer = txtNamePlayer.Text;

            nbCells = Convert.ToInt32(nudNbCells.Value);

            this.Hide();
            PartForm = new FormPart();
            PartForm.Show();
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

        #region Methode Get

        public static string NamePart
        {
            get { return namePart; }
        }

        public static string NamePlayer
        {
            get { return namePlayer; }
        }

        public static string LocalIP
        {
            get { return localIP; }
        }

        public static int NbCells
        {
            get { return nbCells; }
        }

        public static List<Tuple<string, int>> Ship
        {
            get { return listShip; }
        }

        #endregion
    }
}
