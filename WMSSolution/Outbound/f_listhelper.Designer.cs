using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace WMSSolution.Outbound
{
    partial class f_listhelper
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
            this.cmdSelect = new Gizmox.WebGUI.Forms.Button();
            this.cmdCancel = new Gizmox.WebGUI.Forms.Button();
            this.panel2 = new Gizmox.WebGUI.Forms.Panel();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.gv = new Gizmox.WebGUI.Forms.DataGridView();
            this.tableLayoutPanel1 = new Gizmox.WebGUI.Forms.TableLayoutPanel();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txtID = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDescription = new Gizmox.WebGUI.Forms.TextBox();
            this.cmdSearch = new Gizmox.WebGUI.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSelect
            // 
            this.cmdSelect.Dock = Gizmox.WebGUI.Forms.DockStyle.Right;
            this.cmdSelect.Location = new System.Drawing.Point(807, 0);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(75, 32);
            this.cmdSelect.TabIndex = 0;
            this.cmdSelect.Text = "Select";
            this.cmdSelect.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Dock = Gizmox.WebGUI.Forms.DockStyle.Right;
            this.cmdCancel.Location = new System.Drawing.Point(882, 0);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 32);
            this.cmdCancel.TabIndex = 0;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdSelect);
            this.panel2.Controls.Add(this.cmdCancel);
            this.panel2.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 32);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 120);
            this.panel1.TabIndex = 0;
            // 
            // gv
            // 
            this.gv.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.gv.ColumnHeadersHeightSizeMode = Gizmox.WebGUI.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.gv.Location = new System.Drawing.Point(0, 120);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.RowTemplate.DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-US");
            this.gv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(957, 414);
            this.gv.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = Gizmox.WebGUI.Forms.TableLayoutPanelCellBorderStyle.None;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 382F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Gizmox.WebGUI.Forms.ColumnStyle(Gizmox.WebGUI.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmdSearch, 3, 1);
            this.tableLayoutPanel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = Gizmox.WebGUI.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new Gizmox.WebGUI.Forms.RowStyle(Gizmox.WebGUI.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // txtID
            // 
            this.txtID.AllowDrag = false;
            this.txtID.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtID.Location = new System.Drawing.Point(104, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(376, 24);
            this.txtID.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.AllowDrag = false;
            this.txtDescription.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(104, 63);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(376, 24);
            this.txtDescription.TabIndex = 0;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.cmdSearch.Location = new System.Drawing.Point(483, 30);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(79, 30);
            this.cmdSearch.TabIndex = 0;
            this.cmdSearch.Text = "Search";
            // 
            // f_listhelper
            // 
            this.Controls.Add(this.gv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Size = new System.Drawing.Size(957, 566);
            this.Text = "f_listhelper";
            this.Load += new System.EventHandler(this.f_listhelper_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button cmdSelect;
        private Button cmdCancel;
        private Panel panel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private DataGridView gv;
        private TextBox txtID;
        private TextBox txtDescription;
        private Button cmdSearch;


    }
}