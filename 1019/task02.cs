using System;

public class Hello
{
    public static void Main(string[] args)
    {
        string[] stArrayData = System.Console.ReadLine().Trim().Split(' ');

        int i = int.Parse(stArrayData[0]);
        int j = int.Parse(stArrayData[1]);
        System.Console.WriteLine(i + j);

    }
}
