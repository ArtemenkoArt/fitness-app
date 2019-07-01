using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    class AbonementIncomeDetailsRepository : IAbonementIncomeDetailsRepository
    {
        public ArrayList GetList(int id, DateTime date1, DateTime date2)
        {

            string sql = "SELECT DISTINCT a.AbonementGroup, ai.[Date], ai.[Summ], ai.[Id], c.FIO, a.[Name] AS AbonementName, u.FIO AS [User], ai.ClientId, ai.AbonementId, ai.UserId, ai.IsDeleted, ai.DeleteDate, ai.DeleteReason, co.Name AS CoachName, ca.Time, ca.Weekday ";
            sql += " FROM AbonementIncome AS ai INNER JOIN Clients AS c ON c.[Id] = ai.CLientId ";
            sql += " INNER JOIN Abonements AS a ON a.[Id] = ai.AbonementId ";
            sql += " LEFT JOIN ClientsAbonements AS ca ON ai.ClientAbonementId = ca.Id ";
            sql += " LEFT JOIN Coaches AS co ON co.[Id] = ca.[CoachId] ";
            sql += " INNER JOIN Users AS u ON u.[Id] = ai.[UserId] ";
            sql += " WHERE ai.[Date] BETWEEN '" + date1.ToString("yyyyMMdd") + "' AND '" + date2.ToString("yyyyMMdd") + "'";
            sql += " ORDER BY ai.[Date]";

            DataTable dt = ZFort.DB.Execute.ExecuteString_DataTable(sql);

            ArrayList al = new ArrayList();

            foreach (DataRow dr in dt.Rows)
            {
                AbonementIncomeDetailsData det = new AbonementIncomeDetailsData();

                if (!dr.IsNull("Id"))
                    det.Id = Convert.ToInt32(dr["Id"]);

                det.AbonementName = dr["AbonementName"].ToString();

                det.FIO = dr["FIO"].ToString();

                det.User = dr["User"].ToString();

                if (!dr.IsNull("ClientId"))
                    det.ClientId = Convert.ToInt32(dr["ClientId"]);

                if (!dr.IsNull("AbonementId"))
                    det.AbonementId = Convert.ToInt32(dr["AbonementId"]);

                if (!dr.IsNull("UserId"))
                    det.UserId = Convert.ToInt32(dr["UserId"]);

                if (!dr.IsNull("Date"))
                    det.Date = Convert.ToDateTime(dr["Date"]);

                if (!dr.IsNull("Summ"))
                    det.Summ = Convert.ToDouble(dr["Summ"]);

                if (!dr.IsNull("IsDeleted"))
                    det.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);

                if (!dr.IsNull("DeleteDate"))
                    det.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);

                det.DeleteReason = dr["DeleteReason"].ToString();

                if (!dr.IsNull("AbonementGroup"))
                    det.AbonementGroup = Convert.ToInt32(dr["AbonementGroup"]);

                det.CoachName = dr["CoachName"].ToString();

                det.Weekday = dr["Weekday"].ToString();

                det.Time = dr["Time"].ToString();

                al.Add(det);
            }

            return al;
        }

        public static ArrayList GetFitnessList(int id, DateTime date1, DateTime date2)
        {

            string sql = "SELECT DISTINCT a.AbonementGroup, ai.[Date], ai.[Summ], ai.[Id], c.FIO, a.[Name] AS AbonementName, u.FIO AS [User], ai.ClientId, ai.AbonementId, ai.UserId, ai.IsDeleted, ai.DeleteDate, ai.DeleteReason, co.Name AS CoachName, ca.Time, ca.Weekday ";
            sql += " FROM AbonementIncome AS ai INNER JOIN Clients AS c ON c.[Id] = ai.CLientId ";
            sql += " INNER JOIN Abonements AS a ON a.[Id] = ai.AbonementId ";
            sql += " LEFT JOIN ClientsAbonements AS ca ON ai.ClientAbonementId = ca.Id ";
            sql += " LEFT JOIN Coaches AS co ON co.[Id] = ca.[CoachId] ";
            sql += " INNER JOIN Users AS u ON u.[Id] = ai.[UserId] ";
            sql += " WHERE ai.[Date] BETWEEN '" + date1.ToString("yyyyMMdd") + "' AND '" + date2.ToString("yyyyMMdd") + "' AND a.AbonementGroup = 0 ";
            sql += " ORDER BY ai.[Date]";

            DataTable dt = ZFort.DB.Execute.ExecuteString_DataTable(sql);

            ArrayList al = new ArrayList();

            foreach (DataRow dr in dt.Rows)
            {
                AbonementIncomeDetailsData det = new AbonementIncomeDetailsData();

                if (!dr.IsNull("Id"))
                    det.Id = Convert.ToInt32(dr["Id"]);

                det.AbonementName = dr["AbonementName"].ToString();

                det.FIO = dr["FIO"].ToString();

                det.User = dr["User"].ToString();

                if (!dr.IsNull("ClientId"))
                    det.ClientId = Convert.ToInt32(dr["ClientId"]);

                if (!dr.IsNull("AbonementId"))
                    det.AbonementId = Convert.ToInt32(dr["AbonementId"]);

                if (!dr.IsNull("UserId"))
                    det.UserId = Convert.ToInt32(dr["UserId"]);

                if (!dr.IsNull("Date"))
                    det.Date = Convert.ToDateTime(dr["Date"]);

                if (!dr.IsNull("Summ"))
                    det.Summ = Convert.ToDouble(dr["Summ"]);

                if (!dr.IsNull("IsDeleted"))
                    det.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);

                if (!dr.IsNull("DeleteDate"))
                    det.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);

                det.DeleteReason = dr["DeleteReason"].ToString();

                if (!dr.IsNull("AbonementGroup"))
                    det.AbonementGroup = Convert.ToInt32(dr["AbonementGroup"]);

                det.CoachName = dr["CoachName"].ToString();

                det.Weekday = dr["Weekday"].ToString();

                det.Time = dr["Time"].ToString();

                al.Add(det);
            }

            return al;
        }
    }
}
