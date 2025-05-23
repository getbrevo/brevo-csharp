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
    /// GetSmsEventReportEvents
    /// </summary>
    [DataContract]
    public partial class GetSmsEventReportEvents :  IEquatable<GetSmsEventReportEvents>
    {
        /// <summary>
        /// Event which occurred
        /// </summary>
        /// <value>Event which occurred</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventEnum
        {
            
            /// <summary>
            /// Enum Bounces for value: bounces
            /// </summary>
            [EnumMember(Value = "bounces")]
            Bounces = 1,
            
            /// <summary>
            /// Enum HardBounces for value: hardBounces
            /// </summary>
            [EnumMember(Value = "hardBounces")]
            HardBounces = 2,
            
            /// <summary>
            /// Enum SoftBounces for value: softBounces
            /// </summary>
            [EnumMember(Value = "softBounces")]
            SoftBounces = 3,
            
            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered = 4,
            
            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 5,
            
            /// <summary>
            /// Enum Accepted for value: accepted
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted = 6,
            
            /// <summary>
            /// Enum Unsubscription for value: unsubscription
            /// </summary>
            [EnumMember(Value = "unsubscription")]
            Unsubscription = 7,
            
            /// <summary>
            /// Enum Replies for value: replies
            /// </summary>
            [EnumMember(Value = "replies")]
            Replies = 8,
            
            /// <summary>
            /// Enum Blocked for value: blocked
            /// </summary>
            [EnumMember(Value = "blocked")]
            Blocked = 9,
            
            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 10,
            
            /// <summary>
            /// Enum Skipped for value: skipped
            /// </summary>
            [EnumMember(Value = "skipped")]
            Skipped = 11
        }

        /// <summary>
        /// Event which occurred
        /// </summary>
        /// <value>Event which occurred</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public EventEnum? Event { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSmsEventReportEvents" /> class.
        /// </summary>
        /// <param name="phoneNumber">Phone number which has generated the event.</param>
        /// <param name="date">UTC date-time on which the event has been generated.</param>
        /// <param name="messageId">Message ID which generated the event.</param>
        /// <param name="_event">Event which occurred.</param>
        /// <param name="reason">Reason of bounce (only available if the event is hardbounce or softbounce).</param>
        /// <param name="reply">reply.</param>
        /// <param name="tag">Tag of the SMS which generated the event.</param>
        public GetSmsEventReportEvents(string phoneNumber = default(string), string date = default(string), string messageId = default(string), EventEnum? _event = default(EventEnum?), string reason = default(string), string reply = default(string), string tag = default(string))
        {
            this.PhoneNumber = phoneNumber;
            this.Date = date;
            this.MessageId = messageId;
            this.Event = _event;
            this.Reason = reason;
            this.Reply = reply;
            this.Tag = tag;
        }
        
        /// <summary>
        /// Phone number which has generated the event
        /// </summary>
        /// <value>Phone number which has generated the event</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// UTC date-time on which the event has been generated
        /// </summary>
        /// <value>UTC date-time on which the event has been generated</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Message ID which generated the event
        /// </summary>
        /// <value>Message ID which generated the event</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }


        /// <summary>
        /// Reason of bounce (only available if the event is hardbounce or softbounce)
        /// </summary>
        /// <value>Reason of bounce (only available if the event is hardbounce or softbounce)</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Reply
        /// </summary>
        [DataMember(Name="reply", EmitDefaultValue=false)]
        public string Reply { get; set; }

        /// <summary>
        /// Tag of the SMS which generated the event
        /// </summary>
        /// <value>Tag of the SMS which generated the event</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSmsEventReportEvents {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Reply: ").Append(Reply).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as GetSmsEventReportEvents);
        }

        /// <summary>
        /// Returns true if GetSmsEventReportEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSmsEventReportEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSmsEventReportEvents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Reply == input.Reply ||
                    (this.Reply != null &&
                    this.Reply.Equals(input.Reply))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Reply != null)
                    hashCode = hashCode * 59 + this.Reply.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }
    }

}
