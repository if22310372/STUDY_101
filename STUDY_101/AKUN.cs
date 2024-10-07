using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDY_101
{
    public partial class AKUN : Form
    {
        public AKUN()
        {
            InitializeComponent();
        }

        private void btnlihatakun_Click(object sender, EventArgs e)
        {
          CrystalReport21.SetParameterValue("AKUN_USER", txtUsername.Text);
            crystalReportViewer1.ReportSource = CrystalReport21;
            crystalReportViewer1.Refresh();
          
        }
    }
}
