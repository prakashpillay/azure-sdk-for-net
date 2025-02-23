// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> Description of name availability. </summary>
    public partial class DeviceProvisioningServicesNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of DeviceProvisioningServicesNameAvailabilityResult. </summary>
        internal DeviceProvisioningServicesNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServicesNameAvailabilityResult. </summary>
        /// <param name="nameAvailable"> specifies if a name is available or not. </param>
        /// <param name="reason"> specifies the reason a name is unavailable. </param>
        /// <param name="message"> message containing a detailed reason name is unavailable. </param>
        internal DeviceProvisioningServicesNameAvailabilityResult(bool? nameAvailable, DeviceProvisioningServicesNameUnavailableReason? reason, string message)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> specifies if a name is available or not. </summary>
        public bool? NameAvailable { get; }
        /// <summary> specifies the reason a name is unavailable. </summary>
        public DeviceProvisioningServicesNameUnavailableReason? Reason { get; }
        /// <summary> message containing a detailed reason name is unavailable. </summary>
        public string Message { get; }
    }
}
