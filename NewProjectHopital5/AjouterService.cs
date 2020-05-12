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
    public partial class AjouterService : Form
    {
        public AjouterService()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("insert into [servicee] values("+NumeroStxt.Text+",'"+TypeStxt.Text+"')", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Service Ajouter");
                NumeroStxt.Clear();
                TypeStxt.Clear();
                NumeroStxt.Focus();
            }
            catch
            {
                MessageBox.Show("Erreur");

            }
            cn.Close();
        }
    }
}
