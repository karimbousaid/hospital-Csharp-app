using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProjectHopital5
{
    public partial class ImprimerRDVForm : Form
    {
        public ImprimerRDVForm()
        {
            InitializeComponent();
        }
        private int numRDV;

        public int NumRDV
        {
            get { return numRDV; }
            set { numRDV = value; }
        }
        int variable;
        public void Pass2(int n1)
        {
             variable=n1;
        }
        private void ImprimerRDVForm_Load(object sender, EventArgs e)
        {
            ImprimerRDV r = new ImprimerRDV();
            r.SetParameterValue("NumR", variable);
            crystalReportViewer1.ReportSource = r;
            crystalReportViewer1.Refresh();
        }
    }
}
