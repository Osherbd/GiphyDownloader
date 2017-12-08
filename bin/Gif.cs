using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giphy_Downloader
{
    class Gif
    {

        private string m_Filename;
        private string m_Url;
        private string m_Name;
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }


        public Gif(string i_Filename, string i_Url, string i_Name)
        {
            this.m_Filename = i_Filename;
            this.m_Url = i_Url;
            m_Name = i_Name;
        }

        public Gif()
        {
        }

        public string Filename
        {
            get
            {
                return m_Filename;
            }

            set
            {
                m_Filename = value;
            }
        }

        public string Url
        {
            get
            {
                return m_Url;
            }
            set
            {
                m_Url = value;
            }
        }
    }
}