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

namespace Gabopver02
{
    public partial class RLogin : Form
    {
        public RLogin()
        {
            InitializeComponent();
            DbConn db1 = new DbConn();

        }

        private void Btn_log_Click(object sender, EventArgs e)
        {
           
            try
            {
                string connectionString = @"Data Source= SDE-02364; Initial Catalog= Gabop_DATA;Integrated Security=true;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM Reception WHERE Recep_ID = '" + BoX_Bruger.Text + "' AND R_AdKo = '" + BoX_Kode.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        Form1 Recmain = new Form1();
                        Recmain.Show();
                    }
                    else
                    {
                        this.Show();
                        MessageBox.Show("Det var forkert login");
                    }
                    // sda1.Dispose();
                    sda.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Der er ikke forbindelse til databasen");
            }



        }

        private void Btn_ext_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
