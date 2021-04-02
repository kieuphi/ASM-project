using AMS.View.Apartment;
using AMS.View.Service;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS.View
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
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

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(frmApartment));
            if (frm != null)
                frm.Activate();
            else
            {
                frmApartment fr = new frmApartment();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(frmHD));
            if (frm != null)
                frm.Activate();
            else
            {
                frmHD fr = new frmHD();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnApart_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(frmApartment));
            if (frm != null)
                frm.Activate();
            else
            {
                frmApartment fr = new frmApartment();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Form frm = CheckForm(typeof(frmLoadRoom));
            if (frm != null)
                frm.Activate();
            else
            {
                frmLoadRoom fr = new frmLoadRoom();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}