using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class LocalizarPedido : Form
    {
        public LocalizarPedido(int id)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                // Se a conversão der certo:
                var r = Banco.PedidoDAO.ListarTudo(id);
                // Verificar se a ficha tem lançamentos:
                if (r.Rows.Count > 0)
                {
                    // Popular o DGV com as informações:
                    dgvPedidos.DataSource = r;
                    var preco = r.Compute("SUM(preco)", string.Empty);
                    lblPreco.Text = "R$ " + preco.ToString();
                }
                else
                {
                    MessageBox.Show("O cliente não possui pedidos!");

                }
            }
        }
    }
}
