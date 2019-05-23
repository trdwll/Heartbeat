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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            lblTitle.Text = "";
        }

        private void lbHelpSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitle.Text = lbHelpSelection.SelectedItem.ToString();
        }
    }
}
