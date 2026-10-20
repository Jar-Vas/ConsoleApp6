using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Prise { get ; set; }

        public Product(string name, int count, decimal prise)
        {
            Name = name;
            if (count > 0) { Count = count; }
            else { throw new Exception("Idk wt u want"); }
            Prise = prise;
        }

        public static Product operator +(Product p1, int add)
        {
            return new Product(p1.Name, p1.Count+add, p1.Prise);
        }

        public static Product operator -(Product p1, int add)
        {
            if (p1.Count - add >= 0) { return new Product(p1.Name, p1.Count - add, p1.Prise); }
            else { throw new Exception("Idk wt u want"); }
        }

        public static bool operator ==(Product p1, Product p2)
        {
            return (p1.Prise == p2.Prise);
        }
        public static bool operator !=(Product p1, Product p2)
        {
            return (p1.Prise != p2.Prise);
        }
        public static bool operator <(Product p1, Product p2)
        {
            return (p1.Prise < p2.Prise);
        }
        public static bool operator >(Product p1, Product p2)
        {
            return (p1.Prise > p2.Prise);
        }
    }
}
