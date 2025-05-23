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
    /// GetCouponCollection
    /// </summary>
    [DataContract]
    public partial class GetCouponCollection :  IEquatable<GetCouponCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCouponCollection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCouponCollection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCouponCollection" /> class.
        /// </summary>
        /// <param name="id">The id of the collection. (required).</param>
        /// <param name="name">The name of the collection. (required).</param>
        /// <param name="defaultCoupon">The default coupon of the collection. (required).</param>
        /// <param name="createdAt">Datetime on which the collection was created. (required).</param>
        /// <param name="totalCoupons">Total number of coupons in the collection. (required).</param>
        /// <param name="remainingCoupons">Number of coupons that have not been sent yet. (required).</param>
        /// <param name="expirationDate">Expiration date for the coupon collection in RFC3339 format..</param>
        /// <param name="remainingDaysAlert">If present, an email notification is going to be sent the defined amount of days before the expiration date..</param>
        /// <param name="remainingCouponsAlert">If present, an email notification is going to be sent when the total number of available coupons falls below the defined threshold..</param>
        public GetCouponCollection(string id = default(string), string name = default(string), string defaultCoupon = default(string), DateTime? createdAt = default(DateTime?), long? totalCoupons = default(long?), long? remainingCoupons = default(long?), DateTime? expirationDate = default(DateTime?), int? remainingDaysAlert = default(int?), int? remainingCouponsAlert = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetCouponCollection and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetCouponCollection and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "defaultCoupon" is required (not null)
            if (defaultCoupon == null)
            {
                throw new InvalidDataException("defaultCoupon is a required property for GetCouponCollection and cannot be null");
            }
            else
            {
                this.DefaultCoupon = defaultCoupon;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetCouponCollection and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "totalCoupons" is required (not null)
            if (totalCoupons == null)
            {
                throw new InvalidDataException("totalCoupons is a required property for GetCouponCollection and cannot be null");
            }
            else
            {
                this.TotalCoupons = totalCoupons;
            }
            // to ensure "remainingCoupons" is required (not null)
            if (remainingCoupons == null)
            {
                throw new InvalidDataException("remainingCoupons is a required property for GetCouponCollection and cannot be null");
            }
            else
            {
                this.RemainingCoupons = remainingCoupons;
            }
            this.ExpirationDate = expirationDate;
            this.RemainingDaysAlert = remainingDaysAlert;
            this.RemainingCouponsAlert = remainingCouponsAlert;
        }
        
        /// <summary>
        /// The id of the collection.
        /// </summary>
        /// <value>The id of the collection.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the collection.
        /// </summary>
        /// <value>The name of the collection.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The default coupon of the collection.
        /// </summary>
        /// <value>The default coupon of the collection.</value>
        [DataMember(Name="defaultCoupon", EmitDefaultValue=false)]
        public string DefaultCoupon { get; set; }

        /// <summary>
        /// Datetime on which the collection was created.
        /// </summary>
        /// <value>Datetime on which the collection was created.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Total number of coupons in the collection.
        /// </summary>
        /// <value>Total number of coupons in the collection.</value>
        [DataMember(Name="totalCoupons", EmitDefaultValue=false)]
        public long? TotalCoupons { get; set; }

        /// <summary>
        /// Number of coupons that have not been sent yet.
        /// </summary>
        /// <value>Number of coupons that have not been sent yet.</value>
        [DataMember(Name="remainingCoupons", EmitDefaultValue=false)]
        public long? RemainingCoupons { get; set; }

        /// <summary>
        /// Expiration date for the coupon collection in RFC3339 format.
        /// </summary>
        /// <value>Expiration date for the coupon collection in RFC3339 format.</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// If present, an email notification is going to be sent the defined amount of days before the expiration date.
        /// </summary>
        /// <value>If present, an email notification is going to be sent the defined amount of days before the expiration date.</value>
        [DataMember(Name="remainingDaysAlert", EmitDefaultValue=false)]
        public int? RemainingDaysAlert { get; set; }

        /// <summary>
        /// If present, an email notification is going to be sent when the total number of available coupons falls below the defined threshold.
        /// </summary>
        /// <value>If present, an email notification is going to be sent when the total number of available coupons falls below the defined threshold.</value>
        [DataMember(Name="remainingCouponsAlert", EmitDefaultValue=false)]
        public int? RemainingCouponsAlert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCouponCollection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultCoupon: ").Append(DefaultCoupon).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  TotalCoupons: ").Append(TotalCoupons).Append("\n");
            sb.Append("  RemainingCoupons: ").Append(RemainingCoupons).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  RemainingDaysAlert: ").Append(RemainingDaysAlert).Append("\n");
            sb.Append("  RemainingCouponsAlert: ").Append(RemainingCouponsAlert).Append("\n");
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
            return this.Equals(input as GetCouponCollection);
        }

        /// <summary>
        /// Returns true if GetCouponCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCouponCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCouponCollection input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DefaultCoupon == input.DefaultCoupon ||
                    (this.DefaultCoupon != null &&
                    this.DefaultCoupon.Equals(input.DefaultCoupon))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.TotalCoupons == input.TotalCoupons ||
                    (this.TotalCoupons != null &&
                    this.TotalCoupons.Equals(input.TotalCoupons))
                ) && 
                (
                    this.RemainingCoupons == input.RemainingCoupons ||
                    (this.RemainingCoupons != null &&
                    this.RemainingCoupons.Equals(input.RemainingCoupons))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.RemainingDaysAlert == input.RemainingDaysAlert ||
                    (this.RemainingDaysAlert != null &&
                    this.RemainingDaysAlert.Equals(input.RemainingDaysAlert))
                ) && 
                (
                    this.RemainingCouponsAlert == input.RemainingCouponsAlert ||
                    (this.RemainingCouponsAlert != null &&
                    this.RemainingCouponsAlert.Equals(input.RemainingCouponsAlert))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DefaultCoupon != null)
                    hashCode = hashCode * 59 + this.DefaultCoupon.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.TotalCoupons != null)
                    hashCode = hashCode * 59 + this.TotalCoupons.GetHashCode();
                if (this.RemainingCoupons != null)
                    hashCode = hashCode * 59 + this.RemainingCoupons.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                if (this.RemainingDaysAlert != null)
                    hashCode = hashCode * 59 + this.RemainingDaysAlert.GetHashCode();
                if (this.RemainingCouponsAlert != null)
                    hashCode = hashCode * 59 + this.RemainingCouponsAlert.GetHashCode();
                return hashCode;
            }
        }
    }

}
