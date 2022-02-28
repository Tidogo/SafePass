namespace MainMenu_Prototype
{
    partial class frmGenPass
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
            this.triggerPassGen = new System.Windows.Forms.Button();
            this.passLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.copyToClip = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).BeginInit();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // triggerPassGen
            // 
            this.triggerPassGen.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold);
            this.triggerPassGen.Location = new System.Drawing.Point(220, 187);
            this.triggerPassGen.Name = "triggerPassGen";
            this.triggerPassGen.Size = new System.Drawing.Size(306, 50);
            this.triggerPassGen.TabIndex = 0;
            this.triggerPassGen.Text = "Create Password";
            this.triggerPassGen.UseVisualStyleBackColor = true;
            this.triggerPassGen.Click += new System.EventHandler(this.triggerPassGen_Click);
            // 
            // passLength
            // 
            this.passLength.Location = new System.Drawing.Point(220, 142);
            this.passLength.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.passLength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.passLength.Name = "passLength";
            this.passLength.Size = new System.Drawing.Size(306, 20);
            this.passLength.TabIndex = 4;
            this.passLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Password Length (8-32 chars in length)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(220, 243);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(306, 41);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // copyToClip
            // 
            this.copyToClip.Location = new System.Drawing.Point(420, 290);
            this.copyToClip.Name = "copyToClip";
            this.copyToClip.Size = new System.Drawing.Size(106, 44);
            this.copyToClip.TabIndex = 7;
            this.copyToClip.Text = "Copy to Clipboard";
            this.copyToClip.UseVisualStyleBackColor = true;
            this.copyToClip.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.logoPanel.Controls.Add(this.pictureBox2);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(800, 50);
            this.logoPanel.TabIndex = 18;
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
            // frmGenPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.copyToClip);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLength);
            this.Controls.Add(this.triggerPassGen);
            this.Name = "frmGenPass";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).EndInit();
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button triggerPassGen;
        private System.Windows.Forms.NumericUpDown passLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button copyToClip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}