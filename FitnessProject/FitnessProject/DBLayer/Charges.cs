﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace FitnessProject.DBLayer
{
    public class Charges
    {
        #region Details

        public class Details
        {
            #region Constructor

            public Details() { }

            #endregion

            #region Fields

            public int Id = 0;
            public int GroupId = 0;
            public string Name = "";
            public double Summ = 0;
            public DateTime Date = DateTime.MinValue;
            public int AdminstratorId = 0;

            #endregion
        }

        #endregion

        #region Details

        public class Charges_WideDetails
        {
            #region Constructor

            public Charges_WideDetails() { }

            #endregion

            #region Fields

            public int Id = 0;
            public int GroupId = 0;
            public string Name = "";
            public double Summ = 0;
            public DateTime Date = DateTime.MinValue;

            public string GroupName = "";

            public int AdminstratorId = 0;

            public string FIO = "";

            #endregion
        }

        #endregion

        #region Get List

        public static ArrayList GetList(DateTime date1, DateTime date2)
        {

            string sql = "SELECT c.*, cg.[Name] AS ChargeGroup, a.FIO ";
            sql += " FROM Charges AS c INNER JOIN ChargeGroup AS cg ON c.[GroupId] = cg.[Id] LEFT JOIN Administrators AS a ON c.[AdministratorId] = a.[Id] ";
            sql += " WHERE c.[Date] BETWEEN '" + date1.ToString("yyyyMMdd") + "' AND '" + date2.ToString("yyyyMMdd") + "'";
            sql += " ORDER BY [Date]";

            DataTable dt = ZFort.DB.Execute.ExecuteString_DataTable(sql);

            ArrayList al = new ArrayList();

            foreach (DataRow dr in dt.Rows)
            {
                DBLayer.Charges.Charges_WideDetails det = new DBLayer.Charges.Charges_WideDetails();

                if (!dr.IsNull("Id"))
                    det.Id = Convert.ToInt32(dr["Id"]);

                det.Name = dr["Name"].ToString();

                det.GroupName = dr["ChargeGroup"].ToString();

                if (!dr.IsNull("Summ"))
                    det.Summ = Convert.ToDouble(dr["Summ"]);

                if (!dr.IsNull("Date"))
                    det.Date = Convert.ToDateTime(dr["Date"]);

                if (!dr.IsNull("AdministratorId"))
                    det.AdminstratorId = Convert.ToInt32(dr["AdministratorId"]);

                det.FIO = dr["FIO"].ToString();

                al.Add(det);
            }

            return al;
        }

        #endregion               

        #region Insert

        public static int Insert(DBLayer.Charges.Details det)
        {
            string sql = "INSERT INTO Charges (GroupId, [Name], Summ, [Date], AdministratorId) ";
            sql += " VALUES (" + det.GroupId.ToString() + ", '" + det.Name + "', " + det.Summ.ToString().Replace(",", ".") + ", '" + det.Date.ToString("yyyyMMdd") + "', " + det.AdminstratorId.ToString() + ")";

            ZFort.DB.Execute.ExecuteString_void(sql);

            sql = "SELECT Max(Id) FROM Charges";

            return (int)ZFort.DB.Execute.ExecuteString_Scalar(sql);
        }

        #endregion

        #region Update

        public static void Update(DBLayer.Charges.Details det)
        {
            ZFort.DB.Execute.ExecuteString_void("UPDATE Charges SET [GroupId] = " + det.GroupId.ToString() + " WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE Charges SET [Name] = '" + det.Name + "' WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE Charges SET [Summ] = " + det.Summ.ToString().Replace(",", ".") + " WHERE [Id] = " + det.Id.ToString());

            ZFort.DB.Execute.ExecuteString_void("UPDATE Charges SET [Date] = '" + det.Date.ToString("yyyyMMdd") + "' WHERE [Id] = " + det.Id.ToString());
        }

        #endregion

        #region Delete

        public static void Delete(int id)
        {
            string user = ((DBLayer.Users.Details)AppDomain.CurrentDomain.GetData("User")).FIO;

            DBLayer.Charges.Details cDet = DBLayer.Charges.GetDetails(id);

            DBLayer.DeletingLog.DeletingLog_Details det = new DeletingLog.DeletingLog_Details();

            det.Date = DateTime.Now;
            det.Name = cDet.Name + "(" + cDet.Summ.ToString() + ")";
            det.Type = 1;
            det.User = user;

            DBLayer.DeletingLog.Insert(det);

            ZFort.DB.Execute.ExecuteString_void("DELETE FROM Charges WHERE [Id] = " + id.ToString());
        }

        #endregion

        #region GetDetails by Id

        public static DBLayer.Charges.Details GetDetails(int id)
        {
            DataRow dr = ZFort.DB.Execute.ExecuteString_DataRow("SELECT * FROM Charges WHERE [Id] = " + id.ToString());

            DBLayer.Charges.Details det = new Details();

            if (!dr.IsNull("Id"))
                det.Id = Convert.ToInt32(dr["Id"]);

            det.Name = dr["Name"].ToString();

            if (!dr.IsNull("GroupId"))
                det.GroupId = Convert.ToInt32(dr["GroupId"]);

            if (!dr.IsNull("Summ"))
                det.Summ = Convert.ToDouble(dr["Summ"]);

            if (!dr.IsNull("Date"))
                det.Date = Convert.ToDateTime(dr["Date"]);

            if (!dr.IsNull("AdministratorId"))
                det.AdminstratorId = Convert.ToInt32(dr["AdministratorId"]);

            return det;
        }

        #endregion        
    }
}
