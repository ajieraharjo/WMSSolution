using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace WMSSolution.References.Master_Reference.BusinessPartner
{
    partial class f_bp_ref
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
            this.cmdCancel = new Gizmox.WebGUI.Forms.Button();
            this.cmdSave = new Gizmox.WebGUI.Forms.Button();
            this.cmdNew = new Gizmox.WebGUI.Forms.Button();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.tabControl1 = new Gizmox.WebGUI.Forms.TabControl();
            this.tabPage1 = new Gizmox.WebGUI.Forms.TabPage();
            this.tableLayoutPanel3 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label12 = new Gizmox.WebGUI.Forms.Label();
            this.label14 = new Gizmox.WebGUI.Forms.Label();
            this.label15 = new Gizmox.WebGUI.Forms.Label();
            this.label16 = new Gizmox.WebGUI.Forms.Label();
            this.label17 = new Gizmox.WebGUI.Forms.Label();
            this.label18 = new Gizmox.WebGUI.Forms.Label();
            this.label19 = new Gizmox.WebGUI.Forms.Label();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.label20 = new Gizmox.WebGUI.Forms.Label();
            this.txtClientID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtParentBPID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtBPID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.txtAddr_1 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtAddr_2 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCity = new Gizmox.WebGUI.Forms.TextBox();
            this.txtPostalCode = new Gizmox.WebGUI.Forms.TextBox();
            this.txtRegion = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCountry = new Gizmox.WebGUI.Forms.TextBox();
            this.txtTelp = new Gizmox.WebGUI.Forms.TextBox();
            this.txtFax = new Gizmox.WebGUI.Forms.TextBox();
            this.txtEmail = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbType = new Gizmox.WebGUI.Forms.ComboBox();
            this.tabPage2 = new Gizmox.WebGUI.Forms.TabPage();
            this.tableLayoutPanel2 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.Latitude = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.txtLatitude = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLongitude = new Gizmox.WebGUI.Forms.TextBox();
            this.tabPage3 = new Gizmox.WebGUI.Forms.TabPage();
            this.tableLayoutPanel1 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.txtCreateTime = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCreateBy = new Gizmox.WebGUI.Forms.TextBox();
            this.txtUpdateBy = new Gizmox.WebGUI.Forms.TextBox();
            this.txtUpdateTime = new Gizmox.WebGUI.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 32);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = Gizmox.WebGUI.Forms.TabAlignment.Top;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 536);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(615, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 26.36816F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 73.63184F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label11, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label12, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label14, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.label15, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.label16, 1, 10);
            this.tableLayoutPanel3.Controls.Add(this.label17, 1, 11);
            this.tableLayoutPanel3.Controls.Add(this.label18, 1, 12);
            this.tableLayoutPanel3.Controls.Add(this.label19, 1, 13);
            this.tableLayoutPanel3.Controls.Add(this.chkActive, 2, 15);
            this.tableLayoutPanel3.Controls.Add(this.label20, 1, 14);
            this.tableLayoutPanel3.Controls.Add(this.txtClientID, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtParentBPID, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtBPID, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtDescription, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtAddr_1, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtAddr_2, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.txtCity, 2, 8);
            this.tableLayoutPanel3.Controls.Add(this.txtPostalCode, 2, 9);
            this.tableLayoutPanel3.Controls.Add(this.txtRegion, 2, 10);
            this.tableLayoutPanel3.Controls.Add(this.txtCountry, 2, 11);
            this.tableLayoutPanel3.Controls.Add(this.txtTelp, 2, 12);
            this.tableLayoutPanel3.Controls.Add(this.txtFax, 2, 13);
            this.tableLayoutPanel3.Controls.Add(this.txtEmail, 2, 14);
            this.tableLayoutPanel3.Controls.Add(this.cmbType, 2, 5);
            this.tableLayoutPanel3.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tableLayoutPanel3.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 16;
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(609, 454);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Client ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Parent BP PID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "BP ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "City";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Postal Code";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Region";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 308);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Country";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 336);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Telp";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 364);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Fax";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.CheckState = Gizmox.WebGUI.Forms.CheckState.Unchecked;
            this.chkActive.Location = new System.Drawing.Point(126, 420);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 0;
            this.chkActive.Text = "Active";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 392);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Email";
            // 
            // txtClientID
            // 
            this.txtClientID.AllowDrag = false;
            this.txtClientID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtClientID.Location = new System.Drawing.Point(129, 31);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(290, 22);
            this.txtClientID.TabIndex = 0;
            // 
            // txtParentBPID
            // 
            this.txtParentBPID.AllowDrag = false;
            this.txtParentBPID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtParentBPID.Location = new System.Drawing.Point(129, 59);
            this.txtParentBPID.Name = "txtParentBPID";
            this.txtParentBPID.Size = new System.Drawing.Size(290, 22);
            this.txtParentBPID.TabIndex = 0;
            // 
            // txtBPID
            // 
            this.txtBPID.AllowDrag = false;
            this.txtBPID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtBPID.Location = new System.Drawing.Point(129, 87);
            this.txtBPID.Name = "txtBPID";
            this.txtBPID.Size = new System.Drawing.Size(290, 22);
            this.txtBPID.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.AllowDrag = false;
            this.txtDescription.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(129, 115);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(290, 22);
            this.txtDescription.TabIndex = 0;
            // 
            // txtAddr_1
            // 
            this.txtAddr_1.AllowDrag = false;
            this.txtAddr_1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtAddr_1.Location = new System.Drawing.Point(129, 171);
            this.txtAddr_1.Name = "txtAddr_1";
            this.txtAddr_1.Size = new System.Drawing.Size(290, 22);
            this.txtAddr_1.TabIndex = 0;
            // 
            // txtAddr_2
            // 
            this.txtAddr_2.AllowDrag = false;
            this.txtAddr_2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtAddr_2.Location = new System.Drawing.Point(129, 199);
            this.txtAddr_2.Name = "txtAddr_2";
            this.txtAddr_2.Size = new System.Drawing.Size(290, 22);
            this.txtAddr_2.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.AllowDrag = false;
            this.txtCity.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCity.Location = new System.Drawing.Point(129, 227);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(290, 22);
            this.txtCity.TabIndex = 0;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.AllowDrag = false;
            this.txtPostalCode.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtPostalCode.Location = new System.Drawing.Point(129, 255);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(290, 22);
            this.txtPostalCode.TabIndex = 0;
            // 
            // txtRegion
            // 
            this.txtRegion.AllowDrag = false;
            this.txtRegion.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtRegion.Location = new System.Drawing.Point(129, 283);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(290, 22);
            this.txtRegion.TabIndex = 0;
            // 
            // txtCountry
            // 
            this.txtCountry.AllowDrag = false;
            this.txtCountry.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCountry.Location = new System.Drawing.Point(129, 311);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(290, 22);
            this.txtCountry.TabIndex = 0;
            // 
            // txtTelp
            // 
            this.txtTelp.AllowDrag = false;
            this.txtTelp.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtTelp.Location = new System.Drawing.Point(129, 339);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.Size = new System.Drawing.Size(290, 22);
            this.txtTelp.TabIndex = 0;
            // 
            // txtFax
            // 
            this.txtFax.AllowDrag = false;
            this.txtFax.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtFax.Location = new System.Drawing.Point(129, 367);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(290, 22);
            this.txtFax.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.AllowDrag = false;
            this.txtEmail.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(129, 395);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // cmbType
            // 
            this.cmbType.AllowDrag = false;
            this.cmbType.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.cmbType.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(126, 140);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(301, 21);
            this.cmbType.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(615, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GPS Location";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 299F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel2.Controls.Add(this.Latitude, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtLatitude, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtLongitude, 2, 2);
            this.tableLayoutPanel2.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tableLayoutPanel2.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 23.93162F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 25.64103F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(609, 117);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(20, 28);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(46, 13);
            this.Latitude.TabIndex = 0;
            this.Latitude.Text = "Latitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Longitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.AllowDrag = false;
            this.txtLatitude.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLatitude.Location = new System.Drawing.Point(127, 31);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(293, 24);
            this.txtLatitude.TabIndex = 0;
            // 
            // txtLongitude
            // 
            this.txtLongitude.AllowDrag = false;
            this.txtLongitude.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLongitude.Location = new System.Drawing.Point(127, 61);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(293, 23);
            this.txtLongitude.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(615, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 26.53563F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 73.46437F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCreateTime, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCreateBy, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateBy, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateTime, 2, 4);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 151);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Update Time";
            // 
            // txtCreateTime
            // 
            this.txtCreateTime.AllowDrag = false;
            this.txtCreateTime.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCreateTime.Location = new System.Drawing.Point(131, 63);
            this.txtCreateTime.Name = "txtCreateTime";
            this.txtCreateTime.Size = new System.Drawing.Size(293, 24);
            this.txtCreateTime.TabIndex = 0;
            // 
            // txtCreateBy
            // 
            this.txtCreateBy.AllowDrag = false;
            this.txtCreateBy.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCreateBy.Location = new System.Drawing.Point(131, 33);
            this.txtCreateBy.Name = "txtCreateBy";
            this.txtCreateBy.Size = new System.Drawing.Size(293, 24);
            this.txtCreateBy.TabIndex = 0;
            // 
            // txtUpdateBy
            // 
            this.txtUpdateBy.AllowDrag = false;
            this.txtUpdateBy.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtUpdateBy.Location = new System.Drawing.Point(131, 93);
            this.txtUpdateBy.Name = "txtUpdateBy";
            this.txtUpdateBy.Size = new System.Drawing.Size(293, 24);
            this.txtUpdateBy.TabIndex = 0;
            // 
            // txtUpdateTime
            // 
            this.txtUpdateTime.AllowDrag = false;
            this.txtUpdateTime.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtUpdateTime.Location = new System.Drawing.Point(131, 123);
            this.txtUpdateTime.Name = "txtUpdateTime";
            this.txtUpdateTime.Size = new System.Drawing.Size(293, 25);
            this.txtUpdateTime.TabIndex = 0;
            // 
            // f_bp_ref
            // 
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Size = new System.Drawing.Size(623, 568);
            this.Text = "f_bp_ref";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdCancel;
        private Button cmdSave;
        private Button cmdNew;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCreateTime;
        private TextBox txtCreateBy;
        private TextBox txtUpdateBy;
        private TextBox txtUpdateTime;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Latitude;
        private Label label6;
        private TextBox txtLatitude;
        private TextBox txtLongitude;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private CheckBox chkActive;
        private Label label20;
        private TextBox txtClientID;
        private TextBox txtParentBPID;
        private TextBox txtBPID;
        private TextBox txtDescription;
        private TextBox txtAddr_1;
        private TextBox txtAddr_2;
        private TextBox txtCity;
        private TextBox txtPostalCode;
        private TextBox txtRegion;
        private TextBox txtCountry;
        private TextBox txtTelp;
        private TextBox txtFax;
        private TextBox txtEmail;
        private ComboBox cmbType;


    }
}