# brevo_csharp.Model.BalanceOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal?** | Order amount (must not be zero). | 
**BalanceDefinitionId** | **string** | Optional unique identifier (UUID) of the associated balance definition. | [optional] 
**ContactId** | **int?** | Unique identifier of the contact placing the order (must be ≥ 1). | 
**CreatedAt** | **string** | RFC3339 timestamp indicating when the order was created. | 
**DueAt** | **string** | RFC3339 timestamp specifying when the order is due in the future. | 
**ExpiresAt** | **string** | Optional RFC3339 timestamp defining order expiration in the future. | [optional] 
**Id** | **string** | Unique identifier for the balance order. | [optional] 
**LoyaltyProgramId** | **string** | Unique identifier of the loyalty program associated with the order. | 
**Meta** | **Object** | Optional metadata associated with the order. | [optional] 
**ProcessedAt** | **string** | Optional RFC3339 timestamp indicating when the order was processed. | [optional] 
**Transactionid** | **string** | Optional reference to the associated transaction ID. | [optional] 
**UpdatedAt** | **string** | RFC3339 timestamp indicating the last update to the order. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

