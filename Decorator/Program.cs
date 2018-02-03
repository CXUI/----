using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("阴阳师");

            Hat hat = new Hat();
            Coat coat = new Coat();
            Pants pants = new Pants();
            Shoes shoes = new Shoes();
            hat.Decorator(person);
            coat.Decorator(hat);
            pants.Decorator(coat);
            shoes.Decorator(pants);
            shoes.Show();


        }
    }
}
