// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Gateway.Automation.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProcessingStatusLog
    {
        /// <summary>
        /// Initializes a new instance of the ProcessingStatusLog class.
        /// </summary>
        public ProcessingStatusLog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProcessingStatusLog class.
        /// </summary>
        public ProcessingStatusLog(System.DateTime? createDate = default(System.DateTime?), int? sequenceId = default(int?), string level = default(string), string message = default(string))
        {
            CreateDate = createDate;
            SequenceId = sequenceId;
            Level = level;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createDate")]
        public System.DateTime? CreateDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sequenceId")]
        public int? SequenceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
