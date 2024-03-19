# brevo_csharp.Api.TransactionalWhatsAppApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWhatsappEventReport**](TransactionalWhatsAppApi.md#getwhatsappeventreport) | **GET** /whatsapp/statistics/events | Get all your WhatsApp activity (unaggregated events)
[**SendWhatsappMessage**](TransactionalWhatsAppApi.md#sendwhatsappmessage) | **POST** /whatsapp/sendMessage | Send a WhatsApp message


<a name="getwhatsappeventreport"></a>
# **GetWhatsappEventReport**
> GetWhatsappEventReport GetWhatsappEventReport (long? limit = null, long? offset = null, string startDate = null, string endDate = null, long? days = null, string contactNumber = null, string _event = null, string sort = null)

Get all your WhatsApp activity (unaggregated events)

This endpoint will show the unaggregated statistics for WhatsApp activity (30 days by default if `startDate` and `endDate` or `days` is not passed. The date range can not exceed 90 days)

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetWhatsappEventReportExample
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

            var apiInstance = new TransactionalWhatsAppApi();
            var limit = 789;  // long? | Number limitation for the result returned (optional)  (default to 2500)
            var offset = 789;  // long? | Beginning point in the list to retrieve from (optional)  (default to 0)
            var startDate = startDate_example;  // string | **Mandatory if endDate is used.** Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate  (optional) 
            var endDate = endDate_example;  // string | **Mandatory if startDate is used.** Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate  (optional) 
            var days = 789;  // long? | Number of days in the past including today (positive integer). _Not compatible with 'startDate' and 'endDate'_  (optional) 
            var contactNumber = contactNumber_example;  // string | Filter results for specific contact (WhatsApp Number with country code. Example, 85264318721) (optional) 
            var _event = _event_example;  // string | Filter the report for a specific event type (optional) 
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Get all your WhatsApp activity (unaggregated events)
                GetWhatsappEventReport result = apiInstance.GetWhatsappEventReport(limit, offset, startDate, endDate, days, contactNumber, _event, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalWhatsAppApi.GetWhatsappEventReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number limitation for the result returned | [optional] [default to 2500]
 **offset** | **long?**| Beginning point in the list to retrieve from | [optional] [default to 0]
 **startDate** | **string**| **Mandatory if endDate is used.** Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate  | [optional] 
 **endDate** | **string**| **Mandatory if startDate is used.** Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate  | [optional] 
 **days** | **long?**| Number of days in the past including today (positive integer). _Not compatible with &#39;startDate&#39; and &#39;endDate&#39;_  | [optional] 
 **contactNumber** | **string**| Filter results for specific contact (WhatsApp Number with country code. Example, 85264318721) | [optional] 
 **_event** | **string**| Filter the report for a specific event type | [optional] 
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]

### Return type

[**GetWhatsappEventReport**](GetWhatsappEventReport.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendwhatsappmessage"></a>
# **SendWhatsappMessage**
> InlineResponse2014 SendWhatsappMessage (SendWhatsappMessage sendWhatsappMessage)

Send a WhatsApp message

This endpoint is used to send a WhatsApp message. <br/>(**The first message you send using the API must contain a Template ID. You must create a template on WhatsApp on the Brevo platform to fetch the Template ID.**)

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SendWhatsappMessageExample
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

            var apiInstance = new TransactionalWhatsAppApi();
            var sendWhatsappMessage = new SendWhatsappMessage(); // SendWhatsappMessage | Values to send WhatsApp message

            try
            {
                // Send a WhatsApp message
                InlineResponse2014 result = apiInstance.SendWhatsappMessage(sendWhatsappMessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionalWhatsAppApi.SendWhatsappMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sendWhatsappMessage** | [**SendWhatsappMessage**](SendWhatsappMessage.md)| Values to send WhatsApp message | 

### Return type

[**InlineResponse2014**](InlineResponse2014.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

