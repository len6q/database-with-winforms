using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Vegetarian_Community.Scripts
{
    public sealed class UsersCollection
    {
        private const string CONNECTION_STRING = "dbConnectionString";
        private readonly string _configConnection = ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ConnectionString;

        private List<User> _allUsers = new List<User>();

        private int Count
        {
            get
            {
                var sqlExpression = $"SELECT MAX(users_ID) FROM Users";
                using (var connection = new SqlConnection(_configConnection))
                {
                    connection.Open();
                    var command = new SqlCommand(sqlExpression, connection);
                    if (DBNull.Value.Equals(command.ExecuteScalar()))
                    {
                        return 0;
                    }
                    return Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
            }
        }

        public void CreateUser(string name, string currentSex, int age)
        {
            var user = new User(Count, name, currentSex, age);
            InsertUser(user);
        }

        private async void InsertUser(User user)
        {
            string sqlExpression = $"INSERT INTO Users VALUES({user.Id}, '{user.Name}', '{user.Sex}', {user.Age})";
            using(var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();

                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
                _allUsers.Add(user);
            }
        }
    }
}
