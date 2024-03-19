# brevo_csharp.Model.CreateWhatsAppTemplate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the template | 
**Language** | **string** | Language of the template. For Example : **en** for English  | 
**Category** | **string** | Category of the template | 
**MediaUrl** | **string** | Absolute url of the media file **(no local file)** for the header. **Use this field in you want to add media in Template header and headerText is empty.** Allowed extensions for media files are: #### jpeg | png | mp4 | pdf  | [optional] 
**BodyText** | **string** | Body of the template. **Maximum allowed characters are 1024** | 
**HeaderText** | **string** | Text content of the header in the template.  **Maximum allowed characters are 45** **Use this field to add text content in template header and if mediaUrl is empty**  | [optional] 
**Source** | **string** | source of the template | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

