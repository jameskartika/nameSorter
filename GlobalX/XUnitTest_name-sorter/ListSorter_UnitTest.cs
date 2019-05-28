using System;
using Xunit;
using name_sorter;
using System.Collections.Generic;

public class ListSorter_UnitTest
    
{
    [Fact]
    public void Test_SortNameList_ReturnsCorrectResult()
    {
        List<Name> unsortedList = new List<Name> {new Name("zebra zippy zoo"), new Name("pinky pie pooh"), new Name("Christie Cheesy Choi") };
        List<Name> sortedList = new List<Name> { new Name("Christie Cheesy Choi"), new Name("pinky pie pooh"), new Name("zebra zippy zoo") };

        List<Name> methodSortedList = ListSorter.NameSort(unsortedList);

        Assert.Equal(methodSortedList, sortedList);

    }
}
