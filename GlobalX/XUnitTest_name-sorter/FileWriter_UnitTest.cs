using System;
using Xunit;
using name_sorter;
using System.Collections.Generic;
namespace name_sorter_UnitTest
{
    //some tests have dependency on FileReader
    public class FileWriter_UnitTest
    {
        [Fact]
        public void Test_write()
        {
            string path = "../../../testFiles/writeTestFile.txt";
            FileWriter fileWriter = new FileWriter(path);

            string testName1 = "Mary Katherine Ham";
            string testName2 = "Poppy Harlow";
            string testName3 = "Gloria Borger";

            List<string> actual = new List<string> { testName1, testName2, testName3 };

            fileWriter.WriteNames(new List<Name> { new Name(testName1), new Name(testName2), new Name(testName3) });
            fileWriter.stopWriting();

            FileReader fileReader = new FileReader(path);
            List<string> strList = fileReader.Read();
            fileReader.stopReading();

            Assert.Equal(strList, actual);

        }
    }
}