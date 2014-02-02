using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MySql.Data.MySqlClient;
using System.Data;

namespace WMSSolution.cls
{

    public class clsLookUp
    {
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; password=nintendo; database=wmsdb; pooling=false");
        private MySqlCommand cmd;
        private MySqlDataAdapter dap;
        //private DataSet ds = new DataSet();
        private MySqlTransaction trx;
        //
        public DataSet lookUpforBPType(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select * from t_code_list where warehouse_ID='"+warehouse_ID+"' and code_group='BPLTYP'", con);
                cmd.CommandType = CommandType.Text;
                //
                
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        //
        public DataSet lookUpforRoleID(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select * from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='ROLUSR'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup ClientID
        public DataSet lookUpforClientID(string user_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select client_ID,description from t_clients",con);// where warehouse_ID='" + warehouse_ID + "' and code_group='ROLUSR'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup WarehouseID
        public DataSet lookUpforWarehouseID(string user_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select warehouse_ID,description from t_warehouses", con);// where warehouse_ID='" + warehouse_ID + "' and code_group='ROLUSR'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup Part Division
        public DataSet lookUpforPartDivision(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='PRTDIV'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup Part Group
        public DataSet lookUpforPartGroup(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='PRTGRP'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup Part Family
        public DataSet lookUpforPartFamily(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='PRTFAM'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup ABC Codes
        public DataSet lookUpforABCCodes(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='ABCCOD'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup UOM Codes
        public DataSet lookUpforUomCodes(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='UOMCOD'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup Material Types
        public DataSet lookUpforMaterialTypes(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='MATTYP'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup Lottable Controls
        public DataSet lookUpforLottableControls(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='LOTCTL'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup Aging Profiles
        public DataSet lookUpforAgingProfiles(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='AGEPFL'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup Inventory Status
        public DataSet lookUpforInventoryStatus(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='INVSTS'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        // lookup Allocation Strategy
        public DataSet lookUpforAllocationStrategy(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='ALCSTR'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        //ORDER STATUS
        public DataSet lookUpforOrderStatus(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='ORDSTS'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        //ORDER TYPE
        public DataSet lookUpforOrderType(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='ORDTYP'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
        //ORDER PRIORITY
        public DataSet lookUpforOrderPriority(string warehouse_ID)
        {
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("select code_ID,description from t_code_list where warehouse_ID='" + warehouse_ID + "' and code_group='ORDPRI'", con);
                cmd.CommandType = CommandType.Text;
                //
                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                //gv.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                throw ex;
                //trx.Rollback();
                //MessageBox.Show(ex.Message, "ERR [" + ex.ErrorCode.ToString() + "]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return ds;
        }
    }

}