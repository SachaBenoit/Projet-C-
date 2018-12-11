using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatailleNavale
{
    public partial class FormMenu : Form
    {
        private FormNewPart NewPartFrom;
        private FormChargePart ChargePartFrom;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void cmdNewPart_Click(object sender, EventArgs e)
        {
            NewPartFrom = new FormNewPart();
            NewPartFrom.Show();
        }

        private void cmdChargePart_Click(object sender, EventArgs e)
        {
            ChargePartFrom = new FormChargePart();
            ChargePartFrom.Show();
        }

        private void cmdCloseApplication_Click(object sender, EventArgs e)
        {
            //System.Environment.Exit(1);
            System.Windows.Forms.Application.Exit();
        }
    }
}
