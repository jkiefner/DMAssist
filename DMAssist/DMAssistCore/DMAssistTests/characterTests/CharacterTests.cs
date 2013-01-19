using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMAssist.Core.Character.Races;
using NUnit;
using NUnit.Framework;
using DMAssist.Core.Enums;

namespace DMAssist.Tests.characterTests
{
	[TestFixture]
	public class CharacterTests
	{
		[Test]
		public void CanInstantiateACharacterTest()
		{
			Dwarf dwarf = new Dwarf(RaceTypes.Dwarf);
			Assert.That(dwarf.RaceType == RaceTypes.Dwarf);
			Assert.That(dwarf.Constitution == 2);
			Assert.That(dwarf.Charisma == -2);
		}
	}
}
