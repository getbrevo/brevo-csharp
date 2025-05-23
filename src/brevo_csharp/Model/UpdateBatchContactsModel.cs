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
    /// UpdateBatchContactsModel
    /// </summary>
    [DataContract]
    public partial class UpdateBatchContactsModel :  IEquatable<UpdateBatchContactsModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBatchContactsModel" /> class.
        /// </summary>
        /// <param name="successIds">successIds.</param>
        /// <param name="failureIds">failureIds.</param>
        public UpdateBatchContactsModel(List<long?> successIds = default(List<long?>), List<long?> failureIds = default(List<long?>))
        {
            this.SuccessIds = successIds;
            this.FailureIds = failureIds;
        }
        
        /// <summary>
        /// Gets or Sets SuccessIds
        /// </summary>
        [DataMember(Name="successIds", EmitDefaultValue=false)]
        public List<long?> SuccessIds { get; set; }

        /// <summary>
        /// Gets or Sets FailureIds
        /// </summary>
        [DataMember(Name="failureIds", EmitDefaultValue=false)]
        public List<long?> FailureIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBatchContactsModel {\n");
            sb.Append("  SuccessIds: ").Append(SuccessIds).Append("\n");
            sb.Append("  FailureIds: ").Append(FailureIds).Append("\n");
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
            return this.Equals(input as UpdateBatchContactsModel);
        }

        /// <summary>
        /// Returns true if UpdateBatchContactsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateBatchContactsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateBatchContactsModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SuccessIds == input.SuccessIds ||
                    this.SuccessIds != null &&
                    this.SuccessIds.SequenceEqual(input.SuccessIds)
                ) && 
                (
                    this.FailureIds == input.FailureIds ||
                    this.FailureIds != null &&
                    this.FailureIds.SequenceEqual(input.FailureIds)
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
                if (this.SuccessIds != null)
                    hashCode = hashCode * 59 + this.SuccessIds.GetHashCode();
                if (this.FailureIds != null)
                    hashCode = hashCode * 59 + this.FailureIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
