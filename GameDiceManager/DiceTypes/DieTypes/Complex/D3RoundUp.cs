﻿using DiceTypes.Interfaces;
using System;

namespace DiceTypes.DieTypes.Complex
{
    public class D3RoundUp : BaseDie, IDie
    {
        public D3RoundUp() : base(6)
        {

        }

        public D3RoundUp(int randomSeed): base(6, randomSeed)
        {

        }

        public string GetDieType()
        {
            return "D3 Round Up (D6 result / 2 rounded up)";
        }

        public override int RollDie()
        {
            var d6Result = base.RollDie();
            var d3Result = d6Result / 2.0;

            var result = Math.Ceiling(d3Result);

            return Convert.ToInt32(result);
        }
    }
}