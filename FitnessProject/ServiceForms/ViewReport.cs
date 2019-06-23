using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FitnessProject.ServiceForms
{
    public partial class ViewReport : Form
    {
        public ViewReport(int id)
        {
            InitializeComponent();

            DBLayer.Clients.Details det = DBLayer.Clients.GetDetails(id);

            DataSet ds = new DataSet();

            DataTable dt = new DataTable("Appartment");

            dt.Columns.Add("FIO");
            dt.Columns.Add("Document");
            dt.Columns.Add("Source");
            dt.Columns.Add("Type");
            dt.Columns.Add("CurrentAbonement");
            dt.Columns.Add("RegisterDate");
            dt.Columns.Add("DocumentNumber");
            dt.Columns.Add("Photo", Type.GetType("System.Byte[]"));

            DataRow dr = dt.Rows.Add();

            dr["FIO"] = det.FIO;
            dr["Document"] = DBLayer.DocumentType.GetDetails(det.DocumentId).Name + " " + det.DocumentNumber;
            dr["Source"] = DBLayer.AdvertisingSource.GetDetails(det.SourceId).Name;
            dr["Type"] = DBLayer.ClientTypes.GetDetails(det.TypeId).Name;

            dr["RegisterDate"] = det.RegisterDate.ToString("dd-MMM-yyyy");

            dr["CurrentAbonement"] = det.BirthDate.ToString("dd-MMM-yyyy");

            dr["DocumentNumber"] = det.Phone;

            dr["Photo"] = DBLayer.Clients.DownloadPhoto(id);

            ds.Tables.Add(dt);

            /*Reports.Client cl = new FitnessProject.Reports.Client();

            cl.SetDataSource(ds);

            crvReport.ReportSource = cl;

            crvReport.RefreshReport();*/

        }
    }
}
