using AMS.View.RoomMapv2;
using DAL;
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

namespace AMS.View
{
    public partial class frmLoadRoomVer2 : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<Point, Rectangle> CellRects = new Dictionary<Point, Rectangle>();
        private Dictionary<Point, Rectangle> CellCatRects = new Dictionary<Point, Rectangle>();

        int _colCurrent = 5;
        int _rowCurrent = 6;
        public frmLoadRoomVer2()
        {
            InitializeComponent();
        }
        ConnectSQL DBHelper = new ConnectSQL();


        //void load()
        //  {
        //      string sql = "select RoomCode from APM_Room";
        //      DataTable dt = DBHelper.GetData(sql);

        //      int RoomID = 0;
        //      string RoomState = "";
        //      string Sanname = "";

        //      foreach (DataRow row in dt.Rows)
        //      {
        //          RoomID = Convert.ToInt32(row["RoomCode"]);
        //          string sql1 = string.Format("select RoomCode from APM_Room where RoomCode={0}", RoomID);
        //          DataTable dt1 = DBHelper.GetData(sql1);
        //          RoomState = dt1.Rows[0][0].ToString();
        //          string sql2 = "select RoomName from APM_Room where RoomCode=" + RoomID;
        //          DataTable dt2 = DBHelper.GetData(sql2);

        //          if (dt2.Rows.Count > 0)
        //          {
        //              Sanname = dt2.Rows[0][0].ToString();

        //          }
        //          else
        //          {
        //              Sanname = RoomState;
        //          }

        //          RoomUC roomInfo = new RoomUC()
        //          {
        //              RoomNum = RoomID,
        //              Status = RoomState,
        //              InUsers = RoomID % 7 == 0 ? null : new List<RoomUC.User>()
        //                  {
        //                      new RoomUC.User(){ UserName = Sanname }
        //                  }
        //          };

        //          roomInfo.Name = "Số" + RoomID;
        //          flowLayoutPanel1.Controls.Add(roomInfo);
        //      }

        //var btn = new RoomUC()
        //{
        //    RoomNum = RoomID,
        //    Status = RoomState

        //};
        //  }
        void load()
        {
            int RoomID = 0;
            string RoomState = "";
            List<Room_OBJ> ptnlist = Room_DAL.Instance.LoadPTNlist("");
            foreach (Room_OBJ item in ptnlist)
            {
                int rowIndex = Convert.ToInt32(item.RowX);
                 int colIndex = Convert.ToInt32(item.ColY);
                RoomID = item.RoomCode;
                RoomState = item.Floor;
                //int verticalOffset = 0;
                //foreach (int h in tblLayoutPanel.GetRowHeights())
                //{
                //    int colIndex = Convert.ToInt32(item.ColY);
                //    int horizontalOffset = 0;
                //    foreach (int w in tblLayoutPanel.GetColumnWidths())
                //    {
                //        Rectangle rectangle = new Rectangle(horizontalOffset, verticalOffset, w, h);

                tblLayoutPanel.SuspendTN();
                var btn = new RoomUC()
                {
                    RoomNum = RoomID,
                    Status = RoomState

                };
                // btn.Click += new EventHandler(this.btn_Click);
                // btn.MouseMove += new MouseEventHandler(this.btn_MouseMove);
                tblLayoutPanel.Controls.Add(btn, colIndex, rowIndex);
                        AutoGrid(colIndex, rowIndex);
                        tblLayoutPanel.ResumeTN();
                        //return;

                    //    horizontalOffset += w;
                    //    colIndex++;
                    //}
                    //verticalOffset += h;
                    //rowIndex++;
                //}
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
        private void AutoGrid(int colIndex, int rowIndex)
        {
            var hasChange = false;
            if ((colIndex + 1) == _colCurrent)
            {
                _colCurrent += 1;
                numCol.Value = _colCurrent;
                hasChange = true;
            }
            if ((rowIndex + 1) == _rowCurrent)
            {
                _rowCurrent += 1;
                numRow.Value = _rowCurrent;
                hasChange = true;
            }
            if (hasChange)
            {
                InitTableCell();
            }
        }
        private void frmLoadRoomVer2_Load(object sender, EventArgs e)
        {
            load();
            InitTableCell();
        }
    }
}