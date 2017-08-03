using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace webBot
{
    public class QuickReport : Math
    {
        public List<bool> validators = new List<bool>();
        //create a list to store validator outputs as bools

        public List<string> pageLinkURLs = new List<string>();
        //create list to store all page links as strings

        public List<string> pageLinkAnchors = new List<string>();
        //create list to store all anchor links as strings

        public String ProduceMetaData(HtmlAgilityPack.HtmlDocument document)
        {
            var metaDesc = document.DocumentNode.SelectSingleNode("//meta[@name='description']");
            HtmlAttribute metaDescription;
            metaDescription = metaDesc.Attributes["content"];
            string fulldescription = metaDescription.Value;
            return fulldescription;

            //EDIT Form1.labelMetaDescriptionResult.Text = fulldescription;

            /* Encapsulation suggests that the text property should not accessible here, so
            * (rather than force it to public) updates to property are made in Form1 class. 
            * This method returns a string, that we then access within the form */

            //EDIT string metaDescriptionLength = Convert.ToString(CountCharacters(fulldescription));
            //EDIT return metaDescriptionLength;

            /* Originally had this method returning two strings, as seen above. Experience errors,
            * so, moved the count of charatcers to a second method below */
        }

        public String GetH1(HtmlAgilityPack.HtmlDocument document)
        {
            var h1Data = document.DocumentNode.SelectSingleNode("//h1");
            string h1Contents = h1Data.InnerText;
            return h1Contents;
        }

        /* Traverses the returned html document (document) for any nodes tagged H1
         * Will return the text content - not all HTML - within a <h1> tag
         * No style IDs will be passed */

        public string CountMetaData(string fulldescription)
        {
            string metaDescriptionLength = Convert.ToString(CountCharacters(fulldescription));
            return metaDescriptionLength;
            /* Could this method take the ProduceMetaData methods returned string? 
             * Using a string in Form1.cs to pass this back and forth at present.
             * CountMetaData method could reutn an int? but unable to update label as such */
        }

        public bool ValidateMetaData(string metaDescriptionLength)
        {
            bool MetaDataPass;
            int metaLength = Convert.ToInt32(metaDescriptionLength);
            if (metaLength < 160)
            {
                 MetaDataPass = true;
            }
            else
            {
                MetaDataPass = false;
            }
            validators.Add(MetaDataPass);
            return MetaDataPass;
            /* takes the string of Meta Description and converts it to int
             * so that we can test it against Search Standards reccomended length
             * produces bool with true or false value, depending on outcome
             * bool is passed to array of Validators. It is used in Visual class method
             * to set one of the URLS summary status indicators */
        }

        public string ProducePageTitle(HtmlDocument document)
        {
            var pageTitle = document.DocumentNode.SelectSingleNode("//title");
            string title = pageTitle.InnerText;
            return title;
        }

        public string CountPageTitle(string pageTitle)
        {
            string titleLength = Convert.ToString(CountCharacters(pageTitle));
            return titleLength;
            /* Using the CountCharacter method within Math class (inheritance)
             * pass string of pagetitle to the method and return character count */
        }

        public bool ValidatePageTitle(string titleLength)
        {
            bool PageTitlePass;
            int pageLength = Convert.ToInt32(titleLength);
            if (pageLength < 60)
            {
                PageTitlePass = true;
            }
            else
            {
                PageTitlePass = false;
            }
            validators.Add(PageTitlePass);
            return PageTitlePass;
        }

        public List<string> CollectLinks(HtmlDocument document)
        {
            HtmlNodeCollection bodyNodes = document.DocumentNode.SelectNodes("//a[@href]");
            foreach (var node in bodyNodes)
            {
                string href = node.Attributes["href"].Value;

                if (href.StartsWith("/") || href.StartsWith("#"))
                {
                    pageLinkAnchors.Add(href);
                }
                else
                {
                    pageLinkURLs.Add(href);
                }
            }
            return pageLinkURLs;
        }

        /* CollectLink method searches the HTMLWeb document it is passed for all nodes with HREF status
         * collection is looped through so that the value of each node is taken for its destination
         * each value is added to a list, so all links (content inside HREF tags) are stored together
         * if else statement looks to remove internal (anchor) links, internal links */

        public string GetRefreshUrl(HtmlAgilityPack.HtmlDocument document)
        {
//            HtmlAttribute metaDescription;
  //          metaDescription = metaDesc.Attributes["content"];
          
            var root = document.DocumentNode;
            var select = root.SelectNodes("//meta[contains(@content, 'URL')]");
            string resultRedirect = string.Empty;
            if (select != null)
            {
                resultRedirect = "URL has redirect..";
                //Console.WriteLine(select[0].Attributes["content"].Value.Split('=')[1]);
            }
            else
            {
                 resultRedirect = "No redirect using HTML";
            }
            return resultRedirect;
        }
    }
}
