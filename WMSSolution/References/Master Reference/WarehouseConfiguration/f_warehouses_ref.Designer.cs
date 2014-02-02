using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace WMSSolution.References.Master_Reference.WarehouseConfiguration
{
    partial class f_warehouses_ref
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
            this.tcontrol = new Gizmox.WebGUI.Forms.TabControl();
            this.tabPage1 = new Gizmox.WebGUI.Forms.TabPage();
            this.tableLayoutPanel2 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.txtWarehouseID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.txtExternalID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtAddress_1 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtAddress_2 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtState = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCity = new Gizmox.WebGUI.Forms.TextBox();
            this.txtRegion = new Gizmox.WebGUI.Forms.TextBox();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.txtPostalCode = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCountry = new Gizmox.WebGUI.Forms.TextBox();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label12 = new Gizmox.WebGUI.Forms.Label();
            this.label13 = new Gizmox.WebGUI.Forms.Label();
            this.label14 = new Gizmox.WebGUI.Forms.Label();
            this.tabPage2 = new Gizmox.WebGUI.Forms.TabPage();
            this.tableLayoutPanel1 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.txtUpdateTime = new Gizmox.WebGUI.Forms.TextBox();
            this.txtUpdateBy = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCreateTime = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCreateBy = new Gizmox.WebGUI.Forms.TextBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.cmdCancel = new Gizmox.WebGUI.Forms.Button();
            this.cmdSave = new Gizmox.WebGUI.Forms.Button();
            this.cmdNew = new Gizmox.WebGUI.Forms.Button();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tcontrol)).BeginInit();
            this.tcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcontrol
            // 
            this.tcontrol.Alignment = Gizmox.WebGUI.Forms.TabAlignment.Top;
            this.tcontrol.Controls.Add(this.tabPage1);
            this.tcontrol.Controls.Add(this.tabPage2);
            this.tcontrol.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tcontrol.Location = new System.Drawing.Point(0, 0);
            this.tcontrol.Name = "tcontrol";
            this.tcontrol.SelectedIndex = 0;
            this.tcontrol.Size = new System.Drawing.Size(644, 527);
            this.tcontrol.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(636, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 25.64935F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 58.6039F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 15.58442F));
            this.tableLayoutPanel2.Controls.Add(this.txtWarehouseID, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtExternalID, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtAddress_1, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtAddress_2, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtState, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtCity, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtRegion, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.chkActive, 2, 11);
            this.tableLayoutPanel2.Controls.Add(this.txtPostalCode, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.txtCountry, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label12, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.label14, 1, 10);
            this.tableLayoutPanel2.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tableLayoutPanel2.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 8.332569F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(636, 350);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.AllowDrag = false;
            this.txtWarehouseID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtWarehouseID.Location = new System.Drawing.Point(181, 32);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(355, 23);
            this.txtWarehouseID.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.AllowDrag = false;
            this.txtDescription.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(181, 61);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(355, 23);
            this.txtDescription.TabIndex = 0;
            // 
            // txtExternalID
            // 
            this.txtExternalID.AllowDrag = false;
            this.txtExternalID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtExternalID.Location = new System.Drawing.Point(181, 90);
            this.txtExternalID.Name = "txtExternalID";
            this.txtExternalID.Size = new System.Drawing.Size(355, 23);
            this.txtExternalID.TabIndex = 0;
            // 
            // txtAddress_1
            // 
            this.txtAddress_1.AllowDrag = false;
            this.txtAddress_1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtAddress_1.Location = new System.Drawing.Point(181, 119);
            this.txtAddress_1.Name = "txtAddress_1";
            this.txtAddress_1.Size = new System.Drawing.Size(355, 23);
            this.txtAddress_1.TabIndex = 0;
            // 
            // txtAddress_2
            // 
            this.txtAddress_2.AllowDrag = false;
            this.txtAddress_2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtAddress_2.Location = new System.Drawing.Point(181, 148);
            this.txtAddress_2.Name = "txtAddress_2";
            this.txtAddress_2.Size = new System.Drawing.Size(355, 23);
            this.txtAddress_2.TabIndex = 0;
            // 
            // txtState
            // 
            this.txtState.AllowDrag = false;
            this.txtState.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtState.Location = new System.Drawing.Point(181, 177);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(355, 23);
            this.txtState.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.AllowDrag = false;
            this.txtCity.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCity.Location = new System.Drawing.Point(181, 206);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(355, 23);
            this.txtCity.TabIndex = 0;
            // 
            // txtRegion
            // 
            this.txtRegion.AllowDrag = false;
            this.txtRegion.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtRegion.Location = new System.Drawing.Point(181, 235);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(355, 23);
            this.txtRegion.TabIndex = 0;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.CheckState = Gizmox.WebGUI.Forms.CheckState.Unchecked;
            this.chkActive.Location = new System.Drawing.Point(178, 319);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 0;
            this.chkActive.Text = "Active";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.AllowDrag = false;
            this.txtPostalCode.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtPostalCode.Location = new System.Drawing.Point(181, 264);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(355, 23);
            this.txtPostalCode.TabIndex = 0;
            // 
            // txtCountry
            // 
            this.txtCountry.AllowDrag = false;
            this.txtCountry.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCountry.Location = new System.Drawing.Point(181, 293);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(355, 23);
            this.txtCountry.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Warehouse ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "External ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Region";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Postal Code";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Country";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(636, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 25.32467F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 41.23376F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateTime, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateBy, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCreateTime, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCreateBy, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tableLayoutPanel1.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtUpdateTime
            // 
            this.txtUpdateTime.AllowDrag = false;
            this.txtUpdateTime.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtUpdateTime.Location = new System.Drawing.Point(179, 123);
            this.txtUpdateTime.Name = "txtUpdateTime";
            this.txtUpdateTime.ReadOnly = true;
            this.txtUpdateTime.Size = new System.Drawing.Size(248, 24);
            this.txtUpdateTime.TabIndex = 0;
            // 
            // txtUpdateBy
            // 
            this.txtUpdateBy.AllowDrag = false;
            this.txtUpdateBy.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtUpdateBy.Location = new System.Drawing.Point(179, 93);
            this.txtUpdateBy.Name = "txtUpdateBy";
            this.txtUpdateBy.ReadOnly = true;
            this.txtUpdateBy.Size = new System.Drawing.Size(248, 24);
            this.txtUpdateBy.TabIndex = 0;
            // 
            // txtCreateTime
            // 
            this.txtCreateTime.AllowDrag = false;
            this.txtCreateTime.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCreateTime.Location = new System.Drawing.Point(179, 63);
            this.txtCreateTime.Name = "txtCreateTime";
            this.txtCreateTime.ReadOnly = true;
            this.txtCreateTime.Size = new System.Drawing.Size(248, 24);
            this.txtCreateTime.TabIndex = 0;
            // 
            // txtCreateBy
            // 
            this.txtCreateBy.AllowDrag = false;
            this.txtCreateBy.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCreateBy.Location = new System.Drawing.Point(179, 33);
            this.txtCreateBy.Name = "txtCreateBy";
            this.txtCreateBy.ReadOnly = true;
            this.txtCreateBy.Size = new System.Drawing.Size(248, 24);
            this.txtCreateBy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Update Time";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.cmdCancel.Location = new System.Drawing.Point(150, 0);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 32);
            this.cmdCancel.TabIndex = 0;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.cmdSave.Location = new System.Drawing.Point(75, 0);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 32);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
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
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.cmdNew);
            this.panel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 32);
            this.panel1.TabIndex = 0;
            // 
            // f_warehouses_ref
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcontrol);
            this.Size = new System.Drawing.Size(644, 527);
            this.Text = "f_warehouses_ref";
            ((System.ComponentModel.ISupportInitialize)(this.tcontrol)).EndInit();
            this.tcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcontrol;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtCreateBy;
        private TextBox txtUpdateTime;
        private TextBox txtUpdateBy;
        private TextBox txtCreateTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button cmdCancel;
        private Button cmdSave;
        private Button cmdNew;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtWarehouseID;
        private TextBox txtDescription;
        private TextBox txtExternalID;
        private TextBox txtAddress_1;
        private TextBox txtAddress_2;
        private TextBox txtState;
        private TextBox txtCity;
        private TextBox txtRegion;
        private CheckBox chkActive;
        private TextBox txtPostalCode;
        private TextBox txtCountry;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;


    }
}