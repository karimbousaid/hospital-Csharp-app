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
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
          if(EmailUser.Text!="")
            {
                SqlCommand cmd = new SqlCommand("select * from [Utilisateur] where Email_user='"+EmailUser.Text+"'", cn);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    UpdatePassword2 p = new UpdatePassword2();
                    p.ShowDialog();
                }
            }
          else
            {
                MessageBox.Show("Email n'est pas Correcte");
            }
            cn.Close();

        }
    }
}
