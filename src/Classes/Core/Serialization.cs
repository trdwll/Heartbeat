/*
 * Copyright (c) 2016-2019 Jack 'OhYea777' Taylor. All rights reserved.
 * Licensed under the MIT License. See LICENSE.md file in the project root for full license information.
 */
using System;
using System.Web.Script.Serialization;

namespace Heartbeat.Classes.Core
{
    public class Serialization
    {
        public class JSON
        {
            private static JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();

            public class Deserialize
            {
                public static T getFromFile<T>(string jsonFile)
                {
                    T obj = default(T);

                    if (!System.IO.File.Exists(jsonFile))
                    {
                        obj = Activator.CreateInstance<T>();

                        System.IO.Directory.GetParent(jsonFile).Create();
                        System.IO.File.WriteAllText(jsonFile, jsonSerializer.Serialize(obj));
                    }
                    else
                    {
                        obj = getFromJson<T>(System.IO.File.ReadAllText(jsonFile));
                    }

                    return obj;
                }

                public static T getFromJson<T>(string json)
                {
                    return jsonSerializer.Deserialize<T>(json);
                }
            }

            public class Serialize
            {
                public static string serializeObject(object obj)
                {
                    return jsonSerializer.Serialize(obj);
                }

                public static void SerializeToFile(object obj, string jsonFile)
                {
                    System.IO.File.WriteAllText(jsonFile, serializeObject(obj));
                }
            }
        }
    }
}
