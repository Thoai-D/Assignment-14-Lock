using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_14_Lock
{
    class CombinationLock:Lock
    {
        private string Combination;

        public CombinationLock(string c)
        {
            Combination = c;
        }

        public void OpenLock(string c)
        {
            if(c == Combination)
            {
                Locked = false;
            }
        }

        public void ChangeCombination(string newcombination)
        {
            int c;
            if(Locked == false && int.TryParse(newcombination, out c) && c > 0 && newcombination.Length == 3)
            {
                Combination = newcombination;
            }
        }
    }
}
