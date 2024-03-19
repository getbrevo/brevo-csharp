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
    /// GetWATemplatesTemplates
    /// </summary>
    [DataContract]
    public partial class GetWATemplatesTemplates :  IEquatable<GetWATemplatesTemplates>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWATemplatesTemplates" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWATemplatesTemplates() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWATemplatesTemplates" /> class.
        /// </summary>
        /// <param name="id">id of the template (required).</param>
        /// <param name="name">Name of the WhatsApp template (required).</param>
        /// <param name="status">Status of the WhatsApp template (required).</param>
        /// <param name="language">Language in which template exists (required).</param>
        /// <param name="category">category of the template (required).</param>
        /// <param name="errorReason">Error reason in the template creation.</param>
        /// <param name="createdAt">Creation UTC date-time of the whatsApp template (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="modifiedAt">UTC date-time of last modification of the whatsApp template (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        public GetWATemplatesTemplates(string id = default(string), string name = default(string), string status = default(string), string language = default(string), string category = default(string), string errorReason = default(string), string createdAt = default(string), string modifiedAt = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetWATemplatesTemplates and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetWATemplatesTemplates and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for GetWATemplatesTemplates and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new InvalidDataException("language is a required property for GetWATemplatesTemplates and cannot be null");
            }
            else
            {
                this.Language = language;
            }
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new InvalidDataException("category is a required property for GetWATemplatesTemplates and cannot be null");
            }
            else
            {
                this.Category = category;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetWATemplatesTemplates and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "modifiedAt" is required (not null)
            if (modifiedAt == null)
            {
                throw new InvalidDataException("modifiedAt is a required property for GetWATemplatesTemplates and cannot be null");
            }
            else
            {
                this.ModifiedAt = modifiedAt;
            }
            this.ErrorReason = errorReason;
        }
        
        /// <summary>
        /// id of the template
        /// </summary>
        /// <value>id of the template</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the WhatsApp template
        /// </summary>
        /// <value>Name of the WhatsApp template</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Status of the WhatsApp template
        /// </summary>
        /// <value>Status of the WhatsApp template</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Language in which template exists
        /// </summary>
        /// <value>Language in which template exists</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// category of the template
        /// </summary>
        /// <value>category of the template</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Error reason in the template creation
        /// </summary>
        /// <value>Error reason in the template creation</value>
        [DataMember(Name="errorReason", EmitDefaultValue=false)]
        public string ErrorReason { get; set; }

        /// <summary>
        /// Creation UTC date-time of the whatsApp template (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Creation UTC date-time of the whatsApp template (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// UTC date-time of last modification of the whatsApp template (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>UTC date-time of last modification of the whatsApp template (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetWATemplatesTemplates {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ErrorReason: ").Append(ErrorReason).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
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
            return this.Equals(input as GetWATemplatesTemplates);
        }

        /// <summary>
        /// Returns true if GetWATemplatesTemplates instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWATemplatesTemplates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWATemplatesTemplates input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ErrorReason == input.ErrorReason ||
                    (this.ErrorReason != null &&
                    this.ErrorReason.Equals(input.ErrorReason))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ErrorReason != null)
                    hashCode = hashCode * 59 + this.ErrorReason.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}