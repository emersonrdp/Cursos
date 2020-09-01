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
    public partial class cadLocacao : Form
    {
        bool flagSalvar = false;

        public cadLocacao()
        {
            InitializeComponent();
        }

        private void AlteraData()
        {
            dataSaidaDateTimePicker.Text = DateTime.Now.ToShortDateString();
            horaDateTimePicker.Text = DateTime.Now.ToShortTimeString();
            dataDevolucaoDateTimePicker.Text = DateTime.Now.AddMonths(1).ToShortDateString();
        }

        private void locacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if ((idClienteTextBox.Text != "") && (comboBoxNomeCliente.Text != ""))
            {
                if (itemLocacaoDataGridView.RowCount > 1)
                {
                    this.Validate();
                    this.locacaoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                    MessageBox.Show("Locação salva com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flagSalvar = true;
                }
                else
                {
                    MessageBox.Show("Informe o curso que será locado antes de finalizar a locação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flagSalvar = false;
                }
            }
            else
            {
                MessageBox.Show("Informe o cliente antes de finalizar a locação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flagSalvar = false;
            }
        }

        private void cadLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Curso'. Você pode movê-la ou removê-la conforme necessário.
            this.cursoTableAdapter.Fill(this.bDECursosDataSet.Curso);
            this.locacaoBindingSource.AddNew();   // Adicionar um novo registro
            AlteraData();

            // Salva o formulario
            this.Validate();
            this.locacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);

            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.ItemLocacao'. Você pode movê-la ou removê-la conforme necessário.
            this.itemLocacaoTableAdapter.Fill(this.bDECursosDataSet.ItemLocacao);
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.Fill(this.bDECursosDataSet.Locacao);

            this.locacaoBindingSource.MoveLast();   // Mover para o ultimo registro após carregar o formulário
        }

        // -------------------------------------------------------------------------------- //

        private void buttonExcluirCurso_Click(object sender, EventArgs e)   //Botão Remover Curso 
        {
            try
            {
                this.locacaoItemLocacaoBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void buttonAddCurso_Click(object sender, EventArgs e)   //Botão Adicionar Curso
        {
            int idx;
            bool flag = false;

            try
            {
                if (textBoxCodCurso.Text == "")
                {
                    MessageBox.Show("Informe o código do curso antes de clicar no botão adicionar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    idx = this.cursoTableAdapter.FillByIdCurso(bDECursosDataSet.Curso, Convert.ToInt32(textBoxCodCurso.Text));   // Verifica se o curso existe
                    this.cursoTableAdapter.Fill(bDECursosDataSet.Curso);   // Recarrega a tabela após fazer o filtro

                    if (idx == 1)
                    {
                        string tituloCurso = this.bDECursosDataSet.Curso.FindByidCurso(Convert.ToInt32(textBoxCodCurso.Text)).Titulo;   // Joga o título do curso de acordo com o id passado e joga na variável para fazer a comparação

                        // Verifica sw o curso ja foi inserido no grid para não dixar colocar o mesmo curso mais de uma vez. Percorre o grid verificando pelo curso utilizando uma flag para indicar se o curso está no grid.
                        for (int i = 0; i < itemLocacaoDataGridView.RowCount; i++)
                        {
                            if (itemLocacaoDataGridView[2, i].EditedFormattedValue.ToString() == tituloCurso)
                            {
                                flag = true;
                                break;
                            }
                        }

                        if (flag)
                        {
                            MessageBox.Show("O curso já está na cesta de compra.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Inclui o curso na cesta
                            this.bDECursosDataSet.ItemLocacao.Rows.Add(null, Convert.ToInt32(idLocacaoTextBox.Text), Convert.ToInt32(textBoxCodCurso.Text), null);
                        }

                    }
                    else
                    {
                        MessageBox.Show("O Curso não foi encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBoxCodCurso.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        // -------------------------------------------------------------------------------- //

        private void btCancelar_Click(object sender, EventArgs e)   //Botão Cancelar
        {
            this.Dispose();
        }

        // Essa rotina não esta em uso porque o navigator está invisível
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AlteraData();
        }

        // -------------------------------------------------------------------------------- //

        private void idClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    comboBoxNomeCliente.SelectedValue = idClienteTextBox.Text;

                    if (comboBoxNomeCliente.Text == "")
                    {
                        MessageBox.Show("Cliente não cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        idClienteTextBox.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        // Alimentação do Combobox com nome do ciente
        private void comboBoxNomeCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idClienteTextBox.Text = comboBoxNomeCliente.SelectedValue.ToString();
        }

        // -------------------------------------------------------------------------------- //

        private void textBoxCodCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            int idx;
            bool flag = false;

            try
            {
                if (e.KeyChar == 13)
                {
                    idx = this.cursoTableAdapter.FillByIdCurso(bDECursosDataSet.Curso, Convert.ToInt32(textBoxCodCurso.Text));   // Verifica se o curso existe
                    this.cursoTableAdapter.Fill(bDECursosDataSet.Curso);   // Recarrega a tabela após fazer o filtro

                    if (idx == 1)
                    {
                        string tituloCurso = this.bDECursosDataSet.Curso.FindByidCurso(Convert.ToInt32(textBoxCodCurso.Text)).Titulo;   // Joga o título do curso de acordo com o id passado e joga na variável para fazer a comparação

                        // Verifica sw o curso ja foi inserido no grid para não dixar colocar o mesmo curso mais de uma vez. Percorre o grid verificando pelo curso utilizando uma flag para indicar se o curso está no grid.
                        for (int i = 0; i < itemLocacaoDataGridView.RowCount; i++)
                        {
                            if (itemLocacaoDataGridView[2,i].EditedFormattedValue.ToString() == tituloCurso)
                            {
                                flag = true;
                                break;
                            }
                        }

                        if (flag)
                        {
                            MessageBox.Show("O curso já está na cesta de compra.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Inclui o curso na cesta
                            this.bDECursosDataSet.ItemLocacao.Rows.Add(null, Convert.ToInt32(idLocacaoTextBox.Text), Convert.ToInt32(textBoxCodCurso.Text), null);
                        }
                        textBoxCodCurso.Clear();
                    }
                    else
                    {
                        MessageBox.Show("O Curso não foi encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxCodCurso.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        // Implementar Botão novo
        private void btNovo_Click(object sender, EventArgs e)
        {
            // Salva os dados antes de gerar novo, mesmo que o cliente aborte. Implementado dessa forma para que não ocorra erro referente a dados do grid não salvos.
            locacaoBindingNavigatorSaveItem_Click(sender, e);
            if (flagSalvar)   // a flagSalvar só será true se o formulario for salvo.
            {
                if (MessageBox.Show("Deseja realmente gerar uma nova Locação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cadLocacao_Load(sender, e);
                    AlteraData();
                    flagSalvar = false;
                }
                else
                {
                    // Recarrega o formulario
                    this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);
                    this.itemLocacaoTableAdapter.Fill(this.bDECursosDataSet.ItemLocacao);
                    this.locacaoTableAdapter.Fill(this.bDECursosDataSet.Locacao);
                    this.cursoTableAdapter.Fill(this.bDECursosDataSet.Curso);
                    // Mover para o ultimo registro após carregar o formulário
                    this.locacaoBindingSource.MoveLast();
                    MessageBox.Show("Operação abortada.", "Abortada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
           }
            else
            {
                MessageBox.Show("Salve a locação antes de gerar uma nova.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // -------------------------------------------------------------------------------- //
    }
}