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
    public partial class CtrlWomanSingle : UserControl
    {
        public CtrlWomanSingle()
        {
            InitializeComponent();

            ArrayList al = DBLayer.Boxes.GetReserved(1, 0);

            for (int i = 0; i < al.Count; i++)
            {
                switch (Convert.ToInt32(al[i]))
                {
                    case 1:
                        btn1.Enabled = false;
                        break;
                    case 2:
                        btn2.Enabled = false;
                        break;
                    case 3:
                        btn3.Enabled = false;
                        break;
                    case 4:
                        btn4.Enabled = false;
                        break;
                    case 5:
                        btn5.Enabled = false;
                        break;
                    case 6:
                        btn6.Enabled = false;
                        break;
                    case 7:
                        btn7.Enabled = false;
                        break;
                    case 8:
                        btn8.Enabled = false;
                        break;
                    case 9:
                        btn9.Enabled = false;
                        break;
                    case 10:
                        btn10.Enabled = false;
                        break;
                    case 11:
                        btn11.Enabled = false;
                        break;
                    case 12:
                        btn12.Enabled = false;
                        break;
                    case 13:
                        btn13.Enabled = false;
                        break;
                    case 14:
                        btn14.Enabled = false;
                        break;
                    case 15:
                        btn15.Enabled = false;
                        break;
                    case 16:
                        btn16.Enabled = false;
                        break;
                    case 17:
                        btn17.Enabled = false;
                        break;
                    case 18:
                        btn18.Enabled = false;
                        break;
                    case 19:
                        btn19.Enabled = false;
                        break;
                    case 20:
                        btn20.Enabled = false;
                        break;
                    case 21:
                        btn21.Enabled = false;
                        break;
                    case 22:
                        btn22.Enabled = false;
                        break;
                    case 23:
                        btn23.Enabled = false;
                        break;
                    case 24:
                        btn24.Enabled = false;
                        break;
                    case 25:
                        btn25.Enabled = false;
                        break;
                    case 26:
                        btn26.Enabled = false;
                        break;
                    case 27:
                        btn27.Enabled = false;
                        break;
                    case 28:
                        btn28.Enabled = false;
                        break;
                    case 29:
                        btn29.Enabled = false;
                        break;
                    case 30:
                        btn30.Enabled = false;
                        break;
                    case 31:
                        btn31.Enabled = false;
                        break;
                    case 32:
                        btn32.Enabled = false;
                        break;
                    case 33:
                        btn33.Enabled = false;
                        break;
                    case 34:
                        btn34.Enabled = false;
                        break;
                    case 35:
                        btn35.Enabled = false;
                        break;
                    case 36:
                        btn36.Enabled = false;
                        break;
                    case 37:
                        btn37.Enabled = false;
                        break;
                    case 38:
                        btn38.Enabled = false;
                        break;
                    case 39:
                        btn39.Enabled = false;
                        break;
                    case 40:
                        btn40.Enabled = false;
                        break;
                    case 41:
                        btn41.Enabled = false;
                        break;
                    case 42:
                        btn42.Enabled = false;
                        break;
                    case 43:
                        btn43.Enabled = false;
                        break;
                    case 44:
                        btn44.Enabled = false;
                        break;
                    case 45:
                        btn45.Enabled = false;
                        break;
                    case 46:
                        btn46.Enabled = false;
                        break;
                    case 47:
                        btn47.Enabled = false;
                        break;
                    case 48:
                        btn48.Enabled = false;
                        break;
                    case 49:
                        btn49.Enabled = false;
                        break;
                    case 50:
                        btn50.Enabled = false;
                        break;
                    case 51:
                        btn51.Enabled = false;
                        break;
                    case 52:
                        btn52.Enabled = false;
                        break;
                }
            }
        }

        #region Fields

        public int Number = 0;

        #endregion

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Number = 1;

            SimulateSelectBox();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Number = 2;

            SimulateSelectBox();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Number = 3;

            SimulateSelectBox();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Number = 4;

            SimulateSelectBox();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.Number = 5;

            SimulateSelectBox();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.Number = 6;

            SimulateSelectBox();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.Number = 7;

            SimulateSelectBox();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.Number = 8;

            SimulateSelectBox();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.Number = 9;

            SimulateSelectBox();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            this.Number = 10;

            SimulateSelectBox();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            this.Number = 11;

            SimulateSelectBox();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            this.Number = 12;

            SimulateSelectBox();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            this.Number = 13;

            SimulateSelectBox();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            this.Number = 14;

            SimulateSelectBox();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            this.Number = 15;

            SimulateSelectBox();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            this.Number = 16;

            SimulateSelectBox();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            this.Number = 17;

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
            this.Number = 18;

            SimulateSelectBox();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            this.Number = 19;

            SimulateSelectBox();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            this.Number = 20;

            SimulateSelectBox();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            this.Number = 21;

            SimulateSelectBox();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            this.Number = 22;

            SimulateSelectBox();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            this.Number = 23;

            SimulateSelectBox();
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            this.Number = 24;

            SimulateSelectBox();
        }

        private void btn18_Click_1(object sender, EventArgs e)
        {
            this.Number = 18;

            SimulateSelectBox();
        }

        private void btn19_Click_1(object sender, EventArgs e)
        {
            this.Number = 19;

            SimulateSelectBox();
        }

        private void btn20_Click_1(object sender, EventArgs e)
        {
            this.Number = 20;

            SimulateSelectBox();
        }

        private void btn21_Click_1(object sender, EventArgs e)
        {
            this.Number = 21;

            SimulateSelectBox();
        }

        private void btn22_Click_1(object sender, EventArgs e)
        {
            this.Number = 22;

            SimulateSelectBox();
        }

        private void btn23_Click_1(object sender, EventArgs e)
        {
            this.Number = 23;

            SimulateSelectBox();
        }

        private void btn24_Click_1(object sender, EventArgs e)
        {
            this.Number = 24;

            SimulateSelectBox();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            this.Number = 25;

            SimulateSelectBox();
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            this.Number = 26;

            SimulateSelectBox();
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            this.Number = 27;

            SimulateSelectBox();
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            this.Number = 28;

            SimulateSelectBox();
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            this.Number = 29;

            SimulateSelectBox();
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            this.Number = 30;

            SimulateSelectBox();
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            this.Number = 31;

            SimulateSelectBox();
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            this.Number = 32;

            SimulateSelectBox();
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            this.Number = 33;

            SimulateSelectBox();
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            this.Number = 34;

            SimulateSelectBox();
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            this.Number = 35;

            SimulateSelectBox();
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            this.Number = 36;

            SimulateSelectBox();
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            this.Number = 37;

            SimulateSelectBox();
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            this.Number = 38;

            SimulateSelectBox();
        }

        private void btn39_Click(object sender, EventArgs e)
        {
            this.Number = 39;

            SimulateSelectBox();
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            this.Number = 40;

            SimulateSelectBox();
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            this.Number = 41;

            SimulateSelectBox();
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            this.Number = 42;

            SimulateSelectBox();
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            this.Number = 43;

            SimulateSelectBox();
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            this.Number = 44;

            SimulateSelectBox();
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            this.Number = 45;

            SimulateSelectBox();
        }

        private void btn46_Click(object sender, EventArgs e)
        {
            this.Number = 46;

            SimulateSelectBox();
        }

        private void btn47_Click(object sender, EventArgs e)
        {
            this.Number = 47;

            SimulateSelectBox();
        }

        private void btn48_Click(object sender, EventArgs e)
        {
            this.Number = 48;

            SimulateSelectBox();
        }

        private void btn49_Click(object sender, EventArgs e)
        {
            this.Number = 49;

            SimulateSelectBox();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            this.Number = 50;

            SimulateSelectBox();
        }

        private void btn51_Click(object sender, EventArgs e)
        {
            this.Number = 51;

            SimulateSelectBox();
        }

        private void btn52_Click(object sender, EventArgs e)
        {
            this.Number = 52;

            SimulateSelectBox();
        }
    }

    #region BoxWomanSingleSelectEventArgs Class

    public class BoxWomanSingleSelectEventArgs : EventArgs
    {
        #region Constructor

        public BoxWomanSingleSelectEventArgs(int number)
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
