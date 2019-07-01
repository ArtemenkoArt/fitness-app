using System;
using System.Collections;

namespace NewFit
{
    interface IAbonementIncomeDetailsRepository
    {
        ArrayList GetList(int id, DateTime date1, DateTime date2);
    }
}