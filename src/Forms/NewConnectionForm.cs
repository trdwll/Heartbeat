/*
 * Copyright (c) 2016-2019 Russ 'trdwll' Treadwell. All rights reserved.
 * Licensed under the MIT License. See LICENSE.md file in the project root for full license information.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heartbeat.Forms
{
    public partial class NewConnectionForm : Form
    {
        private TabControl tabControl;
        public NewConnectionForm(TabControl _tabControl)
        {
            InitializeComponent();

            tabControl = _tabControl;


#if PAID || DEBUG
            // Populate cbGameList with Pro games
            cbGameList.Items.Add("Space Engineers");
            cbGameList.Items.Add("7 Days To Die");
            cbGameList.Items.Add("Squad");

            chkConnectonStartup.Enabled = true;
#endif
            cbGameList.SelectedIndex = 0;
        }

        void Save()
        {
            // TODO: Save config into json
            Classes.Json.Connections json = new Classes.Json.Connections();

            json.Name = txtName.Text;
            json.Favorite = chkFavorite.Checked;
            json.IPAddress = txtIPAddress.Text;
            json.GamePort = txtPort.Text;
            json.RConPort = txtRconPort.Text;
            json.RConPassword = txtRconPassword.Text;

            // PAID Features
            json.ConnectOnStartup = chkConnectonStartup.Checked;
            json.ShareBans = chkShareBans.Checked;

        }

        private void Connect()
        {
            // TODO: Add connection
           // MessageBox.Show($"Connecting to the server - " + (string.IsNullOrWhiteSpace(txtName.Text) ? "Untitled" : txtName.Text) + $" [{cbGameList.SelectedItem.ToString()}]");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnSaveandConnect_Click(object sender, EventArgs e)
        {
            // TODO: create new tab (connection) and connect
            Classes.Core.Tabs tab = new Classes.Core.Tabs(tabControl);
            tab.createNewConnectionTab((string.IsNullOrWhiteSpace(txtName.Text) ? "Untitled" : txtName.Text) + $" [{cbGameList.SelectedItem.ToString()}]");

            Save();
            Connect();
        }

        private void btnHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }
    }
}
