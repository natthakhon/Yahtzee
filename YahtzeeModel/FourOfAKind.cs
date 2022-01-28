using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    public class FourOfAKind : NofaKindCategory
    {
        public FourOfAKind(CategoryType type) : base(type)
        {
            if ((int)this.type != 10)
            {
                throw new ArgumentException("Invalid Category Type");
            }
        }

        protected override int getscore(IEnumerable<dynamic> query)
        {
            var filter4 = query.Where(p => p.count == 4);
            if (filter4.Count() == 1)
            {
                return filter4.Sum(p => p.num * p.count);
            }
            return 0;
        }
    }
}
