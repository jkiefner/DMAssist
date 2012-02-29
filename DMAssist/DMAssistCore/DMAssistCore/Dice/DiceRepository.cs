using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMAssistCore.Dice
{
   public class DiceRepository
    {

        public int GetDiceRollTotal<T>(List<T> diceSet) where T : Die
        {
            int diceTotal = 0;
            foreach (var die in diceSet)
            {
                diceTotal += die.DieRoll;
            }
                return diceTotal;
        }
    }
}
