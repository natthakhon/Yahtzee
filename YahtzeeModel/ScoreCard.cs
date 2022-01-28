using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    /// <summary>
    /// represent the scorscard
    /// </summary>
    public class ScoreCard
    {
        private List<ScoreCardItem> scoreCardItems = new List<ScoreCardItem>();
        
        public ScoreCard()
        {
            this.scoreCardItems.Add(new ScoreCardItem(new UpperSectionCategory(CategoryType.Ace)));
            this.scoreCardItems.Add(new ScoreCardItem(new UpperSectionCategory(CategoryType.Twos)));
            this.scoreCardItems.Add(new ScoreCardItem(new UpperSectionCategory(CategoryType.Threes)));
            this.scoreCardItems.Add(new ScoreCardItem(new UpperSectionCategory(CategoryType.Fours)));
            this.scoreCardItems.Add(new ScoreCardItem(new UpperSectionCategory(CategoryType.Fives)));
            this.scoreCardItems.Add(new ScoreCardItem(new UpperSectionCategory(CategoryType.Sixes)));
            this.scoreCardItems.Add(new ScoreCardItem(new Pair(CategoryType.Pairs)));
            this.scoreCardItems.Add(new ScoreCardItem(new TwoPairs(CategoryType.TwoPairs)));
            this.scoreCardItems.Add(new ScoreCardItem(new ThreeOfAKind(CategoryType.ThreeOfAKind)));
            this.scoreCardItems.Add(new ScoreCardItem(new FourOfAKind(CategoryType.FourOfAKind)));
            this.scoreCardItems.Add(new ScoreCardItem(new SmallStraight(CategoryType.SmallStraight)));
            this.scoreCardItems.Add(new ScoreCardItem(new LargeStraight(CategoryType.LargeStraight)));
            this.scoreCardItems.Add(new ScoreCardItem(new FullHouse(CategoryType.FullHouse)));
            this.scoreCardItems.Add(new ScoreCardItem(new Chance(CategoryType.Chance)));
            this.scoreCardItems.Add(new ScoreCardItem(new Yahtzee(CategoryType.Yahtzee)));
        }

        public List<ScoreCardItem> Items => this.scoreCardItems;

        public void UpdateCard(string roll)
        {
            foreach(var item in this.scoreCardItems)
            {
                item.GetScore(roll);
            }
        }
    }
}
