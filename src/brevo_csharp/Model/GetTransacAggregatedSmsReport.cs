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
    /// GetTransacAggregatedSmsReport
    /// </summary>
    [DataContract]
    public partial class GetTransacAggregatedSmsReport :  IEquatable<GetTransacAggregatedSmsReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransacAggregatedSmsReport" /> class.
        /// </summary>
        /// <param name="range">Time frame of the report.</param>
        /// <param name="requests">Number of requests for the timeframe.</param>
        /// <param name="delivered">Number of delivered SMS for the timeframe.</param>
        /// <param name="hardBounces">Number of hardbounces for the timeframe.</param>
        /// <param name="softBounces">Number of softbounces for the timeframe.</param>
        /// <param name="blocked">Number of blocked contact for the timeframe.</param>
        /// <param name="unsubscribed">Number of unsubscription for the timeframe.</param>
        /// <param name="replied">Number of answered SMS for the timeframe.</param>
        /// <param name="accepted">Number of accepted for the timeframe.</param>
        /// <param name="rejected">Number of rejected for the timeframe.</param>
        public GetTransacAggregatedSmsReport(string range = default(string), long? requests = default(long?), long? delivered = default(long?), long? hardBounces = default(long?), long? softBounces = default(long?), long? blocked = default(long?), long? unsubscribed = default(long?), long? replied = default(long?), long? accepted = default(long?), long? rejected = default(long?))
        {
            this.Range = range;
            this.Requests = requests;
            this.Delivered = delivered;
            this.HardBounces = hardBounces;
            this.SoftBounces = softBounces;
            this.Blocked = blocked;
            this.Unsubscribed = unsubscribed;
            this.Replied = replied;
            this.Accepted = accepted;
            this.Rejected = rejected;
        }
        
        /// <summary>
        /// Time frame of the report
        /// </summary>
        /// <value>Time frame of the report</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public string Range { get; set; }

        /// <summary>
        /// Number of requests for the timeframe
        /// </summary>
        /// <value>Number of requests for the timeframe</value>
        [DataMember(Name="requests", EmitDefaultValue=false)]
        public long? Requests { get; set; }

        /// <summary>
        /// Number of delivered SMS for the timeframe
        /// </summary>
        /// <value>Number of delivered SMS for the timeframe</value>
        [DataMember(Name="delivered", EmitDefaultValue=false)]
        public long? Delivered { get; set; }

        /// <summary>
        /// Number of hardbounces for the timeframe
        /// </summary>
        /// <value>Number of hardbounces for the timeframe</value>
        [DataMember(Name="hardBounces", EmitDefaultValue=false)]
        public long? HardBounces { get; set; }

        /// <summary>
        /// Number of softbounces for the timeframe
        /// </summary>
        /// <value>Number of softbounces for the timeframe</value>
        [DataMember(Name="softBounces", EmitDefaultValue=false)]
        public long? SoftBounces { get; set; }

        /// <summary>
        /// Number of blocked contact for the timeframe
        /// </summary>
        /// <value>Number of blocked contact for the timeframe</value>
        [DataMember(Name="blocked", EmitDefaultValue=false)]
        public long? Blocked { get; set; }

        /// <summary>
        /// Number of unsubscription for the timeframe
        /// </summary>
        /// <value>Number of unsubscription for the timeframe</value>
        [DataMember(Name="unsubscribed", EmitDefaultValue=false)]
        public long? Unsubscribed { get; set; }

        /// <summary>
        /// Number of answered SMS for the timeframe
        /// </summary>
        /// <value>Number of answered SMS for the timeframe</value>
        [DataMember(Name="replied", EmitDefaultValue=false)]
        public long? Replied { get; set; }

        /// <summary>
        /// Number of accepted for the timeframe
        /// </summary>
        /// <value>Number of accepted for the timeframe</value>
        [DataMember(Name="accepted", EmitDefaultValue=false)]
        public long? Accepted { get; set; }

        /// <summary>
        /// Number of rejected for the timeframe
        /// </summary>
        /// <value>Number of rejected for the timeframe</value>
        [DataMember(Name="rejected", EmitDefaultValue=false)]
        public long? Rejected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransacAggregatedSmsReport {\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
            sb.Append("  Delivered: ").Append(Delivered).Append("\n");
            sb.Append("  HardBounces: ").Append(HardBounces).Append("\n");
            sb.Append("  SoftBounces: ").Append(SoftBounces).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  Unsubscribed: ").Append(Unsubscribed).Append("\n");
            sb.Append("  Replied: ").Append(Replied).Append("\n");
            sb.Append("  Accepted: ").Append(Accepted).Append("\n");
            sb.Append("  Rejected: ").Append(Rejected).Append("\n");
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
            return this.Equals(input as GetTransacAggregatedSmsReport);
        }

        /// <summary>
        /// Returns true if GetTransacAggregatedSmsReport instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransacAggregatedSmsReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransacAggregatedSmsReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Range == input.Range ||
                    (this.Range != null &&
                    this.Range.Equals(input.Range))
                ) && 
                (
                    this.Requests == input.Requests ||
                    (this.Requests != null &&
                    this.Requests.Equals(input.Requests))
                ) && 
                (
                    this.Delivered == input.Delivered ||
                    (this.Delivered != null &&
                    this.Delivered.Equals(input.Delivered))
                ) && 
                (
                    this.HardBounces == input.HardBounces ||
                    (this.HardBounces != null &&
                    this.HardBounces.Equals(input.HardBounces))
                ) && 
                (
                    this.SoftBounces == input.SoftBounces ||
                    (this.SoftBounces != null &&
                    this.SoftBounces.Equals(input.SoftBounces))
                ) && 
                (
                    this.Blocked == input.Blocked ||
                    (this.Blocked != null &&
                    this.Blocked.Equals(input.Blocked))
                ) && 
                (
                    this.Unsubscribed == input.Unsubscribed ||
                    (this.Unsubscribed != null &&
                    this.Unsubscribed.Equals(input.Unsubscribed))
                ) && 
                (
                    this.Replied == input.Replied ||
                    (this.Replied != null &&
                    this.Replied.Equals(input.Replied))
                ) && 
                (
                    this.Accepted == input.Accepted ||
                    (this.Accepted != null &&
                    this.Accepted.Equals(input.Accepted))
                ) && 
                (
                    this.Rejected == input.Rejected ||
                    (this.Rejected != null &&
                    this.Rejected.Equals(input.Rejected))
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
                if (this.Range != null)
                    hashCode = hashCode * 59 + this.Range.GetHashCode();
                if (this.Requests != null)
                    hashCode = hashCode * 59 + this.Requests.GetHashCode();
                if (this.Delivered != null)
                    hashCode = hashCode * 59 + this.Delivered.GetHashCode();
                if (this.HardBounces != null)
                    hashCode = hashCode * 59 + this.HardBounces.GetHashCode();
                if (this.SoftBounces != null)
                    hashCode = hashCode * 59 + this.SoftBounces.GetHashCode();
                if (this.Blocked != null)
                    hashCode = hashCode * 59 + this.Blocked.GetHashCode();
                if (this.Unsubscribed != null)
                    hashCode = hashCode * 59 + this.Unsubscribed.GetHashCode();
                if (this.Replied != null)
                    hashCode = hashCode * 59 + this.Replied.GetHashCode();
                if (this.Accepted != null)
                    hashCode = hashCode * 59 + this.Accepted.GetHashCode();
                if (this.Rejected != null)
                    hashCode = hashCode * 59 + this.Rejected.GetHashCode();
                return hashCode;
            }
        }
    }

}
