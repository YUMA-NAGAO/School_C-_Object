using System;


public class task02{
    
    public static void Main(){
    int num = int.Parse(System.Console.ReadLine().Trim());
    bool b = Nabeatsu(num);
    if(b) {
        System.Console.WriteLine("アホ");
    }else {
        System.Console.WriteLine("アホじゃない");
    }

    }
    static bool Nabeatsu(int num){
        if (num%3==0){
            return true;
        }else{
            int d=0;
            while (d>0){
                d=num%10;
                if (d==3){
                    return true;
                }
                num/=10;
            }
            return false;

        }
                
    }
}
