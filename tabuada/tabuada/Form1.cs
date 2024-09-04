using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você escolheu sair", "Aviso", MessageBoxButtons.OK ,MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtNumero.Focus();
            listBoxTabuada.Items.Clear();
        }

        private void BtnProcessar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtNumero.Text);
                for (int i = 0; i <= 10; i++)
                {
                    listBoxTabuada.Items.Add(valor + " X " + i + " = " + valor * i);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        
    }
}
