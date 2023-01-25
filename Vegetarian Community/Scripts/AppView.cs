using System.Windows.Forms;

namespace Vegetarian_Community.Scripts
{
    public sealed class AppView
    {
        private PostsCollection _postCollection;
        private CommentsCollection _commentsCollection;
        private Label _title;
        private ListBox _box;

        public AppView(PostsCollection postsCollection, CommentsCollection commentsCollection, Label title, ListBox box)
        {
            _postCollection = postsCollection;
            _commentsCollection = commentsCollection;
            _title = title;
            _box = box;

            _postCollection.OnMove += ShowPost;
        }

        ~AppView()
        {
            _postCollection.OnMove -= ShowPost;
        }
       
        private void ShowPost(string titleText)
        {
            _title.Text = titleText;
            _commentsCollection.ShowComments(_postCollection.CurrentPost, _box);
        }
    }
}
