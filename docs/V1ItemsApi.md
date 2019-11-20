# Square.Connect.Api.V1ItemsApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdjustInventory**](V1ItemsApi.md#adjustinventory) | **POST** /v1/{location_id}/inventory/{variation_id} | AdjustInventory
[**ApplyFee**](V1ItemsApi.md#applyfee) | **PUT** /v1/{location_id}/items/{item_id}/fees/{fee_id} | ApplyFee
[**ApplyModifierList**](V1ItemsApi.md#applymodifierlist) | **PUT** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id} | ApplyModifierList
[**CreateCategory**](V1ItemsApi.md#createcategory) | **POST** /v1/{location_id}/categories | CreateCategory
[**CreateDiscount**](V1ItemsApi.md#creatediscount) | **POST** /v1/{location_id}/discounts | CreateDiscount
[**CreateFee**](V1ItemsApi.md#createfee) | **POST** /v1/{location_id}/fees | CreateFee
[**CreateItem**](V1ItemsApi.md#createitem) | **POST** /v1/{location_id}/items | CreateItem
[**CreateModifierList**](V1ItemsApi.md#createmodifierlist) | **POST** /v1/{location_id}/modifier-lists | CreateModifierList
[**CreateModifierOption**](V1ItemsApi.md#createmodifieroption) | **POST** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options | CreateModifierOption
[**CreatePage**](V1ItemsApi.md#createpage) | **POST** /v1/{location_id}/pages | CreatePage
[**CreateVariation**](V1ItemsApi.md#createvariation) | **POST** /v1/{location_id}/items/{item_id}/variations | CreateVariation
[**DeleteCategory**](V1ItemsApi.md#deletecategory) | **DELETE** /v1/{location_id}/categories/{category_id} | DeleteCategory
[**DeleteDiscount**](V1ItemsApi.md#deletediscount) | **DELETE** /v1/{location_id}/discounts/{discount_id} | DeleteDiscount
[**DeleteFee**](V1ItemsApi.md#deletefee) | **DELETE** /v1/{location_id}/fees/{fee_id} | DeleteFee
[**DeleteItem**](V1ItemsApi.md#deleteitem) | **DELETE** /v1/{location_id}/items/{item_id} | DeleteItem
[**DeleteModifierList**](V1ItemsApi.md#deletemodifierlist) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id} | DeleteModifierList
[**DeleteModifierOption**](V1ItemsApi.md#deletemodifieroption) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id} | DeleteModifierOption
[**DeletePage**](V1ItemsApi.md#deletepage) | **DELETE** /v1/{location_id}/pages/{page_id} | DeletePage
[**DeletePageCell**](V1ItemsApi.md#deletepagecell) | **DELETE** /v1/{location_id}/pages/{page_id}/cells | DeletePageCell
[**DeleteVariation**](V1ItemsApi.md#deletevariation) | **DELETE** /v1/{location_id}/items/{item_id}/variations/{variation_id} | DeleteVariation
[**ListCategories**](V1ItemsApi.md#listcategories) | **GET** /v1/{location_id}/categories | ListCategories
[**ListDiscounts**](V1ItemsApi.md#listdiscounts) | **GET** /v1/{location_id}/discounts | ListDiscounts
[**ListFees**](V1ItemsApi.md#listfees) | **GET** /v1/{location_id}/fees | ListFees
[**ListInventory**](V1ItemsApi.md#listinventory) | **GET** /v1/{location_id}/inventory | ListInventory
[**ListItems**](V1ItemsApi.md#listitems) | **GET** /v1/{location_id}/items | ListItems
[**ListModifierLists**](V1ItemsApi.md#listmodifierlists) | **GET** /v1/{location_id}/modifier-lists | ListModifierLists
[**ListPages**](V1ItemsApi.md#listpages) | **GET** /v1/{location_id}/pages | ListPages
[**RemoveFee**](V1ItemsApi.md#removefee) | **DELETE** /v1/{location_id}/items/{item_id}/fees/{fee_id} | RemoveFee
[**RemoveModifierList**](V1ItemsApi.md#removemodifierlist) | **DELETE** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id} | RemoveModifierList
[**RetrieveItem**](V1ItemsApi.md#retrieveitem) | **GET** /v1/{location_id}/items/{item_id} | RetrieveItem
[**RetrieveModifierList**](V1ItemsApi.md#retrievemodifierlist) | **GET** /v1/{location_id}/modifier-lists/{modifier_list_id} | RetrieveModifierList
[**UpdateCategory**](V1ItemsApi.md#updatecategory) | **PUT** /v1/{location_id}/categories/{category_id} | UpdateCategory
[**UpdateDiscount**](V1ItemsApi.md#updatediscount) | **PUT** /v1/{location_id}/discounts/{discount_id} | UpdateDiscount
[**UpdateFee**](V1ItemsApi.md#updatefee) | **PUT** /v1/{location_id}/fees/{fee_id} | UpdateFee
[**UpdateItem**](V1ItemsApi.md#updateitem) | **PUT** /v1/{location_id}/items/{item_id} | UpdateItem
[**UpdateModifierList**](V1ItemsApi.md#updatemodifierlist) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id} | UpdateModifierList
[**UpdateModifierOption**](V1ItemsApi.md#updatemodifieroption) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id} | UpdateModifierOption
[**UpdatePage**](V1ItemsApi.md#updatepage) | **PUT** /v1/{location_id}/pages/{page_id} | UpdatePage
[**UpdatePageCell**](V1ItemsApi.md#updatepagecell) | **PUT** /v1/{location_id}/pages/{page_id}/cells | UpdatePageCell
[**UpdateVariation**](V1ItemsApi.md#updatevariation) | **PUT** /v1/{location_id}/items/{item_id}/variations/{variation_id} | UpdateVariation


<a name="adjustinventory"></a>
# **AdjustInventory**
**Note: This endpoint is deprecated.**
> V1InventoryEntry AdjustInventory (string locationId, string variationId, V1AdjustInventoryRequest body)

AdjustInventory

Adjusts the current available inventory of an item variation.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class AdjustInventoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var variationId = variationId_example;  // string | The ID of the variation to adjust inventory information for.
            var body = new V1AdjustInventoryRequest(); // V1AdjustInventoryRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // AdjustInventory
                V1InventoryEntry result = apiInstance.AdjustInventory(locationId, variationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.AdjustInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **variationId** | **string**| The ID of the variation to adjust inventory information for. | 
 **body** | [**V1AdjustInventoryRequest**](V1AdjustInventoryRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1InventoryEntry**](V1InventoryEntry.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applyfee"></a>
# **ApplyFee**
**Note: This endpoint is deprecated.**
> V1Item ApplyFee (string locationId, string itemId, string feeId)

ApplyFee

Associates a fee with an item so the fee is automatically applied to the item in Square Point of Sale.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ApplyFeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the fee's associated location.
            var itemId = itemId_example;  // string | The ID of the item to add the fee to.
            var feeId = feeId_example;  // string | The ID of the fee to apply.

            try
            {
                // ApplyFee
                V1Item result = apiInstance.ApplyFee(locationId, itemId, feeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.ApplyFee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the fee&#39;s associated location. | 
 **itemId** | **string**| The ID of the item to add the fee to. | 
 **feeId** | **string**| The ID of the fee to apply. | 

### Return type

[**V1Item**](V1Item.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="applymodifierlist"></a>
# **ApplyModifierList**
**Note: This endpoint is deprecated.**
> V1Item ApplyModifierList (string locationId, string modifierListId, string itemId)

ApplyModifierList

Associates a modifier list with an item so the associated modifier options can be applied to the item.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ApplyModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to apply.
            var itemId = itemId_example;  // string | The ID of the item to add the modifier list to.

            try
            {
                // ApplyModifierList
                V1Item result = apiInstance.ApplyModifierList(locationId, modifierListId, itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.ApplyModifierList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **modifierListId** | **string**| The ID of the modifier list to apply. | 
 **itemId** | **string**| The ID of the item to add the modifier list to. | 

### Return type

[**V1Item**](V1Item.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcategory"></a>
# **CreateCategory**
**Note: This endpoint is deprecated.**
> V1Category CreateCategory (string locationId, V1Category body)

CreateCategory

Creates an item category.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create an item for.
            var body = new V1Category(); // V1Category | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateCategory
                V1Category result = apiInstance.CreateCategory(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.CreateCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to create an item for. | 
 **body** | [**V1Category**](V1Category.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Category**](V1Category.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creatediscount"></a>
# **CreateDiscount**
**Note: This endpoint is deprecated.**
> V1Discount CreateDiscount (string locationId, V1Discount body)

CreateDiscount

Creates a discount.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateDiscountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create an item for.
            var body = new V1Discount(); // V1Discount | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateDiscount
                V1Discount result = apiInstance.CreateDiscount(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.CreateDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to create an item for. | 
 **body** | [**V1Discount**](V1Discount.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Discount**](V1Discount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfee"></a>
# **CreateFee**
**Note: This endpoint is deprecated.**
> V1Fee CreateFee (string locationId, V1Fee body)

CreateFee

Creates a fee (tax).  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateFeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create a fee for.
            var body = new V1Fee(); // V1Fee | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateFee
                V1Fee result = apiInstance.CreateFee(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.CreateFee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to create a fee for. | 
 **body** | [**V1Fee**](V1Fee.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Fee**](V1Fee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createitem"></a>
# **CreateItem**
**Note: This endpoint is deprecated.**
> V1Item CreateItem (string locationId, V1Item body)

CreateItem

Creates an item and at least one variation for it.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --   Item-related entities include fields you can use to associate them with entities in a non-Square system.  When you create an item-related entity, you can optionally specify `id`. This value must be unique among all IDs ever specified for the account, including those specified by other applications. You can never reuse an entity ID. If you do not specify an ID, Square generates one for the entity.  Item variations have a `user_data` string that lets you associate arbitrary metadata with the variation. The string cannot exceed 255 characters.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create an item for.
            var body = new V1Item(); // V1Item | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateItem
                V1Item result = apiInstance.CreateItem(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.CreateItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to create an item for. | 
 **body** | [**V1Item**](V1Item.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Item**](V1Item.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmodifierlist"></a>
# **CreateModifierList**
**Note: This endpoint is deprecated.**
> V1ModifierList CreateModifierList (string locationId, V1ModifierList body)

CreateModifierList

Creates an item modifier list and at least 1 modifier option for it.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create a modifier list for.
            var body = new V1ModifierList(); // V1ModifierList | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateModifierList
                V1ModifierList result = apiInstance.CreateModifierList(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.CreateModifierList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to create a modifier list for. | 
 **body** | [**V1ModifierList**](V1ModifierList.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1ModifierList**](V1ModifierList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmodifieroption"></a>
# **CreateModifierOption**
**Note: This endpoint is deprecated.**
> V1ModifierOption CreateModifierOption (string locationId, string modifierListId, V1ModifierOption body)

CreateModifierOption

Creates an item modifier option and adds it to a modifier list.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateModifierOptionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to edit.
            var body = new V1ModifierOption(); // V1ModifierOption | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateModifierOption
                V1ModifierOption result = apiInstance.CreateModifierOption(locationId, modifierListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.CreateModifierOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **modifierListId** | **string**| The ID of the modifier list to edit. | 
 **body** | [**V1ModifierOption**](V1ModifierOption.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1ModifierOption**](V1ModifierOption.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpage"></a>
# **CreatePage**
**Note: This endpoint is deprecated.**
> V1Page CreatePage (string locationId, V1Page body)

CreatePage

Creates a Favorites page in Square Point of Sale.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreatePageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create an item for.
            var body = new V1Page(); // V1Page | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreatePage
                V1Page result = apiInstance.CreatePage(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.CreatePage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to create an item for. | 
 **body** | [**V1Page**](V1Page.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Page**](V1Page.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createvariation"></a>
# **CreateVariation**
**Note: This endpoint is deprecated.**
> V1Variation CreateVariation (string locationId, string itemId, V1Variation body)

CreateVariation

Creates an item variation for an existing item.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class CreateVariationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The item's ID.
            var body = new V1Variation(); // V1Variation | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // CreateVariation
                V1Variation result = apiInstance.CreateVariation(locationId, itemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.CreateVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **itemId** | **string**| The item&#39;s ID. | 
 **body** | [**V1Variation**](V1Variation.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Variation**](V1Variation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecategory"></a>
# **DeleteCategory**
**Note: This endpoint is deprecated.**
> V1Category DeleteCategory (string locationId, string categoryId)

DeleteCategory

Deletes an existing item category.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --  __DeleteCategory__ returns nothing on success but Connect SDKs map the empty response to an empty `V1DeleteCategoryRequest` object as documented below.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var categoryId = categoryId_example;  // string | The ID of the category to delete.

            try
            {
                // DeleteCategory
                V1Category result = apiInstance.DeleteCategory(locationId, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.DeleteCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **categoryId** | **string**| The ID of the category to delete. | 

### Return type

[**V1Category**](V1Category.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletediscount"></a>
# **DeleteDiscount**
**Note: This endpoint is deprecated.**
> V1Discount DeleteDiscount (string locationId, string discountId)

DeleteDiscount

Deletes an existing discount.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --  __DeleteDiscount__ returns nothing on success but Connect SDKs map the empty response to an empty `V1DeleteDiscountRequest` object as documented below.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteDiscountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var discountId = discountId_example;  // string | The ID of the discount to delete.

            try
            {
                // DeleteDiscount
                V1Discount result = apiInstance.DeleteDiscount(locationId, discountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.DeleteDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **discountId** | **string**| The ID of the discount to delete. | 

### Return type

[**V1Discount**](V1Discount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefee"></a>
# **DeleteFee**
**Note: This endpoint is deprecated.**
> V1Fee DeleteFee (string locationId, string feeId)

DeleteFee

Deletes an existing fee (tax).  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --  __DeleteFee__ returns nothing on success but Connect SDKs map the empty response to an empty `V1DeleteFeeRequest` object as documented below.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteFeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the fee's associated location.
            var feeId = feeId_example;  // string | The ID of the fee to delete.

            try
            {
                // DeleteFee
                V1Fee result = apiInstance.DeleteFee(locationId, feeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.DeleteFee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the fee&#39;s associated location. | 
 **feeId** | **string**| The ID of the fee to delete. | 

### Return type

[**V1Fee**](V1Fee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteitem"></a>
# **DeleteItem**
**Note: This endpoint is deprecated.**
> V1Item DeleteItem (string locationId, string itemId)

DeleteItem

Deletes an existing item and all item variations associated with it.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --  __DeleteItem__ returns nothing on success but Connect SDKs map the empty response to an empty `V1DeleteItemRequest` object as documented below.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The ID of the item to modify.

            try
            {
                // DeleteItem
                V1Item result = apiInstance.DeleteItem(locationId, itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.DeleteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **itemId** | **string**| The ID of the item to modify. | 

### Return type

[**V1Item**](V1Item.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemodifierlist"></a>
# **DeleteModifierList**
**Note: This endpoint is deprecated.**
> V1ModifierList DeleteModifierList (string locationId, string modifierListId)

DeleteModifierList

Deletes an existing item modifier list and all modifier options associated with it.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --  __DeleteModifierList__ returns nothing on success but Connect SDKs map the empty response to an empty `V1DeleteModifierListRequest` object as documented below.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to delete.

            try
            {
                // DeleteModifierList
                V1ModifierList result = apiInstance.DeleteModifierList(locationId, modifierListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.DeleteModifierList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **modifierListId** | **string**| The ID of the modifier list to delete. | 

### Return type

[**V1ModifierList**](V1ModifierList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemodifieroption"></a>
# **DeleteModifierOption**
**Note: This endpoint is deprecated.**
> V1ModifierOption DeleteModifierOption (string locationId, string modifierListId, string modifierOptionId)

DeleteModifierOption

Deletes an existing item modifier option from a modifier list.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --  __DeleteModifierOption__ returns nothing on success but Connect SDKs map the empty response to an empty `V1DeleteModifierOptionRequest` object.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteModifierOptionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to delete.
            var modifierOptionId = modifierOptionId_example;  // string | The ID of the modifier list to edit.

            try
            {
                // DeleteModifierOption
                V1ModifierOption result = apiInstance.DeleteModifierOption(locationId, modifierListId, modifierOptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.DeleteModifierOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **modifierListId** | **string**| The ID of the modifier list to delete. | 
 **modifierOptionId** | **string**| The ID of the modifier list to edit. | 

### Return type

[**V1ModifierOption**](V1ModifierOption.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepage"></a>
# **DeletePage**
**Note: This endpoint is deprecated.**
> V1Page DeletePage (string locationId, string pageId)

DeletePage

Deletes an existing Favorites page and all of its cells.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --  __DeletePage__ returns nothing on success but Connect SDKs map the empty response to an empty `V1DeletePageRequest` object.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeletePageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the Favorites page's associated location.
            var pageId = pageId_example;  // string | The ID of the page to delete.

            try
            {
                // DeletePage
                V1Page result = apiInstance.DeletePage(locationId, pageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.DeletePage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the Favorites page&#39;s associated location. | 
 **pageId** | **string**| The ID of the page to delete. | 

### Return type

[**V1Page**](V1Page.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepagecell"></a>
# **DeletePageCell**
**Note: This endpoint is deprecated.**
> V1Page DeletePageCell (string locationId, string pageId, string row = null, string column = null)

DeletePageCell

Deletes a cell from a Favorites page in Square Point of Sale.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --  __DeletePageCell__ returns nothing on success but Connect SDKs map the empty response to an empty `V1DeletePageCellRequest` object as documented below.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeletePageCellExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the Favorites page's associated location.
            var pageId = pageId_example;  // string | The ID of the page to delete.
            var row = row_example;  // string | The row of the cell to clear. Always an integer between 0 and 4, inclusive. Row 0 is the top row. (optional) 
            var column = column_example;  // string | The column of the cell to clear. Always an integer between 0 and 4, inclusive. Column 0 is the leftmost column. (optional) 

            try
            {
                // DeletePageCell
                V1Page result = apiInstance.DeletePageCell(locationId, pageId, row, column);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.DeletePageCell: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the Favorites page&#39;s associated location. | 
 **pageId** | **string**| The ID of the page to delete. | 
 **row** | **string**| The row of the cell to clear. Always an integer between 0 and 4, inclusive. Row 0 is the top row. | [optional] 
 **column** | **string**| The column of the cell to clear. Always an integer between 0 and 4, inclusive. Column 0 is the leftmost column. | [optional] 

### Return type

[**V1Page**](V1Page.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletevariation"></a>
# **DeleteVariation**
**Note: This endpoint is deprecated.**
> V1Variation DeleteVariation (string locationId, string itemId, string variationId)

DeleteVariation

Deletes an existing item variation from an item.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --  __DeleteVariation__ returns nothing on success but Connect SDKs map the empty response to an empty `V1DeleteVariationRequest` object as documented below.

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class DeleteVariationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The ID of the item to delete.
            var variationId = variationId_example;  // string | The ID of the variation to delete.

            try
            {
                // DeleteVariation
                V1Variation result = apiInstance.DeleteVariation(locationId, itemId, variationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.DeleteVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **itemId** | **string**| The ID of the item to delete. | 
 **variationId** | **string**| The ID of the variation to delete. | 

### Return type

[**V1Variation**](V1Variation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcategories"></a>
# **ListCategories**
**Note: This endpoint is deprecated.**
> List<V1Category> ListCategories (string locationId)

ListCategories

Lists all the item categories for a given location.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list categories for.

            try
            {
                // ListCategories
                List&lt;V1Category&gt; result = apiInstance.ListCategories(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.ListCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list categories for. | 

### Return type

[**List<V1Category>**](V1Category.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdiscounts"></a>
# **ListDiscounts**
**Note: This endpoint is deprecated.**
> List<V1Discount> ListDiscounts (string locationId)

ListDiscounts

Lists all the discounts for a given location.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListDiscountsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list categories for.

            try
            {
                // ListDiscounts
                List&lt;V1Discount&gt; result = apiInstance.ListDiscounts(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.ListDiscounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list categories for. | 

### Return type

[**List<V1Discount>**](V1Discount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfees"></a>
# **ListFees**
**Note: This endpoint is deprecated.**
> List<V1Fee> ListFees (string locationId)

ListFees

Lists all the fees (taxes) for a given location.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListFeesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list fees for.

            try
            {
                // ListFees
                List&lt;V1Fee&gt; result = apiInstance.ListFees(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.ListFees: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list fees for. | 

### Return type

[**List<V1Fee>**](V1Fee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinventory"></a>
# **ListInventory**
**Note: This endpoint is deprecated.**
> List<V1InventoryEntry> ListInventory (string locationId, int? limit = null, string batchToken = null)

ListInventory

Provides inventory information for all inventory-enabled item variations.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListInventoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var limit = 56;  // int? | The maximum number of inventory entries to return in a single response. This value cannot exceed 1000. (optional) 
            var batchToken = batchToken_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // ListInventory
                List&lt;V1InventoryEntry&gt; result = apiInstance.ListInventory(locationId, limit, batchToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.ListInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **limit** | **int?**| The maximum number of inventory entries to return in a single response. This value cannot exceed 1000. | [optional] 
 **batchToken** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**List<V1InventoryEntry>**](V1InventoryEntry.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listitems"></a>
# **ListItems**
**Note: This endpoint is deprecated.**
> List<V1Item> ListItems (string locationId, string batchToken = null)

ListItems

Provides summary information of all items for a given location.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListItemsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list items for.
            var batchToken = batchToken_example;  // string | A pagination cursor to retrieve the next set of results for your original query to the endpoint. (optional) 

            try
            {
                // ListItems
                List&lt;V1Item&gt; result = apiInstance.ListItems(locationId, batchToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.ListItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list items for. | 
 **batchToken** | **string**| A pagination cursor to retrieve the next set of results for your original query to the endpoint. | [optional] 

### Return type

[**List<V1Item>**](V1Item.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmodifierlists"></a>
# **ListModifierLists**
**Note: This endpoint is deprecated.**
> List<V1ModifierList> ListModifierLists (string locationId)

ListModifierLists

Lists all the modifier lists for a given location.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListModifierListsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list modifier lists for.

            try
            {
                // ListModifierLists
                List&lt;V1ModifierList&gt; result = apiInstance.ListModifierLists(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.ListModifierLists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list modifier lists for. | 

### Return type

[**List<V1ModifierList>**](V1ModifierList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpages"></a>
# **ListPages**
**Note: This endpoint is deprecated.**
> List<V1Page> ListPages (string locationId)

ListPages

Lists all Favorites pages (in Square Point of Sale) for a given location.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListPagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list Favorites pages for.

            try
            {
                // ListPages
                List&lt;V1Page&gt; result = apiInstance.ListPages(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.ListPages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the location to list Favorites pages for. | 

### Return type

[**List<V1Page>**](V1Page.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removefee"></a>
# **RemoveFee**
**Note: This endpoint is deprecated.**
> V1Item RemoveFee (string locationId, string itemId, string feeId)

RemoveFee

Removes a fee assocation from an item so the fee is no longer automatically applied to the item in Square Point of Sale.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RemoveFeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the fee's associated location.
            var itemId = itemId_example;  // string | The ID of the item to add the fee to.
            var feeId = feeId_example;  // string | The ID of the fee to apply.

            try
            {
                // RemoveFee
                V1Item result = apiInstance.RemoveFee(locationId, itemId, feeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.RemoveFee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the fee&#39;s associated location. | 
 **itemId** | **string**| The ID of the item to add the fee to. | 
 **feeId** | **string**| The ID of the fee to apply. | 

### Return type

[**V1Item**](V1Item.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removemodifierlist"></a>
# **RemoveModifierList**
**Note: This endpoint is deprecated.**
> V1Item RemoveModifierList (string locationId, string modifierListId, string itemId)

RemoveModifierList

Removes a modifier list association from an item so the modifier options from the list can no longer be applied to the item.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RemoveModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to remove.
            var itemId = itemId_example;  // string | The ID of the item to remove the modifier list from.

            try
            {
                // RemoveModifierList
                V1Item result = apiInstance.RemoveModifierList(locationId, modifierListId, itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.RemoveModifierList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **modifierListId** | **string**| The ID of the modifier list to remove. | 
 **itemId** | **string**| The ID of the item to remove the modifier list from. | 

### Return type

[**V1Item**](V1Item.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveitem"></a>
# **RetrieveItem**
**Note: This endpoint is deprecated.**
> V1Item RetrieveItem (string locationId, string itemId)

RetrieveItem

Provides the details for a single item, including associated modifier lists and fees.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The item's ID.

            try
            {
                // RetrieveItem
                V1Item result = apiInstance.RetrieveItem(locationId, itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.RetrieveItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **itemId** | **string**| The item&#39;s ID. | 

### Return type

[**V1Item**](V1Item.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievemodifierlist"></a>
# **RetrieveModifierList**
**Note: This endpoint is deprecated.**
> V1ModifierList RetrieveModifierList (string locationId, string modifierListId)

RetrieveModifierList

Provides the details for a single modifier list.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class RetrieveModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The modifier list's ID.

            try
            {
                // RetrieveModifierList
                V1ModifierList result = apiInstance.RetrieveModifierList(locationId, modifierListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.RetrieveModifierList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **modifierListId** | **string**| The modifier list&#39;s ID. | 

### Return type

[**V1ModifierList**](V1ModifierList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecategory"></a>
# **UpdateCategory**
**Note: This endpoint is deprecated.**
> V1Category UpdateCategory (string locationId, string categoryId, V1Category body)

UpdateCategory

Modifies the details of an existing item category.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the category's associated location.
            var categoryId = categoryId_example;  // string | The ID of the category to edit.
            var body = new V1Category(); // V1Category | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateCategory
                V1Category result = apiInstance.UpdateCategory(locationId, categoryId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.UpdateCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the category&#39;s associated location. | 
 **categoryId** | **string**| The ID of the category to edit. | 
 **body** | [**V1Category**](V1Category.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Category**](V1Category.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatediscount"></a>
# **UpdateDiscount**
**Note: This endpoint is deprecated.**
> V1Discount UpdateDiscount (string locationId, string discountId, V1Discount body)

UpdateDiscount

Modifies the details of an existing discount.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateDiscountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the category's associated location.
            var discountId = discountId_example;  // string | The ID of the discount to edit.
            var body = new V1Discount(); // V1Discount | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateDiscount
                V1Discount result = apiInstance.UpdateDiscount(locationId, discountId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.UpdateDiscount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the category&#39;s associated location. | 
 **discountId** | **string**| The ID of the discount to edit. | 
 **body** | [**V1Discount**](V1Discount.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Discount**](V1Discount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefee"></a>
# **UpdateFee**
**Note: This endpoint is deprecated.**
> V1Fee UpdateFee (string locationId, string feeId, V1Fee body)

UpdateFee

Modifies the details of an existing fee (tax).  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateFeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the fee's associated location.
            var feeId = feeId_example;  // string | The ID of the fee to edit.
            var body = new V1Fee(); // V1Fee | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateFee
                V1Fee result = apiInstance.UpdateFee(locationId, feeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.UpdateFee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the fee&#39;s associated location. | 
 **feeId** | **string**| The ID of the fee to edit. | 
 **body** | [**V1Fee**](V1Fee.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Fee**](V1Fee.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitem"></a>
# **UpdateItem**
**Note: This endpoint is deprecated.**
> V1Item UpdateItem (string locationId, string itemId, V1Item body)

UpdateItem

Modifies the core details of an existing item.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The ID of the item to modify.
            var body = new V1Item(); // V1Item | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateItem
                V1Item result = apiInstance.UpdateItem(locationId, itemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.UpdateItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **itemId** | **string**| The ID of the item to modify. | 
 **body** | [**V1Item**](V1Item.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Item**](V1Item.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemodifierlist"></a>
# **UpdateModifierList**
**Note: This endpoint is deprecated.**
> V1ModifierList UpdateModifierList (string locationId, string modifierListId, V1UpdateModifierListRequest body)

UpdateModifierList

Modifies the details of an existing item modifier list.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to edit.
            var body = new V1UpdateModifierListRequest(); // V1UpdateModifierListRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateModifierList
                V1ModifierList result = apiInstance.UpdateModifierList(locationId, modifierListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.UpdateModifierList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **modifierListId** | **string**| The ID of the modifier list to edit. | 
 **body** | [**V1UpdateModifierListRequest**](V1UpdateModifierListRequest.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1ModifierList**](V1ModifierList.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemodifieroption"></a>
# **UpdateModifierOption**
**Note: This endpoint is deprecated.**
> V1ModifierOption UpdateModifierOption (string locationId, string modifierListId, string modifierOptionId, V1ModifierOption body)

UpdateModifierOption

Modifies the details of an existing item modifier option.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateModifierOptionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to edit.
            var modifierOptionId = modifierOptionId_example;  // string | The ID of the modifier list to edit.
            var body = new V1ModifierOption(); // V1ModifierOption | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateModifierOption
                V1ModifierOption result = apiInstance.UpdateModifierOption(locationId, modifierListId, modifierOptionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.UpdateModifierOption: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **modifierListId** | **string**| The ID of the modifier list to edit. | 
 **modifierOptionId** | **string**| The ID of the modifier list to edit. | 
 **body** | [**V1ModifierOption**](V1ModifierOption.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1ModifierOption**](V1ModifierOption.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepage"></a>
# **UpdatePage**
**Note: This endpoint is deprecated.**
> V1Page UpdatePage (string locationId, string pageId, V1Page body)

UpdatePage

Modifies the details of a Favorites page in Square Point of Sale.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdatePageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the Favorites page's associated location
            var pageId = pageId_example;  // string | The ID of the page to modify.
            var body = new V1Page(); // V1Page | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdatePage
                V1Page result = apiInstance.UpdatePage(locationId, pageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.UpdatePage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the Favorites page&#39;s associated location | 
 **pageId** | **string**| The ID of the page to modify. | 
 **body** | [**V1Page**](V1Page.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Page**](V1Page.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepagecell"></a>
# **UpdatePageCell**
**Note: This endpoint is deprecated.**
> V1Page UpdatePageCell (string locationId, string pageId, V1PageCell body)

UpdatePageCell

Modifies a cell of a Favorites page in Square Point of Sale.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdatePageCellExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the Favorites page's associated location.
            var pageId = pageId_example;  // string | The ID of the page the cell belongs to.
            var body = new V1PageCell(); // V1PageCell | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdatePageCell
                V1Page result = apiInstance.UpdatePageCell(locationId, pageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.UpdatePageCell: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the Favorites page&#39;s associated location. | 
 **pageId** | **string**| The ID of the page the cell belongs to. | 
 **body** | [**V1PageCell**](V1PageCell.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Page**](V1Page.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatevariation"></a>
# **UpdateVariation**
**Note: This endpoint is deprecated.**
> V1Variation UpdateVariation (string locationId, string itemId, string variationId, V1Variation body)

UpdateVariation

Modifies the details of an existing item variation.  - --  - __Deprecation date__: 2019-11-20 - [__Retirement date__](/build-basics/api-lifecycle#deprecated): 2020-11-18 - [Migration guide](/migrate-from-v1/guides/v1-items)  - --

### Example
```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class UpdateVariationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The ID of the item to modify.
            var variationId = variationId_example;  // string | The ID of the variation to modify.
            var body = new V1Variation(); // V1Variation | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // UpdateVariation
                V1Variation result = apiInstance.UpdateVariation(locationId, itemId, variationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1ItemsApi.UpdateVariation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | **string**| The ID of the item&#39;s associated location. | 
 **itemId** | **string**| The ID of the item to modify. | 
 **variationId** | **string**| The ID of the variation to modify. | 
 **body** | [**V1Variation**](V1Variation.md)| An object containing the fields to POST for the request.  See the corresponding object definition for field details. | 

### Return type

[**V1Variation**](V1Variation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

