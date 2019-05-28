using System;
using Xunit;
using name_sorter;
using System.Collections.Generic;

public class ListConverter_UnitTest
{
    [Fact]
    public void Test_ConvertStringtoNameList_ReturnsSameResult()
    {

        List<string> strList = new List<string> { "John Johnny Jordan", "Stephanie Stacy Stoolman", "Bobby bonapetit Bones" };
        List<Name> actual = new List<Name> { new Name("John Johnny Jordan"), new Name("Stephanie Stacy Stoolman"), new Name("Bobby bonapetit Bones") };

        List<Name> nameList = ListConverter.StringToName(strList);

        Assert.Equal(nameList, actual);

    }
}
