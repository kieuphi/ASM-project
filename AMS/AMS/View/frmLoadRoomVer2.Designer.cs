
namespace AMS.View
{
    partial class frmLoadRoomVer2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.tblLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchControl1);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton6);
            this.panel1.Controls.Add(this.simpleButton5);
            this.panel1.Controls.Add(this.simpleButton7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 48);
            this.panel1.TabIndex = 1;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(4, 7);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.AutoHeight = false;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton(),
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(253, 35);
            this.searchControl1.TabIndex = 6;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = global::AMS.Properties.Resources.ooo;
            this.simpleButton3.Location = new System.Drawing.Point(376, 6);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(105, 37);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "OOO";
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = global::AMS.Properties.Resources.ooo;
            this.simpleButton6.Location = new System.Drawing.Point(488, 6);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(105, 37);
            this.simpleButton6.TabIndex = 3;
            this.simpleButton6.Text = "Chuyển phòng";
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = global::AMS.Properties.Resources.guestbalanceV2;
            this.simpleButton5.Location = new System.Drawing.Point(263, 6);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(105, 37);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "Công nợ";
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageOptions.Image = global::AMS.Properties.Resources.infoV2;
            this.simpleButton7.Location = new System.Drawing.Point(600, 6);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(105, 37);
            this.simpleButton7.TabIndex = 5;
            this.simpleButton7.Text = "Trạng thái";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // tblLayoutPanel
            // 
            this.tblLayoutPanel.AutoScroll = true;
            this.tblLayoutPanel.ColumnCount = 1;
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanel.Location = new System.Drawing.Point(0, 48);
            this.tblLayoutPanel.Name = "tblLayoutPanel";
            this.tblLayoutPanel.RowCount = 1;
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutPanel.Size = new System.Drawing.Size(1030, 579);
            this.tblLayoutPanel.TabIndex = 2;
            // 
            // frmLoadRoomVer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 627);
            this.Controls.Add(this.tblLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Name = "frmLoadRoomVer2";
            this.Text = "frmLoadRoomVer2";
            this.Load += new System.EventHandler(this.frmLoadRoomVer2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanel;
    }
}