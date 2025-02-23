// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class CertificateVerificationCodeProperties
    {
        internal static CertificateVerificationCodeProperties DeserializeCertificateVerificationCodeProperties(JsonElement element)
        {
            Optional<string> verificationCode = default;
            Optional<string> subject = default;
            Optional<string> expiry = default;
            Optional<string> thumbprint = default;
            Optional<bool> isVerified = default;
            Optional<byte[]> certificate = default;
            Optional<string> created = default;
            Optional<string> updated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verificationCode"))
                {
                    verificationCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subject"))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiry"))
                {
                    expiry = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isVerified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    certificate = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("created"))
                {
                    created = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updated"))
                {
                    updated = property.Value.GetString();
                    continue;
                }
            }
            return new CertificateVerificationCodeProperties(verificationCode.Value, subject.Value, expiry.Value, thumbprint.Value, Optional.ToNullable(isVerified), certificate.Value, created.Value, updated.Value);
        }
    }
}
