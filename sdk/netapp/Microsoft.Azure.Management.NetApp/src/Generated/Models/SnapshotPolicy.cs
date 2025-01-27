// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Snapshot policy information
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SnapshotPolicy : IResource
    {
        /// <summary>
        /// Initializes a new instance of the SnapshotPolicy class.
        /// </summary>
        public SnapshotPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SnapshotPolicy class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="hourlySchedule">hourlySchedule</param>
        /// <param name="dailySchedule">dailySchedule</param>
        /// <param name="weeklySchedule">weeklySchedule</param>
        /// <param name="monthlySchedule">monthlySchedule</param>
        /// <param name="enabled">The property to decide policy is enabled or
        /// not</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        public SnapshotPolicy(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), HourlySchedule hourlySchedule = default(HourlySchedule), DailySchedule dailySchedule = default(DailySchedule), WeeklySchedule weeklySchedule = default(WeeklySchedule), MonthlySchedule monthlySchedule = default(MonthlySchedule), bool? enabled = default(bool?), string provisioningState = default(string))
        {
            Location = location;
            Id = id;
            Name = name;
            Type = type;
            Tags = tags;
            HourlySchedule = hourlySchedule;
            DailySchedule = dailySchedule;
            WeeklySchedule = weeklySchedule;
            MonthlySchedule = monthlySchedule;
            Enabled = enabled;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets hourlySchedule
        /// </summary>
        /// <remarks>
        /// Schedule for hourly snapshots
        /// </remarks>
        [JsonProperty(PropertyName = "properties.hourlySchedule")]
        public HourlySchedule HourlySchedule { get; set; }

        /// <summary>
        /// Gets or sets dailySchedule
        /// </summary>
        /// <remarks>
        /// Schedule for daily snapshots
        /// </remarks>
        [JsonProperty(PropertyName = "properties.dailySchedule")]
        public DailySchedule DailySchedule { get; set; }

        /// <summary>
        /// Gets or sets weeklySchedule
        /// </summary>
        /// <remarks>
        /// Schedule for weekly snapshots
        /// </remarks>
        [JsonProperty(PropertyName = "properties.weeklySchedule")]
        public WeeklySchedule WeeklySchedule { get; set; }

        /// <summary>
        /// Gets or sets monthlySchedule
        /// </summary>
        /// <remarks>
        /// Schedule for monthly snapshots
        /// </remarks>
        [JsonProperty(PropertyName = "properties.monthlySchedule")]
        public MonthlySchedule MonthlySchedule { get; set; }

        /// <summary>
        /// Gets or sets the property to decide policy is enabled or not
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
