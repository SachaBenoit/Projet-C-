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
        public FormListPart()
        {
            InitializeComponent();
        }

        private void FormListPart_Load(object sender, EventArgs e)
        {
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
            string json = File.ReadAllText(@"sauvegarde\" + lstPart.SelectedItem + ".json");
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }

            }
        }
    }
}
