using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            // //1
            // for(int i=1;i<256;i++){
            //     Console.WriteLine(i);
            // }
            // //2
            // for(int i=1;i<101;i++){
            //     if((i%5==0||i%3==0)&&(i%15!=0)){
            //         Console.WriteLine(i);
            //     }
            // }
            //3
            for(int i=1;i<101;i++){
                string str = "";
                if(i%5==0||i%3==0){
                    if(i%3==0){
                        str = "Fizz";
                    }
                    if(i%5==0){
                        str = str+"Buzz";
                    }
                    Console.WriteLine(str);
                }
                else{
                    Console.WriteLine(i);
                }
            }

        }
    }
}
