using System;
using System.Collections.Generic;

namespace NewFit
{
    public interface IAbonementIncomeUserDataRepository
    {
        List<AbonementIncomeUserData> UserIncome(DateTime date1, DateTime date2);
    }
}