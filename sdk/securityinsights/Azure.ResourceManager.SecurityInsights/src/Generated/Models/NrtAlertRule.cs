// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents NRT alert rule. </summary>
    public partial class NrtAlertRule : SecurityInsightsAlertRuleData
    {
        /// <summary> Initializes a new instance of NrtAlertRule. </summary>
        public NrtAlertRule()
        {
            Tactics = new ChangeTrackingList<AttackTactic>();
            Techniques = new ChangeTrackingList<string>();
            CustomDetails = new ChangeTrackingDictionary<string, string>();
            EntityMappings = new ChangeTrackingList<EntityMapping>();
            Kind = AlertRuleKind.NRT;
        }

        /// <summary> Initializes a new instance of NrtAlertRule. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the alert rule. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="alertRuleTemplateName"> The Name of the alert rule template used to create this rule. </param>
        /// <param name="templateVersion"> The version of the alert rule template used to create this rule - in format &lt;a.b.c&gt;, where all are numbers, for example 0 &lt;1.0.2&gt;. </param>
        /// <param name="description"> The description of the alert rule. </param>
        /// <param name="query"> The query that creates alerts for this rule. </param>
        /// <param name="tactics"> The tactics of the alert rule. </param>
        /// <param name="techniques"> The techniques of the alert rule. </param>
        /// <param name="displayName"> The display name for alerts created by this alert rule. </param>
        /// <param name="enabled"> Determines whether this alert rule is enabled or disabled. </param>
        /// <param name="lastModifiedUtc"> The last time that this alert rule has been modified. </param>
        /// <param name="suppressionDuration"> The suppression (in ISO 8601 duration format) to wait since last time this alert rule been triggered. </param>
        /// <param name="suppressionEnabled"> Determines whether the suppression for this alert rule is enabled or disabled. </param>
        /// <param name="severity"> The severity for alerts created by this alert rule. </param>
        /// <param name="incidentConfiguration"> The settings of the incidents that created from alerts triggered by this analytics rule. </param>
        /// <param name="customDetails"> Dictionary of string key-value pairs of columns to be attached to the alert. </param>
        /// <param name="entityMappings"> Array of the entity mappings of the alert rule. </param>
        /// <param name="alertDetailsOverride"> The alert details override settings. </param>
        internal NrtAlertRule(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, ETag? etag, string alertRuleTemplateName, string templateVersion, string description, string query, IList<AttackTactic> tactics, IList<string> techniques, string displayName, bool? enabled, DateTimeOffset? lastModifiedUtc, TimeSpan? suppressionDuration, bool? suppressionEnabled, AlertSeverity? severity, IncidentConfiguration incidentConfiguration, IDictionary<string, string> customDetails, IList<EntityMapping> entityMappings, AlertDetailsOverride alertDetailsOverride) : base(id, name, resourceType, systemData, kind, etag)
        {
            AlertRuleTemplateName = alertRuleTemplateName;
            TemplateVersion = templateVersion;
            Description = description;
            Query = query;
            Tactics = tactics;
            Techniques = techniques;
            DisplayName = displayName;
            Enabled = enabled;
            LastModifiedUtc = lastModifiedUtc;
            SuppressionDuration = suppressionDuration;
            SuppressionEnabled = suppressionEnabled;
            Severity = severity;
            IncidentConfiguration = incidentConfiguration;
            CustomDetails = customDetails;
            EntityMappings = entityMappings;
            AlertDetailsOverride = alertDetailsOverride;
            Kind = kind;
        }

        /// <summary> The Name of the alert rule template used to create this rule. </summary>
        public string AlertRuleTemplateName { get; set; }
        /// <summary> The version of the alert rule template used to create this rule - in format &lt;a.b.c&gt;, where all are numbers, for example 0 &lt;1.0.2&gt;. </summary>
        public string TemplateVersion { get; set; }
        /// <summary> The description of the alert rule. </summary>
        public string Description { get; set; }
        /// <summary> The query that creates alerts for this rule. </summary>
        public string Query { get; set; }
        /// <summary> The tactics of the alert rule. </summary>
        public IList<AttackTactic> Tactics { get; }
        /// <summary> The techniques of the alert rule. </summary>
        public IList<string> Techniques { get; }
        /// <summary> The display name for alerts created by this alert rule. </summary>
        public string DisplayName { get; set; }
        /// <summary> Determines whether this alert rule is enabled or disabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The last time that this alert rule has been modified. </summary>
        public DateTimeOffset? LastModifiedUtc { get; }
        /// <summary> The suppression (in ISO 8601 duration format) to wait since last time this alert rule been triggered. </summary>
        public TimeSpan? SuppressionDuration { get; set; }
        /// <summary> Determines whether the suppression for this alert rule is enabled or disabled. </summary>
        public bool? SuppressionEnabled { get; set; }
        /// <summary> The severity for alerts created by this alert rule. </summary>
        public AlertSeverity? Severity { get; set; }
        /// <summary> The settings of the incidents that created from alerts triggered by this analytics rule. </summary>
        public IncidentConfiguration IncidentConfiguration { get; set; }
        /// <summary> Dictionary of string key-value pairs of columns to be attached to the alert. </summary>
        public IDictionary<string, string> CustomDetails { get; }
        /// <summary> Array of the entity mappings of the alert rule. </summary>
        public IList<EntityMapping> EntityMappings { get; }
        /// <summary> The alert details override settings. </summary>
        public AlertDetailsOverride AlertDetailsOverride { get; set; }
    }
}
