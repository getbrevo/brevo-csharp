# brevo_csharp.Model.UpdateCouponCollection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultCoupon** | **string** | A default coupon to be used in case there are no coupons left | [optional] 
**ExpirationDate** | **DateTime?** | Specify an expiration date for the coupon collection in RFC3339 format. Use null to remove the expiration date. | [optional] 
**RemainingDaysAlert** | **int?** | Send a notification alert (email) when the remaining days until the expiration date are equal or fall bellow this number. Use null to disable alerts. | [optional] 
**RemainingCouponsAlert** | **int?** | Send a notification alert (email) when the remaining coupons count is equal or fall bellow this number. Use null to disable alerts. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

