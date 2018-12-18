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

namespace BatailleNavale
{
    public partial class FormNewPart : Form
    {
        private FormPart PartForm;

        public FormNewPart()
        {
            InitializeComponent();
        }

        private void cmdPartLocal_Click(object sender, EventArgs e)
        {

        }

        private void cmdPartOnline_Click(object sender, EventArgs e)
        {

        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            /*
            //Phase 1  - creation de l'objet
            Contact contact = new Contact() { Nom = "Durand", Prenom = "Albert", Mail = "adurand@gmail.com" };

            //Phase 2 - serialisation de l'objet 
            string jsonSerializedObj = JsonConvert.SerializeObject(contact);
            File.WriteAllText(@"c:\temp\monfichierResultat.son", jsonSerializedObj); // il faut que le repertoire c:\temp existe
            */

            
            try
            {
                StreamWriter sw = new StreamWriter("./" + txtNamePart.Text + ".json");
                
                sw.WriteLine("{" +
                    "\"NamePlayer\" : \"" + txtNamePlayer.Text + "\"" +
                    "}");


                sw.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception: " + exception.Message);
            }
            

            this.Hide();
            PartForm = new FormPart();
            PartForm.Show();
        }
    }
}
