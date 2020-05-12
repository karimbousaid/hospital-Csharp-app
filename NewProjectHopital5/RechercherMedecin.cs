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
    public partial class RechercherMedecin : Form
    {
        public RechercherMedecin()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        DataTable DtMedecins = new DataTable();
        SqlDataReader drM;
        SqlDataReader drM2;
        string sexeM;
        private void RechercherMedecin_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT        dbo.Medecin.CodeMedecin, dbo.Medecin.NomMedecin, dbo.Medecin.PrenomMedecin, dbo.Medecin.SexeMedecin, dbo.Medecin.TlfMedecin, dbo.Medecin.AdresseMedecin, dbo.Medecin.DateEmbouche, 
                         dbo.Medecin.EmailMedecin, dbo.servicee.TypeService, dbo.Indisponibilité.DateDebut, dbo.Indisponibilité.DateFin
FROM            dbo.Indisponibilité INNER JOIN
                         dbo.Medecin ON dbo.Indisponibilité.CodeMedecin = dbo.Medecin.CodeMedecin INNER JOIN
                         dbo.servicee ON dbo.Medecin.IdService = dbo.servicee.IdService", cn);
            drM = cmd.ExecuteReader();
            while(drM.Read())
            {
                dataGridView1.Rows.Add(drM[0], drM[1], drM[2], drM[3], drM[4], drM[5], drM[6], drM[7], drM[8], drM[9], drM[10]);
            }
            cn.Close();
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                cn.Open();
                SqlCommand cmd2 = new SqlCommand(@"SELECT        dbo.Medecin.*, dbo.Indisponibilité.DateDebut, dbo.Indisponibilité.DateFin
FROM            dbo.Indisponibilité INNER JOIN
                         dbo.Medecin ON dbo.Indisponibilité.CodeMedecin = dbo.Medecin.CodeMedecin where dbo.Medecin.CodeMedecin='" + CodeMtxt.Text + "'", cn);
                drM2 = cmd2.ExecuteReader();
                if (drM2.Read())
                {
                    CodeMtxt.Text = drM2[1].ToString();
                    NomMtxt.Text = drM2[2].ToString();
                    PrénomMtxt.Text = drM2[3].ToString();
                    sexeM = drM2[4].ToString();
                    if (sexeM == "H")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (sexeM == "F")
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                    }
                    Telephonetxt.Text = drM2[5].ToString();
                    Adressetxt.Text = drM2[6].ToString();
                    DateEMtxt.Text = drM2[7].ToString();
                    EmailMtxt.Text = drM2[8].ToString();
                    DateDtxt.Text = drM2[9].ToString();
                    DateFtxt.Text = drM2[10].ToString();
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
                    
            else
                {
                    MessageBox.Show("Ce Medecin n'est pas Existes : réessayer");
                }
                cn.Close();
            }
       
           
        

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    sexeM = "H";
                }
                if (radioButton2.Checked == true)
                {
                    sexeM = "F";
                }
                cn.Open();
                SqlCommand cmd = new SqlCommand("update Medecin set [NomMedecin]='" + NomMtxt.Text + "', [PrenomMedecin]='" + PrénomMtxt.Text + "',[SexeMedecin]='" + sexeM + "',TlfMedecin='" + Telephonetxt.Text + "',[AdresseMedecin]='" + Adressetxt.Text + "',DateEmbouche='" + DateEMtxt.Value + "',[EmailMedecin]='" + EmailMtxt.Text + "' where [CodeMedecin]='" + CodeMtxt.Text + "'", cn);             
                DialogResult r = MessageBox.Show("Voulez-vous vriment Modifier les information de ce Medecin", "Modification", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Modification n'est pas réussite");
            }
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd1 = new SqlCommand("delete from RDV where [CodeMedecin]='" + CodeMtxt.Text + "'", cn);
                SqlCommand cmd2 = new SqlCommand("delete from Indisponibilité where [CodeMedecin]='" + CodeMtxt.Text + "'", cn);
                SqlCommand cmd3 = new SqlCommand("delete from Medecin where [CodeMedecin]='" + CodeMtxt.Text + "'", cn);
                   DialogResult r = MessageBox.Show("Voulez-vous vriment Supprimer ce Medecin", "Supprission", MessageBoxButtons.OKCancel);
                   if (r == DialogResult.OK)
                   {
                       cmd1.ExecuteNonQuery();
                       cmd2.ExecuteNonQuery();
                       cmd3.ExecuteNonQuery();
                       CodeMtxt.Clear();
                       NomMtxt.Clear();
                       PrénomMtxt.Clear();
                       Telephonetxt.Clear();
                       Adressetxt.Clear();
                       EmailMtxt.Clear();                   
                   }
            }
            catch
            {
                MessageBox.Show("Supprission n'est pas réussite");
            }
            cn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT        dbo.Medecin.CodeMedecin, dbo.Medecin.NomMedecin, dbo.Medecin.PrenomMedecin, dbo.Medecin.SexeMedecin, dbo.Medecin.TlfMedecin, dbo.Medecin.AdresseMedecin, dbo.Medecin.DateEmbouche, 
                         dbo.Medecin.EmailMedecin, dbo.servicee.TypeService, dbo.Indisponibilité.DateDebut, dbo.Indisponibilité.DateFin
FROM            dbo.Indisponibilité INNER JOIN
                         dbo.Medecin ON dbo.Indisponibilité.CodeMedecin = dbo.Medecin.CodeMedecin INNER JOIN
                         dbo.servicee ON dbo.Medecin.IdService = dbo.servicee.IdService", cn);
            drM = cmd.ExecuteReader();
            while (drM.Read())
            {
                dataGridView1.Rows.Add(drM[0], drM[1], drM[2], drM[3], drM[4], drM[5], drM[6], drM[7], drM[8], drM[9], drM[10]);
            }
            cn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
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
