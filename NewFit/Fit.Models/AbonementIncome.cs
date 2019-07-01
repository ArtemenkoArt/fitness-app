using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    public class AbonementIncome : SortedDictionary<string, AbonementIncomeData>
    {
        private IAbonementIncomeRepository repository = null;

        public AbonementIncome(IAbonementIncomeRepository repository)
        {
            this.repository = new AbonementIncomeRepository();
        }

    }
}
