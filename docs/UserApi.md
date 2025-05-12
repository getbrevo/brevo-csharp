# brevo_csharp.Api.UserApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditUserPermission**](UserApi.md#edituserpermission) | **POST** /organization/user/update/permissions | Update permission for a user
[**GetInvitedUsersList**](UserApi.md#getinviteduserslist) | **GET** /organization/invited/users | Get the list of all your users
[**GetUserPermission**](UserApi.md#getuserpermission) | **GET** /organization/user/{email}/permissions | Check user permission
[**Inviteuser**](UserApi.md#inviteuser) | **POST** /organization/user/invitation/send | Send invitation to user
[**PutRevokeUserPermission**](UserApi.md#putrevokeuserpermission) | **PUT** /organization/user/invitation/revoke/{email} | Revoke user permission
[**Putresendcancelinvitation**](UserApi.md#putresendcancelinvitation) | **PUT** /organization/user/invitation/{action}/{email} | Resend / Cancel invitation


<a name="edituserpermission"></a>
# **EditUserPermission**
> Inviteuser EditUserPermission (Inviteuser updatePermissions)

Update permission for a user

`Feature` - A Feature represents a specific functionality like Email campaign, Deals, Calls, Automations, etc. on Brevo. While inviting a user, determine which feature you want to manage access to. You must specify the feature accurately to avoid errors.  `Permission` - A Permission defines the level of access or control a user has over a specific feature. While inviting user, decide on the permission level required for the selected feature. Make sure the chosen permission is related to the selected feature.  Features and their respective permissions are as below:  - `email_campaigns`:   - \"create_edit_delete\"   - \"send_schedule_suspend\" - `sms_campaigns`:   - \"create_edit_delete\"   - \"send_schedule_suspend\" - `contacts`:   - \"view\"   - \"create_edit_delete\"   - \"import\"   - \"export\"   - \"list_and_attributes\"   - \"forms\" - `templates`:   - \"create_edit_delete\"   - \"activate_deactivate\" - `workflows`:   - \"create_edit_delete\"   - \"activate_deactivate_pause\"   - \"settings\" - `facebook_ads`:   - \"create_edit_delete\"   - \"schedule_pause\" - `landing_pages`:   - \"all\" - `transactional_emails`:   - \"settings\"   - \"logs\" - `smtp_api`:   - \"smtp\"   - \"api_keys\"   - \"authorized_ips\" - `user_management`:   - \"all\" - `sales_platform`:   - \"create_edit_deals\"   - \"delete_deals\"   - \"manage_others_deals_tasks\"   - \"reports\"   - \"settings\" - `phone`:   - \"all\" - `conversations`:   - \"access\"   - \"assign\"   - \"configure\" - `senders_domains_dedicated_ips`:   - \"senders_management\"   - \"domains_management\"   - \"dedicated_ips_management\" - `push_notifications`:   - \"view\"   - \"create_edit_delete\"   - \"send\"   - \"settings\" - `companies`:   - \"manage_owned_companies\"   - \"manage_other_companies\"   - \"settings\"  **Note**: - The privileges array remains the same as in the send invitation; the user simply needs to provide the permissions that need to be updated. - The availability of feature and its permission depends on your current plan. Please select the features and permissions accordingly. 

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class EditUserPermissionExample
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

            var apiInstance = new UserApi();
            var updatePermissions = new Inviteuser(); // Inviteuser | Values to update permissions for an invited user

            try
            {
                // Update permission for a user
                Inviteuser result = apiInstance.EditUserPermission(updatePermissions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.EditUserPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updatePermissions** | [**Inviteuser**](Inviteuser.md)| Values to update permissions for an invited user | 

### Return type

[**Inviteuser**](Inviteuser.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinviteduserslist"></a>
# **GetInvitedUsersList**
> GetInvitedUsersList GetInvitedUsersList ()

Get the list of all your users

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetInvitedUsersListExample
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

            var apiInstance = new UserApi();

            try
            {
                // Get the list of all your users
                GetInvitedUsersList result = apiInstance.GetInvitedUsersList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetInvitedUsersList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetInvitedUsersList**](GetInvitedUsersList.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserpermission"></a>
# **GetUserPermission**
> GetUserPermission GetUserPermission (string email)

Check user permission

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetUserPermissionExample
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

            var apiInstance = new UserApi();
            var email = email_example;  // string | Email of the invited user.

            try
            {
                // Check user permission
                GetUserPermission result = apiInstance.GetUserPermission(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email of the invited user. | 

### Return type

[**GetUserPermission**](GetUserPermission.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteuser"></a>
# **Inviteuser**
> Inviteuser Inviteuser (Inviteuser sendInvitation)

Send invitation to user

`Feature` - A Feature represents a specific functionality like Email campaign, Deals, Calls, Automations, etc. on Brevo. While inviting a user, determine which feature you want to manage access to. You must specify the feature accurately to avoid errors.  `Permission` - A Permission defines the level of access or control a user has over a specific feature. While inviting user, decide on the permission level required for the selected feature. Make sure the chosen permission is related to the selected feature.  Features and their respective permissions are as below:  - `email_campaigns`:   - \"create_edit_delete\"   - \"send_schedule_suspend\" - `sms_campaigns`:   - \"create_edit_delete\"   - \"send_schedule_suspend\" - `contacts`:   - \"view\"   - \"create_edit_delete\"   - \"import\"   - \"export\"   - \"list_and_attributes\"   - \"forms\" - `templates`:   - \"create_edit_delete\"   - \"activate_deactivate\" - `workflows`:   - \"create_edit_delete\"   - \"activate_deactivate_pause\"   - \"settings\" - `facebook_ads`:   - \"create_edit_delete\"   - \"schedule_pause\" - `landing_pages`:   - \"all\" - `transactional_emails`:   - \"settings\"   - \"logs\" - `smtp_api`:   - \"smtp\"   - \"api_keys\"   - \"authorized_ips\" - `user_management`:   - \"all\" - `sales_platform`:   - \"create_edit_deals\"   - \"delete_deals\"   - \"manage_others_deals_tasks\"   - \"reports\"   - \"settings\" - `phone`:   - \"all\" - `conversations`:   - \"access\"   - \"assign\"   - \"configure\" - `senders_domains_dedicated_ips`:   - \"senders_management\"   - \"domains_management\"   - \"dedicated_ips_management\" - `push_notifications`:   - \"view\"   - \"create_edit_delete\"   - \"send\"   - \"settings\" - `companies`:   - \"manage_owned_companies\"   - \"manage_other_companies\"   - \"settings\"  **Note**: - If `all_features_access: false` then only privileges are required otherwise if `true` then it's assumed that all permissions will be there for the invited user. - The availability of feature and its permission depends on your current plan. Please select the features and permissions accordingly. 

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class InviteuserExample
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

            var apiInstance = new UserApi();
            var sendInvitation = new Inviteuser(); // Inviteuser | Values to create an invitation

            try
            {
                // Send invitation to user
                Inviteuser result = apiInstance.Inviteuser(sendInvitation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.Inviteuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sendInvitation** | [**Inviteuser**](Inviteuser.md)| Values to create an invitation | 

### Return type

[**Inviteuser**](Inviteuser.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putrevokeuserpermission"></a>
# **PutRevokeUserPermission**
> PutRevokeUserPermission PutRevokeUserPermission (string email)

Revoke user permission

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class PutRevokeUserPermissionExample
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

            var apiInstance = new UserApi();
            var email = email_example;  // string | Email of the invited user.

            try
            {
                // Revoke user permission
                PutRevokeUserPermission result = apiInstance.PutRevokeUserPermission(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.PutRevokeUserPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email of the invited user. | 

### Return type

[**PutRevokeUserPermission**](PutRevokeUserPermission.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putresendcancelinvitation"></a>
# **Putresendcancelinvitation**
> Putresendcancelinvitation Putresendcancelinvitation (string action, string email)

Resend / Cancel invitation

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class PutresendcancelinvitationExample
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

            var apiInstance = new UserApi();
            var action = action_example;  // string | action
            var email = email_example;  // string | Email of the invited user.

            try
            {
                // Resend / Cancel invitation
                Putresendcancelinvitation result = apiInstance.Putresendcancelinvitation(action, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.Putresendcancelinvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**| action | 
 **email** | **string**| Email of the invited user. | 

### Return type

[**Putresendcancelinvitation**](Putresendcancelinvitation.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

