using System;
namespace numere_rationale
{
    internal class Rational
    {
        private int a;
        private int b;

        public Rational(int a, int b)
        {
         
            if (b < 0)
            {
                a *= -1;
                b *= -1;
            }
            this.a = a;
            this.b = b;
            Simplify();
        }

        public override string ToString()
        {
            if (a == 0)
                return "0";
            if (b == 0)
                return "Nu exista";
            if (b == 1)
                return a.ToString();
            return a.ToString() + "/" + b.ToString();
        }

        public Rational Add(Rational r2)
        {
            if (r2.b != b)
                return new Rational(r2.a * b + a * r2.b, r2.b * b);
            else
                return new Rational(r2.a + a, b);
        }
        private void Simplify()
        {
            if (a != 0)
            {
                int cmmdc = Cmmdc(Math.Abs(a), Math.Abs(b));

                a /= cmmdc;
                b /= cmmdc;
            }
        }
        public Rational Subtract(Rational r2)
        {
            if (r2.b != b)
                return new Rational(r2.a * b - a * r2.b, r2.b * b);
            else
                return new Rational(r2.a - a, b);
        }

        public Rational Multiply(Rational r2)
        {
            return new Rational(r2.a * a, r2.b * b);
        }

        public Rational Devide(Rational r2)
        {
            return new Rational(a * r2.b, b * r2.a);
        }
        public int Cmmdc(int x, int y)
        {
            while (x != y)
                if (x > y)
                    x -= y;
                else
                    y -= x;
            return x;
        }
    }
}