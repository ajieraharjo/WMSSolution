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
    public partial class f_order_detail : Form
    {
        private MySqlConnection con = new MySqlConnection("server=127.0.0.1;user id=root; password=nintendo; database=wmsdb; pooling=false");
        private MySqlCommand cmd;
        //private MySqlDataAdapter dap;
        private MySqlTransaction trx;
        

        public f_order_detail()
        {
            InitializeComponent();
        }
        private Outbound.f_order nf_order = null;
        public f_order_detail(Form callingForm)
        {
            nf_order = callingForm as Outbound.f_order; 
            InitializeComponent();
        }
        //        private Shipment.f_shipment nf_shipment = null;
        //public f_test(Form callingForm)
        //{
        //    nf_shipment = callingForm as Shipment.f_shipment; 
        //    InitializeComponent();
        //}
        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            this.nf_order.writeTitle("suck");
        }

        private void cmdCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}