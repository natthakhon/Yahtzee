using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    public class SmallStraight : Category
    {
        public SmallStraight(CategoryType type) : base(type)
        {
            if ((int)this.type != 11)
            {
                throw new ArgumentException("Invalid Category Type");
            }
        }
        protected override int score()
        {
            this.dices.Sort();

            if (this.dices[0] == 1)
            {
                for(int i = 0; i <= 3; i++)
                {
                    if (this.dices[i+1] != this.dices[i] + 1)
                    {
                        return 0;
                    }
                }
                return 15;
            }
            return 0;
        }
    }
}
