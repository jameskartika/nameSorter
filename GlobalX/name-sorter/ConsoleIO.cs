using System;
using System.Collections.Generic;

namespace name_sorter
{
    
    //utility class to manage console input and outputs
    public static class ConsoleIO
    {
        //Takes in a list of Name object, and returns a string of names to print
        public static string PrintNames(List<Name> nameList)
        {
            string output = "";
            foreach(Name name in nameList)
            {
                output += $"{name.ToString()}\n";
            }
            return output;
        }

        //Pause function for Console
        public static void Pause()
        {
            Console.Write("\nPress Any Key to continue");
            Console.ReadKey();
        }

        //Output when invalid argument is passed
        public static void invalidArgument()
        {
            Console.Write("Please Input a valid path to the text file");
            Pause();
        }
    }
}