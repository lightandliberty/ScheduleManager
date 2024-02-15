using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowSchedule();
        }

        private void 스케줄러ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSchedule();
        }

        private Scheduler sc;

        private void ShowSchedule()
        {
            if (sc == null || sc.IsDisposed)
            {
                sc = new Scheduler();
                sc.MdiParent = this;
                sc.FormClosing += (s, ea) => { this.Focus(); sc.Dispose(); sc = null; };
                sc.Show();
            }
            else
                sc.Focus();
        }

    }
}
