using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace FitnessProject.Components
{
    public partial class CtrlBarcodes : UserControl
    {
        public CtrlBarcodes()
        {
            InitializeComponent();

            LoadData();
        }

        #region LoadData

        private void LoadData()
        {
            ArrayList al = DBLayer.Barcodes.GetList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Name");

            for (int i = 0; i < al.Count; i++)
            {
                DataRow dr = dt.Rows.Add();

                DBLayer.Barcodes.Details det = (DBLayer.Barcodes.Details) al[i];

                dr["Name"] = det.Name;
            }

            grBarcodes.DataSource = dt;
        }

        #endregion

        private void tbtnExport_Click(object sender, EventArgs e)
        {
            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                string filename = ofdExcel.FileName;

                this.Cursor = Cursors.WaitCursor;

                string connString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=No;IMEX=1""", filename);

                OleDbConnection conn = new OleDbConnection(connString);

                conn.Open();

                DataTable sheets = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                string sql = "SELECT * FROM [" + sheets.Rows[0]["TABLE_NAME"].ToString() + "]";

                OleDbCommand comm = new OleDbCommand(sql, conn);

                OleDbDataAdapter da = new OleDbDataAdapter(comm);

                DataTable dt = new DataTable();

                da.Fill(dt);

                conn.Close();

                int ind = 1;

                foreach (DataRow dr in dt.Rows)
                {
                    try
                    {
                        DBLayer.Barcodes.Details det = new FitnessProject.DBLayer.Barcodes.Details();

                        det.Name = dr["F1"].ToString();

                        if (!DBLayer.Barcodes.Check(det.Name))
                            DBLayer.Barcodes.Insert(det);
                    }
                    catch
                    {
                        MessageBox.Show(ind.ToString());
                    }
                    ind++;
                }

                LoadData();
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить все номера карточек из базы?", Lib.StringConstants.ProjectName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DBLayer.Barcodes.RemoveAll();
                LoadData();

                MessageBox.Show("База карточек очищена!");
            }
        }
    }
}
