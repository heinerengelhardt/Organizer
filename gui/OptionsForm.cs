using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Organizer
{
	/// <summary>
	/// Zusammendfassende Beschreibung für OptionsForm.
	/// </summary>
	internal class OptionsForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labelMemento;
		private System.Windows.Forms.CheckBox checkBoxSound;
		private System.Windows.Forms.CheckBox checkBoxWindow;
		private System.Windows.Forms.Label labelMinuteMemento;
		private System.Windows.Forms.Label labelMementoAs;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
		private System.Windows.Forms.TextBox textBoxSoundFile;
		private System.Windows.Forms.Button buttonChooseSoundFile;
		private System.Windows.Forms.OpenFileDialog openSoundFileDialog;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public OptionsForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(OptionsForm));
			this.labelMemento = new System.Windows.Forms.Label();
			this.checkBoxSound = new System.Windows.Forms.CheckBox();
			this.checkBoxWindow = new System.Windows.Forms.CheckBox();
			this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
			this.labelMinuteMemento = new System.Windows.Forms.Label();
			this.labelMementoAs = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.textBoxSoundFile = new System.Windows.Forms.TextBox();
			this.buttonChooseSoundFile = new System.Windows.Forms.Button();
			this.openSoundFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
			this.SuspendLayout();
			// 
			// labelMemento
			// 
			this.labelMemento.BackColor = System.Drawing.Color.White;
			this.labelMemento.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelMemento.Font = new System.Drawing.Font("Tahoma", 15.75F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMemento.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelMemento.Name = "labelMemento";
			this.labelMemento.Size = new System.Drawing.Size(234, 32);
			this.labelMemento.TabIndex = 2;
			this.labelMemento.Text = "Erinnerung:";
			// 
			// checkBoxSound
			// 
			this.checkBoxSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxSound.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxSound.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.checkBoxSound.Location = new System.Drawing.Point(64, 91);
			this.checkBoxSound.Name = "checkBoxSound";
			this.checkBoxSound.Size = new System.Drawing.Size(64, 24);
			this.checkBoxSound.TabIndex = 3;
			this.checkBoxSound.Text = "Ton";
			this.checkBoxSound.CheckedChanged += new System.EventHandler(this.checkBoxSound_CheckedChanged);
			// 
			// checkBoxWindow
			// 
			this.checkBoxWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxWindow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxWindow.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.checkBoxWindow.Location = new System.Drawing.Point(64, 67);
			this.checkBoxWindow.Name = "checkBoxWindow";
			this.checkBoxWindow.Size = new System.Drawing.Size(64, 24);
			this.checkBoxWindow.TabIndex = 4;
			this.checkBoxWindow.Text = "Fenster";
			// 
			// numericUpDownMinutes
			// 
			this.numericUpDownMinutes.BackColor = System.Drawing.SystemColors.Window;
			this.numericUpDownMinutes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numericUpDownMinutes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.numericUpDownMinutes.Increment = new System.Decimal(new int[] {
																				   15,
																				   0,
																				   0,
																				   0});
			this.numericUpDownMinutes.Location = new System.Drawing.Point(8, 40);
			this.numericUpDownMinutes.Maximum = new System.Decimal(new int[] {
																				 180,
																				 0,
																				 0,
																				 0});
			this.numericUpDownMinutes.Minimum = new System.Decimal(new int[] {
																				 1,
																				 0,
																				 0,
																				 0});
			this.numericUpDownMinutes.Name = "numericUpDownMinutes";
			this.numericUpDownMinutes.Size = new System.Drawing.Size(48, 21);
			this.numericUpDownMinutes.TabIndex = 5;
			this.numericUpDownMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownMinutes.Value = new System.Decimal(new int[] {
																			   30,
																			   0,
																			   0,
																			   0});
			// 
			// labelMinuteMemento
			// 
			this.labelMinuteMemento.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMinuteMemento.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelMinuteMemento.Location = new System.Drawing.Point(64, 40);
			this.labelMinuteMemento.Name = "labelMinuteMemento";
			this.labelMinuteMemento.Size = new System.Drawing.Size(168, 23);
			this.labelMinuteMemento.TabIndex = 6;
			this.labelMinuteMemento.Text = "Minuten vor Terminbeginn.";
			this.labelMinuteMemento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMementoAs
			// 
			this.labelMementoAs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelMementoAs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelMementoAs.Location = new System.Drawing.Point(8, 67);
			this.labelMementoAs.Name = "labelMementoAs";
			this.labelMementoAs.Size = new System.Drawing.Size(32, 23);
			this.labelMementoAs.TabIndex = 7;
			this.labelMementoAs.Text = "Als:";
			this.labelMementoAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonCancel.Location = new System.Drawing.Point(136, 152);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 23);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "Abbruch";
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.buttonOK.Location = new System.Drawing.Point(40, 152);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(88, 23);
			this.buttonOK.TabIndex = 8;
			this.buttonOK.Text = "OK";
			// 
			// textBoxSoundFile
			// 
			this.textBoxSoundFile.Location = new System.Drawing.Point(64, 115);
			this.textBoxSoundFile.Name = "textBoxSoundFile";
			this.textBoxSoundFile.Size = new System.Drawing.Size(128, 20);
			this.textBoxSoundFile.TabIndex = 10;
			this.textBoxSoundFile.Text = "";
			// 
			// buttonChooseSoundFile
			// 
			this.buttonChooseSoundFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonChooseSoundFile.Location = new System.Drawing.Point(200, 115);
			this.buttonChooseSoundFile.Name = "buttonChooseSoundFile";
			this.buttonChooseSoundFile.Size = new System.Drawing.Size(24, 19);
			this.buttonChooseSoundFile.TabIndex = 11;
			this.buttonChooseSoundFile.Text = "...";
			this.buttonChooseSoundFile.Click += new System.EventHandler(this.buttonChooseSoundFile_Click);
			// 
			// openSoundFileDialog
			// 
			this.openSoundFileDialog.DefaultExt = "wav";
			this.openSoundFileDialog.Filter = "Wavdateien (*.wav)|*.wav";
			// 
			// OptionsForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(234, 191);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonChooseSoundFile,
																		  this.textBoxSoundFile,
																		  this.buttonCancel,
																		  this.buttonOK,
																		  this.labelMementoAs,
																		  this.labelMinuteMemento,
																		  this.numericUpDownMinutes,
																		  this.checkBoxWindow,
																		  this.checkBoxSound,
																		  this.labelMemento});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Optionen";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonChooseSoundFile_Click(object sender, System.EventArgs e) {
			DialogResult dr = openSoundFileDialog.ShowDialog();

			if( DialogResult.OK.Equals( dr ) ) {
				textBoxSoundFile.Text = openSoundFileDialog.FileName;
			}
		}

		private void checkBoxSound_CheckedChanged(object sender, System.EventArgs e) {
//			if( checkBoxSound.Checked ) {
//			}
//			else {
//			}
		}

		public string SoundFileName {
			get {
				return textBoxSoundFile.Text;
			}
			set {
				textBoxSoundFile.Text = value;
			}
		}

		public bool IsPlaySound {
			get {
				return checkBoxSound.Checked;
			}
			set {
				checkBoxSound.Checked = value;
			}
		}

		public bool IsShowWindow {
			get {
				return checkBoxWindow.Checked;
			}
			set {
				checkBoxWindow.Checked = value;
			}
		}

		public decimal Minutes {
			get {
				return numericUpDownMinutes.Value;
			}
			set {
				numericUpDownMinutes.Value = value;
			}
		}

	}
}
