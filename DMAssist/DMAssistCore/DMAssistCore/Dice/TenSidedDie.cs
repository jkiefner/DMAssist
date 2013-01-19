using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMAssist.Core.Dice
{
	public class TenSidedDie : Die
	{

		
		public TenSidedDie()
			:base()
		{ }

		public TenSidedDie(Random randomGenerator)
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
					_dieRoll = _randomGenerator.Next(1, 11);
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
