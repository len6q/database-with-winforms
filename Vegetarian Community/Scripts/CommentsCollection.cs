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
        private readonly List<Comment> _allComments = new List<Comment>();
        
        /// <summary>
        /// Коллекция комментариев
        /// </summary>
        public CommentsCollection()
        {
            FillBuffer();
        }

        #region Properties

        /// <summary>
        /// Список всех комментариев
        /// </summary>
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

        #endregion

        #region Public methods

        /// <summary>
        /// Создание экземпляра класса <see cref="Comment"/> и добавление его в базу данных
        /// </summary>
        /// <remarks>
        /// Создает комментарий <see cref="Comment"/>, добавляет его в базу данных и отображает в представлении
        /// <para>
        /// <c>Ожидается:</c>
        /// <para>Данные о комментарии сохраняются в БД, сервер генерирует и отправляет клиенту ответ.</para>
        /// </para>
        /// <para>
        /// <c>Последствия:</c>
        /// <para>Клиент отображает комментарий в представлении.</para>
        /// </para>
        /// </remarks>
        /// <param name="text">Текст комментария</param>
        /// <param name="userId">Уникальный идентификатор пользователя, написавшего текущий комментарий</param>
        /// <param name="postId">Уникальный идентификатор поста, под которым был написан текущий комментарий</param>
        public async void CreateComment(string text, int userId, int postId)
        {
            var comment = new Comment(MaxValue, text, DateTime.Now, userId, postId);
            await InsertComment(comment);
            OnShowComments?.Invoke(postId);
        }

        /// <summary>
        /// Удаление экземпляра класса <see cref="Comment"/> из базы данных
        /// </summary>
        /// <remarks>
        /// Удаляет комментарий <see cref="Comment"/> из базы данных и отображает в представлении
        /// <para>
        /// <c>Ожидается:</c>
        /// <para>Данные об изменении сохраняются в БД, сервер генерирует и отправляет клиенту ответ.</para>
        /// </para>
        /// <para>
        /// <c>Последствия:</c>
        /// <para>Клиент отображает изменения в представлении.</para>
        /// </para>
        /// </remarks>
        /// <param name="currentPost">Уникальный идентификатор поста, под которым был написан текущий комментарий</param>
        /// <param name="selectedComment">Экземпляр класса <see cref="Comment"/>, который будет удален</param>
        /// <exception cref="ArgumentNullException"></exception>
        public async void RemoveComment(int currentPost, Comment selectedComment)
        {
            var sqlExpression = $"DELETE Comments WHERE comments_ID = {selectedComment.Id}";
            using (var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();
                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
            }

            _allComments.RemoveAll(tempComment => tempComment.Id == selectedComment.Id);
            OnShowComments?.Invoke(currentPost);
        }

        /// <summary>
        /// Редактирование текста экземпляра класса <see cref="Comment"/> и сохранение изменений в базе данных.
        /// </summary>
        /// <remarks>
        /// Редактирование текста комментария <see cref="Comment"/>, сохранение изменений в базе данных и отображение его в представлении.
        /// <para>
        /// <c>Ожидается:</c>
        /// <para>Данные об изменении сохраняются в БД, сервер генерирует и отправляет клиенту ответ.</para>
        /// </para>
        /// <para>
        /// <c>Последствия:</c>
        /// <para>Клиент отображает изменения в представлении.</para>
        /// </para>
        /// </remarks>
        /// <param name="currentPost">Уникальный идентификатор поста, под которым был написан текущий комментарий</param>
        /// <param name="updateText">Новый текст комментария</param>
        /// <param name="selectedComment">Экземпляр класса <see cref="Comment"/>, который будет изменен</param>
        /// <exception cref="ArgumentNullException"></exception>
        public async void UpdateComment(int currentPost, string updateText, Comment selectedComment)
        {
            var sqlExpression = $"UPDATE Comments SET c_text = '{updateText}' WHERE comments_ID = {selectedComment.Id}";
            using (var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();
                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
            }

            _allComments.First(tempComment => tempComment.Id == selectedComment.Id).Text = updateText;
            OnShowComments?.Invoke(currentPost);
        }

        #endregion

        #region Private methods

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

        private async Task InsertComment(Comment comment)
        {
            string sqlExpression = $"INSERT INTO Comments VALUES({comment.Id}, '{comment.Text}', " +
                $"'{comment.Time}', {comment.UserId}, {comment.PostId})";
            using (var connection = new SqlConnection(_configConnection))
            {
                await connection.OpenAsync();
                var command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
                _allComments.Add(comment);
            }
        }

        #endregion
    }
}
