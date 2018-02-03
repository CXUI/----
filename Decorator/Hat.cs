using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //帽子类
    
    class Hat:Clothing
    {
        private  string name;

        public void GetHat()
        {
            int number = Int32.Parse( Console.ReadLine());

            switch (number)
            {
                case 1: Hat1 hat1 = new Hat1(); name = hat1.Name; return;
                case 2: Hat2 hat2 = new Hat2();name = hat2.Name; return;
                default:return;
            }
            
        }

        public override void Show()
        {

            GetHat();
            Console.Write("     " + "帽子"+name);
            base.Show();
        }
    }

    class Hat1
    {
        private string name="帽子1";

        public string Name { get => name;  }
    }
    class Hat2
    {
        private string name="帽子2";

        public string Name { get => name;  }
    }
}
