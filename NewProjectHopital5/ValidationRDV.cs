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
    public partial class ValidationRDV : Form
    {
        public ValidationRDV()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand(@"
SELECT       Patient.NomPatient,Patient.PrenomPatient,Medecin.NomMedecin,Medecin.PrenomMedecin,servicee.TypeService,RDV.DateRDV,RDV.HeureRDV
FROM            RDV INNER JOIN
                         Patient ON RDV.CodePatient =Patient.CodePatient INNER JOIN
                         Medecin ON RDV.CodeMedecin =Medecin.CodeMedecin INNER JOIN
                         servicee ON Medecin.IdService =servicee.IdService",cn);
            dr = cm.ExecuteReader();

        }
        DataTable dt = new DataTable();
        SqlDataAdapter d;
        SqlDataReader r;

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(@"
SELECT       Patient.NomPatient,Patient.PrenomPatient,Medecin.NomMedecin,Medecin.PrenomMedecin,servicee.TypeService,RDV.DateRDV,RDV.HeureRDV
FROM            RDV  INNER JOIN
                         Patient ON RDV.CodePatient =Patient.CodePatient INNER JOIN
                         Medecin ON RDV.CodeMedecin =Medecin.CodeMedecin INNER JOIN
                   servicee ON Medecin.IdService =servicee.IdService where 
				 RDV.CodePatient='" + CodePtxt.Text + "'", cn);
           r=cmd.ExecuteReader();
            if(r.Read())
            {
                dataGridView1.Rows.Add(r[0],r[1],r[2],r[3],r[4],r[5],r[6]);
                DateRDV.Text=r[5].ToString();
                HeureRDVtxt.Text=r[6].ToString();
            }
            else
            {
                MessageBox.Show("le Patient n'est pas Existes");
            }
            cn.Close();
        }
        string etet;
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBoxValide.Checked == true)
            {
                etet = "Valide";
            }
      if(CodePtxt.Text!="")
            {               
                cn.Open();
                SqlCommand cmd3 = new SqlCommand("update [EtatDePassment] set [EtatD]='" + etet + "' where [CodePatient]='" + CodePtxt.Text + "' and  [NumRDV] in (select [NumRDV] from RDV where [DateRDV]='" + DateRDV.Value + "' and [HeureRDV]='" + HeureRDVtxt.Text + "')", cn);
                cmd3.ExecuteNonQuery();           
                MessageBox.Show("Rendez vous valide");
            }
      else
            {
                MessageBox.Show("Rendez vous Nom valide");
            }
                cn.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
