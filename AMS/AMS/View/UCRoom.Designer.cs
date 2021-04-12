
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_RoomUsers = new System.Windows.Forms.Label();
            this.lbl_RoomNum = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.PictureBox();
            this.pnl_Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Back
            // 
            this.pnl_Back.Controls.Add(this.pictureBox3);
            this.pnl_Back.Controls.Add(this.pictureBox2);
            this.pnl_Back.Controls.Add(this.pictureBox1);
            this.pnl_Back.Controls.Add(this.lbl_RoomUsers);
            this.pnl_Back.Controls.Add(this.lbl_RoomNum);
            this.pnl_Back.Controls.Add(this.background);
            this.pnl_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Back.Location = new System.Drawing.Point(0, 0);
            this.pnl_Back.Name = "pnl_Back";
            this.pnl_Back.Size = new System.Drawing.Size(105, 96);
            this.pnl_Back.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Location = new System.Drawing.Point(68, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 29);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Location = new System.Drawing.Point(11, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(35, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 38);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_RoomUsers
            // 
            this.lbl_RoomUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_RoomUsers.AutoSize = true;
            this.lbl_RoomUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomUsers.Location = new System.Drawing.Point(32, 78);
            this.lbl_RoomUsers.Name = "lbl_RoomUsers";
            this.lbl_RoomUsers.Size = new System.Drawing.Size(41, 13);
            this.lbl_RoomUsers.TabIndex = 0;
            this.lbl_RoomUsers.Text = "label1";
            // 
            // lbl_RoomNum
            // 
            this.lbl_RoomNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_RoomNum.AutoSize = true;
            this.lbl_RoomNum.Location = new System.Drawing.Point(33, 6);
            this.lbl_RoomNum.Name = "lbl_RoomNum";
            this.lbl_RoomNum.Size = new System.Drawing.Size(35, 13);
            this.lbl_RoomNum.TabIndex = 0;
            this.lbl_RoomNum.Text = "label1";
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.ErrorImage = global::AMS.Properties.Resources.ConnectRoomSL;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(105, 96);
            this.background.TabIndex = 3;
            this.background.TabStop = false;
            // 
            // UCRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_Back);
            this.Name = "UCRoom";
            this.Size = new System.Drawing.Size(105, 96);
            this.pnl_Back.ResumeLayout(false);
            this.pnl_Back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Back;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_RoomUsers;
        private System.Windows.Forms.Label lbl_RoomNum;
        private System.Windows.Forms.PictureBox background;
    }
}
