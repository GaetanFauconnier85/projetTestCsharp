﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTestUnitaire
{
    public class Trigger : Ibreakable
    {
        public void Fire()
        {
            string message = "Fire !";
            Console.WriteLine(message);
        }

        int pv;
        public void RecupLifePoint()
        {
            pv = 100;
        }
        public bool verifVivant()
        {
            RecupLifePoint();

            if (pv > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
