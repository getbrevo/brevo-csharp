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
    /// Identifies the contact associated with the event. At least one identifier is required.
    /// </summary>
    [DataContract]
    public partial class EventIdentifiers :  IEquatable<EventIdentifiers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventIdentifiers" /> class.
        /// </summary>
        /// <param name="emailId">Email Id associated with the event.</param>
        /// <param name="phoneId">SMS associated with the event.</param>
        /// <param name="whatsappId">whatsapp associated with the event.</param>
        /// <param name="landlineNumberId">landline_number associated with the event.</param>
        /// <param name="extId">ext_id associated with the event.</param>
        public EventIdentifiers(string emailId = default(string), string phoneId = default(string), string whatsappId = default(string), string landlineNumberId = default(string), string extId = default(string))
        {
            this.EmailId = emailId;
            this.PhoneId = phoneId;
            this.WhatsappId = whatsappId;
            this.LandlineNumberId = landlineNumberId;
            this.ExtId = extId;
        }
        
        /// <summary>
        /// Email Id associated with the event
        /// </summary>
        /// <value>Email Id associated with the event</value>
        [DataMember(Name="email_id", EmitDefaultValue=false)]
        public string EmailId { get; set; }

        /// <summary>
        /// SMS associated with the event
        /// </summary>
        /// <value>SMS associated with the event</value>
        [DataMember(Name="phone_id", EmitDefaultValue=false)]
        public string PhoneId { get; set; }

        /// <summary>
        /// whatsapp associated with the event
        /// </summary>
        /// <value>whatsapp associated with the event</value>
        [DataMember(Name="whatsapp_id", EmitDefaultValue=false)]
        public string WhatsappId { get; set; }

        /// <summary>
        /// landline_number associated with the event
        /// </summary>
        /// <value>landline_number associated with the event</value>
        [DataMember(Name="landline_number_id", EmitDefaultValue=false)]
        public string LandlineNumberId { get; set; }

        /// <summary>
        /// ext_id associated with the event
        /// </summary>
        /// <value>ext_id associated with the event</value>
        [DataMember(Name="ext_id", EmitDefaultValue=false)]
        public string ExtId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventIdentifiers {\n");
            sb.Append("  EmailId: ").Append(EmailId).Append("\n");
            sb.Append("  PhoneId: ").Append(PhoneId).Append("\n");
            sb.Append("  WhatsappId: ").Append(WhatsappId).Append("\n");
            sb.Append("  LandlineNumberId: ").Append(LandlineNumberId).Append("\n");
            sb.Append("  ExtId: ").Append(ExtId).Append("\n");
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
            return this.Equals(input as EventIdentifiers);
        }

        /// <summary>
        /// Returns true if EventIdentifiers instances are equal
        /// </summary>
        /// <param name="input">Instance of EventIdentifiers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventIdentifiers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailId == input.EmailId ||
                    (this.EmailId != null &&
                    this.EmailId.Equals(input.EmailId))
                ) && 
                (
                    this.PhoneId == input.PhoneId ||
                    (this.PhoneId != null &&
                    this.PhoneId.Equals(input.PhoneId))
                ) && 
                (
                    this.WhatsappId == input.WhatsappId ||
                    (this.WhatsappId != null &&
                    this.WhatsappId.Equals(input.WhatsappId))
                ) && 
                (
                    this.LandlineNumberId == input.LandlineNumberId ||
                    (this.LandlineNumberId != null &&
                    this.LandlineNumberId.Equals(input.LandlineNumberId))
                ) && 
                (
                    this.ExtId == input.ExtId ||
                    (this.ExtId != null &&
                    this.ExtId.Equals(input.ExtId))
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
                if (this.EmailId != null)
                    hashCode = hashCode * 59 + this.EmailId.GetHashCode();
                if (this.PhoneId != null)
                    hashCode = hashCode * 59 + this.PhoneId.GetHashCode();
                if (this.WhatsappId != null)
                    hashCode = hashCode * 59 + this.WhatsappId.GetHashCode();
                if (this.LandlineNumberId != null)
                    hashCode = hashCode * 59 + this.LandlineNumberId.GetHashCode();
                if (this.ExtId != null)
                    hashCode = hashCode * 59 + this.ExtId.GetHashCode();
                return hashCode;
            }
        }
    }

}
