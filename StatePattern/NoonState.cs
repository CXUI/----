using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class NoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour<12)
            {
                Console.WriteLine("中午好，状态良好");
            }
            else
            {
                work.SetState(new AfternoonStats());
                work.WriteProgam();
            }
        }
    }
}
