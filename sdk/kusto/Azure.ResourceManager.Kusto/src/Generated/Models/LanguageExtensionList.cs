// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The list of language extension objects. </summary>
    public partial class LanguageExtensionList
    {
        /// <summary> Initializes a new instance of LanguageExtensionList. </summary>
        public LanguageExtensionList()
        {
            Value = new ChangeTrackingList<LanguageExtension>();
        }

        /// <summary> Initializes a new instance of LanguageExtensionList. </summary>
        /// <param name="value"> The list of language extensions. </param>
        internal LanguageExtensionList(IList<LanguageExtension> value)
        {
            Value = value;
        }

        /// <summary> The list of language extensions. </summary>
        public IList<LanguageExtension> Value { get; }
    }
}
