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
    /// CorporateGroupDetailsResponse
    /// </summary>
    [DataContract]
    public partial class CorporateGroupDetailsResponse :  IEquatable<CorporateGroupDetailsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporateGroupDetailsResponse" /> class.
        /// </summary>
        /// <param name="group">group.</param>
        /// <param name="subAccounts">subAccounts.</param>
        /// <param name="users">users.</param>
        public CorporateGroupDetailsResponse(CorporateGroupDetailsResponseGroup group = default(CorporateGroupDetailsResponseGroup), List<CorporateGroupDetailsResponseSubaccounts> subAccounts = default(List<CorporateGroupDetailsResponseSubaccounts>), List<CorporateGroupDetailsResponseUsers> users = default(List<CorporateGroupDetailsResponseUsers>))
        {
            this.Group = group;
            this.SubAccounts = subAccounts;
            this.Users = users;
        }
        
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public CorporateGroupDetailsResponseGroup Group { get; set; }

        /// <summary>
        /// Gets or Sets SubAccounts
        /// </summary>
        [DataMember(Name="sub-accounts", EmitDefaultValue=false)]
        public List<CorporateGroupDetailsResponseSubaccounts> SubAccounts { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<CorporateGroupDetailsResponseUsers> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorporateGroupDetailsResponse {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  SubAccounts: ").Append(SubAccounts).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as CorporateGroupDetailsResponse);
        }

        /// <summary>
        /// Returns true if CorporateGroupDetailsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CorporateGroupDetailsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorporateGroupDetailsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.SubAccounts == input.SubAccounts ||
                    this.SubAccounts != null &&
                    this.SubAccounts.SequenceEqual(input.SubAccounts)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.SubAccounts != null)
                    hashCode = hashCode * 59 + this.SubAccounts.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }
    }

}
