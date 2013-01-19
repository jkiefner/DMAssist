﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMAssistCore.Character.Races;
using DMAssistCore.Character.Attribute;

namespace DMAssistCore.Character
{
	public class Player 
	{
		private IRace _characterRace;
		public IRace CharacterRace
		{
			get
			{
				return _characterRace;
			}
			set
			{
				_characterRace = value;
			}
		}
		public List<Skill> Skills
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
