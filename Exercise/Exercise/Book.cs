using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Book
    {
        private string name;
        private Author[] authors;
        private double price;
        private int qty = 0;

        public Book(string name, Author[] authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = 0;
        }

        public Book(string name, Author[] authors, double price, int qty)
            : this(name, authors, price)
        {

            this.qty = qty;
        }

        public string getName()
        {
            return this.name;
        }

        public Author[] getAuthor()
        {
            return this.authors;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getQty()
        {
            return this.qty;
        }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        
        public override string ToString()
        {
            string[] a = new string[this.authors.Length];
            for(int i =0; i<this.authors.Length; i++)
            {
                a[i] = this.authors[i].ToString();
            }
            return string.Format("Book[name={0}, authors={1}, price={2}, qty={3}]", this.name, string.Join(",", a) ,  this.price, this.qty);
        }

        public string getAuthorNames()
        {
            string[] a = new string[this.authors.Length];
            for (int i = 0; i < this.authors.Length; i++)
            {
                a[i] = this.authors[i].GetName();
            }
            return string.Join(",",a);
        }
    }
}
