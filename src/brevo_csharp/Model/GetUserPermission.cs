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
    /// Check user permission
    /// </summary>
    [DataContract]
    public partial class GetUserPermission :  IEquatable<GetUserPermission>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserPermission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUserPermission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserPermission" /> class.
        /// </summary>
        /// <param name="email">Email address of the user. (required).</param>
        /// <param name="status">Status of the invited user. (required).</param>
        /// <param name="privileges">Granular feature permissions given to the user. (required).</param>
        public GetUserPermission(string email = default(string), string status = default(string), List<GetUserPermissionPrivileges> privileges = default(List<GetUserPermissionPrivileges>))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for GetUserPermission and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for GetUserPermission and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "privileges" is required (not null)
            if (privileges == null)
            {
                throw new InvalidDataException("privileges is a required property for GetUserPermission and cannot be null");
            }
            else
            {
                this.Privileges = privileges;
            }
        }
        
        /// <summary>
        /// Email address of the user.
        /// </summary>
        /// <value>Email address of the user.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Status of the invited user.
        /// </summary>
        /// <value>Status of the invited user.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Granular feature permissions given to the user.
        /// </summary>
        /// <value>Granular feature permissions given to the user.</value>
        [DataMember(Name="privileges", EmitDefaultValue=false)]
        public List<GetUserPermissionPrivileges> Privileges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUserPermission {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Privileges: ").Append(Privileges).Append("\n");
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
            return this.Equals(input as GetUserPermission);
        }

        /// <summary>
        /// Returns true if GetUserPermission instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUserPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUserPermission input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Privileges == input.Privileges ||
                    this.Privileges != null &&
                    this.Privileges.SequenceEqual(input.Privileges)
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Privileges != null)
                    hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                return hashCode;
            }
        }
    }

}
