# brevo_csharp.Model.Body13
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of task | 
**Duration** | **long?** | Duration of task in milliseconds [1 minute &#x3D; 60000 ms] | [optional] 
**TaskTypeId** | **string** | Id for type of task e.g Call / Email / Meeting etc. | 
**Date** | **DateTime?** | Task due date and time | 
**Notes** | **string** | Notes added to a task | [optional] 
**Done** | **bool?** | Task marked as done | [optional] 
**AssignToId** | **string** | To assign a task to a user you can use either the account email or ID. | [optional] 
**ContactsIds** | **List&lt;int?&gt;** | Contact ids for contacts linked to this task | [optional] 
**DealsIds** | **List&lt;string&gt;** | Deal ids for deals a task is linked to | [optional] 
**CompaniesIds** | **List&lt;string&gt;** | Companies ids for companies a task is linked to | [optional] 
**Reminder** | [**TaskReminder**](TaskReminder.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

