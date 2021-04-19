using DAL.Common;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Commands;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Services;
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

namespace AMS.View.RoomMapv2
{
    public partial class frmRoomPlan : DevExpress.XtraEditors.XtraForm
    {
        public frmRoomPlan()
        {
            InitializeComponent();

            InitAppointments();

            ResourceMappingInfo mappings = schedulerStorage1.Resources.Mappings;
            mappings.Id = "RoomCode";
            mappings.Caption = "RoomName";

            schedulerStorage1.Resources.DataSource = GetDataFromDataTableRoom();
            schedulerStorage1.Appointments.DataSource = GetDataFromDataTable();

            schedulerControl1.GanttView.CellsAutoHeightOptions.Enabled = true;
            schedulerControl1.Views.TimelineView.CellsAutoHeightOptions.Enabled = true;
            schedulerControl1.GanttView.ResourcesPerPage = 24;
        }
        private void InitAppointments()
        {
            AppointmentMappingInfo mappings = schedulerStorage1.Appointments.Mappings;
            mappings.AllDay = "true";
            mappings.Start = "GioDen";
            mappings.End = "GioDi";
            mappings.Subject = "TieuDe";
            mappings.AppointmentId = "ID";
            mappings.ResourceId = "IDPhong";
            mappings.Description = "Description";
            mappings.ReminderInfo = "False";
        }
        private DataTable GetDataFromDataTable()
        {

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("IDPhong", typeof(string));
            table.Columns.Add("TieuDe", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("GioDen", typeof(string));
            table.Columns.Add("GioDi", typeof(string));
            table.Columns.Add("TinhTrang", typeof(int));

            table.Rows.Add(25, "A25", "Hydralazine Hydralazine", "Christoff Christoff ", new DateTime(2020, 05, 12, 2, 20, 00), new DateTime(2020, 05, 12, 2, 40, 00), 1);
            table.Rows.Add(30, "A30", "Combivent Hydralazine", "Janet", new DateTime(2020, 05, 12, 3, 20, 00), new DateTime(2020, 05, 12, 3, 40, 00), 2);
            table.Rows.Add(35, "A35", "Overview of formatting ", "Gantt bars look simple enough, but they can get confusing as projects get complex.", new DateTime(2020, 05, 12, 11, 20, 00), new DateTime(2020, 05, 12, 11, 40, 00), 2);
            table.Rows.Add(40, "A40", "What do you want to do?", "Gantt Chart views allow you see", new DateTime(2020, 05, 12, 1, 20, 00), new DateTime(2020, 05, 12, 1, 40, 00), 2);
            table.Rows.Add(45, "A25", "How to change the height of a Gantt chart in amCharts?", "Hi you can use a style tag to do that", new DateTime(2020, 05, 12, 3, 20, 00), new DateTime(2020, 05, 12, 3, 40, 00), 1);
            return table;
        }
        ConnectSQL db = new ConnectSQL();
        private List<Room_OBJ> GetDataFromDataTableRoom()
        {

            List<Room_OBJ> ptnlist = new List<Room_OBJ>();
            DataTable table = db.GetData("select RoomCode,RoomName,Floor,RowX,ColY,RStatus from APM_Room");

            foreach (DataRow item in table.Rows)
            {
                Room_OBJ roommap = new Room_OBJ(item);
                ptnlist.Add(roommap);
            }

            return ptnlist;
        }
        private void schedulerControl1_CustomDrawDayHeader(object sender, CustomDrawObjectEventArgs e)
        {
            if (schedulerControl1.ActiveViewType == SchedulerViewType.Gantt && e.ObjectInfo is DayHeader)
            {
                DayHeader header = e.ObjectInfo as DayHeader;
                string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
                if (header.Caption.Equals(currentDate))
                {
                    header.Appearance.HeaderCaption.Font = new Font("Tahoma", 8F, FontStyle.Bold);
                    header.Appearance.HeaderCaption.BackColor = Color.Red;

                }
            }
        }

        private void schedulerControl1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void schedulerControl1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            //DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            //DXApplication.CustomAppointmentForm f = new DXApplication.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            //try
            //{
            //   // FormNew f = new FormNew();
            //    f.ShowDialog();
            //}
            //finally
            //{
            //    f.Dispose();
            //}

        }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string RoomName { get; set; }
        public void MyClickHandler(object sender, EventArgs e)
        {

            //DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            frmInsertRoomPlan f = new frmInsertRoomPlan();
            try
            {
                f.NgayBD = Start;
                f.NgayKT = End;
                f.tenphong = RoomName;
                // FormNew f = new FormNew();
                f.ShowDialog();

            }
            finally
            {
                f.Dispose();
            }

        }

        private void schedulerControl1_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
        {
            string tinhTrang = e.ViewInfo.Appointment.CustomFields["BookStatus"] + "";
            e.ViewInfo.Appearance.BackColor = tinhTrang == "1" ? Color.Red : Color.Yellow;
        }

        private void schedulerControl1_PopupMenuShowing_1(object sender, PopupMenuShowingEventArgs e)
        {
            e.Menu.RemoveMenuItem(DevExpress.XtraScheduler.SchedulerMenuItemId.TimeScaleEnable);
            e.Menu.RemoveMenuItem(DevExpress.XtraScheduler.SchedulerMenuItemId.TimeScaleVisible);


            Start = schedulerControl1.SelectedInterval.Start;
            End = schedulerControl1.SelectedInterval.End;
            RoomName = schedulerControl1.SelectedResource.Caption;


            if (e.Menu.Id == DevExpress.XtraScheduler.SchedulerMenuItemId.DefaultMenu)
            {
                // Hide the "Change View To" menu item.



                SchedulerPopupMenu itemChangeViewTo = e.Menu.GetPopupMenuById(SchedulerMenuItemId.SwitchViewMenu);
                //itemChangeViewTo.Visible = false;

                // Remove unnecessary items.
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.GotoDate);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.GotoToday);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.ExpandResource);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchToGroupByResource);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.CollapseResource);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringAppointment);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.TimeScaleEnable);
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.TimeScaleVisible);

                // Disable the "New Recurring Appointment" menu item.
                e.Menu.DisableMenuItem(SchedulerMenuItemId.NewRecurringAppointment);

                // Find the "New Appointment" menu item and rename it.
                SchedulerMenuItem item = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment);
                //if (item != null)
                //{
                //    item.Caption = "&New Meeting";
                //    item.ImageOptions.SvgImage = DevExpress.Utils.Svg.SvgImage.FromFile("NewItem.svg");
                //}

                // Create a menu item for the Scheduler command.
                ISchedulerCommandFactoryService service = schedulerControl1.GetService<ISchedulerCommandFactoryService>();
                SchedulerCommand cmd = service.CreateCommand(SchedulerCommandId.SwitchToGroupByResource);
                SchedulerMenuItemCommandWinAdapter menuItemCommandAdapter =
                    new SchedulerMenuItemCommandWinAdapter(cmd);
                DXMenuItem menuItem = (DXMenuItem)menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal);
                menuItem.BeginGroup = true;
                e.Menu.Items.Add(menuItem);

                // Insert a new item into the Scheduler popup menu and handle its click event.
                e.Menu.Items.Add(new SchedulerMenuItem("Đăng Ký", MyClickHandler));
            }
        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }
    }
}