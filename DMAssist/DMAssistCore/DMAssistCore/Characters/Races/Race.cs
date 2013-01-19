using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMAssist.Core.Enums;

namespace DMAssist.Core.Characters.Races
{
	public abstract class Race
	{

		public virtual RaceTypes RaceType { get; set; }
		public virtual void SetRaceType(RaceTypes raceType)
		{
			this.RaceType = raceType;
		}

		private int _constitution = 0;
		public virtual int Constitution
		{
			get
			{
				if (RaceType == DMAssist.Core.Enums.RaceTypes.Dwarf)
				{
					return _constitution + 2;
				}
				return _constitution;
			}
			set
			{
				_constitution = value;
			}
		}

		private int _charisma = 0;
		public virtual int Charisma
		{
			get
			{
				if (RaceType == DMAssist.Core.Enums.RaceTypes.Dwarf)
				{
					return _charisma - 2;
				}
				return _charisma;
			}
			set
			{
				_charisma = value;
			}
		}

	}
}
