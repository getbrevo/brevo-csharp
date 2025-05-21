# brevo_csharp.Model.GetCouponCollection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the collection. | 
**Name** | **string** | The name of the collection. | 
**DefaultCoupon** | **string** | The default coupon of the collection. | 
**CreatedAt** | **DateTime?** | Datetime on which the collection was created. | 
**TotalCoupons** | **long?** | Total number of coupons in the collection. | 
**RemainingCoupons** | **long?** | Number of coupons that have not been sent yet. | 
**ExpirationDate** | **DateTime?** | Expiration date for the coupon collection in RFC3339 format. | [optional] 
**RemainingDaysAlert** | **int?** | If present, an email notification is going to be sent the defined amount of days before the expiration date. | [optional] 
**RemainingCouponsAlert** | **int?** | If present, an email notification is going to be sent when the total number of available coupons falls below the defined threshold. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

