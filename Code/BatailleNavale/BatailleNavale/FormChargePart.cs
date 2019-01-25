/*
 * 
 * Formulaire qui permet normalement de chargé une partie (non-fonctionnel)
 * 25.01.2019
 * Meylan Benoit & Usan Sacha
 * 
 */

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
    public partial class FormChargePart : Form
    {
        public FormChargePart()
        {
            InitializeComponent();
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {

        }

        private void FormChargePart_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
