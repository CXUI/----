using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //外套
    class Coat:Clothing
    {
        public override void Show()
        {
            Console.Write("    外套");
            base.Show();
        }
    }
}
