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
    
    public partial class Pacient_Service : Form
    {

        SqlManager sqlManager = new SqlManager();

        public Pacient_Service()
        {
            InitializeComponent();
        }

        private async void Pacient_Service_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(SqlManager.connectionString);
            await sqlConnection.OpenAsync();

            using (SqlConnection connection = new SqlConnection(SqlManager.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From [Laboratory_Services]", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        services_comboBox.Items.Add(Convert.ToString(reader["name_service"]));
                    }
                }

                reader.Close();
                connection.Close();
            }
        }

        private  void complete_Button_Click(object sender, EventArgs e)
        {
            if(services_comboBox.Text != "")
            {           
                sqlManager.SqlCommand("INSERT INTO Zakaz (date_create, status_zakaz, name_service) VALUES ('" + DateTime.Now + "','" + "Не принят" + "', '"+ services_comboBox.Text + "')");
            }
        }
    }
}
