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

namespace AMS.View.RoomMapv2
{
    public partial class frmChangeRoom : DevExpress.XtraEditors.XtraForm
    {
        public frmChangeRoom()
        {
            InitializeComponent();
        }
        public string Change;
        private void frmChangeRoom_Load(object sender, EventArgs e)
        {
            textBox1.Text = Change;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}