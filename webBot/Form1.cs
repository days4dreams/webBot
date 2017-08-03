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
            string urlInput = textBoxURL.Text;
            //string urlInput = "http://rileysfishshack.com/";
            HtmlWeb webPage = new HtmlWeb();
            var document = webPage.Load(urlInput);

            /* using HTML Agility Pack, a .NET code library HTML parser
             * take the input URL from user; this is the URL we will crawl
             * create a new instance of the class htmlWeb
             * Pass the input URL to the method Load() on the HTMLweb object
             * EDIT: Add a prompt that indicates a valid URL has not been passed
             * If nothing is matched null will be returned which means 
             * that if you are assigning to string you will get a runtime error.
             * Same is true for all following methods - require some additional validation
             * EG if xxx == null */

            string redirect = reportA.GetRefreshUrl(document);
            labelRedirectOutput.Text = redirect;

            /*Pass the loaded HTML Document to the method GetRefreshURL.
             * unable to test this fully until validators for other methods are set up
             * as null entries cause code break */

            string loadTime = mathmatics.GetLoadingTime(urlInput) + " milliseconds";
            labelResponseTimeOutput.Text = loadTime;

            string statusCode = Convert.ToString(webPage.StatusCode);
            labelResponseOutput.Text = statusCode;

            /*using HTMLAgilityPacks StatusCode method. Returns the current repsonse
             * of the HTTP it is used on */

            labelURLOutput.Text = urlInput;

            reportA.CollectLinks(document);
            string listOfLinks = string.Join("\r\n", reportA.pageLinkURLs.ToArray());
            labelLinksOutput.Text = listOfLinks;
            labelNoOfLinkOutput.Text = Convert.ToString(reportA.pageLinkURLs.Count);
            labelNoOfAnchorOutput.Text = Convert.ToString(reportA.pageLinkAnchors.Count);

            /* pass the HTMLWeb document to the CollectLinks method inside of QuickReports
             * use the string.Join method to combine the List of strings returned from CollectLinks method
             * into one string. Pass string to label text field
             * perform Count() on the the lists of links, present to user */

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

            string h1Tag = reportA.GetH1(document);
            labelH1ContentOutput.Text = h1Tag;

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
