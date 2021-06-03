using System;
using System.Drawing;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;
using Dvoid.Tools;


namespace Organizer
{
	/// <summary>
	/// Zusammendfassende Beschreibung für Form1.
	/// </summary>
	internal class OrganizerForm : System.Windows.Forms.Form {
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.Panel panelRight;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private RegistryKey regkey;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ToolBar toolBar;
		private System.Windows.Forms.ToolBarButton toolBarButtonHide;
		private System.Windows.Forms.Label labelCurrentDate;
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.CheckBox checkBoxTopMost;
		private System.Data.DataSet dataSet;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel panelRightTop;
		private System.Windows.Forms.Panel panelRightBottom;
		private System.Windows.Forms.Label labelTermine;
		private System.Windows.Forms.MenuItem contextMenuItemNewTermin;
		private System.Windows.Forms.MenuItem contextMenuItemDeleteTermin;
		private System.Windows.Forms.MenuItem contextMenuItemEditTermin;
		private System.Windows.Forms.MenuItem contextMenuItemViewSeperator1;
		private System.Windows.Forms.ColumnHeader columnHeaderArrow;
		private System.Windows.Forms.ColumnHeader columnHeaderDate;
		private System.Windows.Forms.ColumnHeader columnHeaderTime;
		private System.Windows.Forms.ColumnHeader columnHeaderSubject;
		private System.Windows.Forms.StatusBarPanel statusBarPanel;
		private System.Windows.Forms.ContextMenu contextMenuIcon;
		private System.Windows.Forms.MenuItem contextMenuItemIconOpen;
		private System.Windows.Forms.MenuItem contextMenuItemIconNewTermin;
		private System.Windows.Forms.MenuItem contextMenuItemIconExit;
		private System.Windows.Forms.MenuItem contextMenuItemIconAbout;
		private System.Windows.Forms.ToolBarButton toolBarButtonExit;
		private System.Windows.Forms.ToolBarButton toolBarButtonSeperator1;
		private System.Windows.Forms.ToolBarButton toolBarButtonSeperator2;
		private System.Windows.Forms.Timer timerTermine;
		private System.Windows.Forms.Timer timerFadeOut;
		private System.Windows.Forms.MenuItem contextMenuItemIconSeperator1;
		private System.Windows.Forms.MenuItem contextMenuItemIconSeperator2;
		private TerminManager terminManager;
		private TaskManager taskManager;
		private System.Windows.Forms.ToolBarButton toolBarButtonSeperator3;
		private System.Windows.Forms.ListView listViewTermine;
		private System.Windows.Forms.ListView listViewTasks;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Panel panelRightCenterTop;
		private System.Windows.Forms.Panel panelRightCenterBottom;
		private System.Windows.Forms.Label labelTasks;
		private System.Windows.Forms.Splitter splitterRightCenter;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButtonEntry;
		private System.Windows.Forms.ContextMenu contextMenuEntry;
		private System.Windows.Forms.MenuItem contextMenuItemNewTask;
		private System.Windows.Forms.MenuItem contextMenuItemEditTask;
		private System.Windows.Forms.MenuItem contextMenuItemDeleteTask;
		private System.Windows.Forms.MenuItem menuItemTermin;
		private System.Windows.Forms.MenuItem menuItemTerminNew;
		private System.Windows.Forms.MenuItem menuItemTerminEdit;
		private System.Windows.Forms.MenuItem menuItemTerminDelete;
		private System.Windows.Forms.MenuItem menuItemTerminSeperator1;
		private System.Windows.Forms.MenuItem menuItemTaskNew;
		private System.Windows.Forms.MenuItem menuItemTaskEdit;
		private System.Windows.Forms.MenuItem menuItemTaskDelete;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItemExit;
		private System.Windows.Forms.MenuItem menuItemView;
		private System.Windows.Forms.MenuItem menuItemViewGridlines;
		private System.Windows.Forms.MenuItem menuItemViewSeperator1;
		private System.Windows.Forms.MenuItem menuItemViewCalender;
		private System.Windows.Forms.MenuItem menuItemViewSeperator2;
		private System.Windows.Forms.MenuItem menuItemViewToolbar;
		private System.Windows.Forms.MenuItem menuItemViewStatusbar;
		private System.Windows.Forms.MenuItem menuItemViewSeperator3;
		private System.Windows.Forms.MenuItem menuItemViewHide;
		private System.Windows.Forms.MenuItem menuItemExtras;
		private System.Windows.Forms.MenuItem menuItemExtrasOptions;
		private System.Windows.Forms.MenuItem menuItemHelp;
		private System.Windows.Forms.MenuItem menuItemHelpAbout;
		private System.Windows.Forms.MainMenu mainMenu;
		private Crownwood.Magic.Menus.MenuCommand menuCommand1;
		private Crownwood.Magic.Menus.MenuCommand menuCommand2;
		private Crownwood.Magic.Menus.MenuCommand menuCommand3;
		private Crownwood.Magic.Menus.MenuControl menuControl;
		private OptionsForm optionsForm;

		public OrganizerForm() {
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			terminManager = new TerminManager();
			taskManager = new TaskManager();
			optionsForm = new OptionsForm();
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(OrganizerForm));
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.statusBarPanel = new System.Windows.Forms.StatusBarPanel();
			this.toolBar = new System.Windows.Forms.ToolBar();
			this.toolBarButtonEntry = new System.Windows.Forms.ToolBarButton();
			this.contextMenuEntry = new System.Windows.Forms.ContextMenu();
			this.contextMenuItemNewTermin = new System.Windows.Forms.MenuItem();
			this.contextMenuItemEditTermin = new System.Windows.Forms.MenuItem();
			this.contextMenuItemDeleteTermin = new System.Windows.Forms.MenuItem();
			this.contextMenuItemViewSeperator1 = new System.Windows.Forms.MenuItem();
			this.contextMenuItemNewTask = new System.Windows.Forms.MenuItem();
			this.contextMenuItemEditTask = new System.Windows.Forms.MenuItem();
			this.contextMenuItemDeleteTask = new System.Windows.Forms.MenuItem();
			this.toolBarButtonSeperator1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonHide = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonSeperator2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonExit = new System.Windows.Forms.ToolBarButton();
			this.toolBarButtonSeperator3 = new System.Windows.Forms.ToolBarButton();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.panelLeft = new System.Windows.Forms.Panel();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.panelRight = new System.Windows.Forms.Panel();
			this.panelRightCenterBottom = new System.Windows.Forms.Panel();
			this.listViewTasks = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.labelTasks = new System.Windows.Forms.Label();
			this.splitterRightCenter = new System.Windows.Forms.Splitter();
			this.panelRightCenterTop = new System.Windows.Forms.Panel();
			this.listViewTermine = new System.Windows.Forms.ListView();
			this.columnHeaderArrow = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderTime = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderSubject = new System.Windows.Forms.ColumnHeader();
			this.labelTermine = new System.Windows.Forms.Label();
			this.panelRightTop = new System.Windows.Forms.Panel();
			this.labelCurrentDate = new System.Windows.Forms.Label();
			this.panelRightBottom = new System.Windows.Forms.Panel();
			this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuIcon = new System.Windows.Forms.ContextMenu();
			this.contextMenuItemIconOpen = new System.Windows.Forms.MenuItem();
			this.contextMenuItemIconAbout = new System.Windows.Forms.MenuItem();
			this.contextMenuItemIconSeperator1 = new System.Windows.Forms.MenuItem();
			this.contextMenuItemIconNewTermin = new System.Windows.Forms.MenuItem();
			this.contextMenuItemIconSeperator2 = new System.Windows.Forms.MenuItem();
			this.contextMenuItemIconExit = new System.Windows.Forms.MenuItem();
			this.timerTermine = new System.Windows.Forms.Timer(this.components);
			this.dataSet = new System.Data.DataSet();
			this.timerFadeOut = new System.Windows.Forms.Timer(this.components);
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.menuItemTermin = new System.Windows.Forms.MenuItem();
			this.menuItemTerminNew = new System.Windows.Forms.MenuItem();
			this.menuItemTerminEdit = new System.Windows.Forms.MenuItem();
			this.menuItemTerminDelete = new System.Windows.Forms.MenuItem();
			this.menuItemTerminSeperator1 = new System.Windows.Forms.MenuItem();
			this.menuItemTaskNew = new System.Windows.Forms.MenuItem();
			this.menuItemTaskEdit = new System.Windows.Forms.MenuItem();
			this.menuItemTaskDelete = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItemExit = new System.Windows.Forms.MenuItem();
			this.menuItemView = new System.Windows.Forms.MenuItem();
			this.menuItemViewGridlines = new System.Windows.Forms.MenuItem();
			this.menuItemViewSeperator1 = new System.Windows.Forms.MenuItem();
			this.menuItemViewCalender = new System.Windows.Forms.MenuItem();
			this.menuItemViewSeperator2 = new System.Windows.Forms.MenuItem();
			this.menuItemViewToolbar = new System.Windows.Forms.MenuItem();
			this.menuItemViewStatusbar = new System.Windows.Forms.MenuItem();
			this.menuItemViewSeperator3 = new System.Windows.Forms.MenuItem();
			this.menuItemViewHide = new System.Windows.Forms.MenuItem();
			this.menuItemExtras = new System.Windows.Forms.MenuItem();
			this.menuItemExtrasOptions = new System.Windows.Forms.MenuItem();
			this.menuItemHelp = new System.Windows.Forms.MenuItem();
			this.menuItemHelpAbout = new System.Windows.Forms.MenuItem();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuControl = new Crownwood.Magic.Menus.MenuControl();
			this.menuCommand1 = new Crownwood.Magic.Menus.MenuCommand();
			this.menuCommand2 = new Crownwood.Magic.Menus.MenuCommand();
			this.menuCommand3 = new Crownwood.Magic.Menus.MenuCommand();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel)).BeginInit();
			this.panelLeft.SuspendLayout();
			this.panelRight.SuspendLayout();
			this.panelRightCenterBottom.SuspendLayout();
			this.panelRightCenterTop.SuspendLayout();
			this.panelRightTop.SuspendLayout();
			this.panelRightBottom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// statusBar
			// 
			this.statusBar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar.Location = new System.Drawing.Point(0, 393);
			this.statusBar.Name = "statusBar";
			this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						 this.statusBarPanel});
			this.statusBar.ShowPanels = true;
			this.statusBar.Size = new System.Drawing.Size(560, 24);
			this.statusBar.TabIndex = 1;
			// 
			// statusBarPanel
			// 
			this.statusBarPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel.Icon")));
			this.statusBarPanel.MinWidth = 100;
			this.statusBarPanel.Text = "Willkommen beim Organizer 1.0.1383";
			this.statusBarPanel.Width = 544;
			// 
			// toolBar
			// 
			this.toolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar.AutoSize = false;
			this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					   this.toolBarButtonEntry,
																					   this.toolBarButtonSeperator1,
																					   this.toolBarButtonHide,
																					   this.toolBarButtonSeperator2,
																					   this.toolBarButtonExit,
																					   this.toolBarButtonSeperator3});
			this.toolBar.ButtonSize = new System.Drawing.Size(22, 22);
			this.toolBar.DropDownArrows = true;
			this.toolBar.ImageList = this.imageList;
			this.toolBar.Name = "toolBar";
			this.toolBar.ShowToolTips = true;
			this.toolBar.Size = new System.Drawing.Size(560, 25);
			this.toolBar.TabIndex = 2;
			this.toolBar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
			// 
			// toolBarButtonEntry
			// 
			this.toolBarButtonEntry.DropDownMenu = this.contextMenuEntry;
			this.toolBarButtonEntry.ImageIndex = 7;
			this.toolBarButtonEntry.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.toolBarButtonEntry.Text = "Neuer Termin";
			this.toolBarButtonEntry.ToolTipText = "Termine / Aufgaben";
			// 
			// contextMenuEntry
			// 
			this.contextMenuEntry.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							 this.contextMenuItemNewTermin,
																							 this.contextMenuItemEditTermin,
																							 this.contextMenuItemDeleteTermin,
																							 this.contextMenuItemViewSeperator1,
																							 this.contextMenuItemNewTask,
																							 this.contextMenuItemEditTask,
																							 this.contextMenuItemDeleteTask});
			// 
			// contextMenuItemNewTermin
			// 
			this.contextMenuItemNewTermin.Index = 0;
			this.contextMenuItemNewTermin.MergeOrder = 12;
			this.contextMenuItemNewTermin.Text = "Neuer Termin";
			this.contextMenuItemNewTermin.Click += new System.EventHandler(this.contextMenuItemNewTermin_Click);
			// 
			// contextMenuItemEditTermin
			// 
			this.contextMenuItemEditTermin.Index = 1;
			this.contextMenuItemEditTermin.Text = "Termin Bearbeiten";
			this.contextMenuItemEditTermin.Click += new System.EventHandler(this.contextMenuItemEditTermin_Click);
			// 
			// contextMenuItemDeleteTermin
			// 
			this.contextMenuItemDeleteTermin.Index = 2;
			this.contextMenuItemDeleteTermin.Text = "Termin Löschen";
			this.contextMenuItemDeleteTermin.Click += new System.EventHandler(this.contextMenuItemDeleteTermin_Click);
			// 
			// contextMenuItemViewSeperator1
			// 
			this.contextMenuItemViewSeperator1.Index = 3;
			this.contextMenuItemViewSeperator1.Text = "-";
			// 
			// contextMenuItemNewTask
			// 
			this.contextMenuItemNewTask.Index = 4;
			this.contextMenuItemNewTask.Text = "Neue Aufgabe";
			this.contextMenuItemNewTask.Click += new System.EventHandler(this.contextMenuItemNewTask_Click);
			// 
			// contextMenuItemEditTask
			// 
			this.contextMenuItemEditTask.Index = 5;
			this.contextMenuItemEditTask.Text = "Aufgabe Bearbeiten";
			this.contextMenuItemEditTask.Click += new System.EventHandler(this.contextMenuItemEditTask_Click);
			// 
			// contextMenuItemDeleteTask
			// 
			this.contextMenuItemDeleteTask.Index = 6;
			this.contextMenuItemDeleteTask.Text = "Aufgabe Löschen";
			this.contextMenuItemDeleteTask.Click += new System.EventHandler(this.contextMenuItemDeleteTask_Click);
			// 
			// toolBarButtonSeperator1
			// 
			this.toolBarButtonSeperator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButtonHide
			// 
			this.toolBarButtonHide.ImageIndex = 2;
			this.toolBarButtonHide.Text = "Verbergen";
			this.toolBarButtonHide.ToolTipText = "Organizer Verbergen";
			// 
			// toolBarButtonSeperator2
			// 
			this.toolBarButtonSeperator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButtonExit
			// 
			this.toolBarButtonExit.ImageIndex = 4;
			this.toolBarButtonExit.Text = "Beenden";
			this.toolBarButtonExit.ToolTipText = "Organizer Beenden";
			// 
			// toolBarButtonSeperator3
			// 
			this.toolBarButtonSeperator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// imageList
			// 
			this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panelLeft
			// 
			this.panelLeft.BackColor = System.Drawing.Color.White;
			this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelLeft.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.monthCalendar});
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new System.Drawing.Point(0, 25);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(200, 368);
			this.panelLeft.TabIndex = 3;
			// 
			// monthCalendar
			// 
			this.monthCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
			this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.monthCalendar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.monthCalendar.MaxSelectionCount = 1;
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.ShowTodayCircle = false;
			this.monthCalendar.ShowWeekNumbers = true;
			this.monthCalendar.TabIndex = 0;
			// 
			// panelRight
			// 
			this.panelRight.BackColor = System.Drawing.Color.White;
			this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelRight.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.panelRightCenterBottom,
																					 this.splitterRightCenter,
																					 this.panelRightCenterTop,
																					 this.panelRightTop,
																					 this.panelRightBottom});
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRight.Location = new System.Drawing.Point(200, 25);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(360, 368);
			this.panelRight.TabIndex = 4;
			// 
			// panelRightCenterBottom
			// 
			this.panelRightCenterBottom.Controls.AddRange(new System.Windows.Forms.Control[] {
																								 this.listViewTasks,
																								 this.labelTasks});
			this.panelRightCenterBottom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelRightCenterBottom.Location = new System.Drawing.Point(0, 184);
			this.panelRightCenterBottom.Name = "panelRightCenterBottom";
			this.panelRightCenterBottom.Size = new System.Drawing.Size(356, 156);
			this.panelRightCenterBottom.TabIndex = 8;
			// 
			// listViewTasks
			// 
			this.listViewTasks.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.listViewTasks.AllowColumnReorder = true;
			this.listViewTasks.BackColor = System.Drawing.Color.White;
			this.listViewTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewTasks.CheckBoxes = true;
			this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							this.columnHeader1});
			this.listViewTasks.ContextMenu = this.contextMenuEntry;
			this.listViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewTasks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listViewTasks.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.listViewTasks.FullRowSelect = true;
			this.listViewTasks.GridLines = true;
			this.listViewTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewTasks.LabelEdit = true;
			this.listViewTasks.Location = new System.Drawing.Point(0, 32);
			this.listViewTasks.MultiSelect = false;
			this.listViewTasks.Name = "listViewTasks";
			this.listViewTasks.Size = new System.Drawing.Size(356, 124);
			this.listViewTasks.SmallImageList = this.imageList;
			this.listViewTasks.TabIndex = 4;
			this.listViewTasks.View = System.Windows.Forms.View.Details;
			this.listViewTasks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewTasks_KeyDown);
			this.listViewTasks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewTasks_ItemCheck);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Aufgabe";
			this.columnHeader1.Width = 335;
			// 
			// labelTasks
			// 
			this.labelTasks.BackColor = System.Drawing.Color.White;
			this.labelTasks.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTasks.Font = new System.Drawing.Font("Tahoma", 15.75F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTasks.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelTasks.Name = "labelTasks";
			this.labelTasks.Size = new System.Drawing.Size(356, 32);
			this.labelTasks.TabIndex = 3;
			this.labelTasks.Text = "Aufgaben:";
			// 
			// splitterRightCenter
			// 
			this.splitterRightCenter.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.splitterRightCenter.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitterRightCenter.Location = new System.Drawing.Point(0, 176);
			this.splitterRightCenter.Name = "splitterRightCenter";
			this.splitterRightCenter.Size = new System.Drawing.Size(356, 8);
			this.splitterRightCenter.TabIndex = 7;
			this.splitterRightCenter.TabStop = false;
			// 
			// panelRightCenterTop
			// 
			this.panelRightCenterTop.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.listViewTermine,
																							  this.labelTermine});
			this.panelRightCenterTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelRightCenterTop.Location = new System.Drawing.Point(0, 24);
			this.panelRightCenterTop.Name = "panelRightCenterTop";
			this.panelRightCenterTop.Size = new System.Drawing.Size(356, 152);
			this.panelRightCenterTop.TabIndex = 6;
			// 
			// listViewTermine
			// 
			this.listViewTermine.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.listViewTermine.AllowColumnReorder = true;
			this.listViewTermine.BackColor = System.Drawing.Color.White;
			this.listViewTermine.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listViewTermine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																							  this.columnHeaderArrow,
																							  this.columnHeaderDate,
																							  this.columnHeaderTime,
																							  this.columnHeaderSubject});
			this.listViewTermine.ContextMenu = this.contextMenuEntry;
			this.listViewTermine.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewTermine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listViewTermine.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.listViewTermine.FullRowSelect = true;
			this.listViewTermine.GridLines = true;
			this.listViewTermine.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewTermine.Location = new System.Drawing.Point(0, 32);
			this.listViewTermine.MultiSelect = false;
			this.listViewTermine.Name = "listViewTermine";
			this.listViewTermine.Size = new System.Drawing.Size(356, 120);
			this.listViewTermine.SmallImageList = this.imageList;
			this.listViewTermine.TabIndex = 2;
			this.listViewTermine.View = System.Windows.Forms.View.Details;
			this.listViewTermine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewTermine_KeyDown);
			this.listViewTermine.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
			// 
			// columnHeaderArrow
			// 
			this.columnHeaderArrow.Text = "";
			this.columnHeaderArrow.Width = 20;
			// 
			// columnHeaderDate
			// 
			this.columnHeaderDate.Text = "Datum";
			this.columnHeaderDate.Width = 70;
			// 
			// columnHeaderTime
			// 
			this.columnHeaderTime.Text = "Zeit";
			this.columnHeaderTime.Width = 40;
			// 
			// columnHeaderSubject
			// 
			this.columnHeaderSubject.Text = "Termin";
			this.columnHeaderSubject.Width = 200;
			// 
			// labelTermine
			// 
			this.labelTermine.BackColor = System.Drawing.Color.White;
			this.labelTermine.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTermine.Font = new System.Drawing.Font("Tahoma", 15.75F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTermine.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelTermine.Name = "labelTermine";
			this.labelTermine.Size = new System.Drawing.Size(356, 32);
			this.labelTermine.TabIndex = 0;
			this.labelTermine.Text = "Termine:";
			// 
			// panelRightTop
			// 
			this.panelRightTop.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.labelCurrentDate});
			this.panelRightTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelRightTop.Name = "panelRightTop";
			this.panelRightTop.Size = new System.Drawing.Size(356, 24);
			this.panelRightTop.TabIndex = 4;
			// 
			// labelCurrentDate
			// 
			this.labelCurrentDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelCurrentDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCurrentDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelCurrentDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelCurrentDate.ForeColor = System.Drawing.Color.White;
			this.labelCurrentDate.Name = "labelCurrentDate";
			this.labelCurrentDate.Size = new System.Drawing.Size(356, 24);
			this.labelCurrentDate.TabIndex = 3;
			this.labelCurrentDate.Text = "<Aktuelles Datum>";
			this.labelCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panelRightBottom
			// 
			this.panelRightBottom.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.checkBoxTopMost,
																						   this.menuControl});
			this.panelRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelRightBottom.Location = new System.Drawing.Point(0, 340);
			this.panelRightBottom.Name = "panelRightBottom";
			this.panelRightBottom.Size = new System.Drawing.Size(356, 24);
			this.panelRightBottom.TabIndex = 5;
			// 
			// checkBoxTopMost
			// 
			this.checkBoxTopMost.Dock = System.Windows.Forms.DockStyle.Right;
			this.checkBoxTopMost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxTopMost.Location = new System.Drawing.Point(204, 0);
			this.checkBoxTopMost.Name = "checkBoxTopMost";
			this.checkBoxTopMost.Size = new System.Drawing.Size(152, 24);
			this.checkBoxTopMost.TabIndex = 0;
			this.checkBoxTopMost.Text = "Organizer im Vordergrund";
			this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenu = this.contextMenuIcon;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Organizer";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// contextMenuIcon
			// 
			this.contextMenuIcon.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.contextMenuItemIconOpen,
																							this.contextMenuItemIconAbout,
																							this.contextMenuItemIconSeperator1,
																							this.contextMenuItemIconNewTermin,
																							this.contextMenuItemIconSeperator2,
																							this.contextMenuItemIconExit});
			// 
			// contextMenuItemIconOpen
			// 
			this.contextMenuItemIconOpen.Index = 0;
			this.contextMenuItemIconOpen.Text = "Öffnen";
			this.contextMenuItemIconOpen.Click += new System.EventHandler(this.contextMenuItemIconOpen_Click);
			// 
			// contextMenuItemIconAbout
			// 
			this.contextMenuItemIconAbout.Index = 1;
			this.contextMenuItemIconAbout.Text = "Über Organizer...";
			this.contextMenuItemIconAbout.Click += new System.EventHandler(this.contextMenuItemIconAbout_Click);
			// 
			// contextMenuItemIconSeperator1
			// 
			this.contextMenuItemIconSeperator1.Index = 2;
			this.contextMenuItemIconSeperator1.Text = "-";
			// 
			// contextMenuItemIconNewTermin
			// 
			this.contextMenuItemIconNewTermin.Index = 3;
			this.contextMenuItemIconNewTermin.Text = "Neuer Termin";
			this.contextMenuItemIconNewTermin.Click += new System.EventHandler(this.contextMenuItemIconNewTermin_Click);
			// 
			// contextMenuItemIconSeperator2
			// 
			this.contextMenuItemIconSeperator2.Index = 4;
			this.contextMenuItemIconSeperator2.Text = "-";
			// 
			// contextMenuItemIconExit
			// 
			this.contextMenuItemIconExit.Index = 5;
			this.contextMenuItemIconExit.Text = "Beenden";
			this.contextMenuItemIconExit.Click += new System.EventHandler(this.contextMenuItemIconExit_Click);
			// 
			// timerTermine
			// 
			this.timerTermine.Interval = 60000;
			this.timerTermine.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "dataSet";
			this.dataSet.Locale = new System.Globalization.CultureInfo("de-DE");
			// 
			// timerFadeOut
			// 
			this.timerFadeOut.Interval = 30;
			this.timerFadeOut.Tick += new System.EventHandler(this.timerFadeOut_Tick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// menuItemTermin
			// 
			this.menuItemTermin.Index = 0;
			this.menuItemTermin.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuItemTerminNew,
																						   this.menuItemTerminEdit,
																						   this.menuItemTerminDelete,
																						   this.menuItemTerminSeperator1,
																						   this.menuItemTaskNew,
																						   this.menuItemTaskEdit,
																						   this.menuItemTaskDelete,
																						   this.menuItem1,
																						   this.menuItemExit});
			this.menuItemTermin.Text = "Organizer";
			// 
			// menuItemTerminNew
			// 
			this.menuItemTerminNew.Index = 0;
			this.menuItemTerminNew.Text = "Neuer Termin";
			this.menuItemTerminNew.Click += new System.EventHandler(this.menuItemTerminNew_Click);
			// 
			// menuItemTerminEdit
			// 
			this.menuItemTerminEdit.Index = 1;
			this.menuItemTerminEdit.Text = "Termin Bearbeiten";
			// 
			// menuItemTerminDelete
			// 
			this.menuItemTerminDelete.Index = 2;
			this.menuItemTerminDelete.Text = "Termin Löschen";
			this.menuItemTerminDelete.Click += new System.EventHandler(this.menuItemTerminDelete_Click);
			// 
			// menuItemTerminSeperator1
			// 
			this.menuItemTerminSeperator1.Index = 3;
			this.menuItemTerminSeperator1.Text = "-";
			// 
			// menuItemTaskNew
			// 
			this.menuItemTaskNew.Index = 4;
			this.menuItemTaskNew.Text = "Neue Aufgabe";
			this.menuItemTaskNew.Click += new System.EventHandler(this.menuItemTaskNew_Click);
			// 
			// menuItemTaskEdit
			// 
			this.menuItemTaskEdit.Index = 5;
			this.menuItemTaskEdit.Text = "Aufgabe Bearbeiten";
			this.menuItemTaskEdit.Click += new System.EventHandler(this.menuItemTaskEdit_Click);
			// 
			// menuItemTaskDelete
			// 
			this.menuItemTaskDelete.Index = 6;
			this.menuItemTaskDelete.Text = "Aufgabe Löschen";
			this.menuItemTaskDelete.Click += new System.EventHandler(this.menuItemTaskDelete_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 7;
			this.menuItem1.Text = "-";
			// 
			// menuItemExit
			// 
			this.menuItemExit.Index = 8;
			this.menuItemExit.Text = "Beenden";
			this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
			// 
			// menuItemView
			// 
			this.menuItemView.Index = 1;
			this.menuItemView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemViewGridlines,
																						 this.menuItemViewSeperator1,
																						 this.menuItemViewCalender,
																						 this.menuItemViewSeperator2,
																						 this.menuItemViewToolbar,
																						 this.menuItemViewStatusbar,
																						 this.menuItemViewSeperator3,
																						 this.menuItemViewHide});
			this.menuItemView.Text = "Ansicht";
			// 
			// menuItemViewGridlines
			// 
			this.menuItemViewGridlines.Checked = true;
			this.menuItemViewGridlines.Index = 0;
			this.menuItemViewGridlines.Text = "Raster";
			this.menuItemViewGridlines.Click += new System.EventHandler(this.menuItemViewGridlines_Click);
			// 
			// menuItemViewSeperator1
			// 
			this.menuItemViewSeperator1.Index = 1;
			this.menuItemViewSeperator1.Text = "-";
			// 
			// menuItemViewCalender
			// 
			this.menuItemViewCalender.Checked = true;
			this.menuItemViewCalender.Index = 2;
			this.menuItemViewCalender.Text = "Kalender";
			this.menuItemViewCalender.Click += new System.EventHandler(this.menuItemViewCalender_Click);
			// 
			// menuItemViewSeperator2
			// 
			this.menuItemViewSeperator2.Index = 3;
			this.menuItemViewSeperator2.Text = "-";
			// 
			// menuItemViewToolbar
			// 
			this.menuItemViewToolbar.Checked = true;
			this.menuItemViewToolbar.Index = 4;
			this.menuItemViewToolbar.Text = "Toolbar";
			this.menuItemViewToolbar.Click += new System.EventHandler(this.menuItemViewToolbar_Click);
			// 
			// menuItemViewStatusbar
			// 
			this.menuItemViewStatusbar.Checked = true;
			this.menuItemViewStatusbar.Index = 5;
			this.menuItemViewStatusbar.Text = "Statusbar";
			this.menuItemViewStatusbar.Click += new System.EventHandler(this.menuItemViewStatusbar_Click);
			// 
			// menuItemViewSeperator3
			// 
			this.menuItemViewSeperator3.Index = 6;
			this.menuItemViewSeperator3.Text = "-";
			// 
			// menuItemViewHide
			// 
			this.menuItemViewHide.Index = 7;
			this.menuItemViewHide.Text = "Organizer Verbergen";
			this.menuItemViewHide.Click += new System.EventHandler(this.menuItemViewHide_Click);
			// 
			// menuItemExtras
			// 
			this.menuItemExtras.Index = 2;
			this.menuItemExtras.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuItemExtrasOptions});
			this.menuItemExtras.Text = "Extras";
			// 
			// menuItemExtrasOptions
			// 
			this.menuItemExtrasOptions.Index = 0;
			this.menuItemExtrasOptions.Text = "Optionen";
			this.menuItemExtrasOptions.Click += new System.EventHandler(this.menuItemExtrasOptions_Click);
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.Index = 3;
			this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemHelpAbout});
			this.menuItemHelp.Text = "Hilfe";
			// 
			// menuItemHelpAbout
			// 
			this.menuItemHelpAbout.Index = 0;
			this.menuItemHelpAbout.Text = "Über Organizer...";
			this.menuItemHelpAbout.Click += new System.EventHandler(this.menuItemHelpAbout_Click);
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItemTermin,
																					 this.menuItemView,
																					 this.menuItemExtras,
																					 this.menuItemHelp});
			// 
			// menuControl
			// 
			this.menuControl.AnimateStyle = Crownwood.Magic.Menus.Animation.System;
			this.menuControl.AnimateTime = 100;
			this.menuControl.BackColor = System.Drawing.Color.White;
			this.menuControl.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.menuControl.Direction = Crownwood.Magic.Common.Direction.Horizontal;
			this.menuControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.menuControl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((System.Byte)(0)));
			this.menuControl.HighlightTextColor = System.Drawing.SystemColors.MenuText;
			this.menuControl.MdiContainer = this;
			this.menuControl.MenuCommands.AddRange(new Crownwood.Magic.Menus.MenuCommand[] {
																							   this.menuCommand1,
																							   this.menuCommand2,
																							   this.menuCommand3});
			this.menuControl.Name = "menuControl";
			this.menuControl.Size = new System.Drawing.Size(356, 25);
			this.menuControl.Style = Crownwood.Magic.Common.VisualStyle.IDE;
			this.menuControl.TabIndex = 1;
			this.menuControl.TabStop = false;
			this.menuControl.Text = "menuControl";
			// 
			// menuCommand1
			// 
			this.menuCommand1.Description = "MenuItem";
			this.menuCommand1.Image = ((System.Drawing.Bitmap)(resources.GetObject("menuCommand1.Image")));
			this.menuCommand1.Text = "File";
			// 
			// menuCommand2
			// 
			this.menuCommand2.Description = "MenuItem";
			this.menuCommand2.Image = ((System.Drawing.Bitmap)(resources.GetObject("menuCommand2.Image")));
			this.menuCommand2.Text = "Edit";
			// 
			// menuCommand3
			// 
			this.menuCommand3.Description = "MenuItem";
			this.menuCommand3.Image = ((System.Drawing.Bitmap)(resources.GetObject("menuCommand3.Image")));
			this.menuCommand3.Text = "Help";
			// 
			// OrganizerForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(560, 417);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panelRight,
																		  this.panelLeft,
																		  this.toolBar,
																		  this.statusBar});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu;
			this.Name = "OrganizerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Organizer 1.0.1383";
			this.SizeChanged += new System.EventHandler(this.OrganizerForSizeChanged);
			this.Load += new System.EventHandler(this.OrganizerForLoad);
			this.Closed += new System.EventHandler(this.OrganizerForClosed);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel)).EndInit();
			this.panelLeft.ResumeLayout(false);
			this.panelRight.ResumeLayout(false);
			this.panelRightCenterBottom.ResumeLayout(false);
			this.panelRightCenterTop.ResumeLayout(false);
			this.panelRightTop.ResumeLayout(false);
			this.panelRightBottom.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			this.ResumeLayout(false);

		}
	#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new OrganizerForm());
		}

		private void OrganizerForSizeChanged(object sender, System.EventArgs e) {
			listViewTermine.Columns[3].Width = panelRightCenterTop.Width - 150;
			listViewTasks.Columns[0].Width = panelRightCenterTop.Width - 20;
		}

		private void menuItemViewGridlines_Click(object sender, System.EventArgs e) {
			if( mainMenu.MenuItems[1].MenuItems[0].Checked == true ) {
				listViewTermine.GridLines = false;
				listViewTasks.GridLines = false;
				regkey.SetValue( "ShowGridLines", false );
				mainMenu.MenuItems[1].MenuItems[0].Checked = false;
		
			}
			else {
				listViewTermine.GridLines = true;
				listViewTasks.GridLines = true;
				regkey.SetValue( "ShowGridLines", true );
				mainMenu.MenuItems[1].MenuItems[0].Checked = true;
			}		
		}

