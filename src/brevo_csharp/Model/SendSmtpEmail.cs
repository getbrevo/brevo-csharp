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
    /// SendSmtpEmail
    /// </summary>
    [DataContract]
    public partial class SendSmtpEmail :  IEquatable<SendSmtpEmail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendSmtpEmail" /> class.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="to">Mandatory if messageVersions are not passed, ignored if messageVersions are passed. List of email addresses and names (optional) of the recipients. For example, [{\&quot;name\&quot;:\&quot;Jimmy\&quot;, \&quot;email\&quot;:\&quot;jimmy98@example.com\&quot;}, {\&quot;name\&quot;:\&quot;Joe\&quot;, \&quot;email\&quot;:\&quot;joe@example.com\&quot;}].</param>
        /// <param name="bcc">List of email addresses and names (optional) of the recipients in bcc.</param>
        /// <param name="cc">List of email addresses and names (optional) of the recipients in cc.</param>
        /// <param name="htmlContent">HTML body of the message ( Mandatory if &#39;templateId&#39; is not passed, ignored if &#39;templateId&#39; is passed ).</param>
        /// <param name="textContent">Plain Text body of the message ( Ignored if &#39;templateId&#39; is passed ).</param>
        /// <param name="subject">Subject of the message. Mandatory if &#39;templateId&#39; is not passed.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="attachment">Pass the absolute URL (no local file) or the base64 content of the attachment along with the attachment name (Mandatory if attachment content is passed). For example, &#x60;[{\&quot;url\&quot;:\&quot;https://attachment.domain.com/myAttachmentFromUrl.jpg\&quot;, \&quot;name\&quot;:\&quot;myAttachmentFromUrl.jpg\&quot;}, {\&quot;content\&quot;:\&quot;base64 example content\&quot;, \&quot;name\&quot;:\&quot;myAttachmentFromBase64.jpg\&quot;}]&#x60;. Allowed extensions for attachment file: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub, eps, odt, mp3, m4a, m4v, wma, ogg, flac, wav, aif, aifc, aiff, mp4, mov, avi, mkv, mpeg, mpg, wmv, pkpass and xlsm ( If &#39;templateId&#39; is passed and is in New Template Language format then both attachment url and content are accepted. If template is in Old template Language format, then &#39;attachment&#39; is ignored ).</param>
        /// <param name="headers">Pass the set of custom headers (not the standard headers) that shall be sent along the mail headers in the original email. &#39;sender.ip&#39; header can be set (only for dedicated ip users) to mention the IP to be used for sending transactional emails. Headers are allowed in &#x60;This-Case-Only&#x60; (i.e. words separated by hyphen with first letter of each word in capital letter), they will be converted to such case styling if not in this format in the request payload. For example, &#x60;{\&quot;sender.ip\&quot;:\&quot;1.2.3.4\&quot;, \&quot;X-Mailin-custom\&quot;:\&quot;some_custom_header\&quot;, \&quot;idempotencyKey\&quot;:\&quot;abc-123\&quot;}&#x60;..</param>
        /// <param name="templateId">Id of the template..</param>
        /// <param name="_params">Pass the set of attributes to customize the template. For example, {\&quot;FNAME\&quot;:\&quot;Joe\&quot;, \&quot;LNAME\&quot;:\&quot;Doe\&quot;}. It&#39;s considered only if template is in New Template Language format..</param>
        /// <param name="messageVersions">You can customize and send out multiple versions of a mail. templateId can be customized only if global parameter contains templateId. htmlContent and textContent can be customized only if any of the two, htmlContent or textContent, is present in global parameters. Some global parameters such as **to(mandatory), bcc, cc, replyTo, subject** can also be customized specific to each version. Total number of recipients in one API request must not exceed 2000. However, you can still pass upto 99 recipients maximum in one message version. The size of individual params in all the messageVersions shall not exceed 100 KB limit and that of cumulative params shall not exceed 1000 KB. You can follow this **step-by-step guide** on how to use **messageVersions** to batch send emails - https://developers.brevo.com/docs/batch-send-transactional-emails.</param>
        /// <param name="tags">Tag your emails to find them more easily.</param>
        /// <param name="scheduledAt">UTC date-time on which the email has to schedule (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for scheduling. There can be an expected delay of +5 minutes in scheduled email delivery..</param>
        /// <param name="batchId">Valid UUIDv4 batch id to identify the scheduled batches transactional email. If not passed we will create a valid UUIDv4 batch id at our end..</param>
        public SendSmtpEmail(SendSmtpEmailSender sender = default(SendSmtpEmailSender), List<SendSmtpEmailTo> to = default(List<SendSmtpEmailTo>), List<SendSmtpEmailBcc> bcc = default(List<SendSmtpEmailBcc>), List<SendSmtpEmailCc> cc = default(List<SendSmtpEmailCc>), string htmlContent = default(string), string textContent = default(string), string subject = default(string), SendSmtpEmailReplyTo replyTo = default(SendSmtpEmailReplyTo), List<SendSmtpEmailAttachment> attachment = default(List<SendSmtpEmailAttachment>), Object headers = default(Object), long? templateId = default(long?), Object _params = default(Object), List<SendSmtpEmailMessageVersions> messageVersions = default(List<SendSmtpEmailMessageVersions>), List<string> tags = default(List<string>), DateTime? scheduledAt = default(DateTime?), string batchId = default(string))
        {
            this.Sender = sender;
            this.To = to;
            this.Bcc = bcc;
            this.Cc = cc;
            this.HtmlContent = htmlContent;
            this.TextContent = textContent;
            this.Subject = subject;
            this.ReplyTo = replyTo;
            this.Attachment = attachment;
            this.Headers = headers;
            this.TemplateId = templateId;
            this.Params = _params;
            this.MessageVersions = messageVersions;
            this.Tags = tags;
            this.ScheduledAt = scheduledAt;
            this.BatchId = batchId;
        }
        
        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public SendSmtpEmailSender Sender { get; set; }

        /// <summary>
        /// Mandatory if messageVersions are not passed, ignored if messageVersions are passed. List of email addresses and names (optional) of the recipients. For example, [{\&quot;name\&quot;:\&quot;Jimmy\&quot;, \&quot;email\&quot;:\&quot;jimmy98@example.com\&quot;}, {\&quot;name\&quot;:\&quot;Joe\&quot;, \&quot;email\&quot;:\&quot;joe@example.com\&quot;}]
        /// </summary>
        /// <value>Mandatory if messageVersions are not passed, ignored if messageVersions are passed. List of email addresses and names (optional) of the recipients. For example, [{\&quot;name\&quot;:\&quot;Jimmy\&quot;, \&quot;email\&quot;:\&quot;jimmy98@example.com\&quot;}, {\&quot;name\&quot;:\&quot;Joe\&quot;, \&quot;email\&quot;:\&quot;joe@example.com\&quot;}]</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<SendSmtpEmailTo> To { get; set; }

        /// <summary>
        /// List of email addresses and names (optional) of the recipients in bcc
        /// </summary>
        /// <value>List of email addresses and names (optional) of the recipients in bcc</value>
        [DataMember(Name="bcc", EmitDefaultValue=false)]
        public List<SendSmtpEmailBcc> Bcc { get; set; }

        /// <summary>
        /// List of email addresses and names (optional) of the recipients in cc
        /// </summary>
        /// <value>List of email addresses and names (optional) of the recipients in cc</value>
        [DataMember(Name="cc", EmitDefaultValue=false)]
        public List<SendSmtpEmailCc> Cc { get; set; }

        /// <summary>
        /// HTML body of the message ( Mandatory if &#39;templateId&#39; is not passed, ignored if &#39;templateId&#39; is passed )
        /// </summary>
        /// <value>HTML body of the message ( Mandatory if &#39;templateId&#39; is not passed, ignored if &#39;templateId&#39; is passed )</value>
        [DataMember(Name="htmlContent", EmitDefaultValue=false)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// Plain Text body of the message ( Ignored if &#39;templateId&#39; is passed )
        /// </summary>
        /// <value>Plain Text body of the message ( Ignored if &#39;templateId&#39; is passed )</value>
        [DataMember(Name="textContent", EmitDefaultValue=false)]
        public string TextContent { get; set; }

        /// <summary>
        /// Subject of the message. Mandatory if &#39;templateId&#39; is not passed
        /// </summary>
        /// <value>Subject of the message. Mandatory if &#39;templateId&#39; is not passed</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets ReplyTo
        /// </summary>
        [DataMember(Name="replyTo", EmitDefaultValue=false)]
        public SendSmtpEmailReplyTo ReplyTo { get; set; }

        /// <summary>
        /// Pass the absolute URL (no local file) or the base64 content of the attachment along with the attachment name (Mandatory if attachment content is passed). For example, &#x60;[{\&quot;url\&quot;:\&quot;https://attachment.domain.com/myAttachmentFromUrl.jpg\&quot;, \&quot;name\&quot;:\&quot;myAttachmentFromUrl.jpg\&quot;}, {\&quot;content\&quot;:\&quot;base64 example content\&quot;, \&quot;name\&quot;:\&quot;myAttachmentFromBase64.jpg\&quot;}]&#x60;. Allowed extensions for attachment file: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub, eps, odt, mp3, m4a, m4v, wma, ogg, flac, wav, aif, aifc, aiff, mp4, mov, avi, mkv, mpeg, mpg, wmv, pkpass and xlsm ( If &#39;templateId&#39; is passed and is in New Template Language format then both attachment url and content are accepted. If template is in Old template Language format, then &#39;attachment&#39; is ignored )
        /// </summary>
        /// <value>Pass the absolute URL (no local file) or the base64 content of the attachment along with the attachment name (Mandatory if attachment content is passed). For example, &#x60;[{\&quot;url\&quot;:\&quot;https://attachment.domain.com/myAttachmentFromUrl.jpg\&quot;, \&quot;name\&quot;:\&quot;myAttachmentFromUrl.jpg\&quot;}, {\&quot;content\&quot;:\&quot;base64 example content\&quot;, \&quot;name\&quot;:\&quot;myAttachmentFromBase64.jpg\&quot;}]&#x60;. Allowed extensions for attachment file: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub, eps, odt, mp3, m4a, m4v, wma, ogg, flac, wav, aif, aifc, aiff, mp4, mov, avi, mkv, mpeg, mpg, wmv, pkpass and xlsm ( If &#39;templateId&#39; is passed and is in New Template Language format then both attachment url and content are accepted. If template is in Old template Language format, then &#39;attachment&#39; is ignored )</value>
        [DataMember(Name="attachment", EmitDefaultValue=false)]
        public List<SendSmtpEmailAttachment> Attachment { get; set; }

        /// <summary>
        /// Pass the set of custom headers (not the standard headers) that shall be sent along the mail headers in the original email. &#39;sender.ip&#39; header can be set (only for dedicated ip users) to mention the IP to be used for sending transactional emails. Headers are allowed in &#x60;This-Case-Only&#x60; (i.e. words separated by hyphen with first letter of each word in capital letter), they will be converted to such case styling if not in this format in the request payload. For example, &#x60;{\&quot;sender.ip\&quot;:\&quot;1.2.3.4\&quot;, \&quot;X-Mailin-custom\&quot;:\&quot;some_custom_header\&quot;, \&quot;idempotencyKey\&quot;:\&quot;abc-123\&quot;}&#x60;.
        /// </summary>
        /// <value>Pass the set of custom headers (not the standard headers) that shall be sent along the mail headers in the original email. &#39;sender.ip&#39; header can be set (only for dedicated ip users) to mention the IP to be used for sending transactional emails. Headers are allowed in &#x60;This-Case-Only&#x60; (i.e. words separated by hyphen with first letter of each word in capital letter), they will be converted to such case styling if not in this format in the request payload. For example, &#x60;{\&quot;sender.ip\&quot;:\&quot;1.2.3.4\&quot;, \&quot;X-Mailin-custom\&quot;:\&quot;some_custom_header\&quot;, \&quot;idempotencyKey\&quot;:\&quot;abc-123\&quot;}&#x60;.</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Object Headers { get; set; }

        /// <summary>
        /// Id of the template.
        /// </summary>
        /// <value>Id of the template.</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// Pass the set of attributes to customize the template. For example, {\&quot;FNAME\&quot;:\&quot;Joe\&quot;, \&quot;LNAME\&quot;:\&quot;Doe\&quot;}. It&#39;s considered only if template is in New Template Language format.
        /// </summary>
        /// <value>Pass the set of attributes to customize the template. For example, {\&quot;FNAME\&quot;:\&quot;Joe\&quot;, \&quot;LNAME\&quot;:\&quot;Doe\&quot;}. It&#39;s considered only if template is in New Template Language format.</value>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Object Params { get; set; }

        /// <summary>
        /// You can customize and send out multiple versions of a mail. templateId can be customized only if global parameter contains templateId. htmlContent and textContent can be customized only if any of the two, htmlContent or textContent, is present in global parameters. Some global parameters such as **to(mandatory), bcc, cc, replyTo, subject** can also be customized specific to each version. Total number of recipients in one API request must not exceed 2000. However, you can still pass upto 99 recipients maximum in one message version. The size of individual params in all the messageVersions shall not exceed 100 KB limit and that of cumulative params shall not exceed 1000 KB. You can follow this **step-by-step guide** on how to use **messageVersions** to batch send emails - https://developers.brevo.com/docs/batch-send-transactional-emails
        /// </summary>
        /// <value>You can customize and send out multiple versions of a mail. templateId can be customized only if global parameter contains templateId. htmlContent and textContent can be customized only if any of the two, htmlContent or textContent, is present in global parameters. Some global parameters such as **to(mandatory), bcc, cc, replyTo, subject** can also be customized specific to each version. Total number of recipients in one API request must not exceed 2000. However, you can still pass upto 99 recipients maximum in one message version. The size of individual params in all the messageVersions shall not exceed 100 KB limit and that of cumulative params shall not exceed 1000 KB. You can follow this **step-by-step guide** on how to use **messageVersions** to batch send emails - https://developers.brevo.com/docs/batch-send-transactional-emails</value>
        [DataMember(Name="messageVersions", EmitDefaultValue=false)]
        public List<SendSmtpEmailMessageVersions> MessageVersions { get; set; }

        /// <summary>
        /// Tag your emails to find them more easily
        /// </summary>
        /// <value>Tag your emails to find them more easily</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// UTC date-time on which the email has to schedule (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for scheduling. There can be an expected delay of +5 minutes in scheduled email delivery.
        /// </summary>
        /// <value>UTC date-time on which the email has to schedule (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for scheduling. There can be an expected delay of +5 minutes in scheduled email delivery.</value>
        [DataMember(Name="scheduledAt", EmitDefaultValue=false)]
        public DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// Valid UUIDv4 batch id to identify the scheduled batches transactional email. If not passed we will create a valid UUIDv4 batch id at our end.
        /// </summary>
        /// <value>Valid UUIDv4 batch id to identify the scheduled batches transactional email. If not passed we will create a valid UUIDv4 batch id at our end.</value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendSmtpEmail {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  HtmlContent: ").Append(HtmlContent).Append("\n");
            sb.Append("  TextContent: ").Append(TextContent).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  MessageVersions: ").Append(MessageVersions).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
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
            return this.Equals(input as SendSmtpEmail);
        }

        /// <summary>
        /// Returns true if SendSmtpEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of SendSmtpEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendSmtpEmail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    this.Bcc != null &&
                    this.Bcc.SequenceEqual(input.Bcc)
                ) && 
                (
                    this.Cc == input.Cc ||
                    this.Cc != null &&
                    this.Cc.SequenceEqual(input.Cc)
                ) && 
                (
                    this.HtmlContent == input.HtmlContent ||
                    (this.HtmlContent != null &&
                    this.HtmlContent.Equals(input.HtmlContent))
                ) && 
                (
                    this.TextContent == input.TextContent ||
                    (this.TextContent != null &&
                    this.TextContent.Equals(input.TextContent))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.Attachment == input.Attachment ||
                    this.Attachment != null &&
                    this.Attachment.SequenceEqual(input.Attachment)
                ) && 
                (
                    this.Headers == input.Headers ||
                    (this.Headers != null &&
                    this.Headers.Equals(input.Headers))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
                ) && 
                (
                    this.MessageVersions == input.MessageVersions ||
                    this.MessageVersions != null &&
                    this.MessageVersions.SequenceEqual(input.MessageVersions)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
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
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.HtmlContent != null)
                    hashCode = hashCode * 59 + this.HtmlContent.GetHashCode();
                if (this.TextContent != null)
                    hashCode = hashCode * 59 + this.TextContent.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.Attachment != null)
                    hashCode = hashCode * 59 + this.Attachment.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.MessageVersions != null)
                    hashCode = hashCode * 59 + this.MessageVersions.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ScheduledAt != null)
                    hashCode = hashCode * 59 + this.ScheduledAt.GetHashCode();
                if (this.BatchId != null)
                    hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                return hashCode;
            }
        }
    }

}
