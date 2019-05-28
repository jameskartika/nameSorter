using System;
using System.IO;
using System.Collections.Generic;

namespace name_sorter
{
    //name_sorter program is used to read a txt file,
    //sort the names in the file,
    //then print it out console and output it in sorted-names-list.txt
    class Program
    {
        static void Main(string[] args)
        {
            //checks if there is a valid path
            if(args.Length ==0)
            {
                ConsoleIO.invalidArgument();
                return;
            }


            //initialize reader and writer
            FileReader fileReader = new FileReader(args[0]);
            FileWriter fileWriter = new FileWriter("./sorted-names-list.txt");

            //read the names and move it to a string list
            List<string> strList = fileReader.Read();

            //convert string list to Name list
            List<Name> nameList = ListConverter.StringToName(strList);
            
            //Sort Names in nameList
            List<Name> sortedNames = ListSorter.NameSort(nameList);

            //write name to output txt file
            fileWriter.WriteNames(sortedNames);

            //print names on the Console
            Console.Write(ConsoleIO.PrintNames(sortedNames));

            //close reader and writer
            fileReader.stopReading();
            fileWriter.stopWriting();

        }
    }
}
