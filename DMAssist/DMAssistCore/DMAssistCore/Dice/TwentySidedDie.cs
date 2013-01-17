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
			:base()
		{ }

        public TwentySidedDie(Random randomGenerator)
            : base(randomGenerator)
        {
            _randomGenerator = randomGenerator;
        }


        public override Random RandomGenerator
        {
            get
            {
				if (_randomGenerator == null)
				{
					_randomGenerator = new Random();
				}
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
