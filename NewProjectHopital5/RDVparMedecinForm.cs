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
    public partial class RDVparMedecinForm : Form
    {
        public RDVparMedecinForm()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        SqlDataReader dr;
        SqlDataReader dr2;

        private void RDVparMedecinForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
             SqlCommand cmd = new SqlCommand("select * from RDV where CodeMedecin in(select CodeMedecin from Medecin where NomMedecin='" + NomMtxt.Text + "' and PrenomMedecin='"+PrénomMtxt.Text+"')", cn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                dataGridView1.Rows.Add(dr[2], dr[3],dr[4]);
            }
            dr.Close();
            //SqlCommand cmd2 = new SqlCommand("select count(*) from RDV where CodeMedecin in(select CodeMedecin from Medecin having NomMedecin='" + textBox1.Text + "' and PrenomMedecin='" + textBox2.Text + "' group by CodePatient,CodeMedecin)", cn);
            //dr2 = cmd2.ExecuteReader();              
            cn.Close();       
            //dr2.Close();
            //int c = dataGridView1.Rows.Count;
            //label3.Text = c.ToString();
        }
    }
}
