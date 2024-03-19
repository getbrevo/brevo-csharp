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
    /// CreateUpdateBatchCategory
    /// </summary>
    [DataContract]
    public partial class CreateUpdateBatchCategory :  IEquatable<CreateUpdateBatchCategory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdateBatchCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUpdateBatchCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdateBatchCategory" /> class.
        /// </summary>
        /// <param name="categories">array of categories objects (required).</param>
        /// <param name="updateEnabled">Facilitate to update the existing categories in the same request (updateEnabled &#x3D; true).</param>
        public CreateUpdateBatchCategory(List<CreateUpdateCategories> categories = default(List<CreateUpdateCategories>), bool? updateEnabled = default(bool?))
        {
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new InvalidDataException("categories is a required property for CreateUpdateBatchCategory and cannot be null");
            }
            else
            {
                this.Categories = categories;
            }
            this.UpdateEnabled = updateEnabled;
        }
        
        /// <summary>
        /// array of categories objects
        /// </summary>
        /// <value>array of categories objects</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<CreateUpdateCategories> Categories { get; set; }

        /// <summary>
        /// Facilitate to update the existing categories in the same request (updateEnabled &#x3D; true)
        /// </summary>
        /// <value>Facilitate to update the existing categories in the same request (updateEnabled &#x3D; true)</value>
        [DataMember(Name="updateEnabled", EmitDefaultValue=false)]
        public bool? UpdateEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUpdateBatchCategory {\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  UpdateEnabled: ").Append(UpdateEnabled).Append("\n");
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
            return this.Equals(input as CreateUpdateBatchCategory);
        }

        /// <summary>
        /// Returns true if CreateUpdateBatchCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUpdateBatchCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUpdateBatchCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.UpdateEnabled == input.UpdateEnabled ||
                    (this.UpdateEnabled != null &&
                    this.UpdateEnabled.Equals(input.UpdateEnabled))
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
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.UpdateEnabled != null)
                    hashCode = hashCode * 59 + this.UpdateEnabled.GetHashCode();
                return hashCode;
            }
        }
    }

}
