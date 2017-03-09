using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace WeChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket ss;
        private void connect_Click(object sender, EventArgs e)
        {
             ss = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            
            IPAddress ip = IPAddress.Parse(txtip.Text);
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(port.Text));
            ss.Connect(point);
            ShowMsg("连接成功");
            //需要开启一个新的线程
            Thread tr = new Thread(Recive);
            tr.IsBackground = true;
            tr.Start();
        }

        private void ShowMsg(String str)
        {
            txtlog.AppendText(str + "\r\n");
        }
        /// <summary>
        /// 不停的接受服务器发来的消息
        /// </summary>
        void Recive()
        {
            while (true)
            {
                try
                {
                    byte[] buff = new byte[1024 * 1024 * 2];
                    int r = ss.Receive(buff);
                    if (r == 0)
                    {
                        break;
                    }
                    if (buff[0]==0)
                    {
                        string str = System.Text.Encoding.UTF8.GetString(buff);
                        Console.WriteLine(str);
                        ShowMsg(ss.RemoteEndPoint + ":" + str);
                    }
                    else if (buff[0]==1)
                    {
                        //保存文件
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"C:\Users\LONG\Desktop";
                        sfd.Title = "你要发啥？";
                        sfd.Filter = "所有文件11|*.*";
                        sfd.ShowDialog(this);
                        string path = sfd.FileName;
                        using (FileStream fswrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {

                            fswrite.Write(buff, 1, r - 1);
                        }
                        MessageBox.Show("保存成功");
                    }
                    else if (buff[0]==2)
                    {
                        ZD();
                    }
                
                }
                catch (System.Exception ex)
                {

                }


            }
         
        }

        void ZD()
        {

            for (int i = 0; i < 500; i++)
            {

                this.Location = new Point(200, 200);
                this.Location = new Point(280, 200);
            }
        }

        private void sendmsg_Click(object sender, EventArgs e)
        {
            string str = txtmsg.Text.Trim();
            byte[] buf = System.Text.Encoding.UTF8.GetBytes(str);
            ss.Send(buf);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        

    }
}
