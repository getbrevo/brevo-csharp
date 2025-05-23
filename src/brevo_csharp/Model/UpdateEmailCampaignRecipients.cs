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
    /// Segment ids and List ids to include/exclude from campaign
    /// </summary>
    [DataContract]
    public partial class UpdateEmailCampaignRecipients :  IEquatable<UpdateEmailCampaignRecipients>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEmailCampaignRecipients" /> class.
        /// </summary>
        /// <param name="exclusionListIds">List ids which have to be excluded from a campaign.</param>
        /// <param name="listIds">Lists Ids to send the campaign to. Campaign should only be updated with listIds if listIds were used to create it. REQUIRED if already not present in campaign and scheduledAt is not empty.</param>
        /// <param name="segmentIds">Mandatory if listIds are not used. Campaign should only be updated with segmentIds if segmentIds were used to create it. Segment ids to send the campaign to..</param>
        /// <param name="exclusionSegmentIds">Segment ids which have to be excluded from a campaign. .</param>
        public UpdateEmailCampaignRecipients(List<long?> exclusionListIds = default(List<long?>), List<long?> listIds = default(List<long?>), List<long?> segmentIds = default(List<long?>), List<long?> exclusionSegmentIds = default(List<long?>))
        {
            this.ExclusionListIds = exclusionListIds;
            this.ListIds = listIds;
            this.SegmentIds = segmentIds;
            this.ExclusionSegmentIds = exclusionSegmentIds;
        }
        
        /// <summary>
        /// List ids which have to be excluded from a campaign
        /// </summary>
        /// <value>List ids which have to be excluded from a campaign</value>
        [DataMember(Name="exclusionListIds", EmitDefaultValue=false)]
        public List<long?> ExclusionListIds { get; set; }

        /// <summary>
        /// Lists Ids to send the campaign to. Campaign should only be updated with listIds if listIds were used to create it. REQUIRED if already not present in campaign and scheduledAt is not empty
        /// </summary>
        /// <value>Lists Ids to send the campaign to. Campaign should only be updated with listIds if listIds were used to create it. REQUIRED if already not present in campaign and scheduledAt is not empty</value>
        [DataMember(Name="listIds", EmitDefaultValue=false)]
        public List<long?> ListIds { get; set; }

        /// <summary>
        /// Mandatory if listIds are not used. Campaign should only be updated with segmentIds if segmentIds were used to create it. Segment ids to send the campaign to.
        /// </summary>
        /// <value>Mandatory if listIds are not used. Campaign should only be updated with segmentIds if segmentIds were used to create it. Segment ids to send the campaign to.</value>
        [DataMember(Name="segmentIds", EmitDefaultValue=false)]
        public List<long?> SegmentIds { get; set; }

        /// <summary>
        /// Segment ids which have to be excluded from a campaign. 
        /// </summary>
        /// <value>Segment ids which have to be excluded from a campaign. </value>
        [DataMember(Name="exclusionSegmentIds", EmitDefaultValue=false)]
        public List<long?> ExclusionSegmentIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEmailCampaignRecipients {\n");
            sb.Append("  ExclusionListIds: ").Append(ExclusionListIds).Append("\n");
            sb.Append("  ListIds: ").Append(ListIds).Append("\n");
            sb.Append("  SegmentIds: ").Append(SegmentIds).Append("\n");
            sb.Append("  ExclusionSegmentIds: ").Append(ExclusionSegmentIds).Append("\n");
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
            return this.Equals(input as UpdateEmailCampaignRecipients);
        }

        /// <summary>
        /// Returns true if UpdateEmailCampaignRecipients instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateEmailCampaignRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateEmailCampaignRecipients input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExclusionListIds == input.ExclusionListIds ||
                    this.ExclusionListIds != null &&
                    this.ExclusionListIds.SequenceEqual(input.ExclusionListIds)
                ) && 
                (
                    this.ListIds == input.ListIds ||
                    this.ListIds != null &&
                    this.ListIds.SequenceEqual(input.ListIds)
                ) && 
                (
                    this.SegmentIds == input.SegmentIds ||
                    this.SegmentIds != null &&
                    this.SegmentIds.SequenceEqual(input.SegmentIds)
                ) && 
                (
                    this.ExclusionSegmentIds == input.ExclusionSegmentIds ||
                    this.ExclusionSegmentIds != null &&
                    this.ExclusionSegmentIds.SequenceEqual(input.ExclusionSegmentIds)
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
                if (this.ExclusionListIds != null)
                    hashCode = hashCode * 59 + this.ExclusionListIds.GetHashCode();
                if (this.ListIds != null)
                    hashCode = hashCode * 59 + this.ListIds.GetHashCode();
                if (this.SegmentIds != null)
                    hashCode = hashCode * 59 + this.SegmentIds.GetHashCode();
                if (this.ExclusionSegmentIds != null)
                    hashCode = hashCode * 59 + this.ExclusionSegmentIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
