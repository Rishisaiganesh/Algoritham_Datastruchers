using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritham_
{
    public class Binarysearch
    {
        public int Binary(string[] Array, string value)
        {
            int leftValue = 0, RightValue = Array.Length - 1;
            while (leftValue <= RightValue)
            {
                int middleValue = leftValue + RightValue / 2;
                int find = value.CompareTo(Array[middleValue]);
                if (find == 0)
                    return middleValue;
                if (find > 0)
                    return middleValue + 1;
                else
                    return middleValue - 1;
            }
            return -1;
        }
    }
}