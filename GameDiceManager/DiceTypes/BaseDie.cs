﻿using DiceTypes.Interfaces;
using System;
using System.Linq;

namespace DiceTypes
{
    public class BaseDie
    {
        // The base die should be in charge of its own seeding

        private int numberOfFaces;

        private int _randomSeed;

        private int _rangeShiftValue = 0;
        private int ExclusiveUpperBound { get { return (numberOfFaces + 1) + _rangeShiftValue; } }
        private int InclusiveLowerBound { get { return 1 + _rangeShiftValue; } }

        private int _rollResult;

        public BaseDie(int numberOfFaces)
        {
            this.numberOfFaces = numberOfFaces;
            _randomSeed = Guid.NewGuid().GetHashCode();
        }

        public BaseDie(int numberOfFaces, int randomSeed)
        {
            this.numberOfFaces = numberOfFaces;
            _randomSeed = randomSeed;
        }

        public BaseDie(int numberOfFaces, ISeedGenerator seedGenerator)
        {
            this.numberOfFaces = numberOfFaces;
            _randomSeed = seedGenerator.GetRandomSeed();
        }

        public string GetFaceNumbers()
        {
            var numbersOnDie = Enumerable.Range(InclusiveLowerBound, numberOfFaces);
            return string.Join(", ", numbersOnDie);
        }

        public virtual int RollDie()
        {
            var randomizer = new Random(_randomSeed);
            var result = randomizer.Next(InclusiveLowerBound, ExclusiveUpperBound);
            _rollResult = result;

            return result;
        }

        public void ShiftRange(int rangeShiftValue)
        {
            _rangeShiftValue = rangeShiftValue;
        }

        public int ReportRollValue()
        {
            return _rollResult;
        }
    }
}
