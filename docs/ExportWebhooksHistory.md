# brevo_csharp.Model.ExportWebhooksHistory
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Days** | **int?** | Number of days in the past including today (positive integer). _Not compatible with &#39;startDate&#39; and &#39;endDate&#39;_ | [optional] 
**StartDate** | **string** | Mandatory if endDate is used. Starting date of the history (YYYY-MM-DD). Must be lower than equal to endDate | [optional] 
**EndDate** | **string** | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate | [optional] 
**Sort** | **string** | Sorting order of records (asc or desc) | [optional] 
**Type** | **string** | Filter the history based on webhook type | 
**Event** | **string** | Filter the history for a specific event type | 
**NotifyURL** | **string** | Webhook URL to receive CSV file link | 
**WebhookId** | **int?** | Filter the history for a specific webhook id | [optional] 
**Email** | **string** | Filter the history for a specific email | [optional] 
**MessageId** | **int?** | Filter the history for a specific message id. Applicable only for transactional webhooks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

