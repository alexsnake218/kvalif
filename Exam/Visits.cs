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
    }
}
