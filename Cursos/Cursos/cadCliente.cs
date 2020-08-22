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
    public partial class cadCliente : Form
    {
        public cadCliente(TipoTab tipoTab)
        {
            InitializeComponent();
            if (tipoTab == TipoTab.Consulta)   // controle da abertura da tela na aba cadastro ou consulta
            {
                tabControlCliente.SelectedTab = tabPageConsulta;
            }
            else
            {
                tabControlCliente.SelectedTab = tabPageCadastro;
            }
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);   // Recarrega o formulário
                this.clienteBindingSource.MoveLast();   // mover para o ultimo cadastro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro: " + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();   /// fechar a janela de cadastro de clientes
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // implementação de pergunta para confirmação de exclusão de registro
            if (MessageBox.Show("Deseja excluir o registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // confirmando exclusão ele salva o registro pois o botão exclusão precisa que salve o registro para concluir a exclusão, desta forma já fica automatizado.
                this.Validate();
                this.clienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);   // Recarrega o formulário
            }
            else
            {
                this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);   // Recarrega o formulario
                MessageBox.Show("Operação abortada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByPesquisaCliente(bDECursosDataSet.Cliente, textBoxPesquisaCliente.Text);
        }
    }
}