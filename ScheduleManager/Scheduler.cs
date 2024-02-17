using DevExpress.XtraBars;
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

namespace ScheduleManager
{
    public partial class Scheduler : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Scheduler()
        {
            InitializeComponent();
        }

        private void Scheduler_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'scDBDataSet.Resources' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.resourcesTableAdapter.Fill(this.scDBDataSet.Resources);
            // TODO: 이 코드는 데이터를 'scDBDataSet.Appointments' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.appointmentsTableAdapter.Fill(this.scDBDataSet.Appointments);
            InitLabels();
        }

        private void schedulerDataStorage1_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(scDBDataSet);
            scDBDataSet.AcceptChanges();
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            ScheduleManager.OutlookAppointmentForm form = new ScheduleManager.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }

        // 라벨 및 상태를 자신의 것으로 대체
        private void InitLabels()
        {
            // Storage대신 DataStorage를 사용.
            // Storage는 이전 버전과의 호환을 위해 사용됨.
//            schedulerControl1.DataStorage.Appointments.Clear();

            string[] IssueList = { "계측기", "현미경", "X-Ray" };    // 라벨 목록 미리 작성
            Color[] IssueColorList = { Color.Ivory, Color.Pink, Color.Plum }; // 라벨의 컬러 미리 작성
            string[] PaymentStatuses = { "Paid", "Unpaid" };           // 상태 목록
            Color[] PaymentColorStatuses = { Color.Green, Color.Red }; // 상태를 브러시로 패턴을 그리려면 커스터마이징 해야 함.

            #region 위에에 라벨, 라벨컬러, 상태, 상태 컬러만 미리 정의해 두면 아래는 신경쓰지 않아도 됨.
            IAppointmentLabelStorage labelStorage = schedulerControl1.DataStorage.Appointments.Labels;
            labelStorage.Clear(); // 라벨을 제거
            int count = IssueList.Length; // 위에서 지정한 배열을 모두 추가
            for (int i = 0; i < count; i++)
            {
                IAppointmentLabel label = labelStorage.CreateNewLabel(i, IssueList[i]); // 새 라벨을 생성
                label.SetColor(IssueColorList[i]); // 새 라벨의 색상 설정
                labelStorage.Add(label); // 목록에 추가
            }
            ISchedulerStorage schedulerStorage = schedulerControl1.DataStorage;
            var statusColl = schedulerStorage.Appointments.Statuses;
            statusColl.Clear();  // 상태를 제거
            count = PaymentStatuses.Length;  // 위에서 지정한 배열을 모두 추가
            for (int i = 0; i < count; i++)
            {
                var status = statusColl.CreateNewStatus(i, PaymentStatuses[i], PaymentStatuses[i]); // 새 상태를 생성
                status.SetBrush(new SolidBrush(PaymentColorStatuses[i])); // 상태의 컬러 (브러시를 생성)
                statusColl.Add(status);
            }

            #endregion 위에에 라벨, 라벨컬러, 상태, 상태 컬러만 미리 정의해 두면 아래는 신경쓰지 않아도 됨. 끝.
        }

        private void Scheduler_Shown(object sender, EventArgs e)
        {

        }
    }
}