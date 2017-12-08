using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Threading;

namespace Giphy_Downloader
{
    class Manager
    {
        #region Consts
        private const string c_GiphyApiPath = "http://api.giphy.com/v1/gifs/search?";
        private const string c_GiphyApiKey = "api_key=826b962229614a14805e2fbda49300b3";
        private const string c_Query = "q=";
        private const string c_LimitStr = "limit=";
        private const int c_LimitValue = 20;
        private const string c_Delimiter = "&";
        #endregion Consts
        private string m_GifName;
        private string m_Slug;
        private WebClient m_WebClient;
        private static object m_SyncObject = new object();
        private Gif m_Gif;

        public Manager(WebClient i_WebClient, Gif i_Gif)
        {
            this.m_WebClient = i_WebClient;
            m_Gif = i_Gif;
        }

        public string GifName
        {
            set
            {
                m_GifName = value;
            }
        }

        internal string Get()
        {
            if (m_GifName == null || m_GifName == string.Empty)
            {
                return null;
            }
            // Thread m_DownloadThread = new Thread(new ThreadStart(handleNewRequest));
            // m_DownloadThread.Start();
            //handleNewRequest();

            return handleNewRequest();

        }

        private string handleNewRequest()
        {
            string fullPath;

            lock (m_SyncObject)
            {
                fullPath = string.Format(
                    "{0}{1}{2}{3}{4}{5}{3}{6}",
                    c_GiphyApiPath,
                    c_Query,
                    m_GifName,
                    c_Delimiter,
                    c_LimitStr,
                    c_LimitValue,
                    c_GiphyApiKey);
            }

            var rawResponse = new WebClient().DownloadString(fullPath);
            JObject _response = JObject.Parse(rawResponse);
            JArray photos = (JArray)_response["data"];

            Random randNum = new Random();
            int idx = randNum.Next(0, 15);

            m_Slug = photos[idx]["slug"].ToString();
            var dir = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\GIFs");
            string fileName = string.Format("{0}\\{1}.gif", dir.FullName, m_Slug);
            m_Gif.Filename = fileName;
            m_Gif.Url = photos[idx]["images"]["fixed_height"]["url"].ToString();
            m_Gif.Name = m_Slug;
            downloadGiphy(photos[idx]["images"]["fixed_height"]["url"].ToString());
            return photos[idx]["images"]["fixed_height"]["url"].ToString();
          
            //Thread.CurrentThread.Abort();
        }

        private void downloadGiphy(string url)
        {
            //Process.Start(url);
            var dir = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\GIFs");
            string fileName = string.Format("{0}\\{1}.gif", dir.FullName, m_Slug);
            m_Gif.Filename = fileName;
            m_Gif.Url = url; 
            m_Gif.Name = m_Slug;
            while (m_WebClient.IsBusy)
            {
                Thread.Sleep(500);
            }

            m_WebClient.DownloadFileAsync(new Uri(m_Gif.Url), fileName, m_Gif);
        }
    }
}
