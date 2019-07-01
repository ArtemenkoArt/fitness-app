using System;
using System.Collections;

namespace NewFit
{
    interface IAbonementIncomeMoneyRepository
    {
        ArrayList MoneyReport(DateTime date1, DateTime date2);
    }
}