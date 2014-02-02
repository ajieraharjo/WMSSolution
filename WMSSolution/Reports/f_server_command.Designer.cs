using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace WMSSolution.Reports
{
    partial class f_server_command
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdGo = new Gizmox.WebGUI.Forms.Button();
            this.cmdNew = new Gizmox.WebGUI.Forms.Button();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.cmdCancel = new Gizmox.WebGUI.Forms.Button();
            this.cmdExport = new Gizmox.WebGUI.Forms.Button();
            this.splitContainer1 = new Gizmox.WebGUI.Forms.SplitContainer();
            this.groupBox1 = new Gizmox.WebGUI.Forms.GroupBox();
            this.gv = new Gizmox.WebGUI.Forms.DataGridView();
            this.groupBox2 = new Gizmox.WebGUI.Forms.GroupBox();
            this.txtServerCOMMAND = new Gizmox.WebGUI.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGo
            // 
            this.cmdGo.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.cmdGo.Location = new System.Drawing.Point(75, 0);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(75, 32);
            this.cmdGo.TabIndex = 0;
            this.cmdGo.Text = "Go";
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.cmdNew.Location = new System.Drawing.Point(0, 0);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(75, 32);
            this.cmdNew.TabIndex = 0;
            this.cmdNew.Text = "New";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Controls.Add(this.cmdExport);
            this.panel1.Controls.Add(this.cmdGo);
            this.panel1.Controls.Add(this.cmdNew);
            this.panel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 32);
            this.panel1.TabIndex = 0;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.cmdCancel.Location = new System.Drawing.Point(225, 0);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 32);
            this.cmdCancel.TabIndex = 0;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdExport
            // 
            this.cmdExport.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.cmdExport.Location = new System.Drawing.Point(150, 0);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(75, 32);
            this.cmdExport.TabIndex = 0;
            this.cmdExport.Text = "Export";
            // 
            // splitContainer1
            // 
            this.splitContainer1.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.splitContainer1.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.splitContainer1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = Gizmox.WebGUI.Forms.FixedPanel.None;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = Gizmox.WebGUI.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(788, 527);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv);
            this.groupBox1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.AllowUserToOrderColumns = true;
            this.gv.AutoSizeColumnsMode = Gizmox.WebGUI.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv.AutoSizeRowsMode = Gizmox.WebGUI.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.gv.ColumnHeadersHeightSizeMode = Gizmox.WebGUI.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(3, 17);
            this.gv.MultiSelect = false;
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.RowTemplate.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
            this.gv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(782, 173);
            this.gv.TabIndex = 0;
            this.gv.UseInternalPaging = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServerCOMMAND);
            this.groupBox2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 330);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server COMMAND";
            // 
            // txtServerCOMMAND
            // 
            this.txtServerCOMMAND.AllowDrag = false;
            this.txtServerCOMMAND.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtServerCOMMAND.Location = new System.Drawing.Point(3, 17);
            this.txtServerCOMMAND.Multiline = true;
            this.txtServerCOMMAND.Name = "txtServerCOMMAND";
            this.txtServerCOMMAND.ScrollBars = Gizmox.WebGUI.Forms.ScrollBars.Vertical;
            this.txtServerCOMMAND.Size = new System.Drawing.Size(782, 310);
            this.txtServerCOMMAND.TabIndex = 0;
            // 
            // f_server_command
            // 
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Size = new System.Drawing.Size(788, 559);
            this.Text = "f_server_command";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdGo;
        private Button cmdNew;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtServerCOMMAND;
        private DataGridView gv;
        private Button cmdCancel;
        private Button cmdExport;


    }
}