# brevo_csharp.Api.WhatsAppCampaignsApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWhatsAppCampaign**](WhatsAppCampaignsApi.md#createwhatsappcampaign) | **POST** /whatsappCampaigns | Create and Send a WhatsApp campaign
[**CreateWhatsAppTemplate**](WhatsAppCampaignsApi.md#createwhatsapptemplate) | **POST** /whatsppCampaigns/template | Create a WhatsApp template
[**DeleteWhatsAppCampaign**](WhatsAppCampaignsApi.md#deletewhatsappcampaign) | **DELETE** /whatsappCampaigns/{campaignId} | Delete a WhatsApp campaign
[**GetWhatsAppCampaign**](WhatsAppCampaignsApi.md#getwhatsappcampaign) | **GET** /whatsappCampaigns/{campaignId} | Get a WhatsApp campaign
[**GetWhatsAppCampaigns**](WhatsAppCampaignsApi.md#getwhatsappcampaigns) | **GET** /whatsappCampaigns | Return all your created WhatsApp campaigns
[**GetWhatsAppConfig**](WhatsAppCampaignsApi.md#getwhatsappconfig) | **GET** /whatsappCampaigns/config | Get your WhatsApp API account information
[**GetWhatsAppTemplates**](WhatsAppCampaignsApi.md#getwhatsapptemplates) | **GET** /whatsappCampaigns/template-list | Return all your created WhatsApp templates
[**SendWhatsAppTemplateApproval**](WhatsAppCampaignsApi.md#sendwhatsapptemplateapproval) | **POST** /whatsappCampaigns/template/approval/{templateId} | Send your WhatsApp template for approval
[**UpdateWhatsAppCampaign**](WhatsAppCampaignsApi.md#updatewhatsappcampaign) | **PUT** /whatsappCampaigns/{campaignId} | Update a WhatsApp campaign


<a name="createwhatsappcampaign"></a>
# **CreateWhatsAppCampaign**
> CreateModel CreateWhatsAppCampaign (CreateWhatsAppCampaign whatsAppCampaigns)

Create and Send a WhatsApp campaign

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateWhatsAppCampaignExample
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

            var apiInstance = new WhatsAppCampaignsApi();
            var whatsAppCampaigns = new CreateWhatsAppCampaign(); // CreateWhatsAppCampaign | Values to create a campaign

            try
            {
                // Create and Send a WhatsApp campaign
                CreateModel result = apiInstance.CreateWhatsAppCampaign(whatsAppCampaigns);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.CreateWhatsAppCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **whatsAppCampaigns** | [**CreateWhatsAppCampaign**](CreateWhatsAppCampaign.md)| Values to create a campaign | 

### Return type

[**CreateModel**](CreateModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createwhatsapptemplate"></a>
# **CreateWhatsAppTemplate**
> CreateModel CreateWhatsAppTemplate (CreateWhatsAppTemplate whatsAppTemplates)

Create a WhatsApp template

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateWhatsAppTemplateExample
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

            var apiInstance = new WhatsAppCampaignsApi();
            var whatsAppTemplates = new CreateWhatsAppTemplate(); // CreateWhatsAppTemplate | Values to create a template

            try
            {
                // Create a WhatsApp template
                CreateModel result = apiInstance.CreateWhatsAppTemplate(whatsAppTemplates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.CreateWhatsAppTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **whatsAppTemplates** | [**CreateWhatsAppTemplate**](CreateWhatsAppTemplate.md)| Values to create a template | 

### Return type

[**CreateModel**](CreateModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletewhatsappcampaign"></a>
# **DeleteWhatsAppCampaign**
> void DeleteWhatsAppCampaign (long? campaignId)

Delete a WhatsApp campaign

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteWhatsAppCampaignExample
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

            var apiInstance = new WhatsAppCampaignsApi();
            var campaignId = 789;  // long? | id of the campaign

            try
            {
                // Delete a WhatsApp campaign
                apiInstance.DeleteWhatsAppCampaign(campaignId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.DeleteWhatsAppCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| id of the campaign | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwhatsappcampaign"></a>
# **GetWhatsAppCampaign**
> GetWhatsappCampaignOverview GetWhatsAppCampaign (long? campaignId)

Get a WhatsApp campaign

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetWhatsAppCampaignExample
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

            var apiInstance = new WhatsAppCampaignsApi();
            var campaignId = 789;  // long? | Id of the campaign

            try
            {
                // Get a WhatsApp campaign
                GetWhatsappCampaignOverview result = apiInstance.GetWhatsAppCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.GetWhatsAppCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the campaign | 

### Return type

[**GetWhatsappCampaignOverview**](GetWhatsappCampaignOverview.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwhatsappcampaigns"></a>
# **GetWhatsAppCampaigns**
> GetWhatsappCampaigns GetWhatsAppCampaigns (string startDate = null, string endDate = null, long? limit = null, long? offset = null, string sort = null)

Return all your created WhatsApp campaigns

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetWhatsAppCampaignsExample
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

            var apiInstance = new WhatsAppCampaignsApi();
            var startDate = startDate_example;  // string | **Mandatory if endDate is used**. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the campaigns created. **Prefer to pass your timezone in date-time format for accurate result**  (optional) 
            var endDate = endDate_example;  // string | **Mandatory if startDate is used**. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the campaigns created. **Prefer to pass your timezone in date-time format for accurate result**  (optional) 
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document in the page (optional)  (default to 0)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record modification. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Return all your created WhatsApp campaigns
                GetWhatsappCampaigns result = apiInstance.GetWhatsAppCampaigns(startDate, endDate, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.GetWhatsAppCampaigns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| **Mandatory if endDate is used**. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the campaigns created. **Prefer to pass your timezone in date-time format for accurate result**  | [optional] 
 **endDate** | **string**| **Mandatory if startDate is used**. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the campaigns created. **Prefer to pass your timezone in date-time format for accurate result**  | [optional] 
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document in the page | [optional] [default to 0]
 **sort** | **string**| Sort the results in the ascending/descending order of record modification. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]

### Return type

[**GetWhatsappCampaigns**](GetWhatsappCampaigns.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwhatsappconfig"></a>
# **GetWhatsAppConfig**
> GetWhatsAppConfig GetWhatsAppConfig ()

Get your WhatsApp API account information

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetWhatsAppConfigExample
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

            var apiInstance = new WhatsAppCampaignsApi();

            try
            {
                // Get your WhatsApp API account information
                GetWhatsAppConfig result = apiInstance.GetWhatsAppConfig();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.GetWhatsAppConfig: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetWhatsAppConfig**](GetWhatsAppConfig.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwhatsapptemplates"></a>
# **GetWhatsAppTemplates**
> GetWATemplates GetWhatsAppTemplates (string startDate = null, string endDate = null, long? limit = null, long? offset = null, string sort = null, string source = null)

Return all your created WhatsApp templates

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetWhatsAppTemplatesExample
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

            var apiInstance = new WhatsAppCampaignsApi();
            var startDate = startDate_example;  // string | **Mandatory if endDate is used**. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the templates created. **Prefer to pass your timezone in date-time format for accurate result**  (optional) 
            var endDate = endDate_example;  // string | **Mandatory if startDate is used**. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the templates created. **Prefer to pass your timezone in date-time format for accurate result**  (optional) 
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document in the page (optional)  (default to 0)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record modification. Default order is **descending** if `sort` is not passed (optional)  (default to desc)
            var source = source_example;  // string | source of the template (optional) 

            try
            {
                // Return all your created WhatsApp templates
                GetWATemplates result = apiInstance.GetWhatsAppTemplates(startDate, endDate, limit, offset, sort, source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.GetWhatsAppTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| **Mandatory if endDate is used**. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the templates created. **Prefer to pass your timezone in date-time format for accurate result**  | [optional] 
 **endDate** | **string**| **Mandatory if startDate is used**. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the templates created. **Prefer to pass your timezone in date-time format for accurate result**  | [optional] 
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document in the page | [optional] [default to 0]
 **sort** | **string**| Sort the results in the ascending/descending order of record modification. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]
 **source** | **string**| source of the template | [optional] 

### Return type

[**GetWATemplates**](GetWATemplates.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendwhatsapptemplateapproval"></a>
# **SendWhatsAppTemplateApproval**
> void SendWhatsAppTemplateApproval (long? templateId)

Send your WhatsApp template for approval

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SendWhatsAppTemplateApprovalExample
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

            var apiInstance = new WhatsAppCampaignsApi();
            var templateId = 789;  // long? | id of the campaign

            try
            {
                // Send your WhatsApp template for approval
                apiInstance.SendWhatsAppTemplateApproval(templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.SendWhatsAppTemplateApproval: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **long?**| id of the campaign | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewhatsappcampaign"></a>
# **UpdateWhatsAppCampaign**
> void UpdateWhatsAppCampaign (long? campaignId, UpdateWhatsAppCampaign whatsAppCampaign = null)

Update a WhatsApp campaign

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateWhatsAppCampaignExample
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

            var apiInstance = new WhatsAppCampaignsApi();
            var campaignId = 789;  // long? | Id of the campaign
            var whatsAppCampaign = new UpdateWhatsAppCampaign(); // UpdateWhatsAppCampaign | values to update WhatsApp Campaign (optional) 

            try
            {
                // Update a WhatsApp campaign
                apiInstance.UpdateWhatsAppCampaign(campaignId, whatsAppCampaign);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.UpdateWhatsAppCampaign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **campaignId** | **long?**| Id of the campaign | 
 **whatsAppCampaign** | [**UpdateWhatsAppCampaign**](UpdateWhatsAppCampaign.md)| values to update WhatsApp Campaign | [optional] 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

