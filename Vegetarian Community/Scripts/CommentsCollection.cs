using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Vegetarian_Community.Scripts
{
    public sealed class CommentsCollection
    {
        public event Action<int> OnShowComments;

        private const string CONNECTION_STRING = "dbConnectionString";
        private readonly string _configConnection = ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ConnectionString;

        private List<Comment> _allComments = new List<Comment>();
        
        public CommentsCollection()
        {
            FillBuffer();
        }

        public List<Comment> Collection => _allComments;

        private int MaxValue
        {
            get
            {
                var sqlExpression = $"SELECT MAX(comments_ID) FROM Comments";
                using (var connection = new SqlConnection(_configConnection))
                {
                    connection.Open();
                    var command = new SqlCommand(sqlExpression, connection);                    
                    if(DBNull.Value.Equals(command.ExecuteScalar()))
                    {
                        return 0;
                    }
                    return Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
            }
        }

        private void FillBuffer()
        {
            var sqlExpression = $"SELECT * FROM Comments";
            using (var connection = new SqlConnection(_configConnection))
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var commentId = reader.GetInt32(0);
                        var text = reader.GetString(1);
                        var time = reader.GetDateTime(2);
                        var userId = reader.GetInt32(3);
                        var postId = reader.GetInt32(4);

                        var comment = new Comment(commentId, text, time, userId, postId);
                        _allComments.Add(comment);
                    }
                }
            }
        }

        public async void CreateComment(string text, int userId, int postId)
        {
            var comment = new Comment(MaxValue, text, DateTime.Now, userId, postId);
            await InsertComment(comment);
            OnShowComments?.Invoke(postId);            
        }        

        private async Task InsertComment(Comment comment)
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

        public async void RemoveComment(int currentPost, Comment selectedComment)
        {            
            var sqlExpression = $"DELETE Comments WHERE comments_ID = {selectedComment.Id}";
            using(var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();
                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
            }

            _allComments.RemoveAll(tempComment => tempComment.Id == selectedComment.Id);
            OnShowComments?.Invoke(currentPost);            
        }

        public async void UpdateComment(int currentPost, string updateText, Comment selectedComment)
        {            
            var sqlExpression = $"UPDATE Comments SET c_text = '{updateText}' WHERE comments_ID = {selectedComment.Id}";
            using(var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();
                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
            }

            _allComments.First(tempComment => tempComment.Id == selectedComment.Id).Text = updateText;
            OnShowComments?.Invoke(currentPost);            
        }
    }
}
