using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    public class AbonementIncomeRepository : IAbonementIncomeRepository
    {
        public void Insert(AbonementIncomeData det)
        {
            string sql = "INSERT INTO AbonementIncome (ClientId, AbonementId, UserId, [Date], Summ, IsDeleted, ClientAbonementId) ";
            sql += " VALUES (" + det.ClientId.ToString() + ", " + det.AbonementId.ToString() + ", " + det.UserId.ToString() + ", '" + det.Date.ToString("yyyyMMdd") + "', " + det.Summ.ToString().Replace(",", ".") + ", 0, " + det.ClientAbonementId.ToString() + ")";

            ZFort.DB.Execute.ExecuteString_void(sql);
        }

        public void Update(AbonementIncomeData det)
        {
            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementIncome SET [ClientId] = " + det.ClientId.ToString() + " WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementIncome SET [AbonementId] = " + det.AbonementId.ToString() + " WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementIncome SET [ClientAbonementId] = " + det.ClientAbonementId.ToString() + " WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementIncome SET [UserId] = " + det.UserId.ToString() + " WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementIncome SET [Date] = '" + det.Date.ToString("yyyyMMdd") + "' WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementIncome SET [Summ] = " + det.Summ.ToString().Replace(",", ".") + " WHERE [Id] = " + det.Id.ToString());
        }

        public void Delete(int id)
        {
            ZFort.DB.Execute.ExecuteString_void("DELETE FROM AbonementIncome WHERE [Id] = " + id.ToString());
        }

        public void DeleteByClientAbonement(int id)
        {
            ZFort.DB.Execute.ExecuteString_void("DELETE FROM AbonementIncome WHERE [ClientAbonementId] = " + id.ToString());
        }

        public void SetDelete(AbonementIncomeData det)
        {
            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementIncome SET IsDeleted = 1 WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementIncome SET DeleteDate = '" + det.DeleteDate.ToString("yyyyMMdd") + "' WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementIncome SET DeleteReason = '" + det.DeleteReason + "' WHERE [Id] = " + det.Id.ToString());
        }

        public AbonementIncomeData GetDetails(int id)
        {
            DataRow dr = ZFort.DB.Execute.ExecuteString_DataRow("SELECT Id, Date, Summ, ClientId, ClientAbonementId, AbonementId, UserId, IsDeleted, DeleteDate, DeleteReason FROM AbonementIncome WHERE [Id] = " + id.ToString());

            var dict = dr.Table.Columns.Cast<DataColumn>().ToDictionary(c => c.ColumnName, c => dr[c]);
            AbonementIncomeData det = DataRowObjectCreator.Create<AbonementIncomeData>(dict, new AbonementIncomeData());

            return det;
        }
    }
}
