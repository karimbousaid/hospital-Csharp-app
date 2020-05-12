using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NewProjectHopital5
{
    public partial class RechercherPatient : Form
    {
        public RechercherPatient()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        string sexeP;
        SqlDataReader dr;
        SqlDataAdapter dA;
        DataTable DtPatient = new DataTable();
        private void RechercherPatient_Load(object sender, EventArgs e)
        {
            dA = new SqlDataAdapter(@"SELECT   dbo.Patient.*, RDV.NumRDV,RDV.[DateRDV], dbo.servicee.TypeService, dbo.Medecin.NomMedecin,dbo.EtatDePassment.EtatD
FROM            dbo.Patient INNER JOIN
                         dbo.EtatDePassment ON dbo.Patient.CodePatient = dbo.EtatDePassment.CodePatient INNER JOIN
                         dbo.RDV ON dbo.Patient.CodePatient = dbo.RDV.CodePatient AND dbo.EtatDePassment.NumRDV = dbo.RDV.NumRDV INNER JOIN
                         dbo.Medecin ON dbo.RDV.CodeMedecin = dbo.Medecin.CodeMedecin INNER JOIN
                         dbo.servicee ON dbo.Medecin.IdService = dbo.servicee.IdService ", cn);
            dA.Fill(DtPatient);
            dataGridView1.DataSource = DtPatient;
            button2.Enabled = false;
            button3.Enabled = false;

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Patient where CodePatient='"+CodePtxt.Text+"'",cn);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {             
                NomPtxt.Text = dr[1].ToString();
                PrénomPtxt.Text = dr[2].ToString();
                sexeP = dr[3].ToString();
                if(sexeP=="H")
                {
                    radioButton1.Checked = true;
                }
                else if (sexeP == "F")
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }
                DateNPtxt.Value =(DateTime)dr[4];
                AdressePtxt.Text = dr[5].ToString();
                TelephonePtxt.Text = dr[6].ToString();
                NomPtxt.Enabled = true;
                PrénomPtxt.Enabled = true;
                AdressePtxt.Enabled = true;
                TelephonePtxt.Enabled = true;
                DateNPtxt.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Patient n'est pas Exists : réessayer ");
            }
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         try
         {
                cn.Open();
                SqlCommand cmd3 = new SqlCommand("delete [EtatDePassment] where CodePatient='" + CodePtxt.Text + "'", cn);
                SqlCommand cmd2 = new SqlCommand("delete RDV where CodePatient='" + CodePtxt.Text + "'", cn);
                SqlCommand cmd = new SqlCommand("delete Patient where CodePatient='" + CodePtxt.Text + "'", cn);
                DialogResult r = MessageBox.Show("Voulez-vous vriment Supprimer ce Patient", "Supprission", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    cmd3.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    button3.Enabled = false;
                    button2.Enabled = false;
                    CodePtxt.Clear();
                    NomPtxt.Clear();
                    PrénomPtxt.Clear();
                    AdressePtxt.Clear();
                    TelephonePtxt.Clear();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    DateNPtxt.Text = DateTime.Now.ToShortDateString();
                }
         
                cn.Close();
                
         }
           catch
            {
                MessageBox.Show("Supprission n'est pas réussite");
            }
        }
            
       
        

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
                try
                {
                    if (radioButton1.Checked == true)
                    {
                        sexeP = "H";
                    }
                    if (radioButton2.Checked == true)
                    {
                        sexeP = "F";
                    }
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("update Patient set [NomPatient]='" + NomPtxt.Text + "', [PrenomPatient]='" + PrénomPtxt.Text + "',[SexePatient]='" + sexeP + "',[DateNaissancePatient]='" + DateNPtxt.Value + "',[AdressePatient]='" + AdressePtxt.Text + "',[TlfPatient]='" + TelephonePtxt.Text + "' where CodePatient='" + CodePtxt.Text + "'", cn);                   
                   DialogResult r = MessageBox.Show("Voulez-vous vriment Modifier les information de ce Patient", "Modification", MessageBoxButtons.OKCancel);
                   if(r==DialogResult.OK)
                   {
                       cmd.ExecuteNonQuery();                   
                       button2.Enabled = false;
                       button3.Enabled = false;
                   }
                   cn.Close();
                }

                catch
                {
                    MessageBox.Show("Modification n'est pas réussite");
                }
            
            
        }
        
        
      

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CodePtxt.Clear();
            NomPtxt.Clear();
            PrénomPtxt.Clear();
            AdressePtxt.Clear();
            TelephonePtxt.Clear();
            DateNPtxt.Text=DateTime.Now.ToShortDateString();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            NomPtxt.Enabled = false;
            PrénomPtxt.Enabled = false;
            AdressePtxt.Enabled = false;
            TelephonePtxt.Enabled = false;
            DateNPtxt.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DtPatient.Rows.Clear();
            dataGridView1.DataSource = DtPatient;
            dA = new SqlDataAdapter(@"SELECT        dbo.Patient.*, RDV.NumRDV,RDV.[DateRDV], dbo.servicee.TypeService, dbo.Medecin.NomMedecin,dbo.EtatDePassment.EtatD
FROM            dbo.Patient INNER JOIN
                         dbo.EtatDePassment ON dbo.Patient.CodePatient = dbo.EtatDePassment.CodePatient INNER JOIN
                         dbo.RDV ON dbo.Patient.CodePatient = dbo.RDV.CodePatient AND dbo.EtatDePassment.NumRDV = dbo.RDV.NumRDV INNER JOIN
                         dbo.Medecin ON dbo.RDV.CodeMedecin = dbo.Medecin.CodeMedecin INNER JOIN
                         dbo.servicee ON dbo.Medecin.IdService = dbo.servicee.IdService ", cn);
            dA.Fill(DtPatient);
            dataGridView1.DataSource = DtPatient;
           
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
