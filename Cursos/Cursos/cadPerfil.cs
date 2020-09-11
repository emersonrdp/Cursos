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
    public partial class cadPerfil : Form
    {
        public cadPerfil(TipoTab tipoTab)
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

        private void perfilBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.idPerfilTextBox.Text = "-1";   // Devolver o valor "-1" para o campo, para que não de erro ao salvar o registro no banco de dados
                this.Validate();
                this.perfilBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                this.perfilTableAdapter.Fill(this.bDECursosDataSet.Perfil);   // Recarrega o formulario
                this.perfilBindingSource.MoveLast();   // mover para o ultimo cadastro
                MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadPerfil_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Perfil'. Você pode movê-la ou removê-la conforme necessário.
            this.perfilTableAdapter.Fill(this.bDECursosDataSet.Perfil);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();   /// fechar a janela de cadastro de perfil
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // implementação de pergunta para confirmação de exclusão de registro
            if (MessageBox.Show("Deseja excluir o registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // confirmando exclusão ele salva o registro pois o botão exclusão precisa que salve o registro para concluir a exclusão, desta forma já fica automatizado.
                this.Validate();
                this.perfilBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.perfilTableAdapter.Fill(this.bDECursosDataSet.Perfil);   // Recarrega o formulario
            }
            else
            {
                this.perfilTableAdapter.Fill(this.bDECursosDataSet.Perfil);   // Recarrega o formulario
                MessageBox.Show("Operação abortada.", "Abortada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxPesquisaPerfil_TextChanged(object sender, EventArgs e)
        {
            this.perfilTableAdapter.FillByPesquisaPerfil(bDECursosDataSet.Perfil, textBoxPesquisaPerfil.Text);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.idPerfilTextBox.Text = "";
        }
    }
}
