using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    public class AbonementIncomeData
    {
        public int Id { get; protected set; } = 0;
        public int ClientId { get; protected set; } = 0;
        public int AbonementId { get; protected set; } = 0;
        public int UserId { get; protected set; } = 0;
        public DateTime Date { get; protected set; } = DateTime.MinValue;
        public double Summ { get; protected set; } = 0;
        public bool IsDeleted { get; protected set; } = false;
        public DateTime DeleteDate { get; protected set; } = DateTime.MinValue;
        public string DeleteReason { get; protected set; } = "";
        public int ClientAbonementId { get; protected set; } = 0;
    }
}
