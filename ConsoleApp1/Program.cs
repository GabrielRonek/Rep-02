using System;
 
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args){
           
            int[] a = [-12, 6, -99, 2, 14, -4, 2];
            countAv(a);
        }  
        static void countAv(int[] b){
            float sum = 0;
            for(int a = 0; a < b.Length; a++){
                sum += b[a];
            }
            Console.WriteLine("The average of the given array is: {0}", sum/b.Length);
        
        }
    }
}