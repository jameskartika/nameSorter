using System;
using Xunit;
using name_sorter;

namespace name_sorter_UnitTest
{
    public class Name_UnitTest
    {
        
        [Fact]
        public void Test_SingleString_ThrowsException()
        {

            string singleString = "Benjyboi";

            Action actual = () => new Name(singleString);

            Assert.Throws<ArgumentOutOfRangeException>(actual);

        }

        [Fact]
        public void Test_TwoString_ReturnsCorrectResult()
        {

            string twoStrings = "Benedict Cucumberbatch";
            string firstName = "Benedict";
            string lastName = "Cucumberbatch";

            Name actual = new Name(twoStrings);

            Assert.Equal(actual.GetFirstName(), firstName);
            Assert.Equal(actual.GetLastName(), lastName);

        }

        [Fact]
        public void Test_ThreeString_ReturnsCorrectResult()
        {

            string threeStrings = "Benjamin Computer Badge";
            string firstName = "Benjamin Computer";
            string lastName = "Badge";

            Name actual = new Name(threeStrings);

            Assert.Equal(actual.GetFirstName(), firstName);
            Assert.Equal(actual.GetLastName(), lastName);

        }

        [Fact]
        public void Test_FourString_ReturnsCorrectResult()
        {

            string fourStrings = "Been Addict Comet Bad";
            string firstName = "Been Addict Comet";
            string lastName = "Bad";

            Name actual = new Name(fourStrings);

            Assert.Equal(actual.GetFirstName(), firstName);
            Assert.Equal(actual.GetLastName(), lastName);

        }

        [Fact]
        public void Test_SortableName_ReturnsSameResult()
        {

            string unsortedNameOrder = "Butterscotch Crochet Bread";
            string actual = "Bread Butterscotch Crochet";

            Name fullName = new Name(unsortedNameOrder);

            Assert.Equal(fullName.GetSortableName(), actual);

        }

        [Fact]
        public void Test_ToString_ReturnsSameResult()
        {

            string actual = "Beaniebag Cabbage Bag";

            Name fullName = new Name(actual);

            Assert.Equal(fullName.ToString(), actual);

        }
    }
}
