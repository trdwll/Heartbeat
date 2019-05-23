/*
 * Copyright (c) 2016-2019 Russ 'trdwll' Treadwell. All rights reserved.
 * Licensed under the MIT License. See LICENSE.md file in the project root for full license information.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heartbeat
{
    public class Configuration
    {
        public static string VERSION_LONG = "1.0.0-alpha";

        public static int ACTIVE_CONNECTIONS = 0;

#if PAID
        public static string APP_RELEASE = "Pro";
        public static int SIMULTANEOUS_CONNECTIONS = -1;
        public static int MAX_FAVORITE = -1;
#elif FREE
        public static string APP_RELEASE = "Free";
        public static int SIMULTANEOUS_CONNECTIONS = 5;
        public static int MAX_FAVORITE = 5;
#else
        public static string APP_RELEASE = "DEVELOPER PREVIEW";
        public static int SIMULTANEOUS_CONNECTIONS = -1;
        public static int MAX_FAVORITE = -1;
#endif
    }
}
