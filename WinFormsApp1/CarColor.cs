using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;
using System.Data;


namespace WinFormsApp1
{
    public partial class CarColor : Form
    {
        public CarColor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(
   "Data Source=COMP;initial Catalog=carshop;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                SqlCommand command = new SqlCommand("carshop.dbo.f_car", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Color", SqlDbType.VarChar,50));
                command.Parameters["@Color"].Value = textBox1.Text;
                command.Connection.Open();
                textBox2.Text = command.ExecuteScalar().ToString();
                connection.Close();
            }
        }
    }
}
