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
using DAL;
using VOBJ;
using System.Reflection;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using AMS.Common;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using AMS.View.Login;
using DevExpress.XtraBars;

namespace AMS.View
{
    public partial class frmLoadRoom : DevExpress.XtraEditors.XtraForm
    {
        public frmLoadRoom()
        {
            InitializeComponent();
            loadptn();            
        }
        public string xem;
        public virtual bool AllowRestoreToAutoHideContainer { get; set; }
        void loadptn()
        {
            List<Room_OBJ> ptnlist = Room_DAL.Instance.LoadPTNlist("");

            foreach (Room_OBJ item in ptnlist)
            {
                SimpleButton btn = new SimpleButton() { Width = Room_DAL.PTNWith, Height = Room_DAL.PTNHeight };

                this.barManager1.SetPopupContextMenu(btn, this.popupMenu1);
                //btn.Text = item.RoomName + Environment.NewLine + item.RoomName;
                btn.Text = item.RoomName + Environment.NewLine;
                btn.MouseClick += btn_Click;
                btn.Tag = item;
               
                switch (item.Floor)
                {
                    case "1":
                        btn.ImageOptions.Image = ((System.Drawing.Image)(AMS.Properties.Resources.ArrivalArrowV2_16x16));
                        btn.ImageOptions.Location = ImageLocation.TopLeft;                      
                        btn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                        break;
                    case "3":
                        btn.ImageOptions.Image = ((System.Drawing.Image)(AMS.Properties.Resources.DepArrowV2_16x16));
                        btn.ImageOptions.Location = ImageLocation.BottomRight;
                        btn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                        break;
                    case "2":
                        btn.ImageOptions.Image = ((System.Drawing.Image)(AMS.Properties.Resources.broom_16x16));
                        btn.ImageOptions.Location = ImageLocation.BottomCenter;
                        btn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                        break;

                    default:
                        //btn.Image = Image.FromFile("D:\\RoomMapIconV2\\DepArrowV2_16x16.png");
                        btn.ImageOptions.ImageToTextAlignment = ImageAlignToText.BottomRight;
                       btn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
                        btn.BackColor = Color.GreenYellow;
                        break;
                }

                flbTable.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, MouseEventArgs e)
        {
            AllowRestoreToAutoHideContainer = false;
        }
        private void frmLoadRoom_Load(object sender, EventArgs e)
        {

        }

        void btn_SubCheckIn_ItemClick(object sender, ItemClickEventArgs e)
        {

            //string PtnID = ((sender as SimpleButton).Tag as Room_OBJ).RoomCode;
            //frmLogin f = new frmLogin();
            //f.nanami = PtnID;
            //f.Show();
        }

        private void btn_SubCheckout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}