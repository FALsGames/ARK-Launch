namespace Ark_Launch
{
    partial class Ark_Launch
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ark_Launch));
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dummyBox = new System.Windows.Forms.ListBox();
            this.editProfiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profileSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play ARK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dummyBox);
            this.splitContainer1.Panel1.Controls.Add(this.editProfiles);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.profileSelector);
            this.splitContainer1.Size = new System.Drawing.Size(800, 427);
            this.splitContainer1.SplitterDistance = 708;
            this.splitContainer1.TabIndex = 1;
            // 
            // dummyBox
            // 
            this.dummyBox.FormattingEnabled = true;
            this.dummyBox.Location = new System.Drawing.Point(247, 201);
            this.dummyBox.Name = "dummyBox";
            this.dummyBox.Size = new System.Drawing.Size(120, 95);
            this.dummyBox.TabIndex = 3;
            this.dummyBox.UseTabStops = false;
            this.dummyBox.Visible = false;
            // 
            // editProfiles
            // 
            this.editProfiles.Location = new System.Drawing.Point(50, 376);
            this.editProfiles.Name = "editProfiles";
            this.editProfiles.Size = new System.Drawing.Size(75, 23);
            this.editProfiles.TabIndex = 2;
            this.editProfiles.Text = "Edit Profiles";
            this.editProfiles.UseVisualStyleBackColor = true;
            this.editProfiles.Click += new System.EventHandler(this.editProfiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profiles:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // profileSelector
            // 
            this.profileSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileSelector.FormattingEnabled = true;
            this.profileSelector.Location = new System.Drawing.Point(4, 400);
            this.profileSelector.MaxDropDownItems = 100;
            this.profileSelector.Name = "profileSelector";
            this.profileSelector.Size = new System.Drawing.Size(121, 21);
            this.profileSelector.TabIndex = 0;
            this.profileSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Ark_Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ark_Launch";
            this.Text = "Ark Launch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ark_Launch_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox profileSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editProfiles;
        private System.Windows.Forms.ListBox dummyBox;
    }
}

