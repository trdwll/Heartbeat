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
    public partial class LicenseKeyForm : Form
    {
        public LicenseKeyForm()
        {
            InitializeComponent();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var license = Portable.Licensing.License.Load(System.IO.File.ReadAllText(ofd.FileName, Encoding.UTF8));

                if (license.VerifySignature(Properties.Settings.Default.pubKey))
                {
                    MessageBox.Show("Your key is valid!");
                }
                else
                {
                    MessageBox.Show("invalid key");
                }
            }
        }
    }
}
