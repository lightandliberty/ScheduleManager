namespace ScheduleManager
{
    partial class GantViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.resourcesTree1 = new DevExpress.XtraScheduler.UI.ResourcesTree();
            this.scGantDBDataSet = new ScheduleManager.scGantDBDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new ScheduleManager.scGantDBDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesTableAdapter = new ScheduleManager.scGantDBDataSetTableAdapters.ResourcesTableAdapter();
            this.taskDependenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskDependenciesTableAdapter = new ScheduleManager.scGantDBDataSetTableAdapters.TaskDependenciesTableAdapter();
            this.colIdSort = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.colId = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.colDescription = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scGantDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDependenciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.resourcesTree1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.schedulerControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(800, 450);
            this.splitContainerControl1.SplitterPosition = 150;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(640, 450);
            this.schedulerControl1.Start = new System.DateTime(2024, 2, 17, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler4);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
            this.schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            this.schedulerDataStorage1.AppointmentDependencies.DataSource = this.taskDependenciesBindingSource;
            this.schedulerDataStorage1.AppointmentDependencies.Mappings.DependentId = "DependentId";
            this.schedulerDataStorage1.AppointmentDependencies.Mappings.ParentId = "ParentId";
            this.schedulerDataStorage1.AppointmentDependencies.Mappings.Type = "Type";
            // 
            // 
            // 
            this.schedulerDataStorage1.Appointments.DataSource = this.appointmentsBindingSource;
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))));
            this.schedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerDataStorage1.Appointments.Mappings.AppointmentId = "UniqueId";
            this.schedulerDataStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerDataStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerDataStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerDataStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerDataStorage1.Appointments.Mappings.PercentComplete = "PercentComplete";
            this.schedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerDataStorage1.Appointments.Mappings.ResourceId = "ResourceId";
            this.schedulerDataStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerDataStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerDataStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerDataStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId";
            this.schedulerDataStorage1.Appointments.Mappings.Type = "Type";
            // 
            // 
            // 
            this.schedulerDataStorage1.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("IdSort", "IdSort"));
            this.schedulerDataStorage1.Resources.DataSource = this.resourcesBindingSource;
            this.schedulerDataStorage1.Resources.Mappings.Caption = "Description";
            this.schedulerDataStorage1.Resources.Mappings.Color = "Color";
            this.schedulerDataStorage1.Resources.Mappings.Id = "Id";
            this.schedulerDataStorage1.Resources.Mappings.Image = "Image";
            this.schedulerDataStorage1.Resources.Mappings.ParentId = "ParentId";
            // 
            // resourcesTree1
            // 
            this.resourcesTree1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIdSort,
            this.colId,
            this.colDescription});
            this.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesTree1.Location = new System.Drawing.Point(0, 0);
            this.resourcesTree1.Name = "resourcesTree1";
            this.resourcesTree1.OptionsBehavior.Editable = false;
            this.resourcesTree1.SchedulerControl = this.schedulerControl1;
            this.resourcesTree1.Size = new System.Drawing.Size(150, 450);
            this.resourcesTree1.TabIndex = 0;
            // 
            // scGantDBDataSet
            // 
            this.scGantDBDataSet.DataSetName = "scGantDBDataSet";
            this.scGantDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.scGantDBDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.scGantDBDataSet;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // taskDependenciesBindingSource
            // 
            this.taskDependenciesBindingSource.DataMember = "TaskDependencies";
            this.taskDependenciesBindingSource.DataSource = this.scGantDBDataSet;
            // 
            // taskDependenciesTableAdapter
            // 
            this.taskDependenciesTableAdapter.ClearBeforeFill = true;
            // 
            // colIdSort
            // 
            this.colIdSort.FieldName = "IdSort";
            this.colIdSort.Name = "colIdSort";
            this.colIdSort.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            // 
            // GantViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "GantViewForm";
            this.Text = "GantViewForm";
            this.Load += new System.EventHandler(this.GantViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scGantDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDependenciesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraScheduler.UI.ResourcesTree resourcesTree1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private scGantDBDataSet scGantDBDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private scGantDBDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private scGantDBDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private System.Windows.Forms.BindingSource taskDependenciesBindingSource;
        private scGantDBDataSetTableAdapters.TaskDependenciesTableAdapter taskDependenciesTableAdapter;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colIdSort;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colId;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colDescription;
    }
}