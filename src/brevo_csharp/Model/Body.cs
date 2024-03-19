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
    /// Body
    /// </summary>
    [DataContract]
    public partial class Body :  IEquatable<Body>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Body() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// </summary>
        /// <param name="groupName">The name of the group of sub-accounts (required).</param>
        /// <param name="subAccountIds">Pass the list of sub-account Ids to be included in the group.</param>
        public Body(string groupName = default(string), List<long?> subAccountIds = default(List<long?>))
        {
            // to ensure "groupName" is required (not null)
            if (groupName == null)
            {
                throw new InvalidDataException("groupName is a required property for Body and cannot be null");
            }
            else
            {
                this.GroupName = groupName;
            }
            this.SubAccountIds = subAccountIds;
        }
        
        /// <summary>
        /// The name of the group of sub-accounts
        /// </summary>
        /// <value>The name of the group of sub-accounts</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Pass the list of sub-account Ids to be included in the group
        /// </summary>
        /// <value>Pass the list of sub-account Ids to be included in the group</value>
        [DataMember(Name="subAccountIds", EmitDefaultValue=false)]
        public List<long?> SubAccountIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body {\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  SubAccountIds: ").Append(SubAccountIds).Append("\n");
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
            return this.Equals(input as Body);
        }

        /// <summary>
        /// Returns true if Body instances are equal
        /// </summary>
        /// <param name="input">Instance of Body to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.SubAccountIds == input.SubAccountIds ||
                    this.SubAccountIds != null &&
                    this.SubAccountIds.SequenceEqual(input.SubAccountIds)
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
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.SubAccountIds != null)
                    hashCode = hashCode * 59 + this.SubAccountIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
