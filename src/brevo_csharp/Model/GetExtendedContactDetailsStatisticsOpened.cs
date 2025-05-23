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
    /// GetExtendedContactDetailsStatisticsOpened
    /// </summary>
    [DataContract]
    public partial class GetExtendedContactDetailsStatisticsOpened :  IEquatable<GetExtendedContactDetailsStatisticsOpened>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedContactDetailsStatisticsOpened" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetExtendedContactDetailsStatisticsOpened() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedContactDetailsStatisticsOpened" /> class.
        /// </summary>
        /// <param name="campaignId">ID of the campaign which generated the event (required).</param>
        /// <param name="count">Number of openings for the campaign (required).</param>
        /// <param name="eventTime">UTC date-time of the event (required).</param>
        /// <param name="ip">IP from which the user has opened the email (required).</param>
        public GetExtendedContactDetailsStatisticsOpened(long? campaignId = default(long?), long? count = default(long?), string eventTime = default(string), string ip = default(string))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new InvalidDataException("campaignId is a required property for GetExtendedContactDetailsStatisticsOpened and cannot be null");
            }
            else
            {
                this.CampaignId = campaignId;
            }
            // to ensure "count" is required (not null)
            if (count == null)
            {
                throw new InvalidDataException("count is a required property for GetExtendedContactDetailsStatisticsOpened and cannot be null");
            }
            else
            {
                this.Count = count;
            }
            // to ensure "eventTime" is required (not null)
            if (eventTime == null)
            {
                throw new InvalidDataException("eventTime is a required property for GetExtendedContactDetailsStatisticsOpened and cannot be null");
            }
            else
            {
                this.EventTime = eventTime;
            }
            // to ensure "ip" is required (not null)
            if (ip == null)
            {
                throw new InvalidDataException("ip is a required property for GetExtendedContactDetailsStatisticsOpened and cannot be null");
            }
            else
            {
                this.Ip = ip;
            }
        }
        
        /// <summary>
        /// ID of the campaign which generated the event
        /// </summary>
        /// <value>ID of the campaign which generated the event</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public long? CampaignId { get; set; }

        /// <summary>
        /// Number of openings for the campaign
        /// </summary>
        /// <value>Number of openings for the campaign</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// UTC date-time of the event
        /// </summary>
        /// <value>UTC date-time of the event</value>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public string EventTime { get; set; }

        /// <summary>
        /// IP from which the user has opened the email
        /// </summary>
        /// <value>IP from which the user has opened the email</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExtendedContactDetailsStatisticsOpened {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
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
            return this.Equals(input as GetExtendedContactDetailsStatisticsOpened);
        }

        /// <summary>
        /// Returns true if GetExtendedContactDetailsStatisticsOpened instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExtendedContactDetailsStatisticsOpened to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExtendedContactDetailsStatisticsOpened input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.EventTime == input.EventTime ||
                    (this.EventTime != null &&
                    this.EventTime.Equals(input.EventTime))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
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
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.EventTime != null)
                    hashCode = hashCode * 59 + this.EventTime.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                return hashCode;
            }
        }
    }

}
