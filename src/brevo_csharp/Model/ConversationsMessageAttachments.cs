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
    /// ConversationsMessageAttachments
    /// </summary>
    [DataContract]
    public partial class ConversationsMessageAttachments :  IEquatable<ConversationsMessageAttachments>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsMessageAttachments" /> class.
        /// </summary>
        /// <param name="fileName">The name of the file..</param>
        /// <param name="isInline">&#x60;true&#x60; for inline files..</param>
        /// <param name="inlineId">The ID of the inline file..</param>
        /// <param name="url">The URL of the file..</param>
        /// <param name="isImage">&#x60;true&#x60; for images..</param>
        /// <param name="size">The size of the file in bytes..</param>
        public ConversationsMessageAttachments(string fileName = default(string), string isInline = default(string), string inlineId = default(string), string url = default(string), bool? isImage = default(bool?), long? size = default(long?))
        {
            this.FileName = fileName;
            this.IsInline = isInline;
            this.InlineId = inlineId;
            this.Url = url;
            this.IsImage = isImage;
            this.Size = size;
        }
        
        /// <summary>
        /// The name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// &#x60;true&#x60; for inline files.
        /// </summary>
        /// <value>&#x60;true&#x60; for inline files.</value>
        [DataMember(Name="isInline", EmitDefaultValue=false)]
        public string IsInline { get; set; }

        /// <summary>
        /// The ID of the inline file.
        /// </summary>
        /// <value>The ID of the inline file.</value>
        [DataMember(Name="inlineId", EmitDefaultValue=false)]
        public string InlineId { get; set; }

        /// <summary>
        /// The URL of the file.
        /// </summary>
        /// <value>The URL of the file.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// &#x60;true&#x60; for images.
        /// </summary>
        /// <value>&#x60;true&#x60; for images.</value>
        [DataMember(Name="isImage", EmitDefaultValue=false)]
        public bool? IsImage { get; set; }

        /// <summary>
        /// The size of the file in bytes.
        /// </summary>
        /// <value>The size of the file in bytes.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationsMessageAttachments {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  IsInline: ").Append(IsInline).Append("\n");
            sb.Append("  InlineId: ").Append(InlineId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IsImage: ").Append(IsImage).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as ConversationsMessageAttachments);
        }

        /// <summary>
        /// Returns true if ConversationsMessageAttachments instances are equal
        /// </summary>
        /// <param name="input">Instance of ConversationsMessageAttachments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationsMessageAttachments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.IsInline == input.IsInline ||
                    (this.IsInline != null &&
                    this.IsInline.Equals(input.IsInline))
                ) && 
                (
                    this.InlineId == input.InlineId ||
                    (this.InlineId != null &&
                    this.InlineId.Equals(input.InlineId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.IsImage == input.IsImage ||
                    (this.IsImage != null &&
                    this.IsImage.Equals(input.IsImage))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.IsInline != null)
                    hashCode = hashCode * 59 + this.IsInline.GetHashCode();
                if (this.InlineId != null)
                    hashCode = hashCode * 59 + this.InlineId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.IsImage != null)
                    hashCode = hashCode * 59 + this.IsImage.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }

}
