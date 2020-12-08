using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class PacientForm : Form
    {
        public PacientForm()
        {
            InitializeComponent();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Authorisation login = new Authorisation();
            login.Show();
            Hide();
        }

        private void give_zakaz_Button_Click(object sender, EventArgs e)
        {
            Pacient_Service pacient_Service = new Pacient_Service();
            pacient_Service.ShowDialog();
        }

        private void PacientForm_Load(object sender, EventArgs e)
        {
            hello_label.Text = "Здравствуйте, " + Authorisation.login;
        }
    }
}
