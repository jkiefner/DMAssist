﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace DMAssist.Core.Dice
{
	public class SixSidedDie : IDie
	{

        public int DieRoll
        {
            get
            {
                Random randomGenerator = new Random();
                return randomGenerator.Next(1, 6);
            }
        }

    }
}
