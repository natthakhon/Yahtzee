using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    public class Yahtzee : NofaKindCategory
    {
        public Yahtzee(CategoryType type) : base(type)
        {
            if ((int)this.type != 15)
            {
                throw new ArgumentException("Invalid Category Type");
            }
        }

        protected override int getscore(IEnumerable<dynamic> query)
        {
            var filter5 = query.Where(p => p.count == 5);
            if (filter5.Count() == 1)
            {
                return 50;
            }
            return 0;
        }
    }
}
