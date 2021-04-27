using DiceTypes.Interfaces;
using System;
using System.Linq;

namespace DiceTypes.DieTypes
{
    public class D3RoundUp : IDie
    {
        private BaseDie _d6;

        public D3RoundUp(int seed)
        {
            _d6 = new BaseDie(6);
        }
        public string GetDieType()
        {
            return "D3 Round Up (D6 result / 2 rounded up)";
        }

        public string GetFaceNumbers()
        {
            return _d6.GetFaceNumbers();
        }

        public int RollDie()
        {
            var d6Result = _d6.RollDie();
            var d3Result = d6Result / 2.0;

            var result = Math.Ceiling(d3Result);

            return Convert.ToInt32(result);
        }
    }
}
