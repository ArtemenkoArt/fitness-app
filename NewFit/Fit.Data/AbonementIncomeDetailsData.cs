using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    class AbonementIncomeDetailsData
    {
        public int Id { get; protected set; } = 0;
        public int ClientId { get; protected set; } = 0;
        public int AbonementId { get; protected set; } = 0;
        public int UserId { get; protected set; } = 0;
        public DateTime Date { get; protected set; } = DateTime.MinValue;
        public double Summ { get; protected set; } = 0;
        public string AbonementName { get; protected set; } = "";
        public string FIO { get; protected set; } = "";
        public string User { get; protected set; } = "";
        public bool IsDeleted { get; protected set; } = false;
        public DateTime DeleteDate { get; protected set; } = DateTime.MinValue;
        public string DeleteReason { get; protected set; } = "";
        public string CoachName { get; protected set; } = "";
        public string Weekday { get; protected set; } = "";
        public string Time { get; protected set; } = "";
        public int AbonementGroup { get; protected set; } = 0;
        public int ClientAbonementId { get; protected set; } = 0;
    }
}
