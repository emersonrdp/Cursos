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
    public partial class cadCurso : Form
    {
        public cadCurso()
        {
            InitializeComponent();
        }

        private void cursoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);

        }

        private void cadCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Curso'. Você pode movê-la ou removê-la conforme necessário.
            this.cursoTableAdapter.Fill(this.bDECursosDataSet.Curso);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();   /// fechar a janela de cadastro de cursos
        }

        private void cursoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cursoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
            MessageBox.Show("Registro Salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursoBindingSource.EndEdit();
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
                this.cursoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
            }
            else
            {
                this.cursoTableAdapter.Fill(this.bDECursosDataSet.Curso);   // exibe novamente o formulario
            }
        }
    }
}