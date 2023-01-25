using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vegetarian_Community.Scripts;

namespace Vegetarian_Community
{
    public partial class Community : Form
    {
        private UsersCollection _usersCollection = new UsersCollection();
        private PostsCollection _postsCollection = new PostsCollection();
        private CommentsCollection _commentsCollection = new CommentsCollection();

        private int _currentPost = 0;

        public Community()
        {            
            InitializeComponent();            
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if(_currentPost > _postsCollection.Count)
            {
                _currentPost++;
            }            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (_currentPost > 0)
            {
                _currentPost--;
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            var currentSex = male.Checked ? "Male" : "Female";
            _usersCollection.CreateUser(
                name.Text, 
                currentSex, 
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
                _currentPost,
                info);            
        }

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
    }
}
