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
    /// SubscriptionAttributedReward
    /// </summary>
    [DataContract]
    public partial class SubscriptionAttributedReward :  IEquatable<SubscriptionAttributedReward>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAttributedReward" /> class.
        /// </summary>
        /// <param name="code">Reward code assigned to the contact..</param>
        /// <param name="contactId">Unique identifier of the contact..</param>
        /// <param name="createdAt">Timestamp when the reward was created..</param>
        /// <param name="expirationDate">Expiration date of the reward..</param>
        /// <param name="id">Unique identifier of the reward..</param>
        /// <param name="loyaltyProgramId">Unique identifier of the loyalty program..</param>
        /// <param name="meta">Additional metadata related to the reward..</param>
        /// <param name="rewardId">Unique identifier of the reward definition..</param>
        /// <param name="updatedAt">Timestamp when the reward was last updated..</param>
        public SubscriptionAttributedReward(string code = default(string), int? contactId = default(int?), string createdAt = default(string), string expirationDate = default(string), string id = default(string), string loyaltyProgramId = default(string), Dictionary<string, Object> meta = default(Dictionary<string, Object>), string rewardId = default(string), string updatedAt = default(string))
        {
            this.Code = code;
            this.ContactId = contactId;
            this.CreatedAt = createdAt;
            this.ExpirationDate = expirationDate;
            this.Id = id;
            this.LoyaltyProgramId = loyaltyProgramId;
            this.Meta = meta;
            this.RewardId = rewardId;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Reward code assigned to the contact.
        /// </summary>
        /// <value>Reward code assigned to the contact.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Unique identifier of the contact.
        /// </summary>
        /// <value>Unique identifier of the contact.</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public int? ContactId { get; set; }

        /// <summary>
        /// Timestamp when the reward was created.
        /// </summary>
        /// <value>Timestamp when the reward was created.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Expiration date of the reward.
        /// </summary>
        /// <value>Expiration date of the reward.</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Unique identifier of the reward.
        /// </summary>
        /// <value>Unique identifier of the reward.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier of the loyalty program.
        /// </summary>
        /// <value>Unique identifier of the loyalty program.</value>
        [DataMember(Name="loyaltyProgramId", EmitDefaultValue=false)]
        public string LoyaltyProgramId { get; set; }

        /// <summary>
        /// Additional metadata related to the reward.
        /// </summary>
        /// <value>Additional metadata related to the reward.</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Dictionary<string, Object> Meta { get; set; }

        /// <summary>
        /// Unique identifier of the reward definition.
        /// </summary>
        /// <value>Unique identifier of the reward definition.</value>
        [DataMember(Name="rewardId", EmitDefaultValue=false)]
        public string RewardId { get; set; }

        /// <summary>
        /// Timestamp when the reward was last updated.
        /// </summary>
        /// <value>Timestamp when the reward was last updated.</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionAttributedReward {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoyaltyProgramId: ").Append(LoyaltyProgramId).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  RewardId: ").Append(RewardId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as SubscriptionAttributedReward);
        }

        /// <summary>
        /// Returns true if SubscriptionAttributedReward instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionAttributedReward to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionAttributedReward input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LoyaltyProgramId == input.LoyaltyProgramId ||
                    (this.LoyaltyProgramId != null &&
                    this.LoyaltyProgramId.Equals(input.LoyaltyProgramId))
                ) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
                ) && 
                (
                    this.RewardId == input.RewardId ||
                    (this.RewardId != null &&
                    this.RewardId.Equals(input.RewardId))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LoyaltyProgramId != null)
                    hashCode = hashCode * 59 + this.LoyaltyProgramId.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.RewardId != null)
                    hashCode = hashCode * 59 + this.RewardId.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
