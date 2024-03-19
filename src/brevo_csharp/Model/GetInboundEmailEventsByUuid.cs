/* 
 * Brevo API
 *
 * Brevo provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/brevo  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
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
    /// GetInboundEmailEventsByUuid
    /// </summary>
    [DataContract]
    public partial class GetInboundEmailEventsByUuid :  IEquatable<GetInboundEmailEventsByUuid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInboundEmailEventsByUuid" /> class.
        /// </summary>
        /// <param name="receivedAt">Date when email was received on SMTP relay.</param>
        /// <param name="deliveredAt">Date when email was delivered successfully to client’s webhook.</param>
        /// <param name="recipient">Recipient’s email address.</param>
        /// <param name="sender">Sender’s email address.</param>
        /// <param name="messageId">Value of the Message-ID header. This will be present only after the processing is done..</param>
        /// <param name="subject">Value of the Subject header. This will be present only after the processing is done. .</param>
        /// <param name="attachments">List of attachments of the email. This will be present only after the processing is done..</param>
        /// <param name="logs">List of events/logs that describe the lifecycle of the email on SIB platform.</param>
        public GetInboundEmailEventsByUuid(DateTime? receivedAt = default(DateTime?), DateTime? deliveredAt = default(DateTime?), string recipient = default(string), string sender = default(string), string messageId = default(string), string subject = default(string), List<GetInboundEmailEventsByUuidAttachments> attachments = default(List<GetInboundEmailEventsByUuidAttachments>), List<GetInboundEmailEventsByUuidLogs> logs = default(List<GetInboundEmailEventsByUuidLogs>))
        {
            this.ReceivedAt = receivedAt;
            this.DeliveredAt = deliveredAt;
            this.Recipient = recipient;
            this.Sender = sender;
            this.MessageId = messageId;
            this.Subject = subject;
            this.Attachments = attachments;
            this.Logs = logs;
        }
        
        /// <summary>
        /// Date when email was received on SMTP relay
        /// </summary>
        /// <value>Date when email was received on SMTP relay</value>
        [DataMember(Name="receivedAt", EmitDefaultValue=false)]
        public DateTime? ReceivedAt { get; set; }

        /// <summary>
        /// Date when email was delivered successfully to client’s webhook
        /// </summary>
        /// <value>Date when email was delivered successfully to client’s webhook</value>
        [DataMember(Name="deliveredAt", EmitDefaultValue=false)]
        public DateTime? DeliveredAt { get; set; }

        /// <summary>
        /// Recipient’s email address
        /// </summary>
        /// <value>Recipient’s email address</value>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Sender’s email address
        /// </summary>
        /// <value>Sender’s email address</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Value of the Message-ID header. This will be present only after the processing is done.
        /// </summary>
        /// <value>Value of the Message-ID header. This will be present only after the processing is done.</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Value of the Subject header. This will be present only after the processing is done. 
        /// </summary>
        /// <value>Value of the Subject header. This will be present only after the processing is done. </value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// List of attachments of the email. This will be present only after the processing is done.
        /// </summary>
        /// <value>List of attachments of the email. This will be present only after the processing is done.</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<GetInboundEmailEventsByUuidAttachments> Attachments { get; set; }

        /// <summary>
        /// List of events/logs that describe the lifecycle of the email on SIB platform
        /// </summary>
        /// <value>List of events/logs that describe the lifecycle of the email on SIB platform</value>
        [DataMember(Name="logs", EmitDefaultValue=false)]
        public List<GetInboundEmailEventsByUuidLogs> Logs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetInboundEmailEventsByUuid {\n");
            sb.Append("  ReceivedAt: ").Append(ReceivedAt).Append("\n");
            sb.Append("  DeliveredAt: ").Append(DeliveredAt).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
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
            return this.Equals(input as GetInboundEmailEventsByUuid);
        }

        /// <summary>
        /// Returns true if GetInboundEmailEventsByUuid instances are equal
        /// </summary>
        /// <param name="input">Instance of GetInboundEmailEventsByUuid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInboundEmailEventsByUuid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReceivedAt == input.ReceivedAt ||
                    (this.ReceivedAt != null &&
                    this.ReceivedAt.Equals(input.ReceivedAt))
                ) && 
                (
                    this.DeliveredAt == input.DeliveredAt ||
                    (this.DeliveredAt != null &&
                    this.DeliveredAt.Equals(input.DeliveredAt))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Logs == input.Logs ||
                    this.Logs != null &&
                    this.Logs.SequenceEqual(input.Logs)
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
                if (this.ReceivedAt != null)
                    hashCode = hashCode * 59 + this.ReceivedAt.GetHashCode();
                if (this.DeliveredAt != null)
                    hashCode = hashCode * 59 + this.DeliveredAt.GetHashCode();
                if (this.Recipient != null)
                    hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Logs != null)
                    hashCode = hashCode * 59 + this.Logs.GetHashCode();
                return hashCode;
            }
        }
    }

}
