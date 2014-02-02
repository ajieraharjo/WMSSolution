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

namespace WMSSolution.References.Master_Reference.BusinessPartner
{
    public partial class f_bp_ref : Form
    {
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; password=nintendo; database=wmsdb; pooling=false");
        private MySqlCommand cmd;
        //private MySqlDataAdapter dap;
        private MySqlTransaction trx;
        //
        cls.clsLookUp nclsLookUp = new cls.clsLookUp();

        public f_bp_ref()
        {
            InitializeComponent();
            //
            cmbType.DataSource = nclsLookUp.lookUpforBPType("31337").Tables[0];
            cmbType.DisplayMember = "description";
            cmbType.ValueMember = "code_ID";

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand("ins_bp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //
                cmd.Parameters.AddWithValue("@parent_bp_id", txtParentBPID.Text);
                cmd.Parameters.AddWithValue("@client_id", txtClientID.Text);
                cmd.Parameters.AddWithValue("@bp_id", txtBPID.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@bp_type", cmbType.SelectedValue);
                cmd.Parameters.AddWithValue("@addr_1", txtAddr_1.Text);
                cmd.Parameters.AddWithValue("@addr_2", txtAddr_2.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@postal_code", txtPostalCode.Text);
                cmd.Parameters.AddWithValue("@region", txtRegion.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@telp", txtTelp.Text);
                cmd.Parameters.AddWithValue("@fax", txtFax.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
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
    }
}