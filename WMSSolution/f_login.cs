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
    public partial class f_login : Form
    {
        public f_login()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            //f_mainmenu nf_mainmenu = new f_mainmenu();
            //nf_mainmenu.ShowDialog();
            this.Close();
        }

        private void f_login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}