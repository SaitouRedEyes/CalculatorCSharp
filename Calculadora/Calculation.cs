using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Calculation : IMathOperations
    {
        public Calculation() { }

        public float Sum(float n1, float n2) { return n1 + n2; }

        public float Subtraction(float n1, float n2) { return n1 - n2; }

        public float Multiplication(float n1, float n2) { return n1 * n2; }

        public float Division(float n1, float n2) 
        {
            if (n2 == 0) n2 = 1;

            return n1 / n2; 
        }

        public int Fibonacci(int n)
        {
            if (n <= 1) return n;

            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}
