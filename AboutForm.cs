using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Organizer
{
	/// <summary>
	/// Zusammendfassende Beschreibung für AboutForm.
	/// </summary>
	internal class AboutForm : System.Windows.Forms.Form {
		private System.Windows.Forms.Label labelApp;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.LinkLabel linkLabelInternet;
		private System.Windows.Forms.LinkLabel linkLabelEmail;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.PictureBox pictureBoxIcon;
		private System.Windows.Forms.Panel panelBottom;
		private System.Windows.Forms.Panel panelLeft;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AboutForm() {
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AboutForm));
			this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
			this.labelApp = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.linkLabelInternet = new System.Windows.Forms.LinkLabel();
			this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.labelName = new System.Windows.Forms.Label();
			this.panelBottom.SuspendLayout();
			this.panelLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxIcon
			// 
			this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxIcon.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBoxIcon.Image")));
			this.pictureBoxIcon.Name = "pictureBoxIcon";
			this.pictureBoxIcon.Size = new System.Drawing.Size(64, 135);
			this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxIcon.TabIndex = 0;
			this.pictureBoxIcon.TabStop = false;
			// 
			// labelApp
			// 
			this.labelApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelApp.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelApp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelApp.Location = new System.Drawing.Point(72, 40);
			this.labelApp.Name = "labelApp";
			this.labelApp.Size = new System.Drawing.Size(176, 24);
			this.labelApp.TabIndex = 1;
			this.labelApp.Text = "Organizer Version 1.0.1383";
			// 
			// labelCopyright
			// 
			this.labelCopyright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelCopyright.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCopyright.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelCopyright.Location = new System.Drawing.Point(104, 64);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(120, 16);
			this.labelCopyright.TabIndex = 2;
			this.labelCopyright.Text = "Copyright © 2003";
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Location = new System.Drawing.Point(168, 16);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 24);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			// 
			// panelBottom
			// 
			this.panelBottom.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.buttonOK,
																					  this.linkLabelInternet,
																					  this.linkLabelEmail});
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new System.Drawing.Point(0, 135);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(258, 48);
			this.panelBottom.TabIndex = 4;
			// 
			// linkLabelInternet
			// 
			this.linkLabelInternet.Location = new System.Drawing.Point(8, 8);
			this.linkLabelInternet.Name = "linkLabelInternet";
			this.linkLabelInternet.Size = new System.Drawing.Size(80, 16);
			this.linkLabelInternet.TabIndex = 6;
			this.linkLabelInternet.TabStop = true;
			this.linkLabelInternet.Text = "www.dvoid.org";
			this.linkLabelInternet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInternet_LinkClicked);
			// 
			// linkLabelEmail
			// 
			this.linkLabelEmail.Location = new System.Drawing.Point(8, 24);
			this.linkLabelEmail.Name = "linkLabelEmail";
			this.linkLabelEmail.Size = new System.Drawing.Size(152, 16);
			this.linkLabelEmail.TabIndex = 6;
			this.linkLabelEmail.TabStop = true;
			this.linkLabelEmail.Text = "heiner.engelhardt@dvoid.org";
			this.linkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmail_LinkClicked);
			// 
			// panelLeft
			// 
			this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelLeft.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.pictureBoxIcon});
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(64, 135);
			this.panelLeft.TabIndex = 5;
			// 
			// labelName
			// 
			this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelName.Location = new System.Drawing.Point(104, 80);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(128, 16);
			this.labelName.TabIndex = 6;
			this.labelName.Text = "by Heiner Engelhardt";
			// 
			// AboutForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(258, 183);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.labelName,
																		  this.panelLeft,
																		  this.panelBottom,
																		  this.labelCopyright,
																		  this.labelApp});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Über";
			this.panelBottom.ResumeLayout(false);
			this.panelLeft.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	#endregion

		private void linkLabelInternet_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start( "http://www.dvoid.org" );
			e.Link.Visited = true;
		}

		private void linkLabelEmail_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start( "mailto:heiner.engelhardt@dvoid.org" );
			e.Link.Visited = true;
		}
	}
}
