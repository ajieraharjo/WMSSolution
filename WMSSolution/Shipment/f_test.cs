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

#endregion

namespace WMSSolution.Shipment
{
    public partial class f_test : Form
    {
        public f_test()
        {
            InitializeComponent();
        }
        private Shipment.f_shipment nf_shipment = null;
        public f_test(Form callingForm)
        {
            nf_shipment = callingForm as Shipment.f_shipment; 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //f_test(nf_shipment);
            this.nf_shipment.writeTitle("suck");
        }
    }
}