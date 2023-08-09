using System;
using System.Windows.Forms;

namespace SystemReporter.Frontend
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void OnReport(object sender, EventArgs e)
        {
            using (ReportWizard rpfWiz = new ReportWizard())
            {
                rpfWiz.ShowDialog();
            }
        }
        private void OnFilter(object sender, EventArgs e)
        {
            using (FilterWizard fWiz = new FilterWizard())
            {
                fWiz.ShowDialog();
            }
        }
        private void OnFastReport(object sender, EventArgs e)
        {

        }
        private void OnNewFilter(object sender, EventArgs e)
        {

        }
    }
}
