using System.Linq;
using System.Windows.Forms;

namespace Vegetarian_Community.Scripts
{
    public sealed class App
    {
        private readonly PostsCollection _postCollection;
        private readonly CommentsCollection _commentsCollection;
        private readonly Label _title;
        private readonly ListBox _box;

        /// <summary>
        /// Основное приложение, в котором происходит взаимодействие компонентов
        /// </summary>
        /// <param name="postsCollection">Коллекция написанных постов</param>
        /// <param name="commentsCollection">Коллекция написанных комментариев</param>
        /// <param name="title">Label заголовка определенного поста</param>
        /// <param name="box">ListBox истории сообщений определенного поста</param>
        public App(PostsCollection postsCollection, CommentsCollection commentsCollection, Label title, ListBox box)
        {
            _postCollection = postsCollection;
            _commentsCollection = commentsCollection;
            _title = title;
            _box = box;


            _postCollection.OnShowPost += ShowPost;
            _commentsCollection.OnShowComments += ShowComments;
        }

        ~App()
        {
            _postCollection.OnShowPost -= ShowPost;
            _commentsCollection.OnShowComments -= ShowComments;
        }
       
        private void ShowPost(string titleText)
        {
            _title.Text = titleText;
            ShowComments(_postCollection.CurrentPost);
        }

        private void ShowComments(int currentPost)
        {
            _box.Items.Clear();
            var filteredComments = _commentsCollection.Collection
                .Where(comment => comment.PostId == currentPost);
            foreach (var item in filteredComments)
            {
                _box.Items.Add(item);
            }            
        }
    }
}
