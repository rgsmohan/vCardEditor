﻿namespace vCardEditor.View
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbsOpen = new System.Windows.Forms.ToolStripButton();
            this.tbsSave = new System.Windows.Forms.ToolStripButton();
            this.tbsDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbsAbout = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bsContacts = new System.Windows.Forms.BindingSource(this.components);
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CellularPhoneValue = new System.Windows.Forms.TextBox();
            this.CellularPhoneLabel = new System.Windows.Forms.Label();
            this.HomePhoneValue = new System.Windows.Forms.TextBox();
            this.FormattedNameValue = new System.Windows.Forms.TextBox();
            this.HomePhoneLabel = new System.Windows.Forms.Label();
            this.FormattedNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(676, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsOpen,
            this.tbsSave,
            this.tbsDelete,
            this.toolStripSeparator1,
            this.tbsAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbsOpen
            // 
            this.tbsOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbsOpen.Image")));
            this.tbsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsOpen.Name = "tbsOpen";
            this.tbsOpen.Size = new System.Drawing.Size(23, 22);
            this.tbsOpen.Text = "&Open";
            this.tbsOpen.Click += new System.EventHandler(this.tbsOpen_Click);
            // 
            // tbsSave
            // 
            this.tbsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsSave.Image = ((System.Drawing.Image)(resources.GetObject("tbsSave.Image")));
            this.tbsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsSave.Name = "tbsSave";
            this.tbsSave.Size = new System.Drawing.Size(23, 22);
            this.tbsSave.Text = "&Save";
            this.tbsSave.Click += new System.EventHandler(this.tbsSave_Click);
            // 
            // tbsDelete
            // 
            this.tbsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tbsDelete.Image")));
            this.tbsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsDelete.Name = "tbsDelete";
            this.tbsDelete.Size = new System.Drawing.Size(23, 22);
            this.tbsDelete.Text = "Delete";
            this.tbsDelete.Click += new System.EventHandler(this.tbsDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbsAbout
            // 
            this.tbsAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsAbout.Image = ((System.Drawing.Image)(resources.GetObject("tbsAbout.Image")));
            this.tbsAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsAbout.Name = "tbsAbout";
            this.tbsAbout.Size = new System.Drawing.Size(23, 22);
            this.tbsAbout.Text = "&?";
            this.tbsAbout.Click += new System.EventHandler(this.tbsAbout_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dgContacts
            // 
            this.dgContacts.AllowUserToAddRows = false;
            this.dgContacts.AllowUserToDeleteRows = false;
            this.dgContacts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgContacts.AutoGenerateColumns = false;
            this.dgContacts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgContacts.DataSource = this.bsContacts;
            this.dgContacts.Location = new System.Drawing.Point(12, 52);
            this.dgContacts.MultiSelect = false;
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.RowHeadersVisible = false;
            this.dgContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContacts.Size = new System.Drawing.Size(191, 376);
            this.dgContacts.TabIndex = 3;
            this.dgContacts.SelectionChanged += new System.EventHandler(this.dgContacts_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "isSelected";
            this.Column1.HeaderText = " ";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CellularPhoneValue);
            this.groupBox1.Controls.Add(this.CellularPhoneLabel);
            this.groupBox1.Controls.Add(this.HomePhoneValue);
            this.groupBox1.Controls.Add(this.FormattedNameValue);
            this.groupBox1.Controls.Add(this.HomePhoneLabel);
            this.groupBox1.Controls.Add(this.FormattedNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(209, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 376);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Detail :";
            // 
            // CellularPhoneValue
            // 
            this.CellularPhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CellularPhoneValue.Location = new System.Drawing.Point(105, 92);
            this.CellularPhoneValue.Name = "CellularPhoneValue";
            this.CellularPhoneValue.Size = new System.Drawing.Size(321, 20);
            this.CellularPhoneValue.TabIndex = 47;
            // 
            // CellularPhoneLabel
            // 
            this.CellularPhoneLabel.Location = new System.Drawing.Point(16, 92);
            this.CellularPhoneLabel.Name = "CellularPhoneLabel";
            this.CellularPhoneLabel.Size = new System.Drawing.Size(83, 19);
            this.CellularPhoneLabel.TabIndex = 46;
            this.CellularPhoneLabel.Text = "Mobile:";
            this.CellularPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomePhoneValue
            // 
            this.HomePhoneValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomePhoneValue.Location = new System.Drawing.Point(105, 65);
            this.HomePhoneValue.Name = "HomePhoneValue";
            this.HomePhoneValue.Size = new System.Drawing.Size(321, 20);
            this.HomePhoneValue.TabIndex = 45;
            // 
            // FormattedNameValue
            // 
            this.FormattedNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormattedNameValue.Location = new System.Drawing.Point(105, 38);
            this.FormattedNameValue.Name = "FormattedNameValue";
            this.FormattedNameValue.Size = new System.Drawing.Size(321, 20);
            this.FormattedNameValue.TabIndex = 44;
            // 
            // HomePhoneLabel
            // 
            this.HomePhoneLabel.Location = new System.Drawing.Point(16, 65);
            this.HomePhoneLabel.Name = "HomePhoneLabel";
            this.HomePhoneLabel.Size = new System.Drawing.Size(83, 19);
            this.HomePhoneLabel.TabIndex = 43;
            this.HomePhoneLabel.Text = "Home Phone:";
            this.HomePhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormattedNameLabel
            // 
            this.FormattedNameLabel.Location = new System.Drawing.Point(16, 38);
            this.FormattedNameLabel.Name = "FormattedNameLabel";
            this.FormattedNameLabel.Size = new System.Drawing.Size(83, 19);
            this.FormattedNameLabel.TabIndex = 42;
            this.FormattedNameLabel.Text = "Name:";
            this.FormattedNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgContacts);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbsOpen;
        private System.Windows.Forms.ToolStripButton tbsSave;
        private System.Windows.Forms.ToolStripButton tbsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbsAbout;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource bsContacts;
        private System.Windows.Forms.DataGridView dgContacts;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox CellularPhoneValue;
        internal System.Windows.Forms.Label CellularPhoneLabel;
        internal System.Windows.Forms.TextBox HomePhoneValue;
        internal System.Windows.Forms.TextBox FormattedNameValue;
        internal System.Windows.Forms.Label HomePhoneLabel;
        internal System.Windows.Forms.Label FormattedNameLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}