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
    /// GetProcesses
    /// </summary>
    [DataContract]
    public partial class GetProcesses :  IEquatable<GetProcesses>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProcesses" /> class.
        /// </summary>
        /// <param name="processes">List of processes available on your account.</param>
        /// <param name="count">Number of processes available on your account.</param>
        public GetProcesses(List<GetProcess> processes = default(List<GetProcess>), long? count = default(long?))
        {
            this.Processes = processes;
            this.Count = count;
        }
        
        /// <summary>
        /// List of processes available on your account
        /// </summary>
        /// <value>List of processes available on your account</value>
        [DataMember(Name="processes", EmitDefaultValue=false)]
        public List<GetProcess> Processes { get; set; }

        /// <summary>
        /// Number of processes available on your account
        /// </summary>
        /// <value>Number of processes available on your account</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProcesses {\n");
            sb.Append("  Processes: ").Append(Processes).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as GetProcesses);
        }

        /// <summary>
        /// Returns true if GetProcesses instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProcesses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProcesses input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Processes == input.Processes ||
                    this.Processes != null &&
                    this.Processes.SequenceEqual(input.Processes)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Processes != null)
                    hashCode = hashCode * 59 + this.Processes.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }

}
