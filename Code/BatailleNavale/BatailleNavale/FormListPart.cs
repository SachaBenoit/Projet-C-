using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BatailleNavale
{
    public partial class FormListPart : Form
    {
        private static string part;

        private FormPart PartForm;

        public FormListPart()
        {
            InitializeComponent();
        }

        private void FormListPart_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("sauvegarde"))
                Directory.CreateDirectory("sauvegarde");

            DirectoryInfo dir = new DirectoryInfo(@"sauvegarde\");
            FileInfo[] fileInfos = dir.GetFiles();

            foreach (FileInfo file in fileInfos)
            {
                lstPart.Items.Add(Path.GetFileNameWithoutExtension(file.ToString()));
            }
        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {

        }

        private void cmdStartPart_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            List<string[]> maliste = new List<string[]>();


            part = lstPart.SelectedItem.ToString();

            string json = File.ReadAllText(@"sauvegarde\" + lstPart.SelectedItem + ".json");
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read())
            {
                /*

                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);

                    switch (reader.Value)
                    {
                        case "PartName":
                        case "PlayerName":
                        case "SizeGrid":
                            reader.Read();
                            list.Add(reader.Value.ToString());
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }
                */

                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                    
                    switch (reader.Value)
                    {
                        case "PartName":
                        case "PlayerName":
                        case "SizeGrid":
                            reader.Read();
                            list.Add(reader.Value.ToString());
                            break;
                        default:
                            break;
                    }

                    


                }
                else if (reader.TokenType == JsonToken.StartArray)
                {

                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }


            }

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            /*
            this.Hide();
            PartForm = new FormPart();
            PartForm.Show();
            */
        }

        public static string Part
        {
            get { return part; }
        }
    }
}
