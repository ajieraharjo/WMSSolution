using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace WMSSolution.References.Master_Reference.WarehouseConfiguration
{
    partial class f_code_list_ref
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
            this.tableLayoutPanel2 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label12 = new Gizmox.WebGUI.Forms.Label();
            this.txtWarehouseID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCodeID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCodeGroup = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.txtExternalID = new Gizmox.WebGUI.Forms.TextBox();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.txtSequence = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbType = new Gizmox.WebGUI.Forms.ComboBox();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
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
            this.tableLayoutPanel3 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.cmdCancel.Location = new System.Drawing.Point(150, 0);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 32);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.cmdSave.Location = new System.Drawing.Point(75, 0);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 32);
            this.cmdSave.TabIndex = 1;
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(615, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 26.10891F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 73.89108F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label11, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label12, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtWarehouseID, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCodeID, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCodeGroup, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtExternalID, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtSequence, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.cmbType, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.chkActive, 2, 8);
            this.tableLayoutPanel2.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tableLayoutPanel2.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 16;
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(615, 454);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Warehouse ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Code ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Code Group";
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
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sequence";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Type";
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.AllowDrag = false;
            this.txtWarehouseID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtWarehouseID.Location = new System.Drawing.Point(129, 31);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(296, 22);
            this.txtWarehouseID.TabIndex = 0;
            // 
            // txtCodeID
            // 
            this.txtCodeID.AllowDrag = false;
            this.txtCodeID.CharacterCasing = Gizmox.WebGUI.Forms.CharacterCasing.Upper;
            this.txtCodeID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCodeID.Location = new System.Drawing.Point(129, 59);
            this.txtCodeID.Name = "txtCodeID";
            this.txtCodeID.Size = new System.Drawing.Size(296, 22);
            this.txtCodeID.TabIndex = 1;
            // 
            // txtCodeGroup
            // 
            this.txtCodeGroup.AllowDrag = false;
            this.txtCodeGroup.CharacterCasing = Gizmox.WebGUI.Forms.CharacterCasing.Upper;
            this.txtCodeGroup.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCodeGroup.Location = new System.Drawing.Point(129, 87);
            this.txtCodeGroup.Name = "txtCodeGroup";
            this.txtCodeGroup.Size = new System.Drawing.Size(296, 22);
            this.txtCodeGroup.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.AllowDrag = false;
            this.txtDescription.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(129, 115);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(296, 22);
            this.txtDescription.TabIndex = 3;
            // 
            // txtExternalID
            // 
            this.txtExternalID.AllowDrag = false;
            this.txtExternalID.CharacterCasing = Gizmox.WebGUI.Forms.CharacterCasing.Upper;
            this.txtExternalID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtExternalID.Location = new System.Drawing.Point(129, 199);
            this.txtExternalID.Name = "txtExternalID";
            this.txtExternalID.Size = new System.Drawing.Size(296, 22);
            this.txtExternalID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "External ID";
            // 
            // txtSequence
            // 
            this.txtSequence.AllowDrag = false;
            this.txtSequence.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtSequence.Location = new System.Drawing.Point(129, 143);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(296, 22);
            this.txtSequence.TabIndex = 4;
            // 
            // cmbType
            // 
            this.cmbType.AllowDrag = false;
            this.cmbType.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.cmbType.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "SYS",
            "USR",
            "LKP"});
            this.cmbType.Location = new System.Drawing.Point(126, 168);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(302, 21);
            this.cmbType.TabIndex = 5;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.CheckState = Gizmox.WebGUI.Forms.CheckState.Unchecked;
            this.chkActive.Location = new System.Drawing.Point(126, 224);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 7;
            this.chkActive.Text = "Active";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(615, 510);
            this.tabPage3.TabIndex = 1;
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
            this.txtCreateTime.TabIndex = 1;
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
            this.txtUpdateBy.TabIndex = 2;
            // 
            // txtUpdateTime
            // 
            this.txtUpdateTime.AllowDrag = false;
            this.txtUpdateTime.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtUpdateTime.Location = new System.Drawing.Point(131, 123);
            this.txtUpdateTime.Name = "txtUpdateTime";
            this.txtUpdateTime.Size = new System.Drawing.Size(293, 25);
            this.txtUpdateTime.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 26.36816F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 73.63184F));
            this.tableLayoutPanel3.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel3.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tableLayoutPanel3.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 16;
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 50F));
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
            // f_code_list_ref
            // 
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Size = new System.Drawing.Size(623, 568);
            this.Text = "f_bp_ref";
            this.Load += new System.EventHandler(this.f_code_list_ref_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtWarehouseID;
        private TextBox txtCodeID;
        private TextBox txtCodeGroup;
        private TextBox txtDescription;
        private TextBox txtExternalID;
        private Label label5;
        private TextBox txtSequence;
        private ComboBox cmbType;
        private CheckBox chkActive;


    }
}