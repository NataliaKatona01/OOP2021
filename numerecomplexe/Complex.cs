using System;

namespace numerecomplexe
{
    public class Complex
    {
        private double re;
        private double im;
        public Complex(double re) : this(re, 0)
        {

        }
        // TODO: parsing pe string pentru a scoate partea reala si partea imaginara
        // probabil ca s-ar putea face cu expresii regulare. 
        public Complex(string v)
        {

        }
        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        // TODO: modificat codul in asa fel incat sa tina cont de valori 0 sau negative.
        public override string ToString()
        {
            if (re == 0)
                return "(" + im.ToString() + "i" + ")";
            if (im == 0)
                return "(" + re.ToString() + ")";
            if (im < 0)
                return "(" + re.ToString() + im.ToString() + "i" + ")";

            return "(" + re.ToString() + "+" + im.ToString() + "i" + ")";
        }
        public Complex Add(Complex c2)
        {
            Complex rezultat = new Complex(c2.re + re, c2.im + im);
            return rezultat;
        }

        public Complex Subtract(Complex c2)
        {
            Complex rezultat = new Complex(re - c2.re, im - c2.im);
            return rezultat;
        }

        public Complex Multiply(Complex c2)
        {
            Complex rezultat = new Complex((re * c2.re) - (im * c2.im), (im * c2.re) + (re * c2.im));
            return rezultat;
        }

        public Complex Power(int pow)
        {
            Complex x = new Complex(re, im);
            Complex rez = new Complex(1);
            if (pow == 0)
                return new Complex(1);
            if (pow == 1)
                return x;
            for (int i = 0; i < pow; i++)
                rez = rez * x;

            return rez;
        }
        
        // TODO
        public double Real
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }
        public double Imag
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }
        public double Modul 
        {
            get
            {
                double rez = Math.Sqrt(re * re + im * im);
                return rez;
            }
        }
        
        public double Argument 
        {
            get
            {
                double rez = Math.Atan(im / re);
                return rez;
            }
        }


        // TODO
        // orice alte operatii pe care le cunoasteti cu operatii complexe. 
        public Complex Complement
        {
            get 
            {
                return new Complex(re, -im);
            }
        }

        // TODO: supraincarcarea operatorilor aritmetici pentru tipul Complex
        // Complex suma = c1 + c2;
        public static Complex operator + (Complex x, Complex y)
        {
            return new Complex(x.re + y.re, x.im + y.im);
        }
        public static Complex operator - (Complex x, Complex y)
        {
            return new Complex(x.re - y.re, x.im - y.im);
        }
        public static Complex operator * (Complex x, Complex y)
        {
            return new Complex((x.re * y.re) - (x.im * y.im), (x.im * y.re) + (x.re * y.im));
        }
        //ridicarea la putere
        public static Complex operator ^ (Complex x, int p)
        {
            Complex rez = new Complex(1);
            if (p == 0)
                return new Complex(1);
            if (p == 1)
                return x;
            for (int i = 0; i < p; i++)
                rez = rez * x;
            
            return rez;
        }
    }
}