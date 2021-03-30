using System;
namespace Demo
{
    public class MyApplication
    {
        public static void Main(string[] args)
        {
            int[] list = { 98, 23, 97, 36, 77 };
            Array.Sort(list);
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}