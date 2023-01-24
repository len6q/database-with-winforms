using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Vegetarian_Community.Scripts
{
    public sealed class UsersFactory
    {
        private const string CONNECTION_STRING = "dbConnectionString";
        private readonly string _configConnection = ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ConnectionString;
        
        public async void InsertUser(User user)
        {
            string sqlExpression = $"INSERT INTO Users VALUES({user.Id}, '{user.Name}', '{user.Sex}', {user.Age})";
            using(SqlConnection connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();

                var command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
