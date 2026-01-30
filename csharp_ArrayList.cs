using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        List<int> arr = new List<int>();
        arr.Add(1);
        arr.Add(2);
        arr.Add(3);

        foreach(int n in arr){
            Console.WriteLine(n);
        }
    }
}