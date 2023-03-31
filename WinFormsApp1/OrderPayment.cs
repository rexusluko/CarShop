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
    public partial class OrderPayment : Form
    {
        public OrderPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(
   "Data Source=COMP;initial Catalog=carshop;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                SqlCommand command = new SqlCommand("carshop.dbo.changeOrderPayment", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", SqlDbType.SmallInt));
                command.Parameters["@ID"].Value = Convert.ToInt16(textBox1.Text);

                command.Parameters.Add(new SqlParameter("@Payment", SqlDbType.SmallInt));
                command.Parameters["@Payment"].Value = Convert.ToInt16(textBox2.Text);

                command.Connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Изменение внесено в базу данных");
            }
        }
    }
}
