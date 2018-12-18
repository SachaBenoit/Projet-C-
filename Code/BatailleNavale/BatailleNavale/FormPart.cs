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
using Newtonsoft;

namespace BatailleNavale
{
    public partial class FormPart : Form
    {
        public FormPart()
        {
            InitializeComponent();
        }

        private void FormPart_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdSavePart_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("./Test.json");
                sw.WriteLine("{}");

                sw.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception: " + exception.Message);
            }
        }
    }
}
