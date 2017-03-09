using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace WeChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Socket sw = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            //创建端口号对象
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(port.Text));
            sw.Bind(point);
            ShowMsg(" 监听成功");
            sw.Listen(10);
            //等待客户端连接，并且创建一个负责通信的Socket
            Thread tr = new Thread(Listen);
            tr.IsBackground = true;
            tr.Start(sw);
        }
        Socket ss;
        void Listen(object o)
        {
            Socket sw = o as Socket;
            while (true)
            {
                 ss = sw.Accept();
                dicSocket.Add(ss.RemoteEndPoint.ToString(),ss);
                comboBox1.Items.Add(ss.RemoteEndPoint.ToString());
                ShowMsg(ss.RemoteEndPoint.ToString() + ":" + "连接成功");
                Thread tr = new Thread(Recive);
                tr.IsBackground = true;
                tr.Start(ss);
            }
        }

        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        void Recive(object o)
        {
            try
             {
	             Socket ss = o as Socket;
	                        while (true)
	                        {
	                            byte[] buffer = new byte[1024 * 1024 * 2];
	                            int r = ss.Receive(buffer);
	                            if (r == 0)
	                            {
	                                break;
	                            }
	                            string str = System.Text.Encoding.UTF8.GetString(buffer, 0, r);
	                            ShowMsg(ss.RemoteEndPoint + ":" + str);
	                        }
             }
             catch (System.Exception ex)
             {
 	
             }

        }
        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = txtmsg.Text;
            byte[] buf = System.Text.Encoding.UTF8.GetBytes(str);
         //   ss.Send(buf);
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buf);
            byte[] newbuff=list.ToArray();


            string ip = comboBox1.SelectedItem.ToString();
            dicSocket[ip].Send(newbuff);
        }

        private void ShowMsg(String str)
        {
            txtlog.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\LONG\Desktop";
            ofd.Title = "你要发啥？";
            ofd.Filter = "所有文件11|*.*";
            ofd.ShowDialog();
            address.Text = ofd.FileName;
        }
  


        private void sendfile_Click(object sender, EventArgs e)
        {
            string path = address.Text;
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read)) 
            {
                byte[] buf = new byte[1024 * 1024 * 5];

                int r = fsRead.Read(buf, 0, buf.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buf);
                byte[] newBuffer = list.ToArray();

                dicSocket[comboBox1.SelectedItem.ToString()].Send(newBuffer, 0, r+1, SocketFlags.None);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] buff = new byte[1];
            buff[0] = 2;
            dicSocket[comboBox1.SelectedItem.ToString()].Send(buff);
        }

    }
}
