using System;
using System.IO;
using System.Collections.Generic;

namespace name_sorter
{
    //class to write List into text file.
    public class FileWriter
    {
        private StreamWriter writer;

        //creates path where the file should be located
        public FileWriter(string filePath)
        {
            writer = File.CreateText(filePath);
            //Don't touch, without AutoFlush, somehow nothing is printed
            writer.AutoFlush = true;
        }

        //write names into text file from list of Name object
        public void WriteNames(List<Name> nameList)
        {
            foreach(Name name in nameList)
            {
                writer.WriteLine(name.ToString());
            }
        }

        public void stopWriting()
        {
            writer.Close();
        }
    }
}