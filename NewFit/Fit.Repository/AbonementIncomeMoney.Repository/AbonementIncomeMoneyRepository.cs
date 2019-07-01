using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    class AbonementIncomeMoneyRepository : IAbonementIncomeMoneyRepository
    {
        public ArrayList MoneyReport(DateTime date1, DateTime date2)
        {
            string sql = "SELECT * FROM Cash as a ";
            sql += " WHERE a.[Date] BETWEEN '" + date1.ToString("yyyyMMdd") + "' AND '" + date2.ToString("yyyyMMdd") + "'";
            sql += " ORDER BY a.[Date]";

            DataTable dt = ZFort.DB.Execute.ExecuteString_DataTable(sql);

            ArrayList al = new ArrayList();

            foreach (DataRow dr in dt.Rows)
            {
                AbonementIncomeMoneyData det = new AbonementIncomeMoneyData();

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

                det.AbonementName = dr["AName"].ToString();

                det.ChargeGroupName = dr["GroupName"].ToString();

                //if (!dr.IsNull("AbonementGroup"))
                //    det.AbonementGroup = Convert.ToInt32(dr["AbonementGroup"]);

                al.Add(det);
            }

            return al;
        }

        public static ArrayList Decline(DateTime date1, DateTime date2)
        {
            string sql = " SELECT * FROM Declines AS a ";
            sql += " WHERE a.[Date] BETWEEN '" + date1.ToString("yyyyMMdd") + "' AND '" + date2.ToString("yyyyMMdd") + "'";

            DataTable dt = ZFort.DB.Execute.ExecuteString_DataTable(sql);

            ArrayList al = new ArrayList();

            foreach (DataRow dr in dt.Rows)
            {
                AbonementIncomeMoneyData det = new AbonementIncomeMoneyData();

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

                if (!dr.IsNull("IsDeleted"))
                    det.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);

                if (!dr.IsNull("DeleteDate"))
                    det.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);

                det.DeleteReason = dr["DeleteReason"].ToString();

                al.Add(det);
            }

            return al;
        }
    }
}
