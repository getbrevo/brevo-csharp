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
    /// Body11
    /// </summary>
    [DataContract]
    public partial class Body11 :  IEquatable<Body11>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body11" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Body11() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Body11" /> class.
        /// </summary>
        /// <param name="visitorId">visitor’s ID received &lt;a href&#x3D;\&quot;https://developers.brevo.com/docs/conversations-webhooks\&quot;&gt;from a webhook&lt;/a&gt; or generated by you to &lt;a href&#x3D;\&quot;https://developers.brevo.com/docs/customize-the-widget#identifying-existing-users\&quot;&gt;bind existing user account to Conversations&lt;/a&gt; (required).</param>
        /// <param name="text">message text (required).</param>
        /// <param name="agentId">agent ID. It can be found on agent’s page or received &lt;a href&#x3D;\&quot;https://developers.brevo.com/docs/conversations-webhooks\&quot;&gt;from a webhook&lt;/a&gt;. Alternatively, you can use &#x60;agentEmail&#x60; + &#x60;agentName&#x60; + &#x60;receivedFrom&#x60; instead (all 3 fields required)..</param>
        /// <param name="receivedFrom">mark your messages to distinguish messages created by you from the others..</param>
        /// <param name="agentEmail">agent email. When sending messages from a standalone system, it’s hard to maintain a 1-to-1 relationship between the users of both systems. In this case, an agent can be specified by their email address..</param>
        /// <param name="agentName">agent name.</param>
        public Body11(string visitorId = default(string), string text = default(string), string agentId = default(string), string receivedFrom = default(string), string agentEmail = default(string), string agentName = default(string))
        {
            // to ensure "visitorId" is required (not null)
            if (visitorId == null)
            {
                throw new InvalidDataException("visitorId is a required property for Body11 and cannot be null");
            }
            else
            {
                this.VisitorId = visitorId;
            }
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for Body11 and cannot be null");
            }
            else
            {
                this.Text = text;
            }
            this.AgentId = agentId;
            this.ReceivedFrom = receivedFrom;
            this.AgentEmail = agentEmail;
            this.AgentName = agentName;
        }
        
        /// <summary>
        /// visitor’s ID received &lt;a href&#x3D;\&quot;https://developers.brevo.com/docs/conversations-webhooks\&quot;&gt;from a webhook&lt;/a&gt; or generated by you to &lt;a href&#x3D;\&quot;https://developers.brevo.com/docs/customize-the-widget#identifying-existing-users\&quot;&gt;bind existing user account to Conversations&lt;/a&gt;
        /// </summary>
        /// <value>visitor’s ID received &lt;a href&#x3D;\&quot;https://developers.brevo.com/docs/conversations-webhooks\&quot;&gt;from a webhook&lt;/a&gt; or generated by you to &lt;a href&#x3D;\&quot;https://developers.brevo.com/docs/customize-the-widget#identifying-existing-users\&quot;&gt;bind existing user account to Conversations&lt;/a&gt;</value>
        [DataMember(Name="visitorId", EmitDefaultValue=false)]
        public string VisitorId { get; set; }

        /// <summary>
        /// message text
        /// </summary>
        /// <value>message text</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// agent ID. It can be found on agent’s page or received &lt;a href&#x3D;\&quot;https://developers.brevo.com/docs/conversations-webhooks\&quot;&gt;from a webhook&lt;/a&gt;. Alternatively, you can use &#x60;agentEmail&#x60; + &#x60;agentName&#x60; + &#x60;receivedFrom&#x60; instead (all 3 fields required).
        /// </summary>
        /// <value>agent ID. It can be found on agent’s page or received &lt;a href&#x3D;\&quot;https://developers.brevo.com/docs/conversations-webhooks\&quot;&gt;from a webhook&lt;/a&gt;. Alternatively, you can use &#x60;agentEmail&#x60; + &#x60;agentName&#x60; + &#x60;receivedFrom&#x60; instead (all 3 fields required).</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// mark your messages to distinguish messages created by you from the others.
        /// </summary>
        /// <value>mark your messages to distinguish messages created by you from the others.</value>
        [DataMember(Name="receivedFrom", EmitDefaultValue=false)]
        public string ReceivedFrom { get; set; }

        /// <summary>
        /// agent email. When sending messages from a standalone system, it’s hard to maintain a 1-to-1 relationship between the users of both systems. In this case, an agent can be specified by their email address.
        /// </summary>
        /// <value>agent email. When sending messages from a standalone system, it’s hard to maintain a 1-to-1 relationship between the users of both systems. In this case, an agent can be specified by their email address.</value>
        [DataMember(Name="agentEmail", EmitDefaultValue=false)]
        public string AgentEmail { get; set; }

        /// <summary>
        /// agent name
        /// </summary>
        /// <value>agent name</value>
        [DataMember(Name="agentName", EmitDefaultValue=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body11 {\n");
            sb.Append("  VisitorId: ").Append(VisitorId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  ReceivedFrom: ").Append(ReceivedFrom).Append("\n");
            sb.Append("  AgentEmail: ").Append(AgentEmail).Append("\n");
            sb.Append("  AgentName: ").Append(AgentName).Append("\n");
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
            return this.Equals(input as Body11);
        }

        /// <summary>
        /// Returns true if Body11 instances are equal
        /// </summary>
        /// <param name="input">Instance of Body11 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body11 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VisitorId == input.VisitorId ||
                    (this.VisitorId != null &&
                    this.VisitorId.Equals(input.VisitorId))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.ReceivedFrom == input.ReceivedFrom ||
                    (this.ReceivedFrom != null &&
                    this.ReceivedFrom.Equals(input.ReceivedFrom))
                ) && 
                (
                    this.AgentEmail == input.AgentEmail ||
                    (this.AgentEmail != null &&
                    this.AgentEmail.Equals(input.AgentEmail))
                ) && 
                (
                    this.AgentName == input.AgentName ||
                    (this.AgentName != null &&
                    this.AgentName.Equals(input.AgentName))
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
                if (this.VisitorId != null)
                    hashCode = hashCode * 59 + this.VisitorId.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.ReceivedFrom != null)
                    hashCode = hashCode * 59 + this.ReceivedFrom.GetHashCode();
                if (this.AgentEmail != null)
                    hashCode = hashCode * 59 + this.AgentEmail.GetHashCode();
                if (this.AgentName != null)
                    hashCode = hashCode * 59 + this.AgentName.GetHashCode();
                return hashCode;
            }
        }
    }

}
