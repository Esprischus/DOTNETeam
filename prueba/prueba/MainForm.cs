/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 27/10/2026
 * Time: 08:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace prueba
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Poke2 pok2 = new Poke2();
			pok2.Show();
			this.Hide();
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			MessageBox.Show(" Pokemon tipo electrico \n Nivel: 14 \n Status: 200 HP / 15 DEF ","Pikachu");
		}
	}
}
