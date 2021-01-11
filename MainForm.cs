﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Gecko;
using Gecko.Events;

namespace Scleroglossa
{
    public partial class MainForm : Form
    {
        List<KeyValuePair<String, String>> bookmarks;

        public GeckoWebBrowser Browser
        {
            get { return geckoWebBrowser1; }
        }

        public MainForm(String url)
        {
            if( String.IsNullOrEmpty(url))
            {
                url = "https://wbsrch.com";
            }
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            //btnBack.Enabled = false;
            //btnForward.Enabled = false;
            btnStop.Enabled = false;
            geckoWebBrowser1.Navigating += geckoWebBrowser1_Navigating;
            geckoWebBrowser1.DocumentCompleted += geckoWebBrowser1_DocumentCompleted;
            geckoWebBrowser1.Navigated += geckoWebBrowser1_Navigated;
            ////cbSearchProviders.SelectedIndex = 0;
            //webBrowser1.ScriptErrorsSuppressed = true;
            LoadBookmarks();
            cbBookmarks.SelectedIndexChanged += new EventHandler(cbBookmarks_SelectedIndexChanged);
            //MessageBox.Show("Browser version: " + webBrowser1.Version.ToString());
            geckoWebBrowser1.Navigate("https://wbsrch.com");
            //geckoWebBrowser1.SetXULBrowserWindowAttribute();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.GoBack();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.GoForward();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Stop();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Reload();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("https://wbsrch.com");
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            //geckoWebBrowser1.LoadHtml()
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
        }

        private void BtnViewSource_Click(object sender, EventArgs e)
        {
            //geckoWebBrowser1.DomDocument.
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox(this);
            aboutBox.ShowDialog();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate(txtUrlBar.Text);
        }

        void cbBookmarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string title = (string)cbBookmarks.Items[cbBookmarks.SelectedIndex];
            int index = cbBookmarks.SelectedIndex;
            txtUrlBar.Text = bookmarks[index].Value;
            BtnGo_Click(sender, e);
        }

        void SaveBookmarks()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (StreamReader sr = new StreamReader(ms))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, bookmarks);
                    ms.Position = 0;
                    byte[] buffer = new byte[(int)ms.Length];
                    ms.Read(buffer, 0, buffer.Length);
                    Properties.Settings.Default.Bookmarks = Convert.ToBase64String(buffer);
                    Properties.Settings.Default.Save();
                }
            }
            //MessageBox.Show(bookmarks.Count.ToString() + " bookmarks saved.");
        }

        void LoadBookmarks()
        {
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.Bookmarks)))
            {
                bookmarks = new List<KeyValuePair<String, String>>();
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    List<KeyValuePair<String, String>> marks = (List<KeyValuePair<String, String>>)bf.Deserialize(ms);
                    bookmarks = marks;
                }
                catch (Exception)
                {
                }
                cbBookmarks.Items.Clear();
                foreach (KeyValuePair<String, String> bookmark in bookmarks)
                {
                    cbBookmarks.Items.Add(bookmark.Key);
                }
            }
            //MessageBox.Show(bookmarks.Count.ToString() + " bookmarks loaded.");
        }

        void InsertBookmark(string name, string url)
        {
            bookmarks.Add(new KeyValuePair<string, string>(name, url));
            cbBookmarks.Items.Add(name);
            SaveBookmarks();
        }

        private void txtUrlBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                geckoWebBrowser1.Navigate(txtUrlBar.Text);
            }
        }

        ////private void txtSearchText_KeyPress(object sender, KeyPressEventArgs e)
        ////{
        ////    if (e.KeyChar == (char)13)
        ////    {
        ////        this.btnSearch_Click(sender, e);
        ////    }
        ////}

        private void geckoWebBrowser1_Navigated(object Sender, EventArgs e)
        {
            txtUrlBar.Text = geckoWebBrowser1.Url.ToString();
            btnStop.Enabled = false;
        }

        private void geckoWebBrowser1_Navigating(object Sender, GeckoNavigatingEventArgs e)
        {
            btnStop.Enabled = true;
        }

        private void geckoWebBrowser1_DocumentCompleted(object Sender, EventArgs e)
        {
            btnStop.Enabled = false;
            if (geckoWebBrowser1.CanGoBack)
            {
                btnBack.Enabled = true;
            }
            else
            {
                btnBack.Enabled = false;
            }
            if (geckoWebBrowser1.CanGoForward)
            {
                btnForward.Enabled = true;
            }
            else
            {
                btnForward.Enabled = false;
            }
            if (!String.IsNullOrEmpty(geckoWebBrowser1.DocumentTitle))
            {
                this.Text = "Scleroglossa Browser: " + geckoWebBrowser1.DocumentTitle;
            }
            else
            {
                this.Text = "Scleroglossa Browser";
            }
        }

        //private void btnPrint_Click(object sender, EventArgs e)
        //{
        //    webBrowser1.Print();
        //}

        //private void btnViewSource_Click(object sender, EventArgs e)
        //{
        //    string source = webBrowser1.DocumentText.ToString();
        //    Source window = new Source(source);
        //    window.ShowDialog();
        //}

        ///// <summary>
        ///// Opens a HTML file for display.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnOpen_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    if (dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        webBrowser1.Navigate(dlg.FileName);
        //    }
        //}

        private void BtnBookmark_Click(object sender, EventArgs e)
        {
            AddBookmark dlg = new AddBookmark(geckoWebBrowser1.DocumentTitle.ToString(), geckoWebBrowser1.Url.ToString());
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.OK)
            {
                InsertBookmark(dlg.GetURLTitle(), dlg.GetURL());
            }
        }

        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);
        //    panel1.Width = this.Width - 25;
        //    txtUrlBar.Width = this.Width - 72;
        //    btnGo.Location = new Point(this.Width - 62, btnGo.Location.Y);
        //}
    }
}
