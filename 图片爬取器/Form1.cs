using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace 图片爬取器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public WebClient wc = new WebClient();
        //得到HTML文本
        public string GetHtmlText(string url)
        {
            wc.Encoding = Encoding.UTF8;
            string html;
            html = wc.DownloadString(url);
            return html;
        }
        //得到图片地址集合
        public MatchCollection GetPictruePath(string html,string strregex)
        {
            MatchCollection matches = Regex.Matches(html, strregex);
            return matches;
        }
        //下载图片
        public void DownLoadPictrue(MatchCollection matches,string pictruetype,string savepath)
        {
            int i = 1;
            foreach (Match item in matches)
            {
                Thread.Sleep(100);
                string str = pictruetype;//图片后缀名称
                lbInfo.Text="正在下载..." + item.Groups[1].Value;
                wc.DownloadFile(item.Groups[1].Value, savepath+ i + str);
                lbInfo.Text = string.Format("{0}下载完毕，准备下一张..", i + str);
                i++;
            }
        }

        //开始爬取
        private void btnStart_Click(object sender, EventArgs e)
        {
            string txt = txtRegex.Text;
            lbInfo.Text = txt;
            //string url = txtURL.Text;
            //string Htmltxt = GetHtmlText(url);
            //MatchCollection matches = GetPictruePath(Htmltxt, @txtRegex.Text);
            //DownLoadPictrue(matches, txtPictrueHouzhui.Text, txtPictruePath.Text);
        }
    }
}
