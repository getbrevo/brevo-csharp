# brevo_csharp.Model.UpdateTierGroupRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the tier group | 
**TierOrder** | **List&lt;Guid?&gt;** | Order of the tiers in the group in ascending order | 
**UpgradeStrategy** | **string** | Select real_time to upgrade tier on real time balance updates. Select membership_anniversary to upgrade tier on subscription anniversary. Select tier_anniversary to upgrade tier on tier anniversary. | [default to UpgradeStrategyEnum.Realtime]
**DowngradeStrategy** | **string** | Select real_time to downgrade tier on real time balance updates. Select membership_anniversary to downgrade tier on subscription anniversary. Select tier_anniversary to downgrade tier on tier anniversary. | [default to DowngradeStrategyEnum.Realtime]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

