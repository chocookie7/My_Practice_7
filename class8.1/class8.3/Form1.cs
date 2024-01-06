using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void BookDelegate(Book[] books);
        Book[] books = new Book[3];
        static int index;
        private void button1_Click(object sender, EventArgs e)
        {
            if (index < books.Length)
            {
                books[index] = new Book(textBox1.Text, Convert.ToDouble(textBox2.Text));
                label3.Text += books[index].GetMessage() + "\n";
                index++;
            }
            else
            {
                label3.Text += String.Format("图书挂添加已满！\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookDelegate bookgate = new BookDelegate(Book.BookSort);
            bookgate(books);
            label3.Text += "\n按价格排序的图书信息：\n";
            foreach(Book bk in books)
            {
                label3.Text+=string.Format("{0}\n",bk.GetMessage());
    
            }
        }
    }
}
