using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FitnessProject.Components
{
    public partial class CtrlClientsOnline : UserControl
    {
        public CtrlClientsOnline()
        {
            InitializeComponent();

            LoadData();
        }

        #region LoadData

        public void LoadData()
        {
            ArrayList al = DBLayer.Visits.GetListOnline();

            DataTable dt = new DataTable();

            dt.Columns.Add("ClientID", typeof(int));
            dt.Columns.Add("FIO");
            dt.Columns.Add("Time");
            dt.Columns.Add("Card");
            dt.Columns.Add("AbonementName");
            dt.Columns.Add("BoxType");
            dt.Columns.Add("Number", typeof(int));
            dt.Columns.Add("Coach");

            for (int i = 0; i < al.Count; i++)
            {
                DataRow dr = dt.Rows.Add();

                DBLayer.Visits.Visits_WideDetails det = (DBLayer.Visits.Visits_WideDetails)al[i];

                dr["ClientID"] = det.ClientId;
                dr["FIO"] = det.ClientName;
                dr["Time"] = det.Time;

                if (det.WithoutKey)
                    dr["Card"] = "Без карты";
                dr["Number"] = det.Number.ToString();

                dr["AbonementName"] = det.AbonementName;
                dr["BoxType"] = det.BoxType;

                dr["Coach"] = det.CoachName;

            }

            grClients.DataSource = dt;

            slblTotal.Text = al.Count.ToString();

            advBandedGridView1.BestFitColumns();
        }

        #endregion

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                //advBandedGridView1.ExportToExcel(sfdExcel.FileName);
            }
        }

        private void tbtnView_Click(object sender, EventArgs e)
        {
            int[] i;
            int SelRow = -1;
            i = advBandedGridView1.GetSelectedRows();
            SelRow = i[0];

            int ind = 0;

            try
            {
                ind = Convert.ToInt32(advBandedGridView1.GetRowCellValue(SelRow, "ClientID"));
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, Lib.StringConstants.ProjectName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                    
            ServiceForms.FrmViewClient frm = new FitnessProject.ServiceForms.FrmViewClient(DBLayer.Clients.GetDetails(ind));
            frm.ShowDialog();
        }
    }
}
