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
    public partial class Produtos : Form
    {
        private int _idSelecionado;
        public Produtos()
        {
            InitializeComponent();
            var c = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            //Converter esse objeto para array:
            foreach(DataRow dataRow in c.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            //Atribuir os valores nos cmbs:
            cmbCategoriaCad.DataSource = rows;
            cmbCategoriaEditar.DataSource = rows.Clone();

            //Atribuir a tabela de produtos do dgv:
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
            //Carregar dados para o dgv:
            AtualizarDgv();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var p = new Produto();
            p.Nome = txtProdutoEditar.Text;
            p.Preco = double.Parse(txtPrecoEditar.Text);           
            p.Id = _idSelecionado;
            p.IdCategoria = ObterIdDaString(cmbCategoriaEditar.Text);
            

            //Atualizar:
            if (Banco.ProdutoDAO.Modificar(p))
            {
                MessageBox.Show("Produto modificado com sucesso!");
                //limpar:
                txtProdutoEditar.Clear();
                txtPrecoEditar.Clear();
                cmbCategoriaEditar.SelectedIndex = 0; 
                //Atualizar dgv:
                AtualizarDgv();

                //Esconder o grb:
                gbrEditar.Enabled = false;

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas!");
            }
        }
        private void AtualizarDgv()
        {
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarTudo();
        }
        private int ObterIdDaString(string texto)
        {
            return int.Parse(texto.Split(' ')[0]);
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar gbr
            gbrEditar.Enabled = true;
                
            //Descobrir o número da linha da célula clicada:
            int numerolinha = dgvProdutos.CurrentCell.RowIndex;
            //Guardar toda a linha em um DataRow:
            var linha = dgvProdutos.Rows[numerolinha];

            //Váriaveis que vão recever os valores na linha selecionada:
            string ProdutoSelecionado = linha.Cells[1].Value.ToString();
            double PrecoProduto = double.Parse(linha.Cells[2].Value.ToString());
            


            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

            //Atribuir os valores das células  aos txt:
            txtProdutoEditar.Text = ProdutoSelecionado;
            txtPrecoEditar.Text = PrecoProduto.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var p = new Produto();
            var valida = txtProdutoCad.Text.Length > 2 && txtPrecoCad.Text.Length > 0;
            



            if (valida)
            {
                p.Nome = txtProdutoCad.Text;
                p.Preco = double.Parse(txtPrecoCad.Text);
                p.IdCategoria = ObterIdDaString(cmbCategoriaCad.Text);

                if (Banco.ProdutoDAO.Cadastrar(p) == true)
                {
                    MessageBox.Show("Produto Cadastrado");
                    //Limpar campos:
                    txtProdutoCad.Clear();
                    txtPrecoCad.Clear();

                    //Atualizar dgv:
                    AtualizarDgv();

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

        private void cmbCategoriaCad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProdutoEditar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
