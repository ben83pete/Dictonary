using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCollectionsLibrary;

namespace TestGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringDictionary = new StringDictionary();
            stringDictionary.Add(7, "Irene");
            stringDictionary.Add(4, "Sammy");
            stringDictionary.Add(25, "Ben");
            stringDictionary.Add(42, "Seth");
            stringDictionary.Add(97, "Ken");
            stringDictionary.Add(55, "Kellen");
            stringDictionary.Add(3, "Chris");

            Console.WriteLine($"The person with Key # 42 is {stringDictionary.Get(42)}");

            foreach (var Name in stringDictionary.Names())
            {
                Console.WriteLine(Name);

            }
                        
            var strings = new StringList();
            strings.Add("ABC");
            strings.Add("DEF");
            strings.Add("GHI");
            strings.Add("jklm", "nopq", "rstu","vwxyz");
            
            foreach(var str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}