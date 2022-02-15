
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.leftMainPanel = new System.Windows.Forms.Panel();
            this.tagPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.subTagButton1 = new System.Windows.Forms.Button();
            this.tagButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generatePass = new System.Windows.Forms.Button();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.safepassdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._safepass_dbDataSet = new MainMenu_Prototype._safepass_dbDataSet();
            this.addTagButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftMainPanel.SuspendLayout();
            this.tagPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safepassdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._safepass_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftMainPanel
            // 
            this.leftMainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.leftMainPanel.Controls.Add(this.tagPanel);
            this.leftMainPanel.Controls.Add(this.button1);
            this.leftMainPanel.Controls.Add(this.logoPanel);
            this.leftMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMainPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMainPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.leftMainPanel.Name = "leftMainPanel";
            this.leftMainPanel.Size = new System.Drawing.Size(400, 865);
            this.leftMainPanel.TabIndex = 0;
            // 
            // tagPanel
            // 
            this.tagPanel.BackColor = System.Drawing.Color.Transparent;
            this.tagPanel.Controls.Add(this.addTagButton);
            this.tagPanel.Controls.Add(this.button5);
            this.tagPanel.Controls.Add(this.button4);
            this.tagPanel.Controls.Add(this.button3);
            this.tagPanel.Controls.Add(this.button2);
            this.tagPanel.Controls.Add(this.subTagButton1);
            this.tagPanel.Controls.Add(this.tagButton);
            this.tagPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tagPanel.Location = new System.Drawing.Point(0, 175);
            this.tagPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tagPanel.Name = "tagPanel";
            this.tagPanel.Size = new System.Drawing.Size(400, 469);
            this.tagPanel.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 326);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(400, 67);
            this.button5.TabIndex = 5;
            this.button5.Text = "Category2";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 259);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 67);
            this.button4.TabIndex = 4;
            this.button4.Text = "Favorite";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 192);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(400, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Shopping";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 125);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Social";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // subTagButton1
            // 
            this.subTagButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.subTagButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.subTagButton1.FlatAppearance.BorderSize = 0;
            this.subTagButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subTagButton1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTagButton1.Location = new System.Drawing.Point(0, 58);
            this.subTagButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.subTagButton1.Name = "subTagButton1";
            this.subTagButton1.Size = new System.Drawing.Size(400, 67);
            this.subTagButton1.TabIndex = 1;
            this.subTagButton1.Text = "Email";
            this.subTagButton1.UseVisualStyleBackColor = false;
            // 
            // tagButton
            // 
            this.tagButton.BackColor = System.Drawing.Color.Transparent;
            this.tagButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tagButton.FlatAppearance.BorderSize = 0;
            this.tagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagButton.Location = new System.Drawing.Point(0, 0);
            this.tagButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tagButton.Name = "tagButton";
            this.tagButton.Size = new System.Drawing.Size(400, 58);
            this.tagButton.TabIndex = 0;
            this.tagButton.Text = "Categories";
            this.tagButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tagButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(0, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 79);
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
            this.logoPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(400, 96);
            this.logoPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.generatePass);
            this.panel1.Controls.Add(this.addEntryButton);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(400, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 1;
            // 
            // generatePass
            // 
            this.generatePass.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold);
            this.generatePass.Location = new System.Drawing.Point(708, 0);
            this.generatePass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.generatePass.Name = "generatePass";
            this.generatePass.Size = new System.Drawing.Size(250, 100);
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
            this.addEntryButton.Location = new System.Drawing.Point(968, 0);
            this.addEntryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(232, 100);
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
            this.searchBox.Location = new System.Drawing.Point(64, 27);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(596, 50);
            this.searchBox.TabIndex = 0;
            this.searchBox.Text = "Search Vault";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(400, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 765);
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
            this.noteCol});
            this.dataView.DataSource = this.safepassdbDataSetBindingSource;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataView.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataView.GridColor = System.Drawing.Color.Silver;
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataView.Size = new System.Drawing.Size(1200, 765);
            this.dataView.TabIndex = 0;
            this.dataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellValueChanged);
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
            // addTagButton
            // 
            this.addTagButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addTagButton.FlatAppearance.BorderSize = 0;
            this.addTagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTagButton.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTagButton.Image = ((System.Drawing.Image)(resources.GetObject("addTagButton.Image")));
            this.addTagButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTagButton.Location = new System.Drawing.Point(0, 393);
            this.addTagButton.Margin = new System.Windows.Forms.Padding(6);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Padding = new System.Windows.Forms.Padding(50, 0, 40, 0);
            this.addTagButton.Size = new System.Drawing.Size(400, 75);
            this.addTagButton.TabIndex = 6;
            this.addTagButton.Text = "Add Tag";
            this.addTagButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainMenu_Prototype.Properties.Resources.white_logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftMainPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.leftMainPanel.ResumeLayout(false);
            this.tagPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safepassdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._safepass_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftMainPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel tagPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button subTagButton1;
        private System.Windows.Forms.Button tagButton;
        private System.Windows.Forms.Button addTagButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource safepassdbDataSetBindingSource;
        private _safepass_dbDataSet _safepass_dbDataSet;
        private System.Windows.Forms.Button generatePass;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteCol;
    }
}

