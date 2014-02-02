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

namespace WMSSolution.References.Master_Reference
{
    public partial class f_items_ref : Form
    {
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; password=nintendo; database=wmsdb; pooling=false");
        private MySqlCommand cmd;
        //private MySqlDataAdapter dap;
        private MySqlTransaction trx;
        //
        cls.clsLookUp nclsLookUp = new cls.clsLookUp();

        public f_items_ref()
        {
            InitializeComponent();
            fillCombo();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand("ins_parts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //
                cmd.Parameters.AddWithValue("@client_ID", cmbClientID.SelectedValue);
                cmd.Parameters.AddWithValue("@part_ID",  txtPartID.Text);
                cmd.Parameters.AddWithValue("@description",  txtDescription.Text);
                cmd.Parameters.AddWithValue("@completed",(chkCompleted.Checked) ? 1 : 0);
                cmd.Parameters.AddWithValue("@active", (chkActive.Checked) ? 1 : 0);
                cmd.Parameters.AddWithValue("@part_division", cmbPartDivision.SelectedValue);
                cmd.Parameters.AddWithValue("@part_group", cmbPartGroup.SelectedValue);
                cmd.Parameters.AddWithValue("@part_family", cmbPartFamily.SelectedValue);
                cmd.Parameters.AddWithValue("@part_abc_category", cmbABCCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@non_inventory_flag", (chkNonInventoryIndicator.Checked) ? 1 : 0);
                cmd.Parameters.AddWithValue("@base_uom", cmbBaseUom.SelectedValue);
                cmd.Parameters.AddWithValue("@part_type", cmbMaterialType.SelectedValue);
                cmd.Parameters.AddWithValue("@net_weight", txtNetWeight.Text);
                cmd.Parameters.AddWithValue("@gross_weight", txtGrossWeight.Text);
                cmd.Parameters.AddWithValue("@length", txtLength.Text);
                cmd.Parameters.AddWithValue("@width", txtWidth.Text);
                cmd.Parameters.AddWithValue("@height", txtHeight.Text);
                cmd.Parameters.AddWithValue("@lottable_control_ID", cmbLottableControl.SelectedValue);
                cmd.Parameters.AddWithValue("@shelf_life", (chkShelfLife.Checked) ? 1 : 0);
                cmd.Parameters.AddWithValue("@aging_profile_ID", cmbAgingProfile.SelectedValue);
                cmd.Parameters.AddWithValue("@inv_status_default", cmbInventoryStatusDefault.SelectedValue);
                cmd.Parameters.AddWithValue("@sn_cap_in", (chkSNCap_in.Checked) ? 1 : 0);
                cmd.Parameters.AddWithValue("@weight_cap_in", (chkCapWeight_in.Checked) ? 1 : 0);
                cmd.Parameters.AddWithValue("@putaway_instruction", txtPutawayInstruction.Text);
                cmd.Parameters.AddWithValue("@allocation_strategy", cmbAllocationStrategy.SelectedValue);
                cmd.Parameters.AddWithValue("@sn_cap_out", (chkCapSN_out.Checked) ? 1 : 0);
                cmd.Parameters.AddWithValue("@weight_cap_out",(chkWeight_out.Checked) ? 1 : 0);
                cmd.Parameters.AddWithValue("@picking_instruction", txtPickingInstruction.Text);
                cmd.Parameters.AddWithValue("@udf_1", txtUDF_1.Text);
                cmd.Parameters.AddWithValue("@udf_2", txtUDF_2.Text);
                cmd.Parameters.AddWithValue("@udf_3", txtUDF_3.Text);
                cmd.Parameters.AddWithValue("@udf_4", txtUDF_4.Text);
                cmd.Parameters.AddWithValue("@udf_5", txtUDF_5.Text);
                cmd.Parameters.AddWithValue("@notes", txtNotes.Text);
                cmd.Parameters.AddWithValue("@create_by", "wmsdemo");
                //cmd.Parameters.AddWithValue("@create_by", "wmsdemo");
                //cmd.Parameters.AddWithValue("@create_by", "wmsdemo");
                //cmd.Parameters.AddWithValue("@create_by", "wmsdemo");
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
            //--- save footprint
            //--- save product alternate
            //--- save bom
        }

#region "local function and procedure"
        private void fillCombo()
        {
            cmbClientID.DataSource = nclsLookUp.lookUpforClientID("wmsdemo").Tables[0];
            cmbClientID.DisplayMember = "description";
            cmbClientID.ValueMember = "client_ID";

            //
            cmbABCCategory.DataSource = nclsLookUp.lookUpforABCCodes("31337").Tables[0];
            cmbABCCategory.DisplayMember = "description";
            cmbABCCategory.ValueMember = "code_ID";
            //
            cmbPartDivision.DataSource = nclsLookUp.lookUpforPartDivision("31337").Tables[0];
            cmbPartDivision.DisplayMember = "description";
            cmbPartDivision.ValueMember = "code_ID";
            //
            cmbPartGroup.DataSource = nclsLookUp.lookUpforPartGroup("31337").Tables[0];
            cmbPartGroup.DisplayMember = "description";
            cmbPartGroup.ValueMember = "code_ID";
            //
            cmbPartFamily.DataSource = nclsLookUp.lookUpforPartFamily("31337").Tables[0];
            cmbPartFamily.DisplayMember = "description";
            cmbPartFamily.ValueMember = "code_ID";
            //
            cmbBaseUom.DataSource = nclsLookUp.lookUpforUomCodes("31337").Tables[0];
            cmbBaseUom.DisplayMember = "description";
            cmbBaseUom.ValueMember = "code_ID";
            //
            cmbMaterialType.DataSource = nclsLookUp.lookUpforMaterialTypes("31337").Tables[0];
            cmbMaterialType.DisplayMember = "description";
            cmbMaterialType.ValueMember = "code_ID";
            //
            cmbLottableControl.DataSource = nclsLookUp.lookUpforLottableControls("31337").Tables[0];
            cmbLottableControl.DisplayMember = "description";
            cmbLottableControl.ValueMember = "code_ID";
            //
            cmbAgingProfile.DataSource = nclsLookUp.lookUpforAgingProfiles("31337").Tables[0];
            cmbAgingProfile.DisplayMember = "description";
            cmbAgingProfile.ValueMember = "code_ID";
            //
            cmbInventoryStatusDefault.DataSource = nclsLookUp.lookUpforInventoryStatus("31337").Tables[0];
            cmbInventoryStatusDefault.DisplayMember = "description";
            cmbInventoryStatusDefault.ValueMember = "code_ID";
            //
            cmbAllocationStrategy.DataSource = nclsLookUp.lookUpforAllocationStrategy("31337").Tables[0];
            cmbAllocationStrategy.DisplayMember = "description";
            cmbAllocationStrategy.ValueMember = "code_ID";


        }
#endregion

    }
}