using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    /// <summary>
    /// testdghedtydygrtdfhgtrdhtrdygrtyg
    /// </summary>
    public class Chance : Category
    {
        public Chance(CategoryType type) : base(type)
        {
            if ((int)this.type != 14)
            {
                throw new ArgumentException("Invalid Category Type");
            }
        }

        protected override int score()
        {
            return this.dices.Sum();
        }
    }
}
