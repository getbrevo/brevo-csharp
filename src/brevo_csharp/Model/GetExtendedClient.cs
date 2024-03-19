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
    /// GetExtendedClient
    /// </summary>
    [DataContract]
    public partial class GetExtendedClient :  IEquatable<GetExtendedClient>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedClient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetExtendedClient() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedClient" /> class.
        /// </summary>
        /// <param name="email">Login Email (required).</param>
        /// <param name="firstName">First Name (required).</param>
        /// <param name="lastName">Last Name (required).</param>
        /// <param name="companyName">Name of the company (required).</param>
        /// <param name="address">address (required).</param>
        public GetExtendedClient(string email = default(string), string firstName = default(string), string lastName = default(string), string companyName = default(string), GetExtendedClientAddress address = default(GetExtendedClientAddress))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for GetExtendedClient and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for GetExtendedClient and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for GetExtendedClient and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }
            // to ensure "companyName" is required (not null)
            if (companyName == null)
            {
                throw new InvalidDataException("companyName is a required property for GetExtendedClient and cannot be null");
            }
            else
            {
                this.CompanyName = companyName;
            }
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for GetExtendedClient and cannot be null");
            }
            else
            {
                this.Address = address;
            }
        }
        
        /// <summary>
        /// Login Email
        /// </summary>
        /// <value>Login Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        /// <value>First Name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        /// <value>Last Name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Name of the company
        /// </summary>
        /// <value>Name of the company</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public GetExtendedClientAddress Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExtendedClient {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as GetExtendedClient);
        }

        /// <summary>
        /// Returns true if GetExtendedClient instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExtendedClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExtendedClient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                return hashCode;
            }
        }
    }

}
