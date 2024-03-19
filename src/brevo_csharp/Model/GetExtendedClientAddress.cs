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
    /// Address informations
    /// </summary>
    [DataContract]
    public partial class GetExtendedClientAddress :  IEquatable<GetExtendedClientAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedClientAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetExtendedClientAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedClientAddress" /> class.
        /// </summary>
        /// <param name="street">Street information (required).</param>
        /// <param name="city">City information (required).</param>
        /// <param name="zipCode">Zip Code information (required).</param>
        /// <param name="country">Country information (required).</param>
        public GetExtendedClientAddress(string street = default(string), string city = default(string), string zipCode = default(string), string country = default(string))
        {
            // to ensure "street" is required (not null)
            if (street == null)
            {
                throw new InvalidDataException("street is a required property for GetExtendedClientAddress and cannot be null");
            }
            else
            {
                this.Street = street;
            }
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new InvalidDataException("city is a required property for GetExtendedClientAddress and cannot be null");
            }
            else
            {
                this.City = city;
            }
            // to ensure "zipCode" is required (not null)
            if (zipCode == null)
            {
                throw new InvalidDataException("zipCode is a required property for GetExtendedClientAddress and cannot be null");
            }
            else
            {
                this.ZipCode = zipCode;
            }
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for GetExtendedClientAddress and cannot be null");
            }
            else
            {
                this.Country = country;
            }
        }
        
        /// <summary>
        /// Street information
        /// </summary>
        /// <value>Street information</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// City information
        /// </summary>
        /// <value>City information</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Zip Code information
        /// </summary>
        /// <value>Zip Code information</value>
        [DataMember(Name="zipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Country information
        /// </summary>
        /// <value>Country information</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExtendedClientAddress {\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as GetExtendedClientAddress);
        }

        /// <summary>
        /// Returns true if GetExtendedClientAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExtendedClientAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExtendedClientAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.ZipCode != null)
                    hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                return hashCode;
            }
        }
    }

}
