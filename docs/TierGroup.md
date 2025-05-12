# brevo_csharp.Model.TierGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | Tier group unique identifier | [optional] 
**Name** | **string** | Tier group name | [optional] 
**TierOrder** | **List&lt;Guid?&gt;** | Order of the tiers in the group in ascending order | [optional] 
**LoyaltyProgramId** | **Guid?** | Associated loyalty program Id | [optional] 
**UpgradeStrategy** | **string** | Select real_time to upgrade tier on real time balance updates. Select membership_anniversary to upgrade tier on subscription anniversary. Select tier_anniversary to upgrade tier on tier anniversary. | [optional] [default to UpgradeStrategyEnum.Realtime]
**DowngradeStrategy** | **string** | Select real_time to downgrade tier on real time balance updates. Select membership_anniversary to downgrade tier on subscription anniversary. Select tier_anniversary to downgrade tier on tier anniversary. | [optional] [default to DowngradeStrategyEnum.Realtime]
**CreatedAt** | **DateTime?** | Timestamp when the tier group was created | [optional] 
**UpdatedAt** | **DateTime?** | Timestamp when the tier group was last updated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

