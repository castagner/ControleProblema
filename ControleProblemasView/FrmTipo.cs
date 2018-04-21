using Controle;
using Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleProblemasView
{
    public partial class FrmTipo : Form
    {
        public FrmTipo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Tipo tipo = new Tipo();
            tipo.Descricao = txtDescricao.Text;

            // MessageBox.Show("Olaaa!! \n ID: " + tipo.Id + "\n Descricao: " +tipo.Descricao); //exibe esta mensagem quando clica no botão

            // MessageBox.Show("Olaaa!! " + tipo);

            if (new TipoDB().insert(tipo))
            {

                MessageBox.Show("Registro Inserido!");
                CarregarGrid();

            }
            else
            {

                MessageBox.Show("Erro ao inserir registro!");

            }
        }

        private void dgTipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           


        }

        private void FrmTipo_Load(object sender, EventArgs e)
        {

            CarregarGrid();

        }

        private void CarregarGrid()
        {

            dgTipo.DataSource = new TipoDB().ListarTipo();
            txtDescricao.Clear();
            txtDescricao.Focus();

        }
    }
}
