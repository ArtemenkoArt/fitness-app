using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    public class AbonementPriceDynamicData
    {
        public int Id { get; protected set; } = 0;
        public int AbonementId { get; protected set; } = 0;

        public double Price { get; protected set; } = 0;
        public DateTime DateStart { get; protected set; } = DateTime.MinValue;
        public DateTime DateFinish { get; protected set; } = DateTime.MinValue;
    }
}
