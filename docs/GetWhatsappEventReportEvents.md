# brevo_csharp.Model.GetWhatsappEventReportEvents
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContactNumber** | **string** | WhatsApp Number with country code. Example, 85264318721 | 
**Date** | **string** | UTC date-time on which the event has been generated | 
**MessageId** | **string** | Message ID which generated the event | 
**Event** | **string** | Event which occurred | 
**Reason** | **string** | Reason for the event (will be there in case of &#x60;error&#x60; and &#x60;soft-bounce&#x60; events) | [optional] 
**Body** | **string** | Text of the reply (will be there only in case of &#x60;reply&#x60; event with text) | [optional] 
**MediaUrl** | **string** | Url of the media reply (will be there only in case of &#x60;reply&#x60; event with media) | [optional] 
**SenderNumber** | **string** | WhatsApp Number with country code. Example, 85264318721 | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

