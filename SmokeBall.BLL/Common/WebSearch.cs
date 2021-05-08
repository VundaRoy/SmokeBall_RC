using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using SmokeBall.BLL.Common;
namespace SmokeBall.BLL.Common
{
    public class WebSearch : IWebSearch
    {      
        //Parse html extract to chunks of data separated by div
        public List<string> GetParsedHtml(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var searchLinks = htmlDoc.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "ZINbbc xpd O9g5cc uUPGi").Contains("kCrYT")).ToList();
            List<string> webSearches = new List<string>();

            foreach(var link in searchLinks)
            {
                if (link.FirstChild.Attributes.Count > 0)
                    webSearches.Add(link.FirstChild.Attributes[0].Value);
            }
            return webSearches;
        }

        //Scrape website results to string
        public string GetHtmlFromWeb(string url)
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            client.DefaultRequestHeaders.Accept.Clear();
            var response = Convert.ToString( client.GetStringAsync(url).Result);
            return response;
        }
       
        

        
    }
}
