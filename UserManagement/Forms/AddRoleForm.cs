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
    public partial class AddRoleForm : Form
    {
        public int RoleID { get; set; }
        public bool IsUpdate { get; set; }
        public AddRoleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppConnection.GetConnectionString());
        }
        //Handle Update Process
       

        private void AddRoleForm_Load(object sender, EventArgs e)
        {
            if(this.IsUpdate==true) 
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Roles_ReLoadDataIntoDataGridView",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@RoleId", this.RoleID);

                        if(con.State != ConnectionState.Open) 
                            con.Open();

                        DataTable dataRole = new DataTable();

                        SqlDataReader dr = cmd.ExecuteReader();
                        dataRole.Load(dr);

                        DataRow row = dataRole.Rows[0];

                        TitleRoleTextbox.Text= row["RoleTile"].ToString();
                        DescriptionTextbox.Text= row["Description"].ToString();


                    }
                }
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Role_InsertNewRole", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RoleTitle", TitleRoleTextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Description", DescriptionTextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@CreateBy", "Admin");

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Your new role is saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        // Update Control
                        saveButton.Text = "Update Information";

                    }
                }
            }
        }
        private bool isFormValid()
        {
            if (TitleRoleTextbox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Role Title need to be filled", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TitleRoleTextbox.Focus();
                return false;

            }
            return true;
        }

        private void titleroletextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
