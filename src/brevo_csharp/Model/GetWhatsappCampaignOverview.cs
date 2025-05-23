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
    /// GetWhatsappCampaignOverview
    /// </summary>
    [DataContract]
    public partial class GetWhatsappCampaignOverview :  IEquatable<GetWhatsappCampaignOverview>
    {
        /// <summary>
        /// Status of the WhatsApp Campaign
        /// </summary>
        /// <value>Status of the WhatsApp Campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CampaignStatusEnum
        {
            
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1,
            
            /// <summary>
            /// Enum Scheduled for value: scheduled
            /// </summary>
            [EnumMember(Value = "scheduled")]
            Scheduled = 2,
            
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 3,
            
            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved = 4,
            
            /// <summary>
            /// Enum Running for value: running
            /// </summary>
            [EnumMember(Value = "running")]
            Running = 5,
            
            /// <summary>
            /// Enum Suspended for value: suspended
            /// </summary>
            [EnumMember(Value = "suspended")]
            Suspended = 6,
            
            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 7,
            
            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 8
        }

        /// <summary>
        /// Status of the WhatsApp Campaign
        /// </summary>
        /// <value>Status of the WhatsApp Campaign</value>
        [DataMember(Name="campaignStatus", EmitDefaultValue=false)]
        public CampaignStatusEnum CampaignStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhatsappCampaignOverview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetWhatsappCampaignOverview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhatsappCampaignOverview" /> class.
        /// </summary>
        /// <param name="id">ID of the WhatsApp Campaign (required).</param>
        /// <param name="campaignName">Name of the WhatsApp Campaign (required).</param>
        /// <param name="campaignStatus">Status of the WhatsApp Campaign (required).</param>
        /// <param name="scheduledAt">UTC date-time on which WhatsApp campaign is scheduled. Should be in YYYY-MM-DDTHH:mm:ss.SSSZ format.</param>
        /// <param name="senderNumber">Sender of the WhatsApp Campaign (required).</param>
        /// <param name="stats">stats.</param>
        /// <param name="template">template (required).</param>
        /// <param name="createdAt">Creation UTC date-time of the WhatsApp campaign (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="modifiedAt">UTC date-time of last modification of the WhatsApp campaign (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        public GetWhatsappCampaignOverview(long? id = default(long?), string campaignName = default(string), CampaignStatusEnum campaignStatus = default(CampaignStatusEnum), string scheduledAt = default(string), string senderNumber = default(string), WhatsappCampStats stats = default(WhatsappCampStats), WhatsappCampTemplate template = default(WhatsappCampTemplate), string createdAt = default(string), string modifiedAt = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetWhatsappCampaignOverview and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "campaignName" is required (not null)
            if (campaignName == null)
            {
                throw new InvalidDataException("campaignName is a required property for GetWhatsappCampaignOverview and cannot be null");
            }
            else
            {
                this.CampaignName = campaignName;
            }
            // to ensure "campaignStatus" is required (not null)
            if (campaignStatus == null)
            {
                throw new InvalidDataException("campaignStatus is a required property for GetWhatsappCampaignOverview and cannot be null");
            }
            else
            {
                this.CampaignStatus = campaignStatus;
            }
            // to ensure "senderNumber" is required (not null)
            if (senderNumber == null)
            {
                throw new InvalidDataException("senderNumber is a required property for GetWhatsappCampaignOverview and cannot be null");
            }
            else
            {
                this.SenderNumber = senderNumber;
            }
            // to ensure "template" is required (not null)
            if (template == null)
            {
                throw new InvalidDataException("template is a required property for GetWhatsappCampaignOverview and cannot be null");
            }
            else
            {
                this.Template = template;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetWhatsappCampaignOverview and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "modifiedAt" is required (not null)
            if (modifiedAt == null)
            {
                throw new InvalidDataException("modifiedAt is a required property for GetWhatsappCampaignOverview and cannot be null");
            }
            else
            {
                this.ModifiedAt = modifiedAt;
            }
            this.ScheduledAt = scheduledAt;
            this.Stats = stats;
        }
        
        /// <summary>
        /// ID of the WhatsApp Campaign
        /// </summary>
        /// <value>ID of the WhatsApp Campaign</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Name of the WhatsApp Campaign
        /// </summary>
        /// <value>Name of the WhatsApp Campaign</value>
        [DataMember(Name="campaignName", EmitDefaultValue=false)]
        public string CampaignName { get; set; }


        /// <summary>
        /// UTC date-time on which WhatsApp campaign is scheduled. Should be in YYYY-MM-DDTHH:mm:ss.SSSZ format
        /// </summary>
        /// <value>UTC date-time on which WhatsApp campaign is scheduled. Should be in YYYY-MM-DDTHH:mm:ss.SSSZ format</value>
        [DataMember(Name="scheduledAt", EmitDefaultValue=false)]
        public string ScheduledAt { get; set; }

        /// <summary>
        /// Sender of the WhatsApp Campaign
        /// </summary>
        /// <value>Sender of the WhatsApp Campaign</value>
        [DataMember(Name="senderNumber", EmitDefaultValue=false)]
        public string SenderNumber { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public WhatsappCampStats Stats { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public WhatsappCampTemplate Template { get; set; }

        /// <summary>
        /// Creation UTC date-time of the WhatsApp campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Creation UTC date-time of the WhatsApp campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// UTC date-time of last modification of the WhatsApp campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>UTC date-time of last modification of the WhatsApp campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetWhatsappCampaignOverview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CampaignName: ").Append(CampaignName).Append("\n");
            sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  SenderNumber: ").Append(SenderNumber).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(input as GetWhatsappCampaignOverview);
        }

        /// <summary>
        /// Returns true if GetWhatsappCampaignOverview instances are equal
        /// </summary>
        /// <param name="input">Instance of GetWhatsappCampaignOverview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetWhatsappCampaignOverview input)
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
                    this.CampaignName == input.CampaignName ||
                    (this.CampaignName != null &&
                    this.CampaignName.Equals(input.CampaignName))
                ) && 
                (
                    this.CampaignStatus == input.CampaignStatus ||
                    (this.CampaignStatus != null &&
                    this.CampaignStatus.Equals(input.CampaignStatus))
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.SenderNumber == input.SenderNumber ||
                    (this.SenderNumber != null &&
                    this.SenderNumber.Equals(input.SenderNumber))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                if (this.CampaignName != null)
                    hashCode = hashCode * 59 + this.CampaignName.GetHashCode();
                if (this.CampaignStatus != null)
                    hashCode = hashCode * 59 + this.CampaignStatus.GetHashCode();
                if (this.ScheduledAt != null)
                    hashCode = hashCode * 59 + this.ScheduledAt.GetHashCode();
                if (this.SenderNumber != null)
                    hashCode = hashCode * 59 + this.SenderNumber.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
