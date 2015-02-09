namespace Helper
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
            this.Actions = new System.Windows.Forms.ListBox();
            this.btnAddAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Actions
            // 
            this.Actions.FormattingEnabled = true;
            this.Actions.Location = new System.Drawing.Point(13, 13);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(120, 95);
            this.Actions.TabIndex = 0;
            // 
            // btnAddAction
            // 
            this.btnAddAction.Location = new System.Drawing.Point(140, 13);
            this.btnAddAction.Name = "btnAddAction";
            this.btnAddAction.Size = new System.Drawing.Size(75, 23);
            this.btnAddAction.TabIndex = 1;
            this.btnAddAction.Text = "Add action";
            this.btnAddAction.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAddAction);
            this.Controls.Add(this.Actions);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Actions;
        private System.Windows.Forms.Button btnAddAction;
    }
}

