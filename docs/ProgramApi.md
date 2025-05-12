# brevo_csharp.Api.ProgramApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNewLP**](ProgramApi.md#createnewlp) | **POST** /loyalty/config/programs | Create loyalty program
[**DeleteContactMembers**](ProgramApi.md#deletecontactmembers) | **DELETE** /loyalty/config/programs/{pid}/subscription-members | Delete subscription member
[**DeleteLoyaltyProgram**](ProgramApi.md#deleteloyaltyprogram) | **DELETE** /loyalty/config/programs/{pid} | Delete Loyalty Program
[**GetLPList**](ProgramApi.md#getlplist) | **GET** /loyalty/config/programs | Get loyalty program list
[**GetLoyaltyProgramInfo**](ProgramApi.md#getloyaltyprograminfo) | **GET** /loyalty/config/programs/{pid} | Get loyalty program Info
[**GetParameterSubscriptionInfo**](ProgramApi.md#getparametersubscriptioninfo) | **GET** /loyalty/config/programs/{pid}/account-info | Get Subscription Data
[**PartiallyUpdateLoyaltyProgram**](ProgramApi.md#partiallyupdateloyaltyprogram) | **PATCH** /loyalty/config/programs/{pid} | Partially update loyalty program
[**PublishLoyaltyProgram**](ProgramApi.md#publishloyaltyprogram) | **POST** /loyalty/config/programs/{pid}/publish | Publish loyalty program
[**SubscribeMemberToASubscription**](ProgramApi.md#subscribemembertoasubscription) | **POST** /loyalty/config/programs/{pid}/subscription-members | Create subscription member
[**SubscribeToLoyaltyProgram**](ProgramApi.md#subscribetoloyaltyprogram) | **POST** /loyalty/config/programs/{pid}/subscriptions | Create subscription
[**UpdateLoyaltyProgram**](ProgramApi.md#updateloyaltyprogram) | **PUT** /loyalty/config/programs/{pid} | Update loyalty program


<a name="createnewlp"></a>
# **CreateNewLP**
> LoyaltyProgram CreateNewLP (CreateLoyaltyProgramPayload body)

Create loyalty program

Creates loyalty program

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateNewLPExample
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

            var apiInstance = new ProgramApi();
            var body = new CreateLoyaltyProgramPayload(); // CreateLoyaltyProgramPayload | Create Loyalty Program Payload

            try
            {
                // Create loyalty program
                LoyaltyProgram result = apiInstance.CreateNewLP(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.CreateNewLP: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateLoyaltyProgramPayload**](CreateLoyaltyProgramPayload.md)| Create Loyalty Program Payload | 

### Return type

[**LoyaltyProgram**](LoyaltyProgram.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontactmembers"></a>
# **DeleteContactMembers**
> void DeleteContactMembers (Guid? pid, string memberContactIds)

Delete subscription member

Deletes member from a subscription

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteContactMembersExample
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

            var apiInstance = new ProgramApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var memberContactIds = memberContactIds_example;  // string | Member Contact Ids

            try
            {
                // Delete subscription member
                apiInstance.DeleteContactMembers(pid, memberContactIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.DeleteContactMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **memberContactIds** | **string**| Member Contact Ids | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteloyaltyprogram"></a>
# **DeleteLoyaltyProgram**
> void DeleteLoyaltyProgram (Guid? pid)

Delete Loyalty Program

Deletes Loyalty Program

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteLoyaltyProgramExample
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

            var apiInstance = new ProgramApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id

            try
            {
                // Delete Loyalty Program
                apiInstance.DeleteLoyaltyProgram(pid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.DeleteLoyaltyProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlplist"></a>
# **GetLPList**
> LoyaltyProgramPage GetLPList (int? limit = null, int? offset = null, string sortField = null, string sort = null)

Get loyalty program list

Returns list of loyalty programs

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetLPListExample
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

            var apiInstance = new ProgramApi();
            var limit = 56;  // int? | Number of documents per page (optional) 
            var offset = 56;  // int? | Index of the first document in the page (optional) 
            var sortField = sortField_example;  // string | Sort documents by field (optional) 
            var sort = sort_example;  // string | Sort the documents in the ascending or descending order (optional) 

            try
            {
                // Get loyalty program list
                LoyaltyProgramPage result = apiInstance.GetLPList(limit, offset, sortField, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.GetLPList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Number of documents per page | [optional] 
 **offset** | **int?**| Index of the first document in the page | [optional] 
 **sortField** | **string**| Sort documents by field | [optional] 
 **sort** | **string**| Sort the documents in the ascending or descending order | [optional] 

### Return type

[**LoyaltyProgramPage**](LoyaltyProgramPage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltyprograminfo"></a>
# **GetLoyaltyProgramInfo**
> LoyaltyProgram GetLoyaltyProgramInfo (Guid? pid)

Get loyalty program Info

Returns loyalty program

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetLoyaltyProgramInfoExample
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

            var apiInstance = new ProgramApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id

            try
            {
                // Get loyalty program Info
                LoyaltyProgram result = apiInstance.GetLoyaltyProgramInfo(pid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.GetLoyaltyProgramInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 

### Return type

[**LoyaltyProgram**](LoyaltyProgram.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparametersubscriptioninfo"></a>
# **GetParameterSubscriptionInfo**
> SubscriptionHandlerInfo GetParameterSubscriptionInfo (Guid? pid, string contactId = null, string _params = null, string loyaltySubscriptionId = null)

Get Subscription Data

Get Information of balances, tiers, rewards and subscription members for a subscription

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetParameterSubscriptionInfoExample
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

            var apiInstance = new ProgramApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var contactId = contactId_example;  // string | Contact Id (optional) 
            var _params = _params_example;  // string | Filter List (optional) 
            var loyaltySubscriptionId = loyaltySubscriptionId_example;  // string | Loyalty Subscription Id (optional) 

            try
            {
                // Get Subscription Data
                SubscriptionHandlerInfo result = apiInstance.GetParameterSubscriptionInfo(pid, contactId, _params, loyaltySubscriptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.GetParameterSubscriptionInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **contactId** | **string**| Contact Id | [optional] 
 **_params** | **string**| Filter List | [optional] 
 **loyaltySubscriptionId** | **string**| Loyalty Subscription Id | [optional] 

### Return type

[**SubscriptionHandlerInfo**](SubscriptionHandlerInfo.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="partiallyupdateloyaltyprogram"></a>
# **PartiallyUpdateLoyaltyProgram**
> LoyaltyProgram PartiallyUpdateLoyaltyProgram (Guid? pid, PatchLoyaltyProgramPayload body)

Partially update loyalty program

Partially updates loyalty program

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class PartiallyUpdateLoyaltyProgramExample
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

            var apiInstance = new ProgramApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var body = new PatchLoyaltyProgramPayload(); // PatchLoyaltyProgramPayload | Loyalty Program Payload

            try
            {
                // Partially update loyalty program
                LoyaltyProgram result = apiInstance.PartiallyUpdateLoyaltyProgram(pid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.PartiallyUpdateLoyaltyProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **body** | [**PatchLoyaltyProgramPayload**](PatchLoyaltyProgramPayload.md)| Loyalty Program Payload | 

### Return type

[**LoyaltyProgram**](LoyaltyProgram.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publishloyaltyprogram"></a>
# **PublishLoyaltyProgram**
> void PublishLoyaltyProgram (Guid? pid)

Publish loyalty program

Publishes loyalty program

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class PublishLoyaltyProgramExample
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

            var apiInstance = new ProgramApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id

            try
            {
                // Publish loyalty program
                apiInstance.PublishLoyaltyProgram(pid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.PublishLoyaltyProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribemembertoasubscription"></a>
# **SubscribeMemberToASubscription**
> SubscriptionMember SubscribeMemberToASubscription (Guid? pid, AddSubscriptionMemberPayload body)

Create subscription member

Add member to a subscription

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SubscribeMemberToASubscriptionExample
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

            var apiInstance = new ProgramApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var body = new AddSubscriptionMemberPayload(); // AddSubscriptionMemberPayload | Add Subscription Member Payload

            try
            {
                // Create subscription member
                SubscriptionMember result = apiInstance.SubscribeMemberToASubscription(pid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.SubscribeMemberToASubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **body** | [**AddSubscriptionMemberPayload**](AddSubscriptionMemberPayload.md)| Add Subscription Member Payload | 

### Return type

[**SubscriptionMember**](SubscriptionMember.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subscribetoloyaltyprogram"></a>
# **SubscribeToLoyaltyProgram**
> Subscription SubscribeToLoyaltyProgram (Guid? pid, CreateSubscriptionPayload body)

Create subscription

Subscribes to a loyalty program

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SubscribeToLoyaltyProgramExample
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

            var apiInstance = new ProgramApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var body = new CreateSubscriptionPayload(); // CreateSubscriptionPayload | Create Subscription Payload

            try
            {
                // Create subscription
                Subscription result = apiInstance.SubscribeToLoyaltyProgram(pid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.SubscribeToLoyaltyProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **body** | [**CreateSubscriptionPayload**](CreateSubscriptionPayload.md)| Create Subscription Payload | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateloyaltyprogram"></a>
# **UpdateLoyaltyProgram**
> LoyaltyProgram UpdateLoyaltyProgram (Guid? pid, UpdateLoyaltyProgramPayload body)

Update loyalty program

Updates loyalty program

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateLoyaltyProgramExample
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

            var apiInstance = new ProgramApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var body = new UpdateLoyaltyProgramPayload(); // UpdateLoyaltyProgramPayload | Update Loyalty Program Payload

            try
            {
                // Update loyalty program
                LoyaltyProgram result = apiInstance.UpdateLoyaltyProgram(pid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProgramApi.UpdateLoyaltyProgram: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **body** | [**UpdateLoyaltyProgramPayload**](UpdateLoyaltyProgramPayload.md)| Update Loyalty Program Payload | 

### Return type

[**LoyaltyProgram**](LoyaltyProgram.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

