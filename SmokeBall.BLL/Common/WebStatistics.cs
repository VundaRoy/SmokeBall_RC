using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeBall.BLL.Common
{
   public class WebStatistics : IWebStatistics
    {
        //Get url search count based on top x and extract it to a list of int
        public List<int> UrlSearchCount(string Url, List<string> SearchList, int TopCount)
        {
            List<int> countList = new List<int>();
            int count = 1;
            foreach (var link in SearchList)
            {
                if (count <= TopCount)
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

        //Output the list of int to string
        public string GetSearchResult(List<int> CountList)
        {
            string strList = "";
            int numberOfCounts = 0;
            foreach (var count in CountList)
            {
                strList += (numberOfCounts > 0 ? "," : "") + count ;

                numberOfCounts++;
            }
            strList = strList== "" ? "No Results": strList;
            return strList;
        }
    }
}
