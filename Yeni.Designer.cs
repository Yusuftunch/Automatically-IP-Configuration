namespace IPConfig
{
    partial class Yeni
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
            this.network_adaptor_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subnet_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gateway_textBox = new System.Windows.Forms.TextBox();
            this.ipsetname_textBox = new System.Windows.Forms.TextBox();
            this.settingname_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.auto_checkBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kaydet_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // network_adaptor_listBox
            // 
            this.network_adaptor_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.network_adaptor_listBox.FormattingEnabled = true;
            this.network_adaptor_listBox.ItemHeight = 24;
            this.network_adaptor_listBox.Location = new System.Drawing.Point(8, 32);
            this.network_adaptor_listBox.Name = "network_adaptor_listBox";
            this.network_adaptor_listBox.Size = new System.Drawing.Size(354, 100);
            this.network_adaptor_listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Network Adaptors";
            // 
            // ip_textBox
            // 
            this.ip_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ip_textBox.Location = new System.Drawing.Point(11, 217);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(161, 29);
            this.ip_textBox.TabIndex = 4;
            this.ip_textBox.Leave += new System.EventHandler(this.ip_textBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(7, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(7, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subnet Mask";
            // 
            // subnet_textBox
            // 
            this.subnet_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subnet_textBox.Location = new System.Drawing.Point(11, 285);
            this.subnet_textBox.Name = "subnet_textBox";
            this.subnet_textBox.Size = new System.Drawing.Size(161, 29);
            this.subnet_textBox.TabIndex = 6;
            this.subnet_textBox.Enter += new System.EventHandler(this.subnet_textBox_Enter);
            this.subnet_textBox.Leave += new System.EventHandler(this.subnet_textBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(197, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gateway";
            // 
            // gateway_textBox
            // 
            this.gateway_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gateway_textBox.Location = new System.Drawing.Point(201, 286);
            this.gateway_textBox.Name = "gateway_textBox";
            this.gateway_textBox.Size = new System.Drawing.Size(161, 29);
            this.gateway_textBox.TabIndex = 9;
            this.gateway_textBox.Leave += new System.EventHandler(this.gateway_textBox_Leave);
            // 
            // ipsetname_textBox
            // 
            this.ipsetname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipsetname_textBox.Location = new System.Drawing.Point(202, 15);
            this.ipsetname_textBox.Name = "ipsetname_textBox";
            this.ipsetname_textBox.Size = new System.Drawing.Size(161, 29);
            this.ipsetname_textBox.TabIndex = 11;
            this.ipsetname_textBox.Leave += new System.EventHandler(this.ipsetname_textBox_Leave);
            // 
            // settingname_label
            // 
            this.settingname_label.AutoSize = true;
            this.settingname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingname_label.ForeColor = System.Drawing.Color.Navy;
            this.settingname_label.Location = new System.Drawing.Point(21, 15);
            this.settingname_label.Name = "settingname_label";
            this.settingname_label.Size = new System.Drawing.Size(175, 24);
            this.settingname_label.TabIndex = 12;
            this.settingname_label.Text = "Your IP set name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.settingname_label);
            this.panel1.Controls.Add(this.ipsetname_textBox);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 59);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.auto_checkBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.network_adaptor_listBox);
            this.panel2.Controls.Add(this.gateway_textBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ip_textBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.subnet_textBox);
            this.panel2.Location = new System.Drawing.Point(8, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 331);
            this.panel2.TabIndex = 14;
            // 
            // auto_checkBox
            // 
            this.auto_checkBox.AutoSize = true;
            this.auto_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.auto_checkBox.ForeColor = System.Drawing.Color.Navy;
            this.auto_checkBox.Location = new System.Drawing.Point(11, 147);
            this.auto_checkBox.Name = "auto_checkBox";
            this.auto_checkBox.Size = new System.Drawing.Size(184, 28);
            this.auto_checkBox.TabIndex = 11;
            this.auto_checkBox.Text = "Set DHCP (Auto)";
            this.auto_checkBox.UseVisualStyleBackColor = true;
            this.auto_checkBox.Click += new System.EventHandler(this.auto_checkBox_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = global::IPConfig.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(7, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kaydet_button
            // 
            this.kaydet_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kaydet_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kaydet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet_button.ForeColor = System.Drawing.Color.Navy;
            this.kaydet_button.Image = global::IPConfig.Properties.Resources.save2;
            this.kaydet_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kaydet_button.Location = new System.Drawing.Point(238, 417);
            this.kaydet_button.Name = "kaydet_button";
            this.kaydet_button.Size = new System.Drawing.Size(161, 40);
            this.kaydet_button.TabIndex = 2;
            this.kaydet_button.Text = "Save";
            this.kaydet_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydet_button.UseVisualStyleBackColor = true;
            // 
            // Yeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(404, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kaydet_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Yeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Network Setting Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kaydet_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label settingname_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListBox network_adaptor_listBox;
        public System.Windows.Forms.TextBox ip_textBox;
        public System.Windows.Forms.TextBox subnet_textBox;
        public System.Windows.Forms.TextBox gateway_textBox;
        public System.Windows.Forms.TextBox ipsetname_textBox;
        public System.Windows.Forms.CheckBox auto_checkBox;
        private System.Windows.Forms.Button button1;
    }
}