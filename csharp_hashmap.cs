using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        Dictionary<string,string> hm = new Dictionary<string,string>();
    
        // Adding items (Notice the Capital 'A')
        hm.Add("India", "New Delhi");
        hm.Add("USA", "Washington D.C.");
        hm.Add("UK", "London");

        // Accessing a value using its key
        Console.WriteLine(hm["India"]); // Output: New Delhi
    }
}