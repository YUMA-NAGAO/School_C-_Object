using System;


public class Hello{
    
    public static void Main(){
        int[] a = {10,11,12};　
        int[] b = a;
        Console.WriteLine(string.Join(", ", a));
        b[0] = 20; 
        b = new int[2];
        Console.WriteLine(string.Join(", ", a));
        Console.WriteLine(string.Join(", ", b));
        
        // 選択肢１が正しい！！
    }
}
