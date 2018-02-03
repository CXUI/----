using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //鞋子
    class Shoes:Clothing
    {

        public override void Show()
        {
            Console.Write("     鞋子");
            base.Show();
        }

    }
}
