namespace Ark_Launch
{
    partial class StringDialogBox
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(13, 13);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(13, 40);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(30, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(50, 40);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(63, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // StringDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 71);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nameInput);
            this.MaximumSize = new System.Drawing.Size(140, 110);
            this.MinimumSize = new System.Drawing.Size(140, 110);
            this.Name = "StringDialogBox";
            this.Text = "Enter profiles name...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button backButton;
        public System.Windows.Forms.TextBox nameInput;
    }
}