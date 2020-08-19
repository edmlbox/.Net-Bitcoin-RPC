using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace BitcoinRpc
{
    class JsonHandler
    {
        readonly MethodNameSwitch MethodNameSwitch;
        public JsonHandler()
        {
            MethodNameSwitch = new MethodNameSwitch();
        }

        public string JsonWriter(string methodName, object guestType)
        {
            string json = null;
            using (MemoryStream stream = new MemoryStream())
            {
                using (Utf8JsonWriter writer = new Utf8JsonWriter(stream))
                {
                    writer.WriteStartObject();
                    writer.WriteString("jsonrpc", "1.0");
                    writer.WriteString("method", methodName);
                    writer.WriteStartArray("params");

                    MethodNameSwitch.MethodNameFilter(methodName, guestType, writer);

                    writer.WriteEndObject();
                }
                json = Encoding.UTF8.GetString(stream.ToArray());
            }

            return json;

        }






    }

}
