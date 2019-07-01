using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFit
{
    public class AbonementPriceDynamicRepository : IAbonementPriceDynamicRepository
    {
        public List<AbonementPriceDynamicData> GetList(int id)
        {

            string sql = "SELECT Id, AbonementId, Price, DateStart, DateFinish FROM AbonementPriceDynamic WHERE AbonementId = " + id.ToString();

            DataTable dt = ZFort.DB.Execute.ExecuteString_DataTable(sql);

            List<AbonementPriceDynamicData> al = new List<AbonementPriceDynamicData>();

            foreach (DataRow dr in dt.Rows)
            {

                var dict = dr.Table.Columns.Cast<DataColumn>().ToDictionary(c => c.ColumnName, c => dr[c]);
                AbonementPriceDynamicData det = DataRowObjectCreator.Create<AbonementPriceDynamicData>(dict, new AbonementPriceDynamicData());

                al.Add(det);
            }

            return al;
        }

        public void Insert(AbonementPriceDynamicData det)
        {
            string sql = "INSERT INTO AbonementPriceDynamic (AbonementId, Price, [DateStart], [DateFinish]) ";
            sql += " VALUES (" + det.AbonementId.ToString() + ", " + det.Price.ToString().Replace(",", ".") + ", '" + det.DateStart.ToString("yyyyMMdd") + "', '" + det.DateFinish.ToString("yyyyMMdd") + "')";

            ZFort.DB.Execute.ExecuteString_void(sql);
        }

        public void Update(AbonementPriceDynamicData det)
        {
            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementPriceDynamic SET [AbonementId] = " + det.AbonementId.ToString() + " WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementPriceDynamic SET [Price] = " + det.Price.ToString().Replace(",", ".") + " WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementPriceDynamic SET [DateStart] = '" + det.DateStart.ToString("yyyyMMdd") + "' WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE AbonementPriceDynamic SET [DateFinish] = '" + det.DateFinish.ToString("yyyyMMdd") + "' WHERE [Id] = " + det.Id.ToString());
        }

        public void Delete(int id)
        {
            ZFort.DB.Execute.ExecuteString_void("DELETE FROM AbonementPriceDynamic WHERE [Id] = " + id.ToString());
        }

        public AbonementPriceDynamicData GetDetails(int id)
        {
            DataRow dr = ZFort.DB.Execute.ExecuteString_DataRow("SELECT Id, AbonementId, Price, DateStart, DateFinish FROM AbonementPriceDynamic WHERE [Id] = " + id.ToString());

            var dict = dr.Table.Columns.Cast<DataColumn>().ToDictionary(c => c.ColumnName, c => dr[c]);
            AbonementPriceDynamicData det = DataRowObjectCreator.Create<AbonementPriceDynamicData>(dict, new AbonementPriceDynamicData());

            return det;
        }
    }
}
