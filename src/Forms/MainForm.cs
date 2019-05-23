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

namespace Heartbeat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // TODO: Call license check here

#if FREE || DEBUG
            miPurchasePro.Visible = true;
            miSpacer1.Visible = true;
#endif

            Text = $"Heartbeat ({Configuration.APP_RELEASE}) - v{Configuration.VERSION_LONG}";
            tsSimConnectionsLabel.Text = $"Active Connections: {Configuration.ACTIVE_CONNECTIONS}/" + (Configuration.SIMULTANEOUS_CONNECTIONS == -1 ? "∞" : Configuration.SIMULTANEOUS_CONNECTIONS.ToString());
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Heartbeat ({Configuration.APP_RELEASE})\r\n" +
                $"Build Version: {Configuration.VERSION_LONG}\r\nCreated by: Russ 'trdwll' Treadwell\r\n\r\n" +
                $"Application Icon: https://icons8.com", "About Heartbeat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miNewConnection_Click(object sender, EventArgs e)
        {
            Forms.NewConnectionForm ncf = new Forms.NewConnectionForm(getTabControl());
            ncf.ShowDialog();
        }

        private void miChangelog_Click(object sender, EventArgs e)
        {
            Forms.ChangelogForm cf = new Forms.ChangelogForm();
            cf.ShowDialog();
        }

        public TabControl getTabControl()
        {
            return tabControl1;
        }
    }
}
