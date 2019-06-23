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
    public partial class CtrlWomanDouble : UserControl
    {
        public CtrlWomanDouble()
        {
            InitializeComponent();

            ArrayList al = DBLayer.Boxes.GetReserved(2, 0);

            for (int i = 0; i < al.Count; i++)
            {
                switch (Convert.ToInt32(al[i]))
                {
                    case 18:
                        btn1.Enabled = false;
                        break;
                    case 19:
                        btn2.Enabled = false;
                        break;
                    case 20:
                        btn3.Enabled = false;
                        break;
                    case 21:
                        btn4.Enabled = false;
                        break;
                    case 22:
                        btn5.Enabled = false;
                        break;
                    case 23:
                        btn6.Enabled = false;
                        break;
                    case 24:
                        btn7.Enabled = false;
                        break;
                    case 25:
                        btn8.Enabled = false;
                        break;
                    case 26:
                        btn9.Enabled = false;
                        break;
                    case 27:
                        btn10.Enabled = false;
                        break;
                    case 28:
                        btn11.Enabled = false;
                        break;
                    case 29:
                        btn12.Enabled = false;
                        break;
                    case 30:
                        btn13.Enabled = false;
                        break;
                    case 31:
                        btn14.Enabled = false;
                        break;
                    case 32:
                        btn15.Enabled = false;
                        break;
                    case 33:
                        btn16.Enabled = false;
                        break;
                    case 34:
                        btn17.Enabled = false;
                        break;
                    case 35:
                        btn18.Enabled = false;
                        break;
                    case 36:
                        btn19.Enabled = false;
                        break;
                    case 37:
                        btn20.Enabled = false;
                        break;
                    case 38:
                        btn21.Enabled = false;
                        break;
                    case 39:
                        btn22.Enabled = false;
                        break;
                    case 40:
                        btn23.Enabled = false;
                        break;
                    case 41:
                        btn24.Enabled = false;
                        break;
                }
            }
        }

        #region Fields

        public int Number = 0;

        #endregion

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Number = 18;

            SimulateSelectBox();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Number = 19;

            SimulateSelectBox();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Number = 20;

            SimulateSelectBox();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Number = 21;

            SimulateSelectBox();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.Number = 22;

            SimulateSelectBox();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.Number = 23;

            SimulateSelectBox();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.Number = 24;

            SimulateSelectBox();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.Number = 25;

            SimulateSelectBox();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.Number = 26;

            SimulateSelectBox();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            this.Number = 27;

            SimulateSelectBox();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            this.Number = 28;

            SimulateSelectBox();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            this.Number = 29;

            SimulateSelectBox();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            this.Number = 30;

            SimulateSelectBox();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            this.Number = 31;

            SimulateSelectBox();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            this.Number = 32;

            SimulateSelectBox();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            this.Number = 33;

            SimulateSelectBox();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            this.Number = 34;

            SimulateSelectBox();
        }

        #region Box Select Event

        public delegate void SelectBoxHandler(object sender, BoxWomanSingleSelectEventArgs args);

        public event SelectBoxHandler SelectBoxMsg;

        protected virtual void OnSelectBox(BoxWomanSingleSelectEventArgs e)
        {
            if (SelectBoxMsg != null)
            {
                SelectBoxMsg(this, e);
            }
        }

        public void SimulateSelectBox()
        {
            BoxWomanSingleSelectEventArgs e = new BoxWomanSingleSelectEventArgs(this.Number);

            OnSelectBox(e);
        }

        #endregion

        private void btn18_Click(object sender, EventArgs e)
        {
            this.Number = 35;

            SimulateSelectBox();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            this.Number = 36;

            SimulateSelectBox();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            this.Number = 37;

            SimulateSelectBox();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            this.Number = 38;

            SimulateSelectBox();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            this.Number = 39;

            SimulateSelectBox();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            this.Number = 40;

            SimulateSelectBox();
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            this.Number = 41;

            SimulateSelectBox();
        }
    }

    #region BoxWomanDoubleSelectEventArgs Class

    public class BoxWomanDoubleSelectEventArgs : EventArgs
    {
        #region Constructor

        public BoxWomanDoubleSelectEventArgs(int number)
        {
            this.Number = number;
        }

        #endregion

        #region Fields

        public readonly int Number;

        #endregion
    }

    #endregion
}
