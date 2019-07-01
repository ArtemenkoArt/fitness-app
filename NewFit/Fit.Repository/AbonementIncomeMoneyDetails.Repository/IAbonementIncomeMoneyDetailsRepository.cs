using System.Collections.Generic;

namespace NewFit
{
    interface IAbonementIncomeMoneyDetailsRepository
    {
        List<AbonementIncomeMoneyDetails> MoneyReportByDayCharges(int month, int year);
    }
}