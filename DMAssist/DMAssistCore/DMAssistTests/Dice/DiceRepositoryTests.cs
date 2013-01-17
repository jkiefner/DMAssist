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
        //[Test]
        //public void CanGetTotalDiceScoreFromListOfDiceTest()
        //{
        //    List<IDie> diceSet = new List<IDie>{
        //    new SixSidedDie(),
        //    new SixSidedDie(),
        //    new SixSidedDie(),
        //    new TwentySidedDie()
        //};
            
        //    int diceScore = DiceRepository.GetDiceRollTotal(diceSet);
        //    Console.WriteLine(string.Format("Multiple dice total test: {0}", diceScore));
        //    Assert.That(diceScore, Is.GreaterThan(2));
        //    Assert.That(diceScore, Is.LessThan(39));
        //}
        [Test]
        public void Roll1000SetsOfthreeTwentySidedTestYields()
        {
            //test outputs to csv file which can be opened
            // in Excel and graph to prove bell curve
            StringBuilder resultstring = new StringBuilder();
            List<int> intList = new List<int>();
            DiceRepository dRepo = new DiceRepository();
            int length = 1000;
            Random rgen = new Random();
			//for (int i = 0; i < length; i++)
			//{
			//    int rollResult =
			//        dRepo.GetDiceRollTotal(
			//        new List<Die> {
			//        new TwentySidedDie(rgen),
			//        new TwentySidedDie(rgen),
			//        new TwentySidedDie(rgen)
			//        });

			//    intList.Add(rollResult);
			//}

			for (int i = 0; i < length; i++)
			{
				int rollResult =
					dRepo.GetDiceRollTotal(
					new List<Die> {
                    new TwentySidedDie(),
                    new TwentySidedDie(),
                    new TwentySidedDie()
                    });

				intList.Add(rollResult);
			}

            Dictionary<int, int> scoreDict = new Dictionary<int, int>();
            for (int i = 1; i < 61; i++)
            {
                scoreDict[i] = intList.Where(x => x == i).Count();
                
            }

            StringBuilder header = new StringBuilder();
            StringBuilder row = new StringBuilder();
            foreach (var item in scoreDict)
            {
                header.Append("\"" + item.Key + "\",");
            }			

            using (StreamWriter sr = new StreamWriter("c:/testouput.csv"))
            {
                sr.WriteLine(header.ToString()
                    .Substring(0,header.ToString().Length - 1));
				foreach (var item in intList)
				{
					StringBuilder dataRow = new StringBuilder();
					for (int i = 0; i < 61; i++)
					{
						if (i == item)
						{
							dataRow.Append("1,");
						}
						else
						{
							dataRow.Append("0,");
						}
					}
					sr.WriteLine(dataRow.ToString()
						.Substring(0, dataRow.ToString().Length - 1));
				}
            }
        }
    }
}
