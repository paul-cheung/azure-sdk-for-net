// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of which Windows Event Log events will be collected and how
    /// they will be collected.
    /// Only collected from Windows machines.
    /// </summary>
    public partial class WindowsEventLogDataSource
    {
        /// <summary>
        /// Initializes a new instance of the WindowsEventLogDataSource class.
        /// </summary>
        public WindowsEventLogDataSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WindowsEventLogDataSource class.
        /// </summary>
        /// <param name="streams">List of streams that this data source will be
        /// sent to.
        /// A stream indicates what schema will be used for this data and
        /// usually what table in Log Analytics the data will be sent
        /// to.</param>
        /// <param name="scheduledTransferPeriod">The interval between data
        /// uploads (scheduled transfers), rounded up to the nearest minute.
        /// Possible values include: 'PT1M', 'PT5M', 'PT15M', 'PT30M',
        /// 'PT60M'</param>
        /// <param name="xPathQueries">A list of Windows Event Log queries in
        /// XPATH format.</param>
        /// <param name="name">A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of
        /// type) within the data collection rule.</param>
        public WindowsEventLogDataSource(IList<string> streams, string scheduledTransferPeriod, IList<string> xPathQueries, string name)
        {
            Streams = streams;
            ScheduledTransferPeriod = scheduledTransferPeriod;
            XPathQueries = xPathQueries;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and
        /// usually what table in Log Analytics the data will be sent to.
        /// </summary>
        [JsonProperty(PropertyName = "streams")]
        public IList<string> Streams { get; set; }

        /// <summary>
        /// Gets or sets the interval between data uploads (scheduled
        /// transfers), rounded up to the nearest minute. Possible values
        /// include: 'PT1M', 'PT5M', 'PT15M', 'PT30M', 'PT60M'
        /// </summary>
        [JsonProperty(PropertyName = "scheduledTransferPeriod")]
        public string ScheduledTransferPeriod { get; set; }

        /// <summary>
        /// Gets or sets a list of Windows Event Log queries in XPATH format.
        /// </summary>
        [JsonProperty(PropertyName = "xPathQueries")]
        public IList<string> XPathQueries { get; set; }

        /// <summary>
        /// Gets or sets a friendly name for the data source.
        /// This name should be unique across all data sources (regardless of
        /// type) within the data collection rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Streams == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Streams");
            }
            if (ScheduledTransferPeriod == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ScheduledTransferPeriod");
            }
            if (XPathQueries == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "XPathQueries");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}