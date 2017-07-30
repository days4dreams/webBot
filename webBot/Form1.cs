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

namespace webBot
{
    public partial class Form1 : Form
    {
        public Math mathmatics = new Math();
        public QuickReport reportA = new QuickReport();
        public Visual indicators = new Visual();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            string urlInput = "https://www.me.com/";
            HtmlWeb webPage = new HtmlWeb();
            var document = webPage.Load(urlInput);

            string statusCode = Convert.ToString(webPage.StatusCode);
            labelResponseOutput.Text = statusCode;

            labelURLOutput.Text = urlInput;

            string metaData = reportA.ProduceMetaData(document);
            labelMetaDescriptionResult.Text = metaData;
            string metaDataCount = reportA.CountMetaData(metaData);
            labelMetaDescriptionLengthOutput.Text = metaDataCount;

            bool metaIndicator = reportA.ValidateMetaData(metaDataCount);
            labelMetaDescriptionPassOutput.Text = indicators.SetIndicator(metaIndicator);

            /* passes the meta descritptions count (metaDataCount) to the ValidateMetaData method within Quick Report
             * this passes the string through a length test and results in a true false
             * this bool is then passed to the Visual class to run the SetIndicator method on it
             * passes will show a tick, fails will show a cross */

            string pageTitle = reportA.ProducePageTitle(document);
            labelPageTitleResult.Text = pageTitle;
            string pageTitleCount = reportA.CountMetaData(pageTitle);
            labelPageTitleLengthOutput.Text = pageTitleCount;

            bool titleIndicator = reportA.ValidatePageTitle(pageTitleCount);
            labelPageTitlePassOutput.Text = indicators.SetIndicator(titleIndicator);

            /* Originally all 'doing' code here, one long statement however, saw problems with lack of encapsulation.
             * EG 'count' value from CountCharacters method was being shared, therefore creating a collective total
             * Moved individual functions - MetaData count, Pagetitle count - into own methods, which inherit from math class */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolTipPageTitle_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
