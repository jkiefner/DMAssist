using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DMAssistCore.Dice;

namespace DMAssistTests.Dice
{
    [TestFixture]
    public class DiceTests
    {
        [Test]
        public void CanInstantiateSixSidedDiceTest()
        {
            IDie sixSided = new SixSidedDie();
            Assert.That(sixSided, Is.Not.Null);
        }

        [Test]
        public void SixSidedDiceCanRollNumberTest()
        {
            IDie sixSided = new SixSidedDie();
            int rollResult = sixSided.DieRoll;
            Assert.That(rollResult, Is.Not.Null);
            Assert.That(rollResult, Is.GreaterThan(0));
        }

        [Test]
        public void SixSidedDiceReturnsRangeFromOneToSixTest()
        {
            IDie sixSided = new SixSidedDie();
            int rollResult = sixSided.DieRoll;
            Console.Write(string.Format("Six sided test result: {0}",rollResult));
            Assert.That(rollResult, Is.InRange(1, 6));
        }
        [Test]
        public void MultipleSixSidedDiceRollsAreInCorrectRangeTest()
        {
            IDie sixSided = new SixSidedDie();
            List<SixSidedDie> diceSet = new List<SixSidedDie>
            {
                new SixSidedDie(),
                new SixSidedDie(),
                new SixSidedDie()
            };
            Assert.That(diceSet[0].DieRoll, Is.InRange(1, 6));
            Assert.That(diceSet[1].DieRoll, Is.InRange(1, 6));
            Assert.That(diceSet[2].DieRoll, Is.InRange(1, 6));
        }
        [Test]
        public void TwentySidedDieRollInRangeTest()
        {
            Die twentySided = new TwentySidedDie();
			twentySided.Add(new TwentySidedDie());
			twentySided.Add(new TenSidedDie());
			foreach (var item in twentySided)
			{
				Console.WriteLine(item.DieRoll);
			}
			var singleDice = twentySided.Where(x => x.GetType() == typeof(TenSidedDie)).FirstOrDefault();

			Assert.That(singleDice.DieRoll > 0);
            int dieRollValue = twentySided.DieRoll;
            Assert.That(dieRollValue,Is.InRange(1,20));
        }
    }
}
