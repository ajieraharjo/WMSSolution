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

namespace WMSSolution
{
    public partial class f_mainmenu : Form
    {
        public f_mainmenu()
        {
            InitializeComponent();
            this.Text = "Warehouse Management System";
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            //References.Master_Reference.WarehouseConfiguration.f_warehouses nf_warehouses = new References.Master_Reference.WarehouseConfiguration.f_warehouses();
            ////Inbound.f_test nf_test = new Inbound.f_test();
            //nf_warehouses.MdiParent = this;
            //nf_warehouses.Show();
        }

        private void menuItem51_Click(object sender, EventArgs e)
        {
            References.Master_Reference.WarehouseConfiguration.f_warehouses_ref nf_warehouses_ref= new References.Master_Reference.WarehouseConfiguration.f_warehouses_ref();
            nf_warehouses_ref.MdiParent = this;
            nf_warehouses_ref.Show();

            //References.Master_Reference.WarehouseConfiguration.f_warehouses nf_warehouses = new References.Master_Reference.WarehouseConfiguration.f_warehouses();
            ////Inbound.f_test nf_test = new Inbound.f_test();
            //nf_warehouses.MdiParent = this;
            //nf_warehouses.Show();
        }

        private void menuItem70_Click(object sender, EventArgs e)
        {
            References.Master_Reference.ClientConfiguration.Clients.f_clients_ref nf_client_ref = new References.Master_Reference.ClientConfiguration.Clients.f_clients_ref();
            nf_client_ref.MdiParent = this;
            nf_client_ref.Show();


        }

        private void menuItem71_Click(object sender, EventArgs e)
        {
            References.Master_Reference.f_items_ref nf_items_ref = new References.Master_Reference.f_items_ref();
            nf_items_ref.MdiParent = this;
            nf_items_ref.Show();
        }

        private void menuItem52_Click(object sender, EventArgs e)
        {
            References.Master_Reference.WarehouseConfiguration.f_areas_ref nf_areas_ref = new References.Master_Reference.WarehouseConfiguration.f_areas_ref();
            nf_areas_ref.MdiParent = this;
            nf_areas_ref.Show();

        }

        private void menuItem53_Click(object sender, EventArgs e)
        {
            References.Master_Reference.WarehouseConfiguration.f_zones_ref nf_zones_ref = new References.Master_Reference.WarehouseConfiguration.f_zones_ref();
            nf_zones_ref.MdiParent = this;
            nf_zones_ref.Show();

        }

        private void menuItem34_Click(object sender, EventArgs e)
        {
            Shipment.f_shipment nf_shipment = new Shipment.f_shipment();
            nf_shipment.MdiParent = this;
            nf_shipment.Show();
        }

        private void menuItem72_Click(object sender, EventArgs e)
        {
            References.Master_Reference.BusinessPartner.f_bp_ref nf_bp_ref = new References.Master_Reference.BusinessPartner.f_bp_ref();
            nf_bp_ref.MdiParent = this;
            nf_bp_ref.Show();
        }

        private void menuItem73_Click(object sender, EventArgs e)
        {

        }

        private void menuItem64_Click(object sender, EventArgs e)
        {
            References.Master_Reference.BusinessPartner.f_bp_ref nf_bp_ref = new References.Master_Reference.BusinessPartner.f_bp_ref();
            nf_bp_ref.MdiParent = this;
            nf_bp_ref.Show();
        }

        private void menuItem65_Click(object sender, EventArgs e)
        {
            References.Master_Reference.BusinessPartner.f_bp_ref nf_bp_ref = new References.Master_Reference.BusinessPartner.f_bp_ref();
            nf_bp_ref.MdiParent = this;
            nf_bp_ref.Show();
        }

        private void menuItem66_Click(object sender, EventArgs e)
        {
            References.Master_Reference.BusinessPartner.f_bp_ref nf_bp_ref = new References.Master_Reference.BusinessPartner.f_bp_ref();
            nf_bp_ref.MdiParent = this;
            nf_bp_ref.Show();
        }

        private void menuItem67_Click(object sender, EventArgs e)
        {
            References.Master_Reference.BusinessPartner.f_bp_ref nf_bp_ref = new References.Master_Reference.BusinessPartner.f_bp_ref();
            nf_bp_ref.MdiParent = this;
            nf_bp_ref.Show();
        }

        private void menuItem69_Click(object sender, EventArgs e)
        {
            References.Master_Reference.BusinessPartner.f_bp_ref nf_bp_ref = new References.Master_Reference.BusinessPartner.f_bp_ref();
            nf_bp_ref.MdiParent = this;
            nf_bp_ref.Show();
        }

        private void f_mainmenu_Load(object sender, EventArgs e)
        {
            f_login nf_login = new f_login();
            nf_login.ShowDialog();
        }

        private void menuItem29_Click(object sender, EventArgs e)
        {
            Outbound.f_order nf_order = new Outbound.f_order();
            nf_order.MdiParent = this;
            nf_order.Show();
        }

        private void menuItem78_Click(object sender, EventArgs e)
        {
            Reports.f_server_command nf_server_command = new Reports.f_server_command();
            nf_server_command.MdiParent = this;
            nf_server_command.Show();
        }

        private void menuItem77_Click(object sender, EventArgs e)
        {
            References.Master_Reference.WarehouseConfiguration.f_code_list_ref nf_code_list_ref = new References.Master_Reference.WarehouseConfiguration.f_code_list_ref();
            nf_code_list_ref.MdiParent = this;
            nf_code_list_ref.Show();
        }

        private void menuItem56_Click(object sender, EventArgs e)
        {
            References.Roles_Management.f_users_ref nf_user_ref = new References.Roles_Management.f_users_ref();
            nf_user_ref.MdiParent = this;
            nf_user_ref.Show();
        }


   

    }
}