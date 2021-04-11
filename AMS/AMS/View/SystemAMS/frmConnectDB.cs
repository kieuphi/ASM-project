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

namespace AMS.View.SystemAMS
{
    public partial class frmConnectDB : DevExpress.XtraEditors.XtraForm
    {
        public frmConnectDB()
        {
            InitializeComponent();
        }

        private void frmConnectDB_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(".");
            comboBox1.Items.Add("(local)");
            comboBox1.Items.Add(@".\SQLEXPRESS");
            comboBox1.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            comboBox1.SelectedIndex = 3;

            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", comboBox1.Text, txtDBName.Text, txtUser.Text, txtPass.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("AMS.Properties.Settings.Setting", connectionString);
                    XtraMessageBox.Show("Bố mày đã lưu rồi nhé con chó !");

                    MainVer2 f = new MainVer2();
                    f.Show();
                    this.Hide();
                }
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra", "Thông báo");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", comboBox1.Text, txtDBName.Text, txtUser.Text, txtPass.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    XtraMessageBox.Show("Kết nối thành công");
                    btnSave.Enabled = true;
                }
            }
            catch
            {
                XtraMessageBox.Show("Có lỗi xảy ra", "Thông báo");
            }
        }
    }
}