# brevo_csharp.Model.SendSmtpEmailMessageVersions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | [**List&lt;SendSmtpEmailTo1&gt;**](SendSmtpEmailTo1.md) | List of email addresses and names (_optional_) of the recipients. For example, [{&quot;name&quot;:&quot;Jimmy&quot;, &quot;email&quot;:&quot;jimmy98@example.com&quot;}, {&quot;name&quot;:&quot;Joe&quot;, &quot;email&quot;:&quot;joe@example.com&quot;}] | 
**Params** | **Dictionary&lt;string, Object&gt;** | Pass the set of attributes to customize the template. For example, {&quot;FNAME&quot;:&quot;Joe&quot;, &quot;LNAME&quot;:&quot;Doe&quot;}. It&#39;s considered only if template is in New Template Language format. | [optional] 
**Bcc** | [**List&lt;SendSmtpEmailBcc&gt;**](SendSmtpEmailBcc.md) | List of email addresses and names (optional) of the recipients in bcc | [optional] 
**Cc** | [**List&lt;SendSmtpEmailCc&gt;**](SendSmtpEmailCc.md) | List of email addresses and names (optional) of the recipients in cc | [optional] 
**ReplyTo** | [**SendSmtpEmailReplyTo1**](SendSmtpEmailReplyTo1.md) |  | [optional] 
**Subject** | **string** | Custom subject specific to message version  | [optional] 
**HtmlContent** | **string** | HTML body of the message. **Mandatory if &#39;templateId&#39; is not passed, ignored if &#39;templateId&#39; is passed**  | [optional] 
**TextContent** | **string** | Plain Text body of the message. **Ignored if &#39;templateId&#39; is passed**  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

