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
    public partial class ChooseAuthor : Form
    {
        public static int loginChoose;

        public ChooseAuthor()
        {
            InitializeComponent();
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            loginChoose = 1;
            this.Close();
        }

        private void laborant_button_Click(object sender, EventArgs e)
        {
            loginChoose = 2;
            this.Close();
        }

        private void booker_button_Click(object sender, EventArgs e)
        {
            loginChoose = 3;
            this.Close();
        }

        private void pacient_button_Click(object sender, EventArgs e)
        {
            loginChoose = 4;
            this.Close();
        }
    }
}
