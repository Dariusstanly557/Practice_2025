using System.Numerics;
using OOP;
using OOP.Debugging;
using static OOP.OperatorOverloading;







#region Debugging


DebuggingClass DbuggerClass = new DebuggingClass();
DbuggerClass.ExMethod();



#endregion







#region Polymorphism 

//*********** (Run - Time Polymorphism) *****************

List<Payment> payments = new List<Payment>
{
    new CreditCardPayment(),
    new PayPalPayment()
};

foreach (var payment in payments)
{
    payment.Pay(1000);  // Each one behaves differently
}

#endregion

#region Compile-Time Polymorphism

Calculator calc = new Calculator();

Console.WriteLine(calc.Add(2, 3));          // 5
Console.WriteLine(calc.Add(2.5, 3.1));      // 5.6
Console.WriteLine(calc.Add(1, 2, 3));       // 6






#endregion

#region MyRegion
Point p1 = new Point(2, 3);
Point p2 = new Point(4, 5);
Point result = p1 + p2;   // Calls the overloaded + operator
Console.WriteLine(result);
#endregion

#region inheritance



#endregion

#region Abstract

Animal myDog = new Dog();


myDog.MakeSound();  // Output: Bark
myDog.Sleep();      // Output: Sleeping...

#endregion

#region Interface

IAnimal ImyDog = new Dogg();
Dogg constrector = new Dogg();
IAnimal ImyDogNoDataLeak = new Dogg();



ForInstens ForInstens = new ForInstens();
Base Test = new ForInstens
{
    MyProperty = 1,
};

Test.TesFunction3();

#endregion
