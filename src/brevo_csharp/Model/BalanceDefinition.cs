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
    /// BalanceDefinition
    /// </summary>
    [DataContract]
    public partial class BalanceDefinition :  IEquatable<BalanceDefinition>
    {
        /// <summary>
        /// startOfPeriod depicts the balancy expiry on start of day/week/month/year. endOfPeriod depicts the balancy expiry on end of day/week/month/year
        /// </summary>
        /// <value>startOfPeriod depicts the balancy expiry on start of day/week/month/year. endOfPeriod depicts the balancy expiry on end of day/week/month/year</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BalanceAvailabilityDurationModifierEnum
        {
            
            /// <summary>
            /// Enum StartOfPeriod for value: startOfPeriod
            /// </summary>
            [EnumMember(Value = "startOfPeriod")]
            StartOfPeriod = 1,
            
            /// <summary>
            /// Enum EndOfPeriod for value: endOfPeriod
            /// </summary>
            [EnumMember(Value = "endOfPeriod")]
            EndOfPeriod = 2,
            
            /// <summary>
            /// Enum NoModification for value: noModification
            /// </summary>
            [EnumMember(Value = "noModification")]
            NoModification = 3
        }

        /// <summary>
        /// startOfPeriod depicts the balancy expiry on start of day/week/month/year. endOfPeriod depicts the balancy expiry on end of day/week/month/year
        /// </summary>
        /// <value>startOfPeriod depicts the balancy expiry on start of day/week/month/year. endOfPeriod depicts the balancy expiry on end of day/week/month/year</value>
        [DataMember(Name="balanceAvailabilityDurationModifier", EmitDefaultValue=false)]
        public BalanceAvailabilityDurationModifierEnum? BalanceAvailabilityDurationModifier { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceDefinition" /> class.
        /// </summary>
        /// <param name="balanceAvailabilityDurationModifier">startOfPeriod depicts the balancy expiry on start of day/week/month/year. endOfPeriod depicts the balancy expiry on end of day/week/month/year.</param>
        /// <param name="balanceAvailabilityDurationUnit">Unit of time for the balance&#39;s availability (e.g., day/week/month/year)..</param>
        /// <param name="balanceAvailabilityDurationValue">Number of days/weeks/month/year for balance expiry.</param>
        /// <param name="balanceExpirationDate">Date when the balance expires and can no longer be used, in dd/mm format. The balance will be expired when this date appears next in the calendar and only one of balanceExpirationDate or balance availability fields can be used..</param>
        /// <param name="balanceOptionAmountOvertakingStrategy">Partial enables partial credit of balance if maximum balance limit is reaching. Strict enables rejection of transaction if it will breach the max credit amount limit..</param>
        /// <param name="balanceOptionCreditRounding">Rounding strategy for credit transactions..</param>
        /// <param name="balanceOptionDebitRounding">Rounding strategy for debit transactions..</param>
        /// <param name="createdAt">Timestamp of balance definition creation..</param>
        /// <param name="deletedAt">Timestamp of balance definition deletion (nullable)..</param>
        /// <param name="description">Short description of the balance definition..</param>
        /// <param name="id">Unique identifier for the balance definition..</param>
        /// <param name="imageRef">Optional image reference URL..</param>
        /// <param name="maxAmount">Maximum allowable balance..</param>
        /// <param name="maxCreditAmountLimit">Max credit allowed per operation..</param>
        /// <param name="maxDebitAmountLimit">Max debit allowed per operation..</param>
        /// <param name="meta">Additional metadata for the balance definition..</param>
        /// <param name="minAmount">Minimum allowable balance..</param>
        /// <param name="name">Name of the balance definition..</param>
        /// <param name="unit">Unit of balance (e.g., points, currency)..</param>
        /// <param name="updatedAt">Timestamp of the last update..</param>
        public BalanceDefinition(BalanceAvailabilityDurationModifierEnum? balanceAvailabilityDurationModifier = default(BalanceAvailabilityDurationModifierEnum?), string balanceAvailabilityDurationUnit = default(string), int? balanceAvailabilityDurationValue = default(int?), DateTime? balanceExpirationDate = default(DateTime?), string balanceOptionAmountOvertakingStrategy = default(string), string balanceOptionCreditRounding = default(string), string balanceOptionDebitRounding = default(string), DateTime? createdAt = default(DateTime?), string deletedAt = default(string), string description = default(string), string id = default(string), string imageRef = default(string), decimal? maxAmount = default(decimal?), decimal? maxCreditAmountLimit = default(decimal?), decimal? maxDebitAmountLimit = default(decimal?), Dictionary<string, Object> meta = default(Dictionary<string, Object>), decimal? minAmount = default(decimal?), string name = default(string), string unit = default(string), string updatedAt = default(string))
        {
            this.BalanceAvailabilityDurationModifier = balanceAvailabilityDurationModifier;
            this.BalanceAvailabilityDurationUnit = balanceAvailabilityDurationUnit;
            this.BalanceAvailabilityDurationValue = balanceAvailabilityDurationValue;
            this.BalanceExpirationDate = balanceExpirationDate;
            this.BalanceOptionAmountOvertakingStrategy = balanceOptionAmountOvertakingStrategy;
            this.BalanceOptionCreditRounding = balanceOptionCreditRounding;
            this.BalanceOptionDebitRounding = balanceOptionDebitRounding;
            this.CreatedAt = createdAt;
            this.DeletedAt = deletedAt;
            this.Description = description;
            this.Id = id;
            this.ImageRef = imageRef;
            this.MaxAmount = maxAmount;
            this.MaxCreditAmountLimit = maxCreditAmountLimit;
            this.MaxDebitAmountLimit = maxDebitAmountLimit;
            this.Meta = meta;
            this.MinAmount = minAmount;
            this.Name = name;
            this.Unit = unit;
            this.UpdatedAt = updatedAt;
        }
        

        /// <summary>
        /// Unit of time for the balance&#39;s availability (e.g., day/week/month/year).
        /// </summary>
        /// <value>Unit of time for the balance&#39;s availability (e.g., day/week/month/year).</value>
        [DataMember(Name="balanceAvailabilityDurationUnit", EmitDefaultValue=false)]
        public string BalanceAvailabilityDurationUnit { get; set; }

        /// <summary>
        /// Number of days/weeks/month/year for balance expiry
        /// </summary>
        /// <value>Number of days/weeks/month/year for balance expiry</value>
        [DataMember(Name="balanceAvailabilityDurationValue", EmitDefaultValue=false)]
        public int? BalanceAvailabilityDurationValue { get; set; }

        /// <summary>
        /// Date when the balance expires and can no longer be used, in dd/mm format. The balance will be expired when this date appears next in the calendar and only one of balanceExpirationDate or balance availability fields can be used.
        /// </summary>
        /// <value>Date when the balance expires and can no longer be used, in dd/mm format. The balance will be expired when this date appears next in the calendar and only one of balanceExpirationDate or balance availability fields can be used.</value>
        [DataMember(Name="balanceExpirationDate", EmitDefaultValue=false)]
        public DateTime? BalanceExpirationDate { get; set; }

        /// <summary>
        /// Partial enables partial credit of balance if maximum balance limit is reaching. Strict enables rejection of transaction if it will breach the max credit amount limit.
        /// </summary>
        /// <value>Partial enables partial credit of balance if maximum balance limit is reaching. Strict enables rejection of transaction if it will breach the max credit amount limit.</value>
        [DataMember(Name="balanceOptionAmountOvertakingStrategy", EmitDefaultValue=false)]
        public string BalanceOptionAmountOvertakingStrategy { get; set; }

        /// <summary>
        /// Rounding strategy for credit transactions.
        /// </summary>
        /// <value>Rounding strategy for credit transactions.</value>
        [DataMember(Name="balanceOptionCreditRounding", EmitDefaultValue=false)]
        public string BalanceOptionCreditRounding { get; set; }

        /// <summary>
        /// Rounding strategy for debit transactions.
        /// </summary>
        /// <value>Rounding strategy for debit transactions.</value>
        [DataMember(Name="balanceOptionDebitRounding", EmitDefaultValue=false)]
        public string BalanceOptionDebitRounding { get; set; }

        /// <summary>
        /// Timestamp of balance definition creation.
        /// </summary>
        /// <value>Timestamp of balance definition creation.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of balance definition deletion (nullable).
        /// </summary>
        /// <value>Timestamp of balance definition deletion (nullable).</value>
        [DataMember(Name="deletedAt", EmitDefaultValue=false)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// Short description of the balance definition.
        /// </summary>
        /// <value>Short description of the balance definition.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Unique identifier for the balance definition.
        /// </summary>
        /// <value>Unique identifier for the balance definition.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Optional image reference URL.
        /// </summary>
        /// <value>Optional image reference URL.</value>
        [DataMember(Name="imageRef", EmitDefaultValue=false)]
        public string ImageRef { get; set; }

        /// <summary>
        /// Maximum allowable balance.
        /// </summary>
        /// <value>Maximum allowable balance.</value>
        [DataMember(Name="maxAmount", EmitDefaultValue=false)]
        public decimal? MaxAmount { get; set; }

        /// <summary>
        /// Max credit allowed per operation.
        /// </summary>
        /// <value>Max credit allowed per operation.</value>
        [DataMember(Name="maxCreditAmountLimit", EmitDefaultValue=false)]
        public decimal? MaxCreditAmountLimit { get; set; }

        /// <summary>
        /// Max debit allowed per operation.
        /// </summary>
        /// <value>Max debit allowed per operation.</value>
        [DataMember(Name="maxDebitAmountLimit", EmitDefaultValue=false)]
        public decimal? MaxDebitAmountLimit { get; set; }

        /// <summary>
        /// Additional metadata for the balance definition.
        /// </summary>
        /// <value>Additional metadata for the balance definition.</value>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public Dictionary<string, Object> Meta { get; set; }

        /// <summary>
        /// Minimum allowable balance.
        /// </summary>
        /// <value>Minimum allowable balance.</value>
        [DataMember(Name="minAmount", EmitDefaultValue=false)]
        public decimal? MinAmount { get; set; }

        /// <summary>
        /// Name of the balance definition.
        /// </summary>
        /// <value>Name of the balance definition.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Unit of balance (e.g., points, currency).
        /// </summary>
        /// <value>Unit of balance (e.g., points, currency).</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Timestamp of the last update.
        /// </summary>
        /// <value>Timestamp of the last update.</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BalanceDefinition {\n");
            sb.Append("  BalanceAvailabilityDurationModifier: ").Append(BalanceAvailabilityDurationModifier).Append("\n");
            sb.Append("  BalanceAvailabilityDurationUnit: ").Append(BalanceAvailabilityDurationUnit).Append("\n");
            sb.Append("  BalanceAvailabilityDurationValue: ").Append(BalanceAvailabilityDurationValue).Append("\n");
            sb.Append("  BalanceExpirationDate: ").Append(BalanceExpirationDate).Append("\n");
            sb.Append("  BalanceOptionAmountOvertakingStrategy: ").Append(BalanceOptionAmountOvertakingStrategy).Append("\n");
            sb.Append("  BalanceOptionCreditRounding: ").Append(BalanceOptionCreditRounding).Append("\n");
            sb.Append("  BalanceOptionDebitRounding: ").Append(BalanceOptionDebitRounding).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageRef: ").Append(ImageRef).Append("\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
            sb.Append("  MaxCreditAmountLimit: ").Append(MaxCreditAmountLimit).Append("\n");
            sb.Append("  MaxDebitAmountLimit: ").Append(MaxDebitAmountLimit).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  MinAmount: ").Append(MinAmount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as BalanceDefinition);
        }

        /// <summary>
        /// Returns true if BalanceDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BalanceAvailabilityDurationModifier == input.BalanceAvailabilityDurationModifier ||
                    (this.BalanceAvailabilityDurationModifier != null &&
                    this.BalanceAvailabilityDurationModifier.Equals(input.BalanceAvailabilityDurationModifier))
                ) && 
                (
                    this.BalanceAvailabilityDurationUnit == input.BalanceAvailabilityDurationUnit ||
                    (this.BalanceAvailabilityDurationUnit != null &&
                    this.BalanceAvailabilityDurationUnit.Equals(input.BalanceAvailabilityDurationUnit))
                ) && 
                (
                    this.BalanceAvailabilityDurationValue == input.BalanceAvailabilityDurationValue ||
                    (this.BalanceAvailabilityDurationValue != null &&
                    this.BalanceAvailabilityDurationValue.Equals(input.BalanceAvailabilityDurationValue))
                ) && 
                (
                    this.BalanceExpirationDate == input.BalanceExpirationDate ||
                    (this.BalanceExpirationDate != null &&
                    this.BalanceExpirationDate.Equals(input.BalanceExpirationDate))
                ) && 
                (
                    this.BalanceOptionAmountOvertakingStrategy == input.BalanceOptionAmountOvertakingStrategy ||
                    (this.BalanceOptionAmountOvertakingStrategy != null &&
                    this.BalanceOptionAmountOvertakingStrategy.Equals(input.BalanceOptionAmountOvertakingStrategy))
                ) && 
                (
                    this.BalanceOptionCreditRounding == input.BalanceOptionCreditRounding ||
                    (this.BalanceOptionCreditRounding != null &&
                    this.BalanceOptionCreditRounding.Equals(input.BalanceOptionCreditRounding))
                ) && 
                (
                    this.BalanceOptionDebitRounding == input.BalanceOptionDebitRounding ||
                    (this.BalanceOptionDebitRounding != null &&
                    this.BalanceOptionDebitRounding.Equals(input.BalanceOptionDebitRounding))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImageRef == input.ImageRef ||
                    (this.ImageRef != null &&
                    this.ImageRef.Equals(input.ImageRef))
                ) && 
                (
                    this.MaxAmount == input.MaxAmount ||
                    (this.MaxAmount != null &&
                    this.MaxAmount.Equals(input.MaxAmount))
                ) && 
                (
                    this.MaxCreditAmountLimit == input.MaxCreditAmountLimit ||
                    (this.MaxCreditAmountLimit != null &&
                    this.MaxCreditAmountLimit.Equals(input.MaxCreditAmountLimit))
                ) && 
                (
                    this.MaxDebitAmountLimit == input.MaxDebitAmountLimit ||
                    (this.MaxDebitAmountLimit != null &&
                    this.MaxDebitAmountLimit.Equals(input.MaxDebitAmountLimit))
                ) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
                ) && 
                (
                    this.MinAmount == input.MinAmount ||
                    (this.MinAmount != null &&
                    this.MinAmount.Equals(input.MinAmount))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.BalanceAvailabilityDurationModifier != null)
                    hashCode = hashCode * 59 + this.BalanceAvailabilityDurationModifier.GetHashCode();
                if (this.BalanceAvailabilityDurationUnit != null)
                    hashCode = hashCode * 59 + this.BalanceAvailabilityDurationUnit.GetHashCode();
                if (this.BalanceAvailabilityDurationValue != null)
                    hashCode = hashCode * 59 + this.BalanceAvailabilityDurationValue.GetHashCode();
                if (this.BalanceExpirationDate != null)
                    hashCode = hashCode * 59 + this.BalanceExpirationDate.GetHashCode();
                if (this.BalanceOptionAmountOvertakingStrategy != null)
                    hashCode = hashCode * 59 + this.BalanceOptionAmountOvertakingStrategy.GetHashCode();
                if (this.BalanceOptionCreditRounding != null)
                    hashCode = hashCode * 59 + this.BalanceOptionCreditRounding.GetHashCode();
                if (this.BalanceOptionDebitRounding != null)
                    hashCode = hashCode * 59 + this.BalanceOptionDebitRounding.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImageRef != null)
                    hashCode = hashCode * 59 + this.ImageRef.GetHashCode();
                if (this.MaxAmount != null)
                    hashCode = hashCode * 59 + this.MaxAmount.GetHashCode();
                if (this.MaxCreditAmountLimit != null)
                    hashCode = hashCode * 59 + this.MaxCreditAmountLimit.GetHashCode();
                if (this.MaxDebitAmountLimit != null)
                    hashCode = hashCode * 59 + this.MaxDebitAmountLimit.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.MinAmount != null)
                    hashCode = hashCode * 59 + this.MinAmount.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
