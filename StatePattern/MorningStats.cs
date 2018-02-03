using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class MorningStats : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour<9)
            {
                Console.WriteLine("早上好,状态迷糊");
            }
            else
            {
                work.SetState(new NoonState()); //那中午的状态注册进去
                work.WriteProgam();//运行中午状态，
            }
        }
    }
}
