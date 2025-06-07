using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Abstraction
    {
        public abstract void Draw();
    }
    public  class AbstractionChiled : Abstraction
    {
        public override void Draw()
        {

        }

        public  void paint()
        {
            
        }

    }

    public abstract class PerentBase
    {
        public abstract void Draw(); 
        public  void Draw1()
        {

        }
    }
    public class Chiled : PerentBase
    {
        public string tempName = "1";
        public override void Draw()
        {
            Console.WriteLine("Overriden");
        }
        public void Draw1()
        {

        }
        public  void Draw2()
        {

        } public  void Draw3()
        {

        } public  void Draw4()
        {

        }
    }

    // Abstract class
    public abstract class Animal
    {
        // Abstract method – must be implemented in derived classes
        public virtual void MakeSound() { }

        // Concrete method – shared functionality
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
            Convert.ToString(Console.ReadLine());
            string res = "1";
        }
    }
    
    
    // Derived class
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
        public  void TEST()
        {
            Console.WriteLine("Bark");
        }

    } 

    

    #region Interface
    // Interface
    public interface IAnimal
    {

        void MakeSound(); // No implementation here
    }

    // Class implementing interface
    public class Dogg : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark");
        } 
        public void Test()
        {
            Console.WriteLine("Bark");
        }
    }


        


    // Usage
    


    #endregion

    public class Base
    {
        public Base()
        {

        }
        public void TesFunction1() { }
        public void TesFunction2() { }
        public void TesFunction3() 
        {
            int age;
            char initial;
            string name;
            DateTime dob;
        }

    }
    public class ForInstens : Base
    {
        public ForInstens() : base()
        {

        }
        public int MyProperty = 10;
        public void TesFunction4() { }

        

        

    }



}
