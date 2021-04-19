
namespace AMS.View.RoomMapv2
{
    partial class frmInsertRoomPlan
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
            this.tbDescription = new DevExpress.XtraEditors.MemoEdit();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.tbProgress = new DevExpress.XtraEditors.TrackBarControl();
            this.lblPercentCompleteValue = new DevExpress.XtraEditors.LabelControl();
            this.lblPercentComplete = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.edtStartTime = new DevExpress.XtraEditors.TimeEdit();
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.tbSubject = new DevExpress.XtraEditors.TextEdit();
            this.lblLocation = new DevExpress.XtraEditors.LabelControl();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.tbLocation = new DevExpress.XtraEditors.TextEdit();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.lblShowTimeAs = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnRecurrence = new DevExpress.XtraEditors.SimpleButton();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.edtEndTime = new DevExpress.XtraEditors.TimeEdit();
            this.edtShowTimeAs = new DevExpress.XtraScheduler.UI.AppointmentStatusEdit();
            this.cbReminder = new DevExpress.XtraScheduler.UI.DurationEdit();
            this.edtResources = new DevExpress.XtraScheduler.UI.AppointmentResourcesEdit();
            this.edtResource = new DevExpress.XtraScheduler.UI.AppointmentResourceEdit();
            this.lblLabel = new DevExpress.XtraEditors.LabelControl();
            this.lblResource = new DevExpress.XtraEditors.LabelControl();
            this.chkAllDay = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            this.progressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescription.EditValue = "";
            this.tbDescription.Location = new System.Drawing.Point(105, 210);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Properties.AccessibleName = "Message";
            this.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.tbDescription.Size = new System.Drawing.Size(599, 104);
            this.tbDescription.TabIndex = 62;
            // 
            // progressPanel
            // 
            this.progressPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressPanel.Controls.Add(this.tbProgress);
            this.progressPanel.Controls.Add(this.lblPercentCompleteValue);
            this.progressPanel.Controls.Add(this.lblPercentComplete);
            this.progressPanel.Location = new System.Drawing.Point(105, 173);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(599, 34);
            this.progressPanel.TabIndex = 61;
            this.progressPanel.TabStop = true;
            // 
            // tbProgress
            // 
            this.tbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProgress.EditValue = null;
            this.tbProgress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbProgress.Location = new System.Drawing.Point(80, 1);
            this.tbProgress.Margin = new System.Windows.Forms.Padding(0);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Properties.AutoSize = false;
            this.tbProgress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tbProgress.Properties.Maximum = 100;
            this.tbProgress.Properties.ShowValueToolTip = true;
            this.tbProgress.Properties.TickFrequency = 10;
            this.tbProgress.Size = new System.Drawing.Size(468, 31);
            this.tbProgress.TabIndex = 22;
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.AccessibleName = "PercentCompleteValue";
            this.lblPercentCompleteValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentCompleteValue.Appearance.Options.UseBackColor = true;
            this.lblPercentCompleteValue.Location = new System.Drawing.Point(560, 10);
            this.lblPercentCompleteValue.Name = "lblPercentCompleteValue";
            this.lblPercentCompleteValue.Size = new System.Drawing.Size(21, 14);
            this.lblPercentCompleteValue.TabIndex = 23;
            this.lblPercentCompleteValue.Text = "100";
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.AccessibleName = "PercentComplete";
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentComplete.Appearance.Options.UseBackColor = true;
            this.lblPercentComplete.Location = new System.Drawing.Point(0, 10);
            this.lblPercentComplete.Name = "lblPercentComplete";
            this.lblPercentComplete.Size = new System.Drawing.Size(72, 14);
            this.lblPercentComplete.TabIndex = 21;
            this.lblPercentComplete.Text = "% &Complete:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.panel1.Location = new System.Drawing.Point(650, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 103);
            this.panel1.TabIndex = 60;
            // 
            // edtStartTime
            // 
            this.edtStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(456, 87);
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.Properties.AccessibleName = "Start time";
            this.edtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartTime.Size = new System.Drawing.Size(188, 20);
            this.edtStartTime.TabIndex = 54;
            // 
            // edtStartDate
            // 
            this.edtStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(105, 89);
            this.edtStartDate.Name = "edtStartDate";
            this.edtStartDate.Properties.AccessibleName = "Start date";
            this.edtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.edtStartDate.Size = new System.Drawing.Size(248, 20);
            this.edtStartDate.TabIndex = 53;
            // 
            // btnOk
            // 
            this.btnOk.AccessibleName = "Ok";
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.Location = new System.Drawing.Point(105, 344);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 63;
            this.btnOk.Text = "OK";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AccessibleName = "Start time";
            this.lblStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStartTime.Location = new System.Drawing.Point(38, 92);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(56, 14);
            this.lblStartTime.TabIndex = 52;
            this.lblStartTime.Text = "Ngày đến:";
            // 
            // tbSubject
            // 
            this.tbSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSubject.EditValue = "";
            this.tbSubject.Location = new System.Drawing.Point(105, 35);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Properties.AccessibleName = "Subject";
            this.tbSubject.Size = new System.Drawing.Size(599, 20);
            this.tbSubject.TabIndex = 49;
            // 
            // lblLocation
            // 
            this.lblLocation.AccessibleName = "Location";
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocation.Location = new System.Drawing.Point(31, 40);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(63, 14);
            this.lblLocation.TabIndex = 50;
            this.lblLocation.Text = "&Tên Group:";
            // 
            // lblSubject
            // 
            this.lblSubject.AccessibleName = "Subject";
            this.lblSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubject.Location = new System.Drawing.Point(51, 14);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 14);
            this.lblSubject.TabIndex = 48;
            this.lblSubject.Text = "&Số BBK:";
            // 
            // tbLocation
            // 
            this.tbLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLocation.EditValue = "";
            this.tbLocation.Location = new System.Drawing.Point(105, 62);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Properties.AccessibleName = "Location";
            this.tbLocation.Size = new System.Drawing.Size(248, 20);
            this.tbLocation.TabIndex = 51;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AccessibleName = "End time";
            this.lblEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndTime.Location = new System.Drawing.Point(50, 118);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(44, 14);
            this.lblEndTime.TabIndex = 55;
            this.lblEndTime.Text = "Ngày đi:";
            // 
            // lblShowTimeAs
            // 
            this.lblShowTimeAs.AccessibleName = "Show time as";
            this.lblShowTimeAs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowTimeAs.Location = new System.Drawing.Point(16, 144);
            this.lblShowTimeAs.Name = "lblShowTimeAs";
            this.lblShowTimeAs.Size = new System.Drawing.Size(78, 14);
            this.lblShowTimeAs.TabIndex = 58;
            this.lblShowTimeAs.Text = "Sho&w time as:";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "Cancel";
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(193, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleName = "Delete";
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.CausesValidation = false;
            this.btnDelete.Location = new System.Drawing.Point(281, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "&Delete";
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.AccessibleName = "Recurrence";
            this.btnRecurrence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecurrence.Location = new System.Drawing.Point(369, 344);
            this.btnRecurrence.Name = "btnRecurrence";
            this.btnRecurrence.Size = new System.Drawing.Size(75, 23);
            this.btnRecurrence.TabIndex = 66;
            this.btnRecurrence.Text = "&Recurrence";
            // 
            // edtEndDate
            // 
            this.edtEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Location = new System.Drawing.Point(105, 116);
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Properties.AccessibleName = "End date";
            this.edtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.edtEndDate.Size = new System.Drawing.Size(248, 20);
            this.edtEndDate.TabIndex = 56;
            // 
            // edtEndTime
            // 
            this.edtEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(456, 113);
            this.edtEndTime.Name = "edtEndTime";
            this.edtEndTime.Properties.AccessibleName = "End time";
            this.edtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndTime.Size = new System.Drawing.Size(188, 20);
            this.edtEndTime.TabIndex = 57;
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edtShowTimeAs.Location = new System.Drawing.Point(105, 143);
            this.edtShowTimeAs.Name = "edtShowTimeAs";
            this.edtShowTimeAs.Properties.AccessibleName = "Show time as";
            this.edtShowTimeAs.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtShowTimeAs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtShowTimeAs.Size = new System.Drawing.Size(539, 20);
            this.edtShowTimeAs.TabIndex = 59;
            // 
            // cbReminder
            // 
            this.cbReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbReminder.EditValue = "";
            this.cbReminder.Location = new System.Drawing.Point(105, 8);
            this.cbReminder.Name = "cbReminder";
            this.cbReminder.Properties.AccessibleName = "Reminder";
            this.cbReminder.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbReminder.Properties.Appearance.Options.UseBackColor = true;
            this.cbReminder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbReminder.Properties.DisabledStateText = "";
            this.cbReminder.Properties.ShowEmptyItem = false;
            this.cbReminder.Size = new System.Drawing.Size(112, 20);
            this.cbReminder.TabIndex = 67;
            // 
            // edtResources
            // 
            this.edtResources.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edtResources.EditValue = "";
            this.edtResources.Location = new System.Drawing.Point(223, 8);
            this.edtResources.Name = "edtResources";
            this.edtResources.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.edtResources.Properties.Appearance.Options.UseBackColor = true;
            this.edtResources.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = true;
            this.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtResources.ResourcesCheckedListBoxControl.Location = new System.Drawing.Point(0, 0);
            this.edtResources.ResourcesCheckedListBoxControl.Name = "";
            this.edtResources.ResourcesCheckedListBoxControl.Size = new System.Drawing.Size(200, 100);
            this.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0;
            this.edtResources.Size = new System.Drawing.Size(112, 20);
            this.edtResources.TabIndex = 68;
            // 
            // edtResource
            // 
            this.edtResource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edtResource.Location = new System.Drawing.Point(456, 61);
            this.edtResource.Name = "edtResource";
            this.edtResource.Properties.AccessibleName = "Resource";
            this.edtResource.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtResource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edtResource.Size = new System.Drawing.Size(188, 20);
            this.edtResource.TabIndex = 71;
            // 
            // lblLabel
            // 
            this.lblLabel.AccessibleName = "Label";
            this.lblLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Appearance.Options.UseBackColor = true;
            this.lblLabel.Location = new System.Drawing.Point(514, 348);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(32, 14);
            this.lblLabel.TabIndex = 69;
            this.lblLabel.Text = "La&bel:";
            // 
            // lblResource
            // 
            this.lblResource.AccessibleName = "Resource";
            this.lblResource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResource.Location = new System.Drawing.Point(55, 66);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(39, 14);
            this.lblResource.TabIndex = 70;
            this.lblResource.Text = "Phòng:";
            // 
            // chkAllDay
            // 
            this.chkAllDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkAllDay.Location = new System.Drawing.Point(574, 346);
            this.chkAllDay.Name = "chkAllDay";
            this.chkAllDay.Properties.AccessibleName = "All day event";
            this.chkAllDay.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chkAllDay.Properties.AutoWidth = true;
            this.chkAllDay.Properties.Caption = "&All day event";
            this.chkAllDay.Size = new System.Drawing.Size(93, 19);
            this.chkAllDay.TabIndex = 72;
            // 
            // labelControl1
            // 
            this.labelControl1.AccessibleName = "Resource";
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(374, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 70;
            this.labelControl1.Text = "Trạng thái:";
            // 
            // labelControl2
            // 
            this.labelControl2.AccessibleName = "Resource";
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(388, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 14);
            this.labelControl2.TabIndex = 70;
            this.labelControl2.Text = "Giờ đến:";
            // 
            // labelControl3
            // 
            this.labelControl3.AccessibleName = "Resource";
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Location = new System.Drawing.Point(400, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 14);
            this.labelControl3.TabIndex = 70;
            this.labelControl3.Text = "Giờ đi:";
            // 
            // labelControl4
            // 
            this.labelControl4.AccessibleName = "Show time as";
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Location = new System.Drawing.Point(49, 183);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 14);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "Ghi chú:";
            // 
            // frmInsertRoomPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 388);
            this.Controls.Add(this.chkAllDay);
            this.Controls.Add(this.edtResource);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblResource);
            this.Controls.Add(this.edtResources);
            this.Controls.Add(this.cbReminder);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.edtStartTime);
            this.Controls.Add(this.edtStartDate);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lblShowTimeAs);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRecurrence);
            this.Controls.Add(this.edtEndDate);
            this.Controls.Add(this.edtEndTime);
            this.Controls.Add(this.edtShowTimeAs);
            this.Name = "frmInsertRoomPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm phòng";
            this.Load += new System.EventHandler(this.FormNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.MemoEdit tbDescription;
        protected System.Windows.Forms.Panel progressPanel;
        protected DevExpress.XtraEditors.TrackBarControl tbProgress;
        protected DevExpress.XtraEditors.LabelControl lblPercentCompleteValue;
        protected DevExpress.XtraEditors.LabelControl lblPercentComplete;
        protected DevExpress.XtraEditors.PanelControl panel1;
        protected DevExpress.XtraEditors.TimeEdit edtStartTime;
        protected DevExpress.XtraEditors.DateEdit edtStartDate;
        protected DevExpress.XtraEditors.SimpleButton btnOk;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.TextEdit tbSubject;
        protected DevExpress.XtraEditors.LabelControl lblLocation;
        protected DevExpress.XtraEditors.LabelControl lblSubject;
        protected DevExpress.XtraEditors.TextEdit tbLocation;
        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        protected DevExpress.XtraEditors.LabelControl lblShowTimeAs;
        protected DevExpress.XtraEditors.SimpleButton btnCancel;
        protected DevExpress.XtraEditors.SimpleButton btnDelete;
        protected DevExpress.XtraEditors.SimpleButton btnRecurrence;
        protected DevExpress.XtraEditors.DateEdit edtEndDate;
        protected DevExpress.XtraEditors.TimeEdit edtEndTime;
        protected DevExpress.XtraScheduler.UI.AppointmentStatusEdit edtShowTimeAs;
        protected DevExpress.XtraScheduler.UI.DurationEdit cbReminder;
        protected DevExpress.XtraScheduler.UI.AppointmentResourcesEdit edtResources;
        protected DevExpress.XtraScheduler.UI.AppointmentResourceEdit edtResource;
        protected DevExpress.XtraEditors.LabelControl lblLabel;
        protected DevExpress.XtraEditors.LabelControl lblResource;
        protected DevExpress.XtraEditors.CheckEdit chkAllDay;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        protected DevExpress.XtraEditors.LabelControl labelControl2;
        protected DevExpress.XtraEditors.LabelControl labelControl3;
        protected DevExpress.XtraEditors.LabelControl labelControl4;
    }
}