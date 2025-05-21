# brevo_csharp.Model.CreateBalanceDefinitionPayload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BalanceAvailabilityDurationModifier** | **string** | Defines when the balance expires within the selected duration. | [optional] 
**BalanceAvailabilityDurationUnit** | **string** | Unit of time for balance validity. | [optional] 
**BalanceAvailabilityDurationValue** | **int?** | Number of time units before the balance expires. | [optional] 
**BalanceExpirationDate** | **DateTime?** | Fixed expiration date (&#x60;dd/mm&#x60; format) as an alternative to duration-based expiry. | [optional] 
**BalanceOptionAmountOvertakingStrategy** | **string** | Defines whether partial credit is allowed when reaching max balance. | [optional] 
**BalanceOptionCreditRounding** | **string** | Defines rounding strategy for credit transactions. | [optional] 
**BalanceOptionDebitRounding** | **string** | Defines rounding strategy for debit transactions. | [optional] 
**Description** | **string** | Short description of the balance definition. | [optional] 
**ImageRef** | **string** | URL of an optional image reference. | [optional] 
**MaxAmount** | **decimal?** | Maximum allowable balance amount. | [optional] 
**MaxCreditAmountLimit** | **decimal?** | Maximum credit allowed per operation. | [optional] 
**MaxDebitAmountLimit** | **decimal?** | Maximum debit allowed per operation. | [optional] 
**Meta** | **Object** | Additional metadata for the balance definition. | [optional] 
**MinAmount** | **decimal?** | Minimum allowable balance amount. | [optional] 
**Name** | **string** | Name of the balance definition. | 
**Unit** | **string** | Unit of balance measurement. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

