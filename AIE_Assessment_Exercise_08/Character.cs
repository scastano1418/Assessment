using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    class Character : GameObject
    {
        int AT;
        int HP;
        int DF;

        public bool IsAlive()
        {
            return HP > 0;
        }
    }
}
