namespace ProcessesBrowser
{
    partial class ProcessBrowser
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.processesListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.machineNameTextBox = new System.Windows.Forms.TextBox();
            this.prcTitleTextBox = new System.Windows.Forms.TextBox();
            this.prcNameTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.machineNameLabel = new System.Windows.Forms.Label();
            this.prcTitleLabel = new System.Windows.Forms.Label();
            this.prcNameLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.propertiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(81, 32);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // processesListBox
            // 
            this.processesListBox.FormattingEnabled = true;
            this.processesListBox.HorizontalScrollbar = true;
            this.processesListBox.Location = new System.Drawing.Point(14, 57);
            this.processesListBox.Name = "processesListBox";
            this.processesListBox.Size = new System.Drawing.Size(258, 329);
            this.processesListBox.TabIndex = 1;
            this.processesListBox.SelectedIndexChanged += new System.EventHandler(this.processesListBox_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(412, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 32);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Controls.Add(this.idTextBox);
            this.propertiesGroupBox.Controls.Add(this.machineNameTextBox);
            this.propertiesGroupBox.Controls.Add(this.prcTitleTextBox);
            this.propertiesGroupBox.Controls.Add(this.prcNameTextBox);
            this.propertiesGroupBox.Controls.Add(this.idLabel);
            this.propertiesGroupBox.Controls.Add(this.machineNameLabel);
            this.propertiesGroupBox.Controls.Add(this.prcTitleLabel);
            this.propertiesGroupBox.Controls.Add(this.prcNameLabel);
            this.propertiesGroupBox.Location = new System.Drawing.Point(278, 57);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(302, 208);
            this.propertiesGroupBox.TabIndex = 3;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Properties";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(94, 166);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(202, 20);
            this.idTextBox.TabIndex = 7;
            // 
            // machineNameTextBox
            // 
            this.machineNameTextBox.Location = new System.Drawing.Point(94, 120);
            this.machineNameTextBox.Name = "machineNameTextBox";
            this.machineNameTextBox.ReadOnly = true;
            this.machineNameTextBox.Size = new System.Drawing.Size(202, 20);
            this.machineNameTextBox.TabIndex = 6;
            // 
            // prcTitleTextBox
            // 
            this.prcTitleTextBox.Location = new System.Drawing.Point(94, 74);
            this.prcTitleTextBox.Name = "prcTitleTextBox";
            this.prcTitleTextBox.ReadOnly = true;
            this.prcTitleTextBox.Size = new System.Drawing.Size(202, 20);
            this.prcTitleTextBox.TabIndex = 5;
            // 
            // prcNameTextBox
            // 
            this.prcNameTextBox.Location = new System.Drawing.Point(94, 28);
            this.prcNameTextBox.Name = "prcNameTextBox";
            this.prcNameTextBox.ReadOnly = true;
            this.prcNameTextBox.Size = new System.Drawing.Size(202, 20);
            this.prcNameTextBox.TabIndex = 4;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.idLabel.Location = new System.Drawing.Point(6, 169);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID :";
            // 
            // machineNameLabel
            // 
            this.machineNameLabel.AutoSize = true;
            this.machineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.machineNameLabel.Location = new System.Drawing.Point(6, 123);
            this.machineNameLabel.Name = "machineNameLabel";
            this.machineNameLabel.Size = new System.Drawing.Size(85, 13);
            this.machineNameLabel.TabIndex = 2;
            this.machineNameLabel.Text = "Machine Name :";
            // 
            // prcTitleLabel
            // 
            this.prcTitleLabel.AutoSize = true;
            this.prcTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.prcTitleLabel.Location = new System.Drawing.Point(6, 77);
            this.prcTitleLabel.Name = "prcTitleLabel";
            this.prcTitleLabel.Size = new System.Drawing.Size(33, 13);
            this.prcTitleLabel.TabIndex = 1;
            this.prcTitleLabel.Text = "Title :";
            // 
            // prcNameLabel
            // 
            this.prcNameLabel.AutoSize = true;
            this.prcNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.prcNameLabel.Location = new System.Drawing.Point(6, 31);
            this.prcNameLabel.Name = "prcNameLabel";
            this.prcNameLabel.Size = new System.Drawing.Size(82, 13);
            this.prcNameLabel.TabIndex = 0;
            this.prcNameLabel.Text = "Process Name :";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(499, 354);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(81, 32);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // processBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 398);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.propertiesGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.processesListBox);
            this.Controls.Add(this.refreshButton);
            this.Name = "mainForm";
            this.Text = "Processes Browser";
            this.Load += new System.EventHandler(this.processBrowser_Load);
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ListBox processesListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.Label prcNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label machineNameLabel;
        private System.Windows.Forms.Label prcTitleLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox machineNameTextBox;
        private System.Windows.Forms.TextBox prcTitleTextBox;
        private System.Windows.Forms.TextBox prcNameTextBox;
        private System.Windows.Forms.Button okButton;
    }
}

