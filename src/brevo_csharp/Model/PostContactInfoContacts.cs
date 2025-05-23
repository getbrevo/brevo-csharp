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
    /// PostContactInfoContacts
    /// </summary>
    [DataContract]
    public partial class PostContactInfoContacts :  IEquatable<PostContactInfoContacts>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostContactInfoContacts" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="failure">failure.</param>
        /// <param name="total">Displays the count of total number of contacts removed from list when user opts for \&quot;all\&quot; option..</param>
        /// <param name="processId">Id of the process created to remove contacts from list when user opts for \&quot;all\&quot; option..</param>
        public PostContactInfoContacts(List<string> success = default(List<string>), List<string> failure = default(List<string>), long? total = default(long?), long? processId = default(long?))
        {
            this.Success = success;
            this.Failure = failure;
            this.Total = total;
            this.ProcessId = processId;
        }
        
        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public List<string> Success { get; set; }

        /// <summary>
        /// Gets or Sets Failure
        /// </summary>
        [DataMember(Name="failure", EmitDefaultValue=false)]
        public List<string> Failure { get; set; }

        /// <summary>
        /// Displays the count of total number of contacts removed from list when user opts for \&quot;all\&quot; option.
        /// </summary>
        /// <value>Displays the count of total number of contacts removed from list when user opts for \&quot;all\&quot; option.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }

        /// <summary>
        /// Id of the process created to remove contacts from list when user opts for \&quot;all\&quot; option.
        /// </summary>
        /// <value>Id of the process created to remove contacts from list when user opts for \&quot;all\&quot; option.</value>
        [DataMember(Name="processId", EmitDefaultValue=false)]
        public long? ProcessId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostContactInfoContacts {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Failure: ").Append(Failure).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
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
            return this.Equals(input as PostContactInfoContacts);
        }

        /// <summary>
        /// Returns true if PostContactInfoContacts instances are equal
        /// </summary>
        /// <param name="input">Instance of PostContactInfoContacts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostContactInfoContacts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Success == input.Success ||
                    this.Success != null &&
                    this.Success.SequenceEqual(input.Success)
                ) && 
                (
                    this.Failure == input.Failure ||
                    this.Failure != null &&
                    this.Failure.SequenceEqual(input.Failure)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
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
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Failure != null)
                    hashCode = hashCode * 59 + this.Failure.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                return hashCode;
            }
        }
    }

}
