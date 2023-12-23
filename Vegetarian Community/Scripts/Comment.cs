using System;

namespace Vegetarian_Community.Scripts
{
    public sealed class Comment
    {
        /// <summary>
        /// Класс комментария
        /// </summary>
        /// <param name="currentId">Уникальный идентификатор комментария</param>
        /// <param name="text">Текст комментария</param>
        /// <param name="time">Время написания комментария</param>
        /// <param name="userId">Уникальный идентификатор пользователя, написавшего текущий комментарий</param>
        /// <param name="postId">Уникальный идентификатор поста, под которым был написан текущий комментарий</param>
        public Comment(int currentId, string text, DateTime time, int userId, int postId)
        {
            Id = currentId;
            Text = text;
            Time = time;
            UserId = userId;
            PostId = postId;
        }

        /// <summary>
        /// Текст комментария
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Уникальный идентификатор комментария
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Время написания комментария
        /// </summary>
        public DateTime Time { get; }

        /// <summary>
        /// Уникальный идентификатор пользователя, написавшего текущий комментарий
        /// </summary>
        public int UserId { get; }

        /// <summary>
        /// Уникальный идентификатор поста, под которым был написан текущий комментарий
        /// </summary>
        public int PostId { get; }

        public override string ToString() => $"({ UserId }) : { Text } | { Time }";
    }
}
