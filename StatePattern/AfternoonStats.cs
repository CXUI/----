using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class AfternoonStats : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour<17)
            {
                Console.WriteLine("下午好，状态犯困");

            }
            else
            {
                work.SetState(new NightState());
                work.WriteProgam();
            }
        }
    }
}
