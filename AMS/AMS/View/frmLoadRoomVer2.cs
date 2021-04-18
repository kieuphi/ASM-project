using AMS.View.Login;
using AMS.View.RoomMapv2;
using DAL;
using DAL.Common;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VOBJ;

namespace AMS.View
{
    public partial class frmLoadRoomVer2 : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<Point, Rectangle> CellRects = new Dictionary<Point, Rectangle>();
        private Dictionary<Point, Rectangle> CellCatRects = new Dictionary<Point, Rectangle>();

        int _colCurrent = 0;
        int _rowCurrent = 0;
        public frmLoadRoomVer2()
        {
            InitializeComponent();
        }
        ConnectSQL DBHelper = new ConnectSQL();


        private void btn_Click(object sender, EventArgs e)
        {
            RoomUC form1 = new RoomUC();
            form1.ClearPictureBoxes(tblLayoutPanel);
        }
        private void btn_MouseUp(object sender, EventArgs e)
        {
            RoomUC form1 = new RoomUC();
            form1.ClearPictureBoxes(tblLayoutPanel);
        }
        void load()
        {

            int RoomID = 0;
            string RoomState = "";
            string RoomName = "";
            List<Room_OBJ> ptnlist = Room_DAL.Instance.LoadPTNlist("");
            foreach (Room_OBJ item in ptnlist)
            {
                int rowIndex = Convert.ToInt32(item.RowX);
                int colIndex = Convert.ToInt32(item.ColY);
                RoomID = item.RoomCode;
                RoomState = item.RStatus;
                RoomName = item.RoomName;

                tblLayoutPanel.SuspendTN();
                RoomUC btn = new RoomUC
                {
                    Roomname = RoomName,
                    Status = RoomState
                };
                btn.ButtonFirstFormClicked += btn_Click;
               // btn.MouseUpClicked += btn_MouseUp;
                tblLayoutPanel.Controls.Add(btn, colIndex, rowIndex);
                // AutoGrid(colIndex, rowIndex);
                tblLayoutPanel.ResumeTN();
            }

        }
        private void InitTableCell()
        {
            var colCount = _colCurrent;
            var rowCount = _rowCurrent;

            tblLayoutPanel.SuspendTN();

            tblLayoutPanel.ColumnStyles.Clear();
            tblLayoutPanel.RowStyles.Clear();

            tblLayoutPanel.ColumnCount = colCount;
            tblLayoutPanel.RowCount = rowCount;

            var fW = 100f;
            var fH = 100f;

            var width = fW / colCount;
            var height = fH / rowCount;
            for (int r = 0; r < rowCount; r++)
            {
                this.tblLayoutPanel.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, height));
            }
            for (int c = 0; c < colCount; c++)
            {
                this.tblLayoutPanel.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, width));
            }
            tblLayoutPanel.ResumeTN();
        }
        private void frmLoadRoomVer2_Load(object sender, EventArgs e)
        {
            load();
            InitTableCell();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            DBHelper.ExecuteSQL("update APM_Room set RStatus = '2' where RoomName = '106");
            load();
        }
    }
}