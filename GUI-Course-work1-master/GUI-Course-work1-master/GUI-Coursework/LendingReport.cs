using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Coursework
{
    public partial class LendingReport : Form
    {
        //connection to database
        string cs = @"Data Source = Sithumini\SQLEXPRESS; Initial Catalog=LibraryManagementSystem; Integrated Security=True";

        //default constructor
        public LendingReport()
        {
            InitializeComponent();
        }

        //loading form
        private void LendingReport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = @"C:\Users\sithu\OneDrive\Desktop\GUI\GUI-Coursework\GUI-Coursework\LendingCrystalReport.rpt";
        }
    }
}
