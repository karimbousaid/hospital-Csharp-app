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
    public partial class GestionUtilisateur : Form
    {
        public GestionUtilisateur()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        SqlDataAdapter dr;
        DataTable tU = new DataTable();
        private void GestionUtilisateur_Load(object sender, EventArgs e)
        {
            dr = new SqlDataAdapter("select * from [Utilisateur]", cn);
            dr.Fill(tU);
            dataGridView1.DataSource = tU;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || comboBox1.Text != "")
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("insert into [Utilisateur] values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedItem + "')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("yes");
                }
                catch
                {
                    MessageBox.Show("oh");
                }
            }
            else
            {
                MessageBox.Show("No");
            }
            cn.Close();
        }
        SqlDataReader d;
        private void button5_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from [Utilisateur] where [Nom_user]='"+textBox1.Text+"'",cn);
            d = cmd2.ExecuteReader();
            if(d.Read())
            {
                textBox1.Text = d[1].ToString();
                textBox2.Text = d[2].ToString();
                textBox3.Text = d[3].ToString();
                comboBox1.Text= d[4].ToString();
            }
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("delete from [Utilisateur] where [Nom_user]='" + textBox1.Text + "' ", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("yes");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("update  [Utilisateur] set [ModePasse_user]='" + textBox2.Text + "',Email_user='" + textBox3.Text + "',[Emploi_user]='"+comboBox1.SelectedItem+"' where [Nom_user]='" + textBox1.Text + "' ", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("yes");
        }
    }
}
