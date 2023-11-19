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
            this.InstallProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishPanel = new System.Windows.Forms.Panel();
            this.FinishButton = new System.Windows.Forms.Button();
            this.StartApp = new System.Windows.Forms.CheckBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ErrorPictureBox = new System.Windows.Forms.PictureBox();
            this.Installing.SuspendLayout();
            this.FinishPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.ErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPictureBox)).BeginInit();
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
            // InstallProgress
            // 
            this.InstallProgress.Location = new System.Drawing.Point(49, 128);
            this.InstallProgress.Maximum = 10;
            this.InstallProgress.Name = "InstallProgress";
            this.InstallProgress.Size = new System.Drawing.Size(381, 23);
            this.InstallProgress.TabIndex = 2;
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
            this.FinishPanel.Visible = false;
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
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.NameLabel);
            this.HeaderPanel.Controls.Add(this.IconPictureBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(476, 51);
            this.HeaderPanel.TabIndex = 3;
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
            // IconPictureBox
            // 
            this.IconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IconPictureBox.Image")));
            this.IconPictureBox.Location = new System.Drawing.Point(3, 3);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(45, 45);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.Controls.Add(this.ErrorPictureBox);
            this.ErrorPanel.Controls.Add(this.CloseButton);
            this.ErrorPanel.Controls.Add(this.ErrorLabel);
            this.ErrorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorPanel.Location = new System.Drawing.Point(0, 51);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(476, 187);
            this.ErrorPanel.TabIndex = 4;
            this.ErrorPanel.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(389, 157);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(109, 61);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(274, 48);
            this.ErrorLabel.TabIndex = 2;
            this.ErrorLabel.Text = "Unfortunately something went wrong. Please try again later.";
            // 
            // ErrorPictureBox
            // 
            this.ErrorPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ErrorPictureBox.Image")));
            this.ErrorPictureBox.Location = new System.Drawing.Point(37, 52);
            this.ErrorPictureBox.Name = "ErrorPictureBox";
            this.ErrorPictureBox.Size = new System.Drawing.Size(60, 60);
            this.ErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorPictureBox.TabIndex = 5;
            this.ErrorPictureBox.TabStop = false;
            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(476, 238);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.Installing);
            this.Controls.Add(this.FinishPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Installer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Installer_Load);
            this.Installing.ResumeLayout(false);
            this.Installing.PerformLayout();
            this.FinishPanel.ResumeLayout(false);
            this.FinishPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ErrorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPictureBox)).EndInit();
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
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.PictureBox ErrorPictureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

