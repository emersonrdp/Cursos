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
    public partial class cadDevolucao : Form
    {
        public cadDevolucao()
        {
            InitializeComponent();
        }

        private void itemLocacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemLocacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);

        }

        private void cadDevolucao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.ItemLocacao'. Você pode movê-la ou removê-la conforme necessário.
            //this.itemLocacaoTableAdapter.Fill(this.bDECursosDataSet.ItemLocacao);   // comentado para não carregar os dados no grid ao abrir o formulário, só vai mostrar ao selecionar o cliente

        }

        private void textBoxCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int countUsuario;

                if (e.KeyChar == 13)
                {
                    countUsuario = this.clienteTableAdapter.FillByIdCliente(this.bDECursosDataSet.Cliente, Convert.ToInt32(textBoxCodCliente.Text));

                    if (countUsuario == 1)
                    {
                        textBoxNomeCliente.Text = this.bDECursosDataSet.Cliente.FindByidCliente(Convert.ToInt32(textBoxCodCliente.Text)).Nome;
                        itemLocacaoTableAdapter.FillByIdCliente(this.bDECursosDataSet.ItemLocacao, Convert.ToInt32(textBoxCodCliente.Text));
                    }
                    else
                    {
                        textBoxNomeCliente.Clear();
                        bDECursosDataSet.ItemLocacao.Clear();
                        MessageBox.Show("O cliente " + textBoxCodCliente.Text + " não está cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxCodCliente.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
