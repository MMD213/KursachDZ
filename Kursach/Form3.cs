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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=MS-sql\\sqlexpress;Initial Catalog=CallCentr;Integrated Security=True");
        int i = 0;
        int b = 0;





        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text!=""&& textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "") {


                    string query = "INSERT INTO Tarif (Название, АбонентскаяПлата,ЛимитВремени,СкоростьИнтернетаКБС,ЛимитИнтернетаГБ,СтоимостьИнтернетаСверхЛимитаГБ,СтоимостьМинутСверхЛимита)";
                    query += "VALUES (@Название, @АбонентскаяПлата,@ЛимитВремени,@СкоростьИнтернетаКБС,@ЛимитИнтернетаГБ,@СтоимостьИнтернетаСверхЛимитаГБ,@СтоимостьМинутСверхЛимита)";
                    SqlCommand sqlCommand = new SqlCommand(query, connect);
                    sqlCommand.Parameters.AddWithValue("@Название", textBox2.Text);
                    sqlCommand.Parameters.AddWithValue("@АбонентскаяПлата", Convert.ToDouble(textBox3.Text));
                    sqlCommand.Parameters.AddWithValue("@ЛимитВремени", Convert.ToDateTime(textBox4.Text));
                    sqlCommand.Parameters.AddWithValue("@СкоростьИнтернетаКБС", Convert.ToInt64(textBox5.Text));
                    sqlCommand.Parameters.AddWithValue("@ЛимитИнтернетаГБ", Convert.ToInt64(textBox9.Text));
                    sqlCommand.Parameters.AddWithValue("@СтоимостьИнтернетаСверхЛимитаГБ", Convert.ToDouble(textBox8.Text));
                    sqlCommand.Parameters.AddWithValue("@СтоимостьМинутСверхЛимита", Convert.ToDouble(textBox7.Text));
                    sqlCommand.ExecuteNonQuery();
                    i++;
                    textBox6.Text ="Добавлено "+i+" тарифов";

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
                    string query = "DELETE FROM [Tarif] WHERE id = " +  Convert.ToInt64(textBox1.Text);
                    SqlCommand sqlCommand = new SqlCommand(query, connect);
                    sqlCommand.ExecuteNonQuery();
                    b++;
                    textBox6.Text ="Удалено "+b+" тарифов";
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

        private void Form3_Load(object sender, EventArgs e)
        {
            connect.Open();
        }
    }
}
