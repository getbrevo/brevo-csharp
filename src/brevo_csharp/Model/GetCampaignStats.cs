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
    /// GetCampaignStats
    /// </summary>
    [DataContract]
    public partial class GetCampaignStats :  IEquatable<GetCampaignStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCampaignStats" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCampaignStats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCampaignStats" /> class.
        /// </summary>
        /// <param name="listId">List Id of email campaign (only in case of get email campaign(s)(not for global stats)).</param>
        /// <param name="uniqueClicks">Number of unique clicks for the campaign (required).</param>
        /// <param name="clickers">Number of total clicks for the campaign (required).</param>
        /// <param name="complaints">Number of complaints (Spam reports) for the campaign (required).</param>
        /// <param name="delivered">Number of delivered emails for the campaign (required).</param>
        /// <param name="sent">Number of sent emails for the campaign (required).</param>
        /// <param name="softBounces">Number of softbounce for the campaign (required).</param>
        /// <param name="hardBounces">Number of harbounce for the campaign (required).</param>
        /// <param name="uniqueViews">Number of unique openings for the campaign (required).</param>
        /// <param name="trackableViews">Recipients without any privacy protection option enabled in their email client (required).</param>
        /// <param name="trackableViewsRate">Rate of recipients without any privacy protection option enabled in their email client.</param>
        /// <param name="estimatedViews">Rate of recipients without any privacy protection option enabled in their email client, applied to all delivered emails.</param>
        /// <param name="unsubscriptions">Number of unsubscription for the campaign (required).</param>
        /// <param name="viewed">Number of openings for the campaign (required).</param>
        /// <param name="deferred">Number of deferred emails for the campaign.</param>
        /// <param name="returnBounce">Total number of non-delivered campaigns for a particular campaign id..</param>
        /// <param name="opensRate">Percentage of recipients who open the email out of your total number of recipients. Depending on your Campaign settings, they may include Apple MPP opens. (required).</param>
        public GetCampaignStats(long? listId = default(long?), long? uniqueClicks = default(long?), long? clickers = default(long?), long? complaints = default(long?), long? delivered = default(long?), long? sent = default(long?), long? softBounces = default(long?), long? hardBounces = default(long?), long? uniqueViews = default(long?), long? trackableViews = default(long?), float? trackableViewsRate = default(float?), long? estimatedViews = default(long?), long? unsubscriptions = default(long?), long? viewed = default(long?), long? deferred = default(long?), long? returnBounce = default(long?), float? opensRate = default(float?))
        {
            // to ensure "uniqueClicks" is required (not null)
            if (uniqueClicks == null)
            {
                throw new InvalidDataException("uniqueClicks is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.UniqueClicks = uniqueClicks;
            }
            // to ensure "clickers" is required (not null)
            if (clickers == null)
            {
                throw new InvalidDataException("clickers is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.Clickers = clickers;
            }
            // to ensure "complaints" is required (not null)
            if (complaints == null)
            {
                throw new InvalidDataException("complaints is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.Complaints = complaints;
            }
            // to ensure "delivered" is required (not null)
            if (delivered == null)
            {
                throw new InvalidDataException("delivered is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.Delivered = delivered;
            }
            // to ensure "sent" is required (not null)
            if (sent == null)
            {
                throw new InvalidDataException("sent is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.Sent = sent;
            }
            // to ensure "softBounces" is required (not null)
            if (softBounces == null)
            {
                throw new InvalidDataException("softBounces is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.SoftBounces = softBounces;
            }
            // to ensure "hardBounces" is required (not null)
            if (hardBounces == null)
            {
                throw new InvalidDataException("hardBounces is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.HardBounces = hardBounces;
            }
            // to ensure "uniqueViews" is required (not null)
            if (uniqueViews == null)
            {
                throw new InvalidDataException("uniqueViews is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.UniqueViews = uniqueViews;
            }
            // to ensure "trackableViews" is required (not null)
            if (trackableViews == null)
            {
                throw new InvalidDataException("trackableViews is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.TrackableViews = trackableViews;
            }
            // to ensure "unsubscriptions" is required (not null)
            if (unsubscriptions == null)
            {
                throw new InvalidDataException("unsubscriptions is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.Unsubscriptions = unsubscriptions;
            }
            // to ensure "viewed" is required (not null)
            if (viewed == null)
            {
                throw new InvalidDataException("viewed is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.Viewed = viewed;
            }
            // to ensure "opensRate" is required (not null)
            if (opensRate == null)
            {
                throw new InvalidDataException("opensRate is a required property for GetCampaignStats and cannot be null");
            }
            else
            {
                this.OpensRate = opensRate;
            }
            this.ListId = listId;
            this.TrackableViewsRate = trackableViewsRate;
            this.EstimatedViews = estimatedViews;
            this.Deferred = deferred;
            this.ReturnBounce = returnBounce;
        }
        
        /// <summary>
        /// List Id of email campaign (only in case of get email campaign(s)(not for global stats))
        /// </summary>
        /// <value>List Id of email campaign (only in case of get email campaign(s)(not for global stats))</value>
        [DataMember(Name="listId", EmitDefaultValue=false)]
        public long? ListId { get; set; }

        /// <summary>
        /// Number of unique clicks for the campaign
        /// </summary>
        /// <value>Number of unique clicks for the campaign</value>
        [DataMember(Name="uniqueClicks", EmitDefaultValue=false)]
        public long? UniqueClicks { get; set; }

        /// <summary>
        /// Number of total clicks for the campaign
        /// </summary>
        /// <value>Number of total clicks for the campaign</value>
        [DataMember(Name="clickers", EmitDefaultValue=false)]
        public long? Clickers { get; set; }

        /// <summary>
        /// Number of complaints (Spam reports) for the campaign
        /// </summary>
        /// <value>Number of complaints (Spam reports) for the campaign</value>
        [DataMember(Name="complaints", EmitDefaultValue=false)]
        public long? Complaints { get; set; }

        /// <summary>
        /// Number of delivered emails for the campaign
        /// </summary>
        /// <value>Number of delivered emails for the campaign</value>
        [DataMember(Name="delivered", EmitDefaultValue=false)]
        public long? Delivered { get; set; }

        /// <summary>
        /// Number of sent emails for the campaign
        /// </summary>
        /// <value>Number of sent emails for the campaign</value>
        [DataMember(Name="sent", EmitDefaultValue=false)]
        public long? Sent { get; set; }

        /// <summary>
        /// Number of softbounce for the campaign
        /// </summary>
        /// <value>Number of softbounce for the campaign</value>
        [DataMember(Name="softBounces", EmitDefaultValue=false)]
        public long? SoftBounces { get; set; }

        /// <summary>
        /// Number of harbounce for the campaign
        /// </summary>
        /// <value>Number of harbounce for the campaign</value>
        [DataMember(Name="hardBounces", EmitDefaultValue=false)]
        public long? HardBounces { get; set; }

        /// <summary>
        /// Number of unique openings for the campaign
        /// </summary>
        /// <value>Number of unique openings for the campaign</value>
        [DataMember(Name="uniqueViews", EmitDefaultValue=false)]
        public long? UniqueViews { get; set; }

        /// <summary>
        /// Recipients without any privacy protection option enabled in their email client
        /// </summary>
        /// <value>Recipients without any privacy protection option enabled in their email client</value>
        [DataMember(Name="trackableViews", EmitDefaultValue=false)]
        public long? TrackableViews { get; set; }

        /// <summary>
        /// Rate of recipients without any privacy protection option enabled in their email client
        /// </summary>
        /// <value>Rate of recipients without any privacy protection option enabled in their email client</value>
        [DataMember(Name="trackableViewsRate", EmitDefaultValue=false)]
        public float? TrackableViewsRate { get; set; }

        /// <summary>
        /// Rate of recipients without any privacy protection option enabled in their email client, applied to all delivered emails
        /// </summary>
        /// <value>Rate of recipients without any privacy protection option enabled in their email client, applied to all delivered emails</value>
        [DataMember(Name="estimatedViews", EmitDefaultValue=false)]
        public long? EstimatedViews { get; set; }

        /// <summary>
        /// Number of unsubscription for the campaign
        /// </summary>
        /// <value>Number of unsubscription for the campaign</value>
        [DataMember(Name="unsubscriptions", EmitDefaultValue=false)]
        public long? Unsubscriptions { get; set; }

        /// <summary>
        /// Number of openings for the campaign
        /// </summary>
        /// <value>Number of openings for the campaign</value>
        [DataMember(Name="viewed", EmitDefaultValue=false)]
        public long? Viewed { get; set; }

        /// <summary>
        /// Number of deferred emails for the campaign
        /// </summary>
        /// <value>Number of deferred emails for the campaign</value>
        [DataMember(Name="deferred", EmitDefaultValue=false)]
        public long? Deferred { get; set; }

        /// <summary>
        /// Total number of non-delivered campaigns for a particular campaign id.
        /// </summary>
        /// <value>Total number of non-delivered campaigns for a particular campaign id.</value>
        [DataMember(Name="returnBounce", EmitDefaultValue=false)]
        public long? ReturnBounce { get; set; }

        /// <summary>
        /// Percentage of recipients who open the email out of your total number of recipients. Depending on your Campaign settings, they may include Apple MPP opens.
        /// </summary>
        /// <value>Percentage of recipients who open the email out of your total number of recipients. Depending on your Campaign settings, they may include Apple MPP opens.</value>
        [DataMember(Name="opensRate", EmitDefaultValue=false)]
        public float? OpensRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCampaignStats {\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  UniqueClicks: ").Append(UniqueClicks).Append("\n");
            sb.Append("  Clickers: ").Append(Clickers).Append("\n");
            sb.Append("  Complaints: ").Append(Complaints).Append("\n");
            sb.Append("  Delivered: ").Append(Delivered).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  SoftBounces: ").Append(SoftBounces).Append("\n");
            sb.Append("  HardBounces: ").Append(HardBounces).Append("\n");
            sb.Append("  UniqueViews: ").Append(UniqueViews).Append("\n");
            sb.Append("  TrackableViews: ").Append(TrackableViews).Append("\n");
            sb.Append("  TrackableViewsRate: ").Append(TrackableViewsRate).Append("\n");
            sb.Append("  EstimatedViews: ").Append(EstimatedViews).Append("\n");
            sb.Append("  Unsubscriptions: ").Append(Unsubscriptions).Append("\n");
            sb.Append("  Viewed: ").Append(Viewed).Append("\n");
            sb.Append("  Deferred: ").Append(Deferred).Append("\n");
            sb.Append("  ReturnBounce: ").Append(ReturnBounce).Append("\n");
            sb.Append("  OpensRate: ").Append(OpensRate).Append("\n");
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
            return this.Equals(input as GetCampaignStats);
        }

        /// <summary>
        /// Returns true if GetCampaignStats instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCampaignStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCampaignStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.UniqueClicks == input.UniqueClicks ||
                    (this.UniqueClicks != null &&
                    this.UniqueClicks.Equals(input.UniqueClicks))
                ) && 
                (
                    this.Clickers == input.Clickers ||
                    (this.Clickers != null &&
                    this.Clickers.Equals(input.Clickers))
                ) && 
                (
                    this.Complaints == input.Complaints ||
                    (this.Complaints != null &&
                    this.Complaints.Equals(input.Complaints))
                ) && 
                (
                    this.Delivered == input.Delivered ||
                    (this.Delivered != null &&
                    this.Delivered.Equals(input.Delivered))
                ) && 
                (
                    this.Sent == input.Sent ||
                    (this.Sent != null &&
                    this.Sent.Equals(input.Sent))
                ) && 
                (
                    this.SoftBounces == input.SoftBounces ||
                    (this.SoftBounces != null &&
                    this.SoftBounces.Equals(input.SoftBounces))
                ) && 
                (
                    this.HardBounces == input.HardBounces ||
                    (this.HardBounces != null &&
                    this.HardBounces.Equals(input.HardBounces))
                ) && 
                (
                    this.UniqueViews == input.UniqueViews ||
                    (this.UniqueViews != null &&
                    this.UniqueViews.Equals(input.UniqueViews))
                ) && 
                (
                    this.TrackableViews == input.TrackableViews ||
                    (this.TrackableViews != null &&
                    this.TrackableViews.Equals(input.TrackableViews))
                ) && 
                (
                    this.TrackableViewsRate == input.TrackableViewsRate ||
                    (this.TrackableViewsRate != null &&
                    this.TrackableViewsRate.Equals(input.TrackableViewsRate))
                ) && 
                (
                    this.EstimatedViews == input.EstimatedViews ||
                    (this.EstimatedViews != null &&
                    this.EstimatedViews.Equals(input.EstimatedViews))
                ) && 
                (
                    this.Unsubscriptions == input.Unsubscriptions ||
                    (this.Unsubscriptions != null &&
                    this.Unsubscriptions.Equals(input.Unsubscriptions))
                ) && 
                (
                    this.Viewed == input.Viewed ||
                    (this.Viewed != null &&
                    this.Viewed.Equals(input.Viewed))
                ) && 
                (
                    this.Deferred == input.Deferred ||
                    (this.Deferred != null &&
                    this.Deferred.Equals(input.Deferred))
                ) && 
                (
                    this.ReturnBounce == input.ReturnBounce ||
                    (this.ReturnBounce != null &&
                    this.ReturnBounce.Equals(input.ReturnBounce))
                ) && 
                (
                    this.OpensRate == input.OpensRate ||
                    (this.OpensRate != null &&
                    this.OpensRate.Equals(input.OpensRate))
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
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.UniqueClicks != null)
                    hashCode = hashCode * 59 + this.UniqueClicks.GetHashCode();
                if (this.Clickers != null)
                    hashCode = hashCode * 59 + this.Clickers.GetHashCode();
                if (this.Complaints != null)
                    hashCode = hashCode * 59 + this.Complaints.GetHashCode();
                if (this.Delivered != null)
                    hashCode = hashCode * 59 + this.Delivered.GetHashCode();
                if (this.Sent != null)
                    hashCode = hashCode * 59 + this.Sent.GetHashCode();
                if (this.SoftBounces != null)
                    hashCode = hashCode * 59 + this.SoftBounces.GetHashCode();
                if (this.HardBounces != null)
                    hashCode = hashCode * 59 + this.HardBounces.GetHashCode();
                if (this.UniqueViews != null)
                    hashCode = hashCode * 59 + this.UniqueViews.GetHashCode();
                if (this.TrackableViews != null)
                    hashCode = hashCode * 59 + this.TrackableViews.GetHashCode();
                if (this.TrackableViewsRate != null)
                    hashCode = hashCode * 59 + this.TrackableViewsRate.GetHashCode();
                if (this.EstimatedViews != null)
                    hashCode = hashCode * 59 + this.EstimatedViews.GetHashCode();
                if (this.Unsubscriptions != null)
                    hashCode = hashCode * 59 + this.Unsubscriptions.GetHashCode();
                if (this.Viewed != null)
                    hashCode = hashCode * 59 + this.Viewed.GetHashCode();
                if (this.Deferred != null)
                    hashCode = hashCode * 59 + this.Deferred.GetHashCode();
                if (this.ReturnBounce != null)
                    hashCode = hashCode * 59 + this.ReturnBounce.GetHashCode();
                if (this.OpensRate != null)
                    hashCode = hashCode * 59 + this.OpensRate.GetHashCode();
                return hashCode;
            }
        }
    }

}
