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
    /// MainFilter
    /// </summary>
    [DataContract]
    public partial class MainFilter :  IEquatable<MainFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MainFilter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MainFilter" /> class.
        /// </summary>
        /// <param name="metadataKey">Metadata key (required).</param>
        /// <param name="metadataValue">Metadata value (required).</param>
        public MainFilter(string metadataKey = default(string), Object metadataValue = default(Object))
        {
            // to ensure "metadataKey" is required (not null)
            if (metadataKey == null)
            {
                throw new InvalidDataException("metadataKey is a required property for MainFilter and cannot be null");
            }
            else
            {
                this.MetadataKey = metadataKey;
            }
            // to ensure "metadataValue" is required (not null)
            if (metadataValue == null)
            {
                throw new InvalidDataException("metadataValue is a required property for MainFilter and cannot be null");
            }
            else
            {
                this.MetadataValue = metadataValue;
            }
        }
        
        /// <summary>
        /// Metadata key
        /// </summary>
        /// <value>Metadata key</value>
        [DataMember(Name="metadata.key", EmitDefaultValue=false)]
        public string MetadataKey { get; set; }

        /// <summary>
        /// Metadata value
        /// </summary>
        /// <value>Metadata value</value>
        [DataMember(Name="metadata.value", EmitDefaultValue=false)]
        public Object MetadataValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MainFilter {\n");
            sb.Append("  MetadataKey: ").Append(MetadataKey).Append("\n");
            sb.Append("  MetadataValue: ").Append(MetadataValue).Append("\n");
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
            return this.Equals(input as MainFilter);
        }

        /// <summary>
        /// Returns true if MainFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of MainFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MainFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MetadataKey == input.MetadataKey ||
                    (this.MetadataKey != null &&
                    this.MetadataKey.Equals(input.MetadataKey))
                ) && 
                (
                    this.MetadataValue == input.MetadataValue ||
                    (this.MetadataValue != null &&
                    this.MetadataValue.Equals(input.MetadataValue))
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
                if (this.MetadataKey != null)
                    hashCode = hashCode * 59 + this.MetadataKey.GetHashCode();
                if (this.MetadataValue != null)
                    hashCode = hashCode * 59 + this.MetadataValue.GetHashCode();
                return hashCode;
            }
        }
    }

}
