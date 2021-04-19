using AMS.VIewData;
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
        private ContractInfo contractInfo;
        private List<ServiceListViewData> serviceViewData;

        public frmPostHouseKeeping(double contractNum)
        {
            InitializeComponent();
            DataHelpers = new DataHelpers();
            servicesOnGrid2 = new List<ServiceList>();
            contractInfo = DataHelpers.GetConTractInfoByContractNum(contractNum);
            textEdit1.Text = contractInfo.FirstName + " " + contractInfo.LastName;
            textEdit2.Text = contractInfo.ContractNum.ToString();
            textEdit3.Text = contractInfo.RoomCode.ToString();
            textEdit5.DateTime = contractInfo.ArrivalDate;
            textEdit6.DateTime = contractInfo.DepartureDate;
            textEdit4.DateTime = contractInfo.ReservationTime;
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

        private void gridView1_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            servicesOnGrid2 = new List<ServiceList>();
            serviceViewData = new List<ServiceListViewData>();
            var select = gridView1.GetSelectedRows();
            foreach (var item in select)
            {
                ServiceList selectvale = (ServiceList)gridView1.GetRow(item);
                ServiceListViewData viewData = new ServiceListViewData() { Code = selectvale.SCode, Name = selectvale.SName, Price = selectvale.Price, Quantity = 1 };
                serviceViewData.Add(viewData);
                servicesOnGrid2.Add(selectvale);
            }
            gridControl2.DataSource = serviceViewData;
        }
    }
}