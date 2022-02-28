using System.Windows.Forms;

namespace MainMenu_Prototype
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.leftMainPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetMasterPass = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.generatePass = new System.Windows.Forms.Button();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.usernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwstrength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safepassdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._safepass_dbDataSet = new MainMenu_Prototype._safepass_dbDataSet();
            this.leftMainPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safepassdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._safepass_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // leftMainPanel
            // 
            this.leftMainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.leftMainPanel.Controls.Add(this.btnHelp);
            this.leftMainPanel.Controls.Add(this.btnResetMasterPass);
            this.leftMainPanel.Controls.Add(this.generatePass);
            this.leftMainPanel.Controls.Add(this.button1);
            this.leftMainPanel.Controls.Add(this.logoPanel);
            this.leftMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMainPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMainPanel.Name = "leftMainPanel";
            this.leftMainPanel.Size = new System.Drawing.Size(195, 555);
            this.leftMainPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "My Vault";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(195, 50);
            this.logoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainMenu_Prototype.Properties.Resources.white_logo;
            this.pictureBox1.Location = new System.Drawing.Point(7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addEntryButton);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(195, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 52);
            this.panel1.TabIndex = 1;
            // 
            // btnResetMasterPass
            // 
            this.btnResetMasterPass.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnResetMasterPass.Location = new System.Drawing.Point(12, 110);
            this.btnResetMasterPass.Name = "btnResetMasterPass";
            this.btnResetMasterPass.Size = new System.Drawing.Size(118, 52);
            this.btnResetMasterPass.TabIndex = 4;
            this.btnResetMasterPass.Text = "Reset Master Pass";
            this.btnResetMasterPass.UseVisualStyleBackColor = true;
            this.btnResetMasterPass.Click += new System.EventHandler(this.btnResetMasterPass_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnHelp.Location = new System.Drawing.Point(12, 226);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(118, 52);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // generatePass
            // 
            this.generatePass.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold);
            this.generatePass.Location = new System.Drawing.Point(12, 168);
            this.generatePass.Name = "generatePass";
            this.generatePass.Size = new System.Drawing.Size(118, 52);
            this.generatePass.TabIndex = 2;
            this.generatePass.Text = "Generate Password";
            this.generatePass.UseVisualStyleBackColor = true;
            this.generatePass.Click += new System.EventHandler(this.generatePass_Click);
            // 
            // addEntryButton
            // 
            this.addEntryButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addEntryButton.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEntryButton.Location = new System.Drawing.Point(781, 0);
            this.addEntryButton.Margin = new System.Windows.Forms.Padding(2);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(74, 52);
            this.addEntryButton.TabIndex = 1;
            this.addEntryButton.Text = "Edit Entry";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchBox.Location = new System.Drawing.Point(32, 14);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(299, 29);
            this.searchBox.TabIndex = 0;
            this.searchBox.Text = "Search Vault";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(195, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 398);
            this.panel2.TabIndex = 2;
            // 
            // dataView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.AutoGenerateColumns = false;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView.ColumnHeadersHeight = 50;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameCol,
            this.passwordCol,
            this.serviceCol,
            this.categoryCol,
            this.noteCol,
            this.pwstrength});
            this.dataView.DataSource = this.safepassdbDataSetBindingSource;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataView.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataView.GridColor = System.Drawing.Color.Silver;
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Margin = new System.Windows.Forms.Padding(2);
            this.dataView.Name = "dataView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView.RowHeadersWidth = 198;
            this.dataView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataView.RowTemplate.Height = 33;
            this.dataView.Size = new System.Drawing.Size(855, 503);
            this.dataView.TabIndex = 0;
            this.dataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellValueChanged);
            // 
            // usernameCol
            // 
            this.usernameCol.DataPropertyName = "UserEmail";
            this.usernameCol.HeaderText = "Username";
            this.usernameCol.MinimumWidth = 10;
            this.usernameCol.Name = "usernameCol";
            // 
            // passwordCol
            // 
            this.passwordCol.DataPropertyName = "UserPW";
            this.passwordCol.HeaderText = "Password";
            this.passwordCol.MinimumWidth = 10;
            this.passwordCol.Name = "passwordCol";
            // 
            // serviceCol
            // 
            this.serviceCol.DataPropertyName = "ServiceName";
            this.serviceCol.HeaderText = "Service";
            this.serviceCol.MinimumWidth = 10;
            this.serviceCol.Name = "serviceCol";
            // 
            // categoryCol
            // 
            this.categoryCol.DataPropertyName = "Category";
            this.categoryCol.HeaderText = "Category";
            this.categoryCol.MinimumWidth = 10;
            this.categoryCol.Name = "categoryCol";
            // 
            // noteCol
            // 
            this.noteCol.DataPropertyName = "Notes";
            this.noteCol.HeaderText = "Notes";
            this.noteCol.MinimumWidth = 10;
            this.noteCol.Name = "noteCol";
            // 
            // pwstrength
            // 
            this.pwstrength.DataPropertyName = "UserPWSTR";
            this.pwstrength.HeaderText = "PW Strength";
            this.pwstrength.Name = "pwstrength";
            // 
            // safepassdbDataSetBindingSource
            // 
            this.safepassdbDataSetBindingSource.DataSource = this._safepass_dbDataSet;
            this.safepassdbDataSetBindingSource.Position = 0;
            // 
            // _safepass_dbDataSet
            // 
            this._safepass_dbDataSet.DataSetName = "_safepass_dbDataSet";
            this._safepass_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftMainPanel);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.leftMainPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safepassdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._safepass_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftMainPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource safepassdbDataSetBindingSource;
        private _safepass_dbDataSet _safepass_dbDataSet;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button generatePass;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwstrength;
        private Button btnHelp;
        private Button btnResetMasterPass;
    }
}

