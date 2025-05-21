# brevo_csharp.Model.AddContactToList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Emails** | **List&lt;string&gt;** | Mandatory if IDs, EXT_ID attributes are not passed, ignored otherwise. Emails to add to a list. You can pass a maximum of 150 emails for addition in one request. If you need to add the emails in bulk, please prefer /contacts/import api. | [optional] 
**Ids** | **List&lt;long?&gt;** | Mandatory if Emails, EXT_ID attributes are not passed, ignored otherwise. Emails to add to a list. You can pass a maximum of 150 ids for addition in one request. If you need to add the emails in bulk, please prefer /contacts/import api. | [optional] 
**ExtIds** | **List&lt;string&gt;** | Mandatory if Emails, IDs are not passed, ignored otherwise. Emails to add to a list. You can pass a maximum of 150 extIds for addition in one request. If you need to add the emails in bulk, please prefer /contacts/import api. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

