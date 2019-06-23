using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FitnessProject.DataForms
{
    public partial class FrmMovement : Form
    {
        #region Fields

        private int Id = 0;

        #endregion

        public FrmMovement(int id)
        {
            InitializeComponent();

            this.Id = id;

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Products.GetMovementLines(this.Id);

            DataTable dt = new DataTable();

            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Arrived", typeof(int));
            dt.Columns.Add("Dispatched", typeof(int));

            int arrived = 0;
            int sold = 0;

            for (int i = 0; i < al.Count; i++)
            {
                DBLayer.Products.MovementDetails det = (DBLayer.Products.MovementDetails)al[i];

                DataRow dr = dt.Rows.Add();

                if (det.Arrived != 0)
                {
                    dr["Arrived"] = det.Arrived;

                    arrived += det.Arrived;
                }

                if (det.Dispatched != 0)
                {
                    dr["Dispatched"] = det.Dispatched;

                    sold += det.Dispatched;
                }

                if (det.Date != DateTime.MinValue)
                {
                    dr["Date"] = det.Date;
                }
            }

            slblArrived.Text = arrived.ToString();
            slblSold.Text = sold.ToString();

            grClients.DataSource = dt;
            advBandedGridView1.BestFitColumns();

        }

        #endregion

        private void tbtnExcel_Click(object sender, EventArgs e)
        {
            if (sfdExcel.ShowDialog() == DialogResult.OK)
            {
                advBandedGridView1.ExportToXls(sfdExcel.FileName);
            }
        }
    }
}
