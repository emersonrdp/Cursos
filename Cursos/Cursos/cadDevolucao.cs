using Cursos.BDECursosDataSetTableAdapters;
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
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Curso'. Você pode movê-la ou removê-la conforme necessário.
            this.cursoTableAdapter.Fill(this.bDECursosDataSet.Curso);
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.ItemLocacao'. Você pode movê-la ou removê-la conforme necessário.
            //this.itemLocacaoTableAdapter.Fill(this.bDECursosDataSet.ItemLocacao);   // comentado para não carregar os dados no grid ao abrir o formulário, só vai mostrar ao selecionar o cliente

        }

        private void textBoxCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    ConsultaCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void ConsultaCliente()
        {
            int countUsuario = this.clienteTableAdapter.FillByIdCliente(this.bDECursosDataSet.Cliente, Convert.ToInt32(textBoxCodCliente.Text));

            if (countUsuario == 1)
            {
                textBoxNomeCliente.Text = this.bDECursosDataSet.Cliente.FindByidCliente(Convert.ToInt32(textBoxCodCliente.Text)).Nome;
                
                int countLocacoes = itemLocacaoTableAdapter.FillByIdCliente(this.bDECursosDataSet.ItemLocacao, Convert.ToInt32(textBoxCodCliente.Text));

                if (countLocacoes == 0)
                {
                    MessageBox.Show("O cliente '" + textBoxCodCliente.Text + " - " + textBoxNomeCliente.Text + "' não possui locações pendentes.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxCodCliente.Clear();
                    textBoxNomeCliente.Clear();
                }
            }
            else
            {
                textBoxNomeCliente.Clear();
                bDECursosDataSet.ItemLocacao.Clear();
                MessageBox.Show("O cliente " + textBoxCodCliente.Text + " não está cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCodCliente.Clear();
            }
        }

        private void bt_PesquisaCliente_Click(object sender, EventArgs e)
        {
            ConsultaCliente ConsCliente = new ConsultaCliente(this);   // o parametro this passa o endereço desse formlário qu srá rcebido no construtor e armazenado no atributo "devolucao"
            ConsCliente.Show();
        }

        public void setCodigoAndNomeCliente(int codigo, string nome)
        {
            textBoxCodCliente.Text = codigo.ToString();
            textBoxNomeCliente.Text = nome;
            ConsultaCliente();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btDevolver_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < itemLocacaoDataGridView.Rows.Count; i++)
            {
                if (bool.Parse(itemLocacaoDataGridView[0, i].EditedFormattedValue.ToString()))
                {
                    itemLocacaoDataGridView[4, i].Value = dateTimePickerDataDevolucao.Value;
                }
            }

            itemLocacaoBindingSource.EndEdit();   // Salva os dados das alterações realizadas no dataSet
            itemLocacaoTableAdapter.Update(this.bDECursosDataSet.ItemLocacao);   // Salva as alterações no banco de dados
            MessageBox.Show("Devolução realizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
