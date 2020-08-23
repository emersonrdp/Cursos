namespace Cursos
{
    partial class cadCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descCursoLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label idProfessorLabel;
            System.Windows.Forms.Label idCursoLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadCurso));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cursoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDECursosDataSet = new Cursos.BDECursosDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cursoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.idCursoTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.descCursoTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tituloTextBox1 = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3ImagemCapa = new System.Windows.Forms.TabPage();
            this.btLimparImagem = new System.Windows.Forms.Button();
            this.textBoxImagem = new System.Windows.Forms.TextBox();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.btAbrirImagem = new System.Windows.Forms.Button();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            this.cursoTableAdapter = new Cursos.BDECursosDataSetTableAdapters.CursoTableAdapter();
            this.tableAdapterManager = new Cursos.BDECursosDataSetTableAdapters.TableAdapterManager();
            this.comboBoxIdProfessor = new System.Windows.Forms.ComboBox();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorTableAdapter = new Cursos.BDECursosDataSetTableAdapters.ProfessorTableAdapter();
            descCursoLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            idProfessorLabel = new System.Windows.Forms.Label();
            idCursoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingNavigator)).BeginInit();
            this.cursoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPage3ImagemCapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descCursoLabel
            // 
            descCursoLabel.AutoSize = true;
            descCursoLabel.Location = new System.Drawing.Point(52, 149);
            descCursoLabel.Name = "descCursoLabel";
            descCursoLabel.Size = new System.Drawing.Size(103, 13);
            descCursoLabel.TabIndex = 6;
            descCursoLabel.Text = "Descrição do Curso:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(52, 123);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 4;
            tituloLabel.Text = "Titulo:";
            // 
            // idProfessorLabel
            // 
            idProfessorLabel.AutoSize = true;
            idProfessorLabel.Location = new System.Drawing.Point(52, 97);
            idProfessorLabel.Name = "idProfessorLabel";
            idProfessorLabel.Size = new System.Drawing.Size(105, 13);
            idProfessorLabel.TabIndex = 2;
            idProfessorLabel.Text = "Código do Professor:";
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(52, 71);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(94, 13);
            idCursoLabel.TabIndex = 0;
            idCursoLabel.Text = "Código do Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 13);
            label1.TabIndex = 10;
            label1.Text = "Comentarios do curso:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3ImagemCapa);
            this.tabControl1.Location = new System.Drawing.Point(28, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 397);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxIdProfessor);
            this.tabPage1.Controls.Add(this.cursoBindingNavigator);
            this.tabPage1.Controls.Add(this.btCadastrar);
            this.tabPage1.Controls.Add(idCursoLabel);
            this.tabPage1.Controls.Add(this.btCancelar);
            this.tabPage1.Controls.Add(this.idCursoTextBox);
            this.tabPage1.Controls.Add(idProfessorLabel);
            this.tabPage1.Controls.Add(tituloLabel);
            this.tabPage1.Controls.Add(this.tituloTextBox);
            this.tabPage1.Controls.Add(descCursoLabel);
            this.tabPage1.Controls.Add(this.descCursoTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cursoBindingNavigator
            // 
            this.cursoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cursoBindingNavigator.BindingSource = this.cursoBindingSource;
            this.cursoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cursoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cursoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cursoBindingNavigatorSaveItem});
            this.cursoBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.cursoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cursoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cursoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cursoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cursoBindingNavigator.Name = "cursoBindingNavigator";
            this.cursoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cursoBindingNavigator.Size = new System.Drawing.Size(732, 25);
            this.cursoBindingNavigator.TabIndex = 10;
            this.cursoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.bDECursosDataSet;
            // 
            // bDECursosDataSet
            // 
            this.bDECursosDataSet.DataSetName = "BDECursosDataSet";
            this.bDECursosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cursoBindingNavigatorSaveItem
            // 
            this.cursoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cursoBindingNavigatorSaveItem.Image")));
            this.cursoBindingNavigatorSaveItem.Name = "cursoBindingNavigatorSaveItem";
            this.cursoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cursoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cursoBindingNavigatorSaveItem.Click += new System.EventHandler(this.cursoBindingNavigatorSaveItem_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(564, 312);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(106, 35);
            this.btCadastrar.TabIndex = 1;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.cursoBindingNavigatorSaveItem_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(439, 312);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 35);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "idCurso", true));
            this.idCursoTextBox.Location = new System.Drawing.Point(162, 68);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.ReadOnly = true;
            this.idCursoTextBox.Size = new System.Drawing.Size(508, 20);
            this.idCursoTextBox.TabIndex = 1;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(162, 120);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(508, 20);
            this.tituloTextBox.TabIndex = 5;
            // 
            // descCursoTextBox
            // 
            this.descCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "DescCurso", true));
            this.descCursoTextBox.Location = new System.Drawing.Point(162, 146);
            this.descCursoTextBox.Name = "descCursoTextBox";
            this.descCursoTextBox.Size = new System.Drawing.Size(508, 20);
            this.descCursoTextBox.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tituloTextBox1);
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.Controls.Add(label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comentários";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tituloTextBox1
            // 
            this.tituloTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Titulo", true));
            this.tituloTextBox1.Location = new System.Drawing.Point(154, 47);
            this.tituloTextBox1.Name = "tituloTextBox1";
            this.tituloTextBox1.ReadOnly = true;
            this.tituloTextBox1.Size = new System.Drawing.Size(526, 20);
            this.tituloTextBox1.TabIndex = 13;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.cursoBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(732, 25);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Adicionar novo";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de itens";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Excluir";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Mover primeiro";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posição";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posição atual";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Mover próximo";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Salvar Dados";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Comentario", true));
            this.textBox1.Location = new System.Drawing.Point(39, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(641, 224);
            this.textBox1.TabIndex = 11;
            // 
            // tabPage3ImagemCapa
            // 
            this.tabPage3ImagemCapa.AutoScroll = true;
            this.tabPage3ImagemCapa.Controls.Add(this.btLimparImagem);
            this.tabPage3ImagemCapa.Controls.Add(this.textBoxImagem);
            this.tabPage3ImagemCapa.Controls.Add(this.pictureBoxImagem);
            this.tabPage3ImagemCapa.Controls.Add(this.btAbrirImagem);
            this.tabPage3ImagemCapa.Location = new System.Drawing.Point(4, 22);
            this.tabPage3ImagemCapa.Name = "tabPage3ImagemCapa";
            this.tabPage3ImagemCapa.Size = new System.Drawing.Size(738, 371);
            this.tabPage3ImagemCapa.TabIndex = 2;
            this.tabPage3ImagemCapa.Text = "Imagem da Capa";
            this.tabPage3ImagemCapa.UseVisualStyleBackColor = true;
            // 
            // btLimparImagem
            // 
            this.btLimparImagem.Location = new System.Drawing.Point(583, 59);
            this.btLimparImagem.Name = "btLimparImagem";
            this.btLimparImagem.Size = new System.Drawing.Size(99, 23);
            this.btLimparImagem.TabIndex = 19;
            this.btLimparImagem.Text = "Limpar Imagem";
            this.btLimparImagem.UseVisualStyleBackColor = true;
            this.btLimparImagem.Click += new System.EventHandler(this.btLimparImagem_Click);
            // 
            // textBoxImagem
            // 
            this.textBoxImagem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "ImagemDaCapa", true));
            this.textBoxImagem.Location = new System.Drawing.Point(40, 32);
            this.textBoxImagem.Name = "textBoxImagem";
            this.textBoxImagem.ReadOnly = true;
            this.textBoxImagem.Size = new System.Drawing.Size(525, 20);
            this.textBoxImagem.TabIndex = 18;
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Location = new System.Drawing.Point(102, 78);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(389, 250);
            this.pictureBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagem.TabIndex = 15;
            this.pictureBoxImagem.TabStop = false;
            // 
            // btAbrirImagem
            // 
            this.btAbrirImagem.Location = new System.Drawing.Point(583, 30);
            this.btAbrirImagem.Name = "btAbrirImagem";
            this.btAbrirImagem.Size = new System.Drawing.Size(99, 23);
            this.btAbrirImagem.TabIndex = 14;
            this.btAbrirImagem.Text = "Abrir Imagem";
            this.btAbrirImagem.UseVisualStyleBackColor = true;
            this.btAbrirImagem.Click += new System.EventHandler(this.btAbrirImagem_Click);
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.FileName = "openFileDialog1";
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CursoTableAdapter = this.cursoTableAdapter;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ItemLocacaoTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.ProfessorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cursos.BDECursosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBoxIdProfessor
            // 
            this.comboBoxIdProfessor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cursoBindingSource, "idProfessor", true));
            this.comboBoxIdProfessor.DataSource = this.professorBindingSource;
            this.comboBoxIdProfessor.DisplayMember = "Nome";
            this.comboBoxIdProfessor.FormattingEnabled = true;
            this.comboBoxIdProfessor.Location = new System.Drawing.Point(162, 93);
            this.comboBoxIdProfessor.Name = "comboBoxIdProfessor";
            this.comboBoxIdProfessor.Size = new System.Drawing.Size(508, 21);
            this.comboBoxIdProfessor.TabIndex = 11;
            this.comboBoxIdProfessor.ValueMember = "idProfessor";
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            this.professorBindingSource.DataSource = this.bDECursosDataSet;
            // 
            // professorTableAdapter
            // 
            this.professorTableAdapter.ClearBeforeFill = true;
            // 
            // cadCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cursos";
            this.Load += new System.EventHandler(this.cadCurso_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingNavigator)).EndInit();
            this.cursoBindingNavigator.ResumeLayout(false);
            this.cursoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPage3ImagemCapa.ResumeLayout(false);
            this.tabPage3ImagemCapa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3ImagemCapa;
        private BDECursosDataSet bDECursosDataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private BDECursosDataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private BDECursosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cursoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cursoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCursoTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox descCursoTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Button btAbrirImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagem;
        private System.Windows.Forms.TextBox textBoxImagem;
        private System.Windows.Forms.TextBox tituloTextBox1;
        private System.Windows.Forms.Button btLimparImagem;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ComboBox comboBoxIdProfessor;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private BDECursosDataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
    }
}