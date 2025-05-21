# brevo_csharp.Model.CreateUpdateCategory
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique Category ID as saved in the shop  | 
**Name** | **string** | **Mandatory in case of creation**. Name of the Category, as displayed in the shop  | [optional] 
**Url** | **string** | URL to the category | [optional] 
**UpdateEnabled** | **bool?** | Facilitate to update the existing category in the same request (updateEnabled &#x3D; true) | [optional] [default to false]
**DeletedAt** | **string** | UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) of the category deleted from the shop&#39;s database | [optional] 
**IsDeleted** | **bool?** | category deleted from the shop&#39;s database | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

