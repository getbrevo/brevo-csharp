# brevo_csharp.Model.UpdateExternalFeed
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the feed | [optional] 
**Url** | **string** | URL of the feed | [optional] 
**AuthType** | **string** | Auth type of the feed:   * &#x60;basic&#x60;   * &#x60;token&#x60;   * &#x60;noAuth&#x60;  | [optional] 
**Username** | **string** | Username for authType &#x60;basic&#x60; | [optional] 
**Password** | **string** | Password for authType &#x60;basic&#x60; | [optional] 
**Token** | **string** | Token for authType &#x60;token&#x60; | [optional] 
**Headers** | [**List&lt;GetExternalFeedByUUIDHeaders&gt;**](GetExternalFeedByUUIDHeaders.md) | Custom headers for the feed | [optional] 
**MaxRetries** | **int?** | Maximum number of retries on the feed url | [optional] 
**Cache** | **bool?** | Toggle caching of feed url response | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

