
namespace AMS.View.SystemAMS
{
    partial class Splash
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
            this.minimize = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.tasks = new System.Windows.Forms.Label();
            this.bigApp = new System.Windows.Forms.Label();
            this.splashtime = new System.Windows.Forms.Timer(this.components);
            this.appMini = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(359, 6);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(36, 26);
            this.minimize.TabIndex = 9;
            this.minimize.Text = "0";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(394, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 26);
            this.close.TabIndex = 8;
            this.close.Text = "r";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            // 
            // tasks
            // 
            this.tasks.AutoSize = true;
            this.tasks.BackColor = System.Drawing.Color.Transparent;
            this.tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tasks.ForeColor = System.Drawing.Color.White;
            this.tasks.Location = new System.Drawing.Point(12, 198);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(113, 29);
            this.tasks.TabIndex = 7;
            this.tasks.Text = "Starting...";
            // 
            // bigApp
            // 
            this.bigApp.AutoSize = true;
            this.bigApp.BackColor = System.Drawing.Color.Transparent;
            this.bigApp.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bigApp.ForeColor = System.Drawing.Color.White;
            this.bigApp.Location = new System.Drawing.Point(83, 50);
            this.bigApp.Name = "bigApp";
            this.bigApp.Size = new System.Drawing.Size(286, 80);
            this.bigApp.TabIndex = 6;
            this.bigApp.Text = "DI - SMILE";
            // 
            // splashtime
            // 
            this.splashtime.Interval = 1600;
            this.splashtime.Tick += new System.EventHandler(this.splashtime_Tick);
            // 
            // appMini
            // 
            this.appMini.AutoSize = true;
            this.appMini.BackColor = System.Drawing.Color.Transparent;
            this.appMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appMini.ForeColor = System.Drawing.Color.White;
            this.appMini.Location = new System.Drawing.Point(94, 130);
            this.appMini.Name = "appMini";
            this.appMini.Size = new System.Drawing.Size(255, 18);
            this.appMini.TabIndex = 5;
            this.appMini.Text = "Bản quyền thuộc về AMSolutions";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AMS.Properties.Resources.Splash;
            this.ClientSize = new System.Drawing.Size(438, 241);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.tasks);
            this.Controls.Add(this.bigApp);
            this.Controls.Add(this.appMini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label tasks;
        private System.Windows.Forms.Label bigApp;
        private System.Windows.Forms.Timer splashtime;
        private System.Windows.Forms.Label appMini;
    }
}