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
    /// GetProductDetails
    /// </summary>
    [DataContract]
    public partial class GetProductDetails :  IEquatable<GetProductDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProductDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetProductDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProductDetails" /> class.
        /// </summary>
        /// <param name="id">Product ID for which you requested the details (required).</param>
        /// <param name="name">Name of the product for which you requested the details (required).</param>
        /// <param name="createdAt">Creation UTC date-time of the product (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="modifiedAt">Last modification UTC date-time of the product (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="url">URL to the product.</param>
        /// <param name="imageUrl">Absolute URL to the cover image of the product.</param>
        /// <param name="sku">Product identifier from the shop.</param>
        /// <param name="price">Price of the product.</param>
        /// <param name="categories">Category ID-s of the product.</param>
        /// <param name="parentId">Parent product id of the product.</param>
        /// <param name="s3Original">S3 url of original image.</param>
        /// <param name="s3ThumbAnalytics">S3 thumbnail url of original image in 120x120 dimension for analytics section (required).</param>
        /// <param name="metaInfo">Meta data of product such as description, vendor, producer, stock level, etc..</param>
        /// <param name="s3ThumbEditor">S3 thumbnail url of original image in 600x400 dimension for editor section (required).</param>
        /// <param name="isDeleted">product deleted from the shop&#39;s database.</param>
        public GetProductDetails(string id = default(string), string name = default(string), string createdAt = default(string), string modifiedAt = default(string), string url = default(string), string imageUrl = default(string), string sku = default(string), float? price = default(float?), List<string> categories = default(List<string>), string parentId = default(string), string s3Original = default(string), string s3ThumbAnalytics = default(string), Object metaInfo = default(Object), string s3ThumbEditor = default(string), bool? isDeleted = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetProductDetails and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetProductDetails and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetProductDetails and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "modifiedAt" is required (not null)
            if (modifiedAt == null)
            {
                throw new InvalidDataException("modifiedAt is a required property for GetProductDetails and cannot be null");
            }
            else
            {
                this.ModifiedAt = modifiedAt;
            }
            // to ensure "s3ThumbAnalytics" is required (not null)
            if (s3ThumbAnalytics == null)
            {
                throw new InvalidDataException("s3ThumbAnalytics is a required property for GetProductDetails and cannot be null");
            }
            else
            {
                this.S3ThumbAnalytics = s3ThumbAnalytics;
            }
            // to ensure "s3ThumbEditor" is required (not null)
            if (s3ThumbEditor == null)
            {
                throw new InvalidDataException("s3ThumbEditor is a required property for GetProductDetails and cannot be null");
            }
            else
            {
                this.S3ThumbEditor = s3ThumbEditor;
            }
            this.Url = url;
            this.ImageUrl = imageUrl;
            this.Sku = sku;
            this.Price = price;
            this.Categories = categories;
            this.ParentId = parentId;
            this.S3Original = s3Original;
            this.MetaInfo = metaInfo;
            this.IsDeleted = isDeleted;
        }
        
        /// <summary>
        /// Product ID for which you requested the details
        /// </summary>
        /// <value>Product ID for which you requested the details</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the product for which you requested the details
        /// </summary>
        /// <value>Name of the product for which you requested the details</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Creation UTC date-time of the product (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Creation UTC date-time of the product (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Last modification UTC date-time of the product (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Last modification UTC date-time of the product (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// URL to the product
        /// </summary>
        /// <value>URL to the product</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Absolute URL to the cover image of the product
        /// </summary>
        /// <value>Absolute URL to the cover image of the product</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Product identifier from the shop
        /// </summary>
        /// <value>Product identifier from the shop</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Price of the product
        /// </summary>
        /// <value>Price of the product</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public float? Price { get; set; }

        /// <summary>
        /// Category ID-s of the product
        /// </summary>
        /// <value>Category ID-s of the product</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Parent product id of the product
        /// </summary>
        /// <value>Parent product id of the product</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// S3 url of original image
        /// </summary>
        /// <value>S3 url of original image</value>
        [DataMember(Name="s3Original", EmitDefaultValue=false)]
        public string S3Original { get; set; }

        /// <summary>
        /// S3 thumbnail url of original image in 120x120 dimension for analytics section
        /// </summary>
        /// <value>S3 thumbnail url of original image in 120x120 dimension for analytics section</value>
        [DataMember(Name="s3ThumbAnalytics", EmitDefaultValue=false)]
        public string S3ThumbAnalytics { get; set; }

        /// <summary>
        /// Meta data of product such as description, vendor, producer, stock level, etc.
        /// </summary>
        /// <value>Meta data of product such as description, vendor, producer, stock level, etc.</value>
        [DataMember(Name="metaInfo", EmitDefaultValue=false)]
        public Object MetaInfo { get; set; }

        /// <summary>
        /// S3 thumbnail url of original image in 600x400 dimension for editor section
        /// </summary>
        /// <value>S3 thumbnail url of original image in 600x400 dimension for editor section</value>
        [DataMember(Name="s3ThumbEditor", EmitDefaultValue=false)]
        public string S3ThumbEditor { get; set; }

        /// <summary>
        /// product deleted from the shop&#39;s database
        /// </summary>
        /// <value>product deleted from the shop&#39;s database</value>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetProductDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  S3Original: ").Append(S3Original).Append("\n");
            sb.Append("  S3ThumbAnalytics: ").Append(S3ThumbAnalytics).Append("\n");
            sb.Append("  MetaInfo: ").Append(MetaInfo).Append("\n");
            sb.Append("  S3ThumbEditor: ").Append(S3ThumbEditor).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
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
            return this.Equals(input as GetProductDetails);
        }

        /// <summary>
        /// Returns true if GetProductDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProductDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProductDetails input)
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
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.S3Original == input.S3Original ||
                    (this.S3Original != null &&
                    this.S3Original.Equals(input.S3Original))
                ) && 
                (
                    this.S3ThumbAnalytics == input.S3ThumbAnalytics ||
                    (this.S3ThumbAnalytics != null &&
                    this.S3ThumbAnalytics.Equals(input.S3ThumbAnalytics))
                ) && 
                (
                    this.MetaInfo == input.MetaInfo ||
                    (this.MetaInfo != null &&
                    this.MetaInfo.Equals(input.MetaInfo))
                ) && 
                (
                    this.S3ThumbEditor == input.S3ThumbEditor ||
                    (this.S3ThumbEditor != null &&
                    this.S3ThumbEditor.Equals(input.S3ThumbEditor))
                ) && 
                (
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.S3Original != null)
                    hashCode = hashCode * 59 + this.S3Original.GetHashCode();
                if (this.S3ThumbAnalytics != null)
                    hashCode = hashCode * 59 + this.S3ThumbAnalytics.GetHashCode();
                if (this.MetaInfo != null)
                    hashCode = hashCode * 59 + this.MetaInfo.GetHashCode();
                if (this.S3ThumbEditor != null)
                    hashCode = hashCode * 59 + this.S3ThumbEditor.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                return hashCode;
            }
        }
    }

}
