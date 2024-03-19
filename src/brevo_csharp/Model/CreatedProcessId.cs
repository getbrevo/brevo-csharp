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
    /// CreatedProcessId
    /// </summary>
    [DataContract]
    public partial class CreatedProcessId :  IEquatable<CreatedProcessId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedProcessId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatedProcessId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedProcessId" /> class.
        /// </summary>
        /// <param name="processId">Id of the process created (required).</param>
        public CreatedProcessId(long? processId = default(long?))
        {
            // to ensure "processId" is required (not null)
            if (processId == null)
            {
                throw new InvalidDataException("processId is a required property for CreatedProcessId and cannot be null");
            }
            else
            {
                this.ProcessId = processId;
            }
        }
        
        /// <summary>
        /// Id of the process created
        /// </summary>
        /// <value>Id of the process created</value>
        [DataMember(Name="processId", EmitDefaultValue=false)]
        public long? ProcessId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatedProcessId {\n");
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
            return this.Equals(input as CreatedProcessId);
        }

        /// <summary>
        /// Returns true if CreatedProcessId instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatedProcessId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatedProcessId input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                return hashCode;
            }
        }
    }

}
