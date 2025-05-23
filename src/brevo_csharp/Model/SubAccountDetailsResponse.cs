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
    /// SubAccountDetailsResponse
    /// </summary>
    [DataContract]
    public partial class SubAccountDetailsResponse :  IEquatable<SubAccountDetailsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccountDetailsResponse" /> class.
        /// </summary>
        /// <param name="name">Name of the sub-account user.</param>
        /// <param name="email">Email id of the sub-account organization.</param>
        /// <param name="companyName">Sub-account company name.</param>
        /// <param name="groups">List of group(s) associated with the sub-account.</param>
        /// <param name="planInfo">planInfo.</param>
        public SubAccountDetailsResponse(string name = default(string), string email = default(string), string companyName = default(string), List<SubAccountDetailsResponseGroups> groups = default(List<SubAccountDetailsResponseGroups>), SubAccountDetailsResponsePlanInfo planInfo = default(SubAccountDetailsResponsePlanInfo))
        {
            this.Name = name;
            this.Email = email;
            this.CompanyName = companyName;
            this.Groups = groups;
            this.PlanInfo = planInfo;
        }
        
        /// <summary>
        /// Name of the sub-account user
        /// </summary>
        /// <value>Name of the sub-account user</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Email id of the sub-account organization
        /// </summary>
        /// <value>Email id of the sub-account organization</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Sub-account company name
        /// </summary>
        /// <value>Sub-account company name</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// List of group(s) associated with the sub-account
        /// </summary>
        /// <value>List of group(s) associated with the sub-account</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<SubAccountDetailsResponseGroups> Groups { get; set; }

        /// <summary>
        /// Gets or Sets PlanInfo
        /// </summary>
        [DataMember(Name="planInfo", EmitDefaultValue=false)]
        public SubAccountDetailsResponsePlanInfo PlanInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubAccountDetailsResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  PlanInfo: ").Append(PlanInfo).Append("\n");
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
            return this.Equals(input as SubAccountDetailsResponse);
        }

        /// <summary>
        /// Returns true if SubAccountDetailsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SubAccountDetailsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubAccountDetailsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.PlanInfo == input.PlanInfo ||
                    (this.PlanInfo != null &&
                    this.PlanInfo.Equals(input.PlanInfo))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.PlanInfo != null)
                    hashCode = hashCode * 59 + this.PlanInfo.GetHashCode();
                return hashCode;
            }
        }
    }

}
