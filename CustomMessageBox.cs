using System;
using System.Windows.Forms;

namespace Health_Survey_Form
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string title)
        {
            InitializeComponent();
            lblMessage.Text = message;
            this.Text = title;
        }

        private void panelMessage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
