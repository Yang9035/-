using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图片爬取器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string GetNewURL(string str,int num)
        {
            string newstr = "";
            string str_1 = str.Substring(0, num);
            string str_2 = str.Substring(num);
            newstr = str_1 + "||****||" + str_2;
            return newstr;
        }
    }
}
