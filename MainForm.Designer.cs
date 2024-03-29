﻿namespace Scleroglossa
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.btnBookmark = new System.Windows.Forms.Button();
            this.cbBookmarks = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtUrlBar = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.ConsoleMessageEventReceivesConsoleLogCalls = true;
            this.geckoWebBrowser1.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser1.Location = new System.Drawing.Point(3, 62);
            this.geckoWebBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(1000, 498);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // btnBookmark
            // 
            this.btnBookmark.Image = ((System.Drawing.Image)(resources.GetObject("btnBookmark.Image")));
            this.btnBookmark.Location = new System.Drawing.Point(616, 12);
            this.btnBookmark.Name = "btnBookmark";
            this.btnBookmark.Size = new System.Drawing.Size(22, 22);
            this.btnBookmark.TabIndex = 26;
            this.btnBookmark.UseVisualStyleBackColor = true;
            this.btnBookmark.Click += new System.EventHandler(this.BtnBookmark_Click);
            // 
            // cbBookmarks
            // 
            this.cbBookmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookmarks.FormattingEnabled = true;
            this.cbBookmarks.Location = new System.Drawing.Point(252, 12);
            this.cbBookmarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBookmarks.Name = "cbBookmarks";
            this.cbBookmarks.Size = new System.Drawing.Size(360, 23);
            this.cbBookmarks.TabIndex = 25;
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::Scleroglossa.Resources.openfolder_orange;
            this.btnOpen.Location = new System.Drawing.Point(132, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(22, 22);
            this.btnOpen.TabIndex = 21;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Scleroglossa.Resources.home;
            this.btnHome.Location = new System.Drawing.Point(106, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(22, 22);
            this.btnHome.TabIndex = 20;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::Scleroglossa.Resources.question2;
            this.btnAbout.Location = new System.Drawing.Point(224, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(22, 22);
            this.btnAbout.TabIndex = 24;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnViewSource
            // 
            this.btnViewSource.Image = global::Scleroglossa.Resources.code;
            this.btnViewSource.Location = new System.Drawing.Point(182, 12);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(38, 22);
            this.btnViewSource.TabIndex = 23;
            this.btnViewSource.UseVisualStyleBackColor = true;
            this.btnViewSource.Click += new System.EventHandler(this.BtnViewSource_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Scleroglossa.Resources.icon_print;
            this.btnPrint.Location = new System.Drawing.Point(156, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(22, 22);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnGo
            // 
            this.btnGo.Image = global::Scleroglossa.Resources.right;
            this.btnGo.Location = new System.Drawing.Point(981, 37);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(22, 22);
            this.btnGo.TabIndex = 15;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Scleroglossa.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(80, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(22, 22);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txtUrlBar
            // 
            this.txtUrlBar.Location = new System.Drawing.Point(3, 38);
            this.txtUrlBar.Name = "txtUrlBar";
            this.txtUrlBar.Size = new System.Drawing.Size(974, 20);
            this.txtUrlBar.TabIndex = 14;
            this.txtUrlBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrlBar_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Scleroglossa.Resources.left;
            this.btnBack.Location = new System.Drawing.Point(3, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(22, 22);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::Scleroglossa.Resources.stop2;
            this.btnStop.Location = new System.Drawing.Point(54, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(22, 22);
            this.btnStop.TabIndex = 18;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = global::Scleroglossa.Resources.right;
            this.btnForward.Location = new System.Drawing.Point(28, 12);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(22, 22);
            this.btnForward.TabIndex = 17;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.btnBookmark);
            this.Controls.Add(this.cbBookmarks);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnViewSource);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtUrlBar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.geckoWebBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Scleroglossa Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Button btnBookmark;
        private System.Windows.Forms.ComboBox cbBookmarks;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtUrlBar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnForward;
    }
}

