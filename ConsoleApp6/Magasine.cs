using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp6
{
    internal class Magasine
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PersonalCount { get; set; }

        public Magasine(string name)
        {
            Name = name;
            Description = "";
            PersonalCount = 0;
        }
        public Magasine(string name, int personalCount)
        {
            Name = name;
            if (personalCount >= 0) { PersonalCount = personalCount; }
            else { throw new Exception("Idk wt u want"); }
            Description = "";
        }
        public Magasine (string name, string description, int personalCount)
        {
            Name = name;
            Description = description;
            if (personalCount >= 0) { PersonalCount = personalCount; }
            else { throw new Exception("Idk wt u want"); }
        }
        public static Magasine operator+(Magasine p, int add)
        {
            return new Magasine(p.Name, p.Description, p.PersonalCount + add);
        }
        public static Magasine operator -(Magasine p, int add)
        {
            if (p.PersonalCount - add >= 0) { return new Magasine(p.Name, p.Description, p.PersonalCount - add); }
            else { throw new Exception("Idk wt u want"); }
        }
        public static bool operator ==(Magasine p, int add)
        {
            return (p.PersonalCount == add);
        }
        public static bool operator ==(Magasine p1, Magasine p2)
        {
            return (p1.PersonalCount == p2.PersonalCount);
        }
        public static bool operator !=(Magasine p, int add)
        {
            return (p.PersonalCount != add);
        }
        public static bool operator !=(Magasine p1, Magasine p2)
        {
            return (p1.PersonalCount != p2.PersonalCount);
        }

        public static bool operator >(Magasine p, int add)
        {
            return (p.PersonalCount > add);
        }
        public static bool operator >(Magasine p1, Magasine p2)
        {
            return (p1.PersonalCount > p2.PersonalCount);
        }
        public static bool operator <(Magasine p, int add)
        {
            return (p.PersonalCount < add);
        }
        public static bool operator <(Magasine p1, Magasine p2)
        {
            return (p1.PersonalCount < p2.PersonalCount);
        }
}
}
