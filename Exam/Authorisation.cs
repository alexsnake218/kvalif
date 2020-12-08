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
    public partial class Authorisation : Form
    {
        public static string login, password;
        public int failLogin = 0;
        

        public Authorisation()
        {
            InitializeComponent();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            if (login_textBox.Text != "" && password_textBox.Text != "")
            {
                ChooseAuthor loginChoose = new ChooseAuthor();
                loginChoose.ShowDialog();

                string sqlExpression = "";
                switch (ChooseAuthor.loginChoose)
                {
                    case 1:
                        sqlExpression = String.Format("SELECT * FROM [Administrator] where login = '{0}' and password = '{1}'", login_textBox.Text, password_textBox.Text);
                        break;
                    case 2:
                        sqlExpression = String.Format("SELECT * FROM [Laborants] where login = '{0}' and password = '{1}'", login_textBox.Text, password_textBox.Text);
                        break;
                    case 3:
                        sqlExpression = String.Format("SELECT * FROM [Booker] where login = '{0}' and password = '{1}'", login_textBox.Text, password_textBox.Text);
                        break;
                    case 4:
                        sqlExpression = String.Format("SELECT * FROM [Pacients] where login = '{0}' and password = '{1}'", login_textBox.Text, password_textBox.Text);
                        break;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(SqlManager.connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            login = login_textBox.Text;
                            password = password_textBox.Text;
                            while (reader.Read())
                            {
                                switch (ChooseAuthor.loginChoose)
                                {
                                    case 1:
                                        {
                                            Administration_Form admin_Form = new Administration_Form();
                                            admin_Form.Show();
                                            Hide();
                                        }
                                        break;
                                    case 2:
                                        {
                                            Laborant_Form laborant_Form = new Laborant_Form();
                                            laborant_Form.Show();
                                            Hide();
                                        }
                                        break;
                                    case 3:
                                        MessageBox.Show("Это бухгалтер");
                                        this.Close();
                                        break;
                                    case 4:
                                        {
                                            PacientForm pacientForm = new PacientForm();
                                            pacientForm.Show();
                                            EditPacient(login);
                                            Hide();
                                        }
                                        
                                        break;
                                }
                            }
                            reader.Close();
                        }
                        else
                        {
                            if(failLogin == 0)
                            {
                                MessageBox.Show("Неверный логин или пароль.", "Ошибка");
                                password_textBox.Clear();
                                failLogin++;
                            }
                            else if(failLogin == 1)
                            {
                                Capcha capcha = new Capcha();
                                capcha.ShowDialog();
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля.");
        }

        private async void EditPacient(string login)
        {
            try
            {
                
                string sqlExpression = String.Format("UPDATE Pacients SET last_enter='{0}' WHERE login='{1}'", DateTime.Now, login);
                using (SqlConnection connection = new SqlConnection(SqlManager.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.Parameters.AddWithValue("last_enter", DateTime.Now);
                    await command.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void visible_password_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(visible_password_checkBox.Checked)
                password_textBox.UseSystemPasswordChar = false;
            else
                password_textBox.UseSystemPasswordChar = true;
        }
    }
}
