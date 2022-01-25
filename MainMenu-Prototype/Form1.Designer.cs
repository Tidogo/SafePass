
namespace MainMenu_Prototype
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftMainPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tagPanel = new System.Windows.Forms.Panel();
            this.tagButton = new System.Windows.Forms.Button();
            this.subTagButton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addTagButton = new System.Windows.Forms.Button();
            this.leftMainPanel.SuspendLayout();
            this.tagPanel.SuspendLayout();
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
            this.leftMainPanel.Name = "leftMainPanel";
            this.leftMainPanel.Size = new System.Drawing.Size(200, 450);
            this.leftMainPanel.TabIndex = 0;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 50);
            this.logoPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "My Vault";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
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
            this.tagPanel.Location = new System.Drawing.Point(0, 80);
            this.tagPanel.Name = "tagPanel";
            this.tagPanel.Size = new System.Drawing.Size(200, 244);
            this.tagPanel.TabIndex = 2;
            // 
            // tagButton
            // 
            this.tagButton.BackColor = System.Drawing.Color.Transparent;
            this.tagButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tagButton.FlatAppearance.BorderSize = 0;
            this.tagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tagButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagButton.Location = new System.Drawing.Point(0, 0);
            this.tagButton.Name = "tagButton";
            this.tagButton.Size = new System.Drawing.Size(200, 30);
            this.tagButton.TabIndex = 0;
            this.tagButton.Text = "Tags";
            this.tagButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tagButton.UseVisualStyleBackColor = false;
            // 
            // subTagButton1
            // 
            this.subTagButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.subTagButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.subTagButton1.FlatAppearance.BorderSize = 0;
            this.subTagButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subTagButton1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTagButton1.Location = new System.Drawing.Point(0, 30);
            this.subTagButton1.Name = "subTagButton1";
            this.subTagButton1.Size = new System.Drawing.Size(200, 35);
            this.subTagButton1.TabIndex = 1;
            this.subTagButton1.Text = "Favorites";
            this.subTagButton1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Favorites";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Favorites";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Favorites";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "Favorites";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // addTagButton
            // 
            this.addTagButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addTagButton.FlatAppearance.BorderSize = 0;
            this.addTagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTagButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTagButton.Image = ((System.Drawing.Image)(resources.GetObject("addTagButton.Image")));
            this.addTagButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTagButton.Location = new System.Drawing.Point(0, 205);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.addTagButton.Size = new System.Drawing.Size(200, 30);
            this.addTagButton.TabIndex = 6;
            this.addTagButton.Text = "Add Tag";
            this.addTagButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leftMainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.leftMainPanel.ResumeLayout(false);
            this.tagPanel.ResumeLayout(false);
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
    }
}

