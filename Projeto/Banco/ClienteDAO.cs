using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Projeto.Banco
{
    internal class ClienteDAO
    {
        //Cadastrar cliente:
        public static bool Cadastrar(Classes.Cliente c)
        {
            string comando;
            comando = "INSERT INTO cliente (nome, email) VALUES (@nome, @email)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            
            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", c.Nome);
            cmd.Parameters.AddWithValue("@email", c.Email);

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
        
        //Listar Tudo:
        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT id, nome, email FROM cliente";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        //Modificar:
        public static bool Modificar(Classes.Cliente c)
        {
            string comando;
            comando = "UPDATE cliente SET nome = @nome, email = @email WHERE id = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            cmd.Parameters.AddWithValue("@email", c.Email);

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

    }
}
