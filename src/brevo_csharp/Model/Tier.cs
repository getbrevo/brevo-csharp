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
    /// Tier
    /// </summary>
    [DataContract]
    public partial class Tier :  IEquatable<Tier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tier" /> class.
        /// </summary>
        /// <param name="tierId">Tier id.</param>
        /// <param name="name">Tier name.</param>
        /// <param name="imageRef">Tier image reference.</param>
        /// <param name="loyaltyProgramId">Associated loyalty program Id.</param>
        /// <param name="groupId">Associated group Id.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="accessConditions">Conditions required to access this tier.</param>
        /// <param name="tierRewards">Rewards associated with this tier.</param>
        public Tier(Guid? tierId = default(Guid?), string name = default(string), string imageRef = default(string), Guid? loyaltyProgramId = default(Guid?), Guid? groupId = default(Guid?), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), List<TierAccessConditions> accessConditions = default(List<TierAccessConditions>), List<TierTierRewards> tierRewards = default(List<TierTierRewards>))
        {
            this.TierId = tierId;
            this.Name = name;
            this.ImageRef = imageRef;
            this.LoyaltyProgramId = loyaltyProgramId;
            this.GroupId = groupId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AccessConditions = accessConditions;
            this.TierRewards = tierRewards;
        }
        
        /// <summary>
        /// Tier id
        /// </summary>
        /// <value>Tier id</value>
        [DataMember(Name="tierId", EmitDefaultValue=false)]
        public Guid? TierId { get; set; }

        /// <summary>
        /// Tier name
        /// </summary>
        /// <value>Tier name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Tier image reference
        /// </summary>
        /// <value>Tier image reference</value>
        [DataMember(Name="imageRef", EmitDefaultValue=false)]
        public string ImageRef { get; set; }

        /// <summary>
        /// Associated loyalty program Id
        /// </summary>
        /// <value>Associated loyalty program Id</value>
        [DataMember(Name="loyaltyProgramId", EmitDefaultValue=false)]
        public Guid? LoyaltyProgramId { get; set; }

        /// <summary>
        /// Associated group Id
        /// </summary>
        /// <value>Associated group Id</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public Guid? GroupId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Conditions required to access this tier
        /// </summary>
        /// <value>Conditions required to access this tier</value>
        [DataMember(Name="accessConditions", EmitDefaultValue=false)]
        public List<TierAccessConditions> AccessConditions { get; set; }

        /// <summary>
        /// Rewards associated with this tier
        /// </summary>
        /// <value>Rewards associated with this tier</value>
        [DataMember(Name="tierRewards", EmitDefaultValue=false)]
        public List<TierTierRewards> TierRewards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tier {\n");
            sb.Append("  TierId: ").Append(TierId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImageRef: ").Append(ImageRef).Append("\n");
            sb.Append("  LoyaltyProgramId: ").Append(LoyaltyProgramId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  AccessConditions: ").Append(AccessConditions).Append("\n");
            sb.Append("  TierRewards: ").Append(TierRewards).Append("\n");
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
            return this.Equals(input as Tier);
        }

        /// <summary>
        /// Returns true if Tier instances are equal
        /// </summary>
        /// <param name="input">Instance of Tier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TierId == input.TierId ||
                    (this.TierId != null &&
                    this.TierId.Equals(input.TierId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ImageRef == input.ImageRef ||
                    (this.ImageRef != null &&
                    this.ImageRef.Equals(input.ImageRef))
                ) && 
                (
                    this.LoyaltyProgramId == input.LoyaltyProgramId ||
                    (this.LoyaltyProgramId != null &&
                    this.LoyaltyProgramId.Equals(input.LoyaltyProgramId))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.AccessConditions == input.AccessConditions ||
                    this.AccessConditions != null &&
                    this.AccessConditions.SequenceEqual(input.AccessConditions)
                ) && 
                (
                    this.TierRewards == input.TierRewards ||
                    this.TierRewards != null &&
                    this.TierRewards.SequenceEqual(input.TierRewards)
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
                if (this.TierId != null)
                    hashCode = hashCode * 59 + this.TierId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ImageRef != null)
                    hashCode = hashCode * 59 + this.ImageRef.GetHashCode();
                if (this.LoyaltyProgramId != null)
                    hashCode = hashCode * 59 + this.LoyaltyProgramId.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.AccessConditions != null)
                    hashCode = hashCode * 59 + this.AccessConditions.GetHashCode();
                if (this.TierRewards != null)
                    hashCode = hashCode * 59 + this.TierRewards.GetHashCode();
                return hashCode;
            }
        }
    }

}
