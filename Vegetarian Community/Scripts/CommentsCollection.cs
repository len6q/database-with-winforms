using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vegetarian_Community.Scripts
{
    public sealed class CommentsCollection
    {        
        private const string CONNECTION_STRING = "dbConnectionString";
        private readonly string _configConnection = ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ConnectionString;

        private List<Comment> _allComments = new List<Comment>();
        
        public CommentsCollection()
        {
            FillBuffer();
        }

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

        public async void CreateComment(string text, int userId, int postId, ListBox chat)
        {
            var comment = new Comment(MaxValue, text, DateTime.Now, userId, postId);
            await InsertComment(comment);
            ShowComments(postId, chat);
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

        public void ShowComments(int currentPost, ListBox infoBox)
        {
            infoBox.Items.Clear();
            var filteredComments = _allComments.Where(comment => comment.PostId == currentPost);
            foreach(var item in filteredComments)
            {
                infoBox.Items.Add(item);
            }                       
        }

        public async void RemoveComment(int currentPost, ListBox infoBox)
        {
            var comment = (Comment)infoBox.SelectedItem;
            var sqlExpression = $"DELETE Comments WHERE comments_ID = {comment.Id}";
            using(var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();
                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
            }

            _allComments.RemoveAll(tempComment => tempComment.Id == comment.Id);
            ShowComments(currentPost, infoBox);
        }

        public async void UpdateComment(int currentPost, string updateText, ListBox infoBox)
        {
            var comment = (Comment)infoBox.SelectedItem;
            var sqlExpression = $"UPDATE Comments SET c_text = '{updateText}' WHERE comments_ID = {comment.Id}";
            using(var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();
                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
            }

            _allComments.First(tempComment => tempComment.Id == comment.Id).Text = updateText;            
            ShowComments(currentPost, infoBox);
        }
    }
}
