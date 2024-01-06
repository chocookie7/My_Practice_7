using System;
using System.Collections.Generic;
using System.Text;

namespace class8._3
{
    public class Book:IComparable<Book>
    {
        private string bookName;
        private double bookPrice;
        public string BookName { get { return bookName; } set { bookName = value; } }
        public double BookPrice { get { return bookPrice; } set { bookPrice = value; }
        
        public Book(string Name,double Price)
        {
            this.bookName = Name;
            this.bookPrice = Price;
        }
        public int CompareTo(Book other)
        {
            return Convert.ToInt32((this.bookPrice - other.bookPrice));
        }
        public string GetMessage()
        {
            return string.Format("图书名：{0},价格：{1}", bookName, bookPrice);
        }
        public static void BookSort(Book[] books)
        {
            Array.Sort(books);
        }

        
    }
}
