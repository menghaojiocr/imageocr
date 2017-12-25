using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Communicate_With_WebBrowser
{
    //
    // 说明：http://udnz.com/Article/Invoke_Javascript_On_Webbrowser_In_Winform.aspx
    // 更多作品请见：http://udnz.com/Works/
    //
    // 有用的链接
    // ms-help://MS.MSDNQTR.v90.chs/iesecurity/workshop/security/szone/reference/functions/cointernetsetfeatureenabled.htm
    // ms-help://MS.MSDNQTR.v90.chs/iesecurity/workshop/security/szone/reference/enums/internetfeaturelist.htm
    // http://blog.csdn.net/jiangsheng/archive/2004/11/07/170742.aspx
    // 如何： 从 Visual C#.net web 浏览器控件的调用查找、 查看源文件和选项对话框:http://support.microsoft.com/?kbid=329014

    public partial class FDemo : Form
    {
        private readonly string FName = "WebBrowser控件上的网页与Winform本身的交互示例";
        private readonly string TestPage = Path.Combine(Application.StartupPath, "Default.htm");

        public FDemo()
        {
            InitializeComponent();
            webBrowser1.Navigated += new WebBrowserNavigatedEventHandler(webBrowser1_Navigated);
        }

        void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.tbUrl.Text = webBrowser1.Url.AbsoluteUri;
           // this.buLoad.Enabled = webBrowser1.CanGoBack;
            //this.buForward.Enabled = webBrowser1.CanGoForward;
        }

        private void FDemo_Load(object sender, EventArgs e)
        {
            this.Text = FName;
            tbUrl.Text = TestPage;
            webBrowser1.Url = new Uri(TestPage);
        }

        private void buLoad_Click(object sender, EventArgs e)
        {
            string url = tbUrl.Text.ToLower();
            if (string.IsNullOrEmpty(url)) return;
            webBrowser1.Url = new Uri(url);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsoluteUri == "about:blank") return;

            this.Text = string.Format("{0} - [{1}]", webBrowser1.DocumentTitle, FName);
            //this.tbHtml.Text = webBrowser1.DocumentText;
            webBrowser1.Document.GetElementById("funCSharp").Click += new HtmlElementEventHandler(funCSharp_Click);

            //使用onchange也可以，只不过相比onpropertychange而言，onchange只能在文本框失去焦点后方能触发，这一点完全相同于Html标签指定的事件
            webBrowser1.Document.GetElementById("onchangingTestArea").AttachEventHandler("onpropertychange", new EventHandler(textbox_Change));
        }


        void funCSharp_Click(object sender, HtmlElementEventArgs e)
        {
            string funCSharp_para = webBrowser1.Document.GetElementById("funCSharp_para").GetAttribute("value");
            MessageBox.Show("第二步：C#方法被调用\n\nfunCSharp_para = " + funCSharp_para, "C#方法被触发,C/S对话框");
        }

        void textbox_Change(object sender, EventArgs e)
        {
            this.tbChanging.Text = webBrowser1.Document.GetElementById("onchangingTestArea").InnerHtml;
        }

        private void buViewHtml_Click(object sender, EventArgs e)
        {
            //tbHtml.Text = webBrowser1.DocumentText;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked) tbUrl.Text = "http://www.baidu.com";

            string url = tbUrl.Text.ToLower();
            if (string.IsNullOrEmpty(url)) return;
            webBrowser1.Url = new Uri(url);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked) tbUrl.Text = "http://www.sohu.com";

            string url = tbUrl.Text.ToLower();
            if (string.IsNullOrEmpty(url)) return;
            webBrowser1.Url = new Uri(url);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked) tbUrl.Text = TestPage;
        }

        private void buFunJS_Click(object sender, EventArgs e)
        {
            //tbPara1 是C/S控件
            webBrowser1.Document.InvokeScript("funJS", new object[] { tbPara1.Text });
        }

        private void buSetHtml_Click(object sender, EventArgs e)
        {
           /// webBrowser1.DocumentText = tbHtml.Text;
        }

        private void buGetVar_Click(object sender, EventArgs e)
        {
            object tmp = webBrowser1.Document.InvokeScript("GetJsVar");
            if (tmp != null)
                MessageBox.Show(string.Format("jsVar = {0}", tmp), "C/S对话框");
            else
                MessageBox.Show("未找到对象");
        }

        private void buGetJson_Click(object sender, EventArgs e)
        {
            object tmp = webBrowser1.Document.InvokeScript("GetJSON");
            if (tmp != null)
            {
                Type t = tmp.GetType();
                object name = t.InvokeMember("Name", System.Reflection.BindingFlags.GetProperty, null, tmp, null);
                object value = t.InvokeMember("Value", System.Reflection.BindingFlags.GetProperty, null, tmp, null);
                MessageBox.Show(string.Format("jsJSON.GetType() = {0}\n\njsJSON.Name = {1}\njsJSON.Value = {2}", tmp, name ?? "[NULL]", value ?? "[NULL]"), "C/S对话框");
            }
            else
                MessageBox.Show("未找到对象");
        }

        private void buGetObj_Click(object sender, EventArgs e)
        {
            object tmp = webBrowser1.Document.InvokeScript("GetJsObj");
            if (tmp != null)
            {
                Type t = tmp.GetType();
                object key = t.InvokeMember("Key", System.Reflection.BindingFlags.GetProperty, null, tmp, null);
                object value = t.InvokeMember("Value", System.Reflection.BindingFlags.GetProperty, null, tmp, null);
                MessageBox.Show(string.Format("jsobj.GetType() = {0}\n\njsobj.Key = {1}\njsobj.Value = {2}", tmp, key ?? "[NULL]", value ?? "[NULL]"), "C/S对话框");
            }
            else
                MessageBox.Show("未找到对象");
        }

        private void buInvokeJSObjMethod_Click(object sender, EventArgs e)
        {
            object tmp = webBrowser1.Document.InvokeScript("GetJsObj");
            if (tmp != null)
            {
                Type t = tmp.GetType();
                object result = t.InvokeMember("MyMethod", System.Reflection.BindingFlags.InvokeMethod, null, tmp, new object[] { tbPara2.Text });  //tbPara2 是C/S文本框
                MessageBox.Show(string.Format("MyMethod.GetType() = {0}\n\njsobj.MyMethod(para) 返回了：\n\n{1}", tmp, result ?? "[NULL]"), "C/S对话框");
            }
            else
                MessageBox.Show("未找到对象");
        }

        private void buGetFlashSize_Click(object sender, EventArgs e)
        {
            HtmlElement f = webBrowser1.Document.GetElementById("flashPlayer");
            if (f == null)
            {
                MessageBox.Show("未找到对象");
                return;
            }

            string w = f.GetAttribute("width");
            string h = f.GetAttribute("height");
            MessageBox.Show(string.Format("获取 Flash 尺寸成功：\n\nWidth = {0}\nHeight = {1}", w, h), "C/S对话框");
        }

        private void buSetFlashSize_Click(object sender, EventArgs e)
        {
            HtmlElement f = webBrowser1.Document.GetElementById("flashPlayer");
            if (f == null)
            {
                MessageBox.Show("未找到对象");
                return;
            }

            f.SetAttribute("width", "160");
            f.SetAttribute("height", "120");
        }

        #region 调用查找、 查看源文件和选项对话框
        private void ExecIOleCommand(Guid guid, uint cmdTarget)
        {
            IOleCommandTarget cmdt;
            Object o = new object();
            try
            {
                cmdt = (IOleCommandTarget)webBrowser1.Document.DomDocument;
                cmdt.Exec(ref guid, cmdTarget, (uint)OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT, ref o, ref o);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// IOleCommandTarget 接口所需的命令GUID（一个未公开的GUID，在将来的系统中可以发生变更）
        /// </summary>
        private Guid cmdGuid = new Guid("ED016940-BD5B-11CF-BA4E-00C04FD70816");
        /// <summary>
        /// 命令
        /// </summary>
        private enum MiscCommandTarget { Find = 1, ViewSource, Options }

        private void buViewSource_Click(object sender, EventArgs e)
        {
            ExecIOleCommand(cmdGuid, (uint)MiscCommandTarget.ViewSource);
        }

        private void buOption_Click(object sender, EventArgs e)
        {
            ExecIOleCommand(cmdGuid, (uint)MiscCommandTarget.Options);
        }

        private void buFind_Click(object sender, EventArgs e)
        {
            ExecIOleCommand(cmdGuid, (uint)MiscCommandTarget.Find);
        }
        #endregion

        private void buBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void buRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://udnz.com/Works/");
        }

        
    }
}
