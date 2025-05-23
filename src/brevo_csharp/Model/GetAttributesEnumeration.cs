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
    /// GetAttributesEnumeration
    /// </summary>
    [DataContract]
    public partial class GetAttributesEnumeration :  IEquatable<GetAttributesEnumeration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttributesEnumeration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAttributesEnumeration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttributesEnumeration" /> class.
        /// </summary>
        /// <param name="value">ID of Value of the \&quot;category\&quot; type attribute (required).</param>
        /// <param name="label">Label of the \&quot;category\&quot; type attribute (required).</param>
        public GetAttributesEnumeration(long? value = default(long?), string label = default(string))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for GetAttributesEnumeration and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new InvalidDataException("label is a required property for GetAttributesEnumeration and cannot be null");
            }
            else
            {
                this.Label = label;
            }
        }
        
        /// <summary>
        /// ID of Value of the \&quot;category\&quot; type attribute
        /// </summary>
        /// <value>ID of Value of the \&quot;category\&quot; type attribute</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public long? Value { get; set; }

        /// <summary>
        /// Label of the \&quot;category\&quot; type attribute
        /// </summary>
        /// <value>Label of the \&quot;category\&quot; type attribute</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAttributesEnumeration {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(input as GetAttributesEnumeration);
        }

        /// <summary>
        /// Returns true if GetAttributesEnumeration instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAttributesEnumeration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAttributesEnumeration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                return hashCode;
            }
        }
    }

}
