/*
 * Copyright (c) 2016-2019 Russ 'trdwll' Treadwell. All rights reserved.
 * Licensed under the MIT License. See LICENSE.md file in the project root for full license information.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heartbeat.Classes
{
    public class ErrorCodes
    {
        public enum EC
        {
            E_AUTH_0x001, // Auth Error (invalid serial key)
            E_AUTH_0x002, // Auth Error (serial key is expired)
        };
    }
}
