using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace WMSSolution.Outbound
{
    partial class f_order_detail
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
            this.cmdNew = new Gizmox.WebGUI.Forms.Button();
            this.cmdSave = new Gizmox.WebGUI.Forms.Button();
            this.cmdCancel = new Gizmox.WebGUI.Forms.Button();
            this.panel2 = new Gizmox.WebGUI.Forms.Panel();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.tabControl1 = new Gizmox.WebGUI.Forms.TabControl();
            this.tabPage1 = new Gizmox.WebGUI.Forms.TabPage();
            this.tableLayoutPanel2 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.lnkPartID = new Gizmox.WebGUI.Forms.LinkLabel();
            this.txtPartID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.cmbBaseUom = new Gizmox.WebGUI.Forms.ComboBox();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.txtQtyExpected = new Gizmox.WebGUI.Forms.TextBox();
            this.txtQtyAllocated = new Gizmox.WebGUI.Forms.TextBox();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.txtQtyPicked = new Gizmox.WebGUI.Forms.TextBox();
            this.txtQtyShipped = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot1 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot2 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot3 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot4 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot5 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot6 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot7 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot8 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot9 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot10 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot11 = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLot12 = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbInventoryStatus = new Gizmox.WebGUI.Forms.ComboBox();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label12 = new Gizmox.WebGUI.Forms.Label();
            this.label13 = new Gizmox.WebGUI.Forms.Label();
            this.label14 = new Gizmox.WebGUI.Forms.Label();
            this.label15 = new Gizmox.WebGUI.Forms.Label();
            this.label16 = new Gizmox.WebGUI.Forms.Label();
            this.label17 = new Gizmox.WebGUI.Forms.Label();
            this.label18 = new Gizmox.WebGUI.Forms.Label();
            this.label19 = new Gizmox.WebGUI.Forms.Label();
            this.label20 = new Gizmox.WebGUI.Forms.Label();
            this.label21 = new Gizmox.WebGUI.Forms.Label();
            this.label22 = new Gizmox.WebGUI.Forms.Label();
            this.label23 = new Gizmox.WebGUI.Forms.Label();
            this.label24 = new Gizmox.WebGUI.Forms.Label();
            this.txtOrderLineNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.tabPage2 = new Gizmox.WebGUI.Forms.TabPage();
            this.tableLayoutPanel1 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.txtCreateBy = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCreateTime = new Gizmox.WebGUI.Forms.TextBox();
            this.txtUpdateBy = new Gizmox.WebGUI.Forms.TextBox();
            this.txtUpdateTime = new Gizmox.WebGUI.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdNew
            // 
            this.cmdNew.Dock = Gizmox.WebGUI.Forms.DockStyle.Right;
            this.cmdNew.Location = new System.Drawing.Point(493, 0);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(75, 32);
            this.cmdNew.TabIndex = 0;
            this.cmdNew.Text = "New";
            this.cmdNew.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Dock = Gizmox.WebGUI.Forms.DockStyle.Right;
            this.cmdSave.Location = new System.Drawing.Point(568, 0);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 32);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Dock = Gizmox.WebGUI.Forms.DockStyle.Right;
            this.cmdCancel.Location = new System.Drawing.Point(643, 0);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 32);
            this.cmdCancel.TabIndex = 0;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdNew);
            this.panel2.Controls.Add(this.cmdSave);
            this.panel2.Controls.Add(this.cmdCancel);
            this.panel2.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 574);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 32);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 32);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = Gizmox.WebGUI.Forms.TabAlignment.Top;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 542);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(710, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lnkPartID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPartID, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cmbBaseUom, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtQtyExpected, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtQtyAllocated, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.label9, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.label10, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtQtyPicked, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtQtyShipped, 5, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtLot1, 2, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtLot2, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.txtLot3, 2, 10);
            this.tableLayoutPanel2.Controls.Add(this.txtLot4, 2, 11);
            this.tableLayoutPanel2.Controls.Add(this.txtLot5, 2, 12);
            this.tableLayoutPanel2.Controls.Add(this.txtLot6, 2, 13);
            this.tableLayoutPanel2.Controls.Add(this.txtLot7, 5, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtLot8, 5, 9);
            this.tableLayoutPanel2.Controls.Add(this.txtLot9, 5, 10);
            this.tableLayoutPanel2.Controls.Add(this.txtLot10, 5, 11);
            this.tableLayoutPanel2.Controls.Add(this.txtLot11, 5, 12);
            this.tableLayoutPanel2.Controls.Add(this.txtLot12, 5, 13);
            this.tableLayoutPanel2.Controls.Add(this.cmbInventoryStatus, 2, 15);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 15);
            this.tableLayoutPanel2.Controls.Add(this.label12, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.label14, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.label15, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.label16, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.label17, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.label18, 4, 8);
            this.tableLayoutPanel2.Controls.Add(this.label19, 4, 9);
            this.tableLayoutPanel2.Controls.Add(this.label20, 4, 10);
            this.tableLayoutPanel2.Controls.Add(this.label21, 4, 11);
            this.tableLayoutPanel2.Controls.Add(this.label22, 4, 12);
            this.tableLayoutPanel2.Controls.Add(this.label23, 4, 13);
            this.tableLayoutPanel2.Controls.Add(this.label24, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtOrderLineNumber, 5, 1);
            this.tableLayoutPanel2.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tableLayoutPanel2.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 16;
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(710, 477);
            this.tableLayoutPanel2.TabIndex = 0;
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
            // lnkPartID
            // 
            this.lnkPartID.AutoSize = true;
            this.lnkPartID.ClientMode = false;
            this.lnkPartID.LinkColor = System.Drawing.Color.Blue;
            this.lnkPartID.Location = new System.Drawing.Point(20, 29);
            this.lnkPartID.Name = "lnkPartID";
            this.lnkPartID.Size = new System.Drawing.Size(41, 13);
            this.lnkPartID.TabIndex = 0;
            this.lnkPartID.TabStop = true;
            this.lnkPartID.Text = "Part ID";
            // 
            // txtPartID
            // 
            this.txtPartID.AllowDrag = false;
            this.txtPartID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtPartID.Location = new System.Drawing.Point(188, 32);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.Size = new System.Drawing.Size(159, 23);
            this.txtPartID.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.AllowDrag = false;
            this.txtDescription.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(188, 61);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(159, 23);
            this.txtDescription.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Base Uom";
            // 
            // cmbBaseUom
            // 
            this.cmbBaseUom.AllowDrag = false;
            this.cmbBaseUom.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.cmbBaseUom.FormattingEnabled = true;
            this.cmbBaseUom.Location = new System.Drawing.Point(185, 87);
            this.cmbBaseUom.Name = "cmbBaseUom";
            this.cmbBaseUom.Size = new System.Drawing.Size(165, 21);
            this.cmbBaseUom.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Qty Expected";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Qty Allocated";
            // 
            // txtQtyExpected
            // 
            this.txtQtyExpected.AllowDrag = false;
            this.txtQtyExpected.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtQtyExpected.Location = new System.Drawing.Point(188, 148);
            this.txtQtyExpected.Name = "txtQtyExpected";
            this.txtQtyExpected.Size = new System.Drawing.Size(159, 23);
            this.txtQtyExpected.TabIndex = 0;
            // 
            // txtQtyAllocated
            // 
            this.txtQtyAllocated.AllowDrag = false;
            this.txtQtyAllocated.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtQtyAllocated.Enabled = false;
            this.txtQtyAllocated.Location = new System.Drawing.Point(188, 177);
            this.txtQtyAllocated.Name = "txtQtyAllocated";
            this.txtQtyAllocated.Size = new System.Drawing.Size(159, 23);
            this.txtQtyAllocated.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Qty Picked";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Qty Shipped";
            // 
            // txtQtyPicked
            // 
            this.txtQtyPicked.AllowDrag = false;
            this.txtQtyPicked.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtQtyPicked.Enabled = false;
            this.txtQtyPicked.Location = new System.Drawing.Point(503, 148);
            this.txtQtyPicked.Name = "txtQtyPicked";
            this.txtQtyPicked.Size = new System.Drawing.Size(183, 23);
            this.txtQtyPicked.TabIndex = 0;
            // 
            // txtQtyShipped
            // 
            this.txtQtyShipped.AllowDrag = false;
            this.txtQtyShipped.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtQtyShipped.Enabled = false;
            this.txtQtyShipped.Location = new System.Drawing.Point(503, 177);
            this.txtQtyShipped.Name = "txtQtyShipped";
            this.txtQtyShipped.Size = new System.Drawing.Size(183, 23);
            this.txtQtyShipped.TabIndex = 0;
            // 
            // txtLot1
            // 
            this.txtLot1.AllowDrag = false;
            this.txtLot1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot1.Location = new System.Drawing.Point(188, 235);
            this.txtLot1.Name = "txtLot1";
            this.txtLot1.Size = new System.Drawing.Size(159, 23);
            this.txtLot1.TabIndex = 0;
            // 
            // txtLot2
            // 
            this.txtLot2.AllowDrag = false;
            this.txtLot2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot2.Location = new System.Drawing.Point(188, 264);
            this.txtLot2.Name = "txtLot2";
            this.txtLot2.Size = new System.Drawing.Size(159, 23);
            this.txtLot2.TabIndex = 0;
            // 
            // txtLot3
            // 
            this.txtLot3.AllowDrag = false;
            this.txtLot3.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot3.Location = new System.Drawing.Point(188, 293);
            this.txtLot3.Name = "txtLot3";
            this.txtLot3.Size = new System.Drawing.Size(159, 23);
            this.txtLot3.TabIndex = 0;
            // 
            // txtLot4
            // 
            this.txtLot4.AllowDrag = false;
            this.txtLot4.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot4.Location = new System.Drawing.Point(188, 322);
            this.txtLot4.Name = "txtLot4";
            this.txtLot4.Size = new System.Drawing.Size(159, 23);
            this.txtLot4.TabIndex = 0;
            // 
            // txtLot5
            // 
            this.txtLot5.AllowDrag = false;
            this.txtLot5.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot5.Location = new System.Drawing.Point(188, 351);
            this.txtLot5.Name = "txtLot5";
            this.txtLot5.Size = new System.Drawing.Size(159, 23);
            this.txtLot5.TabIndex = 0;
            // 
            // txtLot6
            // 
            this.txtLot6.AllowDrag = false;
            this.txtLot6.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot6.Location = new System.Drawing.Point(188, 380);
            this.txtLot6.Name = "txtLot6";
            this.txtLot6.Size = new System.Drawing.Size(159, 23);
            this.txtLot6.TabIndex = 0;
            // 
            // txtLot7
            // 
            this.txtLot7.AllowDrag = false;
            this.txtLot7.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot7.Location = new System.Drawing.Point(503, 235);
            this.txtLot7.Name = "txtLot7";
            this.txtLot7.Size = new System.Drawing.Size(183, 23);
            this.txtLot7.TabIndex = 0;
            // 
            // txtLot8
            // 
            this.txtLot8.AllowDrag = false;
            this.txtLot8.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot8.Location = new System.Drawing.Point(503, 264);
            this.txtLot8.Name = "txtLot8";
            this.txtLot8.Size = new System.Drawing.Size(183, 23);
            this.txtLot8.TabIndex = 0;
            // 
            // txtLot9
            // 
            this.txtLot9.AllowDrag = false;
            this.txtLot9.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot9.Location = new System.Drawing.Point(503, 293);
            this.txtLot9.Name = "txtLot9";
            this.txtLot9.Size = new System.Drawing.Size(183, 23);
            this.txtLot9.TabIndex = 0;
            // 
            // txtLot10
            // 
            this.txtLot10.AllowDrag = false;
            this.txtLot10.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot10.Location = new System.Drawing.Point(503, 322);
            this.txtLot10.Name = "txtLot10";
            this.txtLot10.Size = new System.Drawing.Size(183, 23);
            this.txtLot10.TabIndex = 0;
            // 
            // txtLot11
            // 
            this.txtLot11.AllowDrag = false;
            this.txtLot11.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot11.Location = new System.Drawing.Point(503, 351);
            this.txtLot11.Name = "txtLot11";
            this.txtLot11.Size = new System.Drawing.Size(183, 23);
            this.txtLot11.TabIndex = 0;
            // 
            // txtLot12
            // 
            this.txtLot12.AllowDrag = false;
            this.txtLot12.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtLot12.Location = new System.Drawing.Point(503, 380);
            this.txtLot12.Name = "txtLot12";
            this.txtLot12.Size = new System.Drawing.Size(183, 23);
            this.txtLot12.TabIndex = 0;
            // 
            // cmbInventoryStatus
            // 
            this.cmbInventoryStatus.AllowDrag = false;
            this.cmbInventoryStatus.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.cmbInventoryStatus.FormattingEnabled = true;
            this.cmbInventoryStatus.Location = new System.Drawing.Point(185, 435);
            this.cmbInventoryStatus.Name = "cmbInventoryStatus";
            this.cmbInventoryStatus.Size = new System.Drawing.Size(165, 21);
            this.cmbInventoryStatus.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Inventory Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Lottable 1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Lottable 2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Lottable 3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Lottable 4";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 348);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Lottable 5";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 377);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Lottable 6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(372, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Lottable 7";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(372, 261);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Lottable 8";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(372, 290);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Lottable 9";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(372, 319);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Lottable 10";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(372, 348);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Lottable 11";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(372, 377);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Lottable 12";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(372, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Order LineNumber";
            // 
            // txtOrderLineNumber
            // 
            this.txtOrderLineNumber.AllowDrag = false;
            this.txtOrderLineNumber.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtOrderLineNumber.Enabled = false;
            this.txtOrderLineNumber.Location = new System.Drawing.Point(503, 32);
            this.txtOrderLineNumber.Name = "txtOrderLineNumber";
            this.txtOrderLineNumber.Size = new System.Drawing.Size(183, 23);
            this.txtOrderLineNumber.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(710, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 288F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCreateBy, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCreateTime, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateBy, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUpdateTime, 2, 4);
            this.tableLayoutPanel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tableLayoutPanel1.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 159);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Update Time";
            // 
            // txtCreateBy
            // 
            this.txtCreateBy.AllowDrag = false;
            this.txtCreateBy.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCreateBy.Location = new System.Drawing.Point(107, 34);
            this.txtCreateBy.Name = "txtCreateBy";
            this.txtCreateBy.Size = new System.Drawing.Size(306, 25);
            this.txtCreateBy.TabIndex = 0;
            // 
            // txtCreateTime
            // 
            this.txtCreateTime.AllowDrag = false;
            this.txtCreateTime.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCreateTime.Location = new System.Drawing.Point(107, 65);
            this.txtCreateTime.Name = "txtCreateTime";
            this.txtCreateTime.Size = new System.Drawing.Size(306, 25);
            this.txtCreateTime.TabIndex = 0;
            // 
            // txtUpdateBy
            // 
            this.txtUpdateBy.AllowDrag = false;
            this.txtUpdateBy.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtUpdateBy.Location = new System.Drawing.Point(107, 96);
            this.txtUpdateBy.Name = "txtUpdateBy";
            this.txtUpdateBy.Size = new System.Drawing.Size(306, 25);
            this.txtUpdateBy.TabIndex = 0;
            // 
            // txtUpdateTime
            // 
            this.txtUpdateTime.AllowDrag = false;
            this.txtUpdateTime.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtUpdateTime.Location = new System.Drawing.Point(107, 127);
            this.txtUpdateTime.Name = "txtUpdateTime";
            this.txtUpdateTime.Size = new System.Drawing.Size(306, 29);
            this.txtUpdateTime.TabIndex = 0;
            // 
            // f_order_detail
            // 
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Size = new System.Drawing.Size(718, 606);
            this.Text = "f_order_detail";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdNew;
        private Button cmdSave;
        private Button cmdCancel;
        private Panel panel2;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCreateBy;
        private TextBox txtCreateTime;
        private TextBox txtUpdateBy;
        private TextBox txtUpdateTime;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private LinkLabel lnkPartID;
        private TextBox txtPartID;
        private TextBox txtDescription;
        private Label label5;
        private ComboBox cmbBaseUom;
        private Label label7;
        private Label label8;
        private TextBox txtQtyExpected;
        private TextBox txtQtyAllocated;
        private Label label9;
        private Label label10;
        private TextBox txtQtyPicked;
        private TextBox txtQtyShipped;
        private TextBox txtLot1;
        private TextBox txtLot2;
        private TextBox txtLot3;
        private TextBox txtLot4;
        private TextBox txtLot5;
        private TextBox txtLot6;
        private TextBox txtLot7;
        private TextBox txtLot8;
        private TextBox txtLot9;
        private TextBox txtLot10;
        private TextBox txtLot11;
        private TextBox txtLot12;
        private ComboBox cmbInventoryStatus;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox txtOrderLineNumber;


    }
}