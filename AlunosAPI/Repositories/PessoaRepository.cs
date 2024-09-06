using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.CompilerServices;

namespace AlunosAPI.Repositories
{
    public class PessoaRepository
    {
        private readonly string _connectionString;
       
        public PessoaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        private IDbConnection Connection =>
            new MySqlConnection(_connectionString);
    }
}
