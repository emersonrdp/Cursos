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
    public partial class ConsultaCliente : Form
    {

        private cadDevolucao devolucao;   // Atributo que receberá a variável com o endereço do formulário cadDevolucao no construtor do formulário ConsultaCliente.

        public ConsultaCliente()
        {
            InitializeComponent();
        }

        public ConsultaCliente(cadDevolucao dev)   // Construtor que recebe a váriável com o endereço do formulário cadDevolucao.
        {
            devolucao = dev;
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDECursosDataSet);

        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDECursosDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bDECursosDataSet.Cliente);

        }

        private void textBoxPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByNomeCliente(this.bDECursosDataSet.Cliente, textBoxPesquisaCliente.Text);
        }

        // Método que retornará os dados ao dar 2 cliques na linha do gride de clientes
        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            devolucao.setCodigoAndNomeCliente(Convert.ToInt32(clienteDataGridView.CurrentRow.Cells[0].Value.ToString()),
                clienteDataGridView.CurrentRow.Cells[1].Value.ToString());

            this.Dispose();
        }
    }
}
