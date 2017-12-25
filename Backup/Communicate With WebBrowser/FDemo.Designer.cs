namespace Communicate_With_WebBrowser
{
    partial class FDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buLoad = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.buViewHtml = new System.Windows.Forms.Button();
            this.tbHtml = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.buFunJS = new System.Windows.Forms.Button();
            this.tbPara1 = new System.Windows.Forms.TextBox();
            this.buSetHtml = new System.Windows.Forms.Button();
            this.tbChanging = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buGetVar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buGetJson = new System.Windows.Forms.Button();
            this.buGetObj = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buInvokeJSObjMethod = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPara2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.buGetFlashSize = new System.Windows.Forms.Button();
            this.buSetFlashSize = new System.Windows.Forms.Button();
            this.buViewSource = new System.Windows.Forms.Button();
            this.buFind = new System.Windows.Forms.Button();
            this.buOption = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buBack = new System.Windows.Forms.Button();
            this.buForward = new System.Windows.Forms.Button();
            this.buRefresh = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(775, 424);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // buLoad
            // 
            this.buLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buLoad.Location = new System.Drawing.Point(709, 10);
            this.buLoad.Name = "buLoad";
            this.buLoad.Size = new System.Drawing.Size(75, 23);
            this.buLoad.TabIndex = 1;
            this.buLoad.Text = "打开";
            this.buLoad.UseVisualStyleBackColor = true;
            this.buLoad.Click += new System.EventHandler(this.buLoad_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(331, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(372, 21);
            this.tbUrl.TabIndex = 2;
            // 
            // buViewHtml
            // 
            this.buViewHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buViewHtml.Location = new System.Drawing.Point(540, 3);
            this.buViewHtml.Name = "buViewHtml";
            this.buViewHtml.Size = new System.Drawing.Size(94, 23);
            this.buViewHtml.TabIndex = 3;
            this.buViewHtml.Text = "查看源代码 ↓";
            this.buViewHtml.UseVisualStyleBackColor = true;
            this.buViewHtml.Click += new System.EventHandler(this.buViewHtml_Click);
            // 
            // tbHtml
            // 
            this.tbHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHtml.Location = new System.Drawing.Point(0, 29);
            this.tbHtml.Multiline = true;
            this.tbHtml.Name = "tbHtml";
            this.tbHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHtml.Size = new System.Drawing.Size(775, 157);
            this.tbHtml.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(213, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "百度";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(266, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Google";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(148, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 16);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "测试页";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // buFunJS
            // 
            this.buFunJS.Location = new System.Drawing.Point(5, 20);
            this.buFunJS.Name = "buFunJS";
            this.buFunJS.Size = new System.Drawing.Size(177, 23);
            this.buFunJS.TabIndex = 8;
            this.buFunJS.Text = "A: funJS(param)";
            this.buFunJS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buFunJS.UseVisualStyleBackColor = true;
            this.buFunJS.Click += new System.EventHandler(this.buFunJS_Click);
            // 
            // tbPara1
            // 
            this.tbPara1.Location = new System.Drawing.Point(57, 49);
            this.tbPara1.Name = "tbPara1";
            this.tbPara1.Size = new System.Drawing.Size(125, 21);
            this.tbPara1.TabIndex = 9;
            this.tbPara1.Text = "ABCDEF";
            // 
            // buSetHtml
            // 
            this.buSetHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buSetHtml.Location = new System.Drawing.Point(640, 3);
            this.buSetHtml.Name = "buSetHtml";
            this.buSetHtml.Size = new System.Drawing.Size(132, 23);
            this.buSetHtml.TabIndex = 10;
            this.buSetHtml.Text = "更新源代码到网页 ↑";
            this.buSetHtml.UseVisualStyleBackColor = true;
            this.buSetHtml.Click += new System.EventHandler(this.buSetHtml_Click);
            // 
            // tbChanging
            // 
            this.tbChanging.Location = new System.Drawing.Point(6, 104);
            this.tbChanging.Multiline = true;
            this.tbChanging.Name = "tbChanging";
            this.tbChanging.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbChanging.Size = new System.Drawing.Size(177, 44);
            this.tbChanging.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "B/S文本框onchange事件：";
            // 
            // buGetVar
            // 
            this.buGetVar.Location = new System.Drawing.Point(6, 186);
            this.buGetVar.Name = "buGetVar";
            this.buGetVar.Size = new System.Drawing.Size(177, 23);
            this.buGetVar.TabIndex = 14;
            this.buGetVar.Text = "B: var jsVar;";
            this.buGetVar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buGetVar.UseVisualStyleBackColor = true;
            this.buGetVar.Click += new System.EventHandler(this.buGetVar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(4, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "获取Javascript变量：";
            // 
            // buGetJson
            // 
            this.buGetJson.Location = new System.Drawing.Point(6, 215);
            this.buGetJson.Name = "buGetJson";
            this.buGetJson.Size = new System.Drawing.Size(177, 23);
            this.buGetJson.TabIndex = 16;
            this.buGetJson.Text = "C: var jsJSON = { };";
            this.buGetJson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.buGetJson, "var jsJSON = { Name: \"ObjectName\", Value: \"ObjectValue\" };");
            this.buGetJson.UseVisualStyleBackColor = true;
            this.buGetJson.Click += new System.EventHandler(this.buGetJson_Click);
            // 
            // buGetObj
            // 
            this.buGetObj.Location = new System.Drawing.Point(6, 244);
            this.buGetObj.Name = "buGetObj";
            this.buGetObj.Size = new System.Drawing.Size(177, 23);
            this.buGetObj.TabIndex = 17;
            this.buGetObj.Text = "D: var jsobj = new Obj();";
            this.buGetObj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.buGetObj, "执行按钮E后，可以再次点击按钮D以验证Javascript对象是否已被成功赋值");
            this.buGetObj.UseVisualStyleBackColor = true;
            this.buGetObj.Click += new System.EventHandler(this.buGetObj_Click);
            // 
            // buInvokeJSObjMethod
            // 
            this.buInvokeJSObjMethod.Location = new System.Drawing.Point(6, 298);
            this.buInvokeJSObjMethod.Name = "buInvokeJSObjMethod";
            this.buInvokeJSObjMethod.Size = new System.Drawing.Size(177, 23);
            this.buInvokeJSObjMethod.TabIndex = 19;
            this.buInvokeJSObjMethod.Text = "E: jsobj.MyMethod(param)";
            this.buInvokeJSObjMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.buInvokeJSObjMethod, "执行按钮E后，可以再次点击按钮D以验证Javascript对象是否已被成功赋值");
            this.buInvokeJSObjMethod.UseVisualStyleBackColor = true;
            this.buInvokeJSObjMethod.Click += new System.EventHandler(this.buInvokeJSObjMethod_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(4, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "执行Javascript对象的方法：";
            // 
            // tbPara2
            // 
            this.tbPara2.Location = new System.Drawing.Point(58, 327);
            this.tbPara2.Name = "tbPara2";
            this.tbPara2.Size = new System.Drawing.Size(125, 21);
            this.tbPara2.TabIndex = 20;
            this.tbPara2.Text = "123";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "param =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "param =";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(12, 35);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbHtml);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(775, 614);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buSetHtml);
            this.panel1.Controls.Add(this.buViewHtml);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 29);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(5, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "ActiveX控件";
            // 
            // buGetFlashSize
            // 
            this.buGetFlashSize.Location = new System.Drawing.Point(6, 379);
            this.buGetFlashSize.Name = "buGetFlashSize";
            this.buGetFlashSize.Size = new System.Drawing.Size(177, 23);
            this.buGetFlashSize.TabIndex = 25;
            this.buGetFlashSize.Text = "F: 获取Flash尺寸";
            this.buGetFlashSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buGetFlashSize.UseVisualStyleBackColor = true;
            this.buGetFlashSize.Click += new System.EventHandler(this.buGetFlashSize_Click);
            // 
            // buSetFlashSize
            // 
            this.buSetFlashSize.Location = new System.Drawing.Point(7, 408);
            this.buSetFlashSize.Name = "buSetFlashSize";
            this.buSetFlashSize.Size = new System.Drawing.Size(176, 23);
            this.buSetFlashSize.TabIndex = 26;
            this.buSetFlashSize.Text = "G: 设置Flash大小 (160,120)";
            this.buSetFlashSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buSetFlashSize.UseVisualStyleBackColor = true;
            this.buSetFlashSize.Click += new System.EventHandler(this.buSetFlashSize_Click);
            // 
            // buViewSource
            // 
            this.buViewSource.Location = new System.Drawing.Point(7, 491);
            this.buViewSource.Name = "buViewSource";
            this.buViewSource.Size = new System.Drawing.Size(96, 23);
            this.buViewSource.TabIndex = 11;
            this.buViewSource.Text = "查看源代码";
            this.buViewSource.UseVisualStyleBackColor = true;
            this.buViewSource.Click += new System.EventHandler(this.buViewSource_Click);
            // 
            // buFind
            // 
            this.buFind.Location = new System.Drawing.Point(108, 462);
            this.buFind.Name = "buFind";
            this.buFind.Size = new System.Drawing.Size(75, 23);
            this.buFind.TabIndex = 12;
            this.buFind.Text = "查找";
            this.buFind.UseVisualStyleBackColor = true;
            this.buFind.Click += new System.EventHandler(this.buFind_Click);
            // 
            // buOption
            // 
            this.buOption.Location = new System.Drawing.Point(7, 462);
            this.buOption.Name = "buOption";
            this.buOption.Size = new System.Drawing.Size(96, 23);
            this.buOption.TabIndex = 13;
            this.buOption.Text = "Internet 选项";
            this.buOption.UseVisualStyleBackColor = true;
            this.buOption.Click += new System.EventHandler(this.buOption_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(5, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "浏览器对话框（非托管）";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.buFunJS);
            this.panel2.Controls.Add(this.buViewSource);
            this.panel2.Controls.Add(this.tbPara1);
            this.panel2.Controls.Add(this.buFind);
            this.panel2.Controls.Add(this.tbChanging);
            this.panel2.Controls.Add(this.buOption);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buSetFlashSize);
            this.panel2.Controls.Add(this.buGetVar);
            this.panel2.Controls.Add(this.buGetFlashSize);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buGetJson);
            this.panel2.Controls.Add(this.buGetObj);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.buInvokeJSObjMethod);
            this.panel2.Controls.Add(this.tbPara2);
            this.panel2.Location = new System.Drawing.Point(790, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 639);
            this.panel2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "C/S调用B/S的Javascript：";
            // 
            // buBack
            // 
            this.buBack.Location = new System.Drawing.Point(12, 9);
            this.buBack.Name = "buBack";
            this.buBack.Size = new System.Drawing.Size(38, 23);
            this.buBack.TabIndex = 29;
            this.buBack.Text = "后退";
            this.buBack.UseVisualStyleBackColor = true;
            this.buBack.Click += new System.EventHandler(this.buBack_Click);
            // 
            // buForward
            // 
            this.buForward.Location = new System.Drawing.Point(56, 10);
            this.buForward.Name = "buForward";
            this.buForward.Size = new System.Drawing.Size(40, 23);
            this.buForward.TabIndex = 30;
            this.buForward.Text = "前进";
            this.buForward.UseVisualStyleBackColor = true;
            this.buForward.Click += new System.EventHandler(this.buForward_Click);
            // 
            // buRefresh
            // 
            this.buRefresh.Location = new System.Drawing.Point(102, 10);
            this.buRefresh.Name = "buRefresh";
            this.buRefresh.Size = new System.Drawing.Size(40, 23);
            this.buRefresh.TabIndex = 31;
            this.buRefresh.Text = "刷新";
            this.buRefresh.UseVisualStyleBackColor = true;
            this.buRefresh.Click += new System.EventHandler(this.buRefresh_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(5, 618);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 12);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "更多：http://udnz.com/Works/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 661);
            this.Controls.Add(this.buRefresh);
            this.Controls.Add(this.buForward);
            this.Controls.Add(this.buBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.buLoad);
            this.Name = "FDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C/S 与 B/S 间的交互";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDemo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buLoad;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button buViewHtml;
        private System.Windows.Forms.TextBox tbHtml;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button buFunJS;
        private System.Windows.Forms.TextBox tbPara1;
        private System.Windows.Forms.Button buSetHtml;
        private System.Windows.Forms.TextBox tbChanging;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buGetVar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buGetJson;
        private System.Windows.Forms.Button buGetObj;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buInvokeJSObjMethod;
        private System.Windows.Forms.TextBox tbPara2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buGetFlashSize;
        private System.Windows.Forms.Button buSetFlashSize;
        private System.Windows.Forms.Button buViewSource;
        private System.Windows.Forms.Button buOption;
        private System.Windows.Forms.Button buFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buBack;
        private System.Windows.Forms.Button buForward;
        private System.Windows.Forms.Button buRefresh;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

