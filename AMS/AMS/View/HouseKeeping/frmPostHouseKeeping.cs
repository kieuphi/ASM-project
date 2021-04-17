using DAL.Common;
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
using VOBJ;

namespace AMS.View.HouseKeeping
{
    public partial class frmPostHouseKeeping : DevExpress.XtraEditors.XtraForm
    {
        public DataHelpers DataHelpers;
        private List<ServiceList> servicesOnGrid2;

        public frmPostHouseKeeping()
        {
            InitializeComponent();
            DataHelpers = new DataHelpers();
            servicesOnGrid2 = new List<ServiceList>();
        }

        private void frmPostHouseKeeping_Load(object sender, EventArgs e)
        {
            LoadServiceGroupONsearch();
            var b = DataHelpers.GetAllServiceList();
            gridControl1.DataSource = b;
        }

        private void LoadServiceGroupONsearch()
        {
            var a = DataHelpers.GetAllServiceGroup();
            searchLookUpEdit1.Properties.DataSource = a;
            searchLookUpEdit1.Properties.ValueMember = nameof(ServiceGroup.GroupCode);
            searchLookUpEdit1.Properties.DisplayMember = nameof(ServiceGroup.GroupName);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            servicesOnGrid2 = new List<ServiceList>();
            var select = gridView1.GetSelectedRows();
            foreach (var item in select)
            {
                ServiceList selectvale = (ServiceList)gridView1.GetRow(item);
                servicesOnGrid2.Add(selectvale);
            }
            gridControl2.DataSource = servicesOnGrid2;
        }
    }
}