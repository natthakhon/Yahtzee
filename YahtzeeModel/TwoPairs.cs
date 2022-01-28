using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    public class TwoPairs : NofaKindCategory
    {
        public TwoPairs(CategoryType type) : base(type)
        {
            if ((int)this.type != 8)
            {
                throw new ArgumentException("Invalid Category Type");
            }
        }

        protected override int getscore(IEnumerable<dynamic> query)
        {
            var filterpair = query.Where(p => p.count == 2);

            if (filterpair.Count() >= 1)
            {
                return filterpair.Sum(p => p.num * p.count);
            }
            return 0;
        }
    }
}
