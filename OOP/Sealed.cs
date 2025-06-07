using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Sealed
    {
        //Ex : 1

        sealed class Animal
        {
            public void Speak()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }

        // This will cause a compile-time error
        //class Dog : Animal // ❌ Error: cannot derive from sealed type
        //{
        //}



        #region Sealing Methods:

        //You can also seal a method, but only if it's originally declared as virtual or override. This is useful when:



        class Base
        {
            public virtual void DoSomething() { }
        }

        class Derived : Base
        {
            public sealed override void DoSomething()
            {
                Console.WriteLine("No more overrides allowed.");
            }
            public virtual void DoSomethingV2()
            {
                Console.WriteLine("No more overrides allowed.");
            }
        }

        class AnotherDerived : Derived
        {
            // This will cause an error:
            //public override void DoSomething() { }
            public override void DoSomethingV2()
            {
                Console.WriteLine("No more overrides allowed.");
            }
        }



        #endregion

    }
}
