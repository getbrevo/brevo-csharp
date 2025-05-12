# brevo_csharp.Model.CreateUpdateProduct
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Product ID for which you requested the details | 
**Name** | **string** | Mandatory in case of creation**. Name of the product for which you requested the details | 
**Url** | **string** | URL to the product | [optional] 
**ImageUrl** | **string** | Absolute URL to the cover image of the product | [optional] 
**Sku** | **string** | Product identifier from the shop | [optional] 
**Price** | **float?** | Price of the product | [optional] 
**Categories** | **List&lt;string&gt;** | Category ID-s of the product | [optional] 
**ParentId** | **string** | Parent product id of the product | [optional] 
**MetaInfo** | **Dictionary&lt;string, string&gt;** | Meta data of product such as description, vendor, producer, stock level. The size of cumulative metaInfo shall not exceed **1000 KB**. Maximum length of metaInfo object can be 20. | [optional] 
**UpdateEnabled** | **bool?** | Facilitate to update the existing category in the same request (updateEnabled &#x3D; true) | [optional] [default to false]
**DeletedAt** | **string** | UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) of the product deleted from the shop&#39;s database | [optional] 
**IsDeleted** | **bool?** | product deleted from the shop&#39;s database | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

