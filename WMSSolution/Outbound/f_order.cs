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
    public partial class f_order : Form
    {
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; password=nintendo; database=wmsdb; pooling=false");
        private MySqlCommand cmd;
        //private MySqlDataAdapter dap;
        private MySqlTransaction trx;
        //
        cls.clsLookUp nclsLookUp = new cls.clsLookUp();
        cls.clsSystemNumber nclsSystemNumber = new cls.clsSystemNumber();


        public f_order()
        {
            InitializeComponent();
            fillCombo();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            // save header
            try
            {
                con.Open();
                cmd = new MySqlCommand("ins_order_header", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //
                cmd.Parameters.AddWithValue("@warehouse_id", cmbWarehouseID.SelectedValue);
                cmd.Parameters.AddWithValue("@client_id", cmbClientID.SelectedValue);
                cmd.Parameters.AddWithValue("@order_id", txtOrderNo.Text);
                cmd.Parameters.AddWithValue("@external_id", txtExternalID.Text);
                cmd.Parameters.AddWithValue("@order_type", cmbOrderType.SelectedValue);
                cmd.Parameters.AddWithValue("@order_status", cmbStatus.SelectedValue);
                cmd.Parameters.AddWithValue("@order_priority", cmbPriority.SelectedValue);
                cmd.Parameters.AddWithValue("@order_date", dtpDateOrder.Value);
                cmd.Parameters.AddWithValue("@req_shipmentdate", dtpReqShipment.Value);
                cmd.Parameters.AddWithValue("@actual_shipmentdate", dtpActualShipment.Value);
                cmd.Parameters.AddWithValue("@delivery_date", dtpDateDelivery.Value);
                cmd.Parameters.AddWithValue("@site_id", cmbSiteID.SelectedValue);
                cmd.Parameters.AddWithValue("@customer_id", cmbCustomerID.SelectedValue);
                cmd.Parameters.AddWithValue("@ship_instruction", txtShipInstruction.Text);
                cmd.Parameters.AddWithValue("@shipto_id", txtShipID.Text);
                cmd.Parameters.AddWithValue("@shipto_remarks", txtShip_Remarks.Text);
                cmd.Parameters.AddWithValue("@billto_id", txtBillID.Text);
                cmd.Parameters.AddWithValue("@billto_remarks", txtBill_Remarks.Text);
                cmd.Parameters.AddWithValue("@udf_1", tbControl.Text);
                cmd.Parameters.AddWithValue("@udf_2", txtUDF_2.Text);
                cmd.Parameters.AddWithValue("@udf_3", txtUDF_3.Text);
                cmd.Parameters.AddWithValue("@udf_4", txtUDF_4.Text);
                cmd.Parameters.AddWithValue("@udf_5", txtUDF_5.Text);
                cmd.Parameters.AddWithValue("@notes", txtNotes.Text);
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

        private void cmdCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #region "local function and procedure"
        private void fillCombo()
        {
            cmbWarehouseID.DataSource = nclsLookUp.lookUpforWarehouseID("wmsdemo").Tables[0];
            cmbWarehouseID.DisplayMember = "description";
            cmbWarehouseID.ValueMember = "warehouse_ID";
            //
            cmbClientID.DataSource = nclsLookUp.lookUpforClientID("wmsdemo").Tables[0];
            cmbClientID.DisplayMember = "description";
            cmbClientID.ValueMember = "client_ID";
            //
            cmbStatus.DataSource = nclsLookUp.lookUpforOrderStatus(cmbWarehouseID.SelectedValue.ToString()).Tables[0];
            cmbStatus.DisplayMember = "description";
            cmbStatus.ValueMember = "code_ID";
            //
            cmbOrderType.DataSource = nclsLookUp.lookUpforOrderType(cmbWarehouseID.SelectedValue.ToString()).Tables[0];
            cmbOrderType.DisplayMember = "description";
            cmbOrderType.ValueMember = "code_ID";
            //
            cmbPriority.DataSource = nclsLookUp.lookUpforOrderPriority(cmbWarehouseID.SelectedValue.ToString()).Tables[0];
            cmbPriority.DisplayMember = "description";
            cmbPriority.ValueMember = "code_ID";
        }
        #endregion

        private void cmbWarehouseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            cmbStatus.DataSource = nclsLookUp.lookUpforOrderStatus(cmbWarehouseID.SelectedValue.ToString()).Tables[0];
            cmbStatus.DisplayMember = "description";
            cmbStatus.ValueMember = "code_ID";
            //
            cmbOrderType.DataSource = nclsLookUp.lookUpforOrderType(cmbWarehouseID.SelectedValue.ToString()).Tables[0];
            cmbOrderType.DisplayMember = "description";
            cmbOrderType.ValueMember = "code_ID";
            //
            cmbPriority.DataSource = nclsLookUp.lookUpforOrderPriority(cmbWarehouseID.SelectedValue.ToString()).Tables[0];
            cmbPriority.DisplayMember = "description";
            cmbPriority.ValueMember = "code_ID";
        }

        private void txtOrderNo_KeyUp(object objSender, KeyEventArgs objArgs)
        {
            if (objArgs.KeyData == Keys.F3)
            {
                txtOrderNo.Text = nclsSystemNumber.getSystemNumber("41447", "ORDNBR");
            } 
        }

        private void f_order_KeyUp(object objSender, KeyEventArgs objArgs)
        {

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Outbound.f_order_detail nf_order_detail = new Outbound.f_order_detail(this);
            nf_order_detail.Show();
            //Or.f_test nf_test = new Shipment.f_test(this);
            //nf_test.Show();
        }
        #region "local function and procedure"
        public void writeTitle(string title)
        {
            this.Text = title;
        }
        public void setShipToID(string ID)
        {
            txtShipID.Text = ID;
        }
        public void setBillToID(string ID)
        {
            txtBillID.Text = ID;
        }
        #endregion

        private void lnkShipID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_listhelper nf_listhelper = new f_listhelper(this);
            nf_listhelper.table_name_property = "t_bp where bp_type='SHPTO'";
            nf_listhelper.ShowDialog();
        }

        private void lnkBillID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_listhelper nf_listhelper = new f_listhelper(this);
            nf_listhelper.table_name_property = "t_bp where bp_type='BILLTO'";
            nf_listhelper.ShowDialog();
        }
    }
}