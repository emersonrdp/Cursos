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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Enabled = false;   // desabilitar o carregador da página
                login frmLogin = new login();   // criar um novo login para abrir a tela de login
                frmLogin.Show();   // exibir o formulário
                this.Visible = false;
            }
        }
    }
}
