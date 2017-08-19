using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Diagnostics;


namespace webBot
{
    public partial class FormWelcome : Form
    {
        
        public FormWelcome()
        {
            InitializeComponent();
            new FormQuickReport();
        }

        private void labelSubIntro_Click(object sender, EventArgs e)
        {

        }

        private void labelWelcomeFullReport_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuickReport_Click(object sender, EventArgs e)
        {
            FormQuickReport QuickReportForm = new FormQuickReport();
            QuickReportForm.Show();
            
        }

        private void buttonFullReport_Click(object sender, EventArgs e)
        {
            string holdingMessage = "Coming Soon!";
            MessageBox.Show(holdingMessage);
        }
        /* Form1 open on button click. Form for Full Report still to be designed */
    }
}
