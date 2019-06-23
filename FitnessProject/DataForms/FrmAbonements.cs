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
    public partial class FrmAbonements : Form
    {
        private int Id = 0;
        public ArrayList Abonements = new ArrayList();

        public FrmAbonements(int id)
        {
            InitializeComponent();

            this.Id = id;

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = new ArrayList();

            if (this.Id != 0)
            {
                al = DBLayer.ClientsAbonements.GetList(this.Id);
                Abonements = al;
            }
            else
            {
                al = Abonements;
            }

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("StayCount", typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Coach");
            dt.Columns.Add("Time");
            dt.Columns.Add("Weekdays");
            dt.Columns.Add("DateStart", typeof(DateTime));
            dt.Columns.Add("DateFinish", typeof(DateTime));

            for (int i = 0; i < al.Count; i++)
            {
                DataRow dr = dt.Rows.Add();

                DBLayer.ClientsAbonements.ClientsAbonements_WideDetails det = (DBLayer.ClientsAbonements.ClientsAbonements_WideDetails)al[i];

                dr["Id"] = det.Id;

                if (det.VisitsCount > 0)
                    dr["StayCount"] = det.VisitsCount;

                dr["Name"] = det.Name;
                dr["DateStart"] = det.DateStart;
                dr["DateFinish"] = det.DateFinish;

                dr["Coach"] = det.CoachName;
                dr["Time"] = det.Time;
                dr["Weekdays"] = det.Weekdays;
            }

            grAbonements.DataSource = dt;
            advBandedGridView2.BestFitColumns();


        }

        #endregion
    }


}
