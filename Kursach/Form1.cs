using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        SqlConnection connect = new SqlConnection("Data Source=MS-sql\\sqlexpress;Initial Catalog=CallCentr;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            bool success = false;
            bool success1 = false;
            Form2 form2 = new Form2();
            try
            {
                const string comand = "Select * From Abonent WHERE Логин=@Логин AND Пароль=@Пароль";
                SqlCommand check = new SqlCommand(comand, connect);
                check.Parameters.AddWithValue("@Логин", textBox1.Text);
                check.Parameters.AddWithValue("@Пароль", textBox2.Text);
                using (var dataReader = check.ExecuteReader())
                {
                    success = dataReader.Read();
                }
            }
            finally
            {
                connect.Close();
            }
            if (success)
            {
                connect.Open();
                try
                {
                    const string comand = "Select * From Abonent WHERE Логин=@Логин AND Пароль=@Пароль AND Роль=@Роль";
                    SqlCommand check = new SqlCommand(comand, connect);
                    check.Parameters.AddWithValue("@Логин", textBox1.Text);
                    check.Parameters.AddWithValue("@Пароль", textBox2.Text);
                    check.Parameters.AddWithValue("@Роль", "Admin");
                    using (var dataReader = check.ExecuteReader())
                    {
                        success1 = dataReader.Read();
                    }
                }
                finally
                {
                    connect.Close();
                }
                if (success1)
                {
                    this.Hide();
                   form2.rol = "Admin";
                    form2.Show();
                }
                else
                {
                    this.Hide();
                    form2.rol = "Pols";
                    form2.Show();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
