# brevo_csharp.Model.Transaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal?** | The transaction amount. | [optional] 
**BalanceDefinitionId** | **string** | Unique identifier (UUID) of the associated balance definition. | [optional] 
**CancelledAt** | **string** | Timestamp when the transaction was canceled (nullable). | [optional] 
**CompletedAt** | **string** | Timestamp when the transaction was completed (nullable). | [optional] 
**ContactId** | **int?** | Unique identifier of the contact associated with the transaction. | [optional] 
**CreatedAt** | **string** | Timestamp when the transaction was created. | [optional] 
**EventTime** | **string** | Optional timestamp indicating when the transaction event occurred. | [optional] 
**ExpirationDate** | **string** | Expiry date of the transaction (nullable). | [optional] 
**Id** | **string** | Unique identifier (UUID) of the transaction. | [optional] 
**LoyaltyProgramId** | **string** | Unique identifier (UUID) of the associated loyalty program. | [optional] 
**Meta** | **Object** | Optional metadata associated with the transaction. | [optional] 
**RejectReason** | **string** | Reason for rejection if the transaction was declined (nullable). | [optional] 
**RejectedAt** | **string** | Timestamp when the transaction was rejected (nullable). | [optional] 
**Status** | **string** | The current status of the transaction (e.g., pending, completed, rejected). | [optional] 
**UpdatedAt** | **string** | Timestamp when the transaction was last updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

