using Bussines;
using MySql.Data.MySqlClient;

namespace DataBase
{
    public class Aluno : Base

    {
        public static void Salvar(BaseAluno Cadastro)


        { 
            
            // Conexão com o banco de dados
            string connectionString = "Server=localhost;Port=3306;Database=banco_escola;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Instrução SQL para inserir o aluno na tabela "alunos"
            string sql = "INSERT INTO alunos (nome, idade, nota) VALUES (@nome, @idade, @nota)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@nome", Cadastro.Nome);
            command.Parameters.AddWithValue("@idade", Cadastro.Idade);
            command.Parameters.AddWithValue("@nota", Cadastro.Nota);
            command.ExecuteNonQuery();

            // Fechando a conexão
            connection.Close();
        }

    }
}
