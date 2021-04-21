using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
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

namespace AMS
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        const string SchedulerDBConnection = "Data Source=DESKTOP-PT7D7GM;Initial Catalog=TEST;Persist Security Info=True;User ID=sa;Password=admin@123!@#";
        DataSet DXSchedulerDataset;
        SqlDataAdapter AppointmentDataAdapter;
        SqlConnection DXSchedulerConn;
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            this.schedulerDataStorage1.Appointments.ResourceSharing = true;
            //this.schedulerControl1.GroupType = SchedulerGroupType.Resource;
            this.schedulerControl1.Start = DateTime.Today;

            DXSchedulerDataset = new DataSet();
            string selectAppointments = "SELECT * FROM Appointments";
            string selectResources = "SELECT * FROM Resources";

            DXSchedulerConn = new SqlConnection(SchedulerDBConnection);
            DXSchedulerConn.Open();

            AppointmentDataAdapter = new SqlDataAdapter(selectAppointments, DXSchedulerConn);
            // Subscribe to RowUpdated event to retrieve identity value for an inserted row.
            AppointmentDataAdapter.RowUpdated += new SqlRowUpdatedEventHandler(AppointmentDataAdapter_RowUpdated);
            AppointmentDataAdapter.Fill(DXSchedulerDataset, "Appointments");

            using (var ResourceDataAdapter = new SqlDataAdapter(selectResources, DXSchedulerConn))
                ResourceDataAdapter.Fill(DXSchedulerDataset, "Resources");

            // Specify mappings.
            MapAppointmentData();
            MapResourceData();

            // Generate commands using CommandBuilder.  
            var cmdBuilder = new SqlCommandBuilder(AppointmentDataAdapter);
            AppointmentDataAdapter.InsertCommand = cmdBuilder.GetInsertCommand();
            AppointmentDataAdapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
            AppointmentDataAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand();

            DXSchedulerConn.Close();

            this.schedulerDataStorage1.Appointments.DataSource = DXSchedulerDataset;
            this.schedulerDataStorage1.Appointments.DataMember = "Appointments";
            this.schedulerDataStorage1.Resources.DataSource = DXSchedulerDataset;
            this.schedulerDataStorage1.Resources.DataMember = "Resources";
        }
        private void MapAppointmentData()
        {
            this.schedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerDataStorage1.Appointments.Mappings.Description = "Description";
            // Required mapping.
            this.schedulerDataStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerDataStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerDataStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            // Required mapping.
            this.schedulerDataStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerDataStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerDataStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerDataStorage1.Appointments.Mappings.Type = "Type";
            this.schedulerDataStorage1.Appointments.Mappings.ResourceId = "ResourceIDs";
          //  this.schedulerDataStorage1.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("MyNote", "CustomField1"));
        }

        private void MapResourceData()
        {
            this.schedulerDataStorage1.Resources.Mappings.Id = "ResourceID";
            this.schedulerDataStorage1.Resources.Mappings.Caption = "ResourceName";
        }

        // Retrieve identity value for an inserted appointment.
        void AppointmentDataAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                int id = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('Appointments')", DXSchedulerConn))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                e.Row["UniqueID"] = id;
            }
        }

        // Store modified data in the database
        private void OnApptChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            AppointmentDataAdapter.Update(DXSchedulerDataset.Tables["Appointments"]);
            DXSchedulerDataset.AcceptChanges();
        }

    }
}