# brevo_csharp.Api.TransactionalEmailsApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BlockNewDomain**](TransactionalEmailsApi.md#blocknewdomain) | **POST** /smtp/blockedDomains | Add a new domain to the list of blocked domains
[**CreateSmtpTemplate**](TransactionalEmailsApi.md#createsmtptemplate) | **POST** /smtp/templates | Create an email template
[**DeleteBlockedDomain**](TransactionalEmailsApi.md#deleteblockeddomain) | **DELETE** /smtp/blockedDomains/{domain} | Unblock an existing domain from the list of blocked domains
[**DeleteHardbounces**](TransactionalEmailsApi.md#deletehardbounces) | **POST** /smtp/deleteHardbounces | Delete hardbounces
[**DeleteScheduledEmailById**](TransactionalEmailsApi.md#deletescheduledemailbyid) | **DELETE** /smtp/email/{identifier} | Delete scheduled emails by batchId or messageId
[**DeleteSmtpTemplate**](TransactionalEmailsApi.md#deletesmtptemplate) | **DELETE** /smtp/templates/{templateId} | Delete an inactive email template
[**GetAggregatedSmtpReport**](TransactionalEmailsApi.md#getaggregatedsmtpreport) | **GET** /smtp/statistics/aggregatedReport | Get your transactional email activity aggregated over a period of time
[**GetBlockedDomains**](TransactionalEmailsApi.md#getblockeddomains) | **GET** /smtp/blockedDomains | Get the list of blocked domains
[**GetEmailEventReport**](TransactionalEmailsApi.md#getemaileventreport) | **GET** /smtp/statistics/events | Get all your transactional email activity (unaggregated events)
[**GetScheduledEmailByBatchId**](TransactionalEmailsApi.md#getscheduledemailbybatchid) | **GET** /smtp/emailStatus/{batchId} | Fetch scheduled emails by batchId
[**GetScheduledEmailByMessageId**](TransactionalEmailsApi.md#getscheduledemailbymessageid) | **GET** /smtp/emailStatus/{messageId} | Fetch scheduled email by messageId
[**GetSmtpReport**](TransactionalEmailsApi.md#getsmtpreport) | **GET** /smtp/statistics/reports | Get your transactional email activity aggregated per day
[**GetSmtpTemplate**](TransactionalEmailsApi.md#getsmtptemplate) | **GET** /smtp/templates/{templateId} | Returns the template information
[**GetSmtpTemplates**](TransactionalEmailsApi.md#getsmtptemplates) | **GET** /smtp/templates | Get the list of email templates
[**GetTransacBlockedContacts**](TransactionalEmailsApi.md#gettransacblockedcontacts) | **GET** /smtp/blockedContacts | Get the list of blocked or unsubscribed transactional contacts
[**GetTransacEmailContent**](TransactionalEmailsApi.md#gettransacemailcontent) | **GET** /smtp/emails/{uuid} | Get the personalized content of a sent transactional email
[**GetTransacEmailsList**](TransactionalEmailsApi.md#gettransacemailslist) | **GET** /smtp/emails | Get the list of transactional emails on the basis of allowed filters
[**PostPreviewSmtpEmailTemplates**](TransactionalEmailsApi.md#postpreviewsmtpemailtemplates) | **POST** /smtp/template/preview | Generate the rendered preview of transactional template
[**SendTestTemplate**](TransactionalEmailsApi.md#sendtesttemplate) | **POST** /smtp/templates/{templateId}/sendTest | Send a template to your test list
[**SendTransacEmail**](TransactionalEmailsApi.md#sendtransacemail) | **POST** /smtp/email | Send a transactional email
[**SmtpBlockedContactsEmailDelete**](TransactionalEmailsApi.md#smtpblockedcontactsemaildelete) | **DELETE** /smtp/blockedContacts/{email} | Unblock or resubscribe a transactional contact
[**SmtpLogIdentifierDelete**](TransactionalEmailsApi.md#smtplogidentifierdelete) | **DELETE** /smtp/log/{identifier} | Delete an SMTP transactional log
[**UpdateSmtpTemplate**](TransactionalEmailsApi.md#updatesmtptemplate) | **PUT** /smtp/templates/{templateId} | Update an email template


<a name="blocknewdomain"></a>
# **BlockNewDomain**
> void BlockNewDomain (BlockDomain blockDomain)

Add a new domain to the list of blocked domains

Blocks a new domain in order to avoid messages being sent to the same

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class BlockNewDomainExample
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

            var apiInstance = new TransactionalEmailsApi();
            var blockDomain = new BlockDomain(); // BlockDomain | 

            try
            {
                // Add a new domain to the list of blocked domains
                apiInstance.BlockNewDomain(blockDomain);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.BlockNewDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **blockDomain** | [**BlockDomain**](BlockDomain.md)|  | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsmtptemplate"></a>
# **CreateSmtpTemplate**
> CreateModel CreateSmtpTemplate (CreateSmtpTemplate smtpTemplate)

Create an email template

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateSmtpTemplateExample
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

            var apiInstance = new TransactionalEmailsApi();
            var smtpTemplate = new CreateSmtpTemplate(); // CreateSmtpTemplate | values to update in transactional email template

            try
            {
                // Create an email template
                CreateModel result = apiInstance.CreateSmtpTemplate(smtpTemplate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.CreateSmtpTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **smtpTemplate** | [**CreateSmtpTemplate**](CreateSmtpTemplate.md)| values to update in transactional email template | 

### Return type

[**CreateModel**](CreateModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteblockeddomain"></a>
# **DeleteBlockedDomain**
> void DeleteBlockedDomain (string domain)

Unblock an existing domain from the list of blocked domains

Unblocks an existing domain from the list of blocked domains

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteBlockedDomainExample
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

            var apiInstance = new TransactionalEmailsApi();
            var domain = domain_example;  // string | The name of the domain to be deleted

            try
            {
                // Unblock an existing domain from the list of blocked domains
                apiInstance.DeleteBlockedDomain(domain);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.DeleteBlockedDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The name of the domain to be deleted | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletehardbounces"></a>
# **DeleteHardbounces**
> void DeleteHardbounces (DeleteHardbounces deleteHardbounces = null)

Delete hardbounces

Delete hardbounces. To use carefully (e.g. in case of temporary ISP failures)

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteHardbouncesExample
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

            var apiInstance = new TransactionalEmailsApi();
            var deleteHardbounces = new DeleteHardbounces(); // DeleteHardbounces | values to delete hardbounces (optional) 

            try
            {
                // Delete hardbounces
                apiInstance.DeleteHardbounces(deleteHardbounces);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.DeleteHardbounces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deleteHardbounces** | [**DeleteHardbounces**](DeleteHardbounces.md)| values to delete hardbounces | [optional] 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletescheduledemailbyid"></a>
# **DeleteScheduledEmailById**
> void DeleteScheduledEmailById (string identifier)

Delete scheduled emails by batchId or messageId

Delete scheduled batch of emails by batchId or single scheduled email by messageId

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteScheduledEmailByIdExample
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

            var apiInstance = new TransactionalEmailsApi();
            var identifier = identifier_example;  // string | The `batchId` of scheduled emails batch (Should be a valid UUIDv4) or the `messageId` of scheduled email.

            try
            {
                // Delete scheduled emails by batchId or messageId
                apiInstance.DeleteScheduledEmailById(identifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.DeleteScheduledEmailById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| The &#x60;batchId&#x60; of scheduled emails batch (Should be a valid UUIDv4) or the &#x60;messageId&#x60; of scheduled email. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesmtptemplate"></a>
# **DeleteSmtpTemplate**
> void DeleteSmtpTemplate (long? templateId)

Delete an inactive email template

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteSmtpTemplateExample
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

            var apiInstance = new TransactionalEmailsApi();
            var templateId = 789;  // long? | id of the template

            try
            {
                // Delete an inactive email template
                apiInstance.DeleteSmtpTemplate(templateId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.DeleteSmtpTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **long?**| id of the template | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaggregatedsmtpreport"></a>
# **GetAggregatedSmtpReport**
> GetAggregatedReport GetAggregatedSmtpReport (string startDate = null, string endDate = null, long? days = null, string tag = null)

Get your transactional email activity aggregated over a period of time

This endpoint will show the aggregated stats for past 90 days by default if `startDate` and `endDate` OR `days` is not passed. The date range can not exceed 90 days

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetAggregatedSmtpReportExample
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

            var apiInstance = new TransactionalEmailsApi();
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate (optional) 
            var days = 789;  // long? | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var tag = tag_example;  // string | Tag of the emails (optional) 

            try
            {
                // Get your transactional email activity aggregated over a period of time
                GetAggregatedReport result = apiInstance.GetAggregatedSmtpReport(startDate, endDate, days, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetAggregatedSmtpReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate | [optional] 
 **days** | **long?**| Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional] 
 **tag** | **string**| Tag of the emails | [optional] 

### Return type

[**GetAggregatedReport**](GetAggregatedReport.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getblockeddomains"></a>
# **GetBlockedDomains**
> GetBlockedDomains GetBlockedDomains ()

Get the list of blocked domains

Get the list of blocked domains

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetBlockedDomainsExample
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

            var apiInstance = new TransactionalEmailsApi();

            try
            {
                // Get the list of blocked domains
                GetBlockedDomains result = apiInstance.GetBlockedDomains();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetBlockedDomains: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetBlockedDomains**](GetBlockedDomains.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemaileventreport"></a>
# **GetEmailEventReport**
> GetEmailEventReport GetEmailEventReport (long? limit = null, long? offset = null, string startDate = null, string endDate = null, long? days = null, string email = null, string _event = null, string tags = null, string messageId = null, long? templateId = null, string sort = null)

Get all your transactional email activity (unaggregated events)

This endpoint will show the aggregated stats for past 30 days by default if `startDate` and `endDate` OR `days` is not passed. The date range can not exceed 90 days

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetEmailEventReportExample
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

            var apiInstance = new TransactionalEmailsApi();
            var limit = 789;  // long? | Number limitation for the result returned (optional)  (default to 2500)
            var offset = 789;  // long? | Beginning point in the list to retrieve from. (optional)  (default to 0)
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate (optional) 
            var days = 789;  // long? | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var email = email_example;  // string | Filter the report for a specific email addresses (optional) 
            var _event = _event_example;  // string | Filter the report for a specific event type (optional) 
            var tags = tags_example;  // string | Filter the report for tags (serialized and urlencoded array) (optional) 
            var messageId = messageId_example;  // string | Filter on a specific message id (optional) 
            var templateId = 789;  // long? | Filter on a specific template id (optional) 
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Get all your transactional email activity (unaggregated events)
                GetEmailEventReport result = apiInstance.GetEmailEventReport(limit, offset, startDate, endDate, days, email, _event, tags, messageId, templateId, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetEmailEventReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number limitation for the result returned | [optional] [default to 2500]
 **offset** | **long?**| Beginning point in the list to retrieve from. | [optional] [default to 0]
 **startDate** | **string**| Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate | [optional] 
 **days** | **long?**| Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional] 
 **email** | **string**| Filter the report for a specific email addresses | [optional] 
 **_event** | **string**| Filter the report for a specific event type | [optional] 
 **tags** | **string**| Filter the report for tags (serialized and urlencoded array) | [optional] 
 **messageId** | **string**| Filter on a specific message id | [optional] 
 **templateId** | **long?**| Filter on a specific template id | [optional] 
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]

### Return type

[**GetEmailEventReport**](GetEmailEventReport.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscheduledemailbybatchid"></a>
# **GetScheduledEmailByBatchId**
> GetScheduledEmailByBatchId GetScheduledEmailByBatchId (string batchId, DateTime? startDate = null, DateTime? endDate = null, string sort = null, string status = null, long? limit = null, long? offset = null)

Fetch scheduled emails by batchId

Fetch scheduled batch of emails by batchId (Can retrieve data upto 30 days old)

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetScheduledEmailByBatchIdExample
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

            var apiInstance = new TransactionalEmailsApi();
            var batchId = batchId_example;  // string | The batchId of scheduled emails batch (Should be a valid UUIDv4)
            var startDate = 2013-10-20;  // DateTime? | Mandatory if `endDate` is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Can be maximum 30 days older tha current date. (optional) 
            var endDate = 2013-10-20;  // DateTime? | Mandatory if `startDate` is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)
            var status = status_example;  // string | Filter the records by `status` of the scheduled email batch or message. (optional) 
            var limit = 789;  // long? | Number of documents returned per page (optional)  (default to 100)
            var offset = 789;  // long? | Index of the first document on the page (optional)  (default to 0)

            try
            {
                // Fetch scheduled emails by batchId
                GetScheduledEmailByBatchId result = apiInstance.GetScheduledEmailByBatchId(batchId, startDate, endDate, sort, status, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetScheduledEmailByBatchId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **string**| The batchId of scheduled emails batch (Should be a valid UUIDv4) | 
 **startDate** | **DateTime?**| Mandatory if &#x60;endDate&#x60; is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Can be maximum 30 days older tha current date. | [optional] 
 **endDate** | **DateTime?**| Mandatory if &#x60;startDate&#x60; is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. | [optional] 
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]
 **status** | **string**| Filter the records by &#x60;status&#x60; of the scheduled email batch or message. | [optional] 
 **limit** | **long?**| Number of documents returned per page | [optional] [default to 100]
 **offset** | **long?**| Index of the first document on the page | [optional] [default to 0]

### Return type

[**GetScheduledEmailByBatchId**](GetScheduledEmailByBatchId.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getscheduledemailbymessageid"></a>
# **GetScheduledEmailByMessageId**
> GetScheduledEmailByMessageId GetScheduledEmailByMessageId (string messageId, DateTime? startDate = null, DateTime? endDate = null)

Fetch scheduled email by messageId

Fetch scheduled email by messageId (Can retrieve data upto 30 days old)

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetScheduledEmailByMessageIdExample
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

            var apiInstance = new TransactionalEmailsApi();
            var messageId = messageId_example;  // string | The messageId of scheduled email
            var startDate = 2013-10-20;  // DateTime? | Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Can be maximum 30 days older tha current date. (optional) 
            var endDate = 2013-10-20;  // DateTime? | Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 

            try
            {
                // Fetch scheduled email by messageId
                GetScheduledEmailByMessageId result = apiInstance.GetScheduledEmailByMessageId(messageId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetScheduledEmailByMessageId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| The messageId of scheduled email | 
 **startDate** | **DateTime?**| Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Can be maximum 30 days older tha current date. | [optional] 
 **endDate** | **DateTime?**| Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. | [optional] 

### Return type

[**GetScheduledEmailByMessageId**](GetScheduledEmailByMessageId.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmtpreport"></a>
# **GetSmtpReport**
> GetReports GetSmtpReport (long? limit = null, long? offset = null, string startDate = null, string endDate = null, long? days = null, string tag = null, string sort = null)

Get your transactional email activity aggregated per day

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetSmtpReportExample
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

            var apiInstance = new TransactionalEmailsApi();
            var limit = 789;  // long? | Number of documents returned per page (optional)  (default to 10)
            var offset = 789;  // long? | Index of the first document on the page (optional)  (default to 0)
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD) (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD) (optional) 
            var days = 789;  // long? | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var tag = tag_example;  // string | Tag of the emails (optional) 
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Get your transactional email activity aggregated per day
                GetReports result = apiInstance.GetSmtpReport(limit, offset, startDate, endDate, days, tag, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetSmtpReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents returned per page | [optional] [default to 10]
 **offset** | **long?**| Index of the first document on the page | [optional] [default to 0]
 **startDate** | **string**| Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD) | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD) | [optional] 
 **days** | **long?**| Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional] 
 **tag** | **string**| Tag of the emails | [optional] 
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]

### Return type

[**GetReports**](GetReports.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmtptemplate"></a>
# **GetSmtpTemplate**
> GetSmtpTemplateOverview GetSmtpTemplate (long? templateId)

Returns the template information

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetSmtpTemplateExample
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

            var apiInstance = new TransactionalEmailsApi();
            var templateId = 789;  // long? | id of the template

            try
            {
                // Returns the template information
                GetSmtpTemplateOverview result = apiInstance.GetSmtpTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetSmtpTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **long?**| id of the template | 

### Return type

[**GetSmtpTemplateOverview**](GetSmtpTemplateOverview.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsmtptemplates"></a>
# **GetSmtpTemplates**
> GetSmtpTemplates GetSmtpTemplates (bool? templateStatus = null, long? limit = null, long? offset = null, string sort = null)

Get the list of email templates

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetSmtpTemplatesExample
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

            var apiInstance = new TransactionalEmailsApi();
            var templateStatus = true;  // bool? | Filter on the status of the template. Active = true, inactive = false (optional) 
            var limit = 789;  // long? | Number of documents returned per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document in the page (optional)  (default to 0)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Get the list of email templates
                GetSmtpTemplates result = apiInstance.GetSmtpTemplates(templateStatus, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetSmtpTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateStatus** | **bool?**| Filter on the status of the template. Active &#x3D; true, inactive &#x3D; false | [optional] 
 **limit** | **long?**| Number of documents returned per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document in the page | [optional] [default to 0]
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]

### Return type

[**GetSmtpTemplates**](GetSmtpTemplates.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransacblockedcontacts"></a>
# **GetTransacBlockedContacts**
> GetTransacBlockedContacts GetTransacBlockedContacts (string startDate = null, string endDate = null, long? limit = null, long? offset = null, List<string> senders = null, string sort = null)

Get the list of blocked or unsubscribed transactional contacts

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetTransacBlockedContactsExample
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

            var apiInstance = new TransactionalEmailsApi();
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the blocked or unsubscribed contacts (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the blocked or unsubscribed contacts (optional) 
            var limit = 789;  // long? | Number of documents returned per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document on the page (optional)  (default to 0)
            var senders = new List<string>(); // List<string> | Comma separated list of emails of the senders from which contacts are blocked or unsubscribed (optional) 
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Get the list of blocked or unsubscribed transactional contacts
                GetTransacBlockedContacts result = apiInstance.GetTransacBlockedContacts(startDate, endDate, limit, offset, senders, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetTransacBlockedContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the blocked or unsubscribed contacts | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the blocked or unsubscribed contacts | [optional] 
 **limit** | **long?**| Number of documents returned per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document on the page | [optional] [default to 0]
 **senders** | [**List&lt;string&gt;**](string.md)| Comma separated list of emails of the senders from which contacts are blocked or unsubscribed | [optional] 
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]

### Return type

[**GetTransacBlockedContacts**](GetTransacBlockedContacts.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransacemailcontent"></a>
# **GetTransacEmailContent**
> GetTransacEmailContent GetTransacEmailContent (string uuid)

Get the personalized content of a sent transactional email

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetTransacEmailContentExample
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

            var apiInstance = new TransactionalEmailsApi();
            var uuid = uuid_example;  // string | Unique id of the transactional email that has been sent to a particular contact

            try
            {
                // Get the personalized content of a sent transactional email
                GetTransacEmailContent result = apiInstance.GetTransacEmailContent(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetTransacEmailContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| Unique id of the transactional email that has been sent to a particular contact | 

### Return type

[**GetTransacEmailContent**](GetTransacEmailContent.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransacemailslist"></a>
# **GetTransacEmailsList**
> GetTransacEmailsList GetTransacEmailsList (string email = null, long? templateId = null, string messageId = null, string startDate = null, string endDate = null, string sort = null, long? limit = null, long? offset = null)

Get the list of transactional emails on the basis of allowed filters

This endpoint will show the list of emails for past 30 days by default. To retrieve emails before that time, please pass startDate and endDate in query filters.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetTransacEmailsListExample
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

            var apiInstance = new TransactionalEmailsApi();
            var email = email_example;  // string | Mandatory if templateId and messageId are not passed in query filters. Email address to which transactional email has been sent. (optional) 
            var templateId = 789;  // long? | Mandatory if email and messageId are not passed in query filters. Id of the template that was used to compose transactional email. (optional) 
            var messageId = messageId_example;  // string | Mandatory if templateId and email are not passed in query filters. Message ID of the transactional email sent. (optional) 
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)
            var limit = 789;  // long? | Number of documents returned per page (optional)  (default to 500)
            var offset = 789;  // long? | Index of the first document in the page (optional)  (default to 0)

            try
            {
                // Get the list of transactional emails on the basis of allowed filters
                GetTransacEmailsList result = apiInstance.GetTransacEmailsList(email, templateId, messageId, startDate, endDate, sort, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.GetTransacEmailsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Mandatory if templateId and messageId are not passed in query filters. Email address to which transactional email has been sent. | [optional] 
 **templateId** | **long?**| Mandatory if email and messageId are not passed in query filters. Id of the template that was used to compose transactional email. | [optional] 
 **messageId** | **string**| Mandatory if templateId and email are not passed in query filters. Message ID of the transactional email sent. | [optional] 
 **startDate** | **string**| Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Maximum time period that can be selected is one month. | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. | [optional] 
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]
 **limit** | **long?**| Number of documents returned per page | [optional] [default to 500]
 **offset** | **long?**| Index of the first document in the page | [optional] [default to 0]

### Return type

[**GetTransacEmailsList**](GetTransacEmailsList.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpreviewsmtpemailtemplates"></a>
# **PostPreviewSmtpEmailTemplates**
> TemplatePreview PostPreviewSmtpEmailTemplates (FetchTemplatePreview fetchTemplatePreview)

Generate the rendered preview of transactional template

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class PostPreviewSmtpEmailTemplatesExample
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

            var apiInstance = new TransactionalEmailsApi();
            var fetchTemplatePreview = new FetchTemplatePreview(); // FetchTemplatePreview | Values to fetch Template preview

            try
            {
                // Generate the rendered preview of transactional template
                TemplatePreview result = apiInstance.PostPreviewSmtpEmailTemplates(fetchTemplatePreview);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.PostPreviewSmtpEmailTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fetchTemplatePreview** | [**FetchTemplatePreview**](FetchTemplatePreview.md)| Values to fetch Template preview | 

### Return type

[**TemplatePreview**](TemplatePreview.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtesttemplate"></a>
# **SendTestTemplate**
> void SendTestTemplate (long? templateId, SendTestEmail sendTestEmail)

Send a template to your test list

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SendTestTemplateExample
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

            var apiInstance = new TransactionalEmailsApi();
            var templateId = 789;  // long? | Id of the template
            var sendTestEmail = new SendTestEmail(); // SendTestEmail | 

            try
            {
                // Send a template to your test list
                apiInstance.SendTestTemplate(templateId, sendTestEmail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.SendTestTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **long?**| Id of the template | 
 **sendTestEmail** | [**SendTestEmail**](SendTestEmail.md)|  | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtransacemail"></a>
# **SendTransacEmail**
> CreateSmtpEmail SendTransacEmail (SendSmtpEmail sendSmtpEmail)

Send a transactional email

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SendTransacEmailExample
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

            var apiInstance = new TransactionalEmailsApi();
            var sendSmtpEmail = new SendSmtpEmail(); // SendSmtpEmail | Values to send a transactional email

            try
            {
                // Send a transactional email
                CreateSmtpEmail result = apiInstance.SendTransacEmail(sendSmtpEmail);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.SendTransacEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sendSmtpEmail** | [**SendSmtpEmail**](SendSmtpEmail.md)| Values to send a transactional email | 

### Return type

[**CreateSmtpEmail**](CreateSmtpEmail.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smtpblockedcontactsemaildelete"></a>
# **SmtpBlockedContactsEmailDelete**
> void SmtpBlockedContactsEmailDelete (string email)

Unblock or resubscribe a transactional contact

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SmtpBlockedContactsEmailDeleteExample
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

            var apiInstance = new TransactionalEmailsApi();
            var email = email_example;  // string | contact email (urlencoded) to unblock.

            try
            {
                // Unblock or resubscribe a transactional contact
                apiInstance.SmtpBlockedContactsEmailDelete(email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.SmtpBlockedContactsEmailDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| contact email (urlencoded) to unblock. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="smtplogidentifierdelete"></a>
# **SmtpLogIdentifierDelete**
> void SmtpLogIdentifierDelete (string identifier)

Delete an SMTP transactional log

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SmtpLogIdentifierDeleteExample
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

            var apiInstance = new TransactionalEmailsApi();
            var identifier = identifier_example;  // string | MessageId or Email of the transactional log(s) to delete

            try
            {
                // Delete an SMTP transactional log
                apiInstance.SmtpLogIdentifierDelete(identifier);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.SmtpLogIdentifierDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | **string**| MessageId or Email of the transactional log(s) to delete | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesmtptemplate"></a>
# **UpdateSmtpTemplate**
> void UpdateSmtpTemplate (long? templateId, UpdateSmtpTemplate smtpTemplate)

Update an email template

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateSmtpTemplateExample
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

            var apiInstance = new TransactionalEmailsApi();
            var templateId = 789;  // long? | id of the template
            var smtpTemplate = new UpdateSmtpTemplate(); // UpdateSmtpTemplate | values to update in transactional email template

            try
            {
                // Update an email template
                apiInstance.UpdateSmtpTemplate(templateId, smtpTemplate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalEmailsApi.UpdateSmtpTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **long?**| id of the template | 
 **smtpTemplate** | [**UpdateSmtpTemplate**](UpdateSmtpTemplate.md)| values to update in transactional email template | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

