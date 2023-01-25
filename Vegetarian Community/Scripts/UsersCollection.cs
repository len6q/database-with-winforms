using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Vegetarian_Community.Scripts
{
    public sealed class UsersCollection
    {
        private const string CONNECTION_STRING = "dbConnectionString";
        private readonly string _configConnection = ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ConnectionString;

        private List<User> _allUsers = new List<User>();

        public async void InsertUser(User user)
        {
            string sqlExpression = $"INSERT INTO Users VALUES({user.Id}, '{user.Name}', '{user.Sex}', {user.Age})";
            using(SqlConnection connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();

                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
                _allUsers.Add(user);
            }
        }
    }
}
