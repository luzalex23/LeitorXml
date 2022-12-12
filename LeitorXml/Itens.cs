using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace LeitorXml
{
    public partial class Itens : Form
    {
        public Itens()
        {
            InitializeComponent();
        }
        private string caminhoArquivo = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

        private void Itens_Load(object sender, EventArgs e)
        {
            caminhoArquivo = Directory.GetParent(Directory.GetParent(caminhoArquivo).FullName).FullName;
            caminhoArquivo += @"\Mrcadores.xml";
            XmlTextReader xmlReader = new XmlTextReader(caminhoArquivo);
            while (xmlReader.Read())
            {
                switch(xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        textItens.Text += xmlReader.Name + Environment.NewLine;       
                        break;
                    case XmlNodeType.Text:
                        textItens.Text += xmlReader.Name + Environment.NewLine;
                        break;
                    case XmlNodeType.EndElement:
                        textItens.Text += xmlReader.Name + Environment.NewLine;
                        break;
                }
            }


        }
    }

}
