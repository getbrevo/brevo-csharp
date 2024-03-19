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
    /// CreateUpdateCategory
    /// </summary>
    [DataContract]
    public partial class CreateUpdateCategory :  IEquatable<CreateUpdateCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdateCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUpdateCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdateCategory" /> class.
        /// </summary>
        /// <param name="id">Unique Category ID as saved in the shop  (required).</param>
        /// <param name="name">**Mandatory in case of creation**. Name of the Category, as displayed in the shop .</param>
        /// <param name="url">URL to the category.</param>
        /// <param name="updateEnabled">Facilitate to update the existing category in the same request (updateEnabled &#x3D; true) (default to false).</param>
        /// <param name="deletedAt">UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) of the category deleted from the shop&#39;s database.</param>
        public CreateUpdateCategory(string id = default(string), string name = default(string), string url = default(string), bool? updateEnabled = false, string deletedAt = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CreateUpdateCategory and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            this.Name = name;
            this.Url = url;
            // use default value if no "updateEnabled" provided
            if (updateEnabled == null)
            {
                this.UpdateEnabled = false;
            }
            else
            {
                this.UpdateEnabled = updateEnabled;
            }
            this.DeletedAt = deletedAt;
        }
        
        /// <summary>
        /// Unique Category ID as saved in the shop 
        /// </summary>
        /// <value>Unique Category ID as saved in the shop </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// **Mandatory in case of creation**. Name of the Category, as displayed in the shop 
        /// </summary>
        /// <value>**Mandatory in case of creation**. Name of the Category, as displayed in the shop </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// URL to the category
        /// </summary>
        /// <value>URL to the category</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Facilitate to update the existing category in the same request (updateEnabled &#x3D; true)
        /// </summary>
        /// <value>Facilitate to update the existing category in the same request (updateEnabled &#x3D; true)</value>
        [DataMember(Name="updateEnabled", EmitDefaultValue=false)]
        public bool? UpdateEnabled { get; set; }

        /// <summary>
        /// UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) of the category deleted from the shop&#39;s database
        /// </summary>
        /// <value>UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) of the category deleted from the shop&#39;s database</value>
        [DataMember(Name="deletedAt", EmitDefaultValue=false)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUpdateCategory {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UpdateEnabled: ").Append(UpdateEnabled).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
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
            return this.Equals(input as CreateUpdateCategory);
        }

        /// <summary>
        /// Returns true if CreateUpdateCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUpdateCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUpdateCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.UpdateEnabled == input.UpdateEnabled ||
                    (this.UpdateEnabled != null &&
                    this.UpdateEnabled.Equals(input.UpdateEnabled))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.UpdateEnabled != null)
                    hashCode = hashCode * 59 + this.UpdateEnabled.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
