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

namespace VetClinic.View
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Username, Password, IsAdmin FROM [User]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvVetClinic.DataSource = dt;
        }
    }
}
