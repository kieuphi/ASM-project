
namespace AMS.View
{
    partial class UCRoom
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
            this.pnl_Back = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_RoomUsers = new System.Windows.Forms.Label();
            this.lbl_RoomNum = new System.Windows.Forms.Label();
            this.pnl_Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Back
            // 
            this.pnl_Back.Controls.Add(this.pictureBox1);
            this.pnl_Back.Controls.Add(this.lbl_RoomUsers);
            this.pnl_Back.Controls.Add(this.lbl_RoomNum);
            this.pnl_Back.Location = new System.Drawing.Point(16, 19);
            this.pnl_Back.Name = "pnl_Back";
            this.pnl_Back.Size = new System.Drawing.Size(140, 123);
            this.pnl_Back.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 62);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_RoomUsers
            // 
            this.lbl_RoomUsers.AutoSize = true;
            this.lbl_RoomUsers.Location = new System.Drawing.Point(48, 101);
            this.lbl_RoomUsers.Name = "lbl_RoomUsers";
            this.lbl_RoomUsers.Size = new System.Drawing.Size(35, 13);
            this.lbl_RoomUsers.TabIndex = 0;
            this.lbl_RoomUsers.Text = "label1";
            // 
            // lbl_RoomNum
            // 
            this.lbl_RoomNum.AutoSize = true;
            this.lbl_RoomNum.Location = new System.Drawing.Point(48, 16);
            this.lbl_RoomNum.Name = "lbl_RoomNum";
            this.lbl_RoomNum.Size = new System.Drawing.Size(35, 13);
            this.lbl_RoomNum.TabIndex = 0;
            this.lbl_RoomNum.Text = "label1";
            // 
            // UCRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Back);
            this.Name = "UCRoom";
            this.Size = new System.Drawing.Size(179, 157);
            this.pnl_Back.ResumeLayout(false);
            this.pnl_Back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Back;
        private System.Windows.Forms.Label lbl_RoomUsers;
        private System.Windows.Forms.Label lbl_RoomNum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
