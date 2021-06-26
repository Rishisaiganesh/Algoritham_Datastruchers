using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritham_
{
   public class Bubble
    {
        int i, j;
        int[] Array = { 1, 2, 4, 3, 4, 5, 9, 7, 6, 8 };
        public void Bubblesort()
        {
            for (j = 0; j < Array.Length - 1; i++)
            {
                if (Array[j] > Array[j + 1])
                {
                    int temp = Array[j + 1];
                    Array[j + 1] = temp;

                }
            }
        }
         foreach(var value in Array)
         {
               Console.WriteLine(value);
         }    
   }
}
