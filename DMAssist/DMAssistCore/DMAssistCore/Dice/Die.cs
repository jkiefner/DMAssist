using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMAssistCore.Dice
{
    public abstract class Die
    {
        public abstract Random RandomGenerator { get; set; }
        protected Random _randomGenerator { get; set; }

        public Die() {
            _randomGenerator = new Random();
        }

        public Die(Random randomGenerator)
        {}
        public abstract int DieRoll{get;}
    }
}
