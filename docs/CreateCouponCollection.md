# brevo_csharp.Model.CreateCouponCollection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the coupons collection | 
**DefaultCoupon** | **string** | Default coupons collection name | 
**ExpirationDate** | **DateTime?** | Specify an expiration date for the coupon collection in RFC3339 format. Use null to remove the expiration date. | [optional] 
**RemainingDaysAlert** | **int?** | Send a notification alert (email) when the remaining days until the expiration date are equal or fall bellow this number. Use null to disable alerts. | [optional] 
**RemainingCouponsAlert** | **int?** | Send a notification alert (email) when the remaining coupons count is equal or fall bellow this number. Use null to disable alerts. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

