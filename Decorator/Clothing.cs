using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //装饰类

    class Clothing:Person
    {
        public Person person;
        
        public void Decorator(Person person)
        {
            this.person = person;
        }

        public override void Show()
        {
            if (person!=null)
            {
                person.Show();
            }
        }

    }
}
