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
    public partial class cadProfessores : Form
    {
        public cadProfessores(TipoTab tipoTab)
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();   /// fechar a janela de cadastro de professores
        }

        private void professorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.professorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.professorTableAdapter.Fill(this.bDECursosDataSet.Professor);   // Recarrega o formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro: " + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadProfessores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Professor'. Você pode movê-la ou removê-la conforme necessário.
            this.professorTableAdapter.Fill(this.bDECursosDataSet.Professor);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // implementação de pergunta para confirmação de exclusão de registro
            if (MessageBox.Show("Deseja excluir o registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // confirmando exclusão ele salva o registro pois o botão exclusão precisa que salve o registro para concluir a exclusão, desta forma já fica automatizado.
                this.Validate();
                this.professorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.professorTableAdapter.Fill(this.bDECursosDataSet.Professor);   // Recarrega o formulario
            }
            else
            {
                this.professorTableAdapter.Fill(this.bDECursosDataSet.Professor);   // Recarrega o formulario
                MessageBox.Show("Operação abortada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxPesquisaProfessor_TextChanged(object sender, EventArgs e)
        {
            this.professorTableAdapter.FillByPesquisaProfessor(bDECursosDataSet.Professor, textBoxPesquisaProfessor.Text);
        }
    }
}
