﻿using System;
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
    public partial class cadCliente : Form
    {
        public cadCliente()
        {
            InitializeComponent();
        }

        /*public cadCliente(TipoTab tipoTab)
        {
            if (tipoTab == TipoTab.Consulta)
            {
                tabControlCliente.SelectedTab = tabPageConsulta;
            }
            else
            {
                tabControlCliente.SelectedTab = tabPageCadastro;
            }
        }
        public enum TipoTab
        {
            Cadastro,
            Consulta
        } */

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
                MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro: " + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();   /// fechar a janela de cadastro de clientes
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // implementação de pergunta para confirmação de exclusão de registro
            if (MessageBox.Show("Deseja excluir o registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // confirmando exclusão ele salva o registro pois o botão exclusão precisa que salve o registro para concluir a exclusão, desta forma já fica automatizado.
                this.Validate();
                this.clienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);
            }
            else
            {
                this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);   // exibe novamente o formulario
            }
        }

        private void textBoxPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByPesquisaCliente(bDECursosDataSet.Cliente, textBoxPesquisaCliente.Text);
        }
    }
}