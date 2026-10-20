using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp6
{
    internal class Shop
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Square { get; set; }

        public Shop(string name)
        {
            Name = name;
            Description = "";
            Square = 0;
        }
        public Shop(string name, int square)
        {
            Name = name;
            if (square > 0) { Square = square; }
            else { throw new Exception("Idk wt u want"); }
            Description = "";
        }
        public Shop(string name, string description, int square)
        {
            Name = name;
            Description = description;
            if (square > 0) { Square = square; }
            else { throw new Exception("Idk wt u want"); }
        }
        public static Shop operator +(Shop p, int add)
        {
            return new Shop(p.Name, p.Description, p.Square + add);
        }
        public static Shop operator -(Shop p, int add)
        {
            if (p.Square - add > 0) { return new Shop(p.Name, p.Description, p.Square - add); }
            else { throw new Exception("Idk wt u want"); }
        }
        public static bool operator ==(Shop p, int add)
        {
            return (p.Square == add);
        }
        public static bool operator ==(Shop p1, Shop p2)
        {
            return (p1.Square == p2.Square);
        }
        public static bool operator !=(Shop p, int add)
        {
            return (p.Square != add);
        }
        public static bool operator !=(Shop p1, Shop p2)
        {
            return (p1.Square != p2.Square);
        }

        public static bool operator >(Shop p, int add)
        {
            return (p.Square > add);
        }
        public static bool operator >(Shop p1, Shop p2)
        {
            return (p1.Square > p2.Square);
        }
        public static bool operator <(Shop p, int add)
        {
            return (p.Square < add);
        }
        public static bool operator <(Shop p1, Shop p2)
        {
            return (p1.Square < p2.Square);
        }
    }
}
