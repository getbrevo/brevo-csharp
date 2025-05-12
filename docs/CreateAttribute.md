# brevo_csharp.Model.CreateAttribute
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | Value of the attribute. Use only if the attribute&#39;s category is &#39;calculated&#39; or &#39;global&#39; | [optional] 
**IsRecurring** | **bool?** | Type of the attribute. Use only if the attribute&#39;s category is &#39;calculated&#39; or &#39;global&#39; | [optional] 
**Enumeration** | [**List&lt;CreateAttributeEnumeration&gt;**](CreateAttributeEnumeration.md) | List of values and labels that the attribute can take. Use only if the attribute&#39;s category is &quot;category&quot;. For example, [{&quot;value&quot;:1, &quot;label&quot;:&quot;male&quot;}, {&quot;value&quot;:2, &quot;label&quot;:&quot;female&quot;}] | [optional] 
**MultiCategoryOptions** | **List&lt;string&gt;** | List of options you want to add for multiple-choice attribute. **Use only if the attribute&#39;s category is &quot;normal&quot; and attribute&#39;s type is &quot;multiple-choice&quot;.** For example: **[&quot;USA&quot;,&quot;INDIA&quot;]**  | [optional] 
**Type** | **string** | Type of the attribute. Use only if the attribute&#39;s category is &#39;normal&#39;, &#39;category&#39; or &#39;transactional&#39; ( type &#39;user&#39; and &#39;multiple-choice&#39; is only available if the category is &#39;normal&#39; attribute, type &#39;id&#39; is only available if the category is &#39;transactional&#39; attribute &amp; type &#39;category&#39; is only available if the category is &#39;category&#39; attribute ) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

