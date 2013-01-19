using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMAssist.Core.Character.Races
{
	public class Dwarf : Character
	{
		public Dwarf(Enums.RaceTypes raceType)
		{
			SetRaceType(raceType);
		}
		public override List<Attribute.Skill> Skills
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
