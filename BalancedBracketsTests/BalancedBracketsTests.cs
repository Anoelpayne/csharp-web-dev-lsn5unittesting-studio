using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void BalancedBracketsGivenclosedBracketsShouldReturntrue()
        {
            string booCheck = "Hello [world] !";            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);            bool expected = true;


            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void BalancedBracketsGivenOpenBracketsShouldReturntrue()
        {
            string booCheck = "Hello [world !";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = false;


            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void BalanceBracket_ShouldReturnTrue_IfBracketsInsideBrackets()        {            string booCheck = "Hi[![Hello]]";            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);            bool expected = true;            Assert.AreEqual(Actual, expected);        }

        [TestMethod]
        public void BalanceBracketGivenTextInsideAndOutsideBracketsShouldReturnTrue()
        {
            string testString = "Launch[Code]";
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(testString));

        }
        [TestMethod]
        public void BalanceBracket_ShouldReturnTrue_IfTextOnlyInsideBrackets()        {            string booCheck = "[Hello!]";            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);            bool expected = true;            Assert.AreEqual(Actual, expected);        }
        [TestMethod]        public void BalanceBracket_ShouldReturnTrue_IfEmptyString()        {            string booCheck = "";            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);            bool expected = true;            Assert.AreEqual(Actual, expected);        }

        [TestMethod]
        public void BalanceBracketGivenTextWithOneOpenBracketShouldReturnFalse()
        {
            string testString = "[LaunchCode";
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(testString));

        }

        [TestMethod]
        public void BalanceBracketGivenTextWithReversedBracketsShouldReturnFalse()
        {
            string testString = "Launch]Code[";
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(testString));

        }

        [TestMethod]        public void BalanceBracket_ShouldReturnFalse_IfOnlyOpeningBracket()        {            string booCheck = "[";            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);            bool expected = false;            Assert.AreEqual(Actual, expected);        }        [TestMethod]        public void BalanceBracket_ShouldReturnFalse_IfOppositeDirections()        {            string booCheck = " ] [ ";            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);            bool expected = false;            Assert.AreEqual(Actual, expected);        }



    }
}
