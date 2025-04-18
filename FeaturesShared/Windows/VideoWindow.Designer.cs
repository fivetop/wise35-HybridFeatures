﻿namespace FeaturesShared.Windows
{
	partial class VideoWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej.NET Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.video1 = new Wisej.Web.Video();
			this.SuspendLayout();
			// 
			// video1
			// 
			this.video1.Dock = Wisej.Web.DockStyle.Fill;
			this.video1.Location = new System.Drawing.Point(0, 0);
			this.video1.Name = "video1";
			this.video1.Size = new System.Drawing.Size(300, 300);
			this.video1.TabIndex = 0;
			this.video1.Volume = 0.5D;
			// 
			// VideoWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.video1);
			this.KeepCentered = true;
			this.KeepOnScreen = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "VideoWindow";
			this.Text = "Video Preview";
			this.WindowState = Wisej.Web.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Video video1;
	}
}