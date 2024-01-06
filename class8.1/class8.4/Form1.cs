using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate string SayDelegate();//定义委托
        public event SayDelegate SayEvent;//定义事件
        public string GetMessage()
        {
            return string.Format("我喜欢c#");
        }
        public string GetSayEventMessage()
        {
            return SayEvent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 fn=new Form1();
            fn.SayEvent = new SayDelegate(fn.GetMessage);
            label1.Text = "\n" + fn.GetSayEventMessage();
            
        }
    }
}
