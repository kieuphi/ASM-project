using AMS.View.RoomMapv2;
using DAL.Common;
using DevExpress.Utils.Menu;
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
using System.Windows.Forms;

namespace DXApplication
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();

            
            //TimeScaleFixedInterval scale10Minus = new TimeScaleFixedInterval(TimeSpan.FromMinutes(10));
            //schedulerControl1.GanttView.Scales.Add(scale10Minus);

            InitAppointments();

            ResourceMappingInfo mappings = schedulerStorage1.Resources.Mappings;
            mappings.Id = "RoomCode";
            mappings.Caption = "RoomName";
            mappings.Caption = "RoomTypeCode";
            schedulerStorage1.Resources.DataSource = GetDataFromDataTableRoom();
            schedulerStorage1.Appointments.DataSource = GetDataFromDataTable();

            schedulerControl1.GanttView.CellsAutoHeightOptions.Enabled = true;
            schedulerControl1.Views.TimelineView.CellsAutoHeightOptions.Enabled = true;
            schedulerControl1.GanttView.ResourcesPerPage = 24;

            this.schedulerControl1.GroupType = SchedulerGroupType.Resource;
            this.schedulerControl1.Start = DateTime.Today;
        }

        private void schedulerControl1_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
        {
            string tinhTrang = e.ViewInfo.Appointment.CustomFields["BookStatus"] + "";
            e.ViewInfo.Appearance.BackColor = tinhTrang == "1" ? Color.Red : Color.Yellow;
        }
        private void InitAppointments()
        {
            AppointmentMappingInfo mappings = schedulerStorage1.Appointments.Mappings;
          //  mappings.AllDay = "true";
            mappings.Start = "ArrivalDate";
            mappings.End = "DepartureDate";
           // mappings.Subject = "TieuDe";
           // mappings.AppointmentId = "ID";
            mappings.ResourceId = "RoomCode";
            // mappings.Description = "LastName";
            mappings.Subject = "LastName";
            mappings.Status = "";
            mappings.Location = "Ten";
            mappings.Description = "CompanyName";
            mappings.PercentComplete = "false";
            // mappings.ReminderInfo = "False";
        }
        ConnectSQL db = new ConnectSQL();
        private DataTable GetDataFromDataTable()
        {

            DataTable table = db.GetData("select N'Booking:'+ ' ' + cast(ContractNum as varchar) + ' - ' + CompanyName as Ten,ContractNum,ContractCode,RoomCode,BookStatus,ArrivalDate,DepartureDate,LastName +' '+ FirstName as LastName from Sale_ContractInfo");
                return table;
        }

        private DataTable GetDataFromDataTableRoom()
        {
            DataTable table = db.GetData("select RoomCode,RoomName,Floor,RowX,ColY,RStatus,ap.RoomTypeCode as RoomTypeCode from APM_Room ap left join APM_RoomType rt on ap.RoomTypeCode = rt.RoomTypeCode");

            return table;
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
                    header.Appearance.HeaderCaption.BackColor = Color.SkyBlue;

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

        private void schedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            e.Menu.RemoveMenuItem(DevExpress.XtraScheduler.SchedulerMenuItemId.TimeScaleEnable);
            e.Menu.RemoveMenuItem(DevExpress.XtraScheduler.SchedulerMenuItemId.TimeScaleVisible);


           Start = schedulerControl1.SelectedInterval.Start;
           End = schedulerControl1.SelectedInterval.End;


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
        public void MyClickHandler(object sender, EventArgs e)
            {

                //DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
                frmInsertRoomPlan f = new frmInsertRoomPlan();
                try
                {
                    f.NgayBD = Start;
                    f.NgayKT = End;
                    // FormNew f = new FormNew();
                    f.ShowDialog();

                }
                finally
                {
                    f.Dispose();
                }

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
