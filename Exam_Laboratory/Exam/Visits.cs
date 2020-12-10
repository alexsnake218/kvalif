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


namespace Exam
{
    public partial class Visits : Form
    {
        public Visits()
        {
            InitializeComponent();
        }

        private void Visits_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private async void FillTable()
        {
            SqlConnection sqlConnection = new SqlConnection(SqlManager.connectionString);
            await sqlConnection.OpenAsync();

            SqlCommand showEvents = new SqlCommand("SELECT login, FIO_pacient, last_enter FROM Pacients", sqlConnection);
            SqlDataReader sqlReader = showEvents.ExecuteReader();
            try
            {
                List<string[]> data = new List<string[]>();

                while (sqlReader.Read())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();
                    data[data.Count - 1][2] = sqlReader[2].ToString();
                }

                sqlReader.Close();



                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {


                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Нет данных для отчета", "Ошибка!");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
