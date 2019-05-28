using System;
using System.Collections.Generic;
using System.Linq;

namespace name_sorter
{

    //static class for list type conversion
    public static class ListConverter
    {
        //convert string List to Name List using LINQ
        public static List<Name> StringToName(List<string> strList)
        {
            List<Name> nameList = strList
                .Select(x => new Name(x))
                .ToList();

            return nameList;
        }
    }
}
