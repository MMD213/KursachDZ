using System;
using System.Collections.Generic;
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

namespace Kursach
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=MS-sql\\sqlexpress;Initial Catalog=CallCentr;Integrated Security=True");
        public string FIOID;
        public int a=0;

        private void Form7_Load(object sender, EventArgs e)
        {
            this.abonentTableAdapter.Fill(this.callCentrDataSet2.Abonent);
            Form2 form2 = new Form2();
            if (a == 0)
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Abonent WHERE id ='" + Convert.ToInt64(FIOID) + "'", connect);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Gorod WHERE id ='" + Convert.ToInt64(FIOID) + "'", connect);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
