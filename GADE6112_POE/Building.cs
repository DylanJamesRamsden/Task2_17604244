using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    [Serializable]
    abstract class Building
    {
        protected int xpos;

        protected int ypos;

        protected int health;

        protected string faction;

        protected string symbol;

        //public Building() 

        abstract public bool isDead();

        abstract public string toString();
    }
}
