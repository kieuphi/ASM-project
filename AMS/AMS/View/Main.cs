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
        private bool IsFormActive(Form form)
        {
            bool IsOpened = false;
            //If There Is More Than One Form Opened
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        // Active This Form
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpened = true;
                    }
                }
            }
            return IsOpened;
        }
        public void Viewchild(Form _form)
        {
            //Check Before Open
            if (!IsFormActive(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmApartment f = new frmApartment();
            f.MdiParent = this;
            f.Show();
        }

        private void btnHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHD f = new frmHD();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnApart_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmApartment f = new frmApartment();
            f.MdiParent = this;
            f.Show();
        }
    }
}