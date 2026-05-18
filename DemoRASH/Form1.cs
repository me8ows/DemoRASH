using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DemoRASH
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        static string connectionString = @"Data Source=rashid;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection RashConnection = new SqlConnection(connectionString);

    }
}
