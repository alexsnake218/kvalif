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
using System.Drawing.Printing;

namespace Exam
{
    public partial class Laborant_Form : Form
    {
        public Laborant_Form()
        {
            InitializeComponent();
        }

        private void Laborant_Form_Load(object sender, EventArgs e)
        {
            FillTable();
            hello_label.Text = "Здравствуйте, " + Authorisation.login;
        }

        private async void FillTable()
        {
            SqlConnection sqlConnection = new SqlConnection(SqlManager.connectionString);
            await sqlConnection.OpenAsync();

            SqlCommand showEvents = new SqlCommand("SELECT * FROM Zakaz WHERE status_zakaz='Не принят'", sqlConnection);
            SqlDataReader sqlReader = showEvents.ExecuteReader();
            try
            {
                List<string[]> data = new List<string[]>();

                while (sqlReader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();
                    data[data.Count - 1][2] = sqlReader[2].ToString();
                    data[data.Count - 1][3] = sqlReader[3].ToString();
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

        private void logout_button_Click(object sender, EventArgs e)
        {
            Authorisation login = new Authorisation();
            login.Show();
            Hide();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string text_1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                try
                {
                    string sqlExpression = String.Format("UPDATE Zakaz SET status_zakaz='Принято' WHERE id_zakaz='{0}'", text_1);
                    using (SqlConnection connection = new SqlConnection(SqlManager.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        await command.ExecuteNonQueryAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void button2_Click(object sender, EventArgs e)
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
       

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
