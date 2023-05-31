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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursach
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=MS-sql\\sqlexpress;Initial Catalog=CallCentr;Integrated Security=True");
        int i = 0;
        int b = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" )
            {
                try
                {

                    string query = "INSERT INTO Gorod (Город, Стоимость)";
                    query += "VALUES (@Город, @Стоимость)";
                    SqlCommand sqlCommand = new SqlCommand(query, connect);
                    sqlCommand.Parameters.AddWithValue("@Город", textBox2.Text);
                    sqlCommand.Parameters.AddWithValue("@Стоимость", Convert.ToDouble(textBox3.Text));
                    sqlCommand.ExecuteNonQuery();
                    i++;
                    textBox6.Text = "Добавлено " + i + " городов";
                }
                catch
                {
                    MessageBox.Show("Проверьте правильность данных");
                }
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    string query = "DELETE FROM [Gorod] WHERE id = " + Convert.ToInt64(textBox1.Text);
                    SqlCommand sqlCommand = new SqlCommand(query, connect);
                    sqlCommand.ExecuteNonQuery();
                    b++;
                    textBox6.Text = "Удалено " + b + " городов";
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
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            connect.Open();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
