# brevo_csharp.Api.ExternalFeedsApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateExternalFeed**](ExternalFeedsApi.md#createexternalfeed) | **POST** /feeds | Create an external feed
[**DeleteExternalFeed**](ExternalFeedsApi.md#deleteexternalfeed) | **DELETE** /feeds/{uuid} | Delete an external feed
[**GetAllExternalFeeds**](ExternalFeedsApi.md#getallexternalfeeds) | **GET** /feeds | Fetch all external feeds
[**GetExternalFeedByUUID**](ExternalFeedsApi.md#getexternalfeedbyuuid) | **GET** /feeds/{uuid} | Get an external feed by UUID
[**UpdateExternalFeed**](ExternalFeedsApi.md#updateexternalfeed) | **PUT** /feeds/{uuid} | Update an external feed


<a name="createexternalfeed"></a>
# **CreateExternalFeed**
> InlineResponse2015 CreateExternalFeed (CreateExternalFeed createExternalFeed)

Create an external feed

This endpoint will create an external feed.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateExternalFeedExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ExternalFeedsApi();
            var createExternalFeed = new CreateExternalFeed(); // CreateExternalFeed | Values to create a feed

            try
            {
                // Create an external feed
                InlineResponse2015 result = apiInstance.CreateExternalFeed(createExternalFeed);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalFeedsApi.CreateExternalFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createExternalFeed** | [**CreateExternalFeed**](CreateExternalFeed.md)| Values to create a feed | 

### Return type

[**InlineResponse2015**](InlineResponse2015.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteexternalfeed"></a>
# **DeleteExternalFeed**
> void DeleteExternalFeed (string uuid)

Delete an external feed

This endpoint will delete an external feed.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteExternalFeedExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ExternalFeedsApi();
            var uuid = uuid_example;  // string | UUID of the feed to delete

            try
            {
                // Delete an external feed
                apiInstance.DeleteExternalFeed(uuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalFeedsApi.DeleteExternalFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| UUID of the feed to delete | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallexternalfeeds"></a>
# **GetAllExternalFeeds**
> GetAllExternalFeeds GetAllExternalFeeds (string search = null, DateTime? startDate = null, DateTime? endDate = null, string sort = null, string authType = null, long? limit = null, long? offset = null)

Fetch all external feeds

This endpoint can fetch all created external feeds.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetAllExternalFeedsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ExternalFeedsApi();
            var search = search_example;  // string | Can be used to filter records by search keyword on feed name (optional) 
            var startDate = 2013-10-20;  // DateTime? | Mandatory if `endDate` is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Can be maximum 30 days older than current date. (optional) 
            var endDate = 2013-10-20;  // DateTime? | Mandatory if `startDate` is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed. (optional)  (default to desc)
            var authType = authType_example;  // string | Filter the records by `authType` of the feed. (optional) 
            var limit = 789;  // long? | Number of documents returned per page. (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document on the page. (optional)  (default to 0)

            try
            {
                // Fetch all external feeds
                GetAllExternalFeeds result = apiInstance.GetAllExternalFeeds(search, startDate, endDate, sort, authType, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalFeedsApi.GetAllExternalFeeds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**| Can be used to filter records by search keyword on feed name | [optional] 
 **startDate** | **DateTime?**| Mandatory if &#x60;endDate&#x60; is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Can be maximum 30 days older than current date. | [optional] 
 **endDate** | **DateTime?**| Mandatory if &#x60;startDate&#x60; is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. | [optional] 
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed. | [optional] [default to desc]
 **authType** | **string**| Filter the records by &#x60;authType&#x60; of the feed. | [optional] 
 **limit** | **long?**| Number of documents returned per page. | [optional] [default to 50]
 **offset** | **long?**| Index of the first document on the page. | [optional] [default to 0]

### Return type

[**GetAllExternalFeeds**](GetAllExternalFeeds.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternalfeedbyuuid"></a>
# **GetExternalFeedByUUID**
> GetExternalFeedByUUID GetExternalFeedByUUID (string uuid)

Get an external feed by UUID

This endpoint will update an external feed.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetExternalFeedByUUIDExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ExternalFeedsApi();
            var uuid = uuid_example;  // string | UUID of the feed to fetch

            try
            {
                // Get an external feed by UUID
                GetExternalFeedByUUID result = apiInstance.GetExternalFeedByUUID(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalFeedsApi.GetExternalFeedByUUID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| UUID of the feed to fetch | 

### Return type

[**GetExternalFeedByUUID**](GetExternalFeedByUUID.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateexternalfeed"></a>
# **UpdateExternalFeed**
> void UpdateExternalFeed (string uuid, UpdateExternalFeed updateExternalFeed)

Update an external feed

This endpoint will update an external feed.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateExternalFeedExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: partner-key
            Configuration.Default.AddApiKey("partner-key", "YOUR_PARTNER_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("partner-key", "Bearer");

            var apiInstance = new ExternalFeedsApi();
            var uuid = uuid_example;  // string | UUID of the feed to update
            var updateExternalFeed = new UpdateExternalFeed(); // UpdateExternalFeed | Values to update a feed

            try
            {
                // Update an external feed
                apiInstance.UpdateExternalFeed(uuid, updateExternalFeed);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalFeedsApi.UpdateExternalFeed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| UUID of the feed to update | 
 **updateExternalFeed** | [**UpdateExternalFeed**](UpdateExternalFeed.md)| Values to update a feed | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

