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
    public partial class Bookeeper_Form : Form
    {
        public Bookeeper_Form()
        {
            InitializeComponent();
        }

        private void Booker_Form_Load(object sender, EventArgs e)
        {
            hello_label.Text = "Здравствуйте, " + Authorisation.login;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Authorisation login = new Authorisation();
            login.Show();
            Hide();
        }
    }
}
