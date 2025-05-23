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
    /// SsoTokenRequest
    /// </summary>
    [DataContract]
    public partial class SsoTokenRequest :  IEquatable<SsoTokenRequest>
    {
        /// <summary>
        /// Set target after login success * automation - Redirect to Automation after login * email_campaign - Redirect to Email Campaign after login * contacts - Redirect to Contacts after login * landing_pages - Redirect to Landing Pages after login * email_transactional - Redirect to Email Transactional after login * senders - Redirect to Contacts after login * sms_campaign - Redirect to Sms Campaign after login * sms_transactional - Redirect to Sms Transactional after login 
        /// </summary>
        /// <value>Set target after login success * automation - Redirect to Automation after login * email_campaign - Redirect to Email Campaign after login * contacts - Redirect to Contacts after login * landing_pages - Redirect to Landing Pages after login * email_transactional - Redirect to Email Transactional after login * senders - Redirect to Contacts after login * sms_campaign - Redirect to Sms Campaign after login * sms_transactional - Redirect to Sms Transactional after login </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetEnum
        {
            
            /// <summary>
            /// Enum Automation for value: automation
            /// </summary>
            [EnumMember(Value = "automation")]
            Automation = 1,
            
            /// <summary>
            /// Enum Emailcampaign for value: email_campaign
            /// </summary>
            [EnumMember(Value = "email_campaign")]
            Emailcampaign = 2,
            
            /// <summary>
            /// Enum Contacts for value: contacts
            /// </summary>
            [EnumMember(Value = "contacts")]
            Contacts = 3,
            
            /// <summary>
            /// Enum Landingpages for value: landing_pages
            /// </summary>
            [EnumMember(Value = "landing_pages")]
            Landingpages = 4,
            
            /// <summary>
            /// Enum Emailtransactional for value: email_transactional
            /// </summary>
            [EnumMember(Value = "email_transactional")]
            Emailtransactional = 5,
            
            /// <summary>
            /// Enum Senders for value: senders
            /// </summary>
            [EnumMember(Value = "senders")]
            Senders = 6,
            
            /// <summary>
            /// Enum Smscampaign for value: sms_campaign
            /// </summary>
            [EnumMember(Value = "sms_campaign")]
            Smscampaign = 7,
            
            /// <summary>
            /// Enum Smstransactional for value: sms_transactional
            /// </summary>
            [EnumMember(Value = "sms_transactional")]
            Smstransactional = 8
        }

        /// <summary>
        /// Set target after login success * automation - Redirect to Automation after login * email_campaign - Redirect to Email Campaign after login * contacts - Redirect to Contacts after login * landing_pages - Redirect to Landing Pages after login * email_transactional - Redirect to Email Transactional after login * senders - Redirect to Contacts after login * sms_campaign - Redirect to Sms Campaign after login * sms_transactional - Redirect to Sms Transactional after login 
        /// </summary>
        /// <value>Set target after login success * automation - Redirect to Automation after login * email_campaign - Redirect to Email Campaign after login * contacts - Redirect to Contacts after login * landing_pages - Redirect to Landing Pages after login * email_transactional - Redirect to Email Transactional after login * senders - Redirect to Contacts after login * sms_campaign - Redirect to Sms Campaign after login * sms_transactional - Redirect to Sms Transactional after login </value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public TargetEnum? Target { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoTokenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SsoTokenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoTokenRequest" /> class.
        /// </summary>
        /// <param name="id">Id of the sub-account organization (required).</param>
        /// <param name="email">User email of sub-account organization.</param>
        /// <param name="target">Set target after login success * automation - Redirect to Automation after login * email_campaign - Redirect to Email Campaign after login * contacts - Redirect to Contacts after login * landing_pages - Redirect to Landing Pages after login * email_transactional - Redirect to Email Transactional after login * senders - Redirect to Contacts after login * sms_campaign - Redirect to Sms Campaign after login * sms_transactional - Redirect to Sms Transactional after login .</param>
        /// <param name="url">Set the full target URL after login success. The user will land directly on this target URL after login.</param>
        public SsoTokenRequest(long? id = default(long?), string email = default(string), TargetEnum? target = default(TargetEnum?), string url = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SsoTokenRequest and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            this.Email = email;
            this.Target = target;
            this.Url = url;
        }
        
        /// <summary>
        /// Id of the sub-account organization
        /// </summary>
        /// <value>Id of the sub-account organization</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// User email of sub-account organization
        /// </summary>
        /// <value>User email of sub-account organization</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }


        /// <summary>
        /// Set the full target URL after login success. The user will land directly on this target URL after login
        /// </summary>
        /// <value>Set the full target URL after login success. The user will land directly on this target URL after login</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SsoTokenRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as SsoTokenRequest);
        }

        /// <summary>
        /// Returns true if SsoTokenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SsoTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SsoTokenRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}
