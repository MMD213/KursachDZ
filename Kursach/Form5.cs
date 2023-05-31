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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=MS-sql\\sqlexpress;Initial Catalog=CallCentr;Integrated Security=True");
        int i = 0;
        int b = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {

                    string query = "INSERT INTO Abonent (ФИО, Тариф,Адрес,НомерТелефона,Логин,Пароль,Роль)";
                    query += "VALUES (@ФИО, @Тариф,@Адрес,@НомерТелефона,@Логин,@Пароль,@Роль)";
                    SqlCommand sqlCommand = new SqlCommand(query, connect);
                    sqlCommand.Parameters.AddWithValue("@ФИО", textBox2.Text);
                    sqlCommand.Parameters.AddWithValue("@Тариф", Convert.ToInt64(textBox3.Text));
                    sqlCommand.Parameters.AddWithValue("@Адрес", textBox4.Text);
                    sqlCommand.Parameters.AddWithValue("@НомерТелефона", textBox5.Text);
                    sqlCommand.Parameters.AddWithValue("@Логин", textBox7.Text);
                    sqlCommand.Parameters.AddWithValue("@Пароль", textBox8.Text);
                    sqlCommand.Parameters.AddWithValue("@Роль", textBox9.Text);
                    sqlCommand.ExecuteNonQuery();
                    i++;
                    textBox6.Text = "Добавлено " + i + " абонентов";
                

            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string query = "DELETE FROM [Abonent] WHERE id = " + Convert.ToInt64(textBox1.Text);
                    SqlCommand sqlCommand = new SqlCommand(query, connect);
                    sqlCommand.ExecuteNonQuery();
                    b++;
                    textBox6.Text = "Удалено " + b + " абонентов";
                }
                catch
                {
                    MessageBox.Show("Проверьте правидьность данных");
                }
            }
            else
            {
                MessageBox.Show("Заполните поле id");
            }
            connect.Close ();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
