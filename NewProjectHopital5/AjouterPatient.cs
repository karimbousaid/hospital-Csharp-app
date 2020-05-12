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
    public partial class AjouterPatient : Form
    {
        public AjouterPatient()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        string sexeP;
        SqlDataAdapter dA;
        DataTable DtPatient = new DataTable();
        string test;
        int n;
        int n2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (CodePtxt.Text != "" || NomPtxt.Text != "")
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
                    string s = @"insert into Patient values('" + CodePtxt.Text + "','" + NomPtxt.Text + "','" + PrénomPtxt.Text + "','" + sexeP + "','" + DateNPtxt.Value + "','" + AdressePtxt.Text + "','" + TelephonePtxt.Text + "')";
                    SqlCommand cmd4 = new SqlCommand(s, cn);
                    cmd4.ExecuteNonQuery();
                    cn.Close();
                    GestionRDV r = new GestionRDV();
                    r.Code = CodePtxt.Text;
                    r.Nom = NomPtxt.Text;
                    r.Prenom = PrénomPtxt.Text;
                    if (radioButton1.Checked == true)
                    {
                        m = "H";

                    }
                    else if (radioButton2.Checked == true)
                    {
                        m = "F";
                    }
                    r.Sexe = m;
                    this.Hide();
                    r.ShowDialog();



                }

                catch
                {
                    MessageBox.Show("Erreur d'aprendre le Rendez-Vous");
                }

            }
            else
            {
                MessageBox.Show("le code et le Nom de Patient ne doit pas étre vide");

            }
        }





        private void AjouterPatient_Load(object sender, EventArgs e)
        {
            CodePtxt.Enabled = false;
            NomPtxt.Enabled = false;
            PrénomPtxt.Enabled = false;
            AdressePtxt.Enabled = false;
            TelephonePtxt.Enabled = false;
            DateNPtxt.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CodePtxt.Clear();
            NomPtxt.Clear();
            PrénomPtxt.Clear();
            AdressePtxt.Clear();
            TelephonePtxt.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            DateNPtxt.Text = DateTime.Now.ToShortDateString();
            CodePtxt.Enabled = true;
            NomPtxt.Enabled = true;
            PrénomPtxt.Enabled = true;
            AdressePtxt.Enabled = true;
            TelephonePtxt.Enabled = true;
            DateNPtxt.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        string m;
        private void button4_Click_1(object sender, EventArgs e)
        {



        }

        private void button4_Click_2(object sender, EventArgs e)
        {


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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
             && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
             && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}