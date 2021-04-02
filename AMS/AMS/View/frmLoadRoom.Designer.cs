
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
            this.SuspendLayout();
            // 
            // flbTable
            // 
            this.flbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flbTable.Location = new System.Drawing.Point(0, 0);
            this.flbTable.Name = "flbTable";
            this.flbTable.Size = new System.Drawing.Size(1152, 617);
            this.flbTable.TabIndex = 0;
            // 
            // frmLoadRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 617);
            this.Controls.Add(this.flbTable);
            this.Name = "frmLoadRoom";
            this.Text = "frmLoadRoom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flbTable;
    }
}