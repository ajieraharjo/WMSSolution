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

namespace WMSSolution.Outbound
{
    public partial class f_listhelper : Form
    {
        private String table_name;
        private String SQLcommand;
        //
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; password=nintendo; database=wmsdb; pooling=false");
        private MySqlCommand cmd;
        private MySqlDataAdapter dap;
        private MySqlTransaction trx;

        public f_listhelper()
        {
            InitializeComponent();

        }
        private Outbound.f_order nf_order = null;
        public f_listhelper(Form callingForm)
        {
            nf_order = callingForm as Outbound.f_order; 
            InitializeComponent();
        }

        public String table_name_property
        {
            get
	        {
                return this.table_name;
	        }
	        set
	        {
                this.table_name = value;
	        }

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            nf_order.setBillToID(gv.Rows[0].Cells[3].Value.ToString());
        }

        private void cmdCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f_listhelper_Load(object sender, EventArgs e)
        {
            //this.txtID.Text = table_name_property;
            SQLcommand = "select * from " + table_name_property;
            executeCOMMAND(SQLcommand);
        }

        #region "local function and procedure"
        private void executeCOMMAND(string command)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand(command, con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = null;
                gv.DataSource = ds.Tables[0];

                //cmd.Parameters.AddWithValue("@warehouse_id", txtWarehouseID.Text);
                //cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                //cmd.Parameters.AddWithValue("@external_id", txtExternalID.Text);
                //cmd.Parameters.AddWithValue("@addr_1", txtAddress_1.Text);
                //cmd.Parameters.AddWithValue("@addr_2", txtAddress_2.Text);
                //cmd.Parameters.AddWithValue("@state", txtState.Text);
                //cmd.Parameters.AddWithValue("@city", txtCity.Text);
                //cmd.Parameters.AddWithValue("@region", txtRegion.Text);
                //cmd.Parameters.AddWithValue("@postal_code", txtPostalCode.Text);
                //cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                //cmd.Parameters.AddWithValue("@create_by", "wmsdemo");
                //
                //trx = con.BeginTransaction();
                //cmd.Transaction = trx;
                //cmd.ExecuteNonQuery();
                //trx.Commit();
                //
                //MessageBox.Show("Transaction Successfully SUBMITED", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                //trx.Rollback();
                MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }
        #endregion
    }
}