namespace DXApplication
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.SchedulerColorSchema schedulerColorSchema1 = new DevExpress.XtraScheduler.SchedulerColorSchema();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeScaleYear timeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
            DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
            DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
            DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
            DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
            DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
            DevExpress.XtraScheduler.TimeScale15Minutes timeScale15Minutes1 = new DevExpress.XtraScheduler.TimeScale15Minutes();
            DevExpress.XtraScheduler.TimeScaleYear timeScaleYear2 = new DevExpress.XtraScheduler.TimeScaleYear();
            DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter2 = new DevExpress.XtraScheduler.TimeScaleQuarter();
            DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth2 = new DevExpress.XtraScheduler.TimeScaleMonth();
            DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek2 = new DevExpress.XtraScheduler.TimeScaleWeek();
            DevExpress.XtraScheduler.TimeScaleDay timeScaleDay2 = new DevExpress.XtraScheduler.TimeScaleDay();
            DevExpress.XtraScheduler.TimeScaleHour timeScaleHour2 = new DevExpress.XtraScheduler.TimeScaleHour();
            DevExpress.XtraScheduler.TimeScale15Minutes timeScale15Minutes2 = new DevExpress.XtraScheduler.TimeScale15Minutes();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.resourcesTree1 = new DevExpress.XtraScheduler.UI.ResourcesTree();
            this.UserAction = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.time = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.resourceTreeColumn1 = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt;
            this.schedulerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.schedulerControl1.DataStorage = this.schedulerStorage1;
            this.schedulerControl1.DateNavigationBar.Visible = false;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            schedulerColorSchema1.Cell = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            schedulerColorSchema1.CellBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            schedulerColorSchema1.CellBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            schedulerColorSchema1.CellLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            schedulerColorSchema1.CellLightBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            schedulerColorSchema1.CellLightBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.schedulerControl1.ResourceColorSchemas.Add(schedulerColorSchema1);
            this.schedulerControl1.Size = new System.Drawing.Size(980, 587);
            this.schedulerControl1.Start = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.AgendaView.Enabled = false;
            this.schedulerControl1.Views.DayView.Enabled = false;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.GanttView.Appearance.AdditionalHeaderCaption.BackColor = System.Drawing.Color.Aqua;
            this.schedulerControl1.Views.GanttView.Appearance.AdditionalHeaderCaption.Options.UseBackColor = true;
            this.schedulerControl1.Views.GanttView.Appearance.AlternateHeaderCaptionLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.schedulerControl1.Views.GanttView.Appearance.AlternateHeaderCaptionLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.schedulerControl1.Views.GanttView.Appearance.AlternateHeaderCaptionLine.Options.UseBackColor = true;
            this.schedulerControl1.Views.GanttView.Appearance.AlternateHeaderCaptionLine.Options.UseBorderColor = true;
            this.schedulerControl1.Views.GanttView.AppointmentDisplayOptions.AppointmentAutoHeight = true;
            this.schedulerControl1.Views.GanttView.AppointmentDisplayOptions.PercentCompleteDisplayType = DevExpress.XtraScheduler.PercentCompleteDisplayType.None;
            this.schedulerControl1.Views.GanttView.CellsAutoHeightOptions.Enabled = true;
            this.schedulerControl1.Views.GanttView.CellsAutoHeightOptions.MinHeight = 10;
            this.schedulerControl1.Views.GanttView.OptionsSelectionBehavior.KeepSelectedAppointments = true;
            this.schedulerControl1.Views.GanttView.ResourcesPerPage = 12;
            timeScaleYear1.Enabled = false;
            timeScaleQuarter1.Enabled = false;
            timeScaleMonth1.DisplayFormat = "MM/yyyy";
            timeScaleWeek1.Enabled = false;
            timeScaleDay1.DisplayFormat = "dd/MM";
            timeScaleDay1.Width = 70;
            timeScaleHour1.Enabled = false;
            timeScale15Minutes1.Enabled = false;
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleYear1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleQuarter1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleMonth1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleWeek1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleDay1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScaleHour1);
            this.schedulerControl1.Views.GanttView.Scales.Add(timeScale15Minutes1);
            this.schedulerControl1.Views.GanttView.SelectionBar.Height = 10;
            this.schedulerControl1.Views.GanttView.SelectionBar.Visible = false;
            this.schedulerControl1.Views.GanttView.ShowResourceHeaders = false;
            this.schedulerControl1.Views.GanttView.WorkTime = new DevExpress.XtraScheduler.WorkTimeInterval(System.TimeSpan.Parse("01:00:00"), System.TimeSpan.Parse("24.00:00:00"));
            this.schedulerControl1.Views.MonthView.Enabled = false;
            this.schedulerControl1.Views.TimelineView.CellsAutoHeightOptions.MinHeight = 16;
            this.schedulerControl1.Views.TimelineView.Enabled = false;
            this.schedulerControl1.Views.TimelineView.ResourcesPerPage = 10;
            timeScaleYear2.Enabled = false;
            timeScaleYear2.Width = 58;
            timeScaleQuarter2.Enabled = false;
            timeScaleQuarter2.Width = 58;
            timeScaleMonth2.Enabled = false;
            timeScaleMonth2.Width = 58;
            timeScaleWeek2.Enabled = false;
            timeScaleWeek2.Width = 58;
            timeScaleDay2.DisplayFormat = "MM/dd/yyyy";
            timeScaleDay2.Width = 58;
            timeScaleHour2.Enabled = false;
            timeScaleHour2.Width = 87;
            timeScale15Minutes2.Enabled = false;
            timeScale15Minutes2.Width = 58;
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleYear2);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleQuarter2);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleMonth2);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleWeek2);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleDay2);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScaleHour2);
            this.schedulerControl1.Views.TimelineView.Scales.Add(timeScale15Minutes2);
            this.schedulerControl1.Views.TimelineView.WorkTime = new DevExpress.XtraScheduler.WorkTimeInterval(System.TimeSpan.Parse("01:00:00"), System.TimeSpan.Parse("24.00:00:00"));
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.AppointmentViewInfoCustomizing += new DevExpress.XtraScheduler.AppointmentViewInfoCustomizingEventHandler(this.schedulerControl1_AppointmentViewInfoCustomizing);
            this.schedulerControl1.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerControl1_PopupMenuShowing);
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
            this.schedulerControl1.CustomDrawDayHeader += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(this.schedulerControl1_CustomDrawDayHeader);
            this.schedulerControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.schedulerControl1_MouseDown);
            this.schedulerControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.schedulerControl1_MouseUp);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("BookStatus", "BookStatus", DevExpress.XtraScheduler.FieldValueType.Integer));
            this.schedulerStorage1.Resources.ColorSaving = DevExpress.XtraScheduler.ColorSavingType.Color;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.resourcesTree1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.schedulerControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1182, 587);
            this.splitContainerControl1.SplitterPosition = 197;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // resourcesTree1
            // 
            this.resourcesTree1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.UserAction,
            this.time,
            this.resourceTreeColumn1});
            this.resourcesTree1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesTree1.Location = new System.Drawing.Point(0, 0);
            this.resourcesTree1.MinWidth = 23;
            this.resourcesTree1.Name = "resourcesTree1";
            this.resourcesTree1.OptionsBehavior.Editable = false;
            this.resourcesTree1.SchedulerControl = this.schedulerControl1;
            this.resourcesTree1.Size = new System.Drawing.Size(197, 587);
            this.resourcesTree1.TabIndex = 0;
            this.resourcesTree1.TreeLevelWidth = 14;
            // 
            // UserAction
            // 
            this.UserAction.AppearanceHeader.Options.UseTextOptions = true;
            this.UserAction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserAction.Caption = "Phòng";
            this.UserAction.FieldName = "RoomCode";
            this.UserAction.MinWidth = 23;
            this.UserAction.Name = "UserAction";
            this.UserAction.Visible = true;
            this.UserAction.VisibleIndex = 0;
            this.UserAction.Width = 97;
            // 
            // time
            // 
            this.time.AppearanceHeader.Options.UseTextOptions = true;
            this.time.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.time.Caption = "Mã";
            this.time.FieldName = "RoomName";
            this.time.MinWidth = 23;
            this.time.Name = "time";
            this.time.Visible = true;
            this.time.VisibleIndex = 1;
            this.time.Width = 98;
            // 
            // resourceTreeColumn1
            // 
            this.resourceTreeColumn1.Caption = "Type";
            this.resourceTreeColumn1.FieldName = "RoomTypeCode";
            this.resourceTreeColumn1.Name = "resourceTreeColumn1";
            this.resourceTreeColumn1.Visible = true;
            this.resourceTreeColumn1.VisibleIndex = 2;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đăng ký";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1182, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 587);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1182, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 587);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1182, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 587);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 587);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Sơ đồ đường";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraScheduler.UI.ResourcesTree resourcesTree1;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn UserAction;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn time;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn resourceTreeColumn1;
    }
}

