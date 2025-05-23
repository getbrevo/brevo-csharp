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
    /// TemplatePreview
    /// </summary>
    [DataContract]
    public partial class TemplatePreview :  IEquatable<TemplatePreview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatePreview" /> class.
        /// </summary>
        /// <param name="fromEmail">Sender email address.</param>
        /// <param name="fromName">Sender name.</param>
        /// <param name="html">Html content of the template.</param>
        /// <param name="subject">subject of the template.</param>
        /// <param name="usedFeedNames">usedFeedNames.</param>
        /// <param name="previewText">Preview text of the template.</param>
        public TemplatePreview(string fromEmail = default(string), string fromName = default(string), string html = default(string), string subject = default(string), List<string> usedFeedNames = default(List<string>), string previewText = default(string))
        {
            this.FromEmail = fromEmail;
            this.FromName = fromName;
            this.Html = html;
            this.Subject = subject;
            this.UsedFeedNames = usedFeedNames;
            this.PreviewText = previewText;
        }
        
        /// <summary>
        /// Sender email address
        /// </summary>
        /// <value>Sender email address</value>
        [DataMember(Name="fromEmail", EmitDefaultValue=false)]
        public string FromEmail { get; set; }

        /// <summary>
        /// Sender name
        /// </summary>
        /// <value>Sender name</value>
        [DataMember(Name="fromName", EmitDefaultValue=false)]
        public string FromName { get; set; }

        /// <summary>
        /// Html content of the template
        /// </summary>
        /// <value>Html content of the template</value>
        [DataMember(Name="html", EmitDefaultValue=false)]
        public string Html { get; set; }

        /// <summary>
        /// subject of the template
        /// </summary>
        /// <value>subject of the template</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets UsedFeedNames
        /// </summary>
        [DataMember(Name="usedFeedNames", EmitDefaultValue=false)]
        public List<string> UsedFeedNames { get; set; }

        /// <summary>
        /// Preview text of the template
        /// </summary>
        /// <value>Preview text of the template</value>
        [DataMember(Name="previewText", EmitDefaultValue=false)]
        public string PreviewText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplatePreview {\n");
            sb.Append("  FromEmail: ").Append(FromEmail).Append("\n");
            sb.Append("  FromName: ").Append(FromName).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  UsedFeedNames: ").Append(UsedFeedNames).Append("\n");
            sb.Append("  PreviewText: ").Append(PreviewText).Append("\n");
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
            return this.Equals(input as TemplatePreview);
        }

        /// <summary>
        /// Returns true if TemplatePreview instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplatePreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplatePreview input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FromEmail == input.FromEmail ||
                    (this.FromEmail != null &&
                    this.FromEmail.Equals(input.FromEmail))
                ) && 
                (
                    this.FromName == input.FromName ||
                    (this.FromName != null &&
                    this.FromName.Equals(input.FromName))
                ) && 
                (
                    this.Html == input.Html ||
                    (this.Html != null &&
                    this.Html.Equals(input.Html))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.UsedFeedNames == input.UsedFeedNames ||
                    this.UsedFeedNames != null &&
                    this.UsedFeedNames.SequenceEqual(input.UsedFeedNames)
                ) && 
                (
                    this.PreviewText == input.PreviewText ||
                    (this.PreviewText != null &&
                    this.PreviewText.Equals(input.PreviewText))
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
                if (this.FromEmail != null)
                    hashCode = hashCode * 59 + this.FromEmail.GetHashCode();
                if (this.FromName != null)
                    hashCode = hashCode * 59 + this.FromName.GetHashCode();
                if (this.Html != null)
                    hashCode = hashCode * 59 + this.Html.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.UsedFeedNames != null)
                    hashCode = hashCode * 59 + this.UsedFeedNames.GetHashCode();
                if (this.PreviewText != null)
                    hashCode = hashCode * 59 + this.PreviewText.GetHashCode();
                return hashCode;
            }
        }
    }

}
