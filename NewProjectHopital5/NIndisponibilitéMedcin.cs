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
    public partial class NIndisponibilitéMedcin : Form
    {
        public NIndisponibilitéMedcin()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
           try
           {
               cn.Open();
               SqlCommand cmd = new SqlCommand("update Indisponibilité set [DateDebut]='"+DateDtxt.Value+"',[DateFin]='"+DateFtxt.Value+"'", cn);
               cmd.ExecuteNonQuery();
               MessageBox.Show("l'indisponibilité de ce Medecin à été Modifier");
           }
            catch
           {
               MessageBox.Show("Erreur");
           }
        }
    }
}
