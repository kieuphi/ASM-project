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

namespace AMS.View.Apartment
{
    public partial class frmApartment : DevExpress.XtraEditors.XtraForm
    {
        public frmApartment()
        {
            InitializeComponent();
        }

        private void btnInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmApartment_Insert f = new frmApartment_Insert();
                f.ShowDialog();
        }
    }
}