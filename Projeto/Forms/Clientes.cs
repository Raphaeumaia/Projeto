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
    public partial class Clientes : Form
    {
        //Obejtos Globais:
        private int _idSelecionado;
        int idCliente;
        
        public Clientes()
        {
            InitializeComponent();
            dgvClientes.DataSource = Banco.ClienteDAO.ListarTudo();
            //Carregar dados para o dgv:
            AtualizarDgv();

        }
        private void AtualizarDgv()
        {
            dgvClientes.DataSource = Banco.ClienteDAO.ListarTudo();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var c = new Cliente();
            var valida = txtNomeCad.Text.Length > 2 &&
                txtEmailCad.Text.Length > 7;

            if (valida)
            {
                c.Nome = txtNomeCad.Text;
                c.Email = txtEmailCad.Text;

                if (Banco.ClienteDAO.Cadastrar(c) == true)
                {
                    MessageBox.Show("Cliente Cadastrado");
                    //Limpar campos:
                    txtNomeCad.Clear();
                    txtEmailCad.Clear();
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
            var c=new Cliente();
            c.Nome=txtNomeEditar.Text;
            c.Email=txtEmailEditar.Text;
            c.Id = _idSelecionado;

            //Atualizar:
            if(Banco.ClienteDAO.Modificar(c))
            {
                MessageBox.Show("Usuário modificado com sucesso!");
                //limpar:
                txtNomeEditar.Clear();
                txtEmailEditar.Clear();
                //Atualizar dgv:
                AtualizarDgv();
                
                //Esconder o grb:
               grbAtualizar.Enabled = false; 

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas!");
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar gbr
            grbAtualizar.Enabled = true ;

            //Descobrir o número da linha da célula clicada:
            int numerolinha = dgvClientes.CurrentCell.RowIndex;
            //Guardar toda a linha em um DataRow:
            var linha = dgvClientes.Rows[numerolinha];

            //Váriaveis que vão recever os valores na linha selecionada:
            string nomeSelecionado = linha.Cells[1].Value.ToString();
            string emailSelecionado = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());

            //Atribuir os valores das células  aos txt:
            txtNomeEditar.Text = nomeSelecionado;
            txtEmailEditar.Text = emailSelecionado;
        }
    }
}
