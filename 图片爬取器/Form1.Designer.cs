namespace 图片爬取器
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPictrueHouzhui = new System.Windows.Forms.TextBox();
            this.txtPictruePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(119, 37);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(657, 21);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "https://tieba.baidu.com/p/2460150866?pn=3";
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(119, 76);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(394, 21);
            this.txtRegex.TabIndex = 1;
            this.txtRegex.Text = "src=\\\"(.+?\\\\.jpg)\\\" pic_ext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "说明：.jpg、.png、.bmp";
            // 
            // txtPictrueHouzhui
            // 
            this.txtPictrueHouzhui.Location = new System.Drawing.Point(119, 119);
            this.txtPictrueHouzhui.Name = "txtPictrueHouzhui";
            this.txtPictrueHouzhui.Size = new System.Drawing.Size(88, 21);
            this.txtPictrueHouzhui.TabIndex = 1;
            this.txtPictrueHouzhui.Text = ".jpg";
            // 
            // txtPictruePath
            // 
            this.txtPictruePath.Location = new System.Drawing.Point(119, 156);
            this.txtPictruePath.Name = "txtPictruePath";
            this.txtPictruePath.Size = new System.Drawing.Size(394, 21);
            this.txtPictruePath.TabIndex = 1;
            this.txtPictruePath.Text = "F:\\pictrues";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "提示信息：";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(120, 228);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(41, 12);
            this.lbInfo.TabIndex = 7;
            this.lbInfo.Text = "------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "正则表达式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "URL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "图片后缀名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "图片存放路径";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(624, 228);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 37);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 302);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPictrueHouzhui);
            this.Controls.Add(this.txtPictruePath);
            this.Controls.Add(this.txtRegex);
            this.Controls.Add(this.txtURL);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片爬取器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPictrueHouzhui;
        private System.Windows.Forms.TextBox txtPictruePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStart;
    }
}

