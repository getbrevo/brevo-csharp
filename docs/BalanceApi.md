# brevo_csharp.Api.BalanceApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BeginTransaction**](BalanceApi.md#begintransaction) | **POST** /loyalty/balance/programs/{pid}/transactions | Create new transaction
[**CancelTransaction**](BalanceApi.md#canceltransaction) | **POST** /loyalty/balance/programs/{pid}/transactions/{tid}/cancel | Cancel transaction
[**CompleteTransaction**](BalanceApi.md#completetransaction) | **POST** /loyalty/balance/programs/{pid}/transactions/{tid}/complete | Complete transaction
[**CreateBalanceLimit**](BalanceApi.md#createbalancelimit) | **POST** /loyalty/balance/programs/{pid}/balance-definitions/{bdid}/limits | Create balance limits
[**CreateBalanceOrder**](BalanceApi.md#createbalanceorder) | **POST** /loyalty/balance/programs/{pid}/create-order | Create balance order
[**DeleteBalanceDefinition**](BalanceApi.md#deletebalancedefinition) | **DELETE** /loyalty/balance/programs/{pid}/balance-definitions/{bdid} | Delete balance definition
[**DeleteBalanceLimit**](BalanceApi.md#deletebalancelimit) | **DELETE** /loyalty/balance/programs/{pid}/balance-definitions/{bdid}/limits/{blid} | Delete balance limit
[**GetBalanceDefinition**](BalanceApi.md#getbalancedefinition) | **GET** /loyalty/balance/programs/{pid}/balance-definitions/{bdid} | Get balance definition
[**GetBalanceDefinitionList**](BalanceApi.md#getbalancedefinitionlist) | **GET** /loyalty/balance/programs/{pid}/balance-definitions | Get balance definition list
[**GetBalanceLimit**](BalanceApi.md#getbalancelimit) | **GET** /loyalty/balance/programs/{pid}/balance-definitions/{bdid}/limits/{blid} | Get balance limits
[**GetContactBalances**](BalanceApi.md#getcontactbalances) | **GET** /loyalty/balance/programs/{pid}/contact-balances | Get balance list
[**GetSubscriptionBalances**](BalanceApi.md#getsubscriptionbalances) | **GET** /loyalty/balance/programs/{pid}/subscriptions/{cid}/balances | Get subscription balances
[**LoyaltyBalanceProgramsPidActiveBalanceGet**](BalanceApi.md#loyaltybalanceprogramspidactivebalanceget) | **GET** /loyalty/balance/programs/{pid}/active-balance | Get Active Balances API
[**LoyaltyBalanceProgramsPidBalanceDefinitionsPost**](BalanceApi.md#loyaltybalanceprogramspidbalancedefinitionspost) | **POST** /loyalty/balance/programs/{pid}/balance-definitions | Create balance definition
[**LoyaltyBalanceProgramsPidSubscriptionsCidBalancesPost**](BalanceApi.md#loyaltybalanceprogramspidsubscriptionscidbalancespost) | **POST** /loyalty/balance/programs/{pid}/subscriptions/{cid}/balances | Create subscription balances
[**LoyaltyBalanceProgramsPidTransactionHistoryGet**](BalanceApi.md#loyaltybalanceprogramspidtransactionhistoryget) | **GET** /loyalty/balance/programs/{pid}/transaction-history | Get Transaction History API
[**UpdateBalanceDefinition**](BalanceApi.md#updatebalancedefinition) | **PUT** /loyalty/balance/programs/{pid}/balance-definitions/{bdid} | Update balance definition
[**UpdateBalanceLimit**](BalanceApi.md#updatebalancelimit) | **PUT** /loyalty/balance/programs/{pid}/balance-definitions/{bdid}/limits/{blid} | Updates balance limit


<a name="begintransaction"></a>
# **BeginTransaction**
> Transaction BeginTransaction (Guid? pid, CreateTransactionPayload body)

Create new transaction

Creates new transaction and returns information

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class BeginTransactionExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var body = new CreateTransactionPayload(); // CreateTransactionPayload | Transaction Payload

            try
            {
                // Create new transaction
                Transaction result = apiInstance.BeginTransaction(pid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.BeginTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **body** | [**CreateTransactionPayload**](CreateTransactionPayload.md)| Transaction Payload | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceltransaction"></a>
# **CancelTransaction**
> Transaction CancelTransaction (Guid? pid, Guid? tid)

Cancel transaction

Cancels transaction

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CancelTransactionExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var tid = new Guid?(); // Guid? | Transaction Id

            try
            {
                // Cancel transaction
                Transaction result = apiInstance.CancelTransaction(pid, tid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.CancelTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **tid** | [**Guid?**](Guid?.md)| Transaction Id | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="completetransaction"></a>
# **CompleteTransaction**
> Transaction CompleteTransaction (Guid? pid, Guid? tid)

Complete transaction

Completes transaction

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CompleteTransactionExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var tid = new Guid?(); // Guid? | Transaction Id

            try
            {
                // Complete transaction
                Transaction result = apiInstance.CompleteTransaction(pid, tid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.CompleteTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **tid** | [**Guid?**](Guid?.md)| Transaction Id | 

### Return type

[**Transaction**](Transaction.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbalancelimit"></a>
# **CreateBalanceLimit**
> BalanceLimit CreateBalanceLimit (Guid? pid, Guid? bdid, CreateBalanceLimitPayload body)

Create balance limits

Creates balance limit and sends the created UUID along with the data

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateBalanceLimitExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var bdid = new Guid?(); // Guid? | Balance Definition Id
            var body = new CreateBalanceLimitPayload(); // CreateBalanceLimitPayload | Balance Definition Payload

            try
            {
                // Create balance limits
                BalanceLimit result = apiInstance.CreateBalanceLimit(pid, bdid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.CreateBalanceLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **bdid** | [**Guid?**](Guid?.md)| Balance Definition Id | 
 **body** | [**CreateBalanceLimitPayload**](CreateBalanceLimitPayload.md)| Balance Definition Payload | 

### Return type

[**BalanceLimit**](BalanceLimit.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbalanceorder"></a>
# **CreateBalanceOrder**
> BalanceOrder CreateBalanceOrder (Guid? pid, CreateOrderPayload body)

Create balance order

Returns created order

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateBalanceOrderExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var body = new CreateOrderPayload(); // CreateOrderPayload | Order Payload

            try
            {
                // Create balance order
                BalanceOrder result = apiInstance.CreateBalanceOrder(pid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.CreateBalanceOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **body** | [**CreateOrderPayload**](CreateOrderPayload.md)| Order Payload | 

### Return type

[**BalanceOrder**](BalanceOrder.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebalancedefinition"></a>
# **DeleteBalanceDefinition**
> void DeleteBalanceDefinition (Guid? pid, Guid? bdid)

Delete balance definition

Delete Balance definition

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteBalanceDefinitionExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var bdid = new Guid?(); // Guid? | Balance Definition Id

            try
            {
                // Delete balance definition
                apiInstance.DeleteBalanceDefinition(pid, bdid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.DeleteBalanceDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **bdid** | [**Guid?**](Guid?.md)| Balance Definition Id | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebalancelimit"></a>
# **DeleteBalanceLimit**
> void DeleteBalanceLimit (Guid? pid, Guid? bdid, Guid? blid)

Delete balance limit

Delete balance limit

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class DeleteBalanceLimitExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var bdid = new Guid?(); // Guid? | Balance Definition Id
            var blid = new Guid?(); // Guid? | Balance Limit Id

            try
            {
                // Delete balance limit
                apiInstance.DeleteBalanceLimit(pid, bdid, blid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.DeleteBalanceLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **bdid** | [**Guid?**](Guid?.md)| Balance Definition Id | 
 **blid** | [**Guid?**](Guid?.md)| Balance Limit Id | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbalancedefinition"></a>
# **GetBalanceDefinition**
> BalanceDefinition GetBalanceDefinition (Guid? pid, Guid? bdid, string version = null)

Get balance definition

Returns balance definition

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetBalanceDefinitionExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var bdid = new Guid?(); // Guid? | Balance Definition Id
            var version = version_example;  // string | Version (optional)  (default to draft)

            try
            {
                // Get balance definition
                BalanceDefinition result = apiInstance.GetBalanceDefinition(pid, bdid, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.GetBalanceDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **bdid** | [**Guid?**](Guid?.md)| Balance Definition Id | 
 **version** | **string**| Version | [optional] [default to draft]

### Return type

[**BalanceDefinition**](BalanceDefinition.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbalancedefinitionlist"></a>
# **GetBalanceDefinitionList**
> BalanceDefinitionPage GetBalanceDefinitionList (Guid? pid, int? limit = null, int? offset = null, string sortField = null, string sort = null, string version = null)

Get balance definition list

Returns balance definition page

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetBalanceDefinitionListExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var limit = 56;  // int? | Limit the number of records returned (optional)  (default to 200)
            var offset = 56;  // int? | Offset to paginate records (optional)  (default to 0)
            var sortField = sortField_example;  // string | Field to sort by (optional)  (default to updated_at)
            var sort = sort_example;  // string | Sort direction (optional)  (default to desc)
            var version = version_example;  // string | Version (optional)  (default to draft)

            try
            {
                // Get balance definition list
                BalanceDefinitionPage result = apiInstance.GetBalanceDefinitionList(pid, limit, offset, sortField, sort, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.GetBalanceDefinitionList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **limit** | **int?**| Limit the number of records returned | [optional] [default to 200]
 **offset** | **int?**| Offset to paginate records | [optional] [default to 0]
 **sortField** | **string**| Field to sort by | [optional] [default to updated_at]
 **sort** | **string**| Sort direction | [optional] [default to desc]
 **version** | **string**| Version | [optional] [default to draft]

### Return type

[**BalanceDefinitionPage**](BalanceDefinitionPage.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbalancelimit"></a>
# **GetBalanceLimit**
> BalanceLimit GetBalanceLimit (Guid? pid, Guid? bdid, Guid? blid, string version = null)

Get balance limits

Fetches balance limits and send the created UUID along with the data

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetBalanceLimitExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var bdid = new Guid?(); // Guid? | Balance Definition Id
            var blid = new Guid?(); // Guid? | Balance Limit Id
            var version = version_example;  // string | Version (optional)  (default to draft)

            try
            {
                // Get balance limits
                BalanceLimit result = apiInstance.GetBalanceLimit(pid, bdid, blid, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.GetBalanceLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **bdid** | [**Guid?**](Guid?.md)| Balance Definition Id | 
 **blid** | [**Guid?**](Guid?.md)| Balance Limit Id | 
 **version** | **string**| Version | [optional] [default to draft]

### Return type

[**BalanceLimit**](BalanceLimit.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontactbalances"></a>
# **GetContactBalances**
> ContactBalancesResp GetContactBalances (Guid? pid)

Get balance list

Returns balance list

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetContactBalancesExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id

            try
            {
                // Get balance list
                ContactBalancesResp result = apiInstance.GetContactBalances(pid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.GetContactBalances: " + e.Message );
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

[**ContactBalancesResp**](ContactBalancesResp.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptionbalances"></a>
# **GetSubscriptionBalances**
> ModelSubscriptionBalanceResp GetSubscriptionBalances (string cid, Guid? pid)

Get subscription balances

Returns subscription balances

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetSubscriptionBalancesExample
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

            var apiInstance = new BalanceApi();
            var cid = cid_example;  // string | Contact Id
            var pid = new Guid?(); // Guid? | Loyalty Program Id

            try
            {
                // Get subscription balances
                ModelSubscriptionBalanceResp result = apiInstance.GetSubscriptionBalances(cid, pid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.GetSubscriptionBalances: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cid** | **string**| Contact Id | 
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 

### Return type

[**ModelSubscriptionBalanceResp**](ModelSubscriptionBalanceResp.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltybalanceprogramspidactivebalanceget"></a>
# **LoyaltyBalanceProgramsPidActiveBalanceGet**
> BalanceLimit LoyaltyBalanceProgramsPidActiveBalanceGet (Guid? pid, int? contactId, Guid? balanceDefinitionId, int? limit = null, int? offset = null, string sortField = null, string sort = null)

Get Active Balances API

Returns Active Balances

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyBalanceProgramsPidActiveBalanceGetExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var contactId = 56;  // int? | Contact ID
            var balanceDefinitionId = new Guid?(); // Guid? | Balance Definition ID
            var limit = 56;  // int? | Limit (optional) 
            var offset = 56;  // int? | Offset (optional) 
            var sortField = sortField_example;  // string | Sort Field (optional) 
            var sort = sort_example;  // string | Sort Order (optional) 

            try
            {
                // Get Active Balances API
                BalanceLimit result = apiInstance.LoyaltyBalanceProgramsPidActiveBalanceGet(pid, contactId, balanceDefinitionId, limit, offset, sortField, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.LoyaltyBalanceProgramsPidActiveBalanceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **contactId** | **int?**| Contact ID | 
 **balanceDefinitionId** | [**Guid?**](Guid?.md)| Balance Definition ID | 
 **limit** | **int?**| Limit | [optional] 
 **offset** | **int?**| Offset | [optional] 
 **sortField** | **string**| Sort Field | [optional] 
 **sort** | **string**| Sort Order | [optional] 

### Return type

[**BalanceLimit**](BalanceLimit.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltybalanceprogramspidbalancedefinitionspost"></a>
# **LoyaltyBalanceProgramsPidBalanceDefinitionsPost**
> BalanceDefinition LoyaltyBalanceProgramsPidBalanceDefinitionsPost (Guid? pid, CreateBalanceDefinitionPayload body)

Create balance definition

Creates balance definition and returns information

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyBalanceProgramsPidBalanceDefinitionsPostExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var body = new CreateBalanceDefinitionPayload(); // CreateBalanceDefinitionPayload | Create Balance Definition Payload

            try
            {
                // Create balance definition
                BalanceDefinition result = apiInstance.LoyaltyBalanceProgramsPidBalanceDefinitionsPost(pid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.LoyaltyBalanceProgramsPidBalanceDefinitionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **body** | [**CreateBalanceDefinitionPayload**](CreateBalanceDefinitionPayload.md)| Create Balance Definition Payload | 

### Return type

[**BalanceDefinition**](BalanceDefinition.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltybalanceprogramspidsubscriptionscidbalancespost"></a>
# **LoyaltyBalanceProgramsPidSubscriptionsCidBalancesPost**
> Balance LoyaltyBalanceProgramsPidSubscriptionsCidBalancesPost (Guid? pid, string cid, CreateBalancePayload body)

Create subscription balances

Creates a balance for a contact

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyBalanceProgramsPidSubscriptionsCidBalancesPostExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var cid = cid_example;  // string | Contact Id
            var body = new CreateBalancePayload(); // CreateBalancePayload | Create Balnce Payload

            try
            {
                // Create subscription balances
                Balance result = apiInstance.LoyaltyBalanceProgramsPidSubscriptionsCidBalancesPost(pid, cid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.LoyaltyBalanceProgramsPidSubscriptionsCidBalancesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **cid** | **string**| Contact Id | 
 **body** | [**CreateBalancePayload**](CreateBalancePayload.md)| Create Balnce Payload | 

### Return type

[**Balance**](Balance.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loyaltybalanceprogramspidtransactionhistoryget"></a>
# **LoyaltyBalanceProgramsPidTransactionHistoryGet**
> TransactionHistoryResp LoyaltyBalanceProgramsPidTransactionHistoryGet (Guid? pid, int? contactId, Guid? balanceDefinitionId, int? limit = null, int? offset = null, string sortField = null, string sort = null, List<string> filters = null)

Get Transaction History API

Returns transaction history

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class LoyaltyBalanceProgramsPidTransactionHistoryGetExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var contactId = 56;  // int? | Contact ID (default to 0)
            var balanceDefinitionId = new Guid?(); // Guid? | Balance Definition ID
            var limit = 56;  // int? | Limit the number of records returned (optional)  (default to 20)
            var offset = 56;  // int? | Skip a number of records (optional)  (default to 0)
            var sortField = sortField_example;  // string | Field to sort by (optional)  (default to created_at)
            var sort = sort_example;  // string | Sort order, either asc or desc (optional)  (default to desc)
            var filters = new List<string>(); // List<string> | Filters to apply (optional) 

            try
            {
                // Get Transaction History API
                TransactionHistoryResp result = apiInstance.LoyaltyBalanceProgramsPidTransactionHistoryGet(pid, contactId, balanceDefinitionId, limit, offset, sortField, sort, filters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.LoyaltyBalanceProgramsPidTransactionHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **contactId** | **int?**| Contact ID | [default to 0]
 **balanceDefinitionId** | [**Guid?**](Guid?.md)| Balance Definition ID | 
 **limit** | **int?**| Limit the number of records returned | [optional] [default to 20]
 **offset** | **int?**| Skip a number of records | [optional] [default to 0]
 **sortField** | **string**| Field to sort by | [optional] [default to created_at]
 **sort** | **string**| Sort order, either asc or desc | [optional] [default to desc]
 **filters** | [**List&lt;string&gt;**](string.md)| Filters to apply | [optional] 

### Return type

[**TransactionHistoryResp**](TransactionHistoryResp.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebalancedefinition"></a>
# **UpdateBalanceDefinition**
> BalanceDefinition UpdateBalanceDefinition (Guid? pid, Guid? bdid, UpdateBalanceDefinitionPayload body)

Update balance definition

Updates Balance definition

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateBalanceDefinitionExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var bdid = new Guid?(); // Guid? | Balance Definition Id
            var body = new UpdateBalanceDefinitionPayload(); // UpdateBalanceDefinitionPayload | Update Balance Definition Payload

            try
            {
                // Update balance definition
                BalanceDefinition result = apiInstance.UpdateBalanceDefinition(pid, bdid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.UpdateBalanceDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **bdid** | [**Guid?**](Guid?.md)| Balance Definition Id | 
 **body** | [**UpdateBalanceDefinitionPayload**](UpdateBalanceDefinitionPayload.md)| Update Balance Definition Payload | 

### Return type

[**BalanceDefinition**](BalanceDefinition.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebalancelimit"></a>
# **UpdateBalanceLimit**
> BalanceLimit UpdateBalanceLimit (Guid? pid, Guid? bdid, Guid? blid, UpdateBalanceLimitPayload body)

Updates balance limit

Updates balance limit

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class UpdateBalanceLimitExample
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

            var apiInstance = new BalanceApi();
            var pid = new Guid?(); // Guid? | Loyalty Program Id
            var bdid = new Guid?(); // Guid? | Balance Definition Id
            var blid = new Guid?(); // Guid? | Balance Limit Id
            var body = new UpdateBalanceLimitPayload(); // UpdateBalanceLimitPayload | Balance Limits Payload

            try
            {
                // Updates balance limit
                BalanceLimit result = apiInstance.UpdateBalanceLimit(pid, bdid, blid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BalanceApi.UpdateBalanceLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pid** | [**Guid?**](Guid?.md)| Loyalty Program Id | 
 **bdid** | [**Guid?**](Guid?.md)| Balance Definition Id | 
 **blid** | [**Guid?**](Guid?.md)| Balance Limit Id | 
 **body** | [**UpdateBalanceLimitPayload**](UpdateBalanceLimitPayload.md)| Balance Limits Payload | 

### Return type

[**BalanceLimit**](BalanceLimit.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

