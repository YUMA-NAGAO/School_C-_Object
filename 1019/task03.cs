using System;

public class Hello
{
    public static void Main(string[] args)
    {
        int max = 1000;
        int n = int.Parse(System.Console.ReadLine().Trim());
        int sum = max - n;

        int monewy500 = 0;
        int monewy100 = 0;
        int monewy50 = 0;
        int monewy10 = 0;
        int monewy5 = 0;
        int monewy1 = 0;


        int m500, m100, m50, m10, m5, m1;

        m500 = sum / 500;
        sum = sum % 500;
        m100 = sum / 100;
        sum = sum % 100;
        m50 = sum / 50;
        sum = sum % 50;
        m10 = sum / 10;
        sum = sum % 10;
        m5 = sum / 5;
        m1 = sum % 5;

        System.Console.WriteLine("500円 {0}枚\n100円 {1}枚\n50円 {2}枚\n10円 {3}枚\n5円 {4}枚\n1円 {5}枚\n", m500, m100, m50, m10, m5, m1);




        // 頭が回ってなさ過ぎて、すごく効率が悪いプログラムを書いている…。


    }
}
