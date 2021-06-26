using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritham_
{
   public class InsectionSort
    {
        public int i, j;
        public string[] Array = { "Sai", "Rishi", "Ravi", "Ram" };
        public string[] Check(string[] Array)
        {
            for (i =1; i <= Array.Length; i++)
            {
                string temp = Array[i];
                j = i - 1;
                while (j >= 0 && Array[j].CompareTo(temp) > 0)
                {
                    Array[j + 1] = Array[j];
                    j--;

                }
                Array[j + 1] = temp;

            }
            return Array;
        }

        internal void Check()
        {
            throw new NotImplementedException();
        }
    }
}
