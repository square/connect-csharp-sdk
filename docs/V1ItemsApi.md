# Square.Connect.Api.V1ItemsApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdjustInventory**](V1ItemsApi.md#adjustinventory) | **POST** /v1/{location_id}/inventory/{variation_id} | Adjusts an item variation&#39;s current available inventory.
[**ApplyFee**](V1ItemsApi.md#applyfee) | **PUT** /v1/{location_id}/items/{item_id}/fees/{fee_id} | Associates a fee with an item, meaning the fee is automatically applied to the item in Square Register.
[**ApplyModifierList**](V1ItemsApi.md#applymodifierlist) | **PUT** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id} | Associates a modifier list with an item, meaning modifier options from the list can be applied to the item.
[**CreateCategory**](V1ItemsApi.md#createcategory) | **POST** /v1/{location_id}/categories | Creates an item category.
[**CreateDiscount**](V1ItemsApi.md#creatediscount) | **POST** /v1/{location_id}/discounts | Creates a discount.
[**CreateFee**](V1ItemsApi.md#createfee) | **POST** /v1/{location_id}/fees | Creates a fee (tax).
[**CreateItem**](V1ItemsApi.md#createitem) | **POST** /v1/{location_id}/items | Creates an item and at least one variation for it.
[**CreateModifierList**](V1ItemsApi.md#createmodifierlist) | **POST** /v1/{location_id}/modifier-lists | Creates an item modifier list and at least one modifier option for it.
[**CreateModifierOption**](V1ItemsApi.md#createmodifieroption) | **POST** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options | Creates an item modifier option and adds it to a modifier list.
[**CreatePage**](V1ItemsApi.md#createpage) | **POST** /v1/{location_id}/pages | Creates a Favorites page in Square Register.
[**CreateVariation**](V1ItemsApi.md#createvariation) | **POST** /v1/{location_id}/items/{item_id}/variations | Creates an item variation for an existing item.
[**DeleteCategory**](V1ItemsApi.md#deletecategory) | **DELETE** /v1/{location_id}/categories/{category_id} | Deletes an existing item category.
[**DeleteDiscount**](V1ItemsApi.md#deletediscount) | **DELETE** /v1/{location_id}/discounts/{discount_id} | Deletes an existing discount.
[**DeleteFee**](V1ItemsApi.md#deletefee) | **DELETE** /v1/{location_id}/fees/{fee_id} | Deletes an existing fee (tax).
[**DeleteItem**](V1ItemsApi.md#deleteitem) | **DELETE** /v1/{location_id}/items/{item_id} | Deletes an existing item and all item variations associated with it.
[**DeleteModifierList**](V1ItemsApi.md#deletemodifierlist) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id} | Deletes an existing item modifier list and all modifier options associated with it.
[**DeleteModifierOption**](V1ItemsApi.md#deletemodifieroption) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id} | Deletes an existing item modifier option from a modifier list.
[**DeletePage**](V1ItemsApi.md#deletepage) | **DELETE** /v1/{location_id}/pages/{page_id} | Deletes an existing Favorites page and all of its cells.
[**DeletePageCell**](V1ItemsApi.md#deletepagecell) | **DELETE** /v1/{location_id}/pages/{page_id}/cells | Deletes a cell from a Favorites page in Square Register.
[**DeleteVariation**](V1ItemsApi.md#deletevariation) | **DELETE** /v1/{location_id}/items/{item_id}/variations/{variation_id} | Deletes an existing item variation from an item.
[**ListCategories**](V1ItemsApi.md#listcategories) | **GET** /v1/{location_id}/categories | Lists all of a location&#39;s item categories.
[**ListDiscounts**](V1ItemsApi.md#listdiscounts) | **GET** /v1/{location_id}/discounts | Lists all of a location&#39;s discounts.
[**ListFees**](V1ItemsApi.md#listfees) | **GET** /v1/{location_id}/fees | Lists all of a location&#39;s fees (taxes).
[**ListInventory**](V1ItemsApi.md#listinventory) | **GET** /v1/{location_id}/inventory | Provides inventory information for all of a merchant&#39;s inventory-enabled item variations.
[**ListItems**](V1ItemsApi.md#listitems) | **GET** /v1/{location_id}/items | Provides summary information for all of a location&#39;s items.
[**ListModifierLists**](V1ItemsApi.md#listmodifierlists) | **GET** /v1/{location_id}/modifier-lists | Lists all of a location&#39;s modifier lists.
[**ListPages**](V1ItemsApi.md#listpages) | **GET** /v1/{location_id}/pages | Lists all of a location&#39;s Favorites pages in Square Register.
[**RemoveFee**](V1ItemsApi.md#removefee) | **DELETE** /v1/{location_id}/items/{item_id}/fees/{fee_id} | Removes a fee assocation from an item, meaning the fee is no longer automatically applied to the item in Square Register.
[**RemoveModifierList**](V1ItemsApi.md#removemodifierlist) | **DELETE** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id} | Removes a modifier list association from an item, meaning modifier options from the list can no longer be applied to the item.
[**RetrieveItem**](V1ItemsApi.md#retrieveitem) | **GET** /v1/{location_id}/items/{item_id} | Provides the details for a single item, including associated modifier lists and fees.
[**RetrieveModifierList**](V1ItemsApi.md#retrievemodifierlist) | **GET** /v1/{location_id}/modifier-lists/{modifier_list_id} | Provides the details for a single modifier list.
[**UpdateCategory**](V1ItemsApi.md#updatecategory) | **PUT** /v1/{location_id}/categories/{category_id} | Modifies the details of an existing item category.
[**UpdateDiscount**](V1ItemsApi.md#updatediscount) | **PUT** /v1/{location_id}/discounts/{discount_id} | Modifies the details of an existing discount.
[**UpdateFee**](V1ItemsApi.md#updatefee) | **PUT** /v1/{location_id}/fees/{fee_id} | Modifies the details of an existing fee (tax).
[**UpdateItem**](V1ItemsApi.md#updateitem) | **PUT** /v1/{location_id}/items/{item_id} | Modifies the core details of an existing item.
[**UpdateModifierList**](V1ItemsApi.md#updatemodifierlist) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id} | Modifies the details of an existing item modifier list.
[**UpdateModifierOption**](V1ItemsApi.md#updatemodifieroption) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id} | Modifies the details of an existing item modifier option.
[**UpdatePage**](V1ItemsApi.md#updatepage) | **PUT** /v1/{location_id}/pages/{page_id} | Modifies the details of a Favorites page in Square Register.
[**UpdatePageCell**](V1ItemsApi.md#updatepagecell) | **PUT** /v1/{location_id}/pages/{page_id}/cells | Modifies a cell of a Favorites page in Square Register.
[**UpdateVariation**](V1ItemsApi.md#updatevariation) | **PUT** /v1/{location_id}/items/{item_id}/variations/{variation_id} | Modifies the details of an existing item variation.


<a name="adjustinventory"></a>
# **AdjustInventory**
> V1InventoryEntry AdjustInventory (string locationId, string variationId, V1AdjustInventoryRequest body)

Adjusts an item variation's current available inventory.

Adjusts an item variation's current available inventory.

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
                // Adjusts an item variation's current available inventory.
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
> V1Item ApplyFee (string locationId, string itemId, string feeId)

Associates a fee with an item, meaning the fee is automatically applied to the item in Square Register.

Associates a fee with an item, meaning the fee is automatically applied to the item in Square Register.

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
                // Associates a fee with an item, meaning the fee is automatically applied to the item in Square Register.
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
> V1Item ApplyModifierList (string locationId, string modifierListId, string itemId)

Associates a modifier list with an item, meaning modifier options from the list can be applied to the item.

Associates a modifier list with an item, meaning modifier options from the list can be applied to the item.

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
                // Associates a modifier list with an item, meaning modifier options from the list can be applied to the item.
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
> V1Category CreateCategory (string locationId, V1Category body)

Creates an item category.

Creates an item category.

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
                // Creates an item category.
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
> V1Discount CreateDiscount (string locationId, V1Discount body)

Creates a discount.

Creates a discount.

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
                // Creates a discount.
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
> V1Fee CreateFee (string locationId, V1Fee body)

Creates a fee (tax).

Creates a fee (tax).

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
                // Creates a fee (tax).
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
> V1Item CreateItem (string locationId, V1Item body)

Creates an item and at least one variation for it.

Creates an item and at least one variation for it.

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
                // Creates an item and at least one variation for it.
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
> V1ModifierList CreateModifierList (string locationId, V1ModifierList body)

Creates an item modifier list and at least one modifier option for it.

Creates an item modifier list and at least one modifier option for it.

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
                // Creates an item modifier list and at least one modifier option for it.
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
> V1ModifierOption CreateModifierOption (string locationId, string modifierListId, V1ModifierOption body)

Creates an item modifier option and adds it to a modifier list.

Creates an item modifier option and adds it to a modifier list.

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
                // Creates an item modifier option and adds it to a modifier list.
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
> V1Page CreatePage (string locationId, V1Page body)

Creates a Favorites page in Square Register.

Creates a Favorites page in Square Register.

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
                // Creates a Favorites page in Square Register.
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
> V1Variation CreateVariation (string locationId, string itemId, V1Variation body)

Creates an item variation for an existing item.

Creates an item variation for an existing item.

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
                // Creates an item variation for an existing item.
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
> V1Category DeleteCategory (string locationId, string categoryId)

Deletes an existing item category.

Deletes an existing item category.

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
                // Deletes an existing item category.
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
> V1Discount DeleteDiscount (string locationId, string discountId)

Deletes an existing discount.

Deletes an existing discount.

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
                // Deletes an existing discount.
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
> V1Fee DeleteFee (string locationId, string feeId)

Deletes an existing fee (tax).

Deletes an existing fee (tax).

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
                // Deletes an existing fee (tax).
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
> V1Item DeleteItem (string locationId, string itemId)

Deletes an existing item and all item variations associated with it.

Deletes an existing item and all item variations associated with it.

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
                // Deletes an existing item and all item variations associated with it.
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
> V1ModifierList DeleteModifierList (string locationId, string modifierListId)

Deletes an existing item modifier list and all modifier options associated with it.

Deletes an existing item modifier list and all modifier options associated with it.

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
                // Deletes an existing item modifier list and all modifier options associated with it.
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
> V1ModifierOption DeleteModifierOption (string locationId, string modifierListId, string modifierOptionId)

Deletes an existing item modifier option from a modifier list.

Deletes an existing item modifier option from a modifier list.

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
                // Deletes an existing item modifier option from a modifier list.
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
> V1Page DeletePage (string locationId, string pageId)

Deletes an existing Favorites page and all of its cells.

Deletes an existing Favorites page and all of its cells.

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
                // Deletes an existing Favorites page and all of its cells.
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
> V1Page DeletePageCell (string locationId, string pageId, string row = null, string column = null)

Deletes a cell from a Favorites page in Square Register.

Deletes a cell from a Favorites page in Square Register.

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
                // Deletes a cell from a Favorites page in Square Register.
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
> V1Variation DeleteVariation (string locationId, string itemId, string variationId)

Deletes an existing item variation from an item.

Deletes an existing item variation from an item.

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
                // Deletes an existing item variation from an item.
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
> List<V1Category> ListCategories (string locationId)

Lists all of a location's item categories.

Lists all of a location's item categories.

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
                // Lists all of a location's item categories.
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
> List<V1Discount> ListDiscounts (string locationId)

Lists all of a location's discounts.

Lists all of a location's discounts.

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
                // Lists all of a location's discounts.
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
> List<V1Fee> ListFees (string locationId)

Lists all of a location's fees (taxes).

Lists all of a location's fees (taxes).

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
                // Lists all of a location's fees (taxes).
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
> List<V1InventoryEntry> ListInventory (string locationId, int? limit = null)

Provides inventory information for all of a merchant's inventory-enabled item variations.

Provides inventory information for all of a merchant's inventory-enabled item variations.

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

            try
            {
                // Provides inventory information for all of a merchant's inventory-enabled item variations.
                List&lt;V1InventoryEntry&gt; result = apiInstance.ListInventory(locationId, limit);
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
> List<V1Item> ListItems (string locationId)

Provides summary information for all of a location's items.

Provides summary information for all of a location's items.

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

            try
            {
                // Provides summary information for all of a location's items.
                List&lt;V1Item&gt; result = apiInstance.ListItems(locationId);
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
> List<V1ModifierList> ListModifierLists (string locationId)

Lists all of a location's modifier lists.

Lists all of a location's modifier lists.

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
                // Lists all of a location's modifier lists.
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
> List<V1Page> ListPages (string locationId)

Lists all of a location's Favorites pages in Square Register.

Lists all of a location's Favorites pages in Square Register.

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
                // Lists all of a location's Favorites pages in Square Register.
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
> V1Item RemoveFee (string locationId, string itemId, string feeId)

Removes a fee assocation from an item, meaning the fee is no longer automatically applied to the item in Square Register.

Removes a fee assocation from an item, meaning the fee is no longer automatically applied to the item in Square Register.

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
                // Removes a fee assocation from an item, meaning the fee is no longer automatically applied to the item in Square Register.
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
> V1Item RemoveModifierList (string locationId, string modifierListId, string itemId)

Removes a modifier list association from an item, meaning modifier options from the list can no longer be applied to the item.

Removes a modifier list association from an item, meaning modifier options from the list can no longer be applied to the item.

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
                // Removes a modifier list association from an item, meaning modifier options from the list can no longer be applied to the item.
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
> V1Item RetrieveItem (string locationId, string itemId)

Provides the details for a single item, including associated modifier lists and fees.

Provides the details for a single item, including associated modifier lists and fees.

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
                // Provides the details for a single item, including associated modifier lists and fees.
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
> V1ModifierList RetrieveModifierList (string locationId, string modifierListId)

Provides the details for a single modifier list.

Provides the details for a single modifier list.

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
                // Provides the details for a single modifier list.
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
> V1Category UpdateCategory (string locationId, string categoryId, V1Category body)

Modifies the details of an existing item category.

Modifies the details of an existing item category.

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
                // Modifies the details of an existing item category.
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
> V1Discount UpdateDiscount (string locationId, string discountId, V1Discount body)

Modifies the details of an existing discount.

Modifies the details of an existing discount.

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
                // Modifies the details of an existing discount.
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
> V1Fee UpdateFee (string locationId, string feeId, V1Fee body)

Modifies the details of an existing fee (tax).

Modifies the details of an existing fee (tax).

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
                // Modifies the details of an existing fee (tax).
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
> V1Item UpdateItem (string locationId, string itemId, V1Item body)

Modifies the core details of an existing item.

Modifies the core details of an existing item.

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
                // Modifies the core details of an existing item.
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
> V1ModifierList UpdateModifierList (string locationId, string modifierListId, V1UpdateModifierListRequest body)

Modifies the details of an existing item modifier list.

Modifies the details of an existing item modifier list.

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
                // Modifies the details of an existing item modifier list.
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
> V1ModifierOption UpdateModifierOption (string locationId, string modifierListId, string modifierOptionId, V1ModifierOption body)

Modifies the details of an existing item modifier option.

Modifies the details of an existing item modifier option.

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
                // Modifies the details of an existing item modifier option.
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
> V1Page UpdatePage (string locationId, string pageId, V1Page body)

Modifies the details of a Favorites page in Square Register.

Modifies the details of a Favorites page in Square Register.

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
                // Modifies the details of a Favorites page in Square Register.
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
> V1Page UpdatePageCell (string locationId, string pageId, V1PageCell body)

Modifies a cell of a Favorites page in Square Register.

Modifies a cell of a Favorites page in Square Register.

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
                // Modifies a cell of a Favorites page in Square Register.
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
> V1Variation UpdateVariation (string locationId, string itemId, string variationId, V1Variation body)

Modifies the details of an existing item variation.

Modifies the details of an existing item variation.

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
                // Modifies the details of an existing item variation.
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

