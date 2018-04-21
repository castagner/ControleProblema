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
    public partial class FrmProblema : Form
    {
        public FrmProblema()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmProblema_Load(object sender, EventArgs e)
        {
            CarregaComboTipo();
            CarregaComboNivel();
        }

        private void CarregaComboTipo()
        {

            cboTipo.DataSource = new TipoDB().ListarTipo();
            cboTipo.DisplayMember = "descricao";
            cboTipo.ValueMember = "id";

        }

        private void CarregaComboNivel()
        {

            cboNivel.DataSource = new NivelDB().ListarNivel();
            cboNivel.DisplayMember = "descricao";
            cboNivel.ValueMember = "id";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(cboTipo.SelectedValue.ToString());
            String descricao = txtDescricao.Text;
            int idNivel = Convert.ToInt32(cboNivel.SelectedValue.ToString());
            DateTime dataCriacao = Convert.ToDateTime(txtDataCriacao.Text);


            Problema problema = new Problema()
            {

                Descricao = descricao,
                DataCriacao = dataCriacao,
                Tipo = new Tipo() { Id = id },
                              
                NivelDificuldade = new Nivel() { Id = idNivel },





            };

        if (new ProblemaDB().insert(problema)){

        MessageBox.Show("Registro inserido!");

        }else{


        MessageBox.Show("Erro ao inserir registro");

        }

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
