namespace Cursos
{
    partial class cadFuncionario
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
            System.Windows.Forms.Label idFuncionarioLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label situacaoLabel;
            System.Windows.Forms.Label idPerfilLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadFuncionario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmeSenhaTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxIdPerfil = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDECursosDataSet = new Cursos.BDECursosDataSet();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.funcionarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.idFuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.situacaoCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.funcionarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPesquisaFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.funcionarioTableAdapter = new Cursos.BDECursosDataSetTableAdapters.FuncionarioTableAdapter();
            this.tableAdapterManager = new Cursos.BDECursosDataSetTableAdapters.TableAdapterManager();
            this.perfilTableAdapter = new Cursos.BDECursosDataSetTableAdapters.PerfilTableAdapter();
            idFuncionarioLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            situacaoLabel = new System.Windows.Forms.Label();
            idPerfilLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).BeginInit();
            this.funcionarioBindingNavigator.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idFuncionarioLabel
            // 
            idFuncionarioLabel.AutoSize = true;
            idFuncionarioLabel.Location = new System.Drawing.Point(48, 67);
            idFuncionarioLabel.Name = "idFuncionarioLabel";
            idFuncionarioLabel.Size = new System.Drawing.Size(43, 13);
            idFuncionarioLabel.TabIndex = 0;
            idFuncionarioLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(48, 93);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(48, 119);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Login:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(48, 145);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 6;
            senhaLabel.Text = "Senha:";
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Location = new System.Drawing.Point(48, 173);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(52, 13);
            situacaoLabel.TabIndex = 18;
            situacaoLabel.Text = "Situacao:";
            // 
            // idPerfilLabel
            // 
            idPerfilLabel.AutoSize = true;
            idPerfilLabel.Location = new System.Drawing.Point(48, 201);
            idPerfilLabel.Name = "idPerfilLabel";
            idPerfilLabel.Size = new System.Drawing.Size(44, 13);
            idPerfilLabel.TabIndex = 10;
            idPerfilLabel.Text = "id Perfil:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 401);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.confirmeSenhaTextBox);
            this.tabPage1.Controls.Add(this.comboBoxIdPerfil);
            this.tabPage1.Controls.Add(this.funcionarioBindingNavigator);
            this.tabPage1.Controls.Add(this.btCadastrar);
            this.tabPage1.Controls.Add(this.btCancelar);
            this.tabPage1.Controls.Add(idFuncionarioLabel);
            this.tabPage1.Controls.Add(this.idFuncionarioTextBox);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Controls.Add(loginLabel);
            this.tabPage1.Controls.Add(this.loginTextBox);
            this.tabPage1.Controls.Add(senhaLabel);
            this.tabPage1.Controls.Add(this.senhaTextBox);
            this.tabPage1.Controls.Add(situacaoLabel);
            this.tabPage1.Controls.Add(this.situacaoCheckBox);
            this.tabPage1.Controls.Add(idPerfilLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Confirme";
            // 
            // confirmeSenhaTextBox
            // 
            this.confirmeSenhaTextBox.Location = new System.Drawing.Point(426, 142);
            this.confirmeSenhaTextBox.Name = "confirmeSenhaTextBox";
            this.confirmeSenhaTextBox.Size = new System.Drawing.Size(246, 20);
            this.confirmeSenhaTextBox.TabIndex = 8;
            this.confirmeSenhaTextBox.UseSystemPasswordChar = true;
            // 
            // comboBoxIdPerfil
            // 
            this.comboBoxIdPerfil.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "idPerfil", true));
            this.comboBoxIdPerfil.DataSource = this.perfilBindingSource;
            this.comboBoxIdPerfil.DisplayMember = "Nome";
            this.comboBoxIdPerfil.FormattingEnabled = true;
            this.comboBoxIdPerfil.Location = new System.Drawing.Point(106, 198);
            this.comboBoxIdPerfil.Name = "comboBoxIdPerfil";
            this.comboBoxIdPerfil.Size = new System.Drawing.Size(566, 21);
            this.comboBoxIdPerfil.TabIndex = 11;
            this.comboBoxIdPerfil.ValueMember = "idPerfil";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.bDECursosDataSet;
            // 
            // bDECursosDataSet
            // 
            this.bDECursosDataSet.DataSetName = "BDECursosDataSet";
            this.bDECursosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "Perfil";
            this.perfilBindingSource.DataSource = this.bDECursosDataSet;
            // 
            // funcionarioBindingNavigator
            // 
            this.funcionarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionarioBindingNavigator.BindingSource = this.funcionarioBindingSource;
            this.funcionarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.funcionarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.funcionarioBindingNavigatorSaveItem});
            this.funcionarioBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.funcionarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funcionarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funcionarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funcionarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funcionarioBindingNavigator.Name = "funcionarioBindingNavigator";
            this.funcionarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionarioBindingNavigator.Size = new System.Drawing.Size(732, 25);
            this.funcionarioBindingNavigator.TabIndex = 13;
            this.funcionarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // funcionarioBindingNavigatorSaveItem
            // 
            this.funcionarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioBindingNavigatorSaveItem.Image")));
            this.funcionarioBindingNavigatorSaveItem.Name = "funcionarioBindingNavigatorSaveItem";
            this.funcionarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.funcionarioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.funcionarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionarioBindingNavigatorSaveItem_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(566, 314);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(106, 35);
            this.btCadastrar.TabIndex = 13;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.funcionarioBindingNavigatorSaveItem_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(441, 314);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 35);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // idFuncionarioTextBox
            // 
            this.idFuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "idFuncionario", true));
            this.idFuncionarioTextBox.Location = new System.Drawing.Point(106, 64);
            this.idFuncionarioTextBox.Name = "idFuncionarioTextBox";
            this.idFuncionarioTextBox.ReadOnly = true;
            this.idFuncionarioTextBox.Size = new System.Drawing.Size(566, 20);
            this.idFuncionarioTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(106, 90);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(566, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(106, 116);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(566, 20);
            this.loginTextBox.TabIndex = 5;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(106, 142);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(246, 20);
            this.senhaTextBox.TabIndex = 7;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // situacaoCheckBox
            // 
            this.situacaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.funcionarioBindingSource, "Situacao", true));
            this.situacaoCheckBox.Location = new System.Drawing.Point(106, 168);
            this.situacaoCheckBox.Name = "situacaoCheckBox";
            this.situacaoCheckBox.Size = new System.Drawing.Size(566, 24);
            this.situacaoCheckBox.TabIndex = 9;
            this.situacaoCheckBox.Text = "Ativo / Inativo";
            this.situacaoCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.funcionarioDataGridView);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // funcionarioDataGridView
            // 
            this.funcionarioDataGridView.AutoGenerateColumns = false;
            this.funcionarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.funcionarioDataGridView.DataSource = this.funcionarioBindingSource;
            this.funcionarioDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.funcionarioDataGridView.Location = new System.Drawing.Point(3, 105);
            this.funcionarioDataGridView.Name = "funcionarioDataGridView";
            this.funcionarioDataGridView.Size = new System.Drawing.Size(732, 267);
            this.funcionarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idFuncionario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "Código do funcionário";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 470;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn3.HeaderText = "Login";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Situacao";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Situacao";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxPesquisaFuncionario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 42);
            this.panel1.TabIndex = 0;
            // 
            // textBoxPesquisaFuncionario
            // 
            this.textBoxPesquisaFuncionario.Location = new System.Drawing.Point(175, 10);
            this.textBoxPesquisaFuncionario.Name = "textBoxPesquisaFuncionario";
            this.textBoxPesquisaFuncionario.Size = new System.Drawing.Size(538, 20);
            this.textBoxPesquisaFuncionario.TabIndex = 1;
            this.textBoxPesquisaFuncionario.TextChanged += new System.EventHandler(this.textBoxPesquisaFuncionario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o nome do funcionario";
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.ItemLocacaoTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.ProfessorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cursos.BDECursosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // cadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionarios";
            this.Load += new System.EventHandler(this.cadFuncionario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).EndInit();
            this.funcionarioBindingNavigator.ResumeLayout(false);
            this.funcionarioBindingNavigator.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btCancelar;
        private BDECursosDataSet bDECursosDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private BDECursosDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private BDECursosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton funcionarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idFuncionarioTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox situacaoCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPesquisaFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView funcionarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ComboBox comboBoxIdPerfil;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private BDECursosDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmeSenhaTextBox;
    }
}