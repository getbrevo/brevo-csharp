# brevo_csharp.Api.CompaniesApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompaniesGet**](CompaniesApi.md#companiesget) | **GET** /companies | Get all companies
[**CompaniesIdDelete**](CompaniesApi.md#companiesiddelete) | **DELETE** /companies/{id} | Delete a company
[**CompaniesIdGet**](CompaniesApi.md#companiesidget) | **GET** /companies/{id} | Get a company
[**CompaniesIdPatch**](CompaniesApi.md#companiesidpatch) | **PATCH** /companies/{id} | Update a company
[**CompaniesImportPost**](CompaniesApi.md#companiesimportpost) | **POST** /companies/import | Import companies(creation and updation)
[**CompaniesLinkUnlinkIdPatch**](CompaniesApi.md#companieslinkunlinkidpatch) | **PATCH** /companies/link-unlink/{id} | Link and Unlink company with contacts and deals
[**CompaniesPost**](CompaniesApi.md#companiespost) | **POST** /companies | Create a company
[**CrmAttributesCompaniesGet**](CompaniesApi.md#crmattributescompaniesget) | **GET** /crm/attributes/companies | Get company attributes
[**CrmAttributesPost**](CompaniesApi.md#crmattributespost) | **POST** /crm/attributes | Create a deal/company attribute


<a name="companiesget"></a>
# **CompaniesGet**
> CompaniesList CompaniesGet (string filters = null, long? linkedContactsIds = null, string linkedDealsIds = null, string modifiedSince = null, string createdSince = null, long? page = null, long? limit = null, string sort = null, string sortBy = null)

Get all companies

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CompaniesGetExample
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

            var apiInstance = new CompaniesApi();
            var filters = filters_example;  // string | Filter by attrbutes. If you have filter for owner on your side please send it as {\"attributes.owner\":\"5b1a17d914b73d35a76ca0c7\"} (optional) 
            var linkedContactsIds = 789;  // long? | Filter by linked contacts ids (optional) 
            var linkedDealsIds = linkedDealsIds_example;  // string | Filter by linked deals ids (optional) 
            var modifiedSince = modifiedSince_example;  // string | Filter (urlencoded) the contacts modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. (optional) 
            var createdSince = createdSince_example;  // string | Filter (urlencoded) the contacts created after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. (optional) 
            var page = 789;  // long? | Index of the first document of the page (optional) 
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order. Default order is **descending** by creation if `sort` is not passed (optional) 
            var sortBy = sortBy_example;  // string | The field used to sort field names. (optional) 

            try
            {
                // Get all companies
                CompaniesList result = apiInstance.CompaniesGet(filters, linkedContactsIds, linkedDealsIds, modifiedSince, createdSince, page, limit, sort, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filters** | **string**| Filter by attrbutes. If you have filter for owner on your side please send it as {&quot;attributes.owner&quot;:&quot;5b1a17d914b73d35a76ca0c7&quot;} | [optional] 
 **linkedContactsIds** | **long?**| Filter by linked contacts ids | [optional] 
 **linkedDealsIds** | **string**| Filter by linked deals ids | [optional] 
 **modifiedSince** | **string**| Filter (urlencoded) the contacts modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. | [optional] 
 **createdSince** | **string**| Filter (urlencoded) the contacts created after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result. | [optional] 
 **page** | **long?**| Index of the first document of the page | [optional] 
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **sort** | **string**| Sort the results in the ascending/descending order. Default order is **descending** by creation if &#x60;sort&#x60; is not passed | [optional] 
 **sortBy** | **string**| The field used to sort field names. | [optional] 

### Return type

[**CompaniesList**](CompaniesList.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesiddelete"></a>
# **CompaniesIdDelete**
> void CompaniesIdDelete (string id)

Delete a company

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CompaniesIdDeleteExample
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

            var apiInstance = new CompaniesApi();
            var id = id_example;  // string | 

            try
            {
                // Delete a company
                apiInstance.CompaniesIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesIdDelete: " + e.Message );
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

<a name="companiesidget"></a>
# **CompaniesIdGet**
> Company CompaniesIdGet (string id)

Get a company

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CompaniesIdGetExample
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

            var apiInstance = new CompaniesApi();
            var id = id_example;  // string | 

            try
            {
                // Get a company
                Company result = apiInstance.CompaniesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesIdGet: " + e.Message );
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

[**Company**](Company.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesidpatch"></a>
# **CompaniesIdPatch**
> Company CompaniesIdPatch (string id, Body7 body)

Update a company

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CompaniesIdPatchExample
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

            var apiInstance = new CompaniesApi();
            var id = id_example;  // string | 
            var body = new Body7(); // Body7 | Updated company details.

            try
            {
                // Update a company
                Company result = apiInstance.CompaniesIdPatch(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Body7**](Body7.md)| Updated company details. | 

### Return type

[**Company**](Company.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesimportpost"></a>
# **CompaniesImportPost**
> InlineResponse2004 CompaniesImportPost (System.IO.Stream file, string mapping)

Import companies(creation and updation)

Import companies from a CSV file with mapping options.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CompaniesImportPostExample
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

            var apiInstance = new CompaniesApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The CSV file to upload.The file should have the first row as the mapping attribute. Some default attribute names are (a) company_id [brevo mongoID to update deals] (b) associated_contact (c) associated_deal (f) any other attribute with internal name 
            var mapping = mapping_example;  // string | The mapping options in JSON format.   json    {       \"link_entities\": true, // Determines whether to link related entities during the import process       \"unlink_entities\": false, //Determines whether to unlink related entities during the import process.       \"update_existing_records\": true, // Determines whether to update based on company ID or treat every row as create       \"unset_empty_attributes\": false // Determines whether unset a specific attribute during update if values input is blank       \"use_company_identifier\": false // Determines whether to use company name as identifier     } 

            try
            {
                // Import companies(creation and updation)
                InlineResponse2004 result = apiInstance.CompaniesImportPost(file, mapping);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesImportPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The CSV file to upload.The file should have the first row as the mapping attribute. Some default attribute names are (a) company_id [brevo mongoID to update deals] (b) associated_contact (c) associated_deal (f) any other attribute with internal name  | 
 **mapping** | **string**| The mapping options in JSON format.   json    {       &quot;link_entities&quot;: true, // Determines whether to link related entities during the import process       &quot;unlink_entities&quot;: false, //Determines whether to unlink related entities during the import process.       &quot;update_existing_records&quot;: true, // Determines whether to update based on company ID or treat every row as create       &quot;unset_empty_attributes&quot;: false // Determines whether unset a specific attribute during update if values input is blank       &quot;use_company_identifier&quot;: false // Determines whether to use company name as identifier     }  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companieslinkunlinkidpatch"></a>
# **CompaniesLinkUnlinkIdPatch**
> void CompaniesLinkUnlinkIdPatch (string id, Body8 body)

Link and Unlink company with contacts and deals

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CompaniesLinkUnlinkIdPatchExample
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

            var apiInstance = new CompaniesApi();
            var id = id_example;  // string | 
            var body = new Body8(); // Body8 | Linked / Unlinked contacts and deals ids.

            try
            {
                // Link and Unlink company with contacts and deals
                apiInstance.CompaniesLinkUnlinkIdPatch(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesLinkUnlinkIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Body8**](Body8.md)| Linked / Unlinked contacts and deals ids. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiespost"></a>
# **CompaniesPost**
> InlineResponse2002 CompaniesPost (Body6 body)

Create a company

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CompaniesPostExample
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

            var apiInstance = new CompaniesApi();
            var body = new Body6(); // Body6 | Company create data.

            try
            {
                // Create a company
                InlineResponse2002 result = apiInstance.CompaniesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body6**](Body6.md)| Company create data. | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="crmattributescompaniesget"></a>
# **CrmAttributesCompaniesGet**
> CompanyAttributes CrmAttributesCompaniesGet ()

Get company attributes

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CrmAttributesCompaniesGetExample
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

            var apiInstance = new CompaniesApi();

            try
            {
                // Get company attributes
                CompanyAttributes result = apiInstance.CrmAttributesCompaniesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CrmAttributesCompaniesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CompanyAttributes**](CompanyAttributes.md)

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

            var apiInstance = new CompaniesApi();
            var body = new Body9(); // Body9 | Attribute creation data for company

            try
            {
                // Create a deal/company attribute
                InlineResponse2003 result = apiInstance.CrmAttributesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CrmAttributesPost: " + e.Message );
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

