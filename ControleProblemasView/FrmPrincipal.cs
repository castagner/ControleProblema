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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipo tipo = new FrmTipo();
            tipo.Show();


            
        }

        private void cadastroNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNivel nivel = new FrmNivel();
            nivel.Show();
        }

        private void cadastroDeProblemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmProblema problema = new FrmProblema();
            problema.Show();
        }

    }
    }

