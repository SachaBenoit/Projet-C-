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
        private FormNewPart NewPartForm;
        private FormListPart ListPartForm;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void cmdNewPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPartForm = new FormNewPart();
            NewPartForm.Show();
        }

<<<<<<< HEAD

        private void cmdCloseApplication_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cmdChargePart_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChargePartForm = new FormChargePart();
            ChargePartForm.Show();
            
=======
        private void cmdListPart_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListPartForm = new FormListPart();
            ListPartForm.Show();
        }

        private void cmdCloseApplication_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
>>>>>>> sacha
        }
    }
}
