using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vegetarian_Community.Scripts
{
    public sealed class CommentsCollection
    {
        private const string CONNECTION_STRING = "dbConnectionString";
        private readonly string _configConnection = ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ConnectionString;

        private List<Comment> _allComments = new List<Comment>();

        private int Count
        {
            get
            {
                var sqlExpression = $"SELECT COUNT(*) FROM Comments";
                using (var connection = new SqlConnection(_configConnection))
                {
                    connection.Open();
                    var command = new SqlCommand(sqlExpression, connection);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public void CreateComment(string text, int userId, int postId, ListBox chat)
        {
            var comment = new Comment(Count, text, userId, postId);
            InsertComment(comment);
            ShowComments(postId, chat);
        }

        private async void InsertComment(Comment comment)
        {
            string sqlExpression = $"INSERT INTO Comments VALUES({comment.Id}, '{comment.Text}', " +
                $"'{comment.Time}', {comment.UserId}, {comment.PostId})";
            using(var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();

                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
                _allComments.Add(comment);
            }
        }

        private async void ShowComments(int currentPost, ListBox infoBox)
        {
            infoBox.Items.Clear();
            var sqlExpression = $"SELECT * FROM Comments WHERE c_posts_ID = {currentPost}";
            using(var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();
                var command = new SqlCommand(sqlExpression, connection);
                using(var reader = command.ExecuteReader())
                {
                    while (await reader.ReadAsync())
                    {
                        int userId = reader.GetInt32(3);
                        string text = reader.GetString(1);
                        DateTime time = reader.GetDateTime(2);

                        var comment = $"{userId}: {text} | {time}";
                        infoBox.Items.Add(comment);                       
                    }
                }
            }            
        }
    }
}
