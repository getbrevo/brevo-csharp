# brevo_csharp.Model.BalanceLimit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BalanceDefinitionId** | **string** | balance definition ID | [optional] 
**ConstraintType** | **string** | Defines the type of constraint (e.g., transaction-based or amount-based). | [optional] 
**CreatedAt** | **string** | Timestamp of when the balance limit was created. | 
**DurationUnit** | **string** | Time unit for the balance limit (day, week, month, year). | [optional] 
**DurationValue** | **int?** | Number of time units the balance limit applies to. | [optional] 
**Id** | **string** | Unique identifier for the balance limit. | [optional] 
**SlidingSchedule** | **bool?** | Indicates if the limit resets periodically based on a sliding schedule. | [optional] 
**TransactionType** | **string** | Specifies whether the limit applies to credit or debit transactions. | [optional] 
**UpdatedAt** | **string** | Timestamp of the last update to the balance limit. | 
**Value** | **int?** | The maximum allowed value for the defined constraint. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

