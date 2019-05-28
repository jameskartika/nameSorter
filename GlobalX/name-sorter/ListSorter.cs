using System;
using System.Collections.Generic;
using System.Linq;

namespace name_sorter
{
    //sorts list of given type
    public static class ListSorter
    {

        //sorts list of Name objects ascending using LINQ.
        public static List<Name> NameSort(List<Name> unsortedNameList)
        {
            List<Name> sortedNameList = unsortedNameList
                                     .OrderBy(x => x.GetSortableName())
                                     .ToList();

            return sortedNameList;
        }
    }
}