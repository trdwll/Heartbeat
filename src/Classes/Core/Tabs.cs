/*
 * Copyright (c) 2016-2019 Russ 'trdwll' Treadwell. All rights reserved.
 * Licensed under the MIT License. See LICENSE.md file in the project root for full license information.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heartbeat.Classes.Core
{
    public class Tabs
    {
        private TabControl tabControl;

        public Tabs(TabControl _tabControl)
        {
            tabControl = _tabControl;
        }
        
        public void createNewConnectionTab(string Title)
        {
            if (!tabControl.TabPages.ContainsKey(Title))
            {
                tabControl.TabPages.Add(new TabPage(Title) { Name = Title, Tag = Title });
                tabControl.SuspendLayout();

                TabControl newTabControl = new TabControl();
                DataGridView dgvPlayers = new DataGridView();
                DataGridView dgvBans = new DataGridView();

                newTabControl.Dock = DockStyle.Fill;
                dgvPlayers.Dock = DockStyle.Fill;
                dgvBans.Dock = DockStyle.Fill;

                // TODO: Add context menu to the dgvs
                
                newTabControl.TabPages.Add("Players");
                newTabControl.TabPages.Add("Bans");

                dgvPlayers.Columns.Add("name", "Name");
                dgvPlayers.Columns.Add("guid_uid", "GUID/UID");
                dgvPlayers.Columns.Add("ipaddress", "IP Address");
                dgvPlayers.Columns.Add("proxy_vpn", "Is Proxy/VPN");
                dgvPlayers.Columns.Add("ping", "Ping");

                dgvBans.Columns.Add("name", "Name");
                dgvBans.Columns.Add("guid_uid", "GUID/UID");
                dgvBans.Columns.Add("ipaddress", "IP Address");
                dgvBans.Columns.Add("proxy_vpn", "Is Proxy/VPN");
                dgvBans.Columns.Add("ban_creator", "Ban Creator");
                dgvBans.Columns.Add("ban_date", "Ban Date");
                dgvBans.Columns.Add("ban_expiry", "Ban Expiry");
                dgvBans.Columns.Add("ban_reason", "Ban Reason");

                newTabControl.TabPages[0].Controls.Add(dgvPlayers);
                newTabControl.TabPages[1].Controls.Add(dgvBans);
                tabControl.TabPages[Title].Controls.Add(newTabControl);

                tabControl.ResumeLayout();
            }
        }
    }
}
