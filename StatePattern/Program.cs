using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work();
            work.Hour = 8;
            work.WriteProgam();

            work.Hour = 11;
            work.WriteProgam();

            work.Hour = 15;
            work.WriteProgam();

            work.Hour = 19;
            work.WriteProgam();
        }
    }
}
