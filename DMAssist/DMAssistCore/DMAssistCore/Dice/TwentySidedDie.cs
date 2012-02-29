using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DMAssistCore.Dice
{
    public class TwentySidedDie : Die
    {
        public TwentySidedDie()
        {

        }
        public TwentySidedDie(Random randomGenerator)
            : base(randomGenerator)
        {
            _randomGenerator = randomGenerator;
        }


        public override Random RandomGenerator
        {
            get
            {
                return _randomGenerator;
            }
            set
            {
                _randomGenerator = value;
            }
        }

        public override int DieRoll
        {
            get
            {
                return _randomGenerator.Next(1, 21);
            }
        }
    }
}
