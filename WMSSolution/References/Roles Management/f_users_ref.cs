#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
//
using MySql.Data.MySqlClient;

#endregion

namespace WMSSolution.References.Roles_Management
{
    public partial class f_users_ref : Form
    {
        //private MySqlConnection con = new MySqlConnection("server=192.168.1.4;user id=root; password=password; database=wmsdb; pooling=false");
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; password=nintendo; database=wmsdb; pooling=false");
        private MySqlCommand cmd;
        //private MySqlDataAdapter dap;
        private MySqlTransaction trx;
        //
        cls.clsLookUp nclsLookUp = new cls.clsLookUp();

        public f_users_ref()
        {
            InitializeComponent();
            //
            cmbRoleID.DataSource = nclsLookUp.lookUpforRoleID("31337").Tables[0];
            cmbRoleID.DisplayMember = "description";
            cmbRoleID.ValueMember = "code_ID";
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(txtPasswordConfirm.Text) == false) {
                MessageBox.Show("Password Mismatch", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
            try
            {
                con.Open();
                cmd = new MySqlCommand("ins_user", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //
                cmd.Parameters.AddWithValue("@user_id", txtUserID.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role_id", cmbRoleID.SelectedValue);
                cmd.Parameters.AddWithValue("@external_id", txtExternalID.Text);
                cmd.Parameters.AddWithValue("@create_by", "wmsdemo");
                //
                trx = con.BeginTransaction();
                cmd.Transaction = trx;
                cmd.ExecuteNonQuery();
                trx.Commit();
                //
                MessageBox.Show("Transaction Successfully SUBMITED", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                trx.Rollback();
                MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}