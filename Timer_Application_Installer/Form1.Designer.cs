namespace Timer_Application_Installer
{
    partial class Installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installer));
            this.Installing = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishPanel = new System.Windows.Forms.Panel();
            this.FinishButton = new System.Windows.Forms.Button();
            this.StartApp = new System.Windows.Forms.CheckBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.InstallProgress = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Installing.SuspendLayout();
            this.FinishPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Installing
            // 
            this.Installing.Controls.Add(this.InstallProgress);
            this.Installing.Controls.Add(this.label1);
            this.Installing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Installing.Location = new System.Drawing.Point(0, 51);
            this.Installing.Name = "Installing";
            this.Installing.Size = new System.Drawing.Size(476, 187);
            this.Installing.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Installing...";
            // 
            // FinishPanel
            // 
            this.FinishPanel.Controls.Add(this.FinishButton);
            this.FinishPanel.Controls.Add(this.StartApp);
            this.FinishPanel.Controls.Add(this.MessageLabel);
            this.FinishPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinishPanel.Location = new System.Drawing.Point(0, 51);
            this.FinishPanel.Name = "FinishPanel";
            this.FinishPanel.Size = new System.Drawing.Size(476, 187);
            this.FinishPanel.TabIndex = 2;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(389, 157);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 23);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // StartApp
            // 
            this.StartApp.AutoSize = true;
            this.StartApp.Checked = true;
            this.StartApp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StartApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartApp.Location = new System.Drawing.Point(73, 102);
            this.StartApp.Name = "StartApp";
            this.StartApp.Size = new System.Drawing.Size(170, 22);
            this.StartApp.TabIndex = 3;
            this.StartApp.Text = "Start Time Application";
            this.StartApp.UseVisualStyleBackColor = true;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(69, 13);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(173, 48);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "The Timer Application has been installed!";
            // 
            // InstallProgress
            // 
            this.InstallProgress.Location = new System.Drawing.Point(49, 128);
            this.InstallProgress.Maximum = 10;
            this.InstallProgress.Name = "InstallProgress";
            this.InstallProgress.Size = new System.Drawing.Size(381, 23);
            this.InstallProgress.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 51);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(54, 11);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(77, 29);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Timer";
            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(476, 238);
            this.Controls.Add(this.Installing);
            this.Controls.Add(this.FinishPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Installer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Installer_Load);
            this.Installing.ResumeLayout(false);
            this.Installing.PerformLayout();
            this.FinishPanel.ResumeLayout(false);
            this.FinishPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Installing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel FinishPanel;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.CheckBox StartApp;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.ProgressBar InstallProgress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

