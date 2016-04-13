using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    interface IMathOperations
    {
        float Sum(float n1, float n2);
        float Subtraction(float n1, float n2);
        float Multiplication(float n1, float n2);
        float Division(float n1, float n2);
        int Fibonacci(int n);
    }
}
