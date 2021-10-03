using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace how3
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMovimentacao formMovimentacao = new FormMovimentacao();
            formMovimentacao.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVeiculo formVeiculos = new FormVeiculo();
            formVeiculos.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
