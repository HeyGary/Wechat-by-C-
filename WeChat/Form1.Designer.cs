namespace WeChat
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
            this.ip = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.listen = new System.Windows.Forms.Button();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.sendmsg = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.Button();
            this.sendfile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(61, 29);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(100, 21);
            this.ip.TabIndex = 0;
            this.ip.Text = "192.168.1.239";
            this.ip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(179, 29);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(37, 21);
            this.port.TabIndex = 1;
            this.port.Text = "50000";
            // 
            // listen
            // 
            this.listen.Location = new System.Drawing.Point(313, 29);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(75, 23);
            this.listen.TabIndex = 2;
            this.listen.Text = "开始监听";
            this.listen.UseVisualStyleBackColor = true;
            this.listen.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(46, 83);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(447, 128);
            this.txtlog.TabIndex = 3;
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(61, 227);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(447, 128);
            this.txtmsg.TabIndex = 3;
            // 
            // sendmsg
            // 
            this.sendmsg.Location = new System.Drawing.Point(577, 274);
            this.sendmsg.Name = "sendmsg";
            this.sendmsg.Size = new System.Drawing.Size(75, 23);
            this.sendmsg.TabIndex = 4;
            this.sendmsg.Text = "发送信息";
            this.sendmsg.UseVisualStyleBackColor = true;
            this.sendmsg.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(417, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(79, 385);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(260, 21);
            this.address.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "文件地址";
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(388, 379);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(75, 23);
            this.choose.TabIndex = 8;
            this.choose.Text = "选择文件";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // sendfile
            // 
            this.sendfile.Location = new System.Drawing.Point(507, 379);
            this.sendfile.Name = "sendfile";
            this.sendfile.Size = new System.Drawing.Size(75, 23);
            this.sendfile.TabIndex = 8;
            this.sendfile.Text = "发送";
            this.sendfile.UseVisualStyleBackColor = true;
            this.sendfile.Click += new System.EventHandler(this.sendfile_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "震动";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 430);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sendfile);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sendmsg);
            this.Controls.Add(this.txtmsg);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.listen);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.Button sendmsg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Button sendfile;
        private System.Windows.Forms.Button button3;
    }
}

