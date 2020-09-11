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
            try
            {
                this.idCursoTextBox.Text = "-1";   // Devolver o valor "-1" para o campo, para que não de erro ao salvar o registro no banco de dados
                this.Validate();
                this.cursoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                this.cursoTableAdapter.Fill(this.bDECursosDataSet.Curso);   // Recarrega o formulário
                this.cursoBindingSource.MoveLast();   // mover para o ultimo cadastro
                MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Professor'. Você pode movê-la ou removê-la conforme necessário.
            this.professorTableAdapter.Fill(this.bDECursosDataSet.Professor);
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Curso'. Você pode movê-la ou removê-la conforme necessário.
            this.cursoTableAdapter.Fill(this.bDECursosDataSet.Curso);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();   /// fechar a janela de cadastro de cursos
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
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cursoTableAdapter.Fill(this.bDECursosDataSet.Curso);   // Recarrega o formulário
            }
            else
            {
                this.cursoTableAdapter.Fill(this.bDECursosDataSet.Curso);   // Recarrega o formulario
                MessageBox.Show("Operação abortada.", "Abortada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btAbrirImagem_Click(object sender, EventArgs e)   // botão para abrir a imagem de capa do curso
        {
            if (Convert.ToInt32(idCursoTextBox.Text) > 0)
            {
                if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(openFileDialogImagem.FileName);   // cria uma classe com a imagem aberta
                    Bitmap bmp2 = new Bitmap(bmp, pictureBoxImagem.Size);   // cria nova classe com o tamanho do pictureBox

                    pictureBoxImagem.Image = bmp2;   // carrega a imagem no PictureBox

                    // Salva a Imagem da capa na pasta dentro da pasta da aplicação.
                    // Application.StartupPath -> comando para indicar a pasta onde o programa foi instalado
                    pictureBoxImagem.Image.Save(Application.StartupPath.ToString() + "\\CapasCursos\\" + idCursoTextBox.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    
                    // Salva o caminho no TextBox
                    textBoxImagem.Text = Application.StartupPath.ToString() + "\\CapasCursos\\" + idCursoTextBox.Text + ".png";
                    
                    // Salva o registro
                    this.Validate();
                    this.cursoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                }
            }
            else
            {
                MessageBox.Show("Salve o cadastro do livro para depois carregar a imagem da capa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void toolStripButton7_Click(object sender, EventArgs e)   // Salvar comentário
        {
            this.Validate();
            this.cursoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
            MessageBox.Show("Comentário salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // carregar imagem do curso no picture box ao clicar na aba "Imagem da capa" caso a imagem já esteja gravada no textBoxImagem
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxImagem.Text != "" && textBoxImagem.Text != null)
            {
                pictureBoxImagem.Load(textBoxImagem.Text);
            }
            else
            {
                pictureBoxImagem.ImageLocation = Application.StartupPath.ToString() + "\\CapasCursos\\" + "SemCapa.png";
            }
        }

        private void btLimparImagem_Click(object sender, EventArgs e)   // Botão Limpar Imagem da capa
        {
            try
            {
                if (MessageBox.Show("Deseja realmente limpar a imagem?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pictureBoxImagem.ImageLocation = Application.StartupPath.ToString() + "\\CapasCursos\\" + "SemCapa.png";

                    if (textBoxImagem.Text != "")
                    {
                        if (System.IO.File.Exists(textBoxImagem.Text))
                        {
                            pictureBoxImagem.Dispose();   // limpar a imagem para não dar erro informando qu ela está em uso
                            System.IO.File.Delete(textBoxImagem.Text);
                        }

                        textBoxImagem.Text = "";

                        // Salva o registro
                        this.Validate();
                        this.cursoBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao limpar a imagem da capa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.idCursoTextBox.Text = "";
        }
    }
}