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

namespace WMSSolution.References.Master_Reference.WarehouseConfiguration
{
    public partial class f_code_list_ref : Form
    {
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; password=nintendo; database=wmsdb; pooling=false");
        private MySqlCommand cmd;
        //private MySqlDataAdapter dap;
        private MySqlTransaction trx;

        public f_code_list_ref()
        {
            InitializeComponent();
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
                cmd = new MySqlCommand("ins_code_list", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //
                cmd.Parameters.AddWithValue("@warehouse_id", txtWarehouseID.Text);
                cmd.Parameters.AddWithValue("@code_id", txtCodeID.Text);
                cmd.Parameters.AddWithValue("@code_group", txtCodeGroup.Text);
                cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@seq", txtSequence.Text);
                cmd.Parameters.AddWithValue("@code_type", cmbType.Text);
                cmd.Parameters.AddWithValue("@external_id", txtExternalID.Text);
                //cmd.Parameters.AddWithValue("@region", txtRegion.Text);
                //cmd.Parameters.AddWithValue("@postal_code", txtPostalCode.Text);
                //cmd.Parameters.AddWithValue("@country", txtCountry.Text);
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

        private void f_code_list_ref_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
        }


    }
}