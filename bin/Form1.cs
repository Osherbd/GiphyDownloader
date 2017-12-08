using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace Giphy_Downloader
{
    public partial class Form1 : Form
    {
        private WebClient m_WebClient = new WebClient();
        private Manager m_Manager;
        private int m_ImgIndex = 1;
        ToolTip toolTip1 = new ToolTip();
        ToolTip toolTip2 = new ToolTip();
        ToolTip toolTip3 = new ToolTip();
        ToolTip toolTip4 = new ToolTip();
        string m_Url;
        private Gif m_Gif = new Gif();

        public Form1()
        {
            InitializeComponent();
            //m_WebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(addToGrid);
            m_Manager = new Manager(m_WebClient, m_Gif);
        }

        private void textBoxGifName_TextChanged(object sender, EventArgs e)
        {
            m_Manager.GifName = textBoxGifName.Text;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            m_Url = m_Manager.Get();
            addToGrid();
        }

        delegate void AddToGrid(object sender, AsyncCompletedEventArgs e);

        private void addToGrid() //(object sender, AsyncCompletedEventArgs e)
        {
            //if (this.InvokeRequired)
            //{
            //    AddToGrid del = new AddToGrid(addToGrid);
            //    this.Invoke(del, sender, e);
            //    return;
            //}
            //Gif gif = (Gif)e.UserState;
           
            switch (m_ImgIndex)
            {
                case 1:
                    pictureBoxGif1.WaitOnLoad = false;
                    pictureBoxGif1.LoadAsync(m_Gif.Url); // Filename);
                    pictureBoxGif1.Name = m_Gif.Url;
                    
                    toolTip1.IsBalloon = true;
                    toolTip1.UseFading = true;
                    toolTip1.SetToolTip(pictureBoxGif1, m_Gif.Name);
                    break;
                case 2:
                    pictureBoxGif2.WaitOnLoad = false;
                    pictureBoxGif2.LoadAsync(m_Gif.Url);
                    pictureBoxGif2.Name = m_Gif.Url;
                    
                    toolTip2.IsBalloon = true;
                    toolTip2.UseFading = true;
                    toolTip2.SetToolTip(pictureBoxGif2, m_Gif.Name);
                    break;
                case 3:
                    pictureBoxGif3.WaitOnLoad = false;
                    pictureBoxGif3.LoadAsync(m_Gif.Url);
                    pictureBoxGif3.Name = m_Gif.Url;
                    
                    toolTip3.IsBalloon = true;
                    toolTip3.UseFading = true;
                    toolTip3.SetToolTip(pictureBoxGif3, m_Gif.Name);
                    break;
                case 0:
                    pictureBoxGif4.WaitOnLoad = false;
                    pictureBoxGif4.LoadAsync(m_Gif.Url);
                    pictureBoxGif4.Name = m_Gif.Url;
                    
                    toolTip4.IsBalloon = true;
                    toolTip4.UseFading = true;
                    toolTip4.SetToolTip(pictureBoxGif4, m_Gif.Name);
                    break;
            }

            m_ImgIndex = ((m_ImgIndex + 1) % 4);
        }

        private void textBoxGifName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonShow_Click(this.textBoxGifName, null);
            }
        }
    }
}
