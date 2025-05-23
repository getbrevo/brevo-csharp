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
    /// MainRuleConditionResponse
    /// </summary>
    [DataContract]
    public partial class MainRuleConditionResponse :  IEquatable<MainRuleConditionResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainRuleConditionResponse" /> class.
        /// </summary>
        /// <param name="and">Metric to indicate AND between rules.</param>
        /// <param name="lhs">Conditon of the rule.</param>
        /// <param name="op">Selected operator for the rule.</param>
        /// <param name="or">Metric to indicate OR between rules.</param>
        /// <param name="rhs">Action of the rule.</param>
        public MainRuleConditionResponse(List<MainRuleConditionResponse> and = default(List<MainRuleConditionResponse>), Object lhs = default(Object), string op = default(string), List<MainRuleConditionResponse> or = default(List<MainRuleConditionResponse>), Object rhs = default(Object))
        {
            this.And = and;
            this.Lhs = lhs;
            this.Op = op;
            this.Or = or;
            this.Rhs = rhs;
        }
        
        /// <summary>
        /// Metric to indicate AND between rules
        /// </summary>
        /// <value>Metric to indicate AND between rules</value>
        [DataMember(Name="and", EmitDefaultValue=false)]
        public List<MainRuleConditionResponse> And { get; set; }

        /// <summary>
        /// Conditon of the rule
        /// </summary>
        /// <value>Conditon of the rule</value>
        [DataMember(Name="lhs", EmitDefaultValue=false)]
        public Object Lhs { get; set; }

        /// <summary>
        /// Selected operator for the rule
        /// </summary>
        /// <value>Selected operator for the rule</value>
        [DataMember(Name="op", EmitDefaultValue=false)]
        public string Op { get; set; }

        /// <summary>
        /// Metric to indicate OR between rules
        /// </summary>
        /// <value>Metric to indicate OR between rules</value>
        [DataMember(Name="or", EmitDefaultValue=false)]
        public List<MainRuleConditionResponse> Or { get; set; }

        /// <summary>
        /// Action of the rule
        /// </summary>
        /// <value>Action of the rule</value>
        [DataMember(Name="rhs", EmitDefaultValue=false)]
        public Object Rhs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MainRuleConditionResponse {\n");
            sb.Append("  And: ").Append(And).Append("\n");
            sb.Append("  Lhs: ").Append(Lhs).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Or: ").Append(Or).Append("\n");
            sb.Append("  Rhs: ").Append(Rhs).Append("\n");
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
            return this.Equals(input as MainRuleConditionResponse);
        }

        /// <summary>
        /// Returns true if MainRuleConditionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MainRuleConditionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MainRuleConditionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.And == input.And ||
                    this.And != null &&
                    this.And.SequenceEqual(input.And)
                ) && 
                (
                    this.Lhs == input.Lhs ||
                    (this.Lhs != null &&
                    this.Lhs.Equals(input.Lhs))
                ) && 
                (
                    this.Op == input.Op ||
                    (this.Op != null &&
                    this.Op.Equals(input.Op))
                ) && 
                (
                    this.Or == input.Or ||
                    this.Or != null &&
                    this.Or.SequenceEqual(input.Or)
                ) && 
                (
                    this.Rhs == input.Rhs ||
                    (this.Rhs != null &&
                    this.Rhs.Equals(input.Rhs))
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
                if (this.And != null)
                    hashCode = hashCode * 59 + this.And.GetHashCode();
                if (this.Lhs != null)
                    hashCode = hashCode * 59 + this.Lhs.GetHashCode();
                if (this.Op != null)
                    hashCode = hashCode * 59 + this.Op.GetHashCode();
                if (this.Or != null)
                    hashCode = hashCode * 59 + this.Or.GetHashCode();
                if (this.Rhs != null)
                    hashCode = hashCode * 59 + this.Rhs.GetHashCode();
                return hashCode;
            }
        }
    }

}
