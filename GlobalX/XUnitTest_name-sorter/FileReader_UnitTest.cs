using System;
using Xunit;
using name_sorter;
using System.Collections.Generic;

namespace name_sorter_UnitTest {
    public class FileReader_UnitTest
    {
        [Fact]
        public void Test_ReadNonExistentFile_ThrowsException()
        {

            string path = "./nonExistentFile.txt";

            Action actual = () => new FileReader(path);

            Assert.Throws<System.IO.FileNotFoundException>(actual);

        }

        [Fact]
        public void Test_ReadExistingFile_ReturnsSameResult()
        {

            string path = "../../../testFiles/readExistingFile.txt";
            FileReader fileReader = new FileReader(path);

            List<string> strList = fileReader.Read();
            List<string> actual = new List<string> { "line 1", "line 2"};

            Assert.Equal(strList, actual);

        }
    }
}