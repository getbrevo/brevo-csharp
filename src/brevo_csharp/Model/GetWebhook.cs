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
    /// GetWebhook
    /// </summary>
    [DataContract]
    public partial class GetWebhook :  IEquatable<GetWebhook>
    {
        /// <summary>
        /// Type of webhook (marketing or transactional)
        /// </summary>
        /// <value>Type of webhook (marketing or transactional)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Marketing for value: marketing
            /// </summary>
            [EnumMember(Value = "marketing")]
            Marketing = 1,
            
            /// <summary>
            /// Enum Transactional for value: transactional
            /// </summary>
            [EnumMember(Value = "transactional")]
            Transactional = 2
        }

        /// <summary>
        /// Type of webhook (marketing or transactional)
        /// </summary>
        /// <value>Type of webhook (marketing or transactional)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWebhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhook" /> class.
        /// </summary>
        /// <param name="url">URL of the webhook (required).</param>
        /// <param name="id">ID of the webhook (required).</param>
        /// <param name="description">Description of the webhook (required).</param>
        /// <param name="events">events (required).</param>
        /// <param name="type">Type of webhook (marketing or transactional) (required).</param>
        /// <param name="createdAt">Creation UTC date-time of the webhook (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="modifiedAt">Last modification UTC date-time of the webhook (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="batched">To send batched webhooks.</param>
        /// <param name="auth">auth.</param>
        /// <param name="headers">Custom headers to be send with webhooks.</param>
        public GetWebhook(string url = default(string), long? id = default(long?), string description = default(string), List<string> events = default(List<string>), TypeEnum type = default(TypeEnum), string createdAt = default(string), string modifiedAt = default(string), bool? batched = default(bool?), GetWebhookAuth auth = default(GetWebhookAuth), List<GetWebhookHeaders> headers = default(List<GetWebhookHeaders>))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for GetWebhook and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetWebhook and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for GetWebhook and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new InvalidDataException("events is a required property for GetWebhook and cannot be null");
            }
            else
            {
                this.Events = events;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GetWebhook and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetWebhook and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "modifiedAt" is required (not null)
            if (modifiedAt == null)
            {
                throw new InvalidDataException("modifiedAt is a required property for GetWebhook and cannot be null");
            }
            else
            {
                this.ModifiedAt = modifiedAt;
            }
            this.Batched = batched;
            this.Auth = auth;
            this.Headers = headers;
        }
        
        /// <summary>
        /// URL of the webhook
        /// </summary>
        /// <value>URL of the webhook</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// ID of the webhook
        /// </summary>
        /// <value>ID of the webhook</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Description of the webhook
        /// </summary>
        /// <value>Description of the webhook</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<string> Events { get; set; }


        /// <summary>
        /// Creation UTC date-time of the webhook (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Creation UTC date-time of the webhook (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Last modification UTC date-time of the webhook (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Last modification UTC date-time of the webhook (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// To send batched webhooks
        /// </summary>
        /// <value>To send batched webhooks</value>
        [DataMember(Name="batched", EmitDefaultValue=false)]
        public bool? Batched { get; set; }

        /// <summary>
        /// Gets or Sets Auth
        /// </summary>
        [DataMember(Name="auth", EmitDefaultValue=false)]
        public GetWebhookAuth Auth { get; set; }

        /// <summary>
        /// Custom headers to be send with webhooks
        /// </summary>
        /// <value>Custom headers to be send with webhooks</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public List<GetWebhookHeaders> Headers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetWebhook {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  Batched: ").Append(Batched).Append("\n");
            sb.Append("  Auth: ").Append(Auth).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
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
            return this.Equals(input as GetWebhook);
        }

        /// <summary>
        /// Returns true if GetWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWebhook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                ) && 
                (
                    this.Batched == input.Batched ||
                    (this.Batched != null &&
                    this.Batched.Equals(input.Batched))
                ) && 
                (
                    this.Auth == input.Auth ||
                    (this.Auth != null &&
                    this.Auth.Equals(input.Auth))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.Batched != null)
                    hashCode = hashCode * 59 + this.Batched.GetHashCode();
                if (this.Auth != null)
                    hashCode = hashCode * 59 + this.Auth.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                return hashCode;
            }
        }
    }

}
