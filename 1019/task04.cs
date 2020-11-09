using System;

public class task041019
{
    public static void Main(string[] args)
    {
        string line = Console.ReadLine().Trim();

        // 3の倍数かの判定
        int n = int.Parse(line);
        bool multi3 = !(0 < n % 3);

        // 文字の中に3が入っているかの判定
        bool hell = false;

        for (int i = 0; i < line.Length; i++)
        {
            // string moji = line[i].ToString();
            char moji =line[i];
            if (moji == '3')
            {
                hell = true;
            }
        }

        if (hell || multi3)
        {
            Console.WriteLine("{0}は、アホ", n);

        }
        else
        {
            Console.WriteLine("{0}は、アホではない", n);
        }

    }
}
