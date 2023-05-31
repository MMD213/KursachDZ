using Kursach.CallCentrDataSet3TableAdapters;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection  connect = new SqlConnection("Data Source=MS-sql\\sqlexpress;Initial Catalog=CallCentr;Integrated Security=True");
        int i = 0;
        public string s = "";
        public string rol;
        string pola;

        private void Form2_Load(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            if (rol == "Admin")
            {
                
            }
            else
            {
                dataGridView1.Enabled = false;
                dataGridView2.Enabled = false;
                dataGridView3.Enabled = false;
                dataGridView4.Enabled = false;
                button1.Visible = false;
                button6.Visible = false;
                button2.Size = new System.Drawing.Size(274,159);
                button2.Location = new System.Drawing.Point(12, 393);
                button12.Visible = false;
                button7.Visible = false;
                button8.Location = new System.Drawing.Point(803,154);
                button8.Size = new System.Drawing.Size(323,64);
                button17.Visible = false;
                button18.Visible = false;
                button19.Size = new System.Drawing.Size(953, 97);
                button19.Location = new System.Drawing.Point(9,450);
                button24.Visible = false;
                button23.Visible = false;
                button25.Size = new System.Drawing.Size(195, 147);
                button25.Location = new System.Drawing.Point(935, 73);
            }
            
            this.abonentTableAdapter1.Fill(this.callCentrDataSet4.Abonent);
            this.peregovorTableAdapter.Fill(this.callCentrDataSet3.Peregovor);
            this.abonentTableAdapter.Fill(this.callCentrDataSet2.Abonent);
            this.gorodTableAdapter.Fill(this.callCentrDataSet1.Gorod);
            this.tarifTableAdapter.Fill(this.callCentrDataSet.Tarif);
            dataGridView3.DataSource = this.callCentrDataSet4.Abonent;
            connect.Open();
            string Sql = "select ЛимитИнтернетаГБ from Tarif";
            SqlCommand cmd = new SqlCommand(Sql, connect);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox1.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox1.Items.Add(DR[0]);
                }
            }
            connect.Close();
            connect.Open();
            Sql = "select СкоростьИнтернетаКБС from Tarif";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox2.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox2.Items.Add(DR[0]);
                }
            }
            connect.Close();
            connect.Open();
            Sql = "select АбонентскаяПлата from Tarif";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox3.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox3.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select ЛимитВремени from Tarif";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox4.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox4.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select СтоимостьИнтернетаСверхЛимитаГБ from Tarif";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox5.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox5.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select СтоимостьМинутСверхЛимита from Tarif";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox6.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox6.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select Город from Gorod";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox12.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox12.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select Стоимость from Gorod";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox9.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox9.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select ФИО from Abonent";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox14.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox14.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select Роль from Abonent";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox13.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox13.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select Тариф from Abonent";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox10.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox10.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select Адрес from Abonent";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox11.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox11.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select Абонент from Peregovor";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox16.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox16.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select НачалоРазговора from Peregovor";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox15.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox15.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select КонецРазговора from Peregovor";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox7.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox7.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select IDГорода from Peregovor";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox8.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox8.Items.Add(DR[0]);
                }
            }
            connect.Close();
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            string Sql = "select ЛимитИнтернетаГБ from Tarif";
            SqlCommand cmd = new SqlCommand(Sql, connect);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox1.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox1.Items.Add(DR[0]);
                }
            }
            connect.Close();
            connect.Open();
            Sql = "select СкоростьИнтернетаКБС from Tarif";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox2.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox2.Items.Add(DR[0]);
                }
            }
            connect.Close();
            connect.Open();
            Sql = "select АбонентскаяПлата from Tarif";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox3.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox3.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select ЛимитВремени from Tarif";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox4.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox4.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select СтоимостьИнтернетаСверхЛимитаГБ from Tarif";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox5.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox5.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select СтоимостьМинутСверхЛимита from Tarif";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox6.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox6.Items.Add(DR[0]);
                }
            }
            connect.Close();
            this.tarifTableAdapter.Fill(this.callCentrDataSet.Tarif);
            dataGridView1.DataSource = callCentrDataSet.Tarif;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            textBox5.Text  = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                dataGridView1.DataSource = SearchI(textBox1.Text,"Tarif","Название","Str").Tables[0];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try
                {
                    dataGridView1.DataSource = SearchI(textBox1.Text,"Tarif","ЛимитИнтернетаГб","INT").Tables[0];
                } catch {
                    MessageBox.Show("Введите число");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try
                {
                    dataGridView1.DataSource = SearchI(textBox1.Text,"Tarif","id", "INT").Tables[0];
                }
                catch
                {
                    MessageBox.Show("Введите правильный ID");
                }
            }
        }

        private void dataGridView1_CellErrorTextChanged(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Введите правельные данные");
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введите правельные данные");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                tarifTableAdapter.Update(callCentrDataSet);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try
                {
                    dataGridView2.DataSource = SearchI(textBox2.Text,"Gorod","id","INT").Tables[0];
                }
                catch
                {
                    MessageBox.Show("Введите правильный ID");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                dataGridView2.DataSource = SearchI(textBox2.Text,"Gorod","Город","Str").Tables[0];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try {
                    dataGridView2.DataSource = SearchI(textBox2.Text,"Gorod","Стоимость","Dob").Tables[0];
                } 
                catch { 
                    MessageBox.Show("Проверьте правильность данных"); }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            connect.Open();
            string Sql = "select Город from Gorod";
            SqlCommand cmd = new SqlCommand(Sql, connect);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox12.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox12.Items.Add(DR[0]);
                }
            }
            connect.Close();
            connect.Open();
            Sql = "select Стоимость from Gorod";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox9.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox9.Items.Add(DR[0]);
                }
            }
            connect.Close();
            this.gorodTableAdapter.Fill(this.callCentrDataSet1.Gorod);
            dataGridView2.DataSource = callCentrDataSet1.Gorod;
            comboBox12.Text = "";
            comboBox9.Text = "";
            textBox6.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                gorodTableAdapter.Update(callCentrDataSet1);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных");
            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введите правельные данные");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                abonentTableAdapter1.Update(callCentrDataSet4);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string Sql = "select ФИО from Abonent";
                SqlCommand cmd = new SqlCommand(Sql, connect);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    if (comboBox14.Items.Contains(DR[0]))
                    {

                    }
                    else
                    {
                        comboBox14.Items.Add(DR[0]);
                    }
                }
                connect.Close();
                connect.Open();
                Sql = "select Роль from Abonent";
                cmd = new SqlCommand(Sql, connect);
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    if (comboBox13.Items.Contains(DR[0]))
                    {

                    }
                    else
                    {
                        comboBox13.Items.Add(DR[0]);
                    }
                }
                connect.Close();

                connect.Open();
                Sql = "select Тариф from Abonent";
                cmd = new SqlCommand(Sql, connect);
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    if (comboBox10.Items.Contains(DR[0]))
                    {

                    }
                    else
                    {
                        comboBox10.Items.Add(DR[0]);
                    }
                }
                connect.Close();
                connect.Open();
                Sql = "select Адрес from Abonent";
                cmd = new SqlCommand(Sql, connect);
                DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    if (comboBox11.Items.Contains(DR[0]))
                    {

                    }
                    else
                    {
                        comboBox11.Items.Add(DR[0]);
                    }
                }
                connect.Close();
                this.abonentTableAdapter1.Fill(this.callCentrDataSet4.Abonent);
                dataGridView3.DataSource = callCentrDataSet4.Abonent;
                textBox7.Text = "";
                comboBox14.Text = "";
                comboBox13.Text = "";
                comboBox10.Text = "";
                comboBox11.Text = "";
            }
            catch {connect.Close();}
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try
                {
                    dataGridView3.DataSource = SearchI(textBox3.Text,"Abonent","id","INT").Tables[0];
                }

                catch
                {
                    MessageBox.Show("Введите правильный ID");
                }
            }
        }

        public DataSet SearchI(String a, String b, String c, String d)
        {
            connect.Open();
            DataSet ds = new DataSet();
            try {

                if (d == "INT")
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From " + b + " WHERE " + c + "= + '" + Convert.ToInt64(a) + "'", connect);
                    dataAdapter.Fill(ds);
                }
                if (d == "Dob")
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From " + b + " WHERE " + c + "= + '" + Convert.ToDouble(a) + "'", connect);
                    dataAdapter.Fill(ds);
                }
                if (d == "Str")
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From " + b + " WHERE " + c + " = +'" + a + "'", connect);
                    dataAdapter.Fill(ds);
                }
                if (d == "Time")
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From " + b + " WHERE " + c + "= + '" + Convert.ToDateTime(a) + "'", connect);
                    dataAdapter.Fill(ds);
                }
                connect.Close();
              
            }
            catch { }
            return ds;
        }


        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try
                {
                    dataGridView3.DataSource = SearchI(textBox3.Text, "Abonent", "ФИО","Str").Tables[0];
                }
                catch
                {
                    MessageBox.Show("Введите правильное ФИО");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try
                {
                    dataGridView3.DataSource = SearchI(textBox3.Text, "Abonent", "Логин","Str").Tables[0];
                }
                catch
                {
                    MessageBox.Show("Введите правильный адрес");
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try
                {
                    dataGridView3.DataSource = SearchI(textBox3.Text, "Abonent", "НомерТелефона","Str").Tables[0];
                }
                catch
                {
                    MessageBox.Show("Введите правильный номер");
                }
            }
        }


        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try
                {
                    dataGridView4.DataSource = SearchI(textBox4.Text, "Peregovor", "id", "INT").Tables[0];
                }

                catch
                {
                    MessageBox.Show("Введите правильный ID");
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try
                {
                    dataGridView4.DataSource = SearchI(textBox4.Text, "Peregovor", "НачалоРазговора","Time").Tables[0];
                }

                catch
                {
                    MessageBox.Show("Введите правильный ID");
                }
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("Заполните поле");
            }
            else
            {
                try
                {
                    dataGridView4.DataSource = SearchI(textBox4.Text, "Peregovor", "КонецРазговора","Time").Tables[0];
                }
                catch
                {
                    MessageBox.Show("Введите правильный ID");
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверьте правильность введённых данных");
        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Проверьте правильность введённых данных");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            String das1 = "SELECT Peregovor.id, Peregovor.НачалоРазговора, Peregovor.КонецРазговора, Abonent.ФИО, Gorod.Город FROM Peregovor INNER JOIN Abonent ON Peregovor.Абонент = Abonent.id INNER JOIN Gorod ON Peregovor.IDГорода = Gorod.id";
            SqlDataAdapter das = new SqlDataAdapter(das1, connect);
            DataSet dataSet = new DataSet();
            das.Fill(dataSet);
            dataGridView4.DataSource = dataSet.Tables[0];
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
        private int Proverka()
        {
            i = 0;
            if (comboBox1.Text != "")
            {
                i = i + 1;
            }
            if (comboBox2.Text != "")
            {
                i = i + 1;
            }
            if (comboBox3.Text != "")
            {
                i = i + 1;
            }
            if (comboBox4.Text != "")
            {
                i = i + 1;
            }
            if (comboBox5.Text != "")
            {
                i = i + 1;
            }
            if (comboBox6.Text != "")
            {
                i = i + 1;
            }
            return i;
        }
        public void Filtr()
        {  
            string ilter = "Select * From Tarif WHERE ";
            string filter="";
            pola = "Фильтрация по ";
            if (comboBox1.Text != "")
            {
                if (filter != "") {filter += " AND "; pola+=", "; }
                filter += "ЛимитИнтернетаГБ ='" + Convert.ToInt64(comboBox1.Text) + "'";
                pola += "лимиту интернета "+ comboBox1.Text;
            }
            if (comboBox2.Text != ""){
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "СкоростьИнтернетаКБС ='" + Convert.ToInt64(comboBox2.Text) + "'";
                pola += "скорости интернета КБ/С " + comboBox2.Text;
            }
            if (comboBox3.Text != ""){
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "АбонентскаяПлата = '" + Convert.ToDouble(comboBox3.Text) + "'";
                pola += "абонентской плате " + comboBox3.Text;
            }
            if (comboBox4.Text != ""){
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "ЛимитВремени = '" + Convert.ToDateTime(comboBox4.Text) + "'";
                pola += "лимиту времени " + comboBox4.Text;
            }
            if (comboBox5.Text != ""){
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "СтоимостьИнтернетаСверхЛимитаГБ = '" + Convert.ToDouble(comboBox5.Text) + "'";
                pola += "стоимости интернета сверх лимита за один ГБ " + comboBox5.Text;
            }
            if (comboBox6.Text != ""){
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "СтоимостьМинутСверхЛимита = '" + Convert.ToDouble(comboBox6.Text) + "'";
                pola += "стоимости минут сверх лимита " + comboBox6.Text;
            }  
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter =new SqlDataAdapter(ilter+filter,connect);
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            textBox5.Text = pola;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Proverka() == 1)
            {
                try
                {
                    textBox5.Text = "Фильтрация по лимиту интернета: "+comboBox1.Text;
                    dataGridView1.DataSource = SearchI(comboBox1.Text, "Tarif", "ЛимитИнтернетаГБ", "INT").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr();
            }
            
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Proverka() == 1)
            {
                try
                {
                    textBox5.Text = "Фильтрация по лимиту времени: "+comboBox4.Text;
                    dataGridView1.DataSource = SearchI(comboBox4.Text, "Tarif", "ЛимитВремени", "Time").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr();
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Proverka() == 1)
            {
                try
                {
                    textBox5.Text = "Фильтрация по абонентской плате: "+comboBox3.Text;
                    dataGridView1.DataSource = SearchI(comboBox3.Text, "Tarif", "АбонентскаяПлата", "Dob").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Proverka() == 1)
            {
                try
                {
                    textBox5.Text = "Фильтрация по скорости интернета: "+comboBox2.Text;
                    dataGridView1.DataSource = SearchI(comboBox2.Text, "Tarif", "СкоростьИнтернетаКБС", "INT").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr();
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Proverka() == 1)
            {
                try
                {
                    textBox5.Text = "Фильтрация по стоимости интернета сверх лимита: "+comboBox5.Text;
                    dataGridView1.DataSource = SearchI(comboBox5.Text, "Tarif", "СтоимостьИнтернетаСверхЛимитаГБ", "Dob").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr();
            }

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Proverka() == 1)
            {
                try
                {
                    textBox5.Text = "Фильтрация по стоимости минут сверх лимита: "+comboBox6.Text;
                    dataGridView1.DataSource = SearchI(comboBox6.Text, "Tarif", "СтоимостьМинутСверхЛимита", "Dob").Tables[0];
                }catch { }
            }
            else
            {
                Filtr();
            }

           
        }

        private void dataGridView4_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = e.ColumnIndex;
            int b = e.RowIndex;
            s = dataGridView4.Rows[b].Cells[i].Value.ToString();
            if (i == 1)
            {
                if (s != "")
                {
                    Form7 form7 = new Form7();
                    form7.FIOID = s;
                    form7.Show();
                }
            }
            if (i == 4)
            {
                if (s != "")
                {
                    Form7 form7 = new Form7();
                    form7.a = 1;
                    form7.FIOID = s;
                    form7.Show();
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
        private int ProverkaTab2()
        {
            i = 0;
            if (comboBox12.Text != "")
            {
                i = i + 1;
            }
            if (comboBox9.Text != "")
            {
                i = i + 1;
            }
            return i;
        }
        public void Filtr2()
        {
            string ilter = "Select * From Gorod WHERE ";
            string filter = "";
            pola = "Фильтрация по";


            if (comboBox12.Text != "")
            {
                if (filter != "") { filter += " AND ";pola += ", "; }
                filter += "Город ='" +comboBox12.Text + "'";
                pola += "городу "+comboBox12.Text;
            }
            if (comboBox9.Text != "")
            {
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "Стоимость ='" + Convert.ToDouble(comboBox9.Text) + "'";
                pola += "стоимости "+comboBox9.Text;
            }
            

            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(ilter + filter, connect);
            dataAdapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            textBox6.Text = pola;


        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProverkaTab2() == 1)
            {
                try
                {
                    textBox6.Text = "Фильтрация по названию города: "+comboBox12.Text;
                    dataGridView2.DataSource = SearchI(comboBox12.Text, "Gorod", "Город", "Str").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr2();
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProverkaTab2() == 1)
            {
                try
                {
                    textBox6.Text = "Фильтрация по стоимости: "+comboBox9.Text;
                    dataGridView2.DataSource = SearchI(comboBox9.Text, "Gorod", "Стоимость", "Dob").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr2();
            }
        }
        public void Filtr3()
        {
            string ilter = "Select * From Abonent WHERE ";
            string filter = "";
            pola = "Фильтрация по";


            if (comboBox14.Text != "")
            {
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "ФИО ='" + comboBox14.Text + "'";
                pola += "ФИО " + comboBox14.Text;
            }
            if (comboBox13.Text != "")
            {
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "Роль ='" + comboBox13.Text + "'";
                pola += "роли " + comboBox13.Text;
            }
            if (comboBox10.Text != "")
            {
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "Тариф ='" + Convert.ToInt64(comboBox10.Text) + "'";
                pola += "тарифу " + comboBox10.Text;
            }
            if (comboBox11.Text != "")
            {
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "Адрес ='" + comboBox11.Text + "'";
                pola += "адресу " + comboBox11.Text;
            }
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(ilter + filter, connect);
            dataAdapter.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            textBox7.Text = pola;
        }
        private int ProverkaTab3()
        {
            i = 0;
            if (comboBox14.Text != "")
            {
                i = i + 1;
            }
            if (comboBox13.Text != "")
            {
                i = i + 1;
            }
            if (comboBox10.Text != "")
            {
                i = i + 1;
            }
            if (comboBox11.Text != "")
            {
                i = i + 1;
            }
            return i;
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProverkaTab3() == 1)
            {
                try
                {
                    textBox7.Text = "Фильтрация по ФИО: " + comboBox14.Text;
                    dataGridView3.DataSource = SearchI(comboBox14.Text, "Abonent", "ФИО", "Str").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr3();
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProverkaTab3() == 1)
            {
                try
                {
                    textBox7.Text = "Фильтрация по роли: " + comboBox13.Text;
                    dataGridView3.DataSource = SearchI(comboBox13.Text, "Abonent", "Роль", "Str").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr3();
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProverkaTab3() == 1)
            {
                try
                {
                    textBox7.Text = "Фильтрация по тарифу: " + comboBox10.Text;
                    dataGridView3.DataSource = SearchI(comboBox10.Text, "Abonent", "Тарифу", "INT").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr3();
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProverkaTab3() == 1)
            {
                try
                {
                    textBox7.Text = "Фильтрация по адресу: " + comboBox11.Text;
                    dataGridView3.DataSource = SearchI(comboBox11.Text, "Abonent", "Адрес", "Str").Tables[0];
                }
                catch { }
            }
            else
            {
                Filtr3();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            connect.Open();
            string Sql = "select Абонент from Peregovor";
            SqlCommand cmd = new SqlCommand(Sql, connect);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox16.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox16.Items.Add(DR[0]);
                }
            }
            connect.Close();
            connect.Open();
            Sql = "select НачалоРазговора from Peregovor";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox15.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox15.Items.Add(DR[0]);
                }
            }
            connect.Close();

            connect.Open();
            Sql = "select КонецРазговора from Peregovor";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox7.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox7.Items.Add(DR[0]);
                }
            }
            connect.Close();
            connect.Open();
            Sql = "select IDГорода from Peregovor";
            cmd = new SqlCommand(Sql, connect);
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                if (comboBox8.Items.Contains(DR[0]))
                {

                }
                else
                {
                    comboBox8.Items.Add(DR[0]);
                }
            }
            connect.Close();
            this.peregovorTableAdapter.Fill(this.callCentrDataSet3.Peregovor);
            dataGridView4.DataSource = callCentrDataSet3.Peregovor;
            textBox8.Text = "";
            comboBox16.Text = "";
            comboBox15.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
        }
        public void Filtr4()
        {
            string ilter = "Select * From Peregovor WHERE ";
            string filter = "";
            pola = "Фильтрация по";


            if (comboBox16.Text != "")
            {
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "Абонент ='" + Convert.ToInt64(comboBox16.Text) + "'";
                pola += "ID абонента " + comboBox16.Text;
            }
            if (comboBox15.Text != "")
            {
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "НачалоРазговора ='" + Convert.ToDateTime(comboBox15.Text) + "'";
                pola += "началу разговора " + comboBox15.Text;
            }
            if (comboBox7.Text != "")
            {
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "КонецРазговора ='" + Convert.ToDateTime(comboBox7.Text) + "'";
                pola += "концу разговора " + comboBox7.Text;
            }
            if (comboBox8.Text != "")
            {
                if (filter != "") { filter += " AND "; pola += ", "; }
                filter += "IDГорода ='" + Convert.ToInt64(comboBox8.Text) + "'";
                pola += "ID города " + comboBox8.Text;
            }
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(ilter + filter, connect);
            dataAdapter.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];
            textBox8.Text = pola;
        }
        private int ProverkaTab4()
        {
            i = 0;
            if (comboBox16.Text != "")
            {
                i = i + 1;
            }
            if (comboBox15.Text != "")
            {
                i = i + 1;
            }
            if (comboBox7.Text != "")
            {
                i = i + 1;
            }
            if (comboBox8.Text != "")
            {
                i = i + 1;
            }
            return i;
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

                    textBox8.Text = "Фильтрация по ID абонента: " + comboBox16.Text;

                Filtr4();
            
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

                    textBox8.Text = "Фильтрация по началу разговора: " + comboBox15.Text;

                Filtr4();
            
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

                    textBox8.Text = "Фильтрация по адресу: " + comboBox7.Text;

                Filtr4();
            
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

                    textBox8.Text = "Фильтрация по ID города: " + comboBox8.Text;

                Filtr4();
            
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            try
            {
                peregovorTableAdapter.Update(callCentrDataSet3);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelApp.Cells[1, 1] = "ID";
            ExcelApp.Cells[1, 2] = "Название";
            ExcelApp.Cells[1, 3] = "Абонентская плата";
            ExcelApp.Cells[1, 4] = "Лимит времени";
            ExcelApp.Cells[1, 5] = "Скорость интернета КБ/С";
            ExcelApp.Cells[1, 6] = "Лимит интернета Гб";
            ExcelApp.Cells[1, 7] = "Стоимость интернета сверх лимита Гб";
            ExcelApp.Cells[1, 8] = "Стоимость минут сверх лимита";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelApp.Cells[1, 1] = "ID";
            ExcelApp.Cells[1, 2] = "Город";
            ExcelApp.Cells[1, 3] = "Стоимость";
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelApp.Cells[1, 1] = "ID";
            ExcelApp.Cells[1, 2] = "ФИО";
            ExcelApp.Cells[1, 3] = "Номер телефона";
            ExcelApp.Cells[1, 4] = "Адрес";
            ExcelApp.Cells[1, 5] = "ID тарифа";
            ExcelApp.Cells[1, 6] = "Логин";
            ExcelApp.Cells[1, 7] = "Пароль";
            ExcelApp.Cells[1, 8] = "Роль";
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView3.Rows[i].Cells[j].Value.ToString();
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelApp.Cells[1, 1] = "ID";
            ExcelApp.Cells[1, 2] = "ID абонента";
            ExcelApp.Cells[1, 3] = "Начало разговора";
            ExcelApp.Cells[1, 4] = "Конец разговора";
            ExcelApp.Cells[1, 5] = "ID города";
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView4.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView4.Rows[i].Cells[j].Value.ToString();
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
