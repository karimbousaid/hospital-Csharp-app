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
    public partial class AjouterMedecins : Form
    {
        public AjouterMedecins()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        DataTable DtService = new DataTable();
        SqlDataReader dr;
        string sexeM;

        string codeS;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from servicee where [TypeService]='"+Spécialitétxt.SelectedItem+"'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                codeS = dr[0].ToString();
            }
            cn.Close();
            dr.Close();
        }
        SqlTransaction tr;
        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
           tr=cn.BeginTransaction();
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

                SqlCommand cmd3 = new SqlCommand("insert into Medecin values(" + codeS + ",'" + CodeMtxt.Text + "','" + NomMtxt.Text + "','" + PrénomMtxt.Text + "','" + sexeM + "','" + TelephoneMtxt.Text + "','" + AdresseMtxt.Text + "','" + DateEMtxt.Value + "','" + EmailMtxt.Text + "')", cn,tr);
                cmd3.ExecuteNonQuery();
                SqlCommand cmd4 = new SqlCommand("insert into Indisponibilité values('"+CodeMtxt.Text+"','"+DateDtxt.Value+"','"+DateFintxt.Value+"')",cn,tr);
                cmd4.ExecuteNonQuery();              
                tr.Commit();
                MessageBox.Show("Ajouter");
               

            }
            catch
            {
                tr.Rollback();
                MessageBox.Show("pas Ajouter");
            }
            
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterMedecins_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from servicee", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Spécialitétxt.Items.Add(dr[1].ToString());
            }
            cn.Close();
            dr.Close();

            //cmd = new SqlCommand("select * from Medecin", cn);
           


        }
    }
}