# brevo_csharp.Api.TierApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSubscriptionToTier**](TierApi.md#addsubscriptiontotier) | **POST** /loyalty/tier/programs/{pid}/contacts/{cid}/tiers/{tid} | Assign a tier
[**CreateTierForTierGroup**](TierApi.md#createtierfortiergroup) | **POST** /loyalty/tier/programs/{pid}/tier-groups/{gid}/tiers | Create a tier
[**CreateTierGroup**](TierApi.md#createtiergroup) | **POST** /loyalty/tier/programs/{pid}/tier-groups | Create a tier group
[**DeleteTier**](TierApi.md#deletetier) | **DELETE** /loyalty/tier/programs/{pid}/tiers/{tid} | Delete tier
[**DeleteTierGroup**](TierApi.md#deletetiergroup) | **DELETE** /loyalty/tier/programs/{pid}/tier-groups/{gid} | Delete tier group
[**GetListOfTierGroups**](TierApi.md#getlistoftiergroups) | **GET** /loyalty/tier/programs/{pid}/tier-groups | List tier groups
[**GetLoyaltyProgramTier**](TierApi.md#getloyaltyprogramtier) | **GET** /loyalty/tier/programs/{pid}/tiers | List tiers
[**GetTierGroup**](TierApi.md#gettiergroup) | **GET** /loyalty/tier/programs/{pid}/tier-groups/{gid} | Get tier group
[**UpdateTier**](TierApi.md#updatetier) | **PUT** /loyalty/tier/programs/{pid}/tiers/{tid} | Update tier
[**UpdateTierGroup**](TierApi.md#updatetiergroup) | **PUT** /loyalty/tier/programs/{pid}/tier-groups/{gid} | Update tier group


<a name="addsubscriptiontotier"></a>
# **AddSubscriptionToTier**
> TierForContact AddSubscriptionToTier (Guid? pid, Guid? cid, Guid? tid)

Assign a tier

Manually assigns a tier to a specific membership.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class AddSubscriptionToTierExample
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

            var apiInstance = new TierApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var cid = new Guid?(); // Guid? | Contact ID
            var tid = new Guid?(); // Guid? | Tier ID

            try
            {
                // Assign a tier
                TierForContact result = apiInstance.AddSubscriptionToTier(pid, cid, tid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TierApi.AddSubscriptionToTier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **cid** | [**Guid?**](Guid?.md)| Contact ID | 
 **tid** | [**Guid?**](Guid?.md)| Tier ID | 

### Return type

[**TierForContact**](TierForContact.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtierfortiergroup"></a>
# **CreateTierForTierGroup**
> Tier CreateTierForTierGroup (Guid? pid, Guid? gid, TierRequest payload)

Create a tier

Creates a new tier in a loyalty program tier group. *(The changes will take effect with the next publication of the loyalty program)*

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateTierForTierGroupExample
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

            var apiInstance = new TierApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var gid = new Guid?(); // Guid? | Tier group ID
            var payload = new TierRequest(); // TierRequest | 

            try
            {
                // Create a tier
                Tier result = apiInstance.CreateTierForTierGroup(pid, gid, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TierApi.CreateTierForTierGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **gid** | [**Guid?**](Guid?.md)| Tier group ID | 
 **payload** | [**TierRequest**](TierRequest.md)|  | 

### Return type

[**Tier**](Tier.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtiergroup"></a>
# **CreateTierGroup**
> TierGroup CreateTierGroup (Guid? pid, CreateTierGroupRequest payload)

Create a tier group

Creates a new tier group in a loyalty program. *(The changes will take effect with the next publication of the loyalty program)*

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateTierGroupExample
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

            var apiInstance = new TierApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var payload = new CreateTierGroupRequest(); // CreateTierGroupRequest | Tier group creation payload

            try
            {
                // Create a tier group
                TierGroup result = apiInstance.CreateTierGroup(pid, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TierApi.CreateTierGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **payload** | [**CreateTierGroupRequest**](CreateTierGroupRequest.md)| Tier group creation payload | 

### Return type

[**TierGroup**](TierGroup.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetier"></a>
# **DeleteTier**
> string DeleteTier (Guid? pid, Guid? tid)

Delete tier

Deletes a tier from a loyalty program tier group. *(The changes will take effect with the next publication of the loyalty program)*

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteTierExample
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

            var apiInstance = new TierApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var tid = new Guid?(); // Guid? | Tier ID

            try
            {
                // Delete tier
                string result = apiInstance.DeleteTier(pid, tid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TierApi.DeleteTier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **tid** | [**Guid?**](Guid?.md)| Tier ID | 

### Return type

**string**

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetiergroup"></a>
# **DeleteTierGroup**
> string DeleteTierGroup (Guid? pid, Guid? gid)

Delete tier group

Deletes a tier group from a loyalty program. *(The changes will take effect with the next publication of the loyalty program)*

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteTierGroupExample
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

            var apiInstance = new TierApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var gid = new Guid?(); // Guid? | Tier group ID

            try
            {
                // Delete tier group
                string result = apiInstance.DeleteTierGroup(pid, gid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TierApi.DeleteTierGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **gid** | [**Guid?**](Guid?.md)| Tier group ID | 

### Return type

**string**

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlistoftiergroups"></a>
# **GetListOfTierGroups**
> TierGroupPage GetListOfTierGroups (Guid? pid, string version = null)

List tier groups

Returns the list of tier groups defined within the loyalty program.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetListOfTierGroupsExample
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

            var apiInstance = new TierApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var version = version_example;  // string | Select 'active' to retrieve list of all tier groups which are live for clients. Select draft to retrieve list of all non deleted tier groups. (optional)  (default to draft)

            try
            {
                // List tier groups
                TierGroupPage result = apiInstance.GetListOfTierGroups(pid, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TierApi.GetListOfTierGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **version** | **string**| Select &#39;active&#39; to retrieve list of all tier groups which are live for clients. Select draft to retrieve list of all non deleted tier groups. | [optional] [default to draft]

### Return type

[**TierGroupPage**](TierGroupPage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getloyaltyprogramtier"></a>
# **GetLoyaltyProgramTier**
> LoyaltyTierPage GetLoyaltyProgramTier (Guid? pid, string version = null)

List tiers

Returns the list of tiers defined within the loyalty program.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetLoyaltyProgramTierExample
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

            var apiInstance = new TierApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var version = version_example;  // string | Select 'active' to retrieve list of all tiers which are live for clients. Select draft to retrieve list of all non deleted tiers. (optional)  (default to draft)

            try
            {
                // List tiers
                LoyaltyTierPage result = apiInstance.GetLoyaltyProgramTier(pid, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TierApi.GetLoyaltyProgramTier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **version** | **string**| Select &#39;active&#39; to retrieve list of all tiers which are live for clients. Select draft to retrieve list of all non deleted tiers. | [optional] [default to draft]

### Return type

[**LoyaltyTierPage**](LoyaltyTierPage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettiergroup"></a>
# **GetTierGroup**
> TierGroup GetTierGroup (Guid? pid, Guid? gid, string version = null)

Get tier group

Returns tier group information.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetTierGroupExample
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

            var apiInstance = new TierApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var gid = new Guid?(); // Guid? | Tier group ID
            var version = version_example;  // string | Select active to retrieve active version of tier group. Select draft to retrieve latest changes in tier group. (optional)  (default to draft)

            try
            {
                // Get tier group
                TierGroup result = apiInstance.GetTierGroup(pid, gid, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TierApi.GetTierGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **gid** | [**Guid?**](Guid?.md)| Tier group ID | 
 **version** | **string**| Select active to retrieve active version of tier group. Select draft to retrieve latest changes in tier group. | [optional] [default to draft]

### Return type

[**TierGroup**](TierGroup.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetier"></a>
# **UpdateTier**
> Tier UpdateTier (Guid? pid, Guid? tid, TierRequestPutPayload payload)

Update tier

Modifies an existing tier for the specified tier group *(The changes will take effect with the next publication of the loyalty program)*

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateTierExample
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

            var apiInstance = new TierApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var tid = new Guid?(); // Guid? | Tier ID
            var payload = new TierRequestPutPayload(); // TierRequestPutPayload | 

            try
            {
                // Update tier
                Tier result = apiInstance.UpdateTier(pid, tid, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TierApi.UpdateTier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **tid** | [**Guid?**](Guid?.md)| Tier ID | 
 **payload** | [**TierRequestPutPayload**](TierRequestPutPayload.md)|  | 

### Return type

[**Tier**](Tier.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetiergroup"></a>
# **UpdateTierGroup**
> TierGroup UpdateTierGroup (Guid? pid, Guid? gid, UpdateTierGroupRequest payload)

Update tier group

Updates a tier group from a loyalty program. *(The changes will take effect with the next publication of the loyalty program)*

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateTierGroupExample
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

            var apiInstance = new TierApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var gid = new Guid?(); // Guid? | Tier group ID
            var payload = new UpdateTierGroupRequest(); // UpdateTierGroupRequest | Tier group update payload

            try
            {
                // Update tier group
                TierGroup result = apiInstance.UpdateTierGroup(pid, gid, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TierApi.UpdateTierGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **gid** | [**Guid?**](Guid?.md)| Tier group ID | 
 **payload** | [**UpdateTierGroupRequest**](UpdateTierGroupRequest.md)| Tier group update payload | 

### Return type

[**TierGroup**](TierGroup.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

