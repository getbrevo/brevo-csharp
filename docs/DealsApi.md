# brevo_csharp.Api.DealsApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CrmAttributesDealsGet**](DealsApi.md#crmattributesdealsget) | **GET** /crm/attributes/deals | Get deal attributes
[**CrmAttributesPost**](DealsApi.md#crmattributespost) | **POST** /crm/attributes | Create a deal/company attribute
[**CrmDealsGet**](DealsApi.md#crmdealsget) | **GET** /crm/deals | Get all deals
[**CrmDealsIdDelete**](DealsApi.md#crmdealsiddelete) | **DELETE** /crm/deals/{id} | Delete a deal
[**CrmDealsIdGet**](DealsApi.md#crmdealsidget) | **GET** /crm/deals/{id} | Get a deal
[**CrmDealsIdPatch**](DealsApi.md#crmdealsidpatch) | **PATCH** /crm/deals/{id} | Update a deal
[**CrmDealsImportPost**](DealsApi.md#crmdealsimportpost) | **POST** /crm/deals/import | Import deals(creation and updation)
[**CrmDealsLinkUnlinkIdPatch**](DealsApi.md#crmdealslinkunlinkidpatch) | **PATCH** /crm/deals/link-unlink/{id} | Link and Unlink a deal with contacts and companies
[**CrmDealsPost**](DealsApi.md#crmdealspost) | **POST** /crm/deals | Create a deal
[**CrmPipelineDetailsAllGet**](DealsApi.md#crmpipelinedetailsallget) | **GET** /crm/pipeline/details/all | Get all pipelines
[**CrmPipelineDetailsGet**](DealsApi.md#crmpipelinedetailsget) | **GET** /crm/pipeline/details | Get pipeline stages
[**CrmPipelineDetailsPipelineIDGet**](DealsApi.md#crmpipelinedetailspipelineidget) | **GET** /crm/pipeline/details/{pipelineID} | Get a pipeline


<a name="crmattributesdealsget"></a>
# **CrmAttributesDealsGet**
> DealAttributes CrmAttributesDealsGet ()

Get deal attributes

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmAttributesDealsGetExample
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

            var apiInstance = new DealsApi();

            try
            {
                // Get deal attributes
                DealAttributes result = apiInstance.CrmAttributesDealsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmAttributesDealsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DealAttributes**](DealAttributes.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmattributespost"></a>
# **CrmAttributesPost**
> InlineResponse2003 CrmAttributesPost (Body9 body)

Create a deal/company attribute

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmAttributesPostExample
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

            var apiInstance = new DealsApi();
            var body = new Body9(); // Body9 | Attribute creation data for company

            try
            {
                // Create a deal/company attribute
                InlineResponse2003 result = apiInstance.CrmAttributesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmAttributesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body9**](Body9.md)| Attribute creation data for company | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmdealsget"></a>
# **CrmDealsGet**
> DealsList CrmDealsGet (string filtersAttributesDealName = null, string filtersLinkedCompaniesIds = null, string filtersLinkedContactsIds = null, string modifiedSince = null, string createdSince = null, long? offset = null, long? limit = null, string sort = null, string sortBy = null)

Get all deals

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmDealsGetExample
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

            var apiInstance = new DealsApi();
            var filtersAttributesDealName = filtersAttributesDealName_example;  // string | Filter by attributes. If you have a filter for the owner on your end, please send it as filters[attributes.deal_owner] and utilize the account email for the filtering. (optional) 
            var filtersLinkedCompaniesIds = filtersLinkedCompaniesIds_example;  // string | Filter by linked companies ids (optional) 
            var filtersLinkedContactsIds = filtersLinkedContactsIds_example;  // string | Filter by linked companies ids (optional) 
            var modifiedSince = modifiedSince_example;  // string | Filter (urlencoded) the contacts modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. (optional) 
            var createdSince = createdSince_example;  // string | Filter (urlencoded) the contacts created after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. (optional) 
            var offset = 789;  // long? | Index of the first document of the page (optional) 
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order. Default order is **descending** by creation if `sort` is not passed (optional) 
            var sortBy = sortBy_example;  // string | The field used to sort field names. (optional) 

            try
            {
                // Get all deals
                DealsList result = apiInstance.CrmDealsGet(filtersAttributesDealName, filtersLinkedCompaniesIds, filtersLinkedContactsIds, modifiedSince, createdSince, offset, limit, sort, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmDealsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filtersAttributesDealName** | **string**| Filter by attributes. If you have a filter for the owner on your end, please send it as filters[attributes.deal_owner] and utilize the account email for the filtering. | [optional] 
 **filtersLinkedCompaniesIds** | **string**| Filter by linked companies ids | [optional] 
 **filtersLinkedContactsIds** | **string**| Filter by linked companies ids | [optional] 
 **modifiedSince** | **string**| Filter (urlencoded) the contacts modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. | [optional] 
 **createdSince** | **string**| Filter (urlencoded) the contacts created after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. | [optional] 
 **offset** | **long?**| Index of the first document of the page | [optional] 
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **sort** | **string**| Sort the results in the ascending/descending order. Default order is **descending** by creation if &#x60;sort&#x60; is not passed | [optional] 
 **sortBy** | **string**| The field used to sort field names. | [optional] 

### Return type

[**DealsList**](DealsList.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmdealsiddelete"></a>
# **CrmDealsIdDelete**
> void CrmDealsIdDelete (string id)

Delete a deal

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmDealsIdDeleteExample
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

            var apiInstance = new DealsApi();
            var id = id_example;  // string | 

            try
            {
                // Delete a deal
                apiInstance.CrmDealsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmDealsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmdealsidget"></a>
# **CrmDealsIdGet**
> Deal CrmDealsIdGet (string id)

Get a deal

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmDealsIdGetExample
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

            var apiInstance = new DealsApi();
            var id = id_example;  // string | 

            try
            {
                // Get a deal
                Deal result = apiInstance.CrmDealsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmDealsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**Deal**](Deal.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmdealsidpatch"></a>
# **CrmDealsIdPatch**
> void CrmDealsIdPatch (string id, Body11 body)

Update a deal

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmDealsIdPatchExample
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

            var apiInstance = new DealsApi();
            var id = id_example;  // string | 
            var body = new Body11(); // Body11 | Updated deal details.

            try
            {
                // Update a deal
                apiInstance.CrmDealsIdPatch(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmDealsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Body11**](Body11.md)| Updated deal details. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmdealsimportpost"></a>
# **CrmDealsImportPost**
> InlineResponse2004 CrmDealsImportPost (System.IO.Stream file, string mapping)

Import deals(creation and updation)

Import deals from a CSV file with mapping options.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmDealsImportPostExample
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

            var apiInstance = new DealsApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The CSV file to upload.The file should have the first row as the mapping attribute. Some default attribute names are (a) deal_id [brevo mongoID to update deals] (b) associated_contact (c) associated_company (f) any other attribute with internal name 
            var mapping = mapping_example;  // string | The mapping options in JSON format.   json    {       \"link_entities\": true, // Determines whether to link related entities during the import process       \"unlink_entities\": false, //Determines whether to unlink related entities during the import process.       \"update_existing_records\": true, // Determines whether to update based on deal ID or treat every row as create       \"unset_empty_attributes\": false // Determines whether unset a specific attribute during update if values input is blank     } 

            try
            {
                // Import deals(creation and updation)
                InlineResponse2004 result = apiInstance.CrmDealsImportPost(file, mapping);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmDealsImportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The CSV file to upload.The file should have the first row as the mapping attribute. Some default attribute names are (a) deal_id [brevo mongoID to update deals] (b) associated_contact (c) associated_company (f) any other attribute with internal name  | 
 **mapping** | **string**| The mapping options in JSON format.   json    {       &quot;link_entities&quot;: true, // Determines whether to link related entities during the import process       &quot;unlink_entities&quot;: false, //Determines whether to unlink related entities during the import process.       &quot;update_existing_records&quot;: true, // Determines whether to update based on deal ID or treat every row as create       &quot;unset_empty_attributes&quot;: false // Determines whether unset a specific attribute during update if values input is blank     }  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmdealslinkunlinkidpatch"></a>
# **CrmDealsLinkUnlinkIdPatch**
> void CrmDealsLinkUnlinkIdPatch (string id, Body12 body)

Link and Unlink a deal with contacts and companies

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmDealsLinkUnlinkIdPatchExample
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

            var apiInstance = new DealsApi();
            var id = id_example;  // string | 
            var body = new Body12(); // Body12 | Linked / Unlinked contacts and companies ids.

            try
            {
                // Link and Unlink a deal with contacts and companies
                apiInstance.CrmDealsLinkUnlinkIdPatch(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmDealsLinkUnlinkIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Body12**](Body12.md)| Linked / Unlinked contacts and companies ids. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmdealspost"></a>
# **CrmDealsPost**
> InlineResponse2011 CrmDealsPost (Body10 body)

Create a deal

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmDealsPostExample
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

            var apiInstance = new DealsApi();
            var body = new Body10(); // Body10 | Deal create data.

            try
            {
                // Create a deal
                InlineResponse2011 result = apiInstance.CrmDealsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmDealsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body10**](Body10.md)| Deal create data. | 

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmpipelinedetailsallget"></a>
# **CrmPipelineDetailsAllGet**
> Pipelines CrmPipelineDetailsAllGet ()

Get all pipelines

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmPipelineDetailsAllGetExample
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

            var apiInstance = new DealsApi();

            try
            {
                // Get all pipelines
                Pipelines result = apiInstance.CrmPipelineDetailsAllGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmPipelineDetailsAllGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Pipelines**](Pipelines.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmpipelinedetailsget"></a>
# **CrmPipelineDetailsGet**
> Pipeline CrmPipelineDetailsGet ()

Get pipeline stages

This endpoint is deprecated. Prefer /crm/pipeline/details/{pipelineID} instead.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmPipelineDetailsGetExample
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

            var apiInstance = new DealsApi();

            try
            {
                // Get pipeline stages
                Pipeline result = apiInstance.CrmPipelineDetailsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmPipelineDetailsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Pipeline**](Pipeline.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmpipelinedetailspipelineidget"></a>
# **CrmPipelineDetailsPipelineIDGet**
> Pipelines CrmPipelineDetailsPipelineIDGet (string pipelineID)

Get a pipeline

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmPipelineDetailsPipelineIDGetExample
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

            var apiInstance = new DealsApi();
            var pipelineID = pipelineID_example;  // string | 

            try
            {
                // Get a pipeline
                Pipelines result = apiInstance.CrmPipelineDetailsPipelineIDGet(pipelineID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DealsApi.CrmPipelineDetailsPipelineIDGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pipelineID** | **string**|  | 

### Return type

[**Pipelines**](Pipelines.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

