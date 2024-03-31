using System;


namespace BookProject
{
    internal class Book
    {
        private string name;
        private Author[] authors;       
        private double price;
        private int qty=0;

        public Book(string name, Author[] authors, double price)
        {

            this.name = name;
            this.authors = authors;
            this.price = price;         
        }
        public Book(string name, Author[] author, double price, int qty)
        {

            this.name = name;
            this.authors = author;
            this.price = price;
            this.qty = qty;
        }

        public string Name { get => name;}
        public Author[] Author { get => authors; }

        public double Price
        {
            get => price;

            set
            {
                if (value > 0)
                    this.price = value;
            }
        }

        public int Qty
        { 
            get => qty;
            set 
            {
                if (value > 0)
                    this.qty = value;
            }
        }

        public string ToString()
        {
            string s = "{";
            //duyet mang cac tac gia cua cuon sach nay
            for (int i = 0; i < authors.Length; i++)
            {
                s += "Author[";
                s += authors[i].ToString();
                s += "],";
            }
            s += "}";

            return $"Book[name = {name}, authors= {s}, price = {price}, qty = {qty}]";
        }

        public string getAuthorNames()
        {
            //duyet mang tac gia cua cuon sach nay
            string s = "" ;
            for (int i = 0; i < authors.Length - 1; i++)
            {
                 s +=  authors[i].Name + ",";
               
            }

            s += authors[authors.Length - 1].Name;

            return s;
        }
    }
}
