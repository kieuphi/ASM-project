using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS.View.Login
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main f = new Main();
                f.Show();
        }
        public string nanami;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            f.Show();
            this.Hide();
        }

        private void CreateSimpleButton(int left, int top)
        {
            // Creating and initializing a new SimpleButton control
            SimpleButton simpleButton = new SimpleButton();
            Controls.Add(simpleButton);
            simpleButton.Text = "Show Settings Page";
            //simpleButton.ImageList = imageList1;
            simpleButton.ImageIndex = 0;
            using (var graphics = simpleButton.CreateGraphics())
                simpleButton.Size = simpleButton.CalcBestFit(graphics);
            simpleButton.Location = new Point(left, top);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            textEdit1.Text = nanami;
        }

        //private void simpleButton2_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        XtraMessageBox.Show("con mẹ nó1 ", "THông báo");
        //    }
        //    else//left or middle click
        //    {
        //        XtraMessageBox.Show("con mẹ nó2", "THông báo");
        //    }
        //}

        private void simpleButton2_MouseUp(object sender, MouseEventArgs e)
        {
            XtraMessageBox.Show("con mẹ nó2", "THông báo");
        }
    }
}