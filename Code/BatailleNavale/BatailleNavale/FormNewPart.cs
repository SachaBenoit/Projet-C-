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

using Newtonsoft.Json;

namespace BatailleNavale
{
    public partial class FormNewPart : Form
    {
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

        private void cmdPlay_Click(object sender, EventArgs e)
        {

            namePlayer = txtNamePlayer.Text;

            nbCells = Convert.ToInt32(nudNbCells.Value);

            this.Hide();
            PartForm = new FormPart();
            PartForm.Show();
        }

        #region Methode Get

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
