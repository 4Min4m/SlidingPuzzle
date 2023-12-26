using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace XPuzzle__4x4_
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label L14;
		internal System.Windows.Forms.Label L15;
		internal System.Windows.Forms.Label L4;
		internal System.Windows.Forms.Label L8;
		internal System.Windows.Forms.Label L11;
		internal System.Windows.Forms.LinkLabel LinkLabel2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.Label L2;
		internal System.Windows.Forms.Label L7;
		internal System.Windows.Forms.Label L16;
		internal System.Windows.Forms.ContextMenu ContextMenu1;
		internal System.Windows.Forms.Label L5;
		internal System.Windows.Forms.Label L1;
		internal System.Windows.Forms.Label L6;
		internal System.Windows.Forms.Label L10;
		internal System.Windows.Forms.Label L9;
		internal System.Windows.Forms.Label L3;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.LinkLabel LinkLabel4;
		internal System.Windows.Forms.LinkLabel LinkLabel3;
		internal System.Windows.Forms.Label L12;
		internal System.Windows.Forms.Label L13;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.L14 = new System.Windows.Forms.Label();
            this.L15 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
            this.L8 = new System.Windows.Forms.Label();
            this.L11 = new System.Windows.Forms.Label();
            this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.L2 = new System.Windows.Forms.Label();
            this.L7 = new System.Windows.Forms.Label();
            this.L16 = new System.Windows.Forms.Label();
            this.ContextMenu1 = new System.Windows.Forms.ContextMenu();
            this.L5 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.L6 = new System.Windows.Forms.Label();
            this.L10 = new System.Windows.Forms.Label();
            this.L9 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LinkLabel4 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel3 = new System.Windows.Forms.LinkLabel();
            this.L12 = new System.Windows.Forms.Label();
            this.L13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L14
            // 
            this.L14.BackColor = System.Drawing.Color.Maroon;
            this.L14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L14.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L14, "L14");
            this.L14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L14.Name = "L14";
            this.L14.Click += new System.EventHandler(this.L14_Click);
            // 
            // L15
            // 
            this.L15.BackColor = System.Drawing.Color.Maroon;
            this.L15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L15.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L15, "L15");
            this.L15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L15.Name = "L15";
            this.L15.Click += new System.EventHandler(this.L15_Click);
            // 
            // L4
            // 
            this.L4.BackColor = System.Drawing.Color.Maroon;
            this.L4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L4.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L4, "L4");
            this.L4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L4.Name = "L4";
            this.L4.Click += new System.EventHandler(this.L4_Click);
            // 
            // L8
            // 
            this.L8.BackColor = System.Drawing.Color.Maroon;
            this.L8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L8.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L8, "L8");
            this.L8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L8.Name = "L8";
            this.L8.Click += new System.EventHandler(this.L8_Click);
            // 
            // L11
            // 
            this.L11.BackColor = System.Drawing.Color.Maroon;
            this.L11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L11.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L11, "L11");
            this.L11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L11.Name = "L11";
            this.L11.Click += new System.EventHandler(this.L11_Click);
            // 
            // LinkLabel2
            // 
            this.LinkLabel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LinkLabel2, "LinkLabel2");
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.UseCompatibleTextRendering = true;
            this.LinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.ForeColor = System.Drawing.Color.Maroon;
            this.Label1.Name = "Label1";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LinkLabel1, "LinkLabel1");
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // L2
            // 
            this.L2.BackColor = System.Drawing.Color.Maroon;
            this.L2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L2, "L2");
            this.L2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L2.Name = "L2";
            this.L2.Click += new System.EventHandler(this.L2_Click);
            // 
            // L7
            // 
            this.L7.BackColor = System.Drawing.Color.Maroon;
            this.L7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L7.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L7, "L7");
            this.L7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L7.Name = "L7";
            this.L7.Click += new System.EventHandler(this.L7_Click);
            // 
            // L16
            // 
            this.L16.BackColor = System.Drawing.Color.Black;
            this.L16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L16.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L16, "L16");
            this.L16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L16.Name = "L16";
            this.L16.Click += new System.EventHandler(this.L16_Click);
            // 
            // ContextMenu1
            // 
            this.ContextMenu1.Popup += new System.EventHandler(this.ContextMenu1_Popup);
            // 
            // L5
            // 
            this.L5.BackColor = System.Drawing.Color.Maroon;
            this.L5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L5.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L5, "L5");
            this.L5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L5.Name = "L5";
            this.L5.Click += new System.EventHandler(this.L5_Click);
            // 
            // L1
            // 
            this.L1.BackColor = System.Drawing.Color.Maroon;
            this.L1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L1, "L1");
            this.L1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L1.Name = "L1";
            this.L1.Click += new System.EventHandler(this.L1_Click);
            // 
            // L6
            // 
            this.L6.BackColor = System.Drawing.Color.Maroon;
            this.L6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L6.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L6, "L6");
            this.L6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L6.Name = "L6";
            this.L6.Click += new System.EventHandler(this.L6_Click);
            // 
            // L10
            // 
            this.L10.BackColor = System.Drawing.Color.Maroon;
            this.L10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L10.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L10, "L10");
            this.L10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L10.Name = "L10";
            this.L10.Click += new System.EventHandler(this.L10_Click);
            // 
            // L9
            // 
            this.L9.BackColor = System.Drawing.Color.Maroon;
            this.L9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L9.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L9, "L9");
            this.L9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L9.Name = "L9";
            this.L9.Click += new System.EventHandler(this.L9_Click);
            // 
            // L3
            // 
            this.L3.BackColor = System.Drawing.Color.Maroon;
            this.L3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L3.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L3, "L3");
            this.L3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L3.Name = "L3";
            this.L3.Click += new System.EventHandler(this.L3_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LinkLabel4
            // 
            this.LinkLabel4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LinkLabel4, "LinkLabel4");
            this.LinkLabel4.Name = "LinkLabel4";
            this.LinkLabel4.TabStop = true;
            this.LinkLabel4.UseCompatibleTextRendering = true;
            this.LinkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel4_LinkClicked);
            // 
            // LinkLabel3
            // 
            this.LinkLabel3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LinkLabel3, "LinkLabel3");
            this.LinkLabel3.Name = "LinkLabel3";
            this.LinkLabel3.TabStop = true;
            this.LinkLabel3.UseCompatibleTextRendering = true;
            this.LinkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
            // 
            // L12
            // 
            this.L12.BackColor = System.Drawing.Color.Maroon;
            this.L12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L12.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L12, "L12");
            this.L12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L12.Name = "L12";
            this.L12.Click += new System.EventHandler(this.L12_Click);
            // 
            // L13
            // 
            this.L13.BackColor = System.Drawing.Color.Maroon;
            this.L13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.L13.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.L13, "L13");
            this.L13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.L13.Name = "L13";
            this.L13.Click += new System.EventHandler(this.L13_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ContextMenu = this.ContextMenu1;
            this.ControlBox = false;
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L8);
            this.Controls.Add(this.L11);
            this.Controls.Add(this.LinkLabel2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L7);
            this.Controls.Add(this.L16);
            this.Controls.Add(this.L5);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.L6);
            this.Controls.Add(this.L10);
            this.Controls.Add(this.L9);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.LinkLabel4);
            this.Controls.Add(this.LinkLabel3);
            this.Controls.Add(this.L12);
            this.Controls.Add(this.L13);
            this.Controls.Add(this.L14);
            this.Controls.Add(this.L15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		protected System.Windows.Forms.Label l, n, k;
		int x, y, s, m, h, i, t=0;
		string str;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			NewGame();
		}

		private void NewGame()
		{
			L1.Text = "" ; L1.BackColor = Color.Maroon;									  
			L2.Text = "" ; L2.BackColor = Color.Maroon;
			L3.Text = "" ; L3.BackColor = Color.Maroon;
			L4.Text = "" ; L4.BackColor = Color.Maroon;
			L5.Text = "" ; L5.BackColor = Color.Maroon;
			L6.Text = "" ; L6.BackColor = Color.Maroon;
			L7.Text = "" ; L7.BackColor = Color.Maroon;
			L8.Text = "" ; L8.BackColor = Color.Maroon;
			L9.Text = "" ; L9.BackColor = Color.Maroon;
			L10.Text = "" ; L10.BackColor = Color.Maroon;
			L11.Text = "" ; L11.BackColor = Color.Maroon;
			L12.Text = "" ; L12.BackColor = Color.Maroon;
			L13.Text = "" ; L13.BackColor = Color.Maroon;
			L14.Text = "" ; L14.BackColor = Color.Maroon;
			L15.Text = "" ; L15.BackColor = Color.Maroon;
			L16.Text = "" ; L16.BackColor = Color.Black;
			Timer1.Enabled = false;
			Label1.Text = "00:00:00";

			l = new Label();
			Random r = new Random();
			int j = 1;
			for (i=1; i<=150; i++)
			{
				int v = r.Next(1, 16);
				Selection(v);
				if (l.Text  == "")
				{
					l.Text = j.ToString();
					j = j + 1;
				}
			}
		}

		private void Selection (int y)
		{
			switch (y)
			{
				case 1:		
					l = L1;
					break;
				case 2:	
					l = L2;
					break;
				case 3:		
					l = L3;
					break;
				case 4:		
					l = L4;
					break;
				case 5:		
					l = L5;
					break;
				case 6:		
					l = L6;
					break;
				case 7:		
					l = L7;
					break;
				case 8:		
					l = L8;
					break;
				case 9:	
					l = L9;
					break;
				case 10:
					l = L10;
					break;
				case 11:
					l = L11;
					break;
				case 12:
					l = L12;
					break;
				case 13:
					l = L13;
					break;
				case 14:
					l = L14;
					break;
				case 15:
					l = L15;
					break;
				case 16:
					l = L16;
					break;
			}
		}

		private void Change()
		{
			l.Text = n.Text;
			l.BackColor = n.BackColor;
			n.Text = "";
			n.BackColor = Color.Black;
		}

		private void Clicks()
		{
			if (Timer1.Enabled == false)
			{
				t = 0;
				Timer1.Enabled = true;
			}

			if (x==4|x==8|x==12)
			{
				y = x;
			}
			else 
			{
				y = x + 1;
			}
			Selection(y);
			if (l.Text == "")
			{
				Change();
			}
			else
			{
				if (x==5|x==5|x==13)
				{
					y = x;
				}
				else 
				{
					y = x - 1;
				}
				Selection(y);
				if (l.Text == "")
				{
					Change();
				}
				else
				{
					y = x + 4;
					Selection(y);
					if (l.Text == "")
					{
						Change();
					}
					else
					{
						y = x - 4;
						Selection(y);
						if (l.Text == "")
						{
							Change();
						}
					}
				}
			}

			if (L1.Text == "1" & L2.Text == "2" & L3.Text == "3" & L4.Text == "4" & L5.Text == "5" & L6.Text == "6" & L7.Text == "7" & L8.Text == "8" & L9.Text == "9" & L10.Text == "10" & L11.Text == "11" & L12.Text == "12" & L13.Text == "13" & L14.Text == "14" & L15.Text == "15" & L16.Text == "16")
			{
				Timer1.Enabled = false;
				if (h > 0 & m > 0 & s > 0)
				{
					str = h + " Hours " + m + " Minutes " + s + " Seconds.";
				}
				else
				{
					if (m > 0 & s > 0)
					{
						str = m + " Minutes " + s + " Seconds.";
					}
					else
					{
						if (s > 0)
						{
							str = s + " Seconds.";
						}
					}
				}

				if (MessageBox.Show("YOU WON\n\nTime Taken Is" + str + "\n\nDo You Want Another Game?", "XPuzzle", MessageBoxButtons.YesNo) == DialogResult.Yes )
				{
					NewGame();
				}
				else
				{
					this.Dispose ();
				}
			}
		}


		private void LinkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.Dispose();
		}

		private void LinkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			NewGame();
		}

		private void L1_Click(object sender, System.EventArgs e)
		{
			n = L1;
			x = 1;
			Clicks();
		}

		private void L2_Click(object sender, System.EventArgs e)
		{
			n = L2;
			x = 2;
			Clicks();
		}

		private void L3_Click(object sender, System.EventArgs e)
		{
			n = L3;
			x = 3;
			Clicks();
		}

		private void L4_Click(object sender, System.EventArgs e)
		{
			n = L4;
			x = 4;
			Clicks();
		}

		private void L5_Click(object sender, System.EventArgs e)
		{
			n = L5;
			x = 5;
			Clicks();
		}

		private void L6_Click(object sender, System.EventArgs e)
		{
			n = L6;
			x = 6;
			Clicks();
		}

		private void L7_Click(object sender, System.EventArgs e)
		{
			n = L7;
			x = 7;
			Clicks();
		}

		private void L8_Click(object sender, System.EventArgs e)
		{
			n = L8;
			x = 8;
			Clicks();
		}

		private void L9_Click(object sender, System.EventArgs e)
		{
			n = L9;
			x = 9;
			Clicks();
		}

		private void L10_Click(object sender, System.EventArgs e)
		{
			n = L10;
			x = 10;
			Clicks();
		}

		private void L11_Click(object sender, System.EventArgs e)
		{
			n = L11;
			x = 11;
			Clicks();
		}

		private void L12_Click(object sender, System.EventArgs e)
		{
			n = L12;
			x = 12;
			Clicks();
		}

		private void L13_Click(object sender, System.EventArgs e)
		{
			n = L13;
			x = 13;
			Clicks();
		}

		private void L14_Click(object sender, System.EventArgs e)
		{
			n = L14;
			x = 14;
			Clicks();
		}

		private void L15_Click(object sender, System.EventArgs e)
		{
			n = L15;
			x = 15;
			Clicks();
		}

		private void L16_Click(object sender, System.EventArgs e)
		{
			n = L16;
			x = 16;
			Clicks();
		}

		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			t = t + 1;
			s = t % 60;
			m = t /60;
			h = m / 60;
			m = m % 60;
			Label1.Text =h.ToString().PadLeft(2, '0') + ":" + m.ToString().PadLeft(2, '0') + ":" + s.ToString().PadLeft(2, '0');
		} 

		private void ContextMenu1_Popup(object sender, System.EventArgs e)
		{
			NewGame();
		}

		private void LinkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Panel1.Visible = true;
			form2.Panel2.Visible = false;
			form2.ShowDialog(this);
		}

		private void LinkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Panel2.Visible = true;
			form2.Panel1.Visible = false;
			form2.ShowDialog(this);
		}
	}
}
