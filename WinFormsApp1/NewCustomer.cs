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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(
              "Data Source=COMP;initial Catalog=carshop;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                SqlCommand command = new SqlCommand("carshop.dbo.uspNewCustomer", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.VarChar,50));
                command.Parameters["@CustomerName"].Value = textBox1.Text;

                command.Parameters.Add(new SqlParameter("@CustomerLastName", SqlDbType.VarChar, 50));
                command.Parameters["@CustomerLastName"].Value = textBox2.Text;

                command.Parameters.Add(new SqlParameter("@CustomerPhone", SqlDbType.VarChar, 11));
                command.Parameters["@CustomerPhone"].Value = textBox3.Text;

                command.Parameters.Add(new SqlParameter("@CustomerAddress", SqlDbType.VarChar, 50));
                command.Parameters["@CustomerAddress"].Value = textBox4.Text;

                command.Connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(textBox1.Text + " " + textBox2.Text + " теперь в базе данных");
            }
        }
    }
}
