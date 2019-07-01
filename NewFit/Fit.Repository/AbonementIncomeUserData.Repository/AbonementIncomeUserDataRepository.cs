using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    public class AbonementIncomeUserDataRepository : IAbonementIncomeUserDataRepository
    {
        public List<AbonementIncomeUserData> UserIncome(DateTime date1, DateTime date2)
        {
            string sql = " SELECT * FROM UserIncome AS ui ";
            sql += " WHERE ui.[Date] BETWEEN '" + date1.ToString("yyyyMMdd") + "' AND '" + date2.ToString("yyyyMMdd") + "'";

            DataTable dt = ZFort.DB.Execute.ExecuteString_DataTable(sql);

            List<AbonementIncomeUserData> al = new List<AbonementIncomeUserData>();

            foreach (DataRow dr in dt.Rows)
            {
                AbonementIncomeUserData det = new AbonementIncomeUserData();

                det.Date = Convert.ToDateTime(dr["Date"]).Date;

                det.DimensionName = dr["DimensionName"].ToString();

                det.Name = dr["Name"].ToString();

                det.Price = Convert.ToDouble(dr["Price"]);

                det.Quantity = Convert.ToInt32(dr["Quantity"]);

                det.Summ = Convert.ToDouble(dr["Summ"]);

                det.Time = dr["Time"].ToString();

                det.UserName = dr["User"].ToString();

                det.Type = Convert.ToInt32(dr["Type"]);

                det.GroupName = dr["Group"].ToString();

                if (!dr.IsNull("ClientSumm"))
                    det.ClientsSumm = Convert.ToDouble(dr["ClientSumm"]);

                if (!dr.IsNull("SalesSumm"))
                    det.SalesSumm = Convert.ToDouble(dr["SalesSumm"]);

                if (!dr.IsNull("ServiceSumm"))
                    det.ServiceSumm = Convert.ToDouble(dr["ServiceSumm"]);

                al.Add(det);
            }

            return al;
        }
    }
}
