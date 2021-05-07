using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeBall.BLL.Common
{
    interface IWebSearch
    {
        public string GetHtmlFromWeb(string url);
        public List<string> GetParsedHtml(string html);        

    }

    interface IWebStatistics 
    {
        public List<int> UrlSearchCount(string Url, List<string> SearchList);
        public string GetSearchResult(List<int> CountList);
    }
}
