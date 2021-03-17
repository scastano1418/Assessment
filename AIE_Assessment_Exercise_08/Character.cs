using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    abstract class Character : GameObject
    {
        protected int AT;
        protected int HP;
        protected int DF;

        public Character(int at, int hp, int df)
        {
            this.AT = at;
            this.HP = hp;
            this.DF = df;
        }

        public bool IsAlive()
        {
            return HP > 0;
        }
    }
}
 