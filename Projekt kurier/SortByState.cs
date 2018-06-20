using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_kurier
{
    class SortByState : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            string[] StateLevel = new string[4];
            StateLevel[0] = "Pending";
            StateLevel[1] = "Delivered";
            StateLevel[2] = "Cancelled";
         

            Package itemX = (Package)x;
            Package itemY = (Package)y;
            int xlevel = 0, ylevel = 0;

            for (int i = 0; i < 3; i++)
            {
                if (itemX.State.ToString() == StateLevel[i]) xlevel = i;
                if (itemY.State.ToString() == StateLevel[i]) ylevel = i;
            }

            return xlevel.CompareTo(ylevel);
        }
    }
}

