using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    class AbonementIncomeMoneyData
    {
        public int Type { get; protected set; } = 0;
        public DateTime Date { get; protected set; } = DateTime.MinValue;
        public string Time { get; protected set; } = "";
        public double Summ { get; protected set; } = 0;
        public string UserName { get; protected set; } = "";
        public string Name { get; protected set; } = "";
        public int Quantity { get; protected set; } = 0;
        public double Price { get; protected set; } = 0;
        public string DimensionName { get; protected set; } = "";
        public string GroupName { get; protected set; } = "";
        public bool IsDeleted { get; protected set; } = false;
        public DateTime DeleteDate { get; protected set; } = DateTime.MinValue;
        public string DeleteReason { get; protected set; } = "";
        public string AbonementName { get; protected set; } = "";
        public string ChargeGroupName { get; protected set; } = "";
        public int AbonementGroup { get; protected set; } = 0;
    }
}
