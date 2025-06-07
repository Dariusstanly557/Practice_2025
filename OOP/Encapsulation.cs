using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Encapsulation
    {
        private int age;
        private int age2;

        public int Age
        {
            get { return age; }

            set
            {
                if (age2 > value) {
                    age= age2 + value;                  
                }
            }
        }
    }
}

