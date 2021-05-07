using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeBall.BLL.Common
{
    public class WebStatistics : IWebStatistics
    {
        public List<int> UrlSearchCount(string Url, List<string> SearchList)
        {
            List<int> countList = new List<int>();
            int count = 1;
            foreach (var link in SearchList)
            {
                if (count <= 100)
                {
                    if (link.Contains(Url))
                    {
                        countList.Add(count);
                    }
                }
                else { break; }
                count++;
            }
            return countList;
        }
        public string GetSearchResult(List<int> CountList)
        {
            string strList = "";
            foreach (var count in CountList)
            {
                strList += count + ",";
            }
            return strList;
        }
    }
}
