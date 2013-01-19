using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMAssist.Core.Characters.Attributes
{
	public class Attributes
	{
		public int StrenthScore { get; set; }
		public int StrengthAbilityModifier { get; set; }
		public int DexterityScore { get; set; }
		public int DexterityAbilityModifier { get; set; }
		public int ConstitutionScore { get; set; }
		public int ConstitutionAbilityModifier { get; set; }
		public int IntelligenceScore { get; set; }
		public int IntelligenceAbilityModifier { get; set; }
		public int WisdomScore { get; set; }
		public int WisdomAbilityModifier { get; set; }
		public int CharismaScore { get; set; }
		public int CharismaAbilityModifier
		{
			get
			{
				return GetAbilityModifierValue(CharismaAbilityModifier);
			}
		}

		private int GetAbilityModifierValue(int abilityScore)
		{
			switch (abilityScore)
			{
				case 1:
				case 2:
					return -4;
					break;
				case 3:
				case 4:
					return -3;
						break;
				case 5:
				case 6:
					return -2;
						break;
				case 7:
				case 8:
					return -1;
					break;
				case 9:
				case 10:
				case 11:
					return 0;
					break;
				case 12:
				case 13:
					return 1;
					break;
				case 14:
				case 15:
					return 2;
					break;
				case 16:
				case 17:
					return 3;
					break;
				case 18:
				case 19:
					return 4;
					break;
				case 20:
					return 5;
					break;
				default:
					return 0;
					break;
			}
		}
	}
}
