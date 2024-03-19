# brevo_csharp.Model.SendWhatsappMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **int?** | ID of the template to send | [optional] 
**Text** | **string** | Text to be sent as message body (will be overridden if templateId is passed in the same request) | [optional] 
**SenderNumber** | **string** | WhatsApp Number with country code. Example, 85264318721 | 
**Params** | **Object** | Pass the set of attributes to customize the template. For example, {&quot;FNAME&quot;:&quot;Joe&quot;, &quot;LNAME&quot;:&quot;Doe&quot;}. | [optional] 
**ContactNumbers** | **List&lt;string&gt;** | List of phone numbers of the contacts | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

