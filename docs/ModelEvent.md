# brevo_csharp.Model.ModelEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventName** | **string** | The name of the event that occurred. This is how you will find your event in Brevo. Limited to 255 characters, alphanumerical characters and - _ only. | 
**EventDate** | **string** | Timestamp of when the event occurred (e.g. &quot;2024-01-24T17:39:57+01:00&quot;). If no value is passed, the timestamp of the event creation is used. | [optional] 
**Identifiers** | [**EventIdentifiers**](EventIdentifiers.md) |  | 
**ContactProperties** | **Object** | Properties defining the state of the contact associated to this event. Useful to update contact attributes defined in your contacts database while passing the event. For example: **&quot;FIRSTNAME&quot;: &quot;Jane&quot; , &quot;AGE&quot;: 37** | [optional] 
**EventProperties** | **Object** | Properties of the event. Top level properties and nested properties can be used to better segment contacts and personalise workflow conditions. The following field type are supported: string, number, boolean (true/false), date (Timestamp e.g. &quot;2024-01-24T17:39:57+01:00&quot;). Keys are limited to 255 characters, alphanumerical characters and - _ only. Size is limited to 50Kb. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

