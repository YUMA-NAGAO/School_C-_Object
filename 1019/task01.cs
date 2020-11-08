using System;

public class Hello
{
    public static void Main(string[] args)
    {
        int n = int.Parse(System.Console.ReadLine().Trim());
        for (int i = 1; i < n + 1; i++)
        {
            for (int j = 0; j < i; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine("");
        }
    }
}
