﻿namespace Cursos
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bDECursosDataSet = new Cursos.BDECursosDataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new Cursos.BDECursosDataSetTableAdapters.FuncionarioTableAdapter();
            this.tableAdapterManager = new Cursos.BDECursosDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_cancelar);
            this.panel1.Controls.Add(this.bt_entrar);
            this.panel1.Controls.Add(this.textBoxSenha);
            this.panel1.Controls.Add(this.senha);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxUsuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 261);
            this.panel1.TabIndex = 0;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(379, 205);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 7;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_entrar
            // 
            this.bt_entrar.Location = new System.Drawing.Point(289, 205);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(75, 23);
            this.bt_entrar.TabIndex = 6;
            this.bt_entrar.Text = "Entrar";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.bt_entrar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(237, 140);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(217, 20);
            this.textBoxSenha.TabIndex = 5;
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(234, 124);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(53, 16);
            this.senha.TabIndex = 4;
            this.senha.Text = "Senha";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(234, 75);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(63, 16);
            this.usuario.TabIndex = 3;
            this.usuario.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Controle de Acesso";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(237, 91);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(217, 20);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bDECursosDataSet
            // 
            this.bDECursosDataSet.DataSetName = "BDECursosDataSet";
            this.bDECursosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.bDECursosDataSet;
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
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDECursosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BDECursosDataSet bDECursosDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private BDECursosDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private BDECursosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}