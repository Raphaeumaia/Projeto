using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Classes;


namespace Projeto.Forms
{
    public partial class Pedidos : Form
    {
        //Objetos Globais
        private int _idSelecionado;


        public Pedidos()
        {
            InitializeComponent();
            dgvClientes.DataSource = Banco.ClienteDAO.ListarTudo();
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }
        private int ObterIdDaString(string texto)
        {
            return int.Parse(texto.Split(' ')[0]);
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar gbr
            grbCadastrarIdCliente.Enabled = true;

            //Descobrir o número da linha da célula clicada:
            int numerolinha = dgvClientes.CurrentCell.RowIndex;
            //Guardar toda a linha em um DataRow:
            var linha = dgvClientes.Rows[numerolinha];

            //Váriaveis que vão recever os valores na linha selecionada:
            int IdCliente = int.Parse(linha.Cells[0].Value.ToString());
            



            IdCliente = int.Parse(linha.Cells[0].Value.ToString());

            //Atribuir os valores das células  aos txt:
            txtIdProdutoCadastrar.Text = IdCliente.ToString();
            txtIdLocalizar.Text = IdCliente.ToString();
        }
        private void AtualizarDgv()
        {
            dgvClientes.DataSource = Banco.ClienteDAO.ListarTudo();
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            //Descobrir o número da linha da célula clicada:
            int numerolinha = dgvProdutos.CurrentCell.RowIndex;
            //Guardar toda a linha em um DataRow:
            var linha = dgvProdutos.Rows[numerolinha];

            //Váriaveis que vão recever os valores na linha selecionada:
            int IdPedido = int.Parse(linha.Cells[0].Value.ToString());




            //Atribuir os valores das células aos txt:
            txtProdutoCadastrar.Text = IdPedido.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var p = new Pedido();
            var valida =txtProdutoCadastrar.Text.Length > 0 && txtIdProdutoCadastrar.Text.Length > 0;

            if (valida)
            {
                p.Id = _idSelecionado;

                p.IdCliente = int.Parse(txtIdProdutoCadastrar.Text);
                p.IdProduto = int.Parse(txtProdutoCadastrar.Text);

                if (Banco.PedidoDAO.Cadastrar(p) == true)
                {
                    MessageBox.Show("Pedido Cadastrado");
                    //Limpar campos:
                    txtProdutoCadastrar.Clear();
                    txtIdProdutoCadastrar.Clear();


                }
                else
                {
                    MessageBox.Show("Houve um erro no cadastro." +
                      "Verifique as informações.");
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            var menulocalizar = new LocalizarPedido(int.Parse(txtIdLocalizar.Text));
            menulocalizar.ShowDialog();
        }
    }
}
