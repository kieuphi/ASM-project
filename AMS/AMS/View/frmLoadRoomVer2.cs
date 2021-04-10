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
            load();
        }
        ConnectSQL DBHelper = new ConnectSQL();
        void load()
        {
            string sql = "select RoomCode from APM_Room";
            DataTable dt = DBHelper.GetData(sql);
            int Rowx = 0;
            int Columny = 0;
            int RoomID = 0;
            string RoomState = "";
            string Sanname = "";
            foreach (DataRow row in dt.Rows)
            {
                RoomID = Convert.ToInt32(row["RoomCode"]);
                Rowx = Convert.ToInt32(row["RowX"]);
                Columny = Convert.ToInt32(row["ColumnY"]);

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
                roomInfo.Name = "LBL" + RoomID;
                tableLayoutPanel1.Controls.Add(roomInfo);
            }
        }
    }
}