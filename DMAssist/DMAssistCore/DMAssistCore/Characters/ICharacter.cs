using System.Collections.Generic;
using DMAssist.Core.Character.Attribute;
using DMAssist.Core.Character.Races;
using DMAssist.Core.Characters.Races;
namespace DMAssist.Core.Character
{
	public abstract class Character : Race
	{
		public abstract List<Skill> Skills { get; set; }
		
	}
}