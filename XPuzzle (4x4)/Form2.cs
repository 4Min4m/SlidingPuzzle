using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace XPuzzle__4x4_
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
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
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Panel2
			// 
			this.Panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.Label9,
																				 this.Label8,
																				 this.Label7,
																				 this.Label12,
																				 this.Label13,
																				 this.Label14});
			this.Panel2.Location = new System.Drawing.Point(22, 69);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(296, 328);
			this.Panel2.TabIndex = 51;
			this.Panel2.Visible = false;
			// 
			// Label9
			// 
			this.Label9.BackColor = System.Drawing.Color.LightCoral;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label9.ForeColor = System.Drawing.Color.Maroon;
			this.Label9.Location = new System.Drawing.Point(16, 274);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(224, 24);
			this.Label9.TabIndex = 44;
			this.Label9.Text = "http://www.ninethsense.com";
			// 
			// Label8
			// 
			this.Label8.BackColor = System.Drawing.Color.LightCoral;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label8.ForeColor = System.Drawing.Color.Maroon;
			this.Label8.Location = new System.Drawing.Point(16, 237);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(224, 24);
			this.Label8.TabIndex = 43;
			this.Label8.Text = "(C) NinethSense 2005";
			// 
			// Label7
			// 
			this.Label7.BackColor = System.Drawing.Color.LightCoral;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label7.ForeColor = System.Drawing.Color.Maroon;
			this.Label7.Location = new System.Drawing.Point(16, 172);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(256, 24);
			this.Label7.TabIndex = 42;
			this.Label7.Text = "Email: digitalmanic@yahoo.co.uk";
			// 
			// Label12
			// 
			this.Label12.BackColor = System.Drawing.Color.LightCoral;
			this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label12.ForeColor = System.Drawing.Color.Maroon;
			this.Label12.Location = new System.Drawing.Point(16, 126);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(248, 24);
			this.Label12.TabIndex = 38;
			this.Label12.Text = "Developed by  :  Ambika Praveen";
			// 
			// Label13
			// 
			this.Label13.BackColor = System.Drawing.Color.LightCoral;
			this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label13.ForeColor = System.Drawing.Color.Maroon;
			this.Label13.Location = new System.Drawing.Point(16, 66);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(152, 24);
			this.Label13.TabIndex = 37;
			this.Label13.Text = "Date : 06 Jan 2006";
			// 
			// Label14
			// 
			this.Label14.BackColor = System.Drawing.Color.LightCoral;
			this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label14.ForeColor = System.Drawing.Color.Maroon;
			this.Label14.Location = new System.Drawing.Point(16, 29);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(96, 24);
			this.Label14.TabIndex = 36;
			this.Label14.Text = "Version 1.0";
			// 
			// LinkLabel1
			// 
			this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.LinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.LinkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LinkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
			this.LinkLabel1.Location = new System.Drawing.Point(282, 406);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new System.Drawing.Size(40, 16);
			this.LinkLabel1.TabIndex = 49;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "Close";
			this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
			// 
			// Panel1
			// 
			this.Panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.Label6,
																				 this.Label5,
																				 this.Label4,
																				 this.Label3,
																				 this.Label1});
			this.Panel1.Location = new System.Drawing.Point(22, 69);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(296, 328);
			this.Panel1.TabIndex = 50;
			this.Panel1.Visible = false;
			// 
			// Label6
			// 
			this.Label6.BackColor = System.Drawing.Color.LightCoral;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label6.ForeColor = System.Drawing.Color.Maroon;
			this.Label6.Location = new System.Drawing.Point(16, 273);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(272, 42);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "To start the timer, click any column on the playing board.";
			// 
			// Label5
			// 
			this.Label5.BackColor = System.Drawing.Color.LightCoral;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label5.ForeColor = System.Drawing.Color.Maroon;
			this.Label5.Location = new System.Drawing.Point(16, 220);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(272, 45);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "To start a new game click the New Game link or Right Click on the Mouse.";
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.Color.LightCoral;
			this.Label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label4.ForeColor = System.Drawing.Color.Maroon;
			this.Label4.Location = new System.Drawing.Point(16, 176);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(200, 26);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "To Play Xpuzzle (4x4)";
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.Color.LightCoral;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.ForeColor = System.Drawing.Color.Maroon;
			this.Label3.Location = new System.Drawing.Point(16, 52);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(276, 108);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "Xpuzzle(4x4) is a puzzle game which has 4x4 order containing 16 columns. The obje" +
				"ctive of XPuzzle(4x4)  is to arrange the numbers(0-15) from left to right in the" +
				" natural order as quickly as possible.";
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.Color.LightCoral;
			this.Label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.ForeColor = System.Drawing.Color.Maroon;
			this.Label1.Location = new System.Drawing.Point(16, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(232, 24);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "XPuzzle (4x4) Overview";
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightCoral;
			this.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(340, 450);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Panel2,
																		  this.LinkLabel1,
																		  this.Panel1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Panel2.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void LinkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.Dispose();
		}
	}
}
