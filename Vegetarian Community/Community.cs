using System;
using System.Windows.Forms;
using Vegetarian_Community.Scripts;

namespace Vegetarian_Community
{
    public partial class Community : Form
    {
        private UsersCollection _usersCollection;
        private PostsCollection _postsCollection;
        private CommentsCollection _commentsCollection;

        public Community()
        {            
            InitializeComponent();        
        }

        private void Community_Load(object sender, EventArgs e)
        {
            _usersCollection = new UsersCollection();
            _postsCollection = new PostsCollection();
            _commentsCollection = new CommentsCollection();
            
            new App(_postsCollection, _commentsCollection, l_title_post, info);            
        }
        
        private void forwardBtn_Click(object sender, EventArgs e) => _postsCollection.Move(true);           

        private void backBtn_Click(object sender, EventArgs e) => _postsCollection.Move();

        private void addUser_Click(object sender, EventArgs e)
        {
            _usersCollection.CreateUser(
                name.Text,
                male.Checked ? "Male" : "Female", 
                Convert.ToInt32(age.Text));            
        }

        private void addPost_Click(object sender, EventArgs e)
        {
            _postsCollection.CreatePost(
                p_title.Text,
                Convert.ToInt32(p_user_id.Text));
        }

        private void addComment_Click(object sender, EventArgs e)
        {
            _commentsCollection.CreateComment(
                c_text.Text,
                Convert.ToInt32(c_user_id.Text),
                _postsCollection.CurrentPost
                );
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(info.SelectedItem != null)
            {
                _commentsCollection.RemoveComment(
                    _postsCollection.CurrentPost,
                    (Comment)info.SelectedItem);
            }            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if(info.SelectedItem != null)
            {
                _commentsCollection.UpdateComment(
                    _postsCollection.CurrentPost,
                    updateText.Text,
                    (Comment)info.SelectedItem);
            }
        }

        #region
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void info_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void posts_Enter(object sender, EventArgs e)
        {

        }

        private void users_Enter(object sender, EventArgs e)
        {

        }
        #endregion
    }  
}
