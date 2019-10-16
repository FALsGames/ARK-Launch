namespace Ark_Launch
{
    partial class ProfileEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileEditor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.removeButton = new System.Windows.Forms.Button();
            this.AddProfile = new System.Windows.Forms.Button();
            this.profiles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.removeButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddProfile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.profiles);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(13, 38);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(135, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // AddProfile
            // 
            this.AddProfile.Location = new System.Drawing.Point(12, 8);
            this.AddProfile.Name = "AddProfile";
            this.AddProfile.Size = new System.Drawing.Size(136, 23);
            this.AddProfile.TabIndex = 0;
            this.AddProfile.Text = "Add";
            this.AddProfile.UseVisualStyleBackColor = true;
            this.AddProfile.Click += new System.EventHandler(this.AddProfile_Click);
            // 
            // profiles
            // 
            this.profiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profiles.FormattingEnabled = true;
            this.profiles.Location = new System.Drawing.Point(0, 0);
            this.profiles.Name = "profiles";
            this.profiles.Size = new System.Drawing.Size(634, 450);
            this.profiles.TabIndex = 0;
            // 
            // ProfileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileEditor";
            this.Text = "Profiles";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button AddProfile;
        private System.Windows.Forms.Button removeButton;
        public System.Windows.Forms.ListBox profiles;
    }
}