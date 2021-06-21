using System;

namespace Algoritham_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritham");
            Console.WriteLine("Press 1 to Permutation");
            Console.WriteLine("press 2 to BinarySearch");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    //Permentation Problem
                    string s = "ABCD";
                    Permutations.PermutationRecursive(s, " ");
                    Console.WriteLine(" ");
                    Permutations.PermutationInterative(s, 0, s.Length - 1);
                    break;
                case 2:
                    //binary search 
                    Console.WriteLine("Hi every One GoodMorning Have a Nice Day" +"Give any Key" );
                    string[] Array = { "Hi", "every", "One", "GoodMorning","Have aNice Day" };
                    string value = Convert.ToString(Console.ReadLine());
                    Binarysearch binary = new Binarysearch();
                    int find = binary.Binary(Array, value);
                    if (find == -1)
                        Console.WriteLine("String Not Found");
                    else
                        Console.WriteLine("string is found" + find);
                    break;
                default:
                    Console.WriteLine("Invalid option Enter valid Option");
                    break;
            }


        }
    }
}
