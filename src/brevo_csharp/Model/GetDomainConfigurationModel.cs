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
    /// GetDomainConfigurationModel
    /// </summary>
    [DataContract]
    public partial class GetDomainConfigurationModel :  IEquatable<GetDomainConfigurationModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainConfigurationModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDomainConfigurationModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDomainConfigurationModel" /> class.
        /// </summary>
        /// <param name="domain">Domain (required).</param>
        /// <param name="verified">Status of domain verification (true&#x3D;verified, false&#x3D;non verified) (required).</param>
        /// <param name="authenticated">Status of domain authentication (true&#x3D;authenticated, false&#x3D;non authenticated) (required).</param>
        /// <param name="dnsRecords">dnsRecords (required).</param>
        public GetDomainConfigurationModel(string domain = default(string), bool? verified = default(bool?), bool? authenticated = default(bool?), CreateDomainModelDnsRecords dnsRecords = default(CreateDomainModelDnsRecords))
        {
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new InvalidDataException("domain is a required property for GetDomainConfigurationModel and cannot be null");
            }
            else
            {
                this.Domain = domain;
            }
            // to ensure "verified" is required (not null)
            if (verified == null)
            {
                throw new InvalidDataException("verified is a required property for GetDomainConfigurationModel and cannot be null");
            }
            else
            {
                this.Verified = verified;
            }
            // to ensure "authenticated" is required (not null)
            if (authenticated == null)
            {
                throw new InvalidDataException("authenticated is a required property for GetDomainConfigurationModel and cannot be null");
            }
            else
            {
                this.Authenticated = authenticated;
            }
            // to ensure "dnsRecords" is required (not null)
            if (dnsRecords == null)
            {
                throw new InvalidDataException("dnsRecords is a required property for GetDomainConfigurationModel and cannot be null");
            }
            else
            {
                this.DnsRecords = dnsRecords;
            }
        }
        
        /// <summary>
        /// Domain
        /// </summary>
        /// <value>Domain</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Status of domain verification (true&#x3D;verified, false&#x3D;non verified)
        /// </summary>
        /// <value>Status of domain verification (true&#x3D;verified, false&#x3D;non verified)</value>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public bool? Verified { get; set; }

        /// <summary>
        /// Status of domain authentication (true&#x3D;authenticated, false&#x3D;non authenticated)
        /// </summary>
        /// <value>Status of domain authentication (true&#x3D;authenticated, false&#x3D;non authenticated)</value>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }

        /// <summary>
        /// Gets or Sets DnsRecords
        /// </summary>
        [DataMember(Name="dns_records", EmitDefaultValue=false)]
        public CreateDomainModelDnsRecords DnsRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDomainConfigurationModel {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
            sb.Append("  DnsRecords: ").Append(DnsRecords).Append("\n");
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
            return this.Equals(input as GetDomainConfigurationModel);
        }

        /// <summary>
        /// Returns true if GetDomainConfigurationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDomainConfigurationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDomainConfigurationModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Verified == input.Verified ||
                    (this.Verified != null &&
                    this.Verified.Equals(input.Verified))
                ) && 
                (
                    this.Authenticated == input.Authenticated ||
                    (this.Authenticated != null &&
                    this.Authenticated.Equals(input.Authenticated))
                ) && 
                (
                    this.DnsRecords == input.DnsRecords ||
                    (this.DnsRecords != null &&
                    this.DnsRecords.Equals(input.DnsRecords))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Verified != null)
                    hashCode = hashCode * 59 + this.Verified.GetHashCode();
                if (this.Authenticated != null)
                    hashCode = hashCode * 59 + this.Authenticated.GetHashCode();
                if (this.DnsRecords != null)
                    hashCode = hashCode * 59 + this.DnsRecords.GetHashCode();
                return hashCode;
            }
        }
    }

}
