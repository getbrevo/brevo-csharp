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
    /// Features available on the sub-account
    /// </summary>
    [DataContract]
    public partial class SubAccountDetailsResponsePlanInfoFeatures :  IEquatable<SubAccountDetailsResponsePlanInfoFeatures>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccountDetailsResponsePlanInfoFeatures" /> class.
        /// </summary>
        /// <param name="inbox">inbox.</param>
        /// <param name="landingPage">landingPage.</param>
        /// <param name="users">users.</param>
        public SubAccountDetailsResponsePlanInfoFeatures(SubAccountDetailsResponsePlanInfoFeaturesInbox inbox = default(SubAccountDetailsResponsePlanInfoFeaturesInbox), SubAccountDetailsResponsePlanInfoFeaturesLandingPage landingPage = default(SubAccountDetailsResponsePlanInfoFeaturesLandingPage), SubAccountDetailsResponsePlanInfoFeaturesUsers users = default(SubAccountDetailsResponsePlanInfoFeaturesUsers))
        {
            this.Inbox = inbox;
            this.LandingPage = landingPage;
            this.Users = users;
        }
        
        /// <summary>
        /// Gets or Sets Inbox
        /// </summary>
        [DataMember(Name="inbox", EmitDefaultValue=false)]
        public SubAccountDetailsResponsePlanInfoFeaturesInbox Inbox { get; set; }

        /// <summary>
        /// Gets or Sets LandingPage
        /// </summary>
        [DataMember(Name="landingPage", EmitDefaultValue=false)]
        public SubAccountDetailsResponsePlanInfoFeaturesLandingPage LandingPage { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public SubAccountDetailsResponsePlanInfoFeaturesUsers Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubAccountDetailsResponsePlanInfoFeatures {\n");
            sb.Append("  Inbox: ").Append(Inbox).Append("\n");
            sb.Append("  LandingPage: ").Append(LandingPage).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as SubAccountDetailsResponsePlanInfoFeatures);
        }

        /// <summary>
        /// Returns true if SubAccountDetailsResponsePlanInfoFeatures instances are equal
        /// </summary>
        /// <param name="input">Instance of SubAccountDetailsResponsePlanInfoFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubAccountDetailsResponsePlanInfoFeatures input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Inbox == input.Inbox ||
                    (this.Inbox != null &&
                    this.Inbox.Equals(input.Inbox))
                ) && 
                (
                    this.LandingPage == input.LandingPage ||
                    (this.LandingPage != null &&
                    this.LandingPage.Equals(input.LandingPage))
                ) && 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
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
                if (this.Inbox != null)
                    hashCode = hashCode * 59 + this.Inbox.GetHashCode();
                if (this.LandingPage != null)
                    hashCode = hashCode * 59 + this.LandingPage.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }
    }

}
