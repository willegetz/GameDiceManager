﻿using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes
{
    public class D8 : IDie
    {
        private readonly BaseDie _d8;

        public D8(int randomSeed)
        {
            _d8 = new BaseDie(8);
        }

        public string GetDieType()
        {
            return "D8";
        }

        public string GetFaceNumbers()
        {
            return _d8.GetFaceNumbers();
        }

        public int RollDie()
        {
            return _d8.RollDie();
        }
    }
}
