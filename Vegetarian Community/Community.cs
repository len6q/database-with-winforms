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
        private UsersCollection _collection = new UsersCollection();        

        public Community()
        {            
            InitializeComponent();            
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            var currentSex = male.Checked ? "Male" : "Female";
            var user = new User(
                name.Text,
                currentSex,
                Convert.ToInt32(age.Text));
            _collection.InsertUser(user);
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

        private void addPost_Click(object sender, EventArgs e)
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
