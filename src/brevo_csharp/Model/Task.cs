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
    /// Task Details
    /// </summary>
    [DataContract]
    public partial class Task :  IEquatable<Task>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Task() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="id">Unique task id.</param>
        /// <param name="taskTypeId">Id for type of task e.g Call / Email / Meeting etc. (required).</param>
        /// <param name="name">Name of task (required).</param>
        /// <param name="contactsIds">Contact ids for contacts linked to this task.</param>
        /// <param name="dealsIds">Deal ids for deals a task is linked to.</param>
        /// <param name="companiesIds">Companies ids for companies a task is linked to.</param>
        public Task(string id = default(string), string taskTypeId = default(string), string name = default(string), List<int?> contactsIds = default(List<int?>), List<string> dealsIds = default(List<string>), List<string> companiesIds = default(List<string>))
        {
            // to ensure "taskTypeId" is required (not null)
            if (taskTypeId == null)
            {
                throw new InvalidDataException("taskTypeId is a required property for Task and cannot be null");
            }
            else
            {
                this.TaskTypeId = taskTypeId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Task and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Id = id;
            this.ContactsIds = contactsIds;
            this.DealsIds = dealsIds;
            this.CompaniesIds = companiesIds;
        }
        
        /// <summary>
        /// Unique task id
        /// </summary>
        /// <value>Unique task id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Id for type of task e.g Call / Email / Meeting etc.
        /// </summary>
        /// <value>Id for type of task e.g Call / Email / Meeting etc.</value>
        [DataMember(Name="taskTypeId", EmitDefaultValue=false)]
        public string TaskTypeId { get; set; }

        /// <summary>
        /// Name of task
        /// </summary>
        /// <value>Name of task</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Contact ids for contacts linked to this task
        /// </summary>
        /// <value>Contact ids for contacts linked to this task</value>
        [DataMember(Name="contactsIds", EmitDefaultValue=false)]
        public List<int?> ContactsIds { get; set; }

        /// <summary>
        /// Deal ids for deals a task is linked to
        /// </summary>
        /// <value>Deal ids for deals a task is linked to</value>
        [DataMember(Name="dealsIds", EmitDefaultValue=false)]
        public List<string> DealsIds { get; set; }

        /// <summary>
        /// Companies ids for companies a task is linked to
        /// </summary>
        /// <value>Companies ids for companies a task is linked to</value>
        [DataMember(Name="companiesIds", EmitDefaultValue=false)]
        public List<string> CompaniesIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TaskTypeId: ").Append(TaskTypeId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactsIds: ").Append(ContactsIds).Append("\n");
            sb.Append("  DealsIds: ").Append(DealsIds).Append("\n");
            sb.Append("  CompaniesIds: ").Append(CompaniesIds).Append("\n");
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
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="input">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task input)
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
                    this.TaskTypeId == input.TaskTypeId ||
                    (this.TaskTypeId != null &&
                    this.TaskTypeId.Equals(input.TaskTypeId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ContactsIds == input.ContactsIds ||
                    this.ContactsIds != null &&
                    this.ContactsIds.SequenceEqual(input.ContactsIds)
                ) && 
                (
                    this.DealsIds == input.DealsIds ||
                    this.DealsIds != null &&
                    this.DealsIds.SequenceEqual(input.DealsIds)
                ) && 
                (
                    this.CompaniesIds == input.CompaniesIds ||
                    this.CompaniesIds != null &&
                    this.CompaniesIds.SequenceEqual(input.CompaniesIds)
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
                if (this.TaskTypeId != null)
                    hashCode = hashCode * 59 + this.TaskTypeId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ContactsIds != null)
                    hashCode = hashCode * 59 + this.ContactsIds.GetHashCode();
                if (this.DealsIds != null)
                    hashCode = hashCode * 59 + this.DealsIds.GetHashCode();
                if (this.CompaniesIds != null)
                    hashCode = hashCode * 59 + this.CompaniesIds.GetHashCode();
                return hashCode;
            }
        }
    }

}
