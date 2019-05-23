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
    public class Json
    {
        public class Connections
        {
            public string Name;
            public bool Favorite;
            public string IPAddress;
            public string GamePort;
            public string RConPort;
            public string RConPassword;

#if PAID || DEBUG
            public bool ConnectOnStartup;
            public bool ShareBans;
#endif
        }
    }
}
