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
    /// GetTransacBlockedContactsContacts
    /// </summary>
    [DataContract]
    public partial class GetTransacBlockedContactsContacts :  IEquatable<GetTransacBlockedContactsContacts>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransacBlockedContactsContacts" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransacBlockedContactsContacts() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransacBlockedContactsContacts" /> class.
        /// </summary>
        /// <param name="email">Email address of the blocked or unsubscribed contact (required).</param>
        /// <param name="senderEmail">Sender email address of the blocked or unsubscribed contact (required).</param>
        /// <param name="reason">reason (required).</param>
        /// <param name="blockedAt">Date when the contact was blocked or unsubscribed on (required).</param>
        public GetTransacBlockedContactsContacts(string email = default(string), string senderEmail = default(string), GetTransacBlockedContactsReason reason = default(GetTransacBlockedContactsReason), string blockedAt = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for GetTransacBlockedContactsContacts and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "senderEmail" is required (not null)
            if (senderEmail == null)
            {
                throw new InvalidDataException("senderEmail is a required property for GetTransacBlockedContactsContacts and cannot be null");
            }
            else
            {
                this.SenderEmail = senderEmail;
            }
            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new InvalidDataException("reason is a required property for GetTransacBlockedContactsContacts and cannot be null");
            }
            else
            {
                this.Reason = reason;
            }
            // to ensure "blockedAt" is required (not null)
            if (blockedAt == null)
            {
                throw new InvalidDataException("blockedAt is a required property for GetTransacBlockedContactsContacts and cannot be null");
            }
            else
            {
                this.BlockedAt = blockedAt;
            }
        }
        
        /// <summary>
        /// Email address of the blocked or unsubscribed contact
        /// </summary>
        /// <value>Email address of the blocked or unsubscribed contact</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Sender email address of the blocked or unsubscribed contact
        /// </summary>
        /// <value>Sender email address of the blocked or unsubscribed contact</value>
        [DataMember(Name="senderEmail", EmitDefaultValue=false)]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public GetTransacBlockedContactsReason Reason { get; set; }

        /// <summary>
        /// Date when the contact was blocked or unsubscribed on
        /// </summary>
        /// <value>Date when the contact was blocked or unsubscribed on</value>
        [DataMember(Name="blockedAt", EmitDefaultValue=false)]
        public string BlockedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransacBlockedContactsContacts {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  BlockedAt: ").Append(BlockedAt).Append("\n");
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
            return this.Equals(input as GetTransacBlockedContactsContacts);
        }

        /// <summary>
        /// Returns true if GetTransacBlockedContactsContacts instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransacBlockedContactsContacts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransacBlockedContactsContacts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.SenderEmail == input.SenderEmail ||
                    (this.SenderEmail != null &&
                    this.SenderEmail.Equals(input.SenderEmail))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.BlockedAt == input.BlockedAt ||
                    (this.BlockedAt != null &&
                    this.BlockedAt.Equals(input.BlockedAt))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.SenderEmail != null)
                    hashCode = hashCode * 59 + this.SenderEmail.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.BlockedAt != null)
                    hashCode = hashCode * 59 + this.BlockedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
