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

namespace AMS.View
{
    public partial class frmLoadRoomVer2 : DevExpress.XtraEditors.XtraForm
    {
        public frmLoadRoomVer2()
        {
            InitializeComponent();
            try { load(); }
            catch { }
        }
        ConnectSQL DBHelper = new ConnectSQL();

        private void UCRoom_Click(object sender, EventArgs e)
        {
            if (this.ThePicture != null)
            {
                _thePicture.Image = Image.FromFile(@"D:\AMSolutions\ASM-project\AMS\AMS\Resources\ConnectRoomSL.png", true);
                _thePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private PictureBox _thePicture;
        public PictureBox ThePicture
        {
            set { this._thePicture = value; }
            get { return this._thePicture; }
        }

        void load()
        {
            string sql = "select RoomCode from APM_Room";
            DataTable dt = DBHelper.GetData(sql);

            int RoomID = 0;
            string RoomState = "";
            string Sanname = "";

            foreach (DataRow row in dt.Rows)
            {
                RoomID = Convert.ToInt32(row["RoomCode"]);
                string sql1 = string.Format("select RoomCode from APM_Room where RoomCode={0}", RoomID);
                DataTable dt1 = DBHelper.GetData(sql1);
                RoomState = dt1.Rows[0][0].ToString();
                string sql2 = "select RoomName from APM_Room where RoomCode=" + RoomID;
                DataTable dt2 = DBHelper.GetData(sql2);

                if (dt2.Rows.Count > 0)
                {
                    Sanname = dt2.Rows[0][0].ToString();

                }
                else
                {
                    Sanname = RoomState;
                }

                UCRoom roomInfo = new UCRoom()
                {
                    RoomNum = RoomID,
                    Status = RoomState,
                    InUsers = RoomID % 7 == 0 ? null : new List<UCRoom.User>()
                        {
                            new UCRoom.User(){ UserName = Sanname }
                        }
                };
                roomInfo.Tag = RoomID;
                roomInfo.Click += UCRoom_Click;
                roomInfo.Name = "Số" + RoomID;
                flowLayoutPanel1.Controls.Add(roomInfo);
            }
        }
    }
}