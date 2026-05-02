using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace AgendaWinFormsSQLite.Models
{
    /// <summary>
    /// Classe DAL (Data Access Layer). 
    /// Responsável por toda a comunicação e execução de comandos SQL no banco SQLite.
    /// </summary>
    public class DALAgenda
    {
        // Define o caminho físico do arquivo do banco de dados na raiz da aplicação
        public static string path = Directory.GetCurrentDirectory() + "\\banco.sqlite";
        private static SQLiteConnection sqliteConnection;

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=" + path);
            sqliteConnection.Open();
            return sqliteConnection;
        }

        /// <summary>
        /// Verifica se o arquivo físico do banco de dados existe. Se não, cria um novo.
        /// </summary>
        public static void CriarBancoSQLite()
        {
            try
            {
                if (File.Exists(path) == false)
                {
                    SQLiteConnection.CreateFile(path);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Cria a tabela 'Contatos' estruturada caso ela ainda não exista no banco.
        /// </summary>
        public static void CriarTabelaSQLite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Contatos(id int, nome Varchar(50), email VarChar(80), telefone VarChar(14))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna todos os registros da tabela Contatos.
        /// </summary>
        public static DataTable GetContatos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contatos";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Realiza uma busca parcial (LIKE) na tabela Contatos através do nome fornecido.
        /// </summary>
        public static DataTable GetContatos(string nome)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contatos where nome like '%" + nome + "%'";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna um registro específico baseado no ID.
        /// </summary>
        public static DataTable GetContato(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contatos Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Insere um novo objeto Contato no banco de dados utilizando parâmetros tipados (evita SQL Injection).
        /// </summary>
        public static void Add(Contato contato)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Contatos(id, nome, email, telefone) values (@id, @nome, @email, @telefone)";
                    cmd.Parameters.AddWithValue("@id", contato.Id);
                    cmd.Parameters.AddWithValue("@nome", contato.Nome);
                    cmd.Parameters.AddWithValue("@email", contato.Email);
                    cmd.Parameters.AddWithValue("@telefone", contato.Telefone);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Atualiza os dados (Nome, Email, Telefone) de um Contato existente com base no ID.
        /// </summary>
        public static void Update(Contato contato)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Contatos SET Nome=@Nome, Email=@Email, Telefone=@Telefone WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", contato.Id);
                    cmd.Parameters.AddWithValue("@Nome", contato.Nome);
                    cmd.Parameters.AddWithValue("@Email", contato.Email);
                    cmd.Parameters.AddWithValue("@Telefone", contato.Telefone);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Remove um registro da tabela Contatos com base no ID fornecido.
        /// </summary>
        public static void Delete(int id)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Contatos Where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
