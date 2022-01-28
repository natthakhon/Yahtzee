using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    /// <summary>
    /// another abstract responsible for those categories need to group the dice result and its responding count
    /// </summary>
    public abstract class NofaKindCategory : Category
    {
        public NofaKindCategory(CategoryType type) : base(type) 
        {
            if ((int)this.type == 11 ||
                (int)this.type == 12 ||
                (int)this.type == 14 ||
                (int)this.type < 7)
            {
                throw new ArgumentException("Invalid Category Type");
            }
        }

        protected override int score()
        {
            var query = from q in this.dices
                        group q by q into w
                        select new { num = w.Key, count = w.Count() };

            return this.getscore(query);
        }

        protected abstract int getscore(IEnumerable<dynamic> query);
    }
}
