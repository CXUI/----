using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class NightState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour<24)
            {
                Console.WriteLine("晚上好，很困");
            }
            else
            {
                work.SetState(new MorningStats());
                work.WriteProgam();
            }
        }
    }
}
