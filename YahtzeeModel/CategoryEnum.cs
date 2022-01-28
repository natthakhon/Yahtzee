using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeModel
{
    /// <summary>
    /// types of all categories
    /// </summary>
    public class CategoryEnum
    {
        public enum CategoryType
        {
            Ace = 1,
            Twos = 2 ,
            Threes = 3,
            Fours = 4,
            Fives = 5,
            Sixes = 6,
            Pairs = 7,
            TwoPairs = 8,
            ThreeOfAKind = 9,
            FourOfAKind = 10,
            SmallStraight = 11,
            LargeStraight = 12,
            FullHouse = 13,
            Chance = 14,
            Yahtzee = 15
        }
    }
}
