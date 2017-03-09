namespace WeChatClient
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sendmsg = new System.Windows.Forms.Button();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendmsg
            // 
            this.sendmsg.Location = new System.Drawing.Point(519, 370);
            this.sendmsg.Name = "sendmsg";
            this.sendmsg.Size = new System.Drawing.Size(75, 23);
            this.sendmsg.TabIndex = 10;
            this.sendmsg.Text = "发送信息";
            this.sendmsg.UseVisualStyleBackColor = true;
            this.sendmsg.Click += new System.EventHandler(this.sendmsg_Click);
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(163, 212);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(447, 128);
            this.txtmsg.TabIndex = 8;
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(148, 68);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(447, 128);
            this.txtlog.TabIndex = 9;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(281, 14);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(37, 21);
            this.port.TabIndex = 6;
            this.port.Text = "50000";
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(163, 14);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(100, 21);
            this.txtip.TabIndex = 5;
            this.txtip.Text = "192.168.1.239";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(507, 7);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 32);
            this.connect.TabIndex = 11;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 406);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.sendmsg);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.port);
            this.Controls.Add(this.txtip);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendmsg;
        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Button connect;
    }
}

