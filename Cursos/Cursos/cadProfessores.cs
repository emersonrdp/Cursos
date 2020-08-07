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
    public partial class cadProfessores : Form
    {
        public cadProfessores()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();   /// fechar a janela de cadastro de professores
        }

        private void professorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);

        }

        private void cadProfessores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Professor'. Você pode movê-la ou removê-la conforme necessário.
            this.professorTableAdapter.Fill(this.bDECursosDataSet.Professor);

        }

        private void professorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.professorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
            MessageBox.Show("Registro Salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            else
            {
                this.professorTableAdapter.Fill(this.bDECursosDataSet.Professor);   // exibe novamente o formulario
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
            MessageBox.Show("Registro Salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
