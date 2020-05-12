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

namespace NewProjectHopital5.Resources
{
    public partial class CosulterRDVvalide : Form
    {
        public CosulterRDVvalide()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        SqlDataAdapter dr;
        DataTable t = new DataTable();
        string n;
        string n2;
        private void button1_Click(object sender, EventArgs e)
        {
            t.Rows.Clear();
            dataGridView1.DataSource = t;
            if(radioButton1.Checked==true)
            {
                cn.Open();
                dr = new SqlDataAdapter(@"SELECT       Patient.NomPatient,Medecin.NomMedecin,servicee.TypeService,RDV.DateRDV,RDV.HeureRDV,[EtatDePassment].[EtatD]
fROM            RDV  INNER JOIN
                         Patient ON RDV.CodePatient =Patient.CodePatient INNER JOIN
                         Medecin ON RDV.CodeMedecin =Medecin.CodeMedecin INNER JOIN
						 [EtatDePassment] ON [EtatDePassment].[NumRDV]=[RDV].[NumRDV] INNER JOIN
                   servicee ON Medecin.IdService =servicee.IdService where 
				   [EtatDePassment].[EtatD]='Valide' and [RDV].[DateRDV]='" + DateRDVtxt.Value + "'", cn);
                dr.Fill(t);
                if (t.Rows.Count == 0)
                {
                    MessageBox.Show("Rien à été afficher");
                }
                dataGridView1.DataSource = t;
                cn.Close();
            }
            if (radioButton2.Checked == true)
            {
                cn.Open();
                dr = new SqlDataAdapter(@"SELECT       Patient.NomPatient,Medecin.NomMedecin,servicee.TypeService,RDV.DateRDV,RDV.HeureRDV,[EtatDePassment].[EtatD]
fROM            RDV  INNER JOIN
                         Patient ON RDV.CodePatient =Patient.CodePatient INNER JOIN
                         Medecin ON RDV.CodeMedecin =Medecin.CodeMedecin INNER JOIN
						 [EtatDePassment] ON [EtatDePassment].[NumRDV]=[RDV].[NumRDV] INNER JOIN
                   servicee ON Medecin.IdService =servicee.IdService where 
				   [EtatDePassment].[EtatD]='No Valide' and [RDV].[DateRDV]='" + DateRDVtxt.Value + "'", cn);
                dr.Fill(t);
                if (t.Rows.Count == 0)
                {
                    MessageBox.Show("Rien à été afficher");
                }
                dataGridView1.DataSource = t;
                cn.Close();
            }
            if (radioButton3.Checked == true)
            {
                cn.Open();
                dr = new SqlDataAdapter(@"SELECT       Patient.NomPatient,Medecin.NomMedecin,servicee.TypeService,RDV.DateRDV,RDV.HeureRDV,[EtatDePassment].[EtatD]
fROM            RDV  INNER JOIN
                         Patient ON RDV.CodePatient =Patient.CodePatient INNER JOIN
                         Medecin ON RDV.CodeMedecin =Medecin.CodeMedecin INNER JOIN
						 [EtatDePassment] ON [EtatDePassment].[NumRDV]=[RDV].[NumRDV] INNER JOIN
                   servicee ON Medecin.IdService =servicee.IdService where 
				    [RDV].[DateRDV]='" + DateRDVtxt.Value + "'", cn);
                dr.Fill(t);
                if (t.Rows.Count == 0)
                {
                    MessageBox.Show("Rien à été afficher");
                }
                dataGridView1.DataSource = t;
                cn.Close();
            }
           
        }

        private void CosulterRDVvalide_Load(object sender, EventArgs e)
        {

        }
      
    }
}
