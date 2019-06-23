using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FitnessProject.ServiceForms
{
	/// <summary>
	/// Summary description for FrmCalendar.
	/// </summary>
	public class FrmCalendar : System.Windows.Forms.Form
	{
		#region Controls

		private System.Windows.Forms.MonthCalendar mcCalendar;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		/// 

		private System.ComponentModel.Container components = null;

		#endregion

		#region Properties

		#region SelectedDate

		public DateTime SelectedDate
		{
			get {return mcCalendar.SelectionStart;}
		}

		#endregion

		#endregion

		#region Constructor

		public FrmCalendar()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			/*this.Height = mcCalendar.Height + 2;
			this.Width = mcCalendar.Width + 15;*/

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		#endregion

		#region Dispose

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmCalendar));
			this.mcCalendar = new System.Windows.Forms.MonthCalendar();
			this.SuspendLayout();
			// 
			// mcCalendar
			// 
			this.mcCalendar.Location = new System.Drawing.Point(0, 0);
			this.mcCalendar.Name = "mcCalendar";
			this.mcCalendar.TabIndex = 0;
			this.mcCalendar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mcCalendar_KeyDown);
			this.mcCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcCalendar_DateSelected);
			// 
			// FrmCalendar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(192, 152);
			this.Controls.Add(this.mcCalendar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmCalendar";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.FrmCalendar_Load);
			this.ResumeLayout(false);

		}
		#endregion

		#region Date Select Event

		public delegate void SelectDateEventHandler(object sender, DateSelectEventArgs args);

		public event SelectDateEventHandler SelectDateMsg;

		protected virtual void OnSelectDate(DateSelectEventArgs e)
		{
			if (SelectDateMsg != null)
			{
				SelectDateMsg(this, e);
			}
		}

		public void SimulateSelectDate()
		{
			DateSelectEventArgs e = new DateSelectEventArgs(mcCalendar.SelectionStart);

			OnSelectDate(e);

			this.Close();
		}

		#endregion

		#region Handlers

		#region mcCalendar_DateSelected

		private void mcCalendar_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
			SimulateSelectDate();
		}

		#endregion

		#region FrmCalendar_Load

		private void FrmCalendar_Load(object sender, System.EventArgs e)
		{
			mcCalendar.Focus();
		}

		#endregion

		#region mcCalendar_KeyDown

		private void mcCalendar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				this.Close();
		}

		#endregion

		#endregion

		#region DateSelectEventArgs Class
	
		public class DateSelectEventArgs : EventArgs
		{
			#region Constructor

			public DateSelectEventArgs(DateTime selectedDate)
			{
				this.SelectedDate = selectedDate;
			}

			#endregion

			#region Fields

			public readonly DateTime SelectedDate;

			#endregion 
		}

		#endregion
	}	
}
