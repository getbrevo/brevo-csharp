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
    /// UploadImageToGallery
    /// </summary>
    [DataContract]
    public partial class UploadImageToGallery :  IEquatable<UploadImageToGallery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageToGallery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UploadImageToGallery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageToGallery" /> class.
        /// </summary>
        /// <param name="imageUrl">The absolute url of the image (no local file). Maximum allowed size for image is 2MB. Allowed extensions for images are - jpeg, jpg, png, bmp, gif. (required).</param>
        /// <param name="name">Name of the image..</param>
        public UploadImageToGallery(string imageUrl = default(string), string name = default(string))
        {
            // to ensure "imageUrl" is required (not null)
            if (imageUrl == null)
            {
                throw new InvalidDataException("imageUrl is a required property for UploadImageToGallery and cannot be null");
            }
            else
            {
                this.ImageUrl = imageUrl;
            }
            this.Name = name;
        }
        
        /// <summary>
        /// The absolute url of the image (no local file). Maximum allowed size for image is 2MB. Allowed extensions for images are - jpeg, jpg, png, bmp, gif.
        /// </summary>
        /// <value>The absolute url of the image (no local file). Maximum allowed size for image is 2MB. Allowed extensions for images are - jpeg, jpg, png, bmp, gif.</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Name of the image.
        /// </summary>
        /// <value>Name of the image.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadImageToGallery {\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as UploadImageToGallery);
        }

        /// <summary>
        /// Returns true if UploadImageToGallery instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadImageToGallery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadImageToGallery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
