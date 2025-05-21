# brevo_csharp.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID of the order. | 
**CreatedAt** | **string** | Event occurrence UTC date-time (YYYY-MM-DDTHH:mm:ssZ), when order is actually created. | 
**UpdatedAt** | **string** | Event updated UTC date-time (YYYY-MM-DDTHH:mm:ssZ), when the status of the order is actually changed/updated. | 
**Status** | **string** | State of the order. | 
**Amount** | **decimal?** | Total amount of the order, including all shipping expenses, tax and the price of items. | 
**StoreId** | **string** | ID of store where the order is placed | [optional] 
**Identifiers** | [**OrderIdentifiers**](OrderIdentifiers.md) |  | [optional] 
**Products** | [**List&lt;OrderProducts&gt;**](OrderProducts.md) |  | 
**Billing** | [**OrderBilling**](OrderBilling.md) |  | [optional] 
**Coupons** | **List&lt;string&gt;** | Coupons applied to the order. Stored case insensitive. | [optional] 
**MetaInfo** | **Dictionary&lt;string, Object&gt;** | Meta data of order to store additional detal such as custom message, customer type, source. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

