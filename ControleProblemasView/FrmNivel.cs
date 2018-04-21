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
    public partial class 
        FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }

        private void FrmNivel_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbDescricao_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            Nivel nivel = new Nivel();
            
            nivel.Descricao = tbDescricao.Text;

            // MessageBox.Show("Olaaa!! \n ID: " + nivel.Id + "\n Descricao: " + nivel.Descricao); //exibe esta mensagem quando clica no botão

            if (new NivelDB().insert(nivel))
            {

                MessageBox.Show("Registro Inserido!");
                CarregarGrid();

            }
            else
            {

                MessageBox.Show("Erro ao inserir registro!");

            }

      
        
        }
        private void CarregarGrid()
        {

            dgNivel.DataSource = new NivelDB().ListarNivel();
            tbDescricao.Clear();
            tbDescricao.Focus();

        }
    }
}
