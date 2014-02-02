using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace WMSSolution.References.Master_Reference.WarehouseConfiguration
{
    partial class f_areas_ref
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
            this.tcontrol = new Gizmox.WebGUI.Forms.TabControl();
            this.tabPage1 = new Gizmox.WebGUI.Forms.TabPage();
            this.tableLayoutPanel1 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.txtWarehouseID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtAreaID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.txtExternalID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtAccessType = new Gizmox.WebGUI.Forms.TextBox();
            this.tabPage2 = new Gizmox.WebGUI.Forms.TabPage();
            this.tableLayoutPanel2 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.txtCreateBy = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCreateTime = new Gizmox.WebGUI.Forms.TextBox();
            this.txtUpdateBy = new Gizmox.WebGUI.Forms.TextBox();
            this.txtUpdateTime = new Gizmox.WebGUI.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcontrol)).BeginInit();
            this.tcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 32);
            this.panel1.TabIndex = 0;
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
            this.tcontrol.Size = new System.Drawing.Size(461, 434);
            this.tcontrol.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(453, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 37.43842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 62.56158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.chkActive, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtWarehouseID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAreaID, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtExternalID, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAccessType, 2, 5);
            this.tableLayoutPanel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tableLayoutPanel1.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 208);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Area ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "External ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Access Type";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.CheckState = Gizmox.WebGUI.Forms.CheckState.Unchecked;
            this.chkActive.Location = new System.Drawing.Point(172, 174);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 0;
            this.chkActive.Text = "Active";
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.AllowDrag = false;
            this.txtWarehouseID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtWarehouseID.Location = new System.Drawing.Point(175, 32);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(248, 23);
            this.txtWarehouseID.TabIndex = 0;
            // 
            // txtAreaID
            // 
            this.txtAreaID.AllowDrag = false;
            this.txtAreaID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtAreaID.Location = new System.Drawing.Point(175, 61);
            this.txtAreaID.Name = "txtAreaID";
            this.txtAreaID.Size = new System.Drawing.Size(248, 23);
            this.txtAreaID.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.AllowDrag = false;
            this.txtDescription.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(175, 90);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(248, 23);
            this.txtDescription.TabIndex = 0;
            // 
            // txtExternalID
            // 
            this.txtExternalID.AllowDrag = false;
            this.txtExternalID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtExternalID.Location = new System.Drawing.Point(175, 119);
            this.txtExternalID.Name = "txtExternalID";
            this.txtExternalID.Size = new System.Drawing.Size(248, 23);
            this.txtExternalID.TabIndex = 0;
            // 
            // txtAccessType
            // 
            this.txtAccessType.AllowDrag = false;
            this.txtAccessType.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtAccessType.Location = new System.Drawing.Point(175, 148);
            this.txtAccessType.Name = "txtAccessType";
            this.txtAccessType.Size = new System.Drawing.Size(248, 23);
            this.txtAccessType.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(453, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 37.43842F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 62.56158F));
            this.tableLayoutPanel2.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCreateBy, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCreateTime, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtUpdateBy, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtUpdateTime, 2, 4);
            this.tableLayoutPanel2.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.tableLayoutPanel2.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(447, 149);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Update TIme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create By";
            // 
            // txtCreateBy
            // 
            this.txtCreateBy.AllowDrag = false;
            this.txtCreateBy.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCreateBy.Location = new System.Drawing.Point(175, 32);
            this.txtCreateBy.Name = "txtCreateBy";
            this.txtCreateBy.ReadOnly = true;
            this.txtCreateBy.Size = new System.Drawing.Size(248, 23);
            this.txtCreateBy.TabIndex = 0;
            // 
            // txtCreateTime
            // 
            this.txtCreateTime.AllowDrag = false;
            this.txtCreateTime.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtCreateTime.Location = new System.Drawing.Point(175, 61);
            this.txtCreateTime.Name = "txtCreateTime";
            this.txtCreateTime.ReadOnly = true;
            this.txtCreateTime.Size = new System.Drawing.Size(248, 23);
            this.txtCreateTime.TabIndex = 0;
            // 
            // txtUpdateBy
            // 
            this.txtUpdateBy.AllowDrag = false;
            this.txtUpdateBy.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtUpdateBy.Location = new System.Drawing.Point(175, 90);
            this.txtUpdateBy.Name = "txtUpdateBy";
            this.txtUpdateBy.ReadOnly = true;
            this.txtUpdateBy.Size = new System.Drawing.Size(248, 23);
            this.txtUpdateBy.TabIndex = 0;
            // 
            // txtUpdateTime
            // 
            this.txtUpdateTime.AllowDrag = false;
            this.txtUpdateTime.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtUpdateTime.Location = new System.Drawing.Point(175, 119);
            this.txtUpdateTime.Name = "txtUpdateTime";
            this.txtUpdateTime.ReadOnly = true;
            this.txtUpdateTime.Size = new System.Drawing.Size(248, 27);
            this.txtUpdateTime.TabIndex = 0;
            // 
            // f_areas_ref
            // 
            this.Controls.Add(this.tcontrol);
            this.Controls.Add(this.panel1);
            this.Size = new System.Drawing.Size(461, 466);
            this.Text = "f_areas_ref";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcontrol)).EndInit();
            this.tcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdCancel;
        private Button cmdSave;
        private Button cmdNew;
        private Panel panel1;
        private TabControl tcontrol;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtCreateBy;
        private TextBox txtCreateTime;
        private TextBox txtUpdateBy;
        private TextBox txtUpdateTime;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox chkActive;
        private TextBox txtWarehouseID;
        private TextBox txtAreaID;
        private TextBox txtDescription;
        private TextBox txtExternalID;
        private TextBox txtAccessType;


    }
}