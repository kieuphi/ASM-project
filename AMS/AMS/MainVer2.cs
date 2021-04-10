using AMS.View;
using AMS.View.HouseKeeping;
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

namespace AMS
{
    public partial class MainVer2 : DevExpress.XtraEditors.XtraForm
    {
        public MainVer2()
        {
            InitializeComponent();
        }
        Form CheckForm(Type fType)
        {
            foreach (var f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }
        private void MainVer2_Load(object sender, EventArgs e)
        {
            Form frm = CheckForm(typeof(frmLoadRoomVer2));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLoadRoomVer2 fr = new frmLoadRoomVer2();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmPostHouseKeeping fr = new frmPostHouseKeeping();
                fr.Show();
        }
    }
}