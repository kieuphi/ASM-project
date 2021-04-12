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
    public partial class UCRoom : UserControl
    {
        private int _roomNum;
        private List<User> _inUsers;
        private string _status;
        private string _remark;
        public UCRoom()
        {
            InitializeComponent();
        }
        public string Remark { get; set; }

        #region  initialization
        #endregion
        public int RoomNum
        {
            get { return _roomNum; }
            set
            {
                _roomNum = value;
                UpdateRoomNum();
            }
        }
        private void UpdateRoomNum()
        {
            if (_roomNum == 0)
                return;
            lbl_RoomNum.Text = _roomNum.ToString();
            var width = pnl_Back.Width - lbl_RoomNum.Width;
            if (width < 0)
                width = 0;
            lbl_RoomNum.Location = new Point(width / 3, lbl_RoomNum.Location.Y);
        }
        public List<User> InUsers
        {
            get { return _inUsers; }
            set
            {
                _inUsers = value;
                UpdateInUsers();
            }
        }
        private void UpdateInUsers()
        {
            if (_inUsers == null)
            {
                lbl_RoomUsers.Text = _status.ToString();
                return;
            }
            lbl_RoomUsers.Text = string.Join(",", _inUsers.Select(p => p.UserName).ToList());
            var width = pnl_Back.Width - lbl_RoomUsers.Width;
            if (width < 0)
                width = 0;
            lbl_RoomUsers.Location = new Point(width / 3, lbl_RoomUsers.Location.Y);
        }
        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                UpdateStatus();
            }
        }

        public PictureBox pic
        {
            get
            {
                return background;
            }
        }

        private void UpdateStatus()
        {
            switch (_status)
            {
                case "1":
                    pnl_Back.BackColor = Color.FromArgb(135, 206, 250);

                    pictureBox1.Image = Image.FromFile("..\\..\\..\\..\\Image\\dirtyV2.png", true);
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "2":
                    pnl_Back.BackColor = Color.FromArgb(255, 255, 255);
                    pictureBox2.Image = Image.FromFile(@"D:\SourceTTL\ASM-project\AMS\AMS\Resources\ArrivalArrowV2.png", true);
                    pictureBox3.Image = Image.FromFile(@"D:\SourceTTL\ASM-project\AMS\AMS\Resources\DepArrowV2.png", true);
                    break;

                case "3":
                    pnl_Back.BackColor = Color.FromArgb(255, 255, 255);
                    pictureBox1.Image = Image.FromFile(@"D:\SourceTTL\ASM-project\AMS\AMS\Resources\dirtyV2.png", true);
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "4":
                    pnl_Back.BackColor = Color.FromArgb(255, 255, 255);
                    pictureBox1.Image = Image.FromFile(@"D:\SourceTTL\ASM-project\AMS\AMS\Resources\ExtraBedV2.png", true);
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

                    break;
            }
        }
        public class User
        {
            public string UserName { get; set; }
        }
    }
}
