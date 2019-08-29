using System;
using System.Collections.Generic;

namespace GenericCollections {
    class Program {
        static void Main(string[] args) {

            //5930    7643    6168    9491    5296    6762    7554    1751    9037    8939    9206    2021

            var list1 = new List<int>();
            list1.Add(5930);
            list1.Add(7643);    
            list1.Add(6168);    
            list1.Add(9491);   
            list1.Add(5296);    
            list1.Add(6762);   
            list1.Add(7554);    
            list1.Add(1751);    
            list1.Add(9037);    
            list1.Add(8939);    
            list1.Add(9206);    
            list1.Add(2021);

            var min = int.MaxValue; //starts with largest  possible integer to guarantee it gets set by the list
            var max = int.MinValue; //starts with smallest possible integer to guarantee it gets set by the list
            foreach(var nbr in list1) {
                if(nbr < min) { min = nbr; }
                if(nbr > max) { max = nbr; }
            }

            Console.WriteLine($"Min is {min} and max is {max}.");


            //short answer
            //list1.Sort();
            //min = list1[0];
            //max = list1[list1.Count - 1];
        }
    }
}
