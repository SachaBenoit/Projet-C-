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
        public static int test;
        
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

        #region Methode Ship

        #endregion


        private void cmdPlay_Click(object sender, EventArgs e)
        {
            namePart = txtNamePart.Text;
            namePlayer = txtNamePlayer.Text;

            nbCells = Convert.ToInt32(nudNbCells.Value);

            this.Hide();
            PartForm = new FormPart();
            PartForm.Show();
        }

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
        
        #endregion
    }
}
