using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritham_
{
   public class Permutations
    {
        /// <summary>
        /// Creating Permutation Method
        /// </summary>
        /// <param name="word"></param>
        /// <param name="SecWord"></param>
        public static void PermutationRecursive(string word , string SecWord)
        {
            if (word.Length == 0)
            {
                Console.WriteLine(SecWord + " ");
                return;
            }
            for (int i = 0; i < word.Length; i++ )
            {
                char c = word[i];
                string leftside = word.Substring(0, i);
                string rightside = word.Substring(i + 1);
                string output = leftside + rightside;
                PermutationRecursive(output, SecWord + c);

            }

        }
        /// <summary>
        /// Interative Method Swaping
        /// </summary>
        /// <param name="word"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void PermutationInterative(string word, int left, int right)
        {
            if (left == right)
                Console.WriteLine(word);
            else
            {
                for (int i = left; i <= right; i++)
                {
                    word = Swap(word, left, i);
                    PermutationInterative(word, left + 1, right);
                    word = Swap(word, left, i);
                }
            }
        }

        private static string Swap(string word, int left, int i)
        {
            throw new NotImplementedException();
        }

       
    }
}
