﻿using System;
 
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args){
           
            int[] a = [-12, 6, -99, 2, 14, -4, 2];
            wrMaxValArray(a);
        }  
        static void countAvgg(int[] b){
            float sumb = 0;
            for(int a = 0; a < b.Length; a++){
                sumb += b[a];
            }
            Console.WriteLine("The avg of the given array is: {0}", sumb/b.Length);
        
        }
         static void wrMaxValArray(int[] d){
            int max = d[0];
 
            for(int a = 0; a < d.Length; a++){
                if (max <= d[a])
                    max = d[a];
            }
 
            Console.WriteLine(max);
        }
    }
}