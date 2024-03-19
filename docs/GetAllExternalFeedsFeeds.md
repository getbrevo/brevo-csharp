# brevo_csharp.Model.GetAllExternalFeedsFeeds
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the feed | 
**Name** | **string** | Name of the feed | 
**Url** | **string** | URL of the feed | 
**AuthType** | **string** | Auth type of the feed: * &#x60;basic&#x60; * &#x60;token&#x60; * &#x60;noAuth&#x60;  | 
**Username** | **string** | Username for authType &#x60;basic&#x60; | [optional] 
**Password** | **string** | Password for authType &#x60;basic&#x60; | [optional] 
**Token** | **string** | Token for authType &#x60;token&#x60; | [optional] 
**Headers** | [**List&lt;GetExternalFeedByUUIDHeaders&gt;**](GetExternalFeedByUUIDHeaders.md) | Custom headers for the feed | 
**MaxRetries** | **int?** | Maximum number of retries on the feed url | 
**Cache** | **bool?** | Toggle caching of feed url response | 
**CreatedAt** | **DateTime?** | Datetime on which the feed was created | 
**ModifiedAt** | **DateTime?** | Datetime on which the feed was modified | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

