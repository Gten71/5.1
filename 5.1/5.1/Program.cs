using System;

namespace _5._1
{
    //средний 5.1 13 заданиен 
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 126, 548, 90, 0, 21, 4, 9, 6 };
            Array.Sort(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}
