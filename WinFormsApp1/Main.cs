using System.Reflection;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int a;
        public string conncecntion_string = "Data Source=COMP;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static bool Check(string ID,string LastName)
        {
            Assembly SqlClient =
               Assembly.Load("System.Data.SqlClient, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
            using (SqlConnection connection = new SqlConnection(
               "Data Source=COMP;initial Catalog=carshop;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                SqlCommand command = new SqlCommand("carshop.dbo.f_employee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", SqlDbType.SmallInt));
                command.Parameters["@ID"].Value = Convert.ToInt16(ID);
                command.Connection.Open();
                string result = command.ExecuteScalar().ToString();
                connection.Close();
                return LastName == result;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check(textBox1.Text, textBox2.Text))
            {
                Form frm = new NewCustomer();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ошибка! Проверьте ID и Фамилию");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Check(textBox1.Text, textBox2.Text))
            {
                Form frm = new CarColor();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ошибка! Проверьте ID и Фамилию");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Check(textBox1.Text, textBox2.Text))
            {
                Form frm = new OrderPayment();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ошибка! Проверьте ID и Фамилию");
            }
        }
    }
    }
