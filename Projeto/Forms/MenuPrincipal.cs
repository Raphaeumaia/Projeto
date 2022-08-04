using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //Sair do Programa:
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente deseja sair?", "MenuIniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Minimizar o Programa:
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Adicionar o form no panelcentral:
        private void btnCliente_Click(object sender, EventArgs e)
        {
            Forms.Clientes cliente = new Forms.Clientes();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(cliente);
            cliente.Show();

            //aplica a posicao do eixo x do botao ao marcador:
            panelMarcador.Top = btnCliente.Top;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();
            panelMarcador.Top = btnInicio.Top;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Forms.Produtos produtos = new Forms.Produtos();
            produtos.TopLevel = false;
            produtos.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(produtos);
            produtos.Show();

            panelMarcador.Top = btnProduto.Top;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Forms.Categorias categoria = new Forms.Categorias();
            categoria.TopLevel = false;
            categoria.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(categoria);
            categoria.Show();

            panelMarcador.Top = btnCategoria.Top;
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Forms.Pedidos pedido = new Forms.Pedidos();
            pedido.TopLevel = false;
            pedido.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(pedido);
            pedido.Show();

            panelMarcador.Top = btnPedido.Top;
        }
    }
}
