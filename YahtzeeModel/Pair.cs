using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YahtzeeModel.CategoryEnum;

namespace YahtzeeModel
{
    public class Pair : NofaKindCategory
    {
        public Pair(CategoryType type):base(type)
        {
            if ((int)this.type != 7)
            {
                throw new ArgumentException("Invalid Category Type");
            }
        }

        protected override int getscore(IEnumerable<dynamic> query)
        {
            var filterpair = query.Where(p => p.count == 2);
            
            if (filterpair.Count() >= 1)
            {
                var maxpair = filterpair.Max(p => p.num);
                return filterpair.Where(p => p.num == maxpair).Sum(p => p.num * p.count);
            }
            return 0;
        }
    }
}
