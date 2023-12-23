using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Vegetarian_Community.Scripts
{
    public sealed class PostsCollection
    {
        public event Action<string> OnShowPost;

        private const string CONNECTION_STRING = "dbConnectionString";
        private readonly string _configConnection = ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ConnectionString;
        private readonly List<Post> _allPosts = new List<Post>();

        /// <summary>
        /// Коллекция постов
        /// </summary>
        public PostsCollection() { }

        #region Properties

        /// <summary>
        /// Уникальный идентификатор текущего отображаемого поста
        /// </summary>
        public int CurrentPost { get; private set; } = -1;

        private int MaxValue
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
                string sqlExpression = $"SELECT p_title FROM Posts WHERE posts_ID = {CurrentPost}";
                using (var connection = new SqlConnection(_configConnection))
                {
                    connection.Open();

                    var command = new SqlCommand(sqlExpression, connection);
                    return command.ExecuteScalar().ToString();
                }
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Создание экземпляра класса <see cref="Post"/> и добавление его в базу данных
        /// </summary>
        /// <param name="title">Заголовок поста</param>
        /// <param name="userId">Уникальный идентификатор пользователя, создавшего текущий пост</param>
        public void CreatePost(string title, int userId)
        {
            var post = new Post(MaxValue, title, userId);
            InsertPost(post);
        }

        /// <summary>
        /// Переключение текущего поста на следующий/предыдущий
        /// </summary>
        /// <param name="isNextDirection">Задает направление какой пост будет выбран. По умолчанию предыдущий</param>
        public void Move(bool isNextDirection = false)
        {
            if(isNextDirection && CurrentPost < MaxValue - 1)
            {
                CurrentPost++;
                OnShowPost?.Invoke(Title);                
            }
            else if(isNextDirection == false && CurrentPost > 0)
            {
                CurrentPost--;
                OnShowPost?.Invoke(Title);
            }            
        }

        #endregion

        #region Private methods

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

        #endregion
    }
}
