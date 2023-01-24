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

namespace Vegetarian_Community
{
    public partial class Community : Form
    {
        private const string CONNECTION_STRING =
            "Server=DESKTOP-052MHJ6;Database=VegetarianCommunity;Trusted_Connection=True;";

        public Community()
        {
            InitializeComponent();
            Connection();
        }

        private async void Connection()
        {
            using(SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync();
                Console.WriteLine("Connection is opening!");
                Console.WriteLine($"Connection server: {connection.DataSource}");
            }
        }
    }
}
