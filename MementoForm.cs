using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Organizer
{
	/// <summary>
	/// Zusammendfassende Beschreibung für MementoForm.
	/// </summary>
	internal class MementoForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labelNextTermin;
		private System.Windows.Forms.Label labelTermin;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MementoForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
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
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MementoForm));
			this.labelNextTermin = new System.Windows.Forms.Label();
			this.labelTermin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelNextTermin
			// 
			this.labelNextTermin.BackColor = System.Drawing.SystemColors.Info;
			this.labelNextTermin.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelNextTermin.Font = new System.Drawing.Font("Tahoma", 14.25F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelNextTermin.Name = "labelNextTermin";
			this.labelNextTermin.Size = new System.Drawing.Size(186, 40);
			this.labelNextTermin.TabIndex = 0;
			this.labelNextTermin.Text = "Nächster Termin:";
			// 
			// labelTermin
			// 
			this.labelTermin.BackColor = System.Drawing.SystemColors.Info;
			this.labelTermin.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labelTermin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelTermin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTermin.Location = new System.Drawing.Point(0, 34);
			this.labelTermin.Name = "labelTermin";
			this.labelTermin.Size = new System.Drawing.Size(186, 80);
			this.labelTermin.TabIndex = 1;
			this.labelTermin.Text = "<Nächster Termin>";
			this.labelTermin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelTermin.UseMnemonic = false;
			// 
			// MementoForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(186, 114);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.labelTermin,
																		  this.labelNextTermin});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MementoForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Erinnerung";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion

		public string TerminText {
			get {
				return labelTermin.Text;
			}
			set {
				labelTermin.Text = value;
			}
		}
	}
}
