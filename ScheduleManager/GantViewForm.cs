using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using System.Data.SqlClient;

namespace ScheduleManager
{
    public partial class GantViewForm : Form
    {
        public GantViewForm()
        {
            InitializeComponent();
        }

        private void GantViewForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'scGantDBDataSet.TaskDependencies' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.taskDependenciesTableAdapter.Fill(this.scGantDBDataSet.TaskDependencies);
            // TODO: 이 코드는 데이터를 'scGantDBDataSet.Resources' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.resourcesTableAdapter.Fill(this.scGantDBDataSet.Resources);
            // TODO: 이 코드는 데이터를 'scGantDBDataSet.Appointments' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.appointmentsTableAdapter.Fill(this.scGantDBDataSet.Appointments);

            schedulerControl1.ActiveViewType = SchedulerViewType.Gantt;
            schedulerControl1.GroupType = SchedulerGroupType.Resource;
            schedulerControl1.GanttView.CellsAutoHeightOptions.AutoHeightMode = DevExpress.XtraScheduler.SchedulerCellAutoHeightMode.Limited;
            // Hide unnecessary visual elements.
            schedulerControl1.GanttView.ShowResourceHeaders = false;
            schedulerControl1.GanttView.NavigationButtonVisibility = NavigationButtonVisibility.Never;
            // Disable user sorting in the Resource Tree (clicking the column will not change the sort order).
            colDescription.OptionsColumn.AllowSort = false;
            schedulerControl1.GanttView.ShowResourceHeaders = true;

            schedulerControl1.DataStorage.AppointmentsInserted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsInserted);
            schedulerControl1.DataStorage.AppointmentsChanged += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsChanged);
            schedulerControl1.DataStorage.AppointmentsDeleted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsDeleted);

            schedulerControl1.DataStorage.AppointmentDependenciesInserted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentDependenciesInserted);
            schedulerControl1.DataStorage.AppointmentDependenciesChanged += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentDependenciesChanged);
            schedulerControl1.DataStorage.AppointmentDependenciesDeleted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentDependenciesDeleted);

            schedulerControl1.DataStorage.Appointments.CommitIdToDataSource = false;
            this.appointmentsTableAdapter.Adapter.RowUpdated += new SqlRowUpdatedEventHandler(appointmentsTableAdapter_RowUpdated);

        }

        private void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            CommitTask();
        }

        private void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTask();
        }
        private void schedulerStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {

            CommitTask();
            schedulerControl1.DataStorage.SetAppointmentId(((Appointment)e.Objects[0]), id);
        }

        void CommitTask()
        {

            appointmentsTableAdapter.Update(this.scGantDBDataSet);
            this.scGantDBDataSet.AcceptChanges();
        }

        int id = 0;
        private void appointmentsTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                id = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", appointmentsTableAdapter.Connection))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                    e.Row["UniqueId"] = id;
                }
            }
        }


        private void schedulerStorage1_AppointmentDependenciesChanged(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }

        private void schedulerStorage1_AppointmentDependenciesDeleted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }

        private void schedulerStorage1_AppointmentDependenciesInserted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }
        void CommitTaskDependency()
        {
            taskDependenciesTableAdapter.Update(this.scGantDBDataSet);
            this.scGantDBDataSet.AcceptChanges();
        }

        //taskDependenciesTableAdapter.Update(this.scGantDBDataSet.Tables("TaskDependencies"));
        //this.scGantDBDataSet.Tables("TaskDependencies").AcceptChanges();



    }
}
