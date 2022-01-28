using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    public class ThreeOfAKind : NofaKindCategory
    {
        public ThreeOfAKind(CategoryType type) : base(type) 
        {
            if ((int)this.type != 9)
            {
                throw new ArgumentException("Invalid Category Type");
            }
        }

        protected override int getscore(IEnumerable<dynamic> query)
        {
            var filter3 = query.Where(p => p.count == 3);
            if (filter3.Count() == 1)
            {
                return filter3.Sum(p => p.num * p.count);
            }
            return 0; 
        }
    }
}
