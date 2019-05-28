using System;
using Xunit;
using name_sorter;
using System.Collections.Generic;

public class ConsoleIO_UnitTest
{
    [Fact]
    public void Test_GetPrintStrings_ReturnsCorrectResult()
    {
        List<Name> nameList = new List<Name> { new Name("Christie Cheesy Choi"), new Name("pinky pie pooh"), new Name("zebra zippy zoo") };
        string actual = "Christie Cheesy Choi\npinky pie pooh\nzebra zippy zoo\n";

        string printedStrings = ConsoleIO.PrintNames(nameList);

        Assert.Equal(printedStrings, actual);

    }
}
