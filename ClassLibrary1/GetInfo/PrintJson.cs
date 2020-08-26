using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace BitcoinRpc.GetInfo
{
    public static class JsonRequest
    {
        static string serializedJson;
        public static string SerializedJson { get => serializedJson; set => serializedJson = value; }

        public static string GetRequestAsString(bool WriteIndented)
        {
            if (SerializedJson != null) {
                object DeserializeJson = JsonSerializer.Deserialize<object>(SerializedJson);
                return JsonSerializer.Serialize(DeserializeJson, typeof(object), new JsonSerializerOptions { WriteIndented = WriteIndented });
            }
            return null;


        }

    }
}
