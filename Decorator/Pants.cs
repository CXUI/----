using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //裤子
    class Pants:Clothing
    {
        public override void Show()
        {
            Console.Write("        裤子");
            base.Show();
        }
    }
}
