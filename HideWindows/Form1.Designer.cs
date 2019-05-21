namespace HideWindows
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
            this.ShowHideButton = new System.Windows.Forms.Button();
            this.AppNameTextBox = new System.Windows.Forms.TextBox();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.previousApp = new System.Windows.Forms.Button();
            this.nextApp = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.currentAppLabel = new System.Windows.Forms.Label();
            this.clearCurrentButton = new System.Windows.Forms.Button();
            this.browseProcessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowHideButton
            // 
            this.ShowHideButton.Location = new System.Drawing.Point(64, 137);
            this.ShowHideButton.Name = "ShowHideButton";
            this.ShowHideButton.Size = new System.Drawing.Size(156, 35);
            this.ShowHideButton.TabIndex = 0;
            this.ShowHideButton.Text = "Show / Hide";
            this.ShowHideButton.UseVisualStyleBackColor = true;
            this.ShowHideButton.Click += new System.EventHandler(this.ShowHideButton_Click);
            // 
            // AppNameTextBox
            // 
            this.AppNameTextBox.Location = new System.Drawing.Point(114, 36);
            this.AppNameTextBox.Name = "AppNameTextBox";
            this.AppNameTextBox.Size = new System.Drawing.Size(158, 20);
            this.AppNameTextBox.TabIndex = 1;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Location = new System.Drawing.Point(12, 39);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(96, 13);
            this.AppNameLabel.TabIndex = 2;
            this.AppNameLabel.Text = "Application Name :";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WelcomeLabel.Location = new System.Drawing.Point(44, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(196, 24);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome To Hide Me";
            // 
            // previousApp
            // 
            this.previousApp.Location = new System.Drawing.Point(128, 96);
            this.previousApp.Name = "previousApp";
            this.previousApp.Size = new System.Drawing.Size(35, 35);
            this.previousApp.TabIndex = 4;
            this.previousApp.Text = "<";
            this.previousApp.UseVisualStyleBackColor = true;
            this.previousApp.Click += new System.EventHandler(this.previousApp_Click);
            // 
            // nextApp
            // 
            this.nextApp.Location = new System.Drawing.Point(169, 96);
            this.nextApp.Name = "nextApp";
            this.nextApp.Size = new System.Drawing.Size(35, 35);
            this.nextApp.TabIndex = 5;
            this.nextApp.Text = ">";
            this.nextApp.UseVisualStyleBackColor = true;
            this.nextApp.Click += new System.EventHandler(this.nextApp_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(226, 142);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(46, 25);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // currentAppLabel
            // 
            this.currentAppLabel.AutoSize = true;
            this.currentAppLabel.Location = new System.Drawing.Point(210, 107);
            this.currentAppLabel.Name = "currentAppLabel";
            this.currentAppLabel.Size = new System.Drawing.Size(47, 13);
            this.currentAppLabel.TabIndex = 8;
            this.currentAppLabel.Text = "Current :";
            // 
            // clearCurrentButton
            // 
            this.clearCurrentButton.Location = new System.Drawing.Point(64, 96);
            this.clearCurrentButton.Name = "clearCurrentButton";
            this.clearCurrentButton.Size = new System.Drawing.Size(58, 35);
            this.clearCurrentButton.TabIndex = 9;
            this.clearCurrentButton.Text = "Clear Current";
            this.clearCurrentButton.UseVisualStyleBackColor = true;
            this.clearCurrentButton.Click += new System.EventHandler(this.clearCurrentButton_Click);
            // 
            // browseProcessButton
            // 
            this.browseProcessButton.Location = new System.Drawing.Point(89, 62);
            this.browseProcessButton.Name = "browseProcessButton";
            this.browseProcessButton.Size = new System.Drawing.Size(106, 28);
            this.browseProcessButton.TabIndex = 10;
            this.browseProcessButton.Text = "Browse Processes";
            this.browseProcessButton.UseVisualStyleBackColor = true;
            this.browseProcessButton.Click += new System.EventHandler(this.browseProcessButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.browseProcessButton);
            this.Controls.Add(this.clearCurrentButton);
            this.Controls.Add(this.currentAppLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.nextApp);
            this.Controls.Add(this.previousApp);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.AppNameLabel);
            this.Controls.Add(this.AppNameTextBox);
            this.Controls.Add(this.ShowHideButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 222);
            this.MinimumSize = new System.Drawing.Size(300, 222);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Hide Windows V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowHideButton;
        private System.Windows.Forms.TextBox AppNameTextBox;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button previousApp;
        private System.Windows.Forms.Button nextApp;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label currentAppLabel;
        private System.Windows.Forms.Button clearCurrentButton;
        private System.Windows.Forms.Button browseProcessButton;
    }
}

