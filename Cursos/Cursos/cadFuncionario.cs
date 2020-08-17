using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cursos.Principal;

namespace Cursos
{
    public partial class cadFuncionario : Form
    {
        public cadFuncionario(TipoTab tipoTab)
        {
            InitializeComponent();
            if (tipoTab == TipoTab.Consulta)   // controle da abertura da tela na aba cadastro ou consulta
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else 
            {
                tabControl1.SelectedTab = tabPage1;   // aba cadastro
            }
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.funcionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro: " + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bDECursosDataSet.Funcionario);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();   /// fechar a janela de cadastro de funcionarios
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // implementação de pergunta para confirmação de exclusão de registro
            if (MessageBox.Show("Deseja excluir o registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // confirmando exclusão ele salva o registro pois o botão exclusão precisa que salve o registro para concluir a exclusão, desta forma já fica automatizado.
                this.Validate();
                this.funcionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
            }
            else
            {
                this.funcionarioTableAdapter.Fill(this.bDECursosDataSet.Funcionario);   // exibe novamente o formulario
            }
        }

        private void textBoxPesquisaCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisaFuncionario_TextChanged(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.FillByPesquisaFuncionario(bDECursosDataSet.Funcionario, textBoxPesquisaFuncionario.Text);
        }
    }
}