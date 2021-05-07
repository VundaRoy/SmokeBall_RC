using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmokeBall.BLL.Common;
using System.Configuration;

namespace SmokeBall.Desk.VM
{
    public class GetWebResults
    {
        public string OutputString()
        {
            WebSearch ws = new WebSearch();
            WebStatistics wst = new WebStatistics();

            var urlStr = "https://www.google.com.au/search?num=100&q=conveyancing+software";            
            var html = ws.GetHtmlFromWeb(urlStr);
            var parsedHtml = ws.GetParsedHtml(html);
            string url = ConfigurationManager.AppSettings.Get("urlLink").ToString();
            var countList = wst.UrlSearchCount(url, parsedHtml);
            var strResult = wst.GetSearchResult(countList);
            return strResult;
        }
    }
}
