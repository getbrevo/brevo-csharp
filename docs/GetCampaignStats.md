# brevo_csharp.Model.GetCampaignStats
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListId** | **long?** | List Id of email campaign (only in case of get email campaign(s)(not for global stats)) | [optional] 
**UniqueClicks** | **long?** | Number of unique clicks for the campaign | 
**Clickers** | **long?** | Number of total clicks for the campaign | 
**Complaints** | **long?** | Number of complaints (Spam reports) for the campaign | 
**Delivered** | **long?** | Number of delivered emails for the campaign | 
**Sent** | **long?** | Number of sent emails for the campaign | 
**SoftBounces** | **long?** | Number of softbounce for the campaign | 
**HardBounces** | **long?** | Number of harbounce for the campaign | 
**UniqueViews** | **long?** | Number of unique openings for the campaign | 
**TrackableViews** | **long?** | Recipients without any privacy protection option enabled in their email client | 
**TrackableViewsRate** | **float?** | Rate of recipients without any privacy protection option enabled in their email client | [optional] 
**EstimatedViews** | **long?** | Rate of recipients without any privacy protection option enabled in their email client, applied to all delivered emails | [optional] 
**Unsubscriptions** | **long?** | Number of unsubscription for the campaign | 
**Viewed** | **long?** | Number of openings for the campaign | 
**Deferred** | **long?** | Number of deferred emails for the campaign | [optional] 
**ReturnBounce** | **long?** | Total number of non-delivered campaigns for a particular campaign id. | [optional] 
**OpensRate** | **float?** | Percentage of recipients who open the email out of your total number of recipients. Depending on your Campaign settings, they may include Apple MPP opens. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

