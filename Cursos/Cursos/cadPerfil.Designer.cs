﻿namespace Cursos
{
    partial class cadPerfil
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
            System.Windows.Forms.Label idPerfilLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadPerfil));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.perfilBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.perfilBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idPerfilTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.perfilDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPesquisaPerfil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.perfilTableAdapter = new Cursos.BDECursosDataSetTableAdapters.PerfilTableAdapter();
            this.tableAdapterManager = new Cursos.BDECursosDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idPerfilLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingNavigator)).BeginInit();
            this.perfilBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idPerfilLabel
            // 
            idPerfilLabel.AutoSize = true;
            idPerfilLabel.Location = new System.Drawing.Point(49, 76);
            idPerfilLabel.Name = "idPerfilLabel";
            idPerfilLabel.Size = new System.Drawing.Size(43, 13);
            idPerfilLabel.TabIndex = 0;
            idPerfilLabel.Text = "Codigo:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(49, 102);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(49, 128);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descricao:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 343);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.perfilBindingNavigator);
            this.tabPage1.Controls.Add(idPerfilLabel);
            this.tabPage1.Controls.Add(this.idPerfilTextBox);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Controls.Add(descricaoLabel);
            this.tabPage1.Controls.Add(this.descricaoTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // perfilBindingNavigator
            // 
            this.perfilBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.perfilBindingNavigator.BindingSource = this.perfilBindingSource;
            this.perfilBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.perfilBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.perfilBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.perfilBindingNavigatorSaveItem});
            this.perfilBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.perfilBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.perfilBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.perfilBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.perfilBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.perfilBindingNavigator.Name = "perfilBindingNavigator";
            this.perfilBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.perfilBindingNavigator.Size = new System.Drawing.Size(732, 25);
            this.perfilBindingNavigator.TabIndex = 16;
            this.perfilBindingNavigator.Text = "bindingNavigator1";
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
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataMember = "Perfil";
            this.perfilBindingSource.DataSource = this.bDECursosDataSet;
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
            // perfilBindingNavigatorSaveItem
            // 
            this.perfilBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.perfilBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("perfilBindingNavigatorSaveItem.Image")));
            this.perfilBindingNavigatorSaveItem.Name = "perfilBindingNavigatorSaveItem";
            this.perfilBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.perfilBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.perfilBindingNavigatorSaveItem.Click += new System.EventHandler(this.perfilBindingNavigatorSaveItem_Click_1);
            // 
            // idPerfilTextBox
            // 
            this.idPerfilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "idPerfil", true));
            this.idPerfilTextBox.Location = new System.Drawing.Point(112, 73);
            this.idPerfilTextBox.Name = "idPerfilTextBox";
            this.idPerfilTextBox.ReadOnly = true;
            this.idPerfilTextBox.Size = new System.Drawing.Size(560, 20);
            this.idPerfilTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(112, 99);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(560, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perfilBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(112, 125);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(560, 20);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.perfilDataGridView);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // perfilDataGridView
            // 
            this.perfilDataGridView.AutoGenerateColumns = false;
            this.perfilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perfilDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.perfilDataGridView.DataSource = this.perfilBindingSource;
            this.perfilDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.perfilDataGridView.Location = new System.Drawing.Point(3, 47);
            this.perfilDataGridView.Name = "perfilDataGridView";
            this.perfilDataGridView.Size = new System.Drawing.Size(732, 267);
            this.perfilDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxPesquisaPerfil);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 41);
            this.panel1.TabIndex = 0;
            // 
            // textBoxPesquisaPerfil
            // 
            this.textBoxPesquisaPerfil.Location = new System.Drawing.Point(147, 10);
            this.textBoxPesquisaPerfil.Name = "textBoxPesquisaPerfil";
            this.textBoxPesquisaPerfil.Size = new System.Drawing.Size(565, 20);
            this.textBoxPesquisaPerfil.TabIndex = 1;
            this.textBoxPesquisaPerfil.TextChanged += new System.EventHandler(this.textBoxPesquisaPerfil_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o nome do perfil";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(638, 392);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(106, 35);
            this.btCadastrar.TabIndex = 13;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(513, 392);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 35);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // perfilTableAdapter
            // 
            this.perfilTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ItemLocacaoTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = this.perfilTableAdapter;
            this.tableAdapterManager.ProfessorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cursos.BDECursosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idPerfil";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "Código do perfil";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 330;
            // 
            // cadPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cadPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Perfil";
            this.Load += new System.EventHandler(this.cadPerfil_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingNavigator)).EndInit();
            this.perfilBindingNavigator.ResumeLayout(false);
            this.perfilBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.perfilDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private BDECursosDataSetTableAdapters.PerfilTableAdapter perfilTableAdapter;
        private BDECursosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator perfilBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton perfilBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idPerfilTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPesquisaPerfil;
        private System.Windows.Forms.DataGridView perfilDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}