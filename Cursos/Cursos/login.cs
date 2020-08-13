using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursos
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            //int resultado = funcionarioTableAdapter.FillBylogin(bDECursosDataSet, textBoxUsuario, textBoxSenha);
            //if (resultado = 1)
            if (textBoxUsuario.Text == "Emerson" && textBoxSenha.Text == "123")
            {
                Principal frmPrincipal = new Principal();   // criar um novo login para abrir a tela de login
                frmPrincipal.Show();   // exibir o formulário
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Ocorreu um erro ao fazer o login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);

        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bDECursosDataSet.Funcionario);

        }
    }
}
