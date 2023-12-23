namespace Vegetarian_Community.Scripts
{
    public sealed class Post
    {
        /// <summary>
        /// Класс поста
        /// </summary>
        /// <param name="currentId">Уникальный идентификатор поста</param>
        /// <param name="text">Заголовок поста</param>
        /// <param name="userId">Уникальный идентификатор пользователя, создавшего текущий пост</param>
        public Post(int currentId, string text, int userId)
        {
            Id = currentId;
            Text = text;
            UserId = userId;
        }

        /// <summary>
        /// Уникальный идентификатор поста
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Заголовок поста
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего текущий пост
        /// </summary>
        public int UserId { get; }
    }
}
