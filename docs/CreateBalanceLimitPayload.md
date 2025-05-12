# brevo_csharp.Model.CreateBalanceLimitPayload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConstraintType** | **string** | Defines whether the limit applies to transaction count or amount. | 
**DurationUnit** | **string** | Unit of time for which the limit is applicable. | 
**DurationValue** | **int?** | Number of time units for the balance limit. | 
**SlidingSchedule** | **bool?** | Determines if the limit resets on a rolling schedule. | [optional] 
**TransactionType** | **string** | Specifies whether the limit applies to credit or debit transactions. | 
**Value** | **int?** | Maximum allowed value for the specified constraint type. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

