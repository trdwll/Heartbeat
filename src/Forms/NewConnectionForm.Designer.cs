namespace Heartbeat.Forms
{
    partial class NewConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConnectionForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveandConnect = new System.Windows.Forms.Button();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRconPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkHidePassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRconPassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFavorite = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGameList = new System.Windows.Forms.ComboBox();
            this.btnHelp = new System.Windows.Forms.LinkLabel();
            this.chkShareBans = new System.Windows.Forms.CheckBox();
            this.chkConnectonStartup = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(593, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(512, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveandConnect
            // 
            this.btnSaveandConnect.Location = new System.Drawing.Point(302, 195);
            this.btnSaveandConnect.Name = "btnSaveandConnect";
            this.btnSaveandConnect.Size = new System.Drawing.Size(112, 23);
            this.btnSaveandConnect.TabIndex = 2;
            this.btnSaveandConnect.Text = "Save and Connect";
            this.btnSaveandConnect.UseVisualStyleBackColor = true;
            this.btnSaveandConnect.Click += new System.EventHandler(this.btnSaveandConnect_Click);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(70, 29);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(208, 20);
            this.txtIPAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(70, 55);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(67, 20);
            this.txtPort.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRconPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkHidePassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRconPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIPAddress);
            this.groupBox1.Location = new System.Drawing.Point(302, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Details";
            // 
            // txtRconPort
            // 
            this.txtRconPort.Location = new System.Drawing.Point(211, 55);
            this.txtRconPort.Name = "txtRconPort";
            this.txtRconPort.Size = new System.Drawing.Size(67, 20);
            this.txtRconPort.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "RCon Port";
            // 
            // chkHidePassword
            // 
            this.chkHidePassword.AutoSize = true;
            this.chkHidePassword.Location = new System.Drawing.Point(261, 112);
            this.chkHidePassword.Name = "chkHidePassword";
            this.chkHidePassword.Size = new System.Drawing.Size(48, 17);
            this.chkHidePassword.TabIndex = 9;
            this.chkHidePassword.Text = "Hide";
            this.chkHidePassword.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // txtRconPassword
            // 
            this.txtRconPassword.Location = new System.Drawing.Point(70, 109);
            this.txtRconPassword.Name = "txtRconPassword";
            this.txtRconPassword.Size = new System.Drawing.Size(185, 20);
            this.txtRconPassword.TabIndex = 7;
            this.txtRconPassword.UseSystemPasswordChar = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFavorite);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbGameList);
            this.groupBox2.Controls.Add(this.btnHelp);
            this.groupBox2.Controls.Add(this.chkShareBans);
            this.groupBox2.Controls.Add(this.chkConnectonStartup);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 206);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection Settings";
            // 
            // chkFavorite
            // 
            this.chkFavorite.AutoSize = true;
            this.chkFavorite.Location = new System.Drawing.Point(214, 15);
            this.chkFavorite.Name = "chkFavorite";
            this.chkFavorite.Size = new System.Drawing.Size(64, 17);
            this.chkFavorite.TabIndex = 14;
            this.chkFavorite.Text = "Favorite";
            this.chkFavorite.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Game";
            // 
            // cbGameList
            // 
            this.cbGameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGameList.FormattingEnabled = true;
            this.cbGameList.Items.AddRange(new object[] {
            "Arma 3",
            "DayZ Standalone",
            "Rust",
            "ARK: Survival Evolved"});
            this.cbGameList.Location = new System.Drawing.Point(47, 64);
            this.cbGameList.Name = "cbGameList";
            this.cbGameList.Size = new System.Drawing.Size(231, 21);
            this.cbGameList.TabIndex = 9;
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = true;
            this.btnHelp.Location = new System.Drawing.Point(187, 184);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(13, 13);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.TabStop = true;
            this.btnHelp.Text = "?";
            this.btnHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnHelp_LinkClicked);
            // 
            // chkShareBans
            // 
            this.chkShareBans.AutoSize = true;
            this.chkShareBans.Location = new System.Drawing.Point(9, 183);
            this.chkShareBans.Name = "chkShareBans";
            this.chkShareBans.Size = new System.Drawing.Size(183, 17);
            this.chkShareBans.TabIndex = 12;
            this.chkShareBans.Text = "Share Bans with Heartbeat Users";
            this.chkShareBans.UseVisualStyleBackColor = true;
            // 
            // chkConnectonStartup
            // 
            this.chkConnectonStartup.AutoSize = true;
            this.chkConnectonStartup.Enabled = false;
            this.chkConnectonStartup.Location = new System.Drawing.Point(9, 160);
            this.chkConnectonStartup.Name = "chkConnectonStartup";
            this.chkConnectonStartup.Size = new System.Drawing.Size(168, 17);
            this.chkConnectonStartup.TabIndex = 11;
            this.chkConnectonStartup.Text = "Connect on Heartbeat Startup";
            this.chkConnectonStartup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(431, 195);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // NewConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 230);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveandConnect);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a new connection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveandConnect;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRconPassword;
        private System.Windows.Forms.CheckBox chkHidePassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkShareBans;
        private System.Windows.Forms.CheckBox chkConnectonStartup;
        private System.Windows.Forms.TextBox txtRconPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel btnHelp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGameList;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chkFavorite;
    }
}