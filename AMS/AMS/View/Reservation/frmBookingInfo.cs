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
using System.Data;
using DAL.Common;
using DAL;
using BUS;

namespace AMS.View.Reservation
{
    public partial class frmBookingInfo : DevExpress.XtraEditors.XtraForm
    {
        public frmBookingInfo()
        {
            InitializeComponent();
        }
        ConnectSQL db = new ConnectSQL();
        CompanyDAL comp = new CompanyDAL();
        BookingStatusDAL BkSts = new BookingStatusDAL();
        NationalDAL na = new NationalDAL();
        MarketSegmentDAL marketsg = new MarketSegmentDAL(); 
        MarketChanelDAL marketcn = new MarketChanelDAL();
        BookSourceDAL bks = new BookSourceDAL();
        SaleLocationDAL sl = new SaleLocationDAL();
        RoomTypeDAL rmtype = new RoomTypeDAL();
        RateCodePeriodDAL RateP = new RateCodePeriodDAL();

        private void frmBookingInfo_Load(object sender, EventArgs e)
        {
            slkCongTy.Properties.DataSource = comp.GetList_Company("");
            slkCongTy.Properties.ValueMember = "CompanyCode";
            slkCongTy.Properties.DisplayMember = "CompanyName";

            slkTrangThai.Properties.DataSource = BkSts.Get_ListBookingStatus("");
            slkTrangThai.Properties.ValueMember = "StsCode";
            slkTrangThai.Properties.DisplayMember = "Description";

            slkQuocTich.Properties.DataSource = na.GetList_National("");
            slkQuocTich.Properties.ValueMember = "Code";
            slkQuocTich.Properties.DisplayMember = "Description";

            slkPKTT.Properties.DataSource = marketsg.GetList_MarketSegment("");
            slkPKTT.Properties.ValueMember = "Code";
            slkPKTT.Properties.DisplayMember = "Description";

            slkKenhPhanPhoi.Properties.DataSource = marketcn.GetList_MarkerChanel("");
            slkKenhPhanPhoi.Properties.ValueMember = "Code";
            slkKenhPhanPhoi.Properties.DisplayMember = "Description";

            slkNguonKhach.Properties.DataSource = bks.GetList_BookSource("");
            slkNguonKhach.Properties.ValueMember = "Code";
            slkNguonKhach.Properties.DisplayMember = "Description";

            slkKhuVuc.Properties.DataSource = sl.GetList_SaleLocation("");
            slkKhuVuc.Properties.ValueMember = "Code";
            slkKhuVuc.Properties.DisplayMember = "Description";

            slkLoaiPhong.Properties.DataSource = rmtype.GetList_RoomType("");
            slkLoaiPhong.Properties.ValueMember = "Code";
            slkLoaiPhong.Properties.DisplayMember = "Description";

            slkLoaiGia.Properties.DataSource = RateP.GetList_RatePriod("");
            slkLoaiGia.Properties.ValueMember = "RateCode";
            slkLoaiGia.Properties.DisplayMember = "Description";

            txtMasterContractNum.DataBindings.Add("Text", db.GetData("select dbo.UF_GetMasterID() as Fill "), "Fill");
            txtContractNum.DataBindings.Add("Text", db.GetData("select dbo.UF_GetID() as Fill "), "Fill");



        }


        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void ckGIT_Properties_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGIT.Checked)
            {
                ckFIT.Checked = false;
            }
            else
            {
                ckFIT.Checked = true;
            }    
        }

        private void ckFIT_Properties_CheckedChanged(object sender, EventArgs e)
        {
            if(ckFIT.Checked)
            {
                ckGIT.Checked = false;
            }
            else
            {
                ckGIT.Checked = true;
            }
          
        }

        private void txtMasterContractNum_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}