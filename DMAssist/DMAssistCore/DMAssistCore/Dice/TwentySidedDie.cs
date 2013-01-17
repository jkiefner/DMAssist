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

		private int _dieRoll = 0;
		public override int DieRoll
		{
			get
			{
				if (_dieRoll == 0)
				{
					_dieRoll = _randomGenerator.Next(1, 21);
					return _dieRoll;
				}
				else
				{
					return _dieRoll;
				}
				
			}
		}
	}
}
