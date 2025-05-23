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
    /// Features details to update
    /// </summary>
    [DataContract]
    public partial class SubAccountUpdatePlanRequestFeatures :  IEquatable<SubAccountUpdatePlanRequestFeatures>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccountUpdatePlanRequestFeatures" /> class.
        /// </summary>
        /// <param name="users">Number of multi-users.</param>
        /// <param name="landingPage">Number of landing pages.</param>
        /// <param name="inbox">Number of inboxes / Not required on ENTv2.</param>
        /// <param name="salesUsers">Number of sales users.</param>
        public SubAccountUpdatePlanRequestFeatures(long? users = default(long?), long? landingPage = default(long?), long? inbox = default(long?), long? salesUsers = default(long?))
        {
            this.Users = users;
            this.LandingPage = landingPage;
            this.Inbox = inbox;
            this.SalesUsers = salesUsers;
        }
        
        /// <summary>
        /// Number of multi-users
        /// </summary>
        /// <value>Number of multi-users</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public long? Users { get; set; }

        /// <summary>
        /// Number of landing pages
        /// </summary>
        /// <value>Number of landing pages</value>
        [DataMember(Name="landingPage", EmitDefaultValue=false)]
        public long? LandingPage { get; set; }

        /// <summary>
        /// Number of inboxes / Not required on ENTv2
        /// </summary>
        /// <value>Number of inboxes / Not required on ENTv2</value>
        [DataMember(Name="inbox", EmitDefaultValue=false)]
        public long? Inbox { get; set; }

        /// <summary>
        /// Number of sales users
        /// </summary>
        /// <value>Number of sales users</value>
        [DataMember(Name="salesUsers", EmitDefaultValue=false)]
        public long? SalesUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubAccountUpdatePlanRequestFeatures {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  LandingPage: ").Append(LandingPage).Append("\n");
            sb.Append("  Inbox: ").Append(Inbox).Append("\n");
            sb.Append("  SalesUsers: ").Append(SalesUsers).Append("\n");
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
            return this.Equals(input as SubAccountUpdatePlanRequestFeatures);
        }

        /// <summary>
        /// Returns true if SubAccountUpdatePlanRequestFeatures instances are equal
        /// </summary>
        /// <param name="input">Instance of SubAccountUpdatePlanRequestFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubAccountUpdatePlanRequestFeatures input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
                ) && 
                (
                    this.LandingPage == input.LandingPage ||
                    (this.LandingPage != null &&
                    this.LandingPage.Equals(input.LandingPage))
                ) && 
                (
                    this.Inbox == input.Inbox ||
                    (this.Inbox != null &&
                    this.Inbox.Equals(input.Inbox))
                ) && 
                (
                    this.SalesUsers == input.SalesUsers ||
                    (this.SalesUsers != null &&
                    this.SalesUsers.Equals(input.SalesUsers))
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
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.LandingPage != null)
                    hashCode = hashCode * 59 + this.LandingPage.GetHashCode();
                if (this.Inbox != null)
                    hashCode = hashCode * 59 + this.Inbox.GetHashCode();
                if (this.SalesUsers != null)
                    hashCode = hashCode * 59 + this.SalesUsers.GetHashCode();
                return hashCode;
            }
        }
    }

}
