using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cursos.cadCliente;

namespace Cursos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusData.Text = DateTime.Now.ToShortDateString();   // recbe a data atual
            toolStripStatusHora.Text = DateTime.Now.ToShortTimeString();   // recbe a hora atual
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");   // abre a calculaora do windows
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");   // abre o MS Word -- depois implmentar para s não achar o winword abrir o wordpad
        }

        // BOTÃO SAIR
        private void toolStripButton5_Click(object sender, EventArgs e)   // botão sair
        {
            Application.Exit();
        }

        // MENU SAIR
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)   // menu sair
        {
            Application.Exit();
        }

        // MENU CADASTROS
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadCurso frmCurso = new cadCurso();
            frmCurso.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadCliente frmCliente = new cadCliente();
            frmCliente.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadFuncionario frmFuncionario = new cadFuncionario();
            frmFuncionario.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadPerfil frmPerfil = new cadPerfil();
            frmPerfil.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadProfessores frmProfessores = new cadProfessores();
            frmProfessores.Show();
        }

        // MENU CONSULTAS
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //cadCliente frmCliente2 = new cadCliente(TipoTab.Consulta);
            cadCliente frmCliente2 = new cadCliente();
            frmCliente2.Show();
        }

        private void professoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadProfessores frmProfessores2 = new cadProfessores();
            frmProfessores2.Show();
        }

        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadFuncionario frmFuncionario2 = new cadFuncionario();
            frmFuncionario2.Show();
        }

        private void perfilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadPerfil frmPerfil2 = new cadPerfil();
            frmPerfil2.Show();
        }
    }
}
// implementar abertura de consulta no menu