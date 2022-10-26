using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int produkt, int produkt1)
        {
            return produkt1 * produkt;
        }

        public int Division(int dividend, int divisor)
        {
            return dividend / divisor;
        }
    }
}