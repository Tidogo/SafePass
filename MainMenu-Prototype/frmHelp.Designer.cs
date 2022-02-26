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
            this.btn_OpenEmail = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
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
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_OpenEmail);
            this.Name = "frmHelp";
            this.Text = "frmHelp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenEmail;
        private System.Windows.Forms.Button btnBack;
    }
}