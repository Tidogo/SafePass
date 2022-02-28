namespace MainMenu_Prototype
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.btn_OpenEmail = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.help_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.help_goToEdit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.help_goToGenPass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.help_goToResMasPass = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OpenEmail
            // 
            this.btn_OpenEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenEmail.Location = new System.Drawing.Point(698, 381);
            this.btn_OpenEmail.Name = "btn_OpenEmail";
            this.btn_OpenEmail.Size = new System.Drawing.Size(90, 57);
            this.btn_OpenEmail.TabIndex = 0;
            this.btn_OpenEmail.Text = "Email Us";
            this.btn_OpenEmail.UseVisualStyleBackColor = true;
            this.btn_OpenEmail.Click += new System.EventHandler(this.btn_OpenEmail_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 381);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 57);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.logoPanel.Controls.Add(this.pictureBox2);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(800, 50);
            this.logoPanel.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MainMenu_Prototype.Properties.Resources.white_logo;
            this.pictureBox2.Location = new System.Drawing.Point(7, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 49);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(739, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "The SafePass Password Manager made it simple to store your passwords all at one p" +
    "lace!";
            // 
            // help_label1
            // 
            this.help_label1.AutoSize = true;
            this.help_label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_label1.Location = new System.Drawing.Point(12, 114);
            this.help_label1.Name = "help_label1";
            this.help_label1.Size = new System.Drawing.Size(409, 19);
            this.help_label1.TabIndex = 5;
            this.help_label1.Text = "You can view all your saved passwords in the main menu window.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "To add a new password Press                  in the top right corner.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edit Entry";
            // 
            // help_goToEdit
            // 
            this.help_goToEdit.AutoSize = true;
            this.help_goToEdit.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_goToEdit.ForeColor = System.Drawing.Color.DarkCyan;
            this.help_goToEdit.Location = new System.Drawing.Point(405, 152);
            this.help_goToEdit.Name = "help_goToEdit";
            this.help_goToEdit.Size = new System.Drawing.Size(260, 19);
            this.help_goToEdit.TabIndex = 8;
            this.help_goToEdit.Text = "Click here to go to Edit Entry window.";
            this.help_goToEdit.Click += new System.EventHandler(this.help_goToEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(726, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "SafePass can also create safe passwords for your accounts! Press                 " +
    "                  button in the top right corner.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Generate Password";
            // 
            // help_goToGenPass
            // 
            this.help_goToGenPass.AutoSize = true;
            this.help_goToGenPass.BackColor = System.Drawing.Color.Transparent;
            this.help_goToGenPass.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_goToGenPass.ForeColor = System.Drawing.Color.DarkCyan;
            this.help_goToGenPass.Location = new System.Drawing.Point(736, 190);
            this.help_goToGenPass.Name = "help_goToGenPass";
            this.help_goToGenPass.Size = new System.Drawing.Size(64, 19);
            this.help_goToGenPass.TabIndex = 11;
            this.help_goToGenPass.Text = "Or here.";
            this.help_goToGenPass.Click += new System.EventHandler(this.help_goToGenPass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(503, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "To reset your Master Password, Press                                in the top ri" +
    "ght corner.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Reset Master Pass";
            // 
            // help_goToResMasPass
            // 
            this.help_goToResMasPass.AutoSize = true;
            this.help_goToResMasPass.BackColor = System.Drawing.Color.Transparent;
            this.help_goToResMasPass.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_goToResMasPass.ForeColor = System.Drawing.Color.DarkCyan;
            this.help_goToResMasPass.Location = new System.Drawing.Point(512, 228);
            this.help_goToResMasPass.Name = "help_goToResMasPass";
            this.help_goToResMasPass.Size = new System.Drawing.Size(252, 19);
            this.help_goToResMasPass.TabIndex = 14;
            this.help_goToResMasPass.Text = "Click here to reset Master Password.";
            this.help_goToResMasPass.Click += new System.EventHandler(this.help_goToResMasPass_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "If you are having diffuculties using SafePass email us using the";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(396, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email Us";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(457, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "button in the lower right corner.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(179, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(325, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "We really appreciate you for using SafePass - ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(498, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "SafePass Team";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.help_goToResMasPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.help_goToGenPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.help_goToEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.help_label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_OpenEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelp";
            this.Text = "frmHelp";
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenEmail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label help_label1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label help_goToEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label help_goToGenPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label help_goToResMasPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}