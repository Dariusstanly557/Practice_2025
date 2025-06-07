using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class MethodHiding
    {
        public class BaseClass
        {
            public void Show()
            {
                Console.WriteLine("Base Show()");
            }
        }

        public class DerivedClass : BaseClass
        {
            public new void Show()
            {
                Console.WriteLine("Derived Show()");
            }
        }

    }
}
