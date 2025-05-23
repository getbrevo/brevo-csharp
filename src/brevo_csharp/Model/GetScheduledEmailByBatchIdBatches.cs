/* 
 * Brevo API
 *
 * Brevo provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/brevo  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  |   | 422  | Error. Unprocessable Entity | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@brevo.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = brevo_csharp.Client.SwaggerDateConverter;

namespace brevo_csharp.Model
{
    /// <summary>
    /// GetScheduledEmailByBatchIdBatches
    /// </summary>
    [DataContract]
    public partial class GetScheduledEmailByBatchIdBatches :  IEquatable<GetScheduledEmailByBatchIdBatches>
    {
        /// <summary>
        /// Current status of the scheduled batch
        /// </summary>
        /// <value>Current status of the scheduled batch</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum InProgress for value: inProgress
            /// </summary>
            [EnumMember(Value = "inProgress")]
            InProgress = 1,
            
            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 2,
            
            /// <summary>
            /// Enum Processed for value: processed
            /// </summary>
            [EnumMember(Value = "processed")]
            Processed = 3,
            
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 4
        }

        /// <summary>
        /// Current status of the scheduled batch
        /// </summary>
        /// <value>Current status of the scheduled batch</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetScheduledEmailByBatchIdBatches" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetScheduledEmailByBatchIdBatches() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetScheduledEmailByBatchIdBatches" /> class.
        /// </summary>
        /// <param name="scheduledAt">Datetime for which the batch was scheduled (required).</param>
        /// <param name="createdAt">Datetime on which the batch was scheduled (required).</param>
        /// <param name="status">Current status of the scheduled batch (required).</param>
        public GetScheduledEmailByBatchIdBatches(DateTime? scheduledAt = default(DateTime?), DateTime? createdAt = default(DateTime?), StatusEnum status = default(StatusEnum))
        {
            // to ensure "scheduledAt" is required (not null)
            if (scheduledAt == null)
            {
                throw new InvalidDataException("scheduledAt is a required property for GetScheduledEmailByBatchIdBatches and cannot be null");
            }
            else
            {
                this.ScheduledAt = scheduledAt;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetScheduledEmailByBatchIdBatches and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for GetScheduledEmailByBatchIdBatches and cannot be null");
            }
            else
            {
                this.Status = status;
            }
        }
        
        /// <summary>
        /// Datetime for which the batch was scheduled
        /// </summary>
        /// <value>Datetime for which the batch was scheduled</value>
        [DataMember(Name="scheduledAt", EmitDefaultValue=false)]
        public DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// Datetime on which the batch was scheduled
        /// </summary>
        /// <value>Datetime on which the batch was scheduled</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetScheduledEmailByBatchIdBatches {\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetScheduledEmailByBatchIdBatches);
        }

        /// <summary>
        /// Returns true if GetScheduledEmailByBatchIdBatches instances are equal
        /// </summary>
        /// <param name="input">Instance of GetScheduledEmailByBatchIdBatches to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetScheduledEmailByBatchIdBatches input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ScheduledAt != null)
                    hashCode = hashCode * 59 + this.ScheduledAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }

}
