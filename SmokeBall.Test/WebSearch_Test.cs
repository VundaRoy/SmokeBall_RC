using Microsoft.AspNetCore.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SmokeBall.BLL.Common;
using System.Collections.Generic;
using System.IO;

namespace SmokeBall.Test
{
    [TestClass]
    public class WebSearch_Test
    {
        WebSearch ws;
        WebStatistics wst;

        [TestInitialize]
        public void Initialise_All()
        {
            ws = new WebSearch();
            wst = new WebStatistics();
            
        }
        [TestMethod]
        public void GetHtmlFromWeb_Test()
        {
            var urlStr = "https://www.google.com.au/search?num=100&q=conveyancing+software";
            var res = ws.GetHtmlFromWeb(urlStr);
            Assert.IsNotNull(res);
        }
        [TestMethod]
        public void GetParsedHtml_Test()
        {
            var urlStr = "https://www.google.com.au/search?num=100&q=conveyancing+software";
            var html = ws.GetHtmlFromWeb(urlStr);
            var res = ws.GetParsedHtml(html);
            Assert.IsNotNull(res);
        }
        [TestMethod]
        public void UrlSearchCount_Test()
        {
            var urlStr = "https://www.google.com.au/search?num=100&q=conveyancing+software";
            var html = ws.GetHtmlFromWeb(urlStr);
            var parsedHtml = ws.GetParsedHtml(html);
            string url = "www.smokeball.com.au";
            var res = wst.UrlSearchCount(url,parsedHtml);
            Assert.IsNotNull(res);
        }
        [TestMethod]
        public void GetSearchResult_3Results_Test()
        {
            List<int> countList = new List<int>() { 1, 5, 15 };
            var res = wst.GetSearchResult(countList);
            Assert.IsNotNull(res);
        }
        [TestMethod]
        public void GetSearchResult_OneResult_Test()
        {
            List<int> countList = new List<int>() { 2 };
            var res = wst.GetSearchResult(countList);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void GetSearchResult_NoResult_Test()
        {
            List<int> countList = new List<int>() {  };
            var res = wst.GetSearchResult(countList);
            Assert.IsNotNull(res);
        }
    }
}
