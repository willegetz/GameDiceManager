using DiceTypes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceTypes.DieTypes
{
    public class D4 : BaseDie, IDie
    {
        public D4(): base(4)
        {

        }

        public string GetDieType()
        {
            return "D4";
        }
    }
}
