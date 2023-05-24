namespace UserManagement.Forms
{
    partial class AddRoleForm
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
            menuStrip1 = new MenuStrip();
            saveButton = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            TitleRoleTextbox = new TextBox();
            label2 = new Label();
            DescriptionTextbox = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveButton, closeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(820, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // saveButton
            // 
            saveButton.AccessibleDescription = "saveButton";
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(43, 20);
            saveButton.Text = "Save";
            saveButton.Click += saveToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(48, 20);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 149);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "RoleTitle";
            label1.Click += label1_Click;
            // 
            // TitleRoleTextbox
            // 
            TitleRoleTextbox.Location = new Point(277, 146);
            TitleRoleTextbox.Name = "TitleRoleTextbox";
            TitleRoleTextbox.Size = new Size(283, 23);
            TitleRoleTextbox.TabIndex = 3;
            TitleRoleTextbox.TextChanged += titleroletextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 187);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Description";
            label2.Click += label2_Click;
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Location = new Point(277, 187);
            DescriptionTextbox.Multiline = true;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.Size = new Size(283, 121);
            DescriptionTextbox.TabIndex = 5;
            DescriptionTextbox.TextChanged += textBox2_TextChanged;
            // 
            // AddRoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(DescriptionTextbox);
            Controls.Add(label2);
            Controls.Add(TitleRoleTextbox);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AddRoleForm";
            Text = "AddRoleForm";
            Load += AddRoleForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label1;
        private Label label2;
        public TextBox TitleRoleTextbox;
        public TextBox DescriptionTextbox;
        private ToolStripMenuItem saveButton;
    }
}