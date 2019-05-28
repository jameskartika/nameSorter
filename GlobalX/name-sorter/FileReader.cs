using System;
using System.IO;
using System.Collections.Generic;

namespace name_sorter
{
    //class to read txt files into List of strings
    public class FileReader
    {
        //List of each line in the file
        private List<string> strList = new List<string>();
        private StreamReader reader;

        public  FileReader(string fileName)
        {
            reader = new StreamReader(fileName);
        }

        //read names on text file and add them to the list of string
        public List<string> Read()
        {
            string line = null;
            do
            {
                //read next line of text file
                line = reader.ReadLine();
                //only add to list if string is not empty
                if (line != null)
                strList.Add(line);
            //repeat until EOF
            } while (line != null);

            return strList;
        }

        public void stopReading()
        {
            reader.Close();
        }
    }
}
