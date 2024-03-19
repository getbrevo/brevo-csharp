# brevo_csharp.Model.GetWebhook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | URL of the webhook | 
**Id** | **long?** | ID of the webhook | 
**Description** | **string** | Description of the webhook | 
**Events** | **List&lt;string&gt;** |  | 
**Type** | **string** | Type of webhook (marketing or transactional) | 
**CreatedAt** | **string** | Creation UTC date-time of the webhook (YYYY-MM-DDTHH:mm:ss.SSSZ) | 
**ModifiedAt** | **string** | Last modification UTC date-time of the webhook (YYYY-MM-DDTHH:mm:ss.SSSZ) | 
**Batched** | **bool?** | To send batched webhooks | [optional] 
**Auth** | [**GetWebhookAuth**](GetWebhookAuth.md) |  | [optional] 
**Headers** | [**List&lt;GetWebhookHeaders&gt;**](GetWebhookHeaders.md) | Custom headers to be send with webhooks | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

