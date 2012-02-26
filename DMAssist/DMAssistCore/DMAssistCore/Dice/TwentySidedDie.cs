using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DMAssistCore.Dice
{
   public class TwentySidedDie : IDie
    {
        #region IDie Members


        public int DieRoll
        {
            get {
                Random randomGenerator = new Random();
                return randomGenerator.Next(1, 20);
            }
        }

        #endregion
    }
}
