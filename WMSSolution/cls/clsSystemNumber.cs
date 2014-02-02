using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MySql.Data.MySqlClient;
using System.Data;

namespace WMSSolution.cls
{
    public class clsSystemNumber
    {
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; password=nintendo; database=wmsdb; pooling=false");
        private MySqlCommand cmd;
        //private MySqlCommand cmd2;
        private MySqlDataAdapter dap;
        //private DataSet ds = new DataSet();
        private MySqlTransaction trx;

        public string getSystemNumber(string warehouse_ID,string control_num)
        {
            string resultnumber = "";
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                cmd = new MySqlCommand("update t_sysnum set last_num=start_num+last_num+1 where warehouse_id='" + warehouse_ID + "' and control_num='" + control_num + "'", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                
                
                //cmd = new MySqlCommand("select if(isnull(prefix),'',prefix)+cast(last_num as char)+if(isnull(subfix),'',subfix) as sysnum from t_sysnum set last_num=start_num+1 where warehouse_id='41447' and control_num='ORDNBR'", con);
                cmd = new MySqlCommand("select if(isnull(prefix),'',prefix) as prefix, cast(last_num as char) as number ,if(isnull(subfix),'',subfix) as subfix from t_sysnum  where warehouse_id='41447' and control_num='ORDNBR'",con);
                cmd.CommandType = CommandType.Text;
                //cmd.CommandType = CommandType.Text;
                //cmd.ExecuteNonQuery();
                //

                dap = new MySqlDataAdapter(cmd);
                ds.Clear();
                dap.Fill(ds, "result");
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    resultnumber = dr[0].ToString() + string.Format("{0:0000000000}", Convert.ToInt16(dr[1])) + dr[2].ToString();
                }
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
                //cmd2.Dispose();
                cmd.Dispose();
                con.Close();
            }
            return resultnumber;
        }
    }
}