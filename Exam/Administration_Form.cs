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
    public partial class Administration_Form : Form
    {
        public Administration_Form()
        {
            InitializeComponent();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Authorisation login = new Authorisation();
            login.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visits visits = new Visits();
            visits.ShowDialog();
        }
    }
}
