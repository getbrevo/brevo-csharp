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
    /// AbTestCampaignResultClickedLinks
    /// </summary>
    [DataContract]
    public partial class AbTestCampaignResultClickedLinks :  IEquatable<AbTestCampaignResultClickedLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbTestCampaignResultClickedLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbTestCampaignResultClickedLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbTestCampaignResultClickedLinks" /> class.
        /// </summary>
        /// <param name="versionA">versionA (required).</param>
        /// <param name="versionB">versionB (required).</param>
        public AbTestCampaignResultClickedLinks(AbTestVersionClicks versionA = default(AbTestVersionClicks), AbTestVersionClicks versionB = default(AbTestVersionClicks))
        {
            // to ensure "versionA" is required (not null)
            if (versionA == null)
            {
                throw new InvalidDataException("versionA is a required property for AbTestCampaignResultClickedLinks and cannot be null");
            }
            else
            {
                this.VersionA = versionA;
            }
            // to ensure "versionB" is required (not null)
            if (versionB == null)
            {
                throw new InvalidDataException("versionB is a required property for AbTestCampaignResultClickedLinks and cannot be null");
            }
            else
            {
                this.VersionB = versionB;
            }
        }
        
        /// <summary>
        /// Gets or Sets VersionA
        /// </summary>
        [DataMember(Name="Version A", EmitDefaultValue=false)]
        public AbTestVersionClicks VersionA { get; set; }

        /// <summary>
        /// Gets or Sets VersionB
        /// </summary>
        [DataMember(Name="Version B", EmitDefaultValue=false)]
        public AbTestVersionClicks VersionB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbTestCampaignResultClickedLinks {\n");
            sb.Append("  VersionA: ").Append(VersionA).Append("\n");
            sb.Append("  VersionB: ").Append(VersionB).Append("\n");
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
            return this.Equals(input as AbTestCampaignResultClickedLinks);
        }

        /// <summary>
        /// Returns true if AbTestCampaignResultClickedLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of AbTestCampaignResultClickedLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbTestCampaignResultClickedLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VersionA == input.VersionA ||
                    (this.VersionA != null &&
                    this.VersionA.Equals(input.VersionA))
                ) && 
                (
                    this.VersionB == input.VersionB ||
                    (this.VersionB != null &&
                    this.VersionB.Equals(input.VersionB))
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
                if (this.VersionA != null)
                    hashCode = hashCode * 59 + this.VersionA.GetHashCode();
                if (this.VersionB != null)
                    hashCode = hashCode * 59 + this.VersionB.GetHashCode();
                return hashCode;
            }
        }
    }

}
