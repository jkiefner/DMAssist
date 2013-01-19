using System.Collections.Generic;
using DMAssistCore.Character.Attribute;
using DMAssistCore.Character.Races;
using DMAssistCore.Characters.Races;
namespace DMAssistCore.Character
{
	public abstract class Character : Race
	{
		public abstract List<Skill> Skills { get; set; }
		
	}
}