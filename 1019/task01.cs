using System;

public class task011019
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine().Trim());
        for (int i = 1; i < n + 1; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
