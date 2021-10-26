using System;


namespace KompleksniBrojeviComplex
{
    struct Complex
    {
        public Complex(double Real, double Imaginary)
        {
            this.real = Real;
            this.imaginary = Imaginary;

        }

        public double Real
        {
            get
            {
                return real;
            }
        }

        public double Imaginary
        {
            get
            {
                return imaginary;
            }
        }

        //operator za zbrajanje
        public static Complex operator +(Complex a, Complex b)
            {
            return new Complex(a.real + b.real, a.imaginary + b.imaginary);

        }

        private readonly double real;
        private readonly double imaginary;


    }
}
