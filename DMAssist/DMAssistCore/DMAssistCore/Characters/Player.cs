using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMAssistCore.Character.Race;
using DMAssistCore.Character.Attribute;

namespace DMAssistCore.Character
{
	public class Player : ICharacter
	{
		public IRace CharacterRace
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}
				public Skill Skill
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}

		public List<Gear> Gear
		{
			get
			{
				throw new System.NotImplementedException();
			}
			set
			{
			}
		}
	}
}
