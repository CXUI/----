using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Work
    {
        public State state;

        //初始化状态
        public Work()
        {
            state = new MorningStats();
        }
        private int hour;

        public int Hour { get => hour; set => hour = value; }


        //切换状态
        public void SetState(State s)  
        {
            state = s;
        }

        //执行状态
        public void WriteProgam()
        {
            state.WriteProgram(this);
        }
    }
}
