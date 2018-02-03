using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //具体类
    class Person
    {

        public Person() {       }

        public string peopleName;

        public Person(string peopleName)
        {
            this.peopleName = peopleName;
        }

        public virtual void Show()
        {
            Console.WriteLine("  " + peopleName);
        }

    }
}
