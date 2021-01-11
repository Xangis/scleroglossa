using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace Scleroglossa
{
    public partial class MainForm : Form
    {
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
            //btnStop.Enabled = false;
            //webBrowser1.Navigating += webBrowser1_Navigating;
            //webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            //webBrowser1.Navigated += webBrowser1_Navigated;
            ////cbSearchProviders.SelectedIndex = 0;
            //webBrowser1.ScriptErrorsSuppressed = true;
            //LoadBookmarks();
            //cbBookmarks.SelectedIndexChanged += new EventHandler(cbBookmarks_SelectedIndexChanged);
            //MessageBox.Show("Browser version: " + webBrowser1.Version.ToString());
            geckoWebBrowser1.Navigate("https://wbsrch.com");
        }
    }
}
