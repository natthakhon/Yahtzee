using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeModel
{
    /// <summary>
    /// scordcard item with category name and score according to dice roll
    /// </summary>
    public class ScoreCardItem
    {
        private Category category;
        private int score = 0;

        public ScoreCardItem(Category category)
        {
            this.category = category;
        }

        public string CategoryName => this.category.Name;

        public int Score => this.score;

        public void GetScore(string roll)
        {
            this.score = this.category.GetScore(roll);
        }
    }
}
