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
    /// CreateWhatsAppTemplate
    /// </summary>
    [DataContract]
    public partial class CreateWhatsAppTemplate :  IEquatable<CreateWhatsAppTemplate>
    {
        /// <summary>
        /// Category of the template
        /// </summary>
        /// <value>Category of the template</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            
            /// <summary>
            /// Enum MARKETING for value: MARKETING
            /// </summary>
            [EnumMember(Value = "MARKETING")]
            MARKETING = 1,
            
            /// <summary>
            /// Enum UTILITY for value: UTILITY
            /// </summary>
            [EnumMember(Value = "UTILITY")]
            UTILITY = 2
        }

        /// <summary>
        /// Category of the template
        /// </summary>
        /// <value>Category of the template</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// source of the template
        /// </summary>
        /// <value>source of the template</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            
            /// <summary>
            /// Enum Automation for value: Automation
            /// </summary>
            [EnumMember(Value = "Automation")]
            Automation = 1,
            
            /// <summary>
            /// Enum Conversations for value: Conversations
            /// </summary>
            [EnumMember(Value = "Conversations")]
            Conversations = 2
        }

        /// <summary>
        /// source of the template
        /// </summary>
        /// <value>source of the template</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWhatsAppTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWhatsAppTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWhatsAppTemplate" /> class.
        /// </summary>
        /// <param name="name">Name of the template (required).</param>
        /// <param name="language">Language of the template. For Example : **en** for English  (required).</param>
        /// <param name="category">Category of the template (required).</param>
        /// <param name="mediaUrl">Absolute url of the media file **(no local file)** for the header. **Use this field in you want to add media in Template header and headerText is empty.** Allowed extensions for media files are: #### jpeg | png | mp4 | pdf .</param>
        /// <param name="bodyText">Body of the template. **Maximum allowed characters are 1024** (required).</param>
        /// <param name="headerText">Text content of the header in the template.  **Maximum allowed characters are 45** **Use this field to add text content in template header and if mediaUrl is empty** .</param>
        /// <param name="source">source of the template.</param>
        public CreateWhatsAppTemplate(string name = default(string), string language = default(string), CategoryEnum category = default(CategoryEnum), string mediaUrl = default(string), string bodyText = default(string), string headerText = default(string), SourceEnum? source = default(SourceEnum?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateWhatsAppTemplate and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new InvalidDataException("language is a required property for CreateWhatsAppTemplate and cannot be null");
            }
            else
            {
                this.Language = language;
            }
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new InvalidDataException("category is a required property for CreateWhatsAppTemplate and cannot be null");
            }
            else
            {
                this.Category = category;
            }
            // to ensure "bodyText" is required (not null)
            if (bodyText == null)
            {
                throw new InvalidDataException("bodyText is a required property for CreateWhatsAppTemplate and cannot be null");
            }
            else
            {
                this.BodyText = bodyText;
            }
            this.MediaUrl = mediaUrl;
            this.HeaderText = headerText;
            this.Source = source;
        }
        
        /// <summary>
        /// Name of the template
        /// </summary>
        /// <value>Name of the template</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Language of the template. For Example : **en** for English 
        /// </summary>
        /// <value>Language of the template. For Example : **en** for English </value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }


        /// <summary>
        /// Absolute url of the media file **(no local file)** for the header. **Use this field in you want to add media in Template header and headerText is empty.** Allowed extensions for media files are: #### jpeg | png | mp4 | pdf 
        /// </summary>
        /// <value>Absolute url of the media file **(no local file)** for the header. **Use this field in you want to add media in Template header and headerText is empty.** Allowed extensions for media files are: #### jpeg | png | mp4 | pdf </value>
        [DataMember(Name="mediaUrl", EmitDefaultValue=false)]
        public string MediaUrl { get; set; }

        /// <summary>
        /// Body of the template. **Maximum allowed characters are 1024**
        /// </summary>
        /// <value>Body of the template. **Maximum allowed characters are 1024**</value>
        [DataMember(Name="bodyText", EmitDefaultValue=false)]
        public string BodyText { get; set; }

        /// <summary>
        /// Text content of the header in the template.  **Maximum allowed characters are 45** **Use this field to add text content in template header and if mediaUrl is empty** 
        /// </summary>
        /// <value>Text content of the header in the template.  **Maximum allowed characters are 45** **Use this field to add text content in template header and if mediaUrl is empty** </value>
        [DataMember(Name="headerText", EmitDefaultValue=false)]
        public string HeaderText { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWhatsAppTemplate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  MediaUrl: ").Append(MediaUrl).Append("\n");
            sb.Append("  BodyText: ").Append(BodyText).Append("\n");
            sb.Append("  HeaderText: ").Append(HeaderText).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as CreateWhatsAppTemplate);
        }

        /// <summary>
        /// Returns true if CreateWhatsAppTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWhatsAppTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWhatsAppTemplate input)
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
                    this.MediaUrl == input.MediaUrl ||
                    (this.MediaUrl != null &&
                    this.MediaUrl.Equals(input.MediaUrl))
                ) && 
                (
                    this.BodyText == input.BodyText ||
                    (this.BodyText != null &&
                    this.BodyText.Equals(input.BodyText))
                ) && 
                (
                    this.HeaderText == input.HeaderText ||
                    (this.HeaderText != null &&
                    this.HeaderText.Equals(input.HeaderText))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.MediaUrl != null)
                    hashCode = hashCode * 59 + this.MediaUrl.GetHashCode();
                if (this.BodyText != null)
                    hashCode = hashCode * 59 + this.BodyText.GetHashCode();
                if (this.HeaderText != null)
                    hashCode = hashCode * 59 + this.HeaderText.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }
    }

}
