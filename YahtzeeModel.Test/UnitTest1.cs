using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel.Test
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void TestUpperSectionCategoryScore()
        {
            UpperSectionCategory ace = new UpperSectionCategory(CategoryType.Ace);
            Assert.AreEqual(ace.GetScore("1,2,2,2,5"), 1); // one ace
            Assert.AreEqual(ace.GetScore("1,2,1,2,1"), 3); // miltiple aces
            Assert.AreEqual(ace.GetScore("2,3,4,5,6"), 0); // no ace
        }

        [TestMethod]
        public void TestPair()
        {
            Pair pair = new Pair(CategoryType.Pairs);
            Assert.AreEqual(pair.GetScore("3,3,3,4,4"), 8);
            Assert.AreEqual(pair.GetScore("1,1,6,2,6"), 12);
            Assert.AreEqual(pair.GetScore("1,1,5,2,6"), 2);
            Assert.AreEqual(pair.GetScore("1,3,5,2,6"), 0);
        }

        [TestMethod]
        public void TestTwoPairs()
        {
            TwoPairs twoPairs = new TwoPairs(CategoryType.TwoPairs);
            Assert.AreEqual(twoPairs.GetScore("1,1,2,3,3"), 8);   // this is twopairs
            Assert.AreEqual(twoPairs.GetScore("1,1,2,4,3"), 2); // this is pair
        }

        [TestMethod]
        public void TestThreeOfAKind()
        {
            ThreeOfAKind three = new ThreeOfAKind(CategoryType.ThreeOfAKind);
            Assert.AreEqual(three.GetScore("3,3,3,4,5"), 9);
            Assert.AreEqual(three.GetScore("3,3,2,4,5"), 0);
        }

        [TestMethod]
        public void TestFourOfAKind()
        {
            FourOfAKind four = new FourOfAKind(CategoryType.FourOfAKind);
            Assert.AreEqual(four.GetScore("2,2,2,2,5"), 8);
        }

        [TestMethod]
        public void TestYahtzee()
        {
            Yahtzee yahtzee = new Yahtzee(CategoryType.Yahtzee);
            Assert.AreEqual(yahtzee.GetScore("1,1,1,1,1"), 50);
            Assert.AreEqual(yahtzee.GetScore("1,1,1,2,1"), 0);
        }

        [TestMethod]
        public void TestFullHouse()
        {
            FullHouse fullHouse = new FullHouse(CategoryType.FullHouse);
            Assert.AreEqual(fullHouse.GetScore("1,1,2,2,2"), 8);
            Assert.AreEqual(fullHouse.GetScore("1,3,2,2,2"), 0);
        }

        [TestMethod]
        public void TestChance()
        {
            Chance chance = new Chance(CategoryType.Chance);
            Assert.AreEqual(chance.GetScore("1,1,3,3,6"), 14);
            Assert.AreEqual(chance.GetScore("4,5,5,6,1"), 21);
        }

        [TestMethod]
        public void TestSmallStraight()
        {
            SmallStraight smallStraight = new SmallStraight(CategoryType.SmallStraight);
            Assert.AreEqual(smallStraight.GetScore("1,3,4,5,2"), 15);
            Assert.AreEqual(smallStraight.GetScore("4,2,3,6,1"), 0);
        }

        [TestMethod]
        public void TestLargeStraight()
        {
            LargeStraight largeStraight = new LargeStraight(CategoryType.LargeStraight);
            Assert.AreEqual(largeStraight.GetScore("6,3,4,5,2"), 20);
            Assert.AreEqual(largeStraight.GetScore("4,2,3,6,1"), 0);
        }
    }
}
