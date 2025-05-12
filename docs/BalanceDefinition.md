# brevo_csharp.Model.BalanceDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BalanceAvailabilityDurationModifier** | **string** | startOfPeriod depicts the balancy expiry on start of day/week/month/year. endOfPeriod depicts the balancy expiry on end of day/week/month/year | [optional] 
**BalanceAvailabilityDurationUnit** | **string** | Unit of time for the balance&#39;s availability (e.g., day/week/month/year). | [optional] 
**BalanceAvailabilityDurationValue** | **int?** | Number of days/weeks/month/year for balance expiry | [optional] 
**BalanceExpirationDate** | **DateTime?** | Date when the balance expires and can no longer be used, in dd/mm format. The balance will be expired when this date appears next in the calendar and only one of balanceExpirationDate or balance availability fields can be used. | [optional] 
**BalanceOptionAmountOvertakingStrategy** | **string** | Partial enables partial credit of balance if maximum balance limit is reaching. Strict enables rejection of transaction if it will breach the max credit amount limit. | [optional] 
**BalanceOptionCreditRounding** | **string** | Rounding strategy for credit transactions. | [optional] 
**BalanceOptionDebitRounding** | **string** | Rounding strategy for debit transactions. | [optional] 
**CreatedAt** | **DateTime?** | Timestamp of balance definition creation. | [optional] 
**DeletedAt** | **string** | Timestamp of balance definition deletion (nullable). | [optional] 
**Description** | **string** | Short description of the balance definition. | [optional] 
**Id** | **string** | Unique identifier for the balance definition. | [optional] 
**ImageRef** | **string** | Optional image reference URL. | [optional] 
**MaxAmount** | **decimal?** | Maximum allowable balance. | [optional] 
**MaxCreditAmountLimit** | **decimal?** | Max credit allowed per operation. | [optional] 
**MaxDebitAmountLimit** | **decimal?** | Max debit allowed per operation. | [optional] 
**Meta** | **Dictionary&lt;string, Object&gt;** | Additional metadata for the balance definition. | [optional] 
**MinAmount** | **decimal?** | Minimum allowable balance. | [optional] 
**Name** | **string** | Name of the balance definition. | [optional] 
**Unit** | **string** | Unit of balance (e.g., points, currency). | [optional] 
**UpdatedAt** | **string** | Timestamp of the last update. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

