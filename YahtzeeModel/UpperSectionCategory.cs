using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    public class UpperSectionCategory : Category
    {
        public UpperSectionCategory(CategoryType type) : base(type) 
        {
            if ((int)this.type > 6)
            {
                throw new ArgumentException("Invalid Category Type");
            }
        }

        protected override int score()
        {
            return this.dices.Where(p => p == (int)this.type).Sum();
        }
    }
}
