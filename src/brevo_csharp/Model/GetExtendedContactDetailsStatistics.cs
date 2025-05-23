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
    /// Campaign statistics of the contact
    /// </summary>
    [DataContract]
    public partial class GetExtendedContactDetailsStatistics :  IEquatable<GetExtendedContactDetailsStatistics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedContactDetailsStatistics" /> class.
        /// </summary>
        /// <param name="messagesSent">Listing of the sent campaign for the contact.</param>
        /// <param name="hardBounces">Listing of the hardbounes generated by the contact.</param>
        /// <param name="softBounces">Listing of the softbounes generated by the contact.</param>
        /// <param name="complaints">Listing of the complaints generated by the contact.</param>
        /// <param name="unsubscriptions">unsubscriptions.</param>
        /// <param name="opened">Listing of the openings generated by the contact.</param>
        /// <param name="clicked">Listing of the clicks generated by the contact.</param>
        /// <param name="transacAttributes">Listing of the transactional attributes for the contact.</param>
        /// <param name="delivered">Listing of the delivered campaign for the contact.</param>
        public GetExtendedContactDetailsStatistics(List<GetExtendedContactDetailsStatisticsMessagesSent> messagesSent = default(List<GetExtendedContactDetailsStatisticsMessagesSent>), List<GetExtendedContactDetailsStatisticsMessagesSent> hardBounces = default(List<GetExtendedContactDetailsStatisticsMessagesSent>), List<GetExtendedContactDetailsStatisticsMessagesSent> softBounces = default(List<GetExtendedContactDetailsStatisticsMessagesSent>), List<GetExtendedContactDetailsStatisticsMessagesSent> complaints = default(List<GetExtendedContactDetailsStatisticsMessagesSent>), GetExtendedContactDetailsStatisticsUnsubscriptions unsubscriptions = default(GetExtendedContactDetailsStatisticsUnsubscriptions), List<GetExtendedContactDetailsStatisticsOpened> opened = default(List<GetExtendedContactDetailsStatisticsOpened>), List<GetExtendedContactDetailsStatisticsClicked> clicked = default(List<GetExtendedContactDetailsStatisticsClicked>), List<Object> transacAttributes = default(List<Object>), List<GetExtendedContactDetailsStatisticsDelivered> delivered = default(List<GetExtendedContactDetailsStatisticsDelivered>))
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
        /// Listing of the sent campaign for the contact
        /// </summary>
        /// <value>Listing of the sent campaign for the contact</value>
        [DataMember(Name="messagesSent", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsMessagesSent> MessagesSent { get; set; }

        /// <summary>
        /// Listing of the hardbounes generated by the contact
        /// </summary>
        /// <value>Listing of the hardbounes generated by the contact</value>
        [DataMember(Name="hardBounces", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsMessagesSent> HardBounces { get; set; }

        /// <summary>
        /// Listing of the softbounes generated by the contact
        /// </summary>
        /// <value>Listing of the softbounes generated by the contact</value>
        [DataMember(Name="softBounces", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsMessagesSent> SoftBounces { get; set; }

        /// <summary>
        /// Listing of the complaints generated by the contact
        /// </summary>
        /// <value>Listing of the complaints generated by the contact</value>
        [DataMember(Name="complaints", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsMessagesSent> Complaints { get; set; }

        /// <summary>
        /// Gets or Sets Unsubscriptions
        /// </summary>
        [DataMember(Name="unsubscriptions", EmitDefaultValue=false)]
        public GetExtendedContactDetailsStatisticsUnsubscriptions Unsubscriptions { get; set; }

        /// <summary>
        /// Listing of the openings generated by the contact
        /// </summary>
        /// <value>Listing of the openings generated by the contact</value>
        [DataMember(Name="opened", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsOpened> Opened { get; set; }

        /// <summary>
        /// Listing of the clicks generated by the contact
        /// </summary>
        /// <value>Listing of the clicks generated by the contact</value>
        [DataMember(Name="clicked", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsClicked> Clicked { get; set; }

        /// <summary>
        /// Listing of the transactional attributes for the contact
        /// </summary>
        /// <value>Listing of the transactional attributes for the contact</value>
        [DataMember(Name="transacAttributes", EmitDefaultValue=false)]
        public List<Object> TransacAttributes { get; set; }

        /// <summary>
        /// Listing of the delivered campaign for the contact
        /// </summary>
        /// <value>Listing of the delivered campaign for the contact</value>
        [DataMember(Name="delivered", EmitDefaultValue=false)]
        public List<GetExtendedContactDetailsStatisticsDelivered> Delivered { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExtendedContactDetailsStatistics {\n");
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
            return this.Equals(input as GetExtendedContactDetailsStatistics);
        }

        /// <summary>
        /// Returns true if GetExtendedContactDetailsStatistics instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExtendedContactDetailsStatistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExtendedContactDetailsStatistics input)
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
