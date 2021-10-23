namespace Batman_sPC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.MainTextLabel = new System.Windows.Forms.Label();
            this.exitappContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowedFullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            this.exitappContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.loginButton);
            this.MainPanel.Controls.Add(this.passwordTextBox);
            this.MainPanel.Controls.Add(this.usernameTextBox);
            this.MainPanel.Controls.Add(this.passwordLabel);
            this.MainPanel.Controls.Add(this.usernameLabel);
            this.MainPanel.Controls.Add(this.MainTextLabel);
            this.MainPanel.Location = new System.Drawing.Point(125, 343);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(609, 444);
            this.MainPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Gray;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(179, 306);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(258, 103);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Gray;
            this.passwordTextBox.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(250, 208);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(295, 39);
            this.passwordTextBox.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Gray;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(250, 139);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(295, 36);
            this.usernameTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Gray;
            this.passwordLabel.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(60, 212);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(172, 35);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Gray;
            this.usernameLabel.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(60, 139);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(172, 36);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // MainTextLabel
            // 
            this.MainTextLabel.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTextLabel.ForeColor = System.Drawing.Color.Gray;
            this.MainTextLabel.Location = new System.Drawing.Point(138, 12);
            this.MainTextLabel.Name = "MainTextLabel";
            this.MainTextLabel.Size = new System.Drawing.Size(352, 60);
            this.MainTextLabel.TabIndex = 0;
            this.MainTextLabel.Text = "Batman\'s PC";
            // 
            // exitappContextMenu
            // 
            this.exitappContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.windowedToolStripMenuItem,
            this.windowedFullscreenToolStripMenuItem});
            this.exitappContextMenu.Name = "exitappContextMenu";
            this.exitappContextMenu.Size = new System.Drawing.Size(188, 70);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImage = global::Batman_sPC.Properties.Resources._1;
            this.exitToolStripMenuItem.Image = global::Batman_sPC.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // windowedToolStripMenuItem
            // 
            this.windowedToolStripMenuItem.BackgroundImage = global::Batman_sPC.Properties.Resources.BatmanCMBackground3;
            this.windowedToolStripMenuItem.Image = global::Batman_sPC.Properties.Resources.BatmanIcon3;
            this.windowedToolStripMenuItem.Name = "windowedToolStripMenuItem";
            this.windowedToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.windowedToolStripMenuItem.Text = "Windowed";
            this.windowedToolStripMenuItem.Click += new System.EventHandler(this.WindowedToolStripMenuItem_Click);
            // 
            // windowedFullscreenToolStripMenuItem
            // 
            this.windowedFullscreenToolStripMenuItem.BackgroundImage = global::Batman_sPC.Properties.Resources.BatmanCMBackground2;
            this.windowedFullscreenToolStripMenuItem.Image = global::Batman_sPC.Properties.Resources.BatmanIcon2;
            this.windowedFullscreenToolStripMenuItem.Name = "windowedFullscreenToolStripMenuItem";
            this.windowedFullscreenToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.windowedFullscreenToolStripMenuItem.Text = "Windowed Fullscreen";
            this.windowedFullscreenToolStripMenuItem.Click += new System.EventHandler(this.WindowedFullscreenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.ContextMenuStrip = this.exitappContextMenu;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "User Interface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.exitappContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label MainTextLabel;
        private System.Windows.Forms.ContextMenuStrip exitappContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowedFullscreenToolStripMenuItem;
    }
}

