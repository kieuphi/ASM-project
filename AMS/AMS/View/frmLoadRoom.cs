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
namespace AMS.View
{
    public partial class frmLoadRoom : DevExpress.XtraEditors.XtraForm
    {
        public frmLoadRoom()
        {
            InitializeComponent();
            loadptn();
        }
        void loadptn()
        {
            List<Room_OBJ> ptnlist = Room_DAL.Instance.LoadPTNlist("");

            foreach (Room_OBJ item in ptnlist)
            {
                SimpleButton btn = new SimpleButton() { Width = Room_DAL.PTNWith, Height = Room_DAL.PTNHeight };

                //btn.Text = item.RoomName + Environment.NewLine + item.RoomName;
                btn.Text = item.RoomName + Environment.NewLine;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Floor)
                {
                    case "1":
                        btn.Image = Image.FromFile("D:\\in.png");
                        btn.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
                        btn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
                        //btn.BackColor = Color.LightSteelBlue;

                        break;
                    default:
                        btn.Image = Image.FromFile("D:\\out.png");
                        btn.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
                        btn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
                        //btn.BackColor = Color.LightPink;
                        break;
                }

                flbTable.Controls.Add(btn);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            string PtnID = ((sender as Button).Tag as Room_OBJ).RoomCode;


            //gridControl1.DataSource = busts.LayTenTS(" where MAPTN = '" + PtnID + "'");
        }
    }
}