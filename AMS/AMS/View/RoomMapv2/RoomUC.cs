using DAL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS.View.RoomMapv2
{
    
    public partial class RoomUC : UserControl
    {
        private int _roomNum;
        private List<User> _inUsers;
        private string _status;
        private string _remark;
        private string _roomName;

        public event EventHandler ButtonFirstFormClicked;

        public delegate void UserControlClickHandler(object sender, EventArgs e);

        public RoomUC()
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
        public string Roomname
        {
            get { return _roomName; }
            set
            {
                _roomName = value;
                UpdateRoomName();
            }
        }
        private void UpdateRoomName()
        {
            //if (_roomNum == 0)
            //    return;
            lbl_RoomUsers.Text = _roomName.ToString();
            var width = pnl_Back.Width - lbl_RoomUsers.Width;
            if (width < 0)
                width = 0;
            lbl_RoomUsers.Location = new Point(width / 2, lbl_RoomUsers.Location.Y);
        }
        private void UpdateRoomNum()
        {
            if (_roomNum == 0)
                return;
            lbl_RoomNum.Text = _roomNum.ToString();
            var width = pnl_Back.Width - lbl_RoomNum.Width;
            if (width < 0)
                width = 0;
           // lbl_RoomNum.Location = new Point(width / 3, lbl_RoomNum.Location.Y);
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

        private void UpdateStatus()
        {
            switch (_status)
            {
                case "1":
                    pictureBox1.Properties.NullText = " ";
                    pictureBox2.Properties.NullText = " ";
                    pictureBox3.Properties.NullText = " ";
                    pnl_Back.BackColor = Color.FromArgb(135, 206, 250);                 
                    pictureBox1.Image = Image.FromFile("..\\..\\..\\..\\Image\\dirtyV2.png", true);
                    //pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "2":
                    pictureBox1.Properties.NullText = " ";
                    pictureBox2.Properties.NullText = " ";
                    pictureBox3.Properties.NullText = " ";
                    pnl_Back.BackColor = Color.FromArgb(255, 255, 255);
                    pictureBox1.Image = Image.FromFile("..\\..\\..\\..\\Image\\ArrivalArrowV2.png", true);


                   // pictureBox3.Image = Image.FromFile("..\\..\\..\\..\\Image\\DepArrowV2.png", true);
                    break;

                case "3":
                    pictureBox1.Properties.NullText = " ";
                    pictureBox2.Properties.NullText = " ";
                    pictureBox3.Properties.NullText = " ";
                    pnl_Back.BackColor = Color.FromArgb(255, 255, 255);
                    pictureBox1.Image = Image.FromFile("..\\..\\..\\..\\Image\\dirtyV2.png", true);
                    //pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "4":
                    pictureBox1.Properties.NullText = " ";
                    pictureBox2.Properties.NullText = " ";
                    pictureBox3.Properties.NullText = " ";
                    pnl_Back.BackColor = Color.FromArgb(255, 255, 255);
                    pictureBox1.Image = Image.FromFile("..\\..\\..\\..\\Image\\ExtraBedV2.png", true);
                  //  pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

                    break;
                case "0":
                    pictureBox1.Properties.NullText = " ";
                    pictureBox2.Properties.NullText = " ";
                    pictureBox3.Properties.NullText = " ";
                    this.lbl_RoomUsers.Appearance.ForeColor = System.Drawing.Color.Black;
                    pnl_Back.BackColor = Color.FromArgb(192, 192, 192);
                    pictureBox1.Image = Image.FromFile("..\\..\\..\\..\\Image\\company_32px.png", true);
                    break;
            }
        }
        public class User
        {
            public string UserName { get; set; }
        }

        private void pnl_Back_Click(object sender, EventArgs e)
        {

            MessageBox.Show("CMN");
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ButtonFirstFormClicked?.Invoke(sender, e);   
        }
        public void ClearPictureBoxes(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                if (child is PictureBox)
                    ((PictureBox)child).Image = null;
                else
                    ClearPictureBoxes(child);
            }
        }

        private void RoomUC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cmmm");
        }

        private void btn_RoomChange_Click(object sender, EventArgs e)
        {
            frmChangeRoom f = new frmChangeRoom();
            f.Change = Roomname;
            f.Show();
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonFirstFormClicked?.Invoke(sender, e);
            pictureBox4.Image = Image.FromFile("..\\..\\..\\..\\Image\\ConnectRoomSL.png", true);
        }
        ConnectSQL db = new ConnectSQL();
        private void btn_checkIn_Click(object sender, EventArgs e)
        {
            db.ExecuteSQL("update APM_Room set RStatus = '2' where RoomName = '" + Roomname + "'");
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ButtonFirstFormClicked?.Invoke(sender, e);
            pictureBox4.Image = Image.FromFile("..\\..\\..\\..\\Image\\ConnectRoomSL.png", true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ButtonFirstFormClicked?.Invoke(sender, e);
            pictureBox4.Image = Image.FromFile("..\\..\\..\\..\\Image\\ConnectRoomSL.png", true);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            ButtonFirstFormClicked?.Invoke(sender, e);
            pictureBox4.Image = Image.FromFile("..\\..\\..\\..\\Image\\ConnectRoomSL.png", true);
        }

    }
}
