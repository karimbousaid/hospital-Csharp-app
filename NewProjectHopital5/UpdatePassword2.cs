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
    public partial class UpdatePassword2 : Form
    {
        public UpdatePassword2()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=KARIM\SQLEXPRESS;Initial Catalog=FirstProjet;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            if(EmailUser.Text!="")
            {
                SqlCommand cmd = new SqlCommand("update [dbo].[Utilisateur] set [Nom_user]='"+Usertxt.Text+"',[ModePasse_user]='"+Passwordtxt.Text+"',[Emploi_user]='"+Jobtxt.SelectedItem+"'",cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("la Modification bien ruéssite");
            }
            else
            {
                MessageBox.Show("la Modification n'est pas ruéssite");
            }
            cn.Close();
        }
    }
}
