using System.Linq;
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

            _postCollection.OnShowPost += ShowPost;
            _commentsCollection.OnShowComments += ShowComments;
        }

        ~AppView()
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
            var filteredComments = _commentsCollection.Collection.Where(comment => comment.PostId == currentPost);
            foreach (var item in filteredComments)
            {
                _box.Items.Add(item);
            }            
        }
    }
}
