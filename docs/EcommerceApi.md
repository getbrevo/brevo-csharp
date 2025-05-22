# brevo_csharp.Api.EcommerceApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBatchOrder**](EcommerceApi.md#createbatchorder) | **POST** /orders/status/batch | Create orders in batch
[**CreateOrder**](EcommerceApi.md#createorder) | **POST** /orders/status | Managing the status of the order
[**CreateUpdateBatchCategory**](EcommerceApi.md#createupdatebatchcategory) | **POST** /categories/batch | Create categories in batch
[**CreateUpdateBatchProducts**](EcommerceApi.md#createupdatebatchproducts) | **POST** /products/batch | Create products in batch
[**CreateUpdateCategory**](EcommerceApi.md#createupdatecategory) | **POST** /categories | Create/Update a category
[**CreateUpdateProduct**](EcommerceApi.md#createupdateproduct) | **POST** /products | Create/Update a product
[**EcommerceActivatePost**](EcommerceApi.md#ecommerceactivatepost) | **POST** /ecommerce/activate | Activate the eCommerce app
[**EcommerceAttributionMetricsConversionSourceConversionSourceIdGet**](EcommerceApi.md#ecommerceattributionmetricsconversionsourceconversionsourceidget) | **GET** /ecommerce/attribution/metrics/{conversionSource}/{conversionSourceId} | Get detailed attribution metrics for a single Brevo campaign or workflow
[**EcommerceAttributionMetricsGet**](EcommerceApi.md#ecommerceattributionmetricsget) | **GET** /ecommerce/attribution/metrics | Get attribution metrics for one or more Brevo campaigns or workflows
[**EcommerceAttributionProductsConversionSourceConversionSourceIdGet**](EcommerceApi.md#ecommerceattributionproductsconversionsourceconversionsourceidget) | **GET** /ecommerce/attribution/products/{conversionSource}/{conversionSourceId} | Get attributed product sales for a single Brevo campaign or workflow
[**EcommerceConfigDisplayCurrencyGet**](EcommerceApi.md#ecommerceconfigdisplaycurrencyget) | **GET** /ecommerce/config/displayCurrency | Get the ISO 4217 compliant display currency code for your Brevo account
[**GetCategories**](EcommerceApi.md#getcategories) | **GET** /categories | Return all your categories
[**GetCategoryInfo**](EcommerceApi.md#getcategoryinfo) | **GET** /categories/{id} | Get a category details
[**GetOrders**](EcommerceApi.md#getorders) | **GET** /orders | Get order details
[**GetProductInfo**](EcommerceApi.md#getproductinfo) | **GET** /products/{id} | Get a product&#39;s details
[**GetProducts**](EcommerceApi.md#getproducts) | **GET** /products | Return all your products
[**SetConfigDisplayCurrency**](EcommerceApi.md#setconfigdisplaycurrency) | **POST** /ecommerce/config/displayCurrency | Set the ISO 4217 compliant display currency code for your Brevo account


<a name="createbatchorder"></a>
# **CreateBatchOrder**
> void CreateBatchOrder (OrderBatch orderBatch)

Create orders in batch

Create multiple orders at one time instead of one order at a time

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateBatchOrderExample
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

            var apiInstance = new EcommerceApi();
            var orderBatch = new OrderBatch(); // OrderBatch | 

            try
            {
                // Create orders in batch
                apiInstance.CreateBatchOrder(orderBatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateBatchOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderBatch** | [**OrderBatch**](OrderBatch.md)|  | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createorder"></a>
# **CreateOrder**
> void CreateOrder (Order order)

Managing the status of the order

Manages the transactional status of the order

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateOrderExample
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

            var apiInstance = new EcommerceApi();
            var order = new Order(); // Order | 

            try
            {
                // Managing the status of the order
                apiInstance.CreateOrder(order);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order** | [**Order**](Order.md)|  | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createupdatebatchcategory"></a>
# **CreateUpdateBatchCategory**
> CreateUpdateBatchCategoryModel CreateUpdateBatchCategory (CreateUpdateBatchCategory createUpdateBatchCategory)

Create categories in batch

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateUpdateBatchCategoryExample
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

            var apiInstance = new EcommerceApi();
            var createUpdateBatchCategory = new CreateUpdateBatchCategory(); // CreateUpdateBatchCategory | Values to create a batch of categories

            try
            {
                // Create categories in batch
                CreateUpdateBatchCategoryModel result = apiInstance.CreateUpdateBatchCategory(createUpdateBatchCategory);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateUpdateBatchCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createUpdateBatchCategory** | [**CreateUpdateBatchCategory**](CreateUpdateBatchCategory.md)| Values to create a batch of categories | 

### Return type

[**CreateUpdateBatchCategoryModel**](CreateUpdateBatchCategoryModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createupdatebatchproducts"></a>
# **CreateUpdateBatchProducts**
> CreateUpdateBatchProductsModel CreateUpdateBatchProducts (CreateUpdateBatchProducts createUpdateBatchProducts)

Create products in batch

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateUpdateBatchProductsExample
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

            var apiInstance = new EcommerceApi();
            var createUpdateBatchProducts = new CreateUpdateBatchProducts(); // CreateUpdateBatchProducts | Values to create a batch of products

            try
            {
                // Create products in batch
                CreateUpdateBatchProductsModel result = apiInstance.CreateUpdateBatchProducts(createUpdateBatchProducts);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateUpdateBatchProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createUpdateBatchProducts** | [**CreateUpdateBatchProducts**](CreateUpdateBatchProducts.md)| Values to create a batch of products | 

### Return type

[**CreateUpdateBatchProductsModel**](CreateUpdateBatchProductsModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createupdatecategory"></a>
# **CreateUpdateCategory**
> CreateCategoryModel CreateUpdateCategory (CreateUpdateCategory createUpdateCategory)

Create/Update a category

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateUpdateCategoryExample
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

            var apiInstance = new EcommerceApi();
            var createUpdateCategory = new CreateUpdateCategory(); // CreateUpdateCategory | Values to create/update a category

            try
            {
                // Create/Update a category
                CreateCategoryModel result = apiInstance.CreateUpdateCategory(createUpdateCategory);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateUpdateCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createUpdateCategory** | [**CreateUpdateCategory**](CreateUpdateCategory.md)| Values to create/update a category | 

### Return type

[**CreateCategoryModel**](CreateCategoryModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createupdateproduct"></a>
# **CreateUpdateProduct**
> CreateProductModel CreateUpdateProduct (CreateUpdateProduct createUpdateProduct)

Create/Update a product

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CreateUpdateProductExample
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

            var apiInstance = new EcommerceApi();
            var createUpdateProduct = new CreateUpdateProduct(); // CreateUpdateProduct | Values to create/update a product

            try
            {
                // Create/Update a product
                CreateProductModel result = apiInstance.CreateUpdateProduct(createUpdateProduct);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.CreateUpdateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createUpdateProduct** | [**CreateUpdateProduct**](CreateUpdateProduct.md)| Values to create/update a product | 

### Return type

[**CreateProductModel**](CreateProductModel.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ecommerceactivatepost"></a>
# **EcommerceActivatePost**
> void EcommerceActivatePost ()

Activate the eCommerce app

Getting access to Brevo eCommerce.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class EcommerceActivatePostExample
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

            var apiInstance = new EcommerceApi();

            try
            {
                // Activate the eCommerce app
                apiInstance.EcommerceActivatePost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.EcommerceActivatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ecommerceattributionmetricsconversionsourceconversionsourceidget"></a>
# **EcommerceAttributionMetricsConversionSourceConversionSourceIdGet**
> InlineResponse2007 EcommerceAttributionMetricsConversionSourceConversionSourceIdGet (string conversionSource, string conversionSourceId)

Get detailed attribution metrics for a single Brevo campaign or workflow

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class EcommerceAttributionMetricsConversionSourceConversionSourceIdGetExample
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

            var apiInstance = new EcommerceApi();
            var conversionSource = conversionSource_example;  // string | The Brevo campaign type or workflow type for which data will be retrieved
            var conversionSourceId = conversionSourceId_example;  // string | The Brevo campaign or automation workflow id for which data will be retrieved

            try
            {
                // Get detailed attribution metrics for a single Brevo campaign or workflow
                InlineResponse2007 result = apiInstance.EcommerceAttributionMetricsConversionSourceConversionSourceIdGet(conversionSource, conversionSourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.EcommerceAttributionMetricsConversionSourceConversionSourceIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversionSource** | **string**| The Brevo campaign type or workflow type for which data will be retrieved | 
 **conversionSourceId** | **string**| The Brevo campaign or automation workflow id for which data will be retrieved | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ecommerceattributionmetricsget"></a>
# **EcommerceAttributionMetricsGet**
> InlineResponse2006 EcommerceAttributionMetricsGet (DateTime? periodFrom = null, DateTime? periodTo = null, List<string> emailCampaignId = null, List<string> smsCampaignId = null, List<string> automationWorkflowEmailId = null, List<string> automationWorkflowSmsId = null)

Get attribution metrics for one or more Brevo campaigns or workflows

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class EcommerceAttributionMetricsGetExample
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

            var apiInstance = new EcommerceApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | When getting metrics for a specific period, define the starting datetime in RFC3339 format (optional) 
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | When getting metrics for a specific period, define the end datetime in RFC3339 format (optional) 
            var emailCampaignId = new List<string>(); // List<string> | The email campaign ID(s) to get metrics for (optional) 
            var smsCampaignId = new List<string>(); // List<string> | The SMS campaign ID(s) to get metrics for (optional) 
            var automationWorkflowEmailId = new List<string>(); // List<string> | The automation workflow ID(s) to get email attribution metrics for (optional) 
            var automationWorkflowSmsId = new List<string>(); // List<string> | The automation workflow ID(s) to get SMS attribution metrics for (optional) 

            try
            {
                // Get attribution metrics for one or more Brevo campaigns or workflows
                InlineResponse2006 result = apiInstance.EcommerceAttributionMetricsGet(periodFrom, periodTo, emailCampaignId, smsCampaignId, automationWorkflowEmailId, automationWorkflowSmsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.EcommerceAttributionMetricsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **periodFrom** | **DateTime?**| When getting metrics for a specific period, define the starting datetime in RFC3339 format | [optional] 
 **periodTo** | **DateTime?**| When getting metrics for a specific period, define the end datetime in RFC3339 format | [optional] 
 **emailCampaignId** | [**List&lt;string&gt;**](string.md)| The email campaign ID(s) to get metrics for | [optional] 
 **smsCampaignId** | [**List&lt;string&gt;**](string.md)| The SMS campaign ID(s) to get metrics for | [optional] 
 **automationWorkflowEmailId** | [**List&lt;string&gt;**](string.md)| The automation workflow ID(s) to get email attribution metrics for | [optional] 
 **automationWorkflowSmsId** | [**List&lt;string&gt;**](string.md)| The automation workflow ID(s) to get SMS attribution metrics for | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ecommerceattributionproductsconversionsourceconversionsourceidget"></a>
# **EcommerceAttributionProductsConversionSourceConversionSourceIdGet**
> InlineResponse2008 EcommerceAttributionProductsConversionSourceConversionSourceIdGet (string conversionSource, string conversionSourceId)

Get attributed product sales for a single Brevo campaign or workflow

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class EcommerceAttributionProductsConversionSourceConversionSourceIdGetExample
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

            var apiInstance = new EcommerceApi();
            var conversionSource = conversionSource_example;  // string | The Brevo campaign or automation workflow type for which data will be retrieved
            var conversionSourceId = conversionSourceId_example;  // string | The Brevo campaign or automation workflow id for which data will be retrieved

            try
            {
                // Get attributed product sales for a single Brevo campaign or workflow
                InlineResponse2008 result = apiInstance.EcommerceAttributionProductsConversionSourceConversionSourceIdGet(conversionSource, conversionSourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.EcommerceAttributionProductsConversionSourceConversionSourceIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversionSource** | **string**| The Brevo campaign or automation workflow type for which data will be retrieved | 
 **conversionSourceId** | **string**| The Brevo campaign or automation workflow id for which data will be retrieved | 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ecommerceconfigdisplaycurrencyget"></a>
# **EcommerceConfigDisplayCurrencyGet**
> InlineResponse2005 EcommerceConfigDisplayCurrencyGet ()

Get the ISO 4217 compliant display currency code for your Brevo account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class EcommerceConfigDisplayCurrencyGetExample
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

            var apiInstance = new EcommerceApi();

            try
            {
                // Get the ISO 4217 compliant display currency code for your Brevo account
                InlineResponse2005 result = apiInstance.EcommerceConfigDisplayCurrencyGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.EcommerceConfigDisplayCurrencyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategories"></a>
# **GetCategories**
> GetCategories GetCategories (long? limit = null, long? offset = null, string sort = null, List<string> ids = null, string name = null, string modifiedSince = null, string createdSince = null)

Return all your categories

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetCategoriesExample
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

            var apiInstance = new EcommerceApi();
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document in the page (optional)  (default to 0)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)
            var ids = new List<string>(); // List<string> | Filter by category ids (optional) 
            var name = name_example;  // string | Filter by category name (optional) 
            var modifiedSince = modifiedSince_example;  // string | Filter (urlencoded) the categories modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  (optional) 
            var createdSince = createdSince_example;  // string | Filter (urlencoded) the categories created after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  (optional) 

            try
            {
                // Return all your categories
                GetCategories result = apiInstance.GetCategories(limit, offset, sort, ids, name, modifiedSince, createdSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document in the page | [optional] [default to 0]
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]
 **ids** | [**List&lt;string&gt;**](string.md)| Filter by category ids | [optional] 
 **name** | **string**| Filter by category name | [optional] 
 **modifiedSince** | **string**| Filter (urlencoded) the categories modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  | [optional] 
 **createdSince** | **string**| Filter (urlencoded) the categories created after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  | [optional] 

### Return type

[**GetCategories**](GetCategories.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcategoryinfo"></a>
# **GetCategoryInfo**
> GetCategoryDetails GetCategoryInfo (string id)

Get a category details

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetCategoryInfoExample
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

            var apiInstance = new EcommerceApi();
            var id = id_example;  // string | Category ID

            try
            {
                // Get a category details
                GetCategoryDetails result = apiInstance.GetCategoryInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetCategoryInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Category ID | 

### Return type

[**GetCategoryDetails**](GetCategoryDetails.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorders"></a>
# **GetOrders**
> GetOrders GetOrders (long? limit = null, long? offset = null, string sort = null, string modifiedSince = null, string createdSince = null)

Get order details

Get all the orders

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetOrdersExample
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

            var apiInstance = new EcommerceApi();
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document in the page (optional)  (default to 0)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)
            var modifiedSince = modifiedSince_example;  // string | Filter (urlencoded) the orders modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  (optional) 
            var createdSince = createdSince_example;  // string | Filter (urlencoded) the orders created after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  (optional) 

            try
            {
                // Get order details
                GetOrders result = apiInstance.GetOrders(limit, offset, sort, modifiedSince, createdSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document in the page | [optional] [default to 0]
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]
 **modifiedSince** | **string**| Filter (urlencoded) the orders modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  | [optional] 
 **createdSince** | **string**| Filter (urlencoded) the orders created after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  | [optional] 

### Return type

[**GetOrders**](GetOrders.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductinfo"></a>
# **GetProductInfo**
> GetProductDetails GetProductInfo (string id)

Get a product's details

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetProductInfoExample
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

            var apiInstance = new EcommerceApi();
            var id = id_example;  // string | Product ID

            try
            {
                // Get a product's details
                GetProductDetails result = apiInstance.GetProductInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetProductInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Product ID | 

### Return type

[**GetProductDetails**](GetProductDetails.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproducts"></a>
# **GetProducts**
> GetProducts GetProducts (long? limit = null, long? offset = null, string sort = null, List<string> ids = null, string name = null, decimal? priceLte = null, decimal? priceGte = null, decimal? priceLt = null, decimal? priceGt = null, decimal? priceEq = null, decimal? priceNe = null, List<string> categories = null, string modifiedSince = null, string createdSince = null)

Return all your products

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetProductsExample
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

            var apiInstance = new EcommerceApi();
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 50)
            var offset = 789;  // long? | Index of the first document in the page (optional)  (default to 0)
            var sort = sort_example;  // string | Sort the results in the ascending/descending order of record creation. Default order is **descending** if `sort` is not passed (optional)  (default to desc)
            var ids = new List<string>(); // List<string> | Filter by product ids (optional) 
            var name = name_example;  // string | Filter by product name, minimum 3 characters should be present for search (optional) 
            var priceLte = 8.14;  // decimal? | Price filter for products less than and equals to particular amount (optional) 
            var priceGte = 8.14;  // decimal? | Price filter for products greater than and equals to particular amount (optional) 
            var priceLt = 8.14;  // decimal? | Price filter for products less than particular amount (optional) 
            var priceGt = 8.14;  // decimal? | Price filter for products greater than particular amount (optional) 
            var priceEq = 8.14;  // decimal? | Price filter for products equals to particular amount (optional) 
            var priceNe = 8.14;  // decimal? | Price filter for products not equals to particular amount (optional) 
            var categories = new List<string>(); // List<string> | Filter by category ids (optional) 
            var modifiedSince = modifiedSince_example;  // string | Filter (urlencoded) the orders modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  (optional) 
            var createdSince = createdSince_example;  // string | Filter (urlencoded) the orders created after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  (optional) 

            try
            {
                // Return all your products
                GetProducts result = apiInstance.GetProducts(limit, offset, sort, ids, name, priceLte, priceGte, priceLt, priceGt, priceEq, priceNe, categories, modifiedSince, createdSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.GetProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **long?**| Number of documents per page | [optional] [default to 50]
 **offset** | **long?**| Index of the first document in the page | [optional] [default to 0]
 **sort** | **string**| Sort the results in the ascending/descending order of record creation. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc]
 **ids** | [**List&lt;string&gt;**](string.md)| Filter by product ids | [optional] 
 **name** | **string**| Filter by product name, minimum 3 characters should be present for search | [optional] 
 **priceLte** | **decimal?**| Price filter for products less than and equals to particular amount | [optional] 
 **priceGte** | **decimal?**| Price filter for products greater than and equals to particular amount | [optional] 
 **priceLt** | **decimal?**| Price filter for products less than particular amount | [optional] 
 **priceGt** | **decimal?**| Price filter for products greater than particular amount | [optional] 
 **priceEq** | **decimal?**| Price filter for products equals to particular amount | [optional] 
 **priceNe** | **decimal?**| Price filter for products not equals to particular amount | [optional] 
 **categories** | [**List&lt;string&gt;**](string.md)| Filter by category ids | [optional] 
 **modifiedSince** | **string**| Filter (urlencoded) the orders modified after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  | [optional] 
 **createdSince** | **string**| Filter (urlencoded) the orders created after a given UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.**  | [optional] 

### Return type

[**GetProducts**](GetProducts.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setconfigdisplaycurrency"></a>
# **SetConfigDisplayCurrency**
> SetConfigDisplayCurrency SetConfigDisplayCurrency (SetConfigDisplayCurrency setConfigDisplayCurrency)

Set the ISO 4217 compliant display currency code for your Brevo account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class SetConfigDisplayCurrencyExample
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

            var apiInstance = new EcommerceApi();
            var setConfigDisplayCurrency = new SetConfigDisplayCurrency(); // SetConfigDisplayCurrency | set ISO 4217 compliant display currency code payload

            try
            {
                // Set the ISO 4217 compliant display currency code for your Brevo account
                SetConfigDisplayCurrency result = apiInstance.SetConfigDisplayCurrency(setConfigDisplayCurrency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EcommerceApi.SetConfigDisplayCurrency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **setConfigDisplayCurrency** | [**SetConfigDisplayCurrency**](SetConfigDisplayCurrency.md)| set ISO 4217 compliant display currency code payload | 

### Return type

[**SetConfigDisplayCurrency**](SetConfigDisplayCurrency.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

