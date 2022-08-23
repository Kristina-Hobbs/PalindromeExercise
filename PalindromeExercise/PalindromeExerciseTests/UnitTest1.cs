using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("applesauce", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();
            //act
            bool actual = tester.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
