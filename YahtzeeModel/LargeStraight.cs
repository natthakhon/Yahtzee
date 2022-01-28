using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    public class LargeStraight : Category
    {
        public LargeStraight(CategoryType type) : base(type)
        {
            if ((int)this.type != 12)
            {
                throw new ArgumentException("Invalid Category Type");
            }
        }
        protected override int score()
        {
            this.dices.Sort();

            if (this.dices[0] == 2)
            {
                for (int i = 0; i <= 3; i++)
                {
                    if (this.dices[i + 1] != this.dices[i] + 1)
                    {
                        return 0;
                    }
                }
                return 20;
            }
            return 0;
        }
    }
}
