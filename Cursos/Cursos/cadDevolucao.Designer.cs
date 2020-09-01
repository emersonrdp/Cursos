namespace Cursos
{
    partial class cadDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadDevolucao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_PesquisaCliente = new System.Windows.Forms.Button();
            this.dateTimePickerDataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.textBoxCodCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bDECursosDataSet = new Cursos.BDECursosDataSet();
            this.itemLocacaoTableAdapter = new Cursos.BDECursosDataSetTableAdapters.ItemLocacaoTableAdapter();
            this.itemLocacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemLocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.itemLocacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.itemLocacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btDevolvr = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Cursos.BDECursosDataSetTableAdapters.TableAdapterManager();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Cursos.BDECursosDataSetTableAdapters.ClienteTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingNavigator)).BeginInit();
            this.itemLocacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_PesquisaCliente);
            this.groupBox1.Controls.Add(this.dateTimePickerDataDevolucao);
            this.groupBox1.Controls.Add(this.textBoxNomeCliente);
            this.groupBox1.Controls.Add(this.textBoxCodCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário e Dados da Devolução";
            // 
            // bt_PesquisaCliente
            // 
            this.bt_PesquisaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PesquisaCliente.Location = new System.Drawing.Point(410, 36);
            this.bt_PesquisaCliente.Name = "bt_PesquisaCliente";
            this.bt_PesquisaCliente.Size = new System.Drawing.Size(31, 21);
            this.bt_PesquisaCliente.TabIndex = 6;
            this.bt_PesquisaCliente.Text = "...";
            this.bt_PesquisaCliente.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataDevolucao
            // 
            this.dateTimePickerDataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDevolucao.Location = new System.Drawing.Point(10, 89);
            this.dateTimePickerDataDevolucao.Name = "dateTimePickerDataDevolucao";
            this.dateTimePickerDataDevolucao.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerDataDevolucao.TabIndex = 5;
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(90, 36);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(316, 20);
            this.textBoxNomeCliente.TabIndex = 4;
            // 
            // textBoxCodCliente
            // 
            this.textBoxCodCliente.Location = new System.Drawing.Point(10, 36);
            this.textBoxCodCliente.Name = "textBoxCodCliente";
            this.textBoxCodCliente.Size = new System.Drawing.Size(59, 20);
            this.textBoxCodCliente.TabIndex = 3;
            this.textBoxCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodCliente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data da Devolução:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // bDECursosDataSet
            // 
            this.bDECursosDataSet.DataSetName = "BDECursosDataSet";
            this.bDECursosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemLocacaoTableAdapter
            // 
            this.itemLocacaoTableAdapter.ClearBeforeFill = true;
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
            this.itemLocacaoDataGridView.DataSource = this.itemLocacaoBindingSource;
            this.itemLocacaoDataGridView.Location = new System.Drawing.Point(12, 160);
            this.itemLocacaoDataGridView.Name = "itemLocacaoDataGridView";
            this.itemLocacaoDataGridView.Size = new System.Drawing.Size(610, 286);
            this.itemLocacaoDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idItem";
            this.dataGridViewTextBoxColumn1.HeaderText = "idItem";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idLocacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "idLocacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idCurso";
            this.dataGridViewTextBoxColumn3.HeaderText = "idCurso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataDevolucao";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataDevolucao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // itemLocacaoBindingSource
            // 
            this.itemLocacaoBindingSource.DataMember = "ItemLocacao";
            this.itemLocacaoBindingSource.DataSource = this.bDECursosDataSet;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
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
            // itemLocacaoBindingNavigatorSaveItem
            // 
            this.itemLocacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemLocacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemLocacaoBindingNavigatorSaveItem.Image")));
            this.itemLocacaoBindingNavigatorSaveItem.Name = "itemLocacaoBindingNavigatorSaveItem";
            this.itemLocacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itemLocacaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.itemLocacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemLocacaoBindingNavigatorSaveItem_Click);
            // 
            // itemLocacaoBindingNavigator
            // 
            this.itemLocacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemLocacaoBindingNavigator.BindingSource = this.itemLocacaoBindingSource;
            this.itemLocacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemLocacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemLocacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itemLocacaoBindingNavigatorSaveItem});
            this.itemLocacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemLocacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemLocacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemLocacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemLocacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemLocacaoBindingNavigator.Name = "itemLocacaoBindingNavigator";
            this.itemLocacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemLocacaoBindingNavigator.Size = new System.Drawing.Size(634, 25);
            this.itemLocacaoBindingNavigator.TabIndex = 1;
            this.itemLocacaoBindingNavigator.Text = "bindingNavigator1";
            this.itemLocacaoBindingNavigator.Visible = false;
            // 
            // btDevolvr
            // 
            this.btDevolvr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDevolvr.Location = new System.Drawing.Point(497, 35);
            this.btDevolvr.Name = "btDevolvr";
            this.btDevolvr.Size = new System.Drawing.Size(105, 35);
            this.btDevolvr.TabIndex = 5;
            this.btDevolvr.Text = "Devolver";
            this.btDevolvr.UseVisualStyleBackColor = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ItemLocacaoTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.ProfessorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cursos.BDECursosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bDECursosDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // cadDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 458);
            this.Controls.Add(this.btDevolvr);
            this.Controls.Add(this.itemLocacaoDataGridView);
            this.Controls.Add(this.itemLocacaoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucao de Cursos";
            this.Load += new System.EventHandler(this.cadDevolucao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingNavigator)).EndInit();
            this.itemLocacaoBindingNavigator.ResumeLayout(false);
            this.itemLocacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox textBoxCodCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_PesquisaCliente;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDevolucao;
        private BDECursosDataSet bDECursosDataSet;
        private System.Windows.Forms.BindingSource itemLocacaoBindingSource;
        private BDECursosDataSetTableAdapters.ItemLocacaoTableAdapter itemLocacaoTableAdapter;
        private BDECursosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView itemLocacaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton itemLocacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator itemLocacaoBindingNavigator;
        private System.Windows.Forms.Button btDevolvr;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BDECursosDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}