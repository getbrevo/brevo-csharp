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
    /// UpdateList
    /// </summary>
    [DataContract]
    public partial class UpdateList :  IEquatable<UpdateList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateList" /> class.
        /// </summary>
        /// <param name="name">Name of the list. Either of the two parameters (name, folderId) can be updated at a time..</param>
        /// <param name="folderId">Id of the folder in which the list is to be moved. Either of the two parameters (name, folderId) can be updated at a time..</param>
        public UpdateList(string name = default(string), long? folderId = default(long?))
        {
            this.Name = name;
            this.FolderId = folderId;
        }
        
        /// <summary>
        /// Name of the list. Either of the two parameters (name, folderId) can be updated at a time.
        /// </summary>
        /// <value>Name of the list. Either of the two parameters (name, folderId) can be updated at a time.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Id of the folder in which the list is to be moved. Either of the two parameters (name, folderId) can be updated at a time.
        /// </summary>
        /// <value>Id of the folder in which the list is to be moved. Either of the two parameters (name, folderId) can be updated at a time.</value>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public long? FolderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateList {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
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
            return this.Equals(input as UpdateList);
        }

        /// <summary>
        /// Returns true if UpdateList instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateList input)
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
                    this.FolderId == input.FolderId ||
                    (this.FolderId != null &&
                    this.FolderId.Equals(input.FolderId))
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
                if (this.FolderId != null)
                    hashCode = hashCode * 59 + this.FolderId.GetHashCode();
                return hashCode;
            }
        }
    }

}