//		private void menuItemViewHeader_Click(object sender, System.EventArgs e) {
//			if( mainMenu.MenuItems[1].MenuItems[1].Checked == true ) {
//				listViewTermine.HeaderStyle = ColumnHeaderStyle.None;
//				listViewTasks.HeaderStyle = ColumnHeaderStyle.None;
//				regkey.SetValue( "ShowHeader", ColumnHeaderStyle.None );
//				mainMenu.MenuItems[1].MenuItems[1].Checked = false;
//			}
//			else {
//				listViewTermine.HeaderStyle = ColumnHeaderStyle.Nonclickable;
//				listViewTasks.HeaderStyle = ColumnHeaderStyle.Nonclickable;
//				regkey.SetValue( "ShowHeader", ColumnHeaderStyle.Nonclickable );
//				mainMenu.MenuItems[1].MenuItems[1].Checked = true;
//			}		
//		}

		private void menuItemViewCalender_Click(object sender, System.EventArgs e) {
			if( mainMenu.MenuItems[1].MenuItems[2].Checked == true ) {
				panelLeft.Hide();
				regkey.SetValue( "ShowCalender", false );
				mainMenu.MenuItems[1].MenuItems[2].Checked = false;
			}
			else {
				panelLeft.Show();
				regkey.SetValue( "ShowCalender", true );
				mainMenu.MenuItems[1].MenuItems[2].Checked = true;
			}	
		}

		private void menuItemViewToolbar_Click(object sender, System.EventArgs e) {
			if( mainMenu.MenuItems[1].MenuItems[4].Checked == true ) {
				toolBar.Hide();
				regkey.SetValue( "ShowToolbar", false );
				mainMenu.MenuItems[1].MenuItems[4].Checked = false;
			}
			else {
				toolBar.Show();
				regkey.SetValue( "ShowToolbar", true );
				mainMenu.MenuItems[1].MenuItems[4].Checked = true;
			}
		}

		private void menuItemViewStatusbar_Click(object sender, System.EventArgs e) {
			if( mainMenu.MenuItems[1].MenuItems[5].Checked == true ) {
				statusBar.Hide();
				regkey.SetValue( "ShowStatusbar", false );
				mainMenu.MenuItems[1].MenuItems[5].Checked = false;
			}
			else {
				statusBar.Show();
				regkey.SetValue( "ShowStatusbar", true );
				mainMenu.MenuItems[1].MenuItems[5].Checked = true;
			}		
		}

		private void menuItemViewHide_Click(object sender, System.EventArgs e) {
			this.Hide();
		}

		private void notifyIcon_DoubleClick(object sender, System.EventArgs e) {
			this.Show();
			this.BringToFront();
			this.Focus();
		}

		private void toolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e) {
			// Neuer Termin
			if( e.Button.Text.Equals( "Neuer Termin" ) ) {
				CreateTermin();				
			}

			// Neue Aufgabe
			if( e.Button.Text.Equals( "Neue Aufgabe" ) ) {
				ListViewItem lvi = listViewTasks.Items.Add( "" );
				lvi.EnsureVisible();
				lvi.BeginEdit();
			}

			// Verbergen
			if( e.Button.Text.Equals( "Verbergen" ) ) {
//				timerFadeOut.Start();
				this.Hide();
			}

			// Beenden
			if( e.Button.Text.Equals( "Beenden" ) ) {
				this.Close();
			}
		}

		private void menuItemExit_Click(object sender, System.EventArgs e) {
			this.Close();
		}

		private void menuItemHelpAbout_Click(object sender, System.EventArgs e) {
			AboutForm af = new AboutForm();
			af.ShowDialog( this );
		}

		private void menuItemTerminDelete_Click(object sender, System.EventArgs e) {
			DeleteTermin();
		}

		private void menuItemTerminNew_Click(object sender, System.EventArgs e) {
			CreateTermin();
		}

		private void timer_Tick(object sender, System.EventArgs e) {
			InitTermineListView();
		}

		private void contextMenuItemNewTermin_Click(object sender, System.EventArgs e) {
			toolBar.Buttons[0].Text = "Neuer Termin";
			CreateTermin();
		}

		private void contextMenuItemDeleteTermin_Click(object sender, System.EventArgs e) {
//			toolBar.Buttons[0].Text = "Termin Löschen";
			DeleteTermin();
		}

		private void CreateTermin() {
			timerTermine.Stop();

			TerminForm tf = new TerminForm();
			if( tf.ShowDialog( this ) == DialogResult.OK ) {
				Termin t  = new Termin();
				t.TheDateTime = tf.TheDateTimePicker.Value;
				t.Subject     = tf.textBoxSubject.Text;
				t.ID          = DateTime.Now.Ticks.ToString();
				terminManager.InsertTermin( t );
				InitTermineListView();
			}

			timerTermine.Start();
		}

		private void DeleteTermin() {
			timerTermine.Stop();

			if( listViewTermine.SelectedItems.Count == 1 ) {
				DialogResult dr = MessageBox.Show( this, "Wirklich Löschen?", "Termin Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
				
				if( DialogResult.Yes.Equals( dr ) ) {
					Termin t = new Termin();
					t = (Termin) listViewTermine.SelectedItems[0].Tag;
					if( terminManager.DeleteTermin( t ) ) {
						listViewTermine.Items.Remove( listViewTermine.SelectedItems[0] );
						InitTermineListView();
					}
				}
			}

			timerTermine.Start();
		}

		private void EditTermin() {
			timerTermine.Stop();

			if( listViewTermine.SelectedItems.Count == 1 ) {
				Termin oldone = new Termin();
				oldone = (Termin) listViewTermine.SelectedItems[0].Tag;

				TerminForm tf = new TerminForm();
				tf.TheDateTimePicker.Value = oldone.TheDateTime;
				tf.textBoxSubject.Text  = oldone.Subject;
				if( tf.ShowDialog( this ) == DialogResult.OK ) {
					Termin newone = new Termin();
					newone.TheDateTime = tf.TheDateTimePicker.Value;
					newone.Subject     = tf.textBoxSubject.Text;
					newone.ID          = DateTime.Now.Ticks.ToString();
					terminManager.EditTermin( oldone, newone );
					InitTermineListView();
				}
			}

			timerTermine.Start();
		}

		private void OrganizerForClosed(object sender, System.EventArgs e) {
			regkey.SetValue( "MainFormSizeWidth", this.Size.Width );
			regkey.SetValue( "MainFormSizeHeight", this.Size.Height );
			regkey.SetValue( "MainFormPositionX", this.Location.X );
			regkey.SetValue( "MainFormPositionY", this.Location.Y );
			regkey.SetValue( "SplitPosition", splitterRightCenter.SplitPosition );

			timerTermine.Stop();

			SaveTasks();
		}

		private void contextMenuItemEditTermin_Click(object sender, System.EventArgs e) {
//			toolBar.Buttons[0].Text = "Termin Bearbeiten";
			EditTermin();
		}

		private void InitTermineListView() {
			listViewTermine.Items.Clear();
			ArrayList alTermine = terminManager.LoadTermine();
			bool bCurTerminSet = false;
			bool bSetOneTime   = false;
			Termin tToCheck = null;

			for( int i=0; i<alTermine.Count; i++ ) {
				Termin t = new Termin();
				t = (Termin) alTermine[i];
				ListViewItem lv = new ListViewItem();
				if( t.UpToDate ) {
					lv.ForeColor = Color.FromKnownColor( KnownColor.ActiveCaption );
//					Font f = new Font( lv.Font, FontStyle.Regular );
//					lv.Font = f;
					bCurTerminSet = true;
				}
				else {
					lv.ForeColor = Color.FromKnownColor( KnownColor.ControlDark );
//					Font f = new Font( lv.Font, FontStyle.Strikeout );
//					lv.Font = f;
				}
				if( !bSetOneTime ) {
					if( bCurTerminSet ) {
						lv.ImageIndex = 3;
						string strIconToolTip = "Nächster Termin:\n";
						strIconToolTip += t.TheDateTime.ToShortDateString();
						strIconToolTip += ", ";
						strIconToolTip += t.TheDateTime.ToShortTimeString();
						strIconToolTip += " Uhr";
						if( !t.Subject.Equals( "-") ) {
							strIconToolTip += "\n";
							strIconToolTip += t.Subject;
						}
						strIconToolTip.Trim();
						if( strIconToolTip.Length >= 64 ) {
							strIconToolTip = strIconToolTip.Substring( 0, 63 );
							strIconToolTip = strIconToolTip.Remove( 60, strIconToolTip.Length - 60 );
							strIconToolTip += "...";
						}
						notifyIcon.Text = strIconToolTip;
						bSetOneTime = true;
						
						tToCheck = t;
					}
				}
				lv.SubItems.Add( t.TheDateTime.ToShortDateString() );
				lv.SubItems.Add( t.TheDateTime.ToLongTimeString().Substring( 0, 5 ) );
				lv.SubItems.Add( t.Subject );
				lv.Tag = t;
				listViewTermine.Items.Add( lv );
			}

			CheckMemento( tToCheck );
		}

		private void OrganizerForLoad(object sender, System.EventArgs e) {
			regkey = Registry.LocalMachine;
			regkey = regkey.OpenSubKey( "SOFTWARE", true );
			regkey = regkey.CreateSubKey( "DVOID Organizer" );
			regkey = regkey.CreateSubKey( "Properties" );
        			
			// GridLines
			if( regkey.GetValue( "ShowGridlines", true.ToString() ).Equals( true.ToString() ) ) {
				listViewTermine.GridLines = true;
				listViewTasks.GridLines = true;
				mainMenu.MenuItems[1].MenuItems[0].Checked = true;
			}
			else {
				listViewTermine.GridLines = false;
				listViewTasks.GridLines = false;
				mainMenu.MenuItems[1].MenuItems[0].Checked = false;
			}

//			// Header
//			if( regkey.GetValue( "ShowHeader", "Nonclickable" ).Equals( "Nonclickable" ) ) {
//				listViewTermine.HeaderStyle = ColumnHeaderStyle.Nonclickable;
//				listViewTasks.HeaderStyle = ColumnHeaderStyle.Nonclickable;
//				mainMenu.MenuItems[1].MenuItems[1].Checked = true;
//			}
//			else {
//				listViewTermine.HeaderStyle = ColumnHeaderStyle.None;
//				listViewTasks.HeaderStyle = ColumnHeaderStyle.None;
//				mainMenu.MenuItems[1].MenuItems[1].Checked = false;
//			}
		
			// Calender
			if( regkey.GetValue( "ShowCalender", true.ToString() ).Equals( true.ToString() ) ) {
				panelLeft.Show();
				mainMenu.MenuItems[1].MenuItems[2].Checked = true;
			}
			else {
				panelLeft.Hide();
				mainMenu.MenuItems[1].MenuItems[2].Checked = false;
			}

			// Toolbar
			if( regkey.GetValue( "ShowToolbar", true.ToString() ).Equals( true.ToString() ) ) {
				toolBar.Show();
				mainMenu.MenuItems[1].MenuItems[4].Checked = true;
			}
			else {
				toolBar.Hide();
				mainMenu.MenuItems[1].MenuItems[4].Checked = false;
			}

			// Statusbar
			if( regkey.GetValue( "ShowStatusbar", true.ToString() ).Equals( true.ToString() ) ) {
				statusBar.Show();
				mainMenu.MenuItems[1].MenuItems[5].Checked = true;
			}
			else {
				statusBar.Hide();
				mainMenu.MenuItems[1].MenuItems[5].Checked = false;
			}

			// MainFormSize
			int iWidth  = int.Parse( regkey.GetValue( "MainFormSizeWidth", 576 ).ToString() );
			int iHeight = int.Parse( regkey.GetValue( "MainFormSizeHeight", 400 ).ToString() );
			this.Size = new Size( iWidth, iHeight );

			// MainFormPosition
			int iX = int.Parse( regkey.GetValue( "MainFormPositionX", 300 ).ToString() );
			int iY = int.Parse( regkey.GetValue( "MainFormPositionY", 300 ).ToString() );
			this.Location = new Point( iX, iY );

			// Split Position
			int iPos = int.Parse( regkey.GetValue( "SplitPosition", 150 ).ToString() );
			splitterRightCenter.SplitPosition = iPos;

			// MainFormTopMost
			if( regkey.GetValue( "MainFormTopMost", true.ToString() ).Equals( true.ToString() ) ) {
				checkBoxTopMost.Checked = true;
				this.TopMost = true;
			}
			else {
				checkBoxTopMost.Checked = false;
				this.TopMost = false;
			}

			// Sonstiges
			listViewTermine.Columns[3].Width = panelRightCenterTop.Width - 150;
			listViewTasks.Columns[0].Width = panelRightCenterTop.Width - 20;
			labelCurrentDate.Text = DateTime.Today.ToLongDateString();

			// Optionen
			if( regkey.GetValue( "PlaySound", true.ToString() ).Equals( true.ToString() ) ) {
				optionsForm.IsPlaySound = true;
			}
			else {
				optionsForm.IsPlaySound = false;
			}
			if( regkey.GetValue( "ShowWindow", true.ToString() ).Equals( true.ToString() ) ) {
				optionsForm.IsShowWindow = true;
			}
			else {
				optionsForm.IsShowWindow = false;
			}
			optionsForm.SoundFileName = regkey.GetValue( "SoundFileName", "" ).ToString();
			optionsForm.Minutes = decimal.Parse( regkey.GetValue( "Minutes", 30 ).ToString() );

			// Termine Laden
			InitTermineListView();

			// Aufgaben Laden
			InitTaskListView();

			// Termin Timer starten
			timerTermine.Start();
		}

		private void contextMenuItemIconOpen_Click(object sender, System.EventArgs e) {
			this.Show();
			this.BringToFront();
			this.Focus();
		}

		private void contextMenuItemIconNewTermin_Click(object sender, System.EventArgs e) {
			CreateTermin();
		}

		private void contextMenuItemIconAbout_Click(object sender, System.EventArgs e) {
			AboutForm af = new AboutForm();
			af.ShowDialog( this );		
		}

		private void contextMenuItemIconExit_Click(object sender, System.EventArgs e) {
			this.Close();
		}

		private void checkBoxTopMost_CheckedChanged(object sender, System.EventArgs e) {
			if( checkBoxTopMost.Checked ) {
				this.TopMost = true;
				regkey.SetValue( "MainFormTopMost", true );
			}
			else {
				this.TopMost = false;
				regkey.SetValue( "MainFormTopMost", false );
			}
		}

		private void timerFadeOut_Tick(object sender, System.EventArgs e) {
			double dOpacity = this.Opacity;

			if( dOpacity >= 0.09d ) {
				this.Opacity -= 0.1d;
				this.Refresh();
			}
			else {
				this.Hide();
				this.Opacity = 1.0d;
				this.Refresh();
				timerFadeOut.Stop();
			}		
		}

		private void listView_DoubleClick(object sender, System.EventArgs e) {
			EditTermin();
		}

		private void menuItemExtrasOptions_Click(object sender, System.EventArgs e) {
			optionsForm.Refresh();
			DialogResult dr = optionsForm.ShowDialog( this );

			if( DialogResult.OK.Equals( dr ) ) {
				regkey.SetValue( "PlaySound", optionsForm.IsPlaySound );
				regkey.SetValue( "ShowWindow", optionsForm.IsShowWindow );
				regkey.SetValue( "SoundFileName", optionsForm.SoundFileName );
				regkey.SetValue( "Minutes", optionsForm.Minutes );
			}
		}

		public void CheckMemento(Termin t) {
			if( t == null ) {
				return;
			}

			DateTime dtTermin = t.TheDateTime;
			dtTermin = dtTermin.AddMinutes( (double) - optionsForm.Minutes );
			DateTime dtNow = DateTime.Now;

			if( dtNow.Date.CompareTo( dtTermin.Date ) == 0 ) {
				if( dtNow.Hour.CompareTo( dtTermin.Hour ) == 0 ) {
					if( dtNow.Minute.CompareTo( dtTermin.Minute ) == 0 ) {
						if( optionsForm.IsShowWindow ) {
							MementoForm mf = new MementoForm();
							mf.Location = new Point( Screen.PrimaryScreen.WorkingArea.Width - 192 - 3, Screen.PrimaryScreen.WorkingArea.Height - 136 - 5 );
							mf.TerminText = t.TheDateTime.ToLongDateString();
							mf.TerminText += "\n";
							mf.TerminText += "um ";
							mf.TerminText += t.TheDateTime.ToShortTimeString();
							mf.TerminText += " Uhr";
							mf.TerminText += "\n\n";
							mf.TerminText += t.Subject;
							mf.Show();
						}
						if( optionsForm.IsPlaySound ) {
							WavFile.StartPlayback( optionsForm.SoundFileName, WavPlayOptions.SoundAsync );
						}
					}
				}
			}
		}

		public void InitTaskListView() {
			LoadTasks();
		}

		private void contextMenuItemNewTask_Click(object sender, System.EventArgs e) {
			toolBar.Buttons[0].Text = "Neue Aufgabe";
			ListViewItem lvi = listViewTasks.Items.Add( "" );
			lvi.EnsureVisible();
			lvi.BeginEdit();
		}

		private void contextMenuItemEditTask_Click(object sender, System.EventArgs e) {
			if( listViewTasks.SelectedItems.Count == 1 ) {
				ListViewItem lvi = listViewTasks.SelectedItems[0];
				lvi.EnsureVisible();
				lvi.BeginEdit();
			}
		}

		private void contextMenuItemDeleteTask_Click(object sender, System.EventArgs e) {
			DeleteTask();
		}

		private void menuItemTaskNew_Click(object sender, System.EventArgs e) {
			ListViewItem lvi = listViewTasks.Items.Add( "" );
			lvi.EnsureVisible();
			lvi.BeginEdit();			
		}

		private void menuItemTaskEdit_Click(object sender, System.EventArgs e) {
			if( listViewTasks.SelectedItems.Count == 1 ) {
				ListViewItem lvi = listViewTasks.SelectedItems[0];
				lvi.EnsureVisible();
				lvi.BeginEdit();
			}
		}

		private void menuItemTaskDelete_Click(object sender, System.EventArgs e) {
			DeleteTask();
		}

		private void listViewTasks_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e) {
			if( e.CurrentValue == CheckState.Checked ) {
				ListViewItem lvi = listViewTasks.Items[e.Index];
				lvi.ForeColor = Color.FromKnownColor( KnownColor.ActiveCaption );
				Font f = new Font( lvi.Font, FontStyle.Regular );
				lvi.Font = f;
			}
			else if( e.CurrentValue == CheckState.Unchecked ) {
				ListViewItem lvi = listViewTasks.Items[e.Index];
				lvi.ForeColor = Color.FromKnownColor( KnownColor.ControlDark );
				Font f = new Font( lvi.Font, FontStyle.Strikeout );
				lvi.Font = f;
			}
		}

		public void LoadTasks() {
			ArrayList al = taskManager.LoadTasks();
			Task t = null;
			
			foreach( Object o in al ) {
				t = (Task) o;
				ListViewItem lvi = listViewTasks.Items.Add( t.Subject );
				
				if( t.Done ) {
					lvi.ForeColor = Color.FromKnownColor( KnownColor.ControlDark );
					Font f = new Font( lvi.Font, FontStyle.Strikeout );
					lvi.Font = f;
					lvi.Checked = true;
				}
			}
		}

		public void SaveTasks() {
			ArrayList al = new ArrayList();
			Task t = null;
			ListViewItem lvi = null;

			for( int i=0; i<listViewTasks.Items.Count; i++ ) {
				lvi = listViewTasks.Items[i];

				t = new Task();
				t.Subject = lvi.Text;
				t.Done = lvi.Checked;

				al.Add( t );
			}

			taskManager.SaveTasks( al );		
		}

		private void listViewTermine_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if( e.KeyCode == Keys.Delete ) {
				DeleteTermin();
			}
		}

		private void listViewTasks_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if( e.KeyCode == Keys.Delete ) {
				DeleteTask();
			}
		}

		private void DeleteTask() {
			if( listViewTasks.SelectedItems.Count == 1 ) {
				DialogResult dr = MessageBox.Show( this, "Wirklich Löschen?", "Aufgabe Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
				
				if( DialogResult.Yes.Equals( dr ) ) {
					ListViewItem lvi = listViewTasks.SelectedItems[0];
					listViewTasks.Items.Remove( lvi );
				}
			}		
		}
	}
}
