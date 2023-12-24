using System;

namespace Vegetarian_Community.Scripts
{
    public sealed class Comment
    {
        /// <summary>
        /// Класс комментария
        /// </summary>
        /// <remarks>
        /// <para>Экземпляр класса комментария.</para>
        /// <para>Модель, которая будет сохранена в базе данных.</para>
        /// <para>
        /// <c>Содержит в себе:</c>
        /// <list type="table">
        /// <item><see cref="Text"/> - <see langword="string"/></item>
        /// <item><see cref="Id"/> - <see langword="int"/></item>
        /// <item><see cref="Time"/> - <see langword="dateTime"/></item>
        /// <item><see cref="UserId"/> - <see langword="int"/></item>
        /// <item><see cref="PostId"/> - <see langword="int"/></item>
        /// </list>
        /// </para>
        /// </remarks>
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

        /// <value>
        /// Текст комментария - <see langword="string"/>
        /// </value>
        /// <remarks>
        /// Текст комментария, который будет сохранен в базе данных.
        /// <para>В дальнейшем может быть изменен путем вызова метода <see cref="CommentsCollection.UpdateComment(int, string, Comment)"/></para>
        /// </remarks>
        public string Text { get; set; }

        /// <value>
        /// Уникальный идентификатор - <see langword="int"/>
        /// </value>
        /// <remarks>
        /// Уникальный идентификатор комментария, порядковый номер комментарий в базе данных.
        /// </remarks>
        public int Id { get; }

        /// <value>
        /// Время написания комментария - <see langword="dateTime"/>
        /// </value>
        /// <remarks>
        /// Время написания комментария, которое будет сохранено в базе данных.
        /// <para>В дальнейшем может быть изменено путем вызова метода <see cref="CommentsCollection.UpdateComment(int, string, Comment)"/></para>
        /// </remarks>
        public DateTime Time { get; }

        /// <value>
        /// Уникальный идентификатор пользователя, написавшего текущий комментарий - <see langword="int"/>
        /// </value>
        /// <remarks>
        /// Уникальный идентификатор пользователя, к которому привязан комментарий в базе данных.
        /// </remarks>
        public int UserId { get; }

        /// <value>
        /// Уникальный идентификатор поста, под которым был написан текущий комментарий - <see langword="int"/>
        /// </value>
        /// <remarks>
        /// Уникальный идентификатор поста, к которому привязан комментарий в базе данных.
        /// </remarks>
        public int PostId { get; }

        public override string ToString() => $"({ UserId }) : { Text } | { Time }";
    }
}
