using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan
{
    internal class book : author
    {
        private string name;
        private author author;
        private double price;
        private int qty;

        public author(author other)
        {
            this.name = other.Name;
            this.
        }
        public string Name { get => name; set => name = value; }
        internal author Author { get => author; set => author = value; }

        public book(string name, author author, double price, int qty)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = qty;
        }
        public book(string name, author author, double price)
        {
            this.name = name;
            this.author = author;
            this.price = price;
        }
        public double getPrice()
        {
            return price;
        }
        public void setPrice(double price)
        {           
            this.price = price;
        }
        public int getQty() { return qty; }
        public void setQty(int qty)
        {
            this.qty = qty;
        }
        public void ToSring()
        {
            Console.WriteLine( $"{Name} {Author} {price} {qty}");
        }
    }


}
