using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Banco
{
    public static class CategoriaDAO
    {
        //Metodo para listar todas as informações da tabela categorias:
        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM categorias";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public static bool Cadastrar(Classes.Categoria c)
        {
            string comando;
            comando = "INSERT INTO categorias (nome_categoria) VALUES (@nome_categoria)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_categoria", c.Nome);
            

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

        public static bool Modificar(Classes.Categoria c)
        {
            string comando;
            comando = "UPDATE categorias SET nome_categoria = @nome_categoria WHERE id = @id";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@nome_categoria", c.Nome);

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
