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
    /// AbTestVersionClicksInner
    /// </summary>
    [DataContract]
    public partial class AbTestVersionClicksInner :  IEquatable<AbTestVersionClicksInner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbTestVersionClicksInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbTestVersionClicksInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbTestVersionClicksInner" /> class.
        /// </summary>
        /// <param name="link">URL of the link (required).</param>
        /// <param name="clicksCount">Number of times a link is clicked (required).</param>
        /// <param name="clickRate">Percentage of clicks of link with respect to total clicks (required).</param>
        public AbTestVersionClicksInner(string link = default(string), long? clicksCount = default(long?), string clickRate = default(string))
        {
            // to ensure "link" is required (not null)
            if (link == null)
            {
                throw new InvalidDataException("link is a required property for AbTestVersionClicksInner and cannot be null");
            }
            else
            {
                this.Link = link;
            }
            // to ensure "clicksCount" is required (not null)
            if (clicksCount == null)
            {
                throw new InvalidDataException("clicksCount is a required property for AbTestVersionClicksInner and cannot be null");
            }
            else
            {
                this.ClicksCount = clicksCount;
            }
            // to ensure "clickRate" is required (not null)
            if (clickRate == null)
            {
                throw new InvalidDataException("clickRate is a required property for AbTestVersionClicksInner and cannot be null");
            }
            else
            {
                this.ClickRate = clickRate;
            }
        }
        
        /// <summary>
        /// URL of the link
        /// </summary>
        /// <value>URL of the link</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Number of times a link is clicked
        /// </summary>
        /// <value>Number of times a link is clicked</value>
        [DataMember(Name="clicksCount", EmitDefaultValue=false)]
        public long? ClicksCount { get; set; }

        /// <summary>
        /// Percentage of clicks of link with respect to total clicks
        /// </summary>
        /// <value>Percentage of clicks of link with respect to total clicks</value>
        [DataMember(Name="clickRate", EmitDefaultValue=false)]
        public string ClickRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbTestVersionClicksInner {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  ClicksCount: ").Append(ClicksCount).Append("\n");
            sb.Append("  ClickRate: ").Append(ClickRate).Append("\n");
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
            return this.Equals(input as AbTestVersionClicksInner);
        }

        /// <summary>
        /// Returns true if AbTestVersionClicksInner instances are equal
        /// </summary>
        /// <param name="input">Instance of AbTestVersionClicksInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbTestVersionClicksInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.ClicksCount == input.ClicksCount ||
                    (this.ClicksCount != null &&
                    this.ClicksCount.Equals(input.ClicksCount))
                ) && 
                (
                    this.ClickRate == input.ClickRate ||
                    (this.ClickRate != null &&
                    this.ClickRate.Equals(input.ClickRate))
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
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.ClicksCount != null)
                    hashCode = hashCode * 59 + this.ClicksCount.GetHashCode();
                if (this.ClickRate != null)
                    hashCode = hashCode * 59 + this.ClickRate.GetHashCode();
                return hashCode;
            }
        }
    }

}
