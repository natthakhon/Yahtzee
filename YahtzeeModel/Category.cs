using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    /// <summary>
    /// mother of all categories
    /// </summary>
    public abstract class Category
    {
        private string roll;

        protected CategoryType type;
        protected List<int> dices;

        public string Name => this.type.ToString();

        protected Category(CategoryType type)
        {
            this.type = type;
        }

        public int GetScore(string roll)
        {
            this.roll = roll;

            var rolls = this.roll.Split(',');

            if (rolls.Length != 5)
            {
                throw new ArgumentException("Five dices only");
            }

            this.dices = Array.ConvertAll(rolls, s => int.Parse(s)).ToList();

            return this.score();
        }

        protected abstract int score();
    }
}
