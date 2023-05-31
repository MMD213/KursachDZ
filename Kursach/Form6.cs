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

namespace Kursach
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=MS-sql\\sqlexpress;Initial Catalog=CallCentr;Integrated Security=True");
        int i = 0;
        int b = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                connect.Open();

                string query = "INSERT INTO Peregovor (Абонент, НачалоРазговора,КонецРазговора,IDГорода)";
                    query += "VALUES (@Абонент, @НачалоРазговора,@КонецРазговора, @IDГорода)";
                    SqlCommand sqlCommand = new SqlCommand(query, connect);
                    sqlCommand.Parameters.AddWithValue("@Абонент", Convert.ToInt64(textBox2.Text));
                    sqlCommand.Parameters.AddWithValue("@НачалоРазговора", Convert.ToDateTime(textBox3.Text));
                    sqlCommand.Parameters.AddWithValue("@IDГорода", Convert.ToInt32(textBox5.Text));
                    sqlCommand.Parameters.AddWithValue("@КонецРазговора", Convert.ToDateTime(textBox4.Text));
                    sqlCommand.ExecuteNonQuery();
                    i++;
                    textBox6.Text = "Добавлено " + i + " разговоров";

            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
            connect.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                connect.Open();
                try
                {
                    string query = "DELETE FROM [Peregovor] WHERE id = " + Convert.ToInt64(textBox1.Text);
                    SqlCommand sqlCommand = new SqlCommand(query, connect);
                    sqlCommand.ExecuteNonQuery();
                    b++;
                    textBox6.Text = "Удалено " + b + " разговоров";
                    connect.Close();
                }
                catch
                {
                    MessageBox.Show("Проверьте правильность данных");
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните поле id");
            }
        }
    }
}
