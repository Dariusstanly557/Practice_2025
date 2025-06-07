using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Polymorphism
    {
    }

    #region Run - Time Polymorphism



    public abstract class Payment
    {
        public abstract void Pay(decimal amount);
    }

    public class CreditCardPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card");
        }
    }

    public class PayPalPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal");
        }
    }


    #endregion

    #region Compile-Time Polymorphism

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }


    #endregion


}
