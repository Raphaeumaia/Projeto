using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Classes;
using System.Data;

namespace Projeto.Banco
{
    internal class PedidoDAO
    {
        //Cadastrar pedido:
        public static bool Cadastrar(Classes.Pedido p)
        {
            string comando;
            comando = "INSERT INTO pedidos (id_produtos, id_cliente) VALUES (@id_produtos, @id_cliente)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);
         
            cmd.Parameters.AddWithValue("@id_produtos", p.IdProduto);
            cmd.Parameters.AddWithValue("@id_cliente", p.IdCliente);
           
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static DataTable ListarTudo(int id)
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM view_pedidos WHERE id_cliente = @id_cliente";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_cliente", id);
            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
    }
}
