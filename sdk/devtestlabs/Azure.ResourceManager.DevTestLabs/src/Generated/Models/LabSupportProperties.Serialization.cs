// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class LabSupportProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteStringValue(Enabled.Value.ToString());
            }
            if (Optional.IsDefined(Markdown))
            {
                writer.WritePropertyName("markdown");
                writer.WriteStringValue(Markdown);
            }
            writer.WriteEndObject();
        }

        internal static LabSupportProperties DeserializeLabSupportProperties(JsonElement element)
        {
            Optional<EnableStatus> enabled = default;
            Optional<string> markdown = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = new EnableStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("markdown"))
                {
                    markdown = property.Value.GetString();
                    continue;
                }
            }
            return new LabSupportProperties(Optional.ToNullable(enabled), markdown.Value);
        }
    }
}
