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
    /// UpdateBatchContactsContacts
    /// </summary>
    [DataContract]
    public partial class UpdateBatchContactsContacts :  IEquatable<UpdateBatchContactsContacts>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBatchContactsContacts" /> class.
        /// </summary>
        /// <param name="email">Email address of the user to be updated (For each operation only pass one of the supported contact identifiers. Email, id or sms).</param>
        /// <param name="id">id of the user to be updated (For each operation only pass one of the supported contact identifiers. Email, id or sms).</param>
        /// <param name="sms">SMS of the user to be updated (For each operation only pass one of the supported contact identifiers. Email, id or sms).</param>
        /// <param name="extId">Pass your own Id to update ext_id of a contact..</param>
        /// <param name="attributes">Pass the set of attributes to be updated. **These attributes must be present in your account**. To update existing email address of a contact with the new one please pass EMAIL in attribtes. For example, **{ \&quot;EMAIL\&quot;:\&quot;newemail@domain.com\&quot;, \&quot;FNAME\&quot;:\&quot;Ellie\&quot;, \&quot;LNAME\&quot;:\&quot;Roger\&quot;}**. Keep in mind transactional attributes can be updated the same way as normal attributes. Mobile Number in **SMS** field should be passed with proper country code. For example: **{\&quot;SMS\&quot;:\&quot;+91xxxxxxxxxx\&quot;} or {\&quot;SMS\&quot;:\&quot;0091xxxxxxxxxx\&quot;}** .</param>
        /// <param name="emailBlacklisted">Set/unset this field to blacklist/allow the contact for emails (emailBlacklisted &#x3D; true).</param>
        /// <param name="smsBlacklisted">Set/unset this field to blacklist/allow the contact for SMS (smsBlacklisted &#x3D; true).</param>
        /// <param name="listIds">Ids of the lists to add the contact to.</param>
        /// <param name="unlinkListIds">Ids of the lists to remove the contact from.</param>
        /// <param name="smtpBlacklistSender">transactional email forbidden sender for contact. Use only for email Contact.</param>
        public UpdateBatchContactsContacts(string email = default(string), long? id = default(long?), string sms = default(string), string extId = default(string), Dictionary<string, Object> attributes = default(Dictionary<string, Object>), bool? emailBlacklisted = default(bool?), bool? smsBlacklisted = default(bool?), List<long?> listIds = default(List<long?>), List<long?> unlinkListIds = default(List<long?>), List<string> smtpBlacklistSender = default(List<string>))
        {
            this.Email = email;
            this.Id = id;
            this.Sms = sms;
            this.ExtId = extId;
            this.Attributes = attributes;
            this.EmailBlacklisted = emailBlacklisted;
            this.SmsBlacklisted = smsBlacklisted;
            this.ListIds = listIds;
            this.UnlinkListIds = unlinkListIds;
            this.SmtpBlacklistSender = smtpBlacklistSender;
        }
        
        /// <summary>
        /// Email address of the user to be updated (For each operation only pass one of the supported contact identifiers. Email, id or sms)
        /// </summary>
        /// <value>Email address of the user to be updated (For each operation only pass one of the supported contact identifiers. Email, id or sms)</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// id of the user to be updated (For each operation only pass one of the supported contact identifiers. Email, id or sms)
        /// </summary>
        /// <value>id of the user to be updated (For each operation only pass one of the supported contact identifiers. Email, id or sms)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// SMS of the user to be updated (For each operation only pass one of the supported contact identifiers. Email, id or sms)
        /// </summary>
        /// <value>SMS of the user to be updated (For each operation only pass one of the supported contact identifiers. Email, id or sms)</value>
        [DataMember(Name="sms", EmitDefaultValue=false)]
        public string Sms { get; set; }

        /// <summary>
        /// Pass your own Id to update ext_id of a contact.
        /// </summary>
        /// <value>Pass your own Id to update ext_id of a contact.</value>
        [DataMember(Name="ext_id", EmitDefaultValue=false)]
        public string ExtId { get; set; }

        /// <summary>
        /// Pass the set of attributes to be updated. **These attributes must be present in your account**. To update existing email address of a contact with the new one please pass EMAIL in attribtes. For example, **{ \&quot;EMAIL\&quot;:\&quot;newemail@domain.com\&quot;, \&quot;FNAME\&quot;:\&quot;Ellie\&quot;, \&quot;LNAME\&quot;:\&quot;Roger\&quot;}**. Keep in mind transactional attributes can be updated the same way as normal attributes. Mobile Number in **SMS** field should be passed with proper country code. For example: **{\&quot;SMS\&quot;:\&quot;+91xxxxxxxxxx\&quot;} or {\&quot;SMS\&quot;:\&quot;0091xxxxxxxxxx\&quot;}** 
        /// </summary>
        /// <value>Pass the set of attributes to be updated. **These attributes must be present in your account**. To update existing email address of a contact with the new one please pass EMAIL in attribtes. For example, **{ \&quot;EMAIL\&quot;:\&quot;newemail@domain.com\&quot;, \&quot;FNAME\&quot;:\&quot;Ellie\&quot;, \&quot;LNAME\&quot;:\&quot;Roger\&quot;}**. Keep in mind transactional attributes can be updated the same way as normal attributes. Mobile Number in **SMS** field should be passed with proper country code. For example: **{\&quot;SMS\&quot;:\&quot;+91xxxxxxxxxx\&quot;} or {\&quot;SMS\&quot;:\&quot;0091xxxxxxxxxx\&quot;}** </value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, Object> Attributes { get; set; }

        /// <summary>
        /// Set/unset this field to blacklist/allow the contact for emails (emailBlacklisted &#x3D; true)
        /// </summary>
        /// <value>Set/unset this field to blacklist/allow the contact for emails (emailBlacklisted &#x3D; true)</value>
        [DataMember(Name="emailBlacklisted", EmitDefaultValue=false)]
        public bool? EmailBlacklisted { get; set; }

        /// <summary>
        /// Set/unset this field to blacklist/allow the contact for SMS (smsBlacklisted &#x3D; true)
        /// </summary>
        /// <value>Set/unset this field to blacklist/allow the contact for SMS (smsBlacklisted &#x3D; true)</value>
        [DataMember(Name="smsBlacklisted", EmitDefaultValue=false)]
        public bool? SmsBlacklisted { get; set; }

        /// <summary>
        /// Ids of the lists to add the contact to
        /// </summary>
        /// <value>Ids of the lists to add the contact to</value>
        [DataMember(Name="listIds", EmitDefaultValue=false)]
        public List<long?> ListIds { get; set; }

        /// <summary>
        /// Ids of the lists to remove the contact from
        /// </summary>
        /// <value>Ids of the lists to remove the contact from</value>
        [DataMember(Name="unlinkListIds", EmitDefaultValue=false)]
        public List<long?> UnlinkListIds { get; set; }

        /// <summary>
        /// transactional email forbidden sender for contact. Use only for email Contact
        /// </summary>
        /// <value>transactional email forbidden sender for contact. Use only for email Contact</value>
        [DataMember(Name="smtpBlacklistSender", EmitDefaultValue=false)]
        public List<string> SmtpBlacklistSender { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBatchContactsContacts {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  ExtId: ").Append(ExtId).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  EmailBlacklisted: ").Append(EmailBlacklisted).Append("\n");
            sb.Append("  SmsBlacklisted: ").Append(SmsBlacklisted).Append("\n");
            sb.Append("  ListIds: ").Append(ListIds).Append("\n");
            sb.Append("  UnlinkListIds: ").Append(UnlinkListIds).Append("\n");
            sb.Append("  SmtpBlacklistSender: ").Append(SmtpBlacklistSender).Append("\n");
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
            return this.Equals(input as UpdateBatchContactsContacts);
        }

        /// <summary>
        /// Returns true if UpdateBatchContactsContacts instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateBatchContactsContacts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateBatchContactsContacts input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Sms == input.Sms ||
                    (this.Sms != null &&
                    this.Sms.Equals(input.Sms))
                ) && 
                (
                    this.ExtId == input.ExtId ||
                    (this.ExtId != null &&
                    this.ExtId.Equals(input.ExtId))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.EmailBlacklisted == input.EmailBlacklisted ||
                    (this.EmailBlacklisted != null &&
                    this.EmailBlacklisted.Equals(input.EmailBlacklisted))
                ) && 
                (
                    this.SmsBlacklisted == input.SmsBlacklisted ||
                    (this.SmsBlacklisted != null &&
                    this.SmsBlacklisted.Equals(input.SmsBlacklisted))
                ) && 
                (
                    this.ListIds == input.ListIds ||
                    this.ListIds != null &&
                    this.ListIds.SequenceEqual(input.ListIds)
                ) && 
                (
                    this.UnlinkListIds == input.UnlinkListIds ||
                    this.UnlinkListIds != null &&
                    this.UnlinkListIds.SequenceEqual(input.UnlinkListIds)
                ) && 
                (
                    this.SmtpBlacklistSender == input.SmtpBlacklistSender ||
                    this.SmtpBlacklistSender != null &&
                    this.SmtpBlacklistSender.SequenceEqual(input.SmtpBlacklistSender)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Sms != null)
                    hashCode = hashCode * 59 + this.Sms.GetHashCode();
                if (this.ExtId != null)
                    hashCode = hashCode * 59 + this.ExtId.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.EmailBlacklisted != null)
                    hashCode = hashCode * 59 + this.EmailBlacklisted.GetHashCode();
                if (this.SmsBlacklisted != null)
                    hashCode = hashCode * 59 + this.SmsBlacklisted.GetHashCode();
                if (this.ListIds != null)
                    hashCode = hashCode * 59 + this.ListIds.GetHashCode();
                if (this.UnlinkListIds != null)
                    hashCode = hashCode * 59 + this.UnlinkListIds.GetHashCode();
                if (this.SmtpBlacklistSender != null)
                    hashCode = hashCode * 59 + this.SmtpBlacklistSender.GetHashCode();
                return hashCode;
            }
        }
    }

}
