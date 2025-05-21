# brevo_csharp.Model.CreateOrderPayload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal?** | Order amount (must be non-zero). | 
**BalanceDefinitionId** | **string** | Unique identifier (UUID) of the associated balance definition. | 
**ContactId** | **int?** | Unique identifier of the contact placing the order (must be ≥ 1). | 
**DueAt** | **string** | RFC3339 timestamp specifying when the order is due. | 
**ExpiresAt** | **string** | Optional RFC3339 timestamp defining order expiration. | [optional] 
**Meta** | **Object** | Optional metadata associated with the order. | [optional] 
**Source** | **string** | Specifies the origin of the order (&#x60;engine&#x60; or &#x60;user&#x60;). | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

