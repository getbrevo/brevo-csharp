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
    /// Campaign Statistics for the contact
    /// </summary>
    [DataContract]
    public partial class GetContactCampaignStats :  IEquatable<GetContactCampaignStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactCampaignStats" /> class.
        /// </summary>
        /// <param name="messagesSent">messagesSent.</param>
        /// <param name="hardBounces">hardBounces.</param>
        /// <param name="softBounces">softBounces.</param>
        /// <param name="complaints">complaints.</param>
        /// <param name="unsubscriptions">unsubscriptions.</param>
        /// <param name="opened">opened.</param>
        /// <param name="clicked">clicked.</param>
        /// <param name="transacAttributes">transacAttributes.</param>
        /// <param name="delivered">delivered.</param>
        public GetContactCampaignStats(List<GetExtendedContactDetailsStatisticsMessagesSent> messagesSent = default(List<GetExtendedContactDetailsStatisticsMessagesSent>), List<GetExtendedContactDetailsStatisticsMessagesSent> hardBounces = default(List<GetExtendedContactDetailsStatisticsMessagesSent>), List<GetExtendedContactDetailsStatisticsMessagesSent> softBounces = default(List<GetExtendedContactDetailsStatisticsMessagesSent>), List<GetExtendedContactDetailsStatisticsMessagesSent> complaints = default(List<GetExtendedContactDetailsStatisticsMessagesSent>), GetContactCampaignStatsUnsubscriptions unsubscriptions = default(GetContactCampaignStatsUnsubscriptions), List<GetContactCampaignStatsOpened> opened = default(List<GetContactCampaignStatsOpened>), List<GetContactCampaignStatsClicked> clicked = default(List<GetContactCampaignStatsClicked>), List<GetContactCampaignStatsTransacAttributes> transacAttributes = default(List<GetContactCampaignStatsTransacAttributes>), List<GetExtendedContactDetailsStatisticsMessagesSent> delivered = default(List<GetExtendedContactDetailsStatisticsMessagesSent>))
        {
            this.MessagesSent = messagesSent;
            this.HardBounces = hardBounces;
            this.SoftBounces = softBounces;
            this.Complaints = complaints;
            this.Unsubscriptions = unsubscriptions;
            this.Opened = opened;
            this.Clicked = clicked;
            this.TransacAttributes = transacAttributes;
            this.Delivered = delivered;
        }
        
        /// <summary>
        /// Gets or Sets MessagesSent
        /// </summary>
        [DataMember(Name="messagesSent", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsMessagesSent> MessagesSent { get; set; }

        /// <summary>
        /// Gets or Sets HardBounces
        /// </summary>
        [DataMember(Name="hardBounces", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsMessagesSent> HardBounces { get; set; }

        /// <summary>
        /// Gets or Sets SoftBounces
        /// </summary>
        [DataMember(Name="softBounces", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsMessagesSent> SoftBounces { get; set; }

        /// <summary>
        /// Gets or Sets Complaints
        /// </summary>
        [DataMember(Name="complaints", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsMessagesSent> Complaints { get; set; }

        /// <summary>
        /// Gets or Sets Unsubscriptions
        /// </summary>
        [DataMember(Name="unsubscriptions", EmitDefaultValue=false)]
        public GetContactCampaignStatsUnsubscriptions Unsubscriptions { get; set; }

        /// <summary>
        /// Gets or Sets Opened
        /// </summary>
        [DataMember(Name="opened", EmitDefaultValue=false)]
        public List<GetContactCampaignStatsOpened> Opened { get; set; }

        /// <summary>
        /// Gets or Sets Clicked
        /// </summary>
        [DataMember(Name="clicked", EmitDefaultValue=false)]
        public List<GetContactCampaignStatsClicked> Clicked { get; set; }

        /// <summary>
        /// Gets or Sets TransacAttributes
        /// </summary>
        [DataMember(Name="transacAttributes", EmitDefaultValue=false)]
        public List<GetContactCampaignStatsTransacAttributes> TransacAttributes { get; set; }

        /// <summary>
        /// Gets or Sets Delivered
        /// </summary>
        [DataMember(Name="delivered", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsMessagesSent> Delivered { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetContactCampaignStats {\n");
            sb.Append("  MessagesSent: ").Append(MessagesSent).Append("\n");
            sb.Append("  HardBounces: ").Append(HardBounces).Append("\n");
            sb.Append("  SoftBounces: ").Append(SoftBounces).Append("\n");
            sb.Append("  Complaints: ").Append(Complaints).Append("\n");
            sb.Append("  Unsubscriptions: ").Append(Unsubscriptions).Append("\n");
            sb.Append("  Opened: ").Append(Opened).Append("\n");
            sb.Append("  Clicked: ").Append(Clicked).Append("\n");
            sb.Append("  TransacAttributes: ").Append(TransacAttributes).Append("\n");
            sb.Append("  Delivered: ").Append(Delivered).Append("\n");
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
            return this.Equals(input as GetContactCampaignStats);
        }

        /// <summary>
        /// Returns true if GetContactCampaignStats instances are equal
        /// </summary>
        /// <param name="input">Instance of GetContactCampaignStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetContactCampaignStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessagesSent == input.MessagesSent ||
                    this.MessagesSent != null &&
                    this.MessagesSent.SequenceEqual(input.MessagesSent)
                ) && 
                (
                    this.HardBounces == input.HardBounces ||
                    this.HardBounces != null &&
                    this.HardBounces.SequenceEqual(input.HardBounces)
                ) && 
                (
                    this.SoftBounces == input.SoftBounces ||
                    this.SoftBounces != null &&
                    this.SoftBounces.SequenceEqual(input.SoftBounces)
                ) && 
                (
                    this.Complaints == input.Complaints ||
                    this.Complaints != null &&
                    this.Complaints.SequenceEqual(input.Complaints)
                ) && 
                (
                    this.Unsubscriptions == input.Unsubscriptions ||
                    (this.Unsubscriptions != null &&
                    this.Unsubscriptions.Equals(input.Unsubscriptions))
                ) && 
                (
                    this.Opened == input.Opened ||
                    this.Opened != null &&
                    this.Opened.SequenceEqual(input.Opened)
                ) && 
                (
                    this.Clicked == input.Clicked ||
                    this.Clicked != null &&
                    this.Clicked.SequenceEqual(input.Clicked)
                ) && 
                (
                    this.TransacAttributes == input.TransacAttributes ||
                    this.TransacAttributes != null &&
                    this.TransacAttributes.SequenceEqual(input.TransacAttributes)
                ) && 
                (
                    this.Delivered == input.Delivered ||
                    this.Delivered != null &&
                    this.Delivered.SequenceEqual(input.Delivered)
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
                if (this.MessagesSent != null)
                    hashCode = hashCode * 59 + this.MessagesSent.GetHashCode();
                if (this.HardBounces != null)
                    hashCode = hashCode * 59 + this.HardBounces.GetHashCode();
                if (this.SoftBounces != null)
                    hashCode = hashCode * 59 + this.SoftBounces.GetHashCode();
                if (this.Complaints != null)
                    hashCode = hashCode * 59 + this.Complaints.GetHashCode();
                if (this.Unsubscriptions != null)
                    hashCode = hashCode * 59 + this.Unsubscriptions.GetHashCode();
                if (this.Opened != null)
                    hashCode = hashCode * 59 + this.Opened.GetHashCode();
                if (this.Clicked != null)
                    hashCode = hashCode * 59 + this.Clicked.GetHashCode();
                if (this.TransacAttributes != null)
                    hashCode = hashCode * 59 + this.TransacAttributes.GetHashCode();
                if (this.Delivered != null)
                    hashCode = hashCode * 59 + this.Delivered.GetHashCode();
                return hashCode;
            }
        }
    }

}
