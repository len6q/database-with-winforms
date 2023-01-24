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
        private UsersFactory _factory = new UsersFactory();
        private string _currentSex;

        public Community()
        {            
            InitializeComponent();            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            var user = new User(
                Convert.ToInt32(id.Text),
                name.Text,
                _currentSex,
                Convert.ToInt32(age.Text));
            _factory.InsertUser(user);
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            _currentSex = "Male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            _currentSex = "Female";
        }
    }
}
