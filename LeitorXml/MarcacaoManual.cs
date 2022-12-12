using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeitorXml
{
    public partial class MarcacaoManual : Form
    {
        public MarcacaoManual()
        {
            InitializeComponent();
        }

        private void manualMaker_Click(object sender, EventArgs e)
        {
            Itens itens = new Itens();
            itens.Show(this);
        }
    }
}
