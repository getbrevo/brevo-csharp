# brevo_csharp.Model.MainOrderPayload
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal?** | Total amount of the order | [optional] 
**Billing** | **Object** | Billing information for the order | [optional] 
**ContactId** | **long?** | Unique identifier for the contact | [optional] 
**Coupons** | **List&lt;string&gt;** | List of coupon codes applied to the order | [optional] 
**CreatedAt** | **DateTime?** | Timestamp when the order was created | [optional] 
**Email** | **string** | Email address associated with the order | [optional] 
**Id** | **string** | Unique identifier for the order | [optional] 
**Identifiers** | **Object** | Additional identifiers for the order | [optional] 
**Products** | [**List&lt;MainProductPayload&gt;**](MainProductPayload.md) | List of products in the order | [optional] 
**Status** | **string** | Current status of the order | [optional] 
**StoreId** | **string** | Identifier for the store where the order was placed | [optional] 
**UpdatedAt** | **DateTime?** | Timestamp when the order was last updated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

