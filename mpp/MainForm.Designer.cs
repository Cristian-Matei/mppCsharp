namespace mpp
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
            this.participantsGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.enterOneResultButton = new System.Windows.Forms.Button();
            this.enterAllResultsButton = new System.Windows.Forms.Button();
            this.refereeNameLabel = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.participantsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // participantsGridView
            // 
            this.participantsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantsGridView.Location = new System.Drawing.Point(41, 35);
            this.participantsGridView.Name = "participantsGridView";
            this.participantsGridView.RowTemplate.Height = 24;
            this.participantsGridView.Size = new System.Drawing.Size(594, 125);
            this.participantsGridView.TabIndex = 0;
            this.participantsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.participantsGridView_CellClick);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(41, 216);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(165, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.Location = new System.Drawing.Point(41, 281);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(165, 22);
            this.pointsTextBox.TabIndex = 2;
            // 
            // enterOneResultButton
            // 
            this.enterOneResultButton.Location = new System.Drawing.Point(41, 346);
            this.enterOneResultButton.Name = "enterOneResultButton";
            this.enterOneResultButton.Size = new System.Drawing.Size(125, 49);
            this.enterOneResultButton.TabIndex = 3;
            this.enterOneResultButton.Text = "Enter this result";
            this.enterOneResultButton.UseVisualStyleBackColor = true;
            this.enterOneResultButton.Click += new System.EventHandler(this.enterOneResultButton_Click);
            // 
            // enterAllResultsButton
            // 
            this.enterAllResultsButton.Location = new System.Drawing.Point(205, 346);
            this.enterAllResultsButton.Name = "enterAllResultsButton";
            this.enterAllResultsButton.Size = new System.Drawing.Size(120, 49);
            this.enterAllResultsButton.TabIndex = 4;
            this.enterAllResultsButton.Text = "Enter all results";
            this.enterAllResultsButton.UseVisualStyleBackColor = true;
            this.enterAllResultsButton.Click += new System.EventHandler(this.enterAllResultsButton_Click);
            // 
            // refereeNameLabel
            // 
            this.refereeNameLabel.AutoSize = true;
            this.refereeNameLabel.Location = new System.Drawing.Point(696, 63);
            this.refereeNameLabel.Name = "refereeNameLabel";
            this.refereeNameLabel.Size = new System.Drawing.Size(46, 17);
            this.refereeNameLabel.TabIndex = 5;
            this.refereeNameLabel.Text = "label1";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(452, 346);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(136, 49);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "Generate Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 573);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.refereeNameLabel);
            this.Controls.Add(this.enterAllResultsButton);
            this.Controls.Add(this.enterOneResultButton);
            this.Controls.Add(this.pointsTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.participantsGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.participantsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView participantsGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.Button enterOneResultButton;
        private System.Windows.Forms.Button enterAllResultsButton;
        private System.Windows.Forms.Label refereeNameLabel;
        private System.Windows.Forms.Button reportButton;
    }
}