# brevo_csharp.Model.CreateTransactionPayload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoyaltySubscriptionId** | **string** | Unique identifier for the loyalty subscription (required unless &#x60;contactId&#x60; is provided). | [optional] 
**Amount** | **decimal?** | Transaction amount (must be provided). | 
**AutoComplete** | **bool?** | Whether the transaction should be automatically completed. | [optional] 
**BalanceDefinitionId** | **string** | Unique identifier (UUID) of the associated balance definition. | 
**BalanceExpiryInMinutes** | **int?** | Optional expiry time for the balance in minutes (must be greater than 0 if provided). | [optional] 
**ContactId** | **int?** | Unique identifier of the contact involved in the transaction (required unless &#x60;LoyaltySubscriptionId&#x60; is provided). | [optional] 
**EventTime** | **string** | Optional timestamp specifying when the transaction occurred. | [optional] 
**Meta** | **Object** | Optional metadata associated with the transaction. | [optional] 
**Ttl** | **int?** | Optional time-to-live for the transaction (must be greater than 0 if provided). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

