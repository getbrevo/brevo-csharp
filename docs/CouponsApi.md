# brevo_csharp.Api.CouponsApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCouponCollection**](CouponsApi.md#createcouponcollection) | **POST** /couponCollections | Create а coupon collection
[**CreateCoupons**](CouponsApi.md#createcoupons) | **POST** /coupons | Create coupons for a coupon collection
[**GetCouponCollection**](CouponsApi.md#getcouponcollection) | **GET** /couponCollections/{id} | Get a coupon collection by id
[**GetCouponCollections**](CouponsApi.md#getcouponcollections) | **GET** /couponCollections | Get all your coupon collections
[**UpdateCouponCollection**](CouponsApi.md#updatecouponcollection) | **PATCH** /couponCollections/{id} | Update a coupon collection by id


<a name="createcouponcollection"></a>
# **CreateCouponCollection**
> InlineResponse2013 CreateCouponCollection (CreateCouponCollection createCouponCollection)

Create а coupon collection

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateCouponCollectionExample
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

            var apiInstance = new CouponsApi();
            var createCouponCollection = new CreateCouponCollection(); // CreateCouponCollection | Values to create a coupon collection

            try
            {
                // Create а coupon collection
                InlineResponse2013 result = apiInstance.CreateCouponCollection(createCouponCollection);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.CreateCouponCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createCouponCollection** | [**CreateCouponCollection**](CreateCouponCollection.md)| Values to create a coupon collection | 

### Return type

[**InlineResponse2013**](InlineResponse2013.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcoupons"></a>
# **CreateCoupons**
> void CreateCoupons (CreateCoupons createCoupons)

Create coupons for a coupon collection

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateCouponsExample
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

            var apiInstance = new CouponsApi();
            var createCoupons = new CreateCoupons(); // CreateCoupons | Values to create coupons

            try
            {
                // Create coupons for a coupon collection
                apiInstance.CreateCoupons(createCoupons);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.CreateCoupons: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createCoupons** | [**CreateCoupons**](CreateCoupons.md)| Values to create coupons | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcouponcollection"></a>
# **GetCouponCollection**
> GetCouponCollection GetCouponCollection (string id)

Get a coupon collection by id

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetCouponCollectionExample
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

            var apiInstance = new CouponsApi();
            var id = id_example;  // string | Id of the collection to return

            try
            {
                // Get a coupon collection by id
                GetCouponCollection result = apiInstance.GetCouponCollection(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.GetCouponCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the collection to return | 

### Return type

[**GetCouponCollection**](GetCouponCollection.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcouponcollections"></a>
# **GetCouponCollections**
> GetCouponCollection GetCouponCollections (long? limit = null, long? offset = null, string sort = null)

Get all your coupon collections

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetCouponCollectionsExample
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

            var apiInstance = new CouponsApi();
            var limit = 789;  // long? | Number of documents returned per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document on the page (optional)  (default to 0)
            var sort = sort_example;  // string | Sort the results by creation time in ascending/descending order (optional)  (default to desc)

            try
            {
                // Get all your coupon collections
                GetCouponCollection result = apiInstance.GetCouponCollections(limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.GetCouponCollections: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents returned per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document on the page | [optional] [default to 0]
 **sort** | **string**| Sort the results by creation time in ascending/descending order | [optional] [default to desc]

### Return type

[**GetCouponCollection**](GetCouponCollection.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecouponcollection"></a>
# **UpdateCouponCollection**
> InlineResponse2003 UpdateCouponCollection (string id, UpdateCouponCollection updateCouponCollection)

Update a coupon collection by id

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateCouponCollectionExample
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

            var apiInstance = new CouponsApi();
            var id = id_example;  // string | Id of the collection to update
            var updateCouponCollection = new UpdateCouponCollection(); // UpdateCouponCollection | Values to update the coupon collection

            try
            {
                // Update a coupon collection by id
                InlineResponse2003 result = apiInstance.UpdateCouponCollection(id, updateCouponCollection);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CouponsApi.UpdateCouponCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the collection to update | 
 **updateCouponCollection** | [**UpdateCouponCollection**](UpdateCouponCollection.md)| Values to update the coupon collection | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

