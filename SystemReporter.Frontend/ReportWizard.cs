using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemReporter.Frontend
{
    public partial class ReportWizard : Form
    {
        public ReportWizard()
        {
            InitializeComponent();
        }

        private void OnCreate(object sender, EventArgs e)
        {

        }
        private void OnReturn(object sender, EventArgs e)
        {
            Close();
        }
    }
}
