# brevo_csharp.Api.RewardApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCodeCount**](RewardApi.md#getcodecount) | **GET** /loyalty/offer/programs/{pid}/code-pools/{cpid}/codes-count | Get code count
[**LoyaltyOfferProgramsPidOffersGet**](RewardApi.md#loyaltyofferprogramspidoffersget) | **GET** /loyalty/offer/programs/{pid}/offers | Get Reward Page API
[**LoyaltyOfferProgramsPidOffersPost**](RewardApi.md#loyaltyofferprogramspidofferspost) | **POST** /loyalty/offer/programs/{pid}/offers | Create a reward
[**LoyaltyOfferProgramsPidRewardsAttributePost**](RewardApi.md#loyaltyofferprogramspidrewardsattributepost) | **POST** /loyalty/offer/programs/{pid}/rewards/attribute | Create a voucher
[**LoyaltyOfferProgramsPidRewardsRedeemPost**](RewardApi.md#loyaltyofferprogramspidrewardsredeempost) | **POST** /loyalty/offer/programs/{pid}/rewards/redeem | Create redeem voucher request
[**LoyaltyOfferProgramsPidRewardsRedeemTidCompletePost**](RewardApi.md#loyaltyofferprogramspidrewardsredeemtidcompletepost) | **POST** /loyalty/offer/programs/{pid}/rewards/redeem/{tid}/complete | Complete redeem voucher request
[**LoyaltyOfferProgramsPidRewardsRevokeDelete**](RewardApi.md#loyaltyofferprogramspidrewardsrevokedelete) | **DELETE** /loyalty/offer/programs/{pid}/rewards/revoke | Revoke vouchers
[**LoyaltyOfferProgramsPidRewardsRidGet**](RewardApi.md#loyaltyofferprogramspidrewardsridget) | **GET** /loyalty/offer/programs/{pid}/rewards/{rid} | Get reward information
[**LoyaltyOfferProgramsPidRewardsValidatePost**](RewardApi.md#loyaltyofferprogramspidrewardsvalidatepost) | **POST** /loyalty/offer/programs/{pid}/rewards/validate | Validate a reward
[**LoyaltyOfferProgramsPidVouchersGet**](RewardApi.md#loyaltyofferprogramspidvouchersget) | **GET** /loyalty/offer/programs/{pid}/vouchers | Get voucher for a contact


<a name="getcodecount"></a>
# **GetCodeCount**
> MainCodeCountHttpResponse GetCodeCount (Guid? pid, Guid? cpid)

Get code count

Get code count

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetCodeCountExample
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

            var apiInstance = new RewardApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var cpid = new Guid?(); // Guid? | Code Pool ID

            try
            {
                // Get code count
                MainCodeCountHttpResponse result = apiInstance.GetCodeCount(pid, cpid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardApi.GetCodeCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **cpid** | [**Guid?**](Guid?.md)| Code Pool ID | 

### Return type

[**MainCodeCountHttpResponse**](MainCodeCountHttpResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltyofferprogramspidoffersget"></a>
# **LoyaltyOfferProgramsPidOffersGet**
> MainRewardPage LoyaltyOfferProgramsPidOffersGet (Guid? pid, int? limit = null, int? offset = null, string state = null, string version = null)

Get Reward Page API

Returns a reward page

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyOfferProgramsPidOffersGetExample
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

            var apiInstance = new RewardApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var limit = 56;  // int? | Page size (optional)  (default to 25)
            var offset = 56;  // int? | Pagination offset (optional)  (default to 0)
            var state = state_example;  // string | State of the reward (optional)  (default to all)
            var version = version_example;  // string | Version (optional)  (default to draft)

            try
            {
                // Get Reward Page API
                MainRewardPage result = apiInstance.LoyaltyOfferProgramsPidOffersGet(pid, limit, offset, state, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardApi.LoyaltyOfferProgramsPidOffersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **limit** | **int?**| Page size | [optional] [default to 25]
 **offset** | **int?**| Pagination offset | [optional] [default to 0]
 **state** | **string**| State of the reward | [optional] [default to all]
 **version** | **string**| Version | [optional] [default to draft]

### Return type

[**MainRewardPage**](MainRewardPage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltyofferprogramspidofferspost"></a>
# **LoyaltyOfferProgramsPidOffersPost**
> MainCreateRewardResponse LoyaltyOfferProgramsPidOffersPost (Guid? pid, MainCreateRewardPayload payload)

Create a reward

Creates a new reward in loyalty program.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyOfferProgramsPidOffersPostExample
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

            var apiInstance = new RewardApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var payload = new MainCreateRewardPayload(); // MainCreateRewardPayload | Reward creation payload

            try
            {
                // Create a reward
                MainCreateRewardResponse result = apiInstance.LoyaltyOfferProgramsPidOffersPost(pid, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardApi.LoyaltyOfferProgramsPidOffersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **payload** | [**MainCreateRewardPayload**](MainCreateRewardPayload.md)| Reward creation payload | 

### Return type

[**MainCreateRewardResponse**](MainCreateRewardResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltyofferprogramspidrewardsattributepost"></a>
# **LoyaltyOfferProgramsPidRewardsAttributePost**
> MainRewardAttribution LoyaltyOfferProgramsPidRewardsAttributePost (Guid? pid, MainAttributeRewardPayload payload)

Create a voucher

Create a voucher and attribute it to a specific membership.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyOfferProgramsPidRewardsAttributePostExample
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

            var apiInstance = new RewardApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var payload = new MainAttributeRewardPayload(); // MainAttributeRewardPayload | Voucher creation payload

            try
            {
                // Create a voucher
                MainRewardAttribution result = apiInstance.LoyaltyOfferProgramsPidRewardsAttributePost(pid, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardApi.LoyaltyOfferProgramsPidRewardsAttributePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **payload** | [**MainAttributeRewardPayload**](MainAttributeRewardPayload.md)| Voucher creation payload | 

### Return type

[**MainRewardAttribution**](MainRewardAttribution.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltyofferprogramspidrewardsredeempost"></a>
# **LoyaltyOfferProgramsPidRewardsRedeemPost**
> MainRedeem LoyaltyOfferProgramsPidRewardsRedeemPost (Guid? pid, MainCreateRedeemPayload payload)

Create redeem voucher request

Creates a request to redeem a voucher.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyOfferProgramsPidRewardsRedeemPostExample
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

            var apiInstance = new RewardApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var payload = new MainCreateRedeemPayload(); // MainCreateRedeemPayload | Redeem transaction creation payload

            try
            {
                // Create redeem voucher request
                MainRedeem result = apiInstance.LoyaltyOfferProgramsPidRewardsRedeemPost(pid, payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardApi.LoyaltyOfferProgramsPidRewardsRedeemPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **payload** | [**MainCreateRedeemPayload**](MainCreateRedeemPayload.md)| Redeem transaction creation payload | 

### Return type

[**MainRedeem**](MainRedeem.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltyofferprogramspidrewardsredeemtidcompletepost"></a>
# **LoyaltyOfferProgramsPidRewardsRedeemTidCompletePost**
> MainRedeem LoyaltyOfferProgramsPidRewardsRedeemTidCompletePost (Guid? pid, string tid)

Complete redeem voucher request

Completes voucher redeem request.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyOfferProgramsPidRewardsRedeemTidCompletePostExample
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

            var apiInstance = new RewardApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var tid = tid_example;  // string | Redeem transaction ID

            try
            {
                // Complete redeem voucher request
                MainRedeem result = apiInstance.LoyaltyOfferProgramsPidRewardsRedeemTidCompletePost(pid, tid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardApi.LoyaltyOfferProgramsPidRewardsRedeemTidCompletePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **tid** | **string**| Redeem transaction ID | 

### Return type

[**MainRedeem**](MainRedeem.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltyofferprogramspidrewardsrevokedelete"></a>
# **LoyaltyOfferProgramsPidRewardsRevokeDelete**
> string LoyaltyOfferProgramsPidRewardsRevokeDelete (Guid? pid, string attributedRewardIds = null)

Revoke vouchers

Revoke attributed vouchers.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyOfferProgramsPidRewardsRevokeDeleteExample
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

            var apiInstance = new RewardApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var attributedRewardIds = attributedRewardIds_example;  // string | Reward Attribution IDs (comma seperated) (optional) 

            try
            {
                // Revoke vouchers
                string result = apiInstance.LoyaltyOfferProgramsPidRewardsRevokeDelete(pid, attributedRewardIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardApi.LoyaltyOfferProgramsPidRewardsRevokeDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **attributedRewardIds** | **string**| Reward Attribution IDs (comma seperated) | [optional] 

### Return type

**string**

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltyofferprogramspidrewardsridget"></a>
# **LoyaltyOfferProgramsPidRewardsRidGet**
> MainReward LoyaltyOfferProgramsPidRewardsRidGet (Guid? pid, Guid? rid, string version = null)

Get reward information

Returns reward information.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyOfferProgramsPidRewardsRidGetExample
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

            var apiInstance = new RewardApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var rid = new Guid?(); // Guid? | Reward ID
            var version = version_example;  // string | Version (optional)  (default to draft)

            try
            {
                // Get reward information
                MainReward result = apiInstance.LoyaltyOfferProgramsPidRewardsRidGet(pid, rid, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardApi.LoyaltyOfferProgramsPidRewardsRidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **rid** | [**Guid?**](Guid?.md)| Reward ID | 
 **version** | **string**| Version | [optional] [default to draft]

### Return type

[**MainReward**](MainReward.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltyofferprogramspidrewardsvalidatepost"></a>
# **LoyaltyOfferProgramsPidRewardsValidatePost**
> MainRewardValidate LoyaltyOfferProgramsPidRewardsValidatePost (Guid? pid, MainValidateRewardPayload body)

Validate a reward

Validates a reward.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyOfferProgramsPidRewardsValidatePostExample
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

            var apiInstance = new RewardApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var body = new MainValidateRewardPayload(); // MainValidateRewardPayload | Reward validation payload

            try
            {
                // Validate a reward
                MainRewardValidate result = apiInstance.LoyaltyOfferProgramsPidRewardsValidatePost(pid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardApi.LoyaltyOfferProgramsPidRewardsValidatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **body** | [**MainValidateRewardPayload**](MainValidateRewardPayload.md)| Reward validation payload | 

### Return type

[**MainRewardValidate**](MainRewardValidate.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltyofferprogramspidvouchersget"></a>
# **LoyaltyOfferProgramsPidVouchersGet**
> MainModelContactRewardsResp LoyaltyOfferProgramsPidVouchersGet (Guid? pid, int? contactId, int? limit = null, int? offset = null, string sort = null, string sortField = null, string metadataKeyValue = null, string rewardId = null)

Get voucher for a contact

Get voucher for a contact

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyOfferProgramsPidVouchersGetExample
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

            var apiInstance = new RewardApi();
            var pid = new Guid?(); // Guid? | Loyalty Program ID
            var contactId = 56;  // int? | Contact ID
            var limit = 56;  // int? | Page size (optional)  (default to 25)
            var offset = 56;  // int? | Pagination offset (optional)  (default to 0)
            var sort = sort_example;  // string | Sort order (optional)  (default to desc)
            var sortField = sortField_example;  // string | Sort field (optional)  (default to updatedAt)
            var metadataKeyValue = metadataKeyValue_example;  // string | Metadata value for a Key filter (optional) 
            var rewardId = rewardId_example;  // string | Reward ID (optional) 

            try
            {
                // Get voucher for a contact
                MainModelContactRewardsResp result = apiInstance.LoyaltyOfferProgramsPidVouchersGet(pid, contactId, limit, offset, sort, sortField, metadataKeyValue, rewardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardApi.LoyaltyOfferProgramsPidVouchersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program ID | 
 **contactId** | **int?**| Contact ID | 
 **limit** | **int?**| Page size | [optional] [default to 25]
 **offset** | **int?**| Pagination offset | [optional] [default to 0]
 **sort** | **string**| Sort order | [optional] [default to desc]
 **sortField** | **string**| Sort field | [optional] [default to updatedAt]
 **metadataKeyValue** | **string**| Metadata value for a Key filter | [optional] 
 **rewardId** | **string**| Reward ID | [optional] 

### Return type

[**MainModelContactRewardsResp**](MainModelContactRewardsResp.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

