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
    public partial class f_shipment : Form
    {
        public f_shipment()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Shipment.f_test nf_test = new Shipment.f_test(this);
            nf_test.Show();

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void writeTitle(string title) {
            this.Text = title;
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}