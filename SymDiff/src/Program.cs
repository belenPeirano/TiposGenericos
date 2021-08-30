using System.Collections;
using System.Collections.Generic;
using System;

namespace SymDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>(){
                1,2,3
            };
            List<int> list2 = new List<int>(){
                3,4,5
            };
            Console.WriteLine($"La diferencia simétrica entre ambas listas es: [{String.Join(",",SymDiff.Dif(list1,list2))}]");
        }
    }
}
