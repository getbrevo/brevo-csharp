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
    /// Custom attributes for the report email.
    /// </summary>
    [DataContract]
    public partial class SendReportEmail :  IEquatable<SendReportEmail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendReportEmail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendReportEmail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendReportEmail" /> class.
        /// </summary>
        /// <param name="to">Email addresses of the recipients (required).</param>
        /// <param name="body">Custom text message to be presented in the report email. (required).</param>
        public SendReportEmail(List<string> to = default(List<string>), string body = default(string))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for SendReportEmail and cannot be null");
            }
            else
            {
                this.To = to;
            }
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for SendReportEmail and cannot be null");
            }
            else
            {
                this.Body = body;
            }
        }
        
        /// <summary>
        /// Email addresses of the recipients
        /// </summary>
        /// <value>Email addresses of the recipients</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<string> To { get; set; }

        /// <summary>
        /// Custom text message to be presented in the report email.
        /// </summary>
        /// <value>Custom text message to be presented in the report email.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendReportEmail {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(input as SendReportEmail);
        }

        /// <summary>
        /// Returns true if SendReportEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of SendReportEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendReportEmail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.To == input.To ||
                    this.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }

}
