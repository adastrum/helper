namespace Helper
{
    partial class NewActionForm
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
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.chkTerminateOnFailure = new System.Windows.Forms.CheckBox();
            this.nDelayBefore = new System.Windows.Forms.NumericUpDown();
            this.nDelayAfter = new System.Windows.Forms.NumericUpDown();
            this.nNumberOfAttempts = new System.Windows.Forms.NumericUpDown();
            this.nDelayBetweenAttempts = new System.Windows.Forms.NumericUpDown();
            this.lblActionType = new System.Windows.Forms.Label();
            this.lblDelayBefore = new System.Windows.Forms.Label();
            this.lblDelayAfter = new System.Windows.Forms.Label();
            this.lblNumberOfAttempts = new System.Windows.Forms.Label();
            this.lblDelayBetweenAttempts = new System.Windows.Forms.Label();
            this.lblTerminateOnFailure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nDelayBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDelayAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumberOfAttempts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDelayBetweenAttempts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbActionType
            // 
            this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionType.FormattingEnabled = true;
            this.cmbActionType.Location = new System.Drawing.Point(151, 12);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(121, 21);
            this.cmbActionType.TabIndex = 0;
            // 
            // chkTerminateOnFailure
            // 
            this.chkTerminateOnFailure.AutoSize = true;
            this.chkTerminateOnFailure.Location = new System.Drawing.Point(152, 39);
            this.chkTerminateOnFailure.Name = "chkTerminateOnFailure";
            this.chkTerminateOnFailure.Size = new System.Drawing.Size(15, 14);
            this.chkTerminateOnFailure.TabIndex = 1;
            this.chkTerminateOnFailure.UseVisualStyleBackColor = true;
            // 
            // nDelayBefore
            // 
            this.nDelayBefore.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nDelayBefore.Location = new System.Drawing.Point(152, 62);
            this.nDelayBefore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nDelayBefore.Name = "nDelayBefore";
            this.nDelayBefore.Size = new System.Drawing.Size(120, 20);
            this.nDelayBefore.TabIndex = 2;
            // 
            // nDelayAfter
            // 
            this.nDelayAfter.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nDelayAfter.Location = new System.Drawing.Point(152, 88);
            this.nDelayAfter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nDelayAfter.Name = "nDelayAfter";
            this.nDelayAfter.Size = new System.Drawing.Size(120, 20);
            this.nDelayAfter.TabIndex = 3;
            // 
            // nNumberOfAttempts
            // 
            this.nNumberOfAttempts.Location = new System.Drawing.Point(152, 114);
            this.nNumberOfAttempts.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nNumberOfAttempts.Name = "nNumberOfAttempts";
            this.nNumberOfAttempts.Size = new System.Drawing.Size(120, 20);
            this.nNumberOfAttempts.TabIndex = 4;
            // 
            // nDelayBetweenAttempts
            // 
            this.nDelayBetweenAttempts.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nDelayBetweenAttempts.Location = new System.Drawing.Point(152, 140);
            this.nDelayBetweenAttempts.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nDelayBetweenAttempts.Name = "nDelayBetweenAttempts";
            this.nDelayBetweenAttempts.Size = new System.Drawing.Size(120, 20);
            this.nDelayBetweenAttempts.TabIndex = 5;
            // 
            // lblActionType
            // 
            this.lblActionType.AutoSize = true;
            this.lblActionType.Location = new System.Drawing.Point(12, 15);
            this.lblActionType.Name = "lblActionType";
            this.lblActionType.Size = new System.Drawing.Size(60, 13);
            this.lblActionType.TabIndex = 1;
            this.lblActionType.Text = "Action type";
            // 
            // lblDelayBefore
            // 
            this.lblDelayBefore.AutoSize = true;
            this.lblDelayBefore.Location = new System.Drawing.Point(12, 64);
            this.lblDelayBefore.Name = "lblDelayBefore";
            this.lblDelayBefore.Size = new System.Drawing.Size(67, 13);
            this.lblDelayBefore.TabIndex = 1;
            this.lblDelayBefore.Text = "Delay before";
            // 
            // lblDelayAfter
            // 
            this.lblDelayAfter.AutoSize = true;
            this.lblDelayAfter.Location = new System.Drawing.Point(12, 90);
            this.lblDelayAfter.Name = "lblDelayAfter";
            this.lblDelayAfter.Size = new System.Drawing.Size(58, 13);
            this.lblDelayAfter.TabIndex = 1;
            this.lblDelayAfter.Text = "Delay after";
            // 
            // lblNumberOfAttempts
            // 
            this.lblNumberOfAttempts.AutoSize = true;
            this.lblNumberOfAttempts.Location = new System.Drawing.Point(12, 116);
            this.lblNumberOfAttempts.Name = "lblNumberOfAttempts";
            this.lblNumberOfAttempts.Size = new System.Drawing.Size(99, 13);
            this.lblNumberOfAttempts.TabIndex = 1;
            this.lblNumberOfAttempts.Text = "Number of attempts";
            // 
            // lblDelayBetweenAttempts
            // 
            this.lblDelayBetweenAttempts.AutoSize = true;
            this.lblDelayBetweenAttempts.Location = new System.Drawing.Point(12, 142);
            this.lblDelayBetweenAttempts.Name = "lblDelayBetweenAttempts";
            this.lblDelayBetweenAttempts.Size = new System.Drawing.Size(121, 13);
            this.lblDelayBetweenAttempts.TabIndex = 1;
            this.lblDelayBetweenAttempts.Text = "Delay between attempts";
            // 
            // lblTerminateOnFailure
            // 
            this.lblTerminateOnFailure.AutoSize = true;
            this.lblTerminateOnFailure.Location = new System.Drawing.Point(12, 40);
            this.lblTerminateOnFailure.Name = "lblTerminateOnFailure";
            this.lblTerminateOnFailure.Size = new System.Drawing.Size(100, 13);
            this.lblTerminateOnFailure.TabIndex = 1;
            this.lblTerminateOnFailure.Text = "Terminate on failure";
            // 
            // NewActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblTerminateOnFailure);
            this.Controls.Add(this.lblDelayBetweenAttempts);
            this.Controls.Add(this.lblNumberOfAttempts);
            this.Controls.Add(this.lblDelayAfter);
            this.Controls.Add(this.lblDelayBefore);
            this.Controls.Add(this.lblActionType);
            this.Controls.Add(this.nDelayBetweenAttempts);
            this.Controls.Add(this.nNumberOfAttempts);
            this.Controls.Add(this.nDelayAfter);
            this.Controls.Add(this.nDelayBefore);
            this.Controls.Add(this.chkTerminateOnFailure);
            this.Controls.Add(this.cmbActionType);
            this.Name = "NewActionForm";
            this.Text = "NewActionForm";
            ((System.ComponentModel.ISupportInitialize)(this.nDelayBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDelayAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumberOfAttempts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDelayBetweenAttempts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.CheckBox chkTerminateOnFailure;
        private System.Windows.Forms.NumericUpDown nDelayBefore;
        private System.Windows.Forms.NumericUpDown nDelayAfter;
        private System.Windows.Forms.NumericUpDown nNumberOfAttempts;
        private System.Windows.Forms.NumericUpDown nDelayBetweenAttempts;
        private System.Windows.Forms.Label lblActionType;
        private System.Windows.Forms.Label lblDelayBefore;
        private System.Windows.Forms.Label lblDelayAfter;
        private System.Windows.Forms.Label lblNumberOfAttempts;
        private System.Windows.Forms.Label lblDelayBetweenAttempts;
        private System.Windows.Forms.Label lblTerminateOnFailure;

    }
}