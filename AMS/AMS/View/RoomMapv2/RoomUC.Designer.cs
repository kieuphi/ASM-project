
namespace AMS.View.RoomMapv2
{
    partial class RoomUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureBox1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureBox3 = new DevExpress.XtraEditors.PictureEdit();
            this.lbl_RoomNum = new System.Windows.Forms.Label();
            this.pnl_Back = new DevExpress.XtraEditors.PanelControl();
            this.lbl_RoomUsers = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_checkIn = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_checkOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_RoomChange = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Back)).BeginInit();
            this.pnl_Back.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(7, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Properties.AllowFocused = false;
            this.pictureBox2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureBox2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureBox2.Properties.ReadOnly = true;
            this.pictureBox2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBox2.Properties.ShowMenu = false;
            this.pictureBox2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureBox2.Size = new System.Drawing.Size(28, 31);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Properties.AllowFocused = false;
            this.pictureBox1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureBox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureBox1.Properties.ReadOnly = true;
            this.pictureBox1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBox1.Properties.ShowMenu = false;
            this.pictureBox1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureBox1.Size = new System.Drawing.Size(25, 31);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(68, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Properties.AllowFocused = false;
            this.pictureBox3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureBox3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureBox3.Properties.ReadOnly = true;
            this.pictureBox3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBox3.Properties.ShowMenu = false;
            this.pictureBox3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureBox3.Size = new System.Drawing.Size(28, 31);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);

            // 
            // lbl_RoomNum
            // 
            this.lbl_RoomNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_RoomNum.AutoSize = true;
            this.lbl_RoomNum.Enabled = false;
            this.lbl_RoomNum.Location = new System.Drawing.Point(34, 10);
            this.lbl_RoomNum.Name = "lbl_RoomNum";
            this.lbl_RoomNum.Size = new System.Drawing.Size(38, 14);
            this.lbl_RoomNum.TabIndex = 0;
            this.lbl_RoomNum.Text = "label1";
            this.lbl_RoomNum.Visible = false;
            // 
            // pnl_Back
            // 
            this.pnl_Back.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Back.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.pnl_Back.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.pnl_Back.Appearance.Options.UseBackColor = true;
            this.pnl_Back.Appearance.Options.UseBorderColor = true;
            this.pnl_Back.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnl_Back.Controls.Add(this.pictureBox1);
            this.pnl_Back.Controls.Add(this.pictureBox3);
            this.pnl_Back.Controls.Add(this.pictureBox2);
            this.pnl_Back.Controls.Add(this.lbl_RoomUsers);
            this.pnl_Back.Controls.Add(this.lbl_RoomNum);
            this.pnl_Back.Controls.Add(this.pictureBox4);
            this.pnl_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Back.Location = new System.Drawing.Point(0, 0);
            this.pnl_Back.Name = "pnl_Back";
            this.pnl_Back.Size = new System.Drawing.Size(107, 101);
            this.pnl_Back.TabIndex = 1;
            this.pnl_Back.Click += new System.EventHandler(this.pnl_Back_Click);
            // 
            // lbl_RoomUsers
            // 
            this.lbl_RoomUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_RoomUsers.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_RoomUsers.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.lbl_RoomUsers.Appearance.Options.UseFont = true;
            this.lbl_RoomUsers.Appearance.Options.UseForeColor = true;
            this.lbl_RoomUsers.Enabled = false;
            this.lbl_RoomUsers.Location = new System.Drawing.Point(14, 69);
            this.lbl_RoomUsers.Name = "lbl_RoomUsers";
            this.lbl_RoomUsers.Size = new System.Drawing.Size(82, 14);
            this.lbl_RoomUsers.TabIndex = 1;
            this.lbl_RoomUsers.Text = "labelControl1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_checkIn,
            this.btn_checkOut,
            this.btn_RoomChange});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 70);
            // 
            // pictureBox4
            // 
            this.pictureBox4.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 101);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp);
            // 
            // btn_checkIn
            // 
            this.btn_checkIn.Image = global::AMS.Properties.Resources.ArrivalArrowV2_16x16;
            this.btn_checkIn.Name = "btn_checkIn";
            this.btn_checkIn.Size = new System.Drawing.Size(153, 22);
            this.btn_checkIn.Text = "Check In";
            this.btn_checkIn.Click += new System.EventHandler(this.btn_checkIn_Click);
            // 
            // btn_checkOut
            // 
            this.btn_checkOut.Image = global::AMS.Properties.Resources.DepArrowV2_16x16;
            this.btn_checkOut.Name = "btn_checkOut";
            this.btn_checkOut.Size = new System.Drawing.Size(153, 22);
            this.btn_checkOut.Text = "Check Out";
            // 
            // btn_RoomChange
            // 
            this.btn_RoomChange.Image = global::AMS.Properties.Resources.RoomStatusV2;
            this.btn_RoomChange.Name = "btn_RoomChange";
            this.btn_RoomChange.Size = new System.Drawing.Size(153, 22);
            this.btn_RoomChange.Text = "Chuyển phòng";
            this.btn_RoomChange.Click += new System.EventHandler(this.btn_RoomChange_Click);
            // 
            // RoomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_Back);
            this.DoubleBuffered = true;
            this.Name = "RoomUC";
            this.Size = new System.Drawing.Size(107, 101);
            this.Click += new System.EventHandler(this.RoomUC_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Back)).EndInit();
            this.pnl_Back.ResumeLayout(false);
            this.pnl_Back.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_RoomNum;
        private DevExpress.XtraEditors.PanelControl pnl_Back;
        private DevExpress.XtraEditors.LabelControl lbl_RoomUsers;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_checkIn;
        private System.Windows.Forms.ToolStripMenuItem btn_checkOut;
        private System.Windows.Forms.ToolStripMenuItem btn_RoomChange;
        private DevExpress.XtraEditors.PictureEdit pictureBox2;
        private DevExpress.XtraEditors.PictureEdit pictureBox1;
        private DevExpress.XtraEditors.PictureEdit pictureBox3;
    }
}
