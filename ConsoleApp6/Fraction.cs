using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ConsoleApp6
{
    internal class Fraction
    {
        public long A { get; set; }
        public long B { get; set; }

        void simplify()
        {
            long g = (long)BigInteger.GreatestCommonDivisor(A, B);
            A /= g; B /= g; 
        }

        public Fraction (long a, long b)
        {
            A = a;
            if (b == 0) { throw new Exception("Idk wt u want"); }
            B = b;
            this.simplify();
        }
        public Fraction()
        {
            A = 1;
            B = 1;
        }

        // if (b == 0) { throw new Exception("Idk wt u want"); }
        #region 1
        public static Fraction operator +(Fraction p, int b)
        {
            return new Fraction(p.A + b * p.B, p.B);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.A * b.B + a.B * b.A, a.B * b.B);
        }

        public static Fraction operator -(Fraction p, int b)
        {
            return new Fraction(p.A - b*p.B, p.B);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.A*b.B - a.B*b.A, a.B*b.B);
        }

        public static Fraction operator *(Fraction p, int b)
        {
            return new Fraction(p.A*b, p.B);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.A*b.A, a.B*b.B);
        }


        public static Fraction operator /(Fraction p, int b)
        {
            if (b == 0) { throw new Exception("Idk wt u want"); }
            return new Fraction(p.A, p.B * b);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.A == 0) { throw new Exception("Idk wt u want"); }
            return new Fraction(a.A*b.B, a.B*b.A);
        }
        #endregion 1



        public static bool operator ==(Fraction p, int b)
        {
            return (p.A == b * p.B);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return (a.A*b.B == a.B*b.A);
        }
        public static bool operator !=(Fraction p, int b)
        {
            return (p.A != b * p.B);
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return (a.A * b.B != a.B * b.A);
        }
    }
}
