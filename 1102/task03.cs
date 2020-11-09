using System;


public class task03{
    
    public static void Main(){
        string data=System.Console.ReadLine().Trim();
        double d = Double.Parse(data);
        
        int x = Round(d);
        System.Console.WriteLine(x);
   
                
        }
             
        static int Round(double d){
            int num =(int)d;
            double res=d-num;
            
            if (res>=0.5){
                   res=num+1 ;
            }
            return (int)res;
        }
    
}
