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
using OBJ;
using DAL;
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
                Button btn = new Button() { Width = Room_DAL.PTNWith, Height = Room_DAL.PTNHeight };

                btn.Text = item.Floor + Environment.NewLine + item.Floor;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Floor)
                {
                    case "1":
                        btn.Image = Image.FromFile("D:\\in.png");
                        btn.ImageAlign = ContentAlignment.TopCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        //btn.BackColor = Color.LightSteelBlue;

                        break;
                    default:
                        btn.Image = Image.FromFile("D:\\out.png");
                        btn.ImageAlign = ContentAlignment.TopCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
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