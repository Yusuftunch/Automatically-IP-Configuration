namespace IPConfig
{
    partial class Main_Page
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIPSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteSelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeOnlineNetworkAdaptorsSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedNetworkAdaptorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectedNetworkAdaptorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allNetworkAdaptorsPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWithWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_listbox = new System.Windows.Forms.ListBox();
            this.menu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applyForSelectedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.traymenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.menu1.SuspendLayout();
            this.traymenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.minimizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.ımportToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::IPConfig.Properties.Resources.file;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::IPConfig.Properties.Resources.export;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // ımportToolStripMenuItem
            // 
            this.ımportToolStripMenuItem.Image = global::IPConfig.Properties.Resources.import;
            this.ımportToolStripMenuItem.Name = "ımportToolStripMenuItem";
            this.ımportToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.ımportToolStripMenuItem.Text = "Import";
            this.ımportToolStripMenuItem.Click += new System.EventHandler(this.ımportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::IPConfig.Properties.Resources.Close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newIPSetToolStripMenuItem,
            this.toolStripSeparator4,
            this.editToolStripMenuItem1,
            this.toolStripSeparator2,
            this.deleteSelectedItemToolStripMenuItem,
            this.toolStripSeparator3,
            this.applyToolStripMenuItem,
            this.seeOnlineNetworkAdaptorsSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Image = global::IPConfig.Properties.Resources.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newIPSetToolStripMenuItem
            // 
            this.newIPSetToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.newIPSetToolStripMenuItem.Image = global::IPConfig.Properties.Resources._new;
            this.newIPSetToolStripMenuItem.Name = "newIPSetToolStripMenuItem";
            this.newIPSetToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.newIPSetToolStripMenuItem.Text = "New IP Set";
            this.newIPSetToolStripMenuItem.Click += new System.EventHandler(this.newIPSetToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(292, 6);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.editToolStripMenuItem1.Image = global::IPConfig.Properties.Resources.edit;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(295, 26);
            this.editToolStripMenuItem1.Text = "Edit Selected Item";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(292, 6);
            // 
            // deleteSelectedItemToolStripMenuItem
            // 
            this.deleteSelectedItemToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.deleteSelectedItemToolStripMenuItem.Image = global::IPConfig.Properties.Resources.delete;
            this.deleteSelectedItemToolStripMenuItem.Name = "deleteSelectedItemToolStripMenuItem";
            this.deleteSelectedItemToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.deleteSelectedItemToolStripMenuItem.Text = "Delete Selected Item";
            this.deleteSelectedItemToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedItemToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(292, 6);
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.applyToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.applyToolStripMenuItem.Image = global::IPConfig.Properties.Resources._checked;
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.applyToolStripMenuItem.Text = "Apply for Selected Item";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // seeOnlineNetworkAdaptorsSettingsToolStripMenuItem
            // 
            this.seeOnlineNetworkAdaptorsSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedNetworkAdaptorsToolStripMenuItem,
            this.disconnectedNetworkAdaptorsToolStripMenuItem1,
            this.allNetworkAdaptorsPropertiesToolStripMenuItem});
            this.seeOnlineNetworkAdaptorsSettingsToolStripMenuItem.Name = "seeOnlineNetworkAdaptorsSettingsToolStripMenuItem";
            this.seeOnlineNetworkAdaptorsSettingsToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.seeOnlineNetworkAdaptorsSettingsToolStripMenuItem.Text = "Network Adaptors Properties";
            // 
            // connectedNetworkAdaptorsToolStripMenuItem
            // 
            this.connectedNetworkAdaptorsToolStripMenuItem.Name = "connectedNetworkAdaptorsToolStripMenuItem";
            this.connectedNetworkAdaptorsToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.connectedNetworkAdaptorsToolStripMenuItem.Text = "Connected Network Adaptors";
            this.connectedNetworkAdaptorsToolStripMenuItem.Click += new System.EventHandler(this.connectedNetworkAdaptorsToolStripMenuItem_Click);
            // 
            // disconnectedNetworkAdaptorsToolStripMenuItem1
            // 
            this.disconnectedNetworkAdaptorsToolStripMenuItem1.Name = "disconnectedNetworkAdaptorsToolStripMenuItem1";
            this.disconnectedNetworkAdaptorsToolStripMenuItem1.Size = new System.Drawing.Size(319, 26);
            this.disconnectedNetworkAdaptorsToolStripMenuItem1.Text = "Disconnected Network Adaptors";
            this.disconnectedNetworkAdaptorsToolStripMenuItem1.Click += new System.EventHandler(this.disconnectedNetworkAdaptorsToolStripMenuItem1_Click);
            // 
            // allNetworkAdaptorsPropertiesToolStripMenuItem
            // 
            this.allNetworkAdaptorsPropertiesToolStripMenuItem.Name = "allNetworkAdaptorsPropertiesToolStripMenuItem";
            this.allNetworkAdaptorsPropertiesToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.allNetworkAdaptorsPropertiesToolStripMenuItem.Text = "All Network Adaptors Properties";
            this.allNetworkAdaptorsPropertiesToolStripMenuItem.Click += new System.EventHandler(this.allNetworkAdaptorsPropertiesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWithWindowsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // startWithWindowsToolStripMenuItem
            // 
            this.startWithWindowsToolStripMenuItem.Name = "startWithWindowsToolStripMenuItem";
            this.startWithWindowsToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.startWithWindowsToolStripMenuItem.Text = "Start with Windows Start up";
            this.startWithWindowsToolStripMenuItem.Click += new System.EventHandler(this.startWithWindowsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donateToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::IPConfig.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Image = global::IPConfig.Properties.Resources.about;
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.donateToolStripMenuItem.Text = "About";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.minimizeToolStripMenuItem.Image = global::IPConfig.Properties.Resources.minimize;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // setting_listbox
            // 
            this.setting_listbox.ContextMenuStrip = this.menu1;
            this.setting_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setting_listbox.ForeColor = System.Drawing.Color.Navy;
            this.setting_listbox.FormattingEnabled = true;
            this.setting_listbox.ItemHeight = 20;
            this.setting_listbox.Location = new System.Drawing.Point(12, 37);
            this.setting_listbox.Name = "setting_listbox";
            this.setting_listbox.Size = new System.Drawing.Size(219, 344);
            this.setting_listbox.TabIndex = 2;
            // 
            // menu1
            // 
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editSelectedItemToolStripMenuItem,
            this.deleteSelectedItemToolStripMenuItem1,
            this.applyForSelectedItemToolStripMenuItem});
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(198, 92);
            this.menu1.Text = "New IP Set Item";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::IPConfig.Properties.Resources._new;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuItem1.Text = "New IP Set Item";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editSelectedItemToolStripMenuItem
            // 
            this.editSelectedItemToolStripMenuItem.Image = global::IPConfig.Properties.Resources.edit;
            this.editSelectedItemToolStripMenuItem.Name = "editSelectedItemToolStripMenuItem";
            this.editSelectedItemToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.editSelectedItemToolStripMenuItem.Text = "Edit Selected Item";
            this.editSelectedItemToolStripMenuItem.Click += new System.EventHandler(this.editSelectedItemToolStripMenuItem_Click);
            // 
            // deleteSelectedItemToolStripMenuItem1
            // 
            this.deleteSelectedItemToolStripMenuItem1.Image = global::IPConfig.Properties.Resources.delete;
            this.deleteSelectedItemToolStripMenuItem1.Name = "deleteSelectedItemToolStripMenuItem1";
            this.deleteSelectedItemToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.deleteSelectedItemToolStripMenuItem1.Text = "Delete Selected Item";
            this.deleteSelectedItemToolStripMenuItem1.Click += new System.EventHandler(this.deleteSelectedItemToolStripMenuItem1_Click);
            // 
            // applyForSelectedItemToolStripMenuItem
            // 
            this.applyForSelectedItemToolStripMenuItem.Image = global::IPConfig.Properties.Resources._checked;
            this.applyForSelectedItemToolStripMenuItem.Name = "applyForSelectedItemToolStripMenuItem";
            this.applyForSelectedItemToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.applyForSelectedItemToolStripMenuItem.Text = "Apply for Selected Item";
            this.applyForSelectedItemToolStripMenuItem.Click += new System.EventHandler(this.applyForSelectedItemToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.traymenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "IP Configuration Tool V1.0";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // traymenu
            // 
            this.traymenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.traymenu.Name = "traymenu";
            this.traymenu.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(243, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 146);
            this.button3.TabIndex = 6;
            this.button3.Text = "Apply\r\n for Selected Item";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(243, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = global::IPConfig.Properties.Resources.edit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(243, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // new_button
            // 
            this.new_button.BackColor = System.Drawing.Color.White;
            this.new_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.new_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.new_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.new_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.new_button.ForeColor = System.Drawing.Color.Navy;
            this.new_button.Image = global::IPConfig.Properties.Resources._new;
            this.new_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.new_button.Location = new System.Drawing.Point(243, 37);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(162, 60);
            this.new_button.TabIndex = 3;
            this.new_button.Text = "New Set IP";
            this.new_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_button.UseVisualStyleBackColor = false;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 389);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.setting_listbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_Page";
            this.Text = "Change Network Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menu1.ResumeLayout(false);
            this.traymenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox setting_listbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newIPSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ımportToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editSelectedItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedItemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applyForSelectedItemToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip traymenu;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem startWithWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeOnlineNetworkAdaptorsSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedNetworkAdaptorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectedNetworkAdaptorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allNetworkAdaptorsPropertiesToolStripMenuItem;
    }
}

