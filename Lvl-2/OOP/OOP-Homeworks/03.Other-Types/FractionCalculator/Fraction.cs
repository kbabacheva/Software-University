using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set
            {
                checked
                {
                    this.numerator = value;
                }
            }
        }

        public long Denominator 
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denominator cannot be 0");
                }
                checked
                {
                    this.denominator = value;
                }
            }
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            first.Numerator *= second.Denominator;
            second.Numerator *= first.Denominator;
            long commonDenom = first.Denominator * second.Denominator;
            return new Fraction(first.Numerator + second.Numerator, commonDenom);
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            first.Numerator *= second.Denominator;
            second.Numerator *= first.Denominator;
            long commonDenom = first.Denominator * second.Denominator;
            return new Fraction(first.Numerator - second.Numerator, commonDenom);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}",this.Numerator,this.Denominator);
        }
    }
}
