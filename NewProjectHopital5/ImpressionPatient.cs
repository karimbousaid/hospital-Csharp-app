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

namespace NewProjectHopital5
{
    public partial class ImpressionPatient : Form
    {
        public ImpressionPatient()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
    
        SqlDataReader dr;
        private void ImpressionPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OmpressionPatientDataSet.Patient' table. You can move, or remove it, as needed.
            
        }

        private void ImpressionPatient_Load_1(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from [servicee]", cn);
            dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                Spécialitétxt.Items.Add(dr[1]);
            }
            dr.Close();
            cn.Close();
            // TODO: This line of code loads data into the 'ImpressionRDV.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.ImpressionRDV.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.ReqAfficherTest(this.ImpressionRDV.DataTable1,EtatRdvtxt.Text,Spécialitétxt.Text,DateRDVtxt.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
