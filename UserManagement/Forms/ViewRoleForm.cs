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

namespace UserManagement.Forms
{
    public partial class ViewRoleForm : Form
    {

        public ViewRoleForm()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Roles_LoadDataIntoDataGridView", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    DataTable dtRole = new DataTable();

                    SqlDataReader dr = cmd.ExecuteReader();

                    dtRole.Load(dr);

                    RoleDataGridView.DataSource = dtRole;
                }
            }
        }
        private void ViewRoleForm_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewRoleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddRoleForm addRoleForm = new AddRoleForm();
            addRoleForm.Show();
        }

        private void RoleDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RoleDataGridView.Rows.Count > 0)
            {
                int RID = Convert.ToInt32(RoleDataGridView.SelectedRows[0].Cells[0].Value);

                AddRoleForm roleForm = new AddRoleForm();
                roleForm.RoleID= RID;
                roleForm.IsUpdate = true;
                roleForm.ShowDialog();

                LoadDataIntoDataGridView();
            }
        }
    }
}
