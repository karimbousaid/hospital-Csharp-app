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
    public partial class SupprimerServicee : Form
    {
        public SupprimerServicee()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd5 = new SqlCommand("delete  from [dbo].[EtatDePassment] where NumRDV in (select NumRDV from RDV where CodeMedecin in (select CodeMedecin from Medecin where [IdService]=" + NumStxt.Text + "))", cn);
                SqlCommand cmd4 = new SqlCommand("delete  from RDV where [CodeMedecin] in (select CodeMedecin from Medecin where [IdService]=" + NumStxt.Text + ")", cn);
                SqlCommand cmd3 = new SqlCommand("delete  from Indisponibilité where [CodeMedecin] in (select CodeMedecin from Medecin where [IdService]=" + NumStxt.Text + ")", cn);
                SqlCommand cmd2 = new SqlCommand("delete  from Medecin where [IdService]=" + NumStxt.Text + "", cn);
                SqlCommand cmd1 = new SqlCommand("delete  from [servicee] where [IdService]=" + NumStxt.Text + "", cn);
                  DialogResult r = MessageBox.Show("Voulez-vous vriment Supprimer ce Service", "Supprission", MessageBoxButtons.OKCancel);
                  if (r == DialogResult.OK)
                  {
                      cmd5.ExecuteNonQuery();
                      cmd4.ExecuteNonQuery();
                      cmd3.ExecuteNonQuery();
                      cmd2.ExecuteNonQuery();
                      cmd1.ExecuteNonQuery();
                      dataGridView1.Rows.Clear();
                      SqlCommand cmd = new SqlCommand("select * from [servicee]", cn);
                      dr = cmd.ExecuteReader();
                      while (dr.Read())
                      {
                          dataGridView1.Rows.Add(dr[0], dr[1]);
                      }
                  }
              
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Supprission n'est pas réussite");
            }

        }

        private void SupprimerServicee_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from [servicee]", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1]);
            }
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
