using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DMAssistCore.Dice;
using System.IO;
using System.Threading;

namespace DMAssistTests.Dice
{
    [TestFixture]
    public class DiceRepositoryTests
    {
        [Test]
        public void CanGetTotalDiceScoreFromListOfDiceTest()
        {
            List<IDie> diceSet = new List<IDie>{
            new SixSidedDie(),
            new SixSidedDie(),
            new SixSidedDie(),
            new TwentySidedDie()
        };
            DiceRepository diceRepo = new DiceRepository();
            int diceScore = diceRepo.GetDiceRollTotal(diceSet);
            Console.WriteLine(string.Format("Multiple dice total test: {0}", diceScore));
            Assert.That(diceScore, Is.GreaterThan(2));
            Assert.That(diceScore, Is.LessThan(39));
        }
        [Test]
        public void Roll1000TwentySidedTest()
        {
            StringBuilder resultstring = new StringBuilder();
            List<int> intList = new List<int>();
            resultstring.AppendLine("DieRoll");
            int length = 1000;
            for (int i = 0; i < length; i++)
            {
                
                TwentySidedDie td = new TwentySidedDie();
                intList.Add(td.DieRoll);
                Thread.Sleep(1000);
            }
            Dictionary<int, int> scoreDict = new Dictionary<int, int>();
            for (int i = 1; i < 21; i++)
            {
                scoreDict[i] = intList.Where(x => x == i).Count();
                
            }

            StringBuilder header = new StringBuilder();
            StringBuilder row = new StringBuilder();
            foreach (var item in scoreDict)
            {
                header.Append(item.Key + ",");
                row.Append(item.Value + ",");
            }

            using (StreamWriter sr = new StreamWriter("c:/testouput.csv"))
            {
                sr.WriteLine(header.ToString());
                sr.WriteLine(row.ToString());
            }

        }
    }
}
