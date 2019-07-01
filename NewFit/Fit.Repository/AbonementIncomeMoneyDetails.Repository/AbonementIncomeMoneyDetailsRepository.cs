using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    class AbonementIncomeMoneyDetailsRepository : IAbonementIncomeMoneyDetailsRepository
    {
        public List<AbonementIncomeMoneyDetails> MoneyReportByDayCharges(int month, int year)
        {
            string sql = "SELECT SUM(Summ) AS Charges, Date FROM Cash ";
            sql += " WHERE Month(Date) = " + month.ToString() + " AND Year(Date) = " + year.ToString() + " AND Summ < 0 ";
            sql += " GROUP BY Date ";
            sql += " ORDER BY Date";

            DataTable dt = ZFort.DB.Execute.ExecuteString_DataTable(sql);

            List<AbonementIncomeMoneyDetails> list = new List<AbonementIncomeMoneyDetails>();

            foreach (DataRow dr in dt.Rows)
            {
                AbonementIncomeMoneyDetails det = new AbonementIncomeMoneyDetails();

                if (!dr.IsNull("Date"))
                    det.Date = Convert.ToDateTime(dr["Date"]);

                if (!dr.IsNull("Charges"))
                    det.Value = Convert.ToDouble(dr["Charges"]);
                else
                    det.Value = 0;

                list.Add(det);
            }

            return list;
        }

        public static List<AbonementIncomeMoneyDetails> MoneyReportByDayIncomes(int month, int year)
        {
            string sql = "SELECT SUM(Summ) AS Incomes, Date FROM Cash ";
            sql += " WHERE Month(Date) = " + month.ToString() + " AND Year(Date) = " + year.ToString() + " AND Summ >= 0 ";
            sql += " GROUP BY Date ";
            sql += " ORDER BY Date";

            DataTable dt = ZFort.DB.Execute.ExecuteString_DataTable(sql);

            List<AbonementIncomeMoneyDetails> list = new List<AbonementIncomeMoneyDetails>();

            foreach (DataRow dr in dt.Rows)
            {
                AbonementIncomeMoneyDetails det = new AbonementIncomeMoneyDetails();

                if (!dr.IsNull("Date"))
                    det.Date = Convert.ToDateTime(dr["Date"]);

                if (!dr.IsNull("Incomes"))
                    det.Value = Convert.ToDouble(dr["Incomes"]);
                else
                    det.Value = 0;

                list.Add(det);
            }

            return list;
        }
    }
}
