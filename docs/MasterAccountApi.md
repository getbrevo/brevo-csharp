# brevo_csharp.Api.MasterAccountApi

All URIs are relative to *https://api.brevo.com/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CorporateGroupIdDelete**](MasterAccountApi.md#corporategroupiddelete) | **DELETE** /corporate/group/{id} | Delete a group
[**CorporateGroupIdGet**](MasterAccountApi.md#corporategroupidget) | **GET** /corporate/group/{id} | GET a group details
[**CorporateGroupIdPut**](MasterAccountApi.md#corporategroupidput) | **PUT** /corporate/group/{id} | Update a group of sub-accounts
[**CorporateGroupPost**](MasterAccountApi.md#corporategrouppost) | **POST** /corporate/group | Create a new group of sub-accounts
[**CorporateGroupUnlinkGroupIdSubAccountsPut**](MasterAccountApi.md#corporategroupunlinkgroupidsubaccountsput) | **PUT** /corporate/group/unlink/{groupId}/subAccounts | Delete sub-account from group
[**CorporateIpGet**](MasterAccountApi.md#corporateipget) | **GET** /corporate/ip | List of all IPs
[**CorporateMasterAccountGet**](MasterAccountApi.md#corporatemasteraccountget) | **GET** /corporate/masterAccount | Get the details of requested master account
[**CorporateSsoTokenPost**](MasterAccountApi.md#corporatessotokenpost) | **POST** /corporate/ssoToken | Generate SSO token to access admin account
[**CorporateSubAccountGet**](MasterAccountApi.md#corporatesubaccountget) | **GET** /corporate/subAccount | Get the list of all the sub-accounts of the master account.
[**CorporateSubAccountIdApplicationsTogglePut**](MasterAccountApi.md#corporatesubaccountidapplicationstoggleput) | **PUT** /corporate/subAccount/{id}/applications/toggle | Enable/disable sub-account application(s)
[**CorporateSubAccountIdDelete**](MasterAccountApi.md#corporatesubaccountiddelete) | **DELETE** /corporate/subAccount/{id} | Delete a sub-account
[**CorporateSubAccountIdGet**](MasterAccountApi.md#corporatesubaccountidget) | **GET** /corporate/subAccount/{id} | Get sub-account details
[**CorporateSubAccountIdPlanPut**](MasterAccountApi.md#corporatesubaccountidplanput) | **PUT** /corporate/subAccount/{id}/plan | Update sub-account plan
[**CorporateSubAccountIpAssociatePost**](MasterAccountApi.md#corporatesubaccountipassociatepost) | **POST** /corporate/subAccount/ip/associate | Associate an IP to sub-accounts
[**CorporateSubAccountIpDissociatePut**](MasterAccountApi.md#corporatesubaccountipdissociateput) | **PUT** /corporate/subAccount/ip/dissociate | Dissociate an IP from sub-accounts
[**CorporateSubAccountKeyPost**](MasterAccountApi.md#corporatesubaccountkeypost) | **POST** /corporate/subAccount/key | Create an API key for a sub-account
[**CorporateSubAccountPost**](MasterAccountApi.md#corporatesubaccountpost) | **POST** /corporate/subAccount | Create a new sub-account under a master account.
[**CorporateSubAccountSsoTokenPost**](MasterAccountApi.md#corporatesubaccountssotokenpost) | **POST** /corporate/subAccount/ssoToken | Generate SSO token to access sub-account
[**CorporateSubAccountsPlanPut**](MasterAccountApi.md#corporatesubaccountsplanput) | **PUT** /corporate/subAccounts/plan | Update sub-accounts plan
[**CorporateUserEmailPermissionsPut**](MasterAccountApi.md#corporateuseremailpermissionsput) | **PUT** /corporate/user/{email}/permissions | Change admin user permissions
[**CorporateUserInvitationActionEmailPut**](MasterAccountApi.md#corporateuserinvitationactionemailput) | **PUT** /corporate/user/invitation/{action}/{email} | Resend / cancel admin user invitation
[**CorporateUserRevokeEmailDelete**](MasterAccountApi.md#corporateuserrevokeemaildelete) | **DELETE** /corporate/user/revoke/{email} | Revoke an admin user
[**GetAccountActivity**](MasterAccountApi.md#getaccountactivity) | **GET** /organization/activities | Get user activity logs
[**GetCorporateInvitedUsersList**](MasterAccountApi.md#getcorporateinviteduserslist) | **GET** /corporate/invited/users | Get the list of all admin users
[**GetCorporateUserPermission**](MasterAccountApi.md#getcorporateuserpermission) | **GET** /corporate/user/{email}/permissions | Check admin user permissions
[**GetSubAccountGroups**](MasterAccountApi.md#getsubaccountgroups) | **GET** /corporate/groups | Get the list of groups
[**InviteAdminUser**](MasterAccountApi.md#inviteadminuser) | **POST** /corporate/user/invitation/send | Send invitation to an admin user


<a name="corporategroupiddelete"></a>
# **CorporateGroupIdDelete**
> void CorporateGroupIdDelete (string id)

Delete a group

This endpoint allows you to delete a group of sub-organizations. When a group is deleted, the sub-organizations are no longer part of this group. The users associated with the group are no longer associated with the group once deleted.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateGroupIdDeleteExample
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

            var apiInstance = new MasterAccountApi();
            var id = id_example;  // string | Id of the group

            try
            {
                // Delete a group
                apiInstance.CorporateGroupIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateGroupIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the group | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporategroupidget"></a>
# **CorporateGroupIdGet**
> CorporateGroupDetailsResponse CorporateGroupIdGet (string id)

GET a group details

This endpoint allows you to retrieve a specific group’s information such as the list of sub-organizations and the user associated with the group.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateGroupIdGetExample
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

            var apiInstance = new MasterAccountApi();
            var id = id_example;  // string | Id of the group of sub-organization

            try
            {
                // GET a group details
                CorporateGroupDetailsResponse result = apiInstance.CorporateGroupIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateGroupIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the group of sub-organization | 

### Return type

[**CorporateGroupDetailsResponse**](CorporateGroupDetailsResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporategroupidput"></a>
# **CorporateGroupIdPut**
> void CorporateGroupIdPut (string id, Body3 body)

Update a group of sub-accounts

This endpoint allows you to update a group of sub-accounts

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateGroupIdPutExample
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

            var apiInstance = new MasterAccountApi();
            var id = id_example;  // string | Id of the group
            var body = new Body3(); // Body3 | Group details to be updated.

            try
            {
                // Update a group of sub-accounts
                apiInstance.CorporateGroupIdPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateGroupIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the group | 
 **body** | [**Body3**](Body3.md)| Group details to be updated. | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporategrouppost"></a>
# **CorporateGroupPost**
> InlineResponse201 CorporateGroupPost (Body body)

Create a new group of sub-accounts

This endpoint allows to create a group of sub-accounts

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateGroupPostExample
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

            var apiInstance = new MasterAccountApi();
            var body = new Body(); // Body | Group details to be created.

            try
            {
                // Create a new group of sub-accounts
                InlineResponse201 result = apiInstance.CorporateGroupPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateGroupPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| Group details to be created. | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporategroupunlinkgroupidsubaccountsput"></a>
# **CorporateGroupUnlinkGroupIdSubAccountsPut**
> void CorporateGroupUnlinkGroupIdSubAccountsPut (string groupId, Body4 body)

Delete sub-account from group

This endpoint allows you to remove a sub-organization from a group.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateGroupUnlinkGroupIdSubAccountsPutExample
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

            var apiInstance = new MasterAccountApi();
            var groupId = groupId_example;  // string | Id of the group
            var body = new Body4(); // Body4 | List of sub-account ids

            try
            {
                // Delete sub-account from group
                apiInstance.CorporateGroupUnlinkGroupIdSubAccountsPut(groupId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateGroupUnlinkGroupIdSubAccountsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **string**| Id of the group | 
 **body** | [**Body4**](Body4.md)| List of sub-account ids | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporateipget"></a>
# **CorporateIpGet**
> void CorporateIpGet ()

List of all IPs

This endpoint allows you to retrieve the list of active IPs on your Admin account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateIpGetExample
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

            var apiInstance = new MasterAccountApi();

            try
            {
                // List of all IPs
                apiInstance.CorporateIpGet();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateIpGet: " + e.Message );
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

<a name="corporatemasteraccountget"></a>
# **CorporateMasterAccountGet**
> MasterDetailsResponse CorporateMasterAccountGet ()

Get the details of requested master account

This endpoint will provide the details of the master account.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateMasterAccountGetExample
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

            var apiInstance = new MasterAccountApi();

            try
            {
                // Get the details of requested master account
                MasterDetailsResponse result = apiInstance.CorporateMasterAccountGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateMasterAccountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MasterDetailsResponse**](MasterDetailsResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatessotokenpost"></a>
# **CorporateSsoTokenPost**
> GetSsoToken CorporateSsoTokenPost (SsoTokenRequestCorporate ssoTokenRequestCorporate)

Generate SSO token to access admin account

This endpoint generates an SSO token to authenticate and access the admin account using the endpoint https://account-app.brevo.com/account/login/corporate/sso/[token], where [token] will be replaced by the actual token.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSsoTokenPostExample
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

            var apiInstance = new MasterAccountApi();
            var ssoTokenRequestCorporate = new SsoTokenRequestCorporate(); // SsoTokenRequestCorporate | User email of admin account

            try
            {
                // Generate SSO token to access admin account
                GetSsoToken result = apiInstance.CorporateSsoTokenPost(ssoTokenRequestCorporate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSsoTokenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ssoTokenRequestCorporate** | [**SsoTokenRequestCorporate**](SsoTokenRequestCorporate.md)| User email of admin account | 

### Return type

[**GetSsoToken**](GetSsoToken.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountget"></a>
# **CorporateSubAccountGet**
> SubAccountsResponse CorporateSubAccountGet (int? offset, int? limit)

Get the list of all the sub-accounts of the master account.

This endpoint will provide the list all the sub-accounts of the master account.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountGetExample
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

            var apiInstance = new MasterAccountApi();
            var offset = 56;  // int? | Index of the first sub-account in the page
            var limit = 56;  // int? | Number of sub-accounts to be displayed on each page

            try
            {
                // Get the list of all the sub-accounts of the master account.
                SubAccountsResponse result = apiInstance.CorporateSubAccountGet(offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Index of the first sub-account in the page | 
 **limit** | **int?**| Number of sub-accounts to be displayed on each page | 

### Return type

[**SubAccountsResponse**](SubAccountsResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountidapplicationstoggleput"></a>
# **CorporateSubAccountIdApplicationsTogglePut**
> void CorporateSubAccountIdApplicationsTogglePut (long? id, SubAccountAppsToggleRequest toggleApplications)

Enable/disable sub-account application(s)

API endpoint for the Corporate owner to enable/disable applications on the sub-account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountIdApplicationsTogglePutExample
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

            var apiInstance = new MasterAccountApi();
            var id = 789;  // long? | Id of the sub-account organization (mandatory)
            var toggleApplications = new SubAccountAppsToggleRequest(); // SubAccountAppsToggleRequest | List of applications to activate or deactivate on a sub-account

            try
            {
                // Enable/disable sub-account application(s)
                apiInstance.CorporateSubAccountIdApplicationsTogglePut(id, toggleApplications);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountIdApplicationsTogglePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the sub-account organization (mandatory) | 
 **toggleApplications** | [**SubAccountAppsToggleRequest**](SubAccountAppsToggleRequest.md)| List of applications to activate or deactivate on a sub-account | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountiddelete"></a>
# **CorporateSubAccountIdDelete**
> void CorporateSubAccountIdDelete (long? id)

Delete a sub-account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountIdDeleteExample
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

            var apiInstance = new MasterAccountApi();
            var id = 789;  // long? | Id of the sub-account organization to be deleted

            try
            {
                // Delete a sub-account
                apiInstance.CorporateSubAccountIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the sub-account organization to be deleted | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountidget"></a>
# **CorporateSubAccountIdGet**
> SubAccountDetailsResponse CorporateSubAccountIdGet (long? id)

Get sub-account details

This endpoint will provide the details for the specified sub-account company

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountIdGetExample
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

            var apiInstance = new MasterAccountApi();
            var id = 789;  // long? | Id of the sub-account organization

            try
            {
                // Get sub-account details
                SubAccountDetailsResponse result = apiInstance.CorporateSubAccountIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the sub-account organization | 

### Return type

[**SubAccountDetailsResponse**](SubAccountDetailsResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountidplanput"></a>
# **CorporateSubAccountIdPlanPut**
> void CorporateSubAccountIdPlanPut (long? id, SubAccountUpdatePlanRequest updatePlanDetails)

Update sub-account plan

This endpoint will update the sub-account plan. On the Corporate solution new version v2, you can set an unlimited number of credits in your sub-organization. Please pass the value “-1\" to set the consumable in unlimited mode.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountIdPlanPutExample
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

            var apiInstance = new MasterAccountApi();
            var id = 789;  // long? | Id of the sub-account organization
            var updatePlanDetails = new SubAccountUpdatePlanRequest(); // SubAccountUpdatePlanRequest | Values to update a sub-account plan

            try
            {
                // Update sub-account plan
                apiInstance.CorporateSubAccountIdPlanPut(id, updatePlanDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountIdPlanPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| Id of the sub-account organization | 
 **updatePlanDetails** | [**SubAccountUpdatePlanRequest**](SubAccountUpdatePlanRequest.md)| Values to update a sub-account plan | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountipassociatepost"></a>
# **CorporateSubAccountIpAssociatePost**
> Object CorporateSubAccountIpAssociatePost (Body1 body)

Associate an IP to sub-accounts

This endpoint allows to associate an IP to sub-accounts

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountIpAssociatePostExample
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

            var apiInstance = new MasterAccountApi();
            var body = new Body1(); // Body1 | Ip address association details

            try
            {
                // Associate an IP to sub-accounts
                Object result = apiInstance.CorporateSubAccountIpAssociatePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountIpAssociatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body1**](Body1.md)| Ip address association details | 

### Return type

**Object**

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountipdissociateput"></a>
# **CorporateSubAccountIpDissociatePut**
> void CorporateSubAccountIpDissociatePut (Body2 body)

Dissociate an IP from sub-accounts

This endpoint allows to dissociate an IP from sub-accounts

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountIpDissociatePutExample
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

            var apiInstance = new MasterAccountApi();
            var body = new Body2(); // Body2 | Ip address dissociation details

            try
            {
                // Dissociate an IP from sub-accounts
                apiInstance.CorporateSubAccountIpDissociatePut(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountIpDissociatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body2**](Body2.md)| Ip address dissociation details | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountkeypost"></a>
# **CorporateSubAccountKeyPost**
> CreateApiKeyResponse CorporateSubAccountKeyPost (CreateApiKeyRequest createApiKeyRequest)

Create an API key for a sub-account

This endpoint will generate an API v3 key for a sub account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountKeyPostExample
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

            var apiInstance = new MasterAccountApi();
            var createApiKeyRequest = new CreateApiKeyRequest(); // CreateApiKeyRequest | Values to generate API key for sub-account

            try
            {
                // Create an API key for a sub-account
                CreateApiKeyResponse result = apiInstance.CorporateSubAccountKeyPost(createApiKeyRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountKeyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createApiKeyRequest** | [**CreateApiKeyRequest**](CreateApiKeyRequest.md)| Values to generate API key for sub-account | 

### Return type

[**CreateApiKeyResponse**](CreateApiKeyResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountpost"></a>
# **CorporateSubAccountPost**
> CreateSubAccountResponse CorporateSubAccountPost (CreateSubAccount subAccountCreate)

Create a new sub-account under a master account.

This endpoint will create a new sub-account under a master account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountPostExample
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

            var apiInstance = new MasterAccountApi();
            var subAccountCreate = new CreateSubAccount(); // CreateSubAccount | values to create new sub-account

            try
            {
                // Create a new sub-account under a master account.
                CreateSubAccountResponse result = apiInstance.CorporateSubAccountPost(subAccountCreate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subAccountCreate** | [**CreateSubAccount**](CreateSubAccount.md)| values to create new sub-account | 

### Return type

[**CreateSubAccountResponse**](CreateSubAccountResponse.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountssotokenpost"></a>
# **CorporateSubAccountSsoTokenPost**
> GetSsoToken CorporateSubAccountSsoTokenPost (SsoTokenRequest ssoTokenRequest)

Generate SSO token to access sub-account

This endpoint generates an sso token to authenticate and access a sub-account of the master using the account endpoint https://account-app.brevo.com/account/login/sub-account/sso/[token], where [token] will be replaced by the actual token.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountSsoTokenPostExample
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

            var apiInstance = new MasterAccountApi();
            var ssoTokenRequest = new SsoTokenRequest(); // SsoTokenRequest | Values to generate SSO token for sub-account

            try
            {
                // Generate SSO token to access sub-account
                GetSsoToken result = apiInstance.CorporateSubAccountSsoTokenPost(ssoTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountSsoTokenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ssoTokenRequest** | [**SsoTokenRequest**](SsoTokenRequest.md)| Values to generate SSO token for sub-account | 

### Return type

[**GetSsoToken**](GetSsoToken.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporatesubaccountsplanput"></a>
# **CorporateSubAccountsPlanPut**
> void CorporateSubAccountsPlanPut (SubAccountsUpdatePlanRequest updatePlanDetails)

Update sub-accounts plan

This endpoint will update multiple sub-accounts plan. On the Corporate solution new version v2, you can set an unlimited number of credits in your sub-organization. Please pass the value “-1\" to set the consumable in unlimited mode.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateSubAccountsPlanPutExample
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

            var apiInstance = new MasterAccountApi();
            var updatePlanDetails = new SubAccountsUpdatePlanRequest(); // SubAccountsUpdatePlanRequest | Values to update sub-accounts plan

            try
            {
                // Update sub-accounts plan
                apiInstance.CorporateSubAccountsPlanPut(updatePlanDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateSubAccountsPlanPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updatePlanDetails** | [**SubAccountsUpdatePlanRequest**](SubAccountsUpdatePlanRequest.md)| Values to update sub-accounts plan | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporateuseremailpermissionsput"></a>
# **CorporateUserEmailPermissionsPut**
> void CorporateUserEmailPermissionsPut (string email, Body5 body)

Change admin user permissions

This endpoint will allow you to change the permissions of Admin users of your Admin account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateUserEmailPermissionsPutExample
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

            var apiInstance = new MasterAccountApi();
            var email = email_example;  // string | Email address of Admin user
            var body = new Body5(); // Body5 | Values to update an admin user permissions

            try
            {
                // Change admin user permissions
                apiInstance.CorporateUserEmailPermissionsPut(email, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateUserEmailPermissionsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email address of Admin user | 
 **body** | [**Body5**](Body5.md)| Values to update an admin user permissions | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporateuserinvitationactionemailput"></a>
# **CorporateUserInvitationActionEmailPut**
> InlineResponse200 CorporateUserInvitationActionEmailPut (string action, string email)

Resend / cancel admin user invitation

This endpoint will allow the user to: - Resend an admin user invitation - Cancel an admin user invitation 

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateUserInvitationActionEmailPutExample
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

            var apiInstance = new MasterAccountApi();
            var action = action_example;  // string | Action to be performed (cancel / resend)
            var email = email_example;  // string | Email address of the recipient

            try
            {
                // Resend / cancel admin user invitation
                InlineResponse200 result = apiInstance.CorporateUserInvitationActionEmailPut(action, email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateUserInvitationActionEmailPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**| Action to be performed (cancel / resend) | 
 **email** | **string**| Email address of the recipient | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corporateuserrevokeemaildelete"></a>
# **CorporateUserRevokeEmailDelete**
> void CorporateUserRevokeEmailDelete (string email)

Revoke an admin user

This endpoint allows to revoke/remove an invited member of your Admin account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class CorporateUserRevokeEmailDeleteExample
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

            var apiInstance = new MasterAccountApi();
            var email = email_example;  // string | Email of the invited user

            try
            {
                // Revoke an admin user
                apiInstance.CorporateUserRevokeEmailDelete(email);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.CorporateUserRevokeEmailDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email of the invited user | 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountactivity"></a>
# **GetAccountActivity**
> GetAccountActivity GetAccountActivity (string startDate = null, string endDate = null, string email = null, long? limit = null, long? offset = null)

Get user activity logs

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetAccountActivityExample
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

            var apiInstance = new MasterAccountApi();
            var startDate = startDate_example;  // string | Mandatory if endDate is used. Enter start date in UTC date (YYYY-MM-DD) format to filter the activity in your account. Maximum time period that can be selected is one month. Additionally, you can retrieve activity logs from the past 12 months from the date of your search. (optional) 
            var endDate = endDate_example;  // string | Mandatory if startDate is used. Enter end date in UTC date (YYYY-MM-DD) format to filter the activity in your account. Maximum time period that can be selected is one month. (optional) 
            var email = email_example;  // string | Enter the user's email address to filter their activity in the account. (optional) 
            var limit = 789;  // long? | Number of documents per page (optional)  (default to 10)
            var offset = 789;  // long? | Index of the first document in the page. (optional)  (default to 0)

            try
            {
                // Get user activity logs
                GetAccountActivity result = apiInstance.GetAccountActivity(startDate, endDate, email, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.GetAccountActivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **string**| Mandatory if endDate is used. Enter start date in UTC date (YYYY-MM-DD) format to filter the activity in your account. Maximum time period that can be selected is one month. Additionally, you can retrieve activity logs from the past 12 months from the date of your search. | [optional] 
 **endDate** | **string**| Mandatory if startDate is used. Enter end date in UTC date (YYYY-MM-DD) format to filter the activity in your account. Maximum time period that can be selected is one month. | [optional] 
 **email** | **string**| Enter the user&#39;s email address to filter their activity in the account. | [optional] 
 **limit** | **long?**| Number of documents per page | [optional] [default to 10]
 **offset** | **long?**| Index of the first document in the page. | [optional] [default to 0]

### Return type

[**GetAccountActivity**](GetAccountActivity.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporateinviteduserslist"></a>
# **GetCorporateInvitedUsersList**
> GetCorporateInvitedUsersList GetCorporateInvitedUsersList ()

Get the list of all admin users

This endpoint allows you to list all Admin users of your Admin account

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetCorporateInvitedUsersListExample
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

            var apiInstance = new MasterAccountApi();

            try
            {
                // Get the list of all admin users
                GetCorporateInvitedUsersList result = apiInstance.GetCorporateInvitedUsersList();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.GetCorporateInvitedUsersList: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GetCorporateInvitedUsersList**](GetCorporateInvitedUsersList.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporateuserpermission"></a>
# **GetCorporateUserPermission**
> GetCorporateUserPermission GetCorporateUserPermission (string email)

Check admin user permissions

This endpoint will provide the list of admin user permissions

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetCorporateUserPermissionExample
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

            var apiInstance = new MasterAccountApi();
            var email = email_example;  // string | Email of the invited user

            try
            {
                // Check admin user permissions
                GetCorporateUserPermission result = apiInstance.GetCorporateUserPermission(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.GetCorporateUserPermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Email of the invited user | 

### Return type

[**GetCorporateUserPermission**](GetCorporateUserPermission.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubaccountgroups"></a>
# **GetSubAccountGroups**
> List<InlineResponse2001> GetSubAccountGroups ()

Get the list of groups

This endpoint allows you to list all groups created on your Admin account.

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class GetSubAccountGroupsExample
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

            var apiInstance = new MasterAccountApi();

            try
            {
                // Get the list of groups
                List&lt;InlineResponse2001&gt; result = apiInstance.GetSubAccountGroups();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.GetSubAccountGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InlineResponse2001>**](InlineResponse2001.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteadminuser"></a>
# **InviteAdminUser**
> InviteAdminUser InviteAdminUser (InviteAdminUser sendInvitation)

Send invitation to an admin user

`This endpoint allows you to invite a member to manage the Admin account  Features and their respective permissions are as below:  - `my_plan`:   - \"all\" - `api`:   - \"none\" - `user_management`:   - \"all\" - `app_management` | Not available in ENTv2:   - \"all\" - `sub_organization_groups`   - \"create\"   - \"edit_delete\" - `create_sub_organizations`   - \"all\" - `manage_sub_organizations`   - \"all\" - `analytics`   - \"download_data\"   - \"create_alerts\"   - \"my_looks\"   - \"explore_create\" - `security`   - \"all\"  **Note**: - If `all_features_access: false` then only privileges are required otherwise if `true` then it's assumed that all permissions will be there for the invited admin user. 

### Example
```csharp
using System;
using System.Diagnostics;
using brevo_csharp.Api;
using brevo_csharp.Client;
using brevo_csharp.Model;

namespace Example
{
    public class InviteAdminUserExample
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

            var apiInstance = new MasterAccountApi();
            var sendInvitation = new InviteAdminUser(); // InviteAdminUser | Payload to send an invitation

            try
            {
                // Send invitation to an admin user
                InviteAdminUser result = apiInstance.InviteAdminUser(sendInvitation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterAccountApi.InviteAdminUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sendInvitation** | [**InviteAdminUser**](InviteAdminUser.md)| Payload to send an invitation | 

### Return type

[**InviteAdminUser**](InviteAdminUser.md)

### Authorization

[api-key](../README.md#api-key), [partner-key](../README.md#partner-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

