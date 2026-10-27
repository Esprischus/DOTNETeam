/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 27/10/2026
 * Time: 08:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace prueba
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblp = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblp
			// 
			this.lblp.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblp.Location = new System.Drawing.Point(68, 13);
			this.lblp.Name = "lblp";
			this.lblp.Size = new System.Drawing.Size(100, 23);
			this.lblp.TabIndex = 0;
			this.lblp.Text = "prueba";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblp);
			this.Name = "MainForm";
			this.Text = "prueba";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblp;
	}
}
