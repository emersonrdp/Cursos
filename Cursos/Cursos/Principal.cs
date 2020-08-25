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
        public enum TipoTab   // enun utilizado para abrir os cadastros na aba de cadastro ou na aba de consulta
        {
            Cadastro,
            Consulta
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
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // MENU SAIR
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // MENU CADASTROS
       
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)   // Clientes
        {
            cadCliente frmCliente = new cadCliente(TipoTab.Cadastro);
            frmCliente.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)   // Professores
        {
            cadProfessores frmProfessores = new cadProfessores(TipoTab.Cadastro);
            frmProfessores.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)   // Funcionários
        {
            cadFuncionario frmFuncionario = new cadFuncionario(TipoTab.Cadastro);
            frmFuncionario.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)   // Perfil
        {
            cadPerfil frmPerfil = new cadPerfil(TipoTab.Cadastro);
            frmPerfil.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)   // Curso
        {
            cadCurso frmCurso = new cadCurso();
            frmCurso.Show();
        }

        // MENU CONSULTAS
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadCliente frmCliente2 = new cadCliente(TipoTab.Consulta);
            //cadCliente frmCliente2 = new cadCliente();
            frmCliente2.Show();
        }

        private void professoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadProfessores frmProfessores2 = new cadProfessores(TipoTab.Consulta);
            frmProfessores2.Show();
        }

        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadFuncionario frmFuncionario2 = new cadFuncionario(TipoTab.Consulta);
            frmFuncionario2.Show();
        }

        private void perfilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadPerfil frmPerfil2 = new cadPerfil(TipoTab.Consulta);
            frmPerfil2.Show();
        }

        // BOTÕES DO TOPO DA TELA   
        
        // Backup do banco de dados
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (saveFileDialogBackup.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(saveFileDialogBackup.FileName))
                {
                    System.IO.File.Delete(saveFileDialogBackup.FileName);
                }

                System.IO.File.Copy(Application.StartupPath.ToString() + "\\BD-ECursos.accdb", saveFileDialogBackup.FileName);
                MessageBox.Show("Backup realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação abortada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Restauração do backup do banco de dados
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialogRestore.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("Deseja realmente restaurar o backup?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (System.IO.File.Exists(Application.StartupPath.ToString() + "\\BD-ECursos.accdb"))
                    {
                        System.IO.File.Delete(Application.StartupPath.ToString() + "\\BD-ECursos.accdb");
                    }

                    System.IO.File.Copy(openFileDialogRestore.FileName, Application.StartupPath.ToString() + "\\BD-ECursos.accdb");
                    MessageBox.Show("Backup restaurado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Restauração de backup cancelada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Operação abortada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // LOCAÇÃO  
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            cadLocacao frmLocacao = new cadLocacao();
            frmLocacao.Show();
        }

        // DEVOLUÇÃO
        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }
    }
} 

// implmentar para não mostrar o codigo do cadastro, so mostrar após salvar (para não ficar mostrando numero negativo)
//          ao clicar em novo não mostra e ao clicar em salvar mostra