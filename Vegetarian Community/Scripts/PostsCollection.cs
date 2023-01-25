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
    public sealed class PostsCollection
    {
        public event Action<string> OnMove;

        private const string CONNECTION_STRING = "dbConnectionString";
        private readonly string _configConnection = ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ConnectionString;

        private List<Post> _allPosts = new List<Post>();

        private int _currentPost = -1;

        public int CurrentPost => _currentPost;

        private int Count
        {
            get
            {
                var sqlExpression = $"SELECT MAX(posts_ID) FROM Posts";
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
        
        private string Title
        {
            get
            {
                string sqlExpression = $"SELECT p_title FROM Posts WHERE posts_ID = {_currentPost}";
                using (var connection = new SqlConnection(_configConnection))
                {
                    connection.Open();

                    var command = new SqlCommand(sqlExpression, connection);
                    return command.ExecuteScalar().ToString();
                }
            }
        }

        public void CreatePost(string title, int userId)
        {
            var post = new Post(Count, title, userId);
            InsertPost(post);
        }

        public void Move(bool isNextDirection = false)
        {
            if(isNextDirection && _currentPost < Count - 1)
            {                
                _currentPost++;
                OnMove?.Invoke(Title);                
            }
            else if(isNextDirection == false && _currentPost > 0)
            {                
                _currentPost--;
                OnMove?.Invoke(Title);
            }            
        }

        private async void InsertPost(Post post)
        {
            string sqlExpression = $"INSERT INTO Posts VALUES({post.Id}, '{post.Text}', {post.UserId})";
            using(var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();

                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
                _allPosts.Add(post);
            }
        }
    }
}
