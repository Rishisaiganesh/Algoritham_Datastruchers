using System;

namespace Algoritham_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritham");
            Permutations obj = new Permutations();
            string s = "ABCD";
            Permutations.PermutationRecursive(s, " ");
            Console.WriteLine(" ");
            Permutations.PermutationInterative(s, 0, s.Length - 1);

        }
    }
}
