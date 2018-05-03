﻿using Newtonsoft.Json;
using System;

namespace SolcNet.DataDescription.Parsing
{
    class HexStringConverter : JsonConverter<byte[]>
    {
        public override byte[] ReadJson(JsonReader reader, Type objectType, byte[] existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var hexStr = (string)reader.Value;
            return EncodingUtils.HexToBytes(hexStr);
        }

        public override void WriteJson(JsonWriter writer, byte[] value, JsonSerializer serializer)
        {
            var hexString = EncodingUtils.ByteArrayToHex(value);
            writer.WriteToken(JsonToken.String, hexString);
        }
    }
}