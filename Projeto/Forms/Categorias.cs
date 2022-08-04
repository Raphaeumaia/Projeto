using System;
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
    public partial class Categorias : Form
    {
        //Obejtos Globais:
        private int _idSelecionado;
        public Categorias()
        {
            InitializeComponent();
            AtualizarDgv();
        }

        private void AtualizarDgv()
        {
            dgvCategoria.DataSource = Banco.CategoriaDAO.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var c = new Categoria();
            var valida = txtCadastrar.Text.Length > 2; 
               

            if (valida)
            {
                c.Nome = txtCadastrar.Text;
                

                if (Banco.CategoriaDAO.Cadastrar(c) == true)
                {
                    MessageBox.Show("Categoria Cadastrado");
                    //Limpar campos:
                    txtCadastrar.Clear();
                   
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            var c = new Categoria();
            c.Nome = txtAtualizar.Text;
            
            c.Id = _idSelecionado;

            //Atualizar:
            if (Banco.CategoriaDAO.Modificar(c))
            {
                MessageBox.Show("Categoria modificado com sucesso!");
                //limpar:
                txtAtualizar.Clear();
                
                //Atualizar dgv:
                AtualizarDgv();

                //Esconder grb:
                gbrAtulizar.Enabled = false;

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas!");
            }
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar gbr
            gbrAtulizar.Enabled = true;

            //Descobrir o número da linha da célula clicada:
            int numerolinha = dgvCategoria.CurrentCell.RowIndex;
            //Guardar toda a linha em um DataRow:
            var linha = dgvCategoria.Rows[numerolinha];

            //Váriaveis que vão recever os valores na linha selecionada:
            string nomeSelecionado = linha.Cells[1].Value.ToString();
           
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

            //Atribuir os valores das células  aos txt:
            txtAtualizar.Text = nomeSelecionado;
            
        }
    }
}
