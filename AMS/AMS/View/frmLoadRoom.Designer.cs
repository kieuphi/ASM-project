
namespace AMS.View
{
    partial class frmLoadRoom
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
            this.flbTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCheckin = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.txtRoomCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flbTable
            // 
            this.flbTable.AutoScroll = true;
            this.flbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flbTable.Location = new System.Drawing.Point(0, 0);
            this.flbTable.Name = "flbTable";
            this.flbTable.Size = new System.Drawing.Size(849, 617);
            this.flbTable.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtRoomCode);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.btnCheckin);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(849, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(303, 617);
            this.panelControl1.TabIndex = 1;
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(9, 5);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(90, 29);
            this.btnCheckin.TabIndex = 0;
            this.btnCheckin.Text = "Check in";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(105, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(89, 29);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Check out";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(200, 5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(89, 29);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "OOO";
            // 
            // txtRoomCode
            // 
            this.txtRoomCode.Location = new System.Drawing.Point(9, 41);
            this.txtRoomCode.Name = "txtRoomCode";
            this.txtRoomCode.Properties.AutoHeight = false;
            this.txtRoomCode.Size = new System.Drawing.Size(280, 29);
            this.txtRoomCode.TabIndex = 1;
            // 
            // frmLoadRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 617);
            this.Controls.Add(this.flbTable);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmLoadRoom";
            this.Text = "Sơ đồ phòng";
            this.Load += new System.EventHandler(this.frmLoadRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flbTable;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnCheckin;
        private DevExpress.XtraEditors.TextEdit txtRoomCode;
    }
}