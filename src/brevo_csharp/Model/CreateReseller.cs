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
    /// CreateReseller
    /// </summary>
    [DataContract]
    public partial class CreateReseller :  IEquatable<CreateReseller>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReseller" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateReseller() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReseller" /> class.
        /// </summary>
        /// <param name="authKey">AuthKey of Reseller child created (required).</param>
        /// <param name="id">Id of Reseller child created.</param>
        public CreateReseller(string authKey = default(string), long? id = default(long?))
        {
            // to ensure "authKey" is required (not null)
            if (authKey == null)
            {
                throw new InvalidDataException("authKey is a required property for CreateReseller and cannot be null");
            }
            else
            {
                this.AuthKey = authKey;
            }
            this.Id = id;
        }
        
        /// <summary>
        /// AuthKey of Reseller child created
        /// </summary>
        /// <value>AuthKey of Reseller child created</value>
        [DataMember(Name="authKey", EmitDefaultValue=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// Id of Reseller child created
        /// </summary>
        /// <value>Id of Reseller child created</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReseller {\n");
            sb.Append("  AuthKey: ").Append(AuthKey).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CreateReseller);
        }

        /// <summary>
        /// Returns true if CreateReseller instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateReseller to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateReseller input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthKey == input.AuthKey ||
                    (this.AuthKey != null &&
                    this.AuthKey.Equals(input.AuthKey))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.AuthKey != null)
                    hashCode = hashCode * 59 + this.AuthKey.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }

}
