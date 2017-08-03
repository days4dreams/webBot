using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBot
{
    public partial class FormWelcome : Form
    {
        
        public FormWelcome()
        {
            InitializeComponent();
            new Form1();
        }

        private void labelSubIntro_Click(object sender, EventArgs e)
        {

        }

        private void labelWelcomeFullReport_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuickReport_Click(object sender, EventArgs e)
        {
            Form1 QuickReportForm = new Form1();
            QuickReportForm.Show();
            
        }
        /* Form1 open on button click. Form for Full Report still to be designed */
    }
}
