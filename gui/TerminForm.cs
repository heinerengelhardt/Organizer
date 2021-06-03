using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Organizer
{
	/// <summary>
	/// Zusammendfassende Beschreibung für TerminForm.
	/// </summary>
	internal class TerminForm : System.Windows.Forms.Form {
		public System.Windows.Forms.DateTimePicker TheDateTimePicker;
		private System.Windows.Forms.RadioButton radioButtonTime;
		private System.Windows.Forms.RadioButton radioButtonDate;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		public System.Windows.Forms.TextBox textBoxSubject;
		private System.Windows.Forms.Label labelSubject;
		private System.Windows.Forms.Label labelNewTermin;
		private System.Windows.Forms.Panel panelCenter;

		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TerminForm() {
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
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
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
		private void InitializeComponent() {
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TerminForm));
			this.labelNewTermin = new System.Windows.Forms.Label();
			this.panelCenter = new System.Windows.Forms.Panel();
			this.TheDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.radioButtonTime = new System.Windows.Forms.RadioButton();
			this.radioButtonDate = new System.Windows.Forms.RadioButton();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.textBoxSubject = new System.Windows.Forms.TextBox();
			this.labelSubject = new System.Windows.Forms.Label();
			this.panelCenter.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelNewTermin
			// 
			this.labelNewTermin.BackColor = System.Drawing.Color.White;
			this.labelNewTermin.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelNewTermin.Font = new System.Drawing.Font("Tahoma", 15.75F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelNewTermin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelNewTermin.Name = "labelNewTermin";
			this.labelNewTermin.Size = new System.Drawing.Size(250, 24);
			this.labelNewTermin.TabIndex = 1;
			this.labelNewTermin.Text = "Neuer Termin:";
			// 
			// panelCenter
			// 
			this.panelCenter.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.TheDateTimePicker,
																					  this.radioButtonTime,
																					  this.radioButtonDate,
																					  this.buttonCancel,
																					  this.buttonOK,
																					  this.textBoxSubject,
																					  this.labelSubject});
			this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCenter.Location = new System.Drawing.Point(0, 24);
			this.panelCenter.Name = "panelCenter";
			this.panelCenter.Size = new System.Drawing.Size(250, 111);
			this.panelCenter.TabIndex = 3;
			// 
			// TheDateTimePicker
			// 
			this.TheDateTimePicker.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TheDateTimePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TheDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.TheDateTimePicker.Location = new System.Drawing.Point(136, 8);
			this.TheDateTimePicker.Name = "TheDateTimePicker";
			this.TheDateTimePicker.Size = new System.Drawing.Size(96, 21);
			this.TheDateTimePicker.TabIndex = 2;
			// 
			// radioButtonTime
			// 
			this.radioButtonTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButtonTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.radioButtonTime.Location = new System.Drawing.Point(80, 8);
			this.radioButtonTime.Name = "radioButtonTime";
			this.radioButtonTime.Size = new System.Drawing.Size(56, 24);
			this.radioButtonTime.TabIndex = 1;
			this.radioButtonTime.Text = "Zeit";
			this.radioButtonTime.CheckedChanged += new System.EventHandler(this.radioButtonTime_CheckedChanged);
			// 
			// radioButtonDate
			// 
			this.radioButtonDate.Checked = true;
			this.radioButtonDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButtonDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.radioButtonDate.Location = new System.Drawing.Point(16, 8);
			this.radioButtonDate.Name = "radioButtonDate";
			this.radioButtonDate.Size = new System.Drawing.Size(64, 24);
			this.radioButtonDate.TabIndex = 0;
			this.radioButtonDate.TabStop = true;
			this.radioButtonDate.Text = "Datum";
			this.radioButtonDate.CheckedChanged += new System.EventHandler(this.radioButtonDate_CheckedChanged);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonCancel.Location = new System.Drawing.Point(144, 72);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Abbruch";
			// 
			// buttonOK
			// 
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonOK.Location = new System.Drawing.Point(48, 72);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(88, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// textBoxSubject
			// 
			this.textBoxSubject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBoxSubject.ForeColor = System.Drawing.SystemColors.ControlText;
			this.textBoxSubject.Location = new System.Drawing.Point(72, 40);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(160, 21);
			this.textBoxSubject.TabIndex = 3;
			this.textBoxSubject.Text = "";
			this.textBoxSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSubject_KeyDown);
			// 
			// labelSubject
			// 
			this.labelSubject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelSubject.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelSubject.Location = new System.Drawing.Point(16, 40);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(56, 23);
			this.labelSubject.TabIndex = 1;
			this.labelSubject.Text = "Betreff";
			this.labelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TerminForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(250, 135);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panelCenter,
																		  this.labelNewTermin});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TerminForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Organizer";
			this.panelCenter.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	#endregion

		private void buttonOK_Click(object sender, System.EventArgs e) {
			textBoxSubject.Text = textBoxSubject.Text.Trim();

			if( textBoxSubject.Text.Equals( "" ) ) {
				textBoxSubject.Text = "-";
			}

			this.DialogResult = DialogResult.OK;
		}

		private void radioButtonDate_CheckedChanged(object sender, System.EventArgs e) {
			TheDateTimePicker.Format = DateTimePickerFormat.Short;
			TheDateTimePicker.ShowUpDown = false;
		}

		private void radioButtonTime_CheckedChanged(object sender, System.EventArgs e) {
			TheDateTimePicker.Format = DateTimePickerFormat.Time;
			TheDateTimePicker.ShowUpDown = true;
		}

		private void textBoxSubject_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if( e.KeyCode == Keys.Enter ) {
				textBoxSubject.Text = textBoxSubject.Text.Trim();

				if( textBoxSubject.Text.Equals( "" ) ) {
					textBoxSubject.Text = "-";
				}
				
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
