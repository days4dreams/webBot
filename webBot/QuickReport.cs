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
        //create a list to store validator bools

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
    }
}
