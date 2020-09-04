namespace Cursos
{
    partial class cadLocacao
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
            System.Windows.Forms.Label idLocacaoLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idFuncionarioLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label dataSaidaLabel;
            System.Windows.Forms.Label dataEntregaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadLocacao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNomeCliente = new System.Windows.Forms.ComboBox();
            this.locacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDECursosDataSet = new Cursos.BDECursosDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLocacaoTextBox = new System.Windows.Forms.TextBox();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.idFuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.horaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataDevolucaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.locacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.itemLocacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locacaoItemLocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemLocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodCurso = new System.Windows.Forms.TextBox();
            this.buttonExcluirCurso = new System.Windows.Forms.Button();
            this.buttonAddCurso = new System.Windows.Forms.Button();
            this.clienteLocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btNovo = new System.Windows.Forms.Button();
            this.locacaoTableAdapter = new Cursos.BDECursosDataSetTableAdapters.LocacaoTableAdapter();
            this.tableAdapterManager = new Cursos.BDECursosDataSetTableAdapters.TableAdapterManager();
            this.itemLocacaoTableAdapter = new Cursos.BDECursosDataSetTableAdapters.ItemLocacaoTableAdapter();
            this.clienteTableAdapter = new Cursos.BDECursosDataSetTableAdapters.ClienteTableAdapter();
            this.cursoTableAdapter = new Cursos.BDECursosDataSetTableAdapters.CursoTableAdapter();
            this.toolTipInfoLocacao = new System.Windows.Forms.ToolTip(this.components);
            idLocacaoLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idFuncionarioLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            dataSaidaLabel = new System.Windows.Forms.Label();
            dataEntregaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingNavigator)).BeginInit();
            this.locacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoItemLocacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteLocacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLocacaoLabel
            // 
            idLocacaoLabel.AutoSize = true;
            idLocacaoLabel.Location = new System.Drawing.Point(19, 20);
            idLocacaoLabel.Name = "idLocacaoLabel";
            idLocacaoLabel.Size = new System.Drawing.Size(43, 13);
            idLocacaoLabel.TabIndex = 10;
            idLocacaoLabel.Text = "Código:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(19, 93);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(42, 13);
            idClienteLabel.TabIndex = 24;
            idClienteLabel.Text = "Cliente:";
            // 
            // idFuncionarioLabel
            // 
            idFuncionarioLabel.AutoSize = true;
            idFuncionarioLabel.Location = new System.Drawing.Point(148, 20);
            idFuncionarioLabel.Name = "idFuncionarioLabel";
            idFuncionarioLabel.Size = new System.Drawing.Size(76, 13);
            idFuncionarioLabel.TabIndex = 24;
            idFuncionarioLabel.Text = "id Funcionario:";
            idFuncionarioLabel.Visible = false;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(187, 46);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 22;
            horaLabel.Text = "Hora:";
            // 
            // dataSaidaLabel
            // 
            dataSaidaLabel.AutoSize = true;
            dataSaidaLabel.Location = new System.Drawing.Point(19, 46);
            dataSaidaLabel.Name = "dataSaidaLabel";
            dataSaidaLabel.Size = new System.Drawing.Size(93, 13);
            dataSaidaLabel.TabIndex = 21;
            dataSaidaLabel.Text = "Data da Locação:";
            // 
            // dataEntregaLabel
            // 
            dataEntregaLabel.AutoSize = true;
            dataEntregaLabel.Location = new System.Drawing.Point(298, 46);
            dataEntregaLabel.Name = "dataEntregaLabel";
            dataEntregaLabel.Size = new System.Drawing.Size(103, 13);
            dataEntregaLabel.TabIndex = 23;
            dataEntregaLabel.Text = "Data da Devolução:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxNomeCliente);
            this.groupBox1.Controls.Add(idLocacaoLabel);
            this.groupBox1.Controls.Add(this.idLocacaoTextBox);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.idClienteTextBox);
            this.groupBox1.Controls.Add(idFuncionarioLabel);
            this.groupBox1.Controls.Add(this.idFuncionarioTextBox);
            this.groupBox1.Controls.Add(horaLabel);
            this.groupBox1.Controls.Add(this.horaDateTimePicker);
            this.groupBox1.Controls.Add(dataSaidaLabel);
            this.groupBox1.Controls.Add(this.dataSaidaDateTimePicker);
            this.groupBox1.Controls.Add(dataEntregaLabel);
            this.groupBox1.Controls.Add(this.dataDevolucaoDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Locação";
            // 
            // comboBoxNomeCliente
            // 
            this.comboBoxNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locacaoBindingSource, "idCliente", true));
            this.comboBoxNomeCliente.DataSource = this.clienteBindingSource;
            this.comboBoxNomeCliente.DisplayMember = "Nome";
            this.comboBoxNomeCliente.FormattingEnabled = true;
            this.comboBoxNomeCliente.Location = new System.Drawing.Point(97, 109);
            this.comboBoxNomeCliente.Name = "comboBoxNomeCliente";
            this.comboBoxNomeCliente.Size = new System.Drawing.Size(333, 21);
            this.comboBoxNomeCliente.TabIndex = 28;
            this.comboBoxNomeCliente.ValueMember = "idCliente";
            this.comboBoxNomeCliente.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNomeCliente_SelectionChangeCommitted);
            // 
            // locacaoBindingSource
            // 
            this.locacaoBindingSource.DataMember = "Locacao";
            this.locacaoBindingSource.DataSource = this.bDECursosDataSet;
            // 
            // bDECursosDataSet
            // 
            this.bDECursosDataSet.DataSetName = "BDECursosDataSet";
            this.bDECursosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bDECursosDataSet;
            // 
            // idLocacaoTextBox
            // 
            this.idLocacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "idLocacao", true));
            this.idLocacaoTextBox.Location = new System.Drawing.Point(68, 17);
            this.idLocacaoTextBox.Name = "idLocacaoTextBox";
            this.idLocacaoTextBox.ReadOnly = true;
            this.idLocacaoTextBox.Size = new System.Drawing.Size(73, 20);
            this.idLocacaoTextBox.TabIndex = 11;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "idCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(22, 109);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(69, 20);
            this.idClienteTextBox.TabIndex = 1;
            this.idClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idClienteTextBox_KeyPress);
            // 
            // idFuncionarioTextBox
            // 
            this.idFuncionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "idFuncionario", true));
            this.idFuncionarioTextBox.Location = new System.Drawing.Point(230, 17);
            this.idFuncionarioTextBox.Name = "idFuncionarioTextBox";
            this.idFuncionarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.idFuncionarioTextBox.TabIndex = 25;
            this.idFuncionarioTextBox.Visible = false;
            // 
            // horaDateTimePicker
            // 
            this.horaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "Hora", true));
            this.horaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaDateTimePicker.Location = new System.Drawing.Point(190, 62);
            this.horaDateTimePicker.Name = "horaDateTimePicker";
            this.horaDateTimePicker.ShowUpDown = true;
            this.horaDateTimePicker.Size = new System.Drawing.Size(78, 20);
            this.horaDateTimePicker.TabIndex = 13;
            // 
            // dataSaidaDateTimePicker
            // 
            this.dataSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "DataSaida", true));
            this.dataSaidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataSaidaDateTimePicker.Location = new System.Drawing.Point(22, 62);
            this.dataSaidaDateTimePicker.Name = "dataSaidaDateTimePicker";
            this.dataSaidaDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.dataSaidaDateTimePicker.TabIndex = 12;
            // 
            // dataDevolucaoDateTimePicker
            // 
            this.dataDevolucaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "DataEntrega", true));
            this.dataDevolucaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDevolucaoDateTimePicker.Location = new System.Drawing.Point(301, 62);
            this.dataDevolucaoDateTimePicker.Name = "dataDevolucaoDateTimePicker";
            this.dataDevolucaoDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.dataDevolucaoDateTimePicker.TabIndex = 14;
            // 
            // locacaoBindingNavigator
            // 
            this.locacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.locacaoBindingNavigator.BindingSource = this.locacaoBindingSource;
            this.locacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.locacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.locacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.locacaoBindingNavigatorSaveItem});
            this.locacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.locacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.locacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.locacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.locacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.locacaoBindingNavigator.Name = "locacaoBindingNavigator";
            this.locacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.locacaoBindingNavigator.Size = new System.Drawing.Size(634, 25);
            this.locacaoBindingNavigator.TabIndex = 1;
            this.locacaoBindingNavigator.Text = "bindingNavigator1";
            this.locacaoBindingNavigator.Visible = false;
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
            // locacaoBindingNavigatorSaveItem
            // 
            this.locacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.locacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("locacaoBindingNavigatorSaveItem.Image")));
            this.locacaoBindingNavigatorSaveItem.Name = "locacaoBindingNavigatorSaveItem";
            this.locacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.locacaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.locacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.locacaoBindingNavigatorSaveItem_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(500, 67);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(106, 35);
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "Salvar";
            this.toolTipInfoLocacao.SetToolTip(this.btCadastrar, "Salva a locação.");
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.locacaoBindingNavigatorSaveItem_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(500, 109);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 35);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.toolTipInfoLocacao.SetToolTip(this.btCancelar, "Fecha a tela de locacção.");
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // itemLocacaoDataGridView
            // 
            this.itemLocacaoDataGridView.AutoGenerateColumns = false;
            this.itemLocacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemLocacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itemLocacaoDataGridView.DataSource = this.locacaoItemLocacaoBindingSource;
            this.itemLocacaoDataGridView.Location = new System.Drawing.Point(12, 205);
            this.itemLocacaoDataGridView.Name = "itemLocacaoDataGridView";
            this.itemLocacaoDataGridView.Size = new System.Drawing.Size(610, 241);
            this.itemLocacaoDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idItem";
            this.dataGridViewTextBoxColumn1.HeaderText = "idItem";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idLocacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "idLocacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idCurso";
            this.dataGridViewTextBoxColumn3.DataSource = this.cursoBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Titulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "idCurso";
            this.dataGridViewTextBoxColumn3.Width = 565;
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.bDECursosDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataDevolucao";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataDevolucao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // locacaoItemLocacaoBindingSource
            // 
            this.locacaoItemLocacaoBindingSource.DataMember = "LocacaoItemLocacao";
            this.locacaoItemLocacaoBindingSource.DataSource = this.locacaoBindingSource;
            // 
            // itemLocacaoBindingSource
            // 
            this.itemLocacaoBindingSource.DataMember = "ItemLocacao";
            this.itemLocacaoBindingSource.DataSource = this.bDECursosDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código do Curso:";
            // 
            // textBoxCodCurso
            // 
            this.textBoxCodCurso.Location = new System.Drawing.Point(12, 177);
            this.textBoxCodCurso.Name = "textBoxCodCurso";
            this.textBoxCodCurso.Size = new System.Drawing.Size(69, 20);
            this.textBoxCodCurso.TabIndex = 2;
            this.textBoxCodCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodCurso_KeyPress);
            // 
            // buttonExcluirCurso
            // 
            this.buttonExcluirCurso.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirCurso.Image")));
            this.buttonExcluirCurso.Location = new System.Drawing.Point(131, 176);
            this.buttonExcluirCurso.Name = "buttonExcluirCurso";
            this.buttonExcluirCurso.Size = new System.Drawing.Size(38, 21);
            this.buttonExcluirCurso.TabIndex = 19;
            this.toolTipInfoLocacao.SetToolTip(this.buttonExcluirCurso, "Exclui o curso selecionado.");
            this.buttonExcluirCurso.UseVisualStyleBackColor = true;
            this.buttonExcluirCurso.Click += new System.EventHandler(this.buttonExcluirCurso_Click);
            // 
            // buttonAddCurso
            // 
            this.buttonAddCurso.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCurso.Image")));
            this.buttonAddCurso.Location = new System.Drawing.Point(87, 176);
            this.buttonAddCurso.Name = "buttonAddCurso";
            this.buttonAddCurso.Size = new System.Drawing.Size(38, 21);
            this.buttonAddCurso.TabIndex = 18;
            this.toolTipInfoLocacao.SetToolTip(this.buttonAddCurso, "Adiciona o curso referente ao código informado na cesta.");
            this.buttonAddCurso.UseVisualStyleBackColor = true;
            this.buttonAddCurso.Click += new System.EventHandler(this.buttonAddCurso_Click);
            // 
            // clienteLocacaoBindingSource
            // 
            this.clienteLocacaoBindingSource.DataMember = "ClienteLocacao";
            this.clienteLocacaoBindingSource.DataSource = this.clienteBindingSource;
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(500, 25);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(106, 35);
            this.btNovo.TabIndex = 21;
            this.btNovo.Text = "Novo";
            this.toolTipInfoLocacao.SetToolTip(this.btNovo, "Salva a locação e cria uma nova.");
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // locacaoTableAdapter
            // 
            this.locacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ItemLocacaoTableAdapter = this.itemLocacaoTableAdapter;
            this.tableAdapterManager.LocacaoTableAdapter = this.locacaoTableAdapter;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.ProfessorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cursos.BDECursosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemLocacaoTableAdapter
            // 
            this.itemLocacaoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // toolTipInfoLocacao
            // 
            this.toolTipInfoLocacao.Tag = "";
            // 
            // cadLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 458);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.buttonExcluirCurso);
            this.Controls.Add(this.buttonAddCurso);
            this.Controls.Add(this.textBoxCodCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemLocacaoDataGridView);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.locacaoBindingNavigator);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locacão de Cursos";
            this.Load += new System.EventHandler(this.cadLocacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingNavigator)).EndInit();
            this.locacaoBindingNavigator.ResumeLayout(false);
            this.locacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoItemLocacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteLocacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BDECursosDataSet bDECursosDataSet;
        private System.Windows.Forms.BindingSource locacaoBindingSource;
        private BDECursosDataSetTableAdapters.LocacaoTableAdapter locacaoTableAdapter;
        private BDECursosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator locacaoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton locacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idLocacaoTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox idFuncionarioTextBox;
        private System.Windows.Forms.DateTimePicker horaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSaidaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataDevolucaoDateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxNomeCliente;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btCancelar;
        private BDECursosDataSetTableAdapters.ItemLocacaoTableAdapter itemLocacaoTableAdapter;
        private System.Windows.Forms.BindingSource itemLocacaoBindingSource;
        private System.Windows.Forms.DataGridView itemLocacaoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodCurso;
        private System.Windows.Forms.Button buttonAddCurso;
        private System.Windows.Forms.Button buttonExcluirCurso;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BDECursosDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteLocacaoBindingSource;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private BDECursosDataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.BindingSource locacaoItemLocacaoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolTip toolTipInfoLocacao;
    }
}