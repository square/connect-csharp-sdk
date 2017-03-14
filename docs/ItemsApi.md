# Square.Connect.Api.ItemsApi

All URIs are relative to *https://connect.squareup.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1AdjustInventory**](ItemsApi.md#v1adjustinventory) | **POST** /v1/{location_id}/inventory/{variation_id} | Adjusts an item variation&#39;s current available inventory.
[**V1ApplyFee**](ItemsApi.md#v1applyfee) | **PUT** /v1/{location_id}/items/{item_id}/fees/{fee_id} | Associates a fee with an item, meaning the fee is automatically applied to the item in Square Register.
[**V1ApplyModifierList**](ItemsApi.md#v1applymodifierlist) | **PUT** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id} | Associates a modifier list with an item, meaning modifier options from the list can be applied to the item.
[**V1CreateCategory**](ItemsApi.md#v1createcategory) | **POST** /v1/{location_id}/categories | Creates an item category.
[**V1CreateDiscount**](ItemsApi.md#v1creatediscount) | **POST** /v1/{location_id}/discounts | Creates a discount.
[**V1CreateFee**](ItemsApi.md#v1createfee) | **POST** /v1/{location_id}/fees | Creates a fee (tax).
[**V1CreateItem**](ItemsApi.md#v1createitem) | **POST** /v1/{location_id}/items | Creates an item and at least one variation for it.
[**V1CreateModifierList**](ItemsApi.md#v1createmodifierlist) | **POST** /v1/{location_id}/modifier-lists | Creates an item modifier list and at least one modifier option for it.
[**V1CreateModifierOption**](ItemsApi.md#v1createmodifieroption) | **POST** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options | Creates an item modifier option and adds it to a modifier list.
[**V1CreatePage**](ItemsApi.md#v1createpage) | **POST** /v1/{location_id}/pages | Creates a Favorites page in Square Register.
[**V1CreateVariation**](ItemsApi.md#v1createvariation) | **POST** /v1/{location_id}/items/{item_id}/variations | Creates an item variation for an existing item.
[**V1DeleteCategory**](ItemsApi.md#v1deletecategory) | **DELETE** /v1/{location_id}/categories/{category_id} | Deletes an existing item category.
[**V1DeleteDiscount**](ItemsApi.md#v1deletediscount) | **DELETE** /v1/{location_id}/discounts/{discount_id} | Deletes an existing discount.
[**V1DeleteFee**](ItemsApi.md#v1deletefee) | **DELETE** /v1/{location_id}/fees/{fee_id} | Deletes an existing fee (tax).
[**V1DeleteItem**](ItemsApi.md#v1deleteitem) | **DELETE** /v1/{location_id}/items/{item_id} | Deletes an existing item and all item variations associated with it.
[**V1DeleteModifierList**](ItemsApi.md#v1deletemodifierlist) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id} | Deletes an existing item modifier list and all modifier options associated with it.
[**V1DeleteModifierOption**](ItemsApi.md#v1deletemodifieroption) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id} | Deletes an existing item modifier option from a modifier list.
[**V1DeletePage**](ItemsApi.md#v1deletepage) | **DELETE** /v1/{location_id}/pages/{page_id} | Deletes an existing Favorites page and all of its cells.
[**V1DeletePageCell**](ItemsApi.md#v1deletepagecell) | **DELETE** /v1/{location_id}/pages/{page_id}/cells | Deletes a cell from a Favorites page in Square Register.
[**V1DeleteVariation**](ItemsApi.md#v1deletevariation) | **DELETE** /v1/{location_id}/items/{item_id}/variations/{variation_id} | Deletes an existing item variation from an item.
[**V1ListCategories**](ItemsApi.md#v1listcategories) | **GET** /v1/{location_id}/categories | Lists all of a location&#39;s item categories.
[**V1ListDiscounts**](ItemsApi.md#v1listdiscounts) | **GET** /v1/{location_id}/discounts | Lists all of a location&#39;s discounts.
[**V1ListFees**](ItemsApi.md#v1listfees) | **GET** /v1/{location_id}/fees | Lists all of a location&#39;s fees (taxes).
[**V1ListInventory**](ItemsApi.md#v1listinventory) | **GET** /v1/{location_id}/inventory | Provides inventory information for all of a merchant&#39;s inventory-enabled item variations.
[**V1ListItems**](ItemsApi.md#v1listitems) | **GET** /v1/{location_id}/items | Provides summary information for all of a location&#39;s items.
[**V1ListModifierLists**](ItemsApi.md#v1listmodifierlists) | **GET** /v1/{location_id}/modifier-lists | Lists all of a location&#39;s modifier lists.
[**V1ListPages**](ItemsApi.md#v1listpages) | **GET** /v1/{location_id}/pages | Lists all of a location&#39;s Favorites pages in Square Register.
[**V1RemoveFee**](ItemsApi.md#v1removefee) | **DELETE** /v1/{location_id}/items/{item_id}/fees/{fee_id} | Removes a fee assocation from an item, meaning the fee is no longer automatically applied to the item in Square Register.
[**V1RemoveModifierList**](ItemsApi.md#v1removemodifierlist) | **DELETE** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id} | Removes a modifier list association from an item, meaning modifier options from the list can no longer be applied to the item.
[**V1RetrieveItem**](ItemsApi.md#v1retrieveitem) | **GET** /v1/{location_id}/items/{item_id} | Provides the details for a single item, including associated modifier lists and fees.
[**V1RetrieveModifierList**](ItemsApi.md#v1retrievemodifierlist) | **GET** /v1/{location_id}/modifier-lists/{modifier_list_id} | Provides the details for a single modifier list.
[**V1UpdateCategory**](ItemsApi.md#v1updatecategory) | **PUT** /v1/{location_id}/categories/{category_id} | Modifies the details of an existing item category.
[**V1UpdateDiscount**](ItemsApi.md#v1updatediscount) | **PUT** /v1/{location_id}/discounts/{discount_id} | Modifies the details of an existing discount.
[**V1UpdateFee**](ItemsApi.md#v1updatefee) | **PUT** /v1/{location_id}/fees/{fee_id} | Modifies the details of an existing fee (tax).
[**V1UpdateItem**](ItemsApi.md#v1updateitem) | **PUT** /v1/{location_id}/items/{item_id} | Modifies the core details of an existing item.
[**V1UpdateModifierList**](ItemsApi.md#v1updatemodifierlist) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id} | Modifies the details of an existing item modifier list.
[**V1UpdateModifierOption**](ItemsApi.md#v1updatemodifieroption) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id} | Modifies the details of an existing item modifier option.
[**V1UpdatePage**](ItemsApi.md#v1updatepage) | **PUT** /v1/{location_id}/pages/{page_id} | Modifies the details of a Favorites page in Square Register.
[**V1UpdatePageCell**](ItemsApi.md#v1updatepagecell) | **PUT** /v1/{location_id}/pages/{page_id}/cells | Modifies a cell of a Favorites page in Square Register.
[**V1UpdateVariation**](ItemsApi.md#v1updatevariation) | **PUT** /v1/{location_id}/items/{item_id}/variations/{variation_id} | Modifies the details of an existing item variation.


<a name="v1adjustinventory"></a>
# **V1AdjustInventory**
> V1InventoryEntry V1AdjustInventory (string locationId, string variationId, V1AdjustInventoryRequest body)

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
    public class V1AdjustInventoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var variationId = variationId_example;  // string | The ID of the variation to adjust inventory information for.
            var body = new V1AdjustInventoryRequest(); // V1AdjustInventoryRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Adjusts an item variation's current available inventory.
                V1InventoryEntry result = apiInstance.V1AdjustInventory(locationId, variationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1AdjustInventory: " + e.Message );
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

<a name="v1applyfee"></a>
# **V1ApplyFee**
> V1Item V1ApplyFee (string locationId, string itemId, string feeId)

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
    public class V1ApplyFeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the fee's associated location.
            var itemId = itemId_example;  // string | The ID of the item to add the fee to.
            var feeId = feeId_example;  // string | The ID of the fee to apply.

            try
            {
                // Associates a fee with an item, meaning the fee is automatically applied to the item in Square Register.
                V1Item result = apiInstance.V1ApplyFee(locationId, itemId, feeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1ApplyFee: " + e.Message );
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

<a name="v1applymodifierlist"></a>
# **V1ApplyModifierList**
> V1Item V1ApplyModifierList (string locationId, string modifierListId, string itemId)

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
    public class V1ApplyModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to apply.
            var itemId = itemId_example;  // string | The ID of the item to add the modifier list to.

            try
            {
                // Associates a modifier list with an item, meaning modifier options from the list can be applied to the item.
                V1Item result = apiInstance.V1ApplyModifierList(locationId, modifierListId, itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1ApplyModifierList: " + e.Message );
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

<a name="v1createcategory"></a>
# **V1CreateCategory**
> V1Category V1CreateCategory (string locationId, V1Category body)

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
    public class V1CreateCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create an item for.
            var body = new V1Category(); // V1Category | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates an item category.
                V1Category result = apiInstance.V1CreateCategory(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1CreateCategory: " + e.Message );
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

<a name="v1creatediscount"></a>
# **V1CreateDiscount**
> V1Discount V1CreateDiscount (string locationId, V1Discount body)

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
    public class V1CreateDiscountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create an item for.
            var body = new V1Discount(); // V1Discount | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates a discount.
                V1Discount result = apiInstance.V1CreateDiscount(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1CreateDiscount: " + e.Message );
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

<a name="v1createfee"></a>
# **V1CreateFee**
> V1Fee V1CreateFee (string locationId, V1Fee body)

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
    public class V1CreateFeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create a fee for.
            var body = new V1Fee(); // V1Fee | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates a fee (tax).
                V1Fee result = apiInstance.V1CreateFee(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1CreateFee: " + e.Message );
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

<a name="v1createitem"></a>
# **V1CreateItem**
> V1Item V1CreateItem (string locationId, V1Item body)

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
    public class V1CreateItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create an item for.
            var body = new V1Item(); // V1Item | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates an item and at least one variation for it.
                V1Item result = apiInstance.V1CreateItem(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1CreateItem: " + e.Message );
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

<a name="v1createmodifierlist"></a>
# **V1CreateModifierList**
> V1ModifierList V1CreateModifierList (string locationId, V1ModifierList body)

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
    public class V1CreateModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create a modifier list for.
            var body = new V1ModifierList(); // V1ModifierList | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates an item modifier list and at least one modifier option for it.
                V1ModifierList result = apiInstance.V1CreateModifierList(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1CreateModifierList: " + e.Message );
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

<a name="v1createmodifieroption"></a>
# **V1CreateModifierOption**
> V1ModifierOption V1CreateModifierOption (string locationId, string modifierListId, V1ModifierOption body)

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
    public class V1CreateModifierOptionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to edit.
            var body = new V1ModifierOption(); // V1ModifierOption | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates an item modifier option and adds it to a modifier list.
                V1ModifierOption result = apiInstance.V1CreateModifierOption(locationId, modifierListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1CreateModifierOption: " + e.Message );
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

<a name="v1createpage"></a>
# **V1CreatePage**
> V1Page V1CreatePage (string locationId, V1Page body)

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
    public class V1CreatePageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to create an item for.
            var body = new V1Page(); // V1Page | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates a Favorites page in Square Register.
                V1Page result = apiInstance.V1CreatePage(locationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1CreatePage: " + e.Message );
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

<a name="v1createvariation"></a>
# **V1CreateVariation**
> V1Variation V1CreateVariation (string locationId, string itemId, V1Variation body)

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
    public class V1CreateVariationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The item's ID.
            var body = new V1Variation(); // V1Variation | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Creates an item variation for an existing item.
                V1Variation result = apiInstance.V1CreateVariation(locationId, itemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1CreateVariation: " + e.Message );
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

<a name="v1deletecategory"></a>
# **V1DeleteCategory**
> V1Category V1DeleteCategory (string locationId, string categoryId)

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
    public class V1DeleteCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var categoryId = categoryId_example;  // string | The ID of the category to delete.

            try
            {
                // Deletes an existing item category.
                V1Category result = apiInstance.V1DeleteCategory(locationId, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1DeleteCategory: " + e.Message );
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

<a name="v1deletediscount"></a>
# **V1DeleteDiscount**
> V1Discount V1DeleteDiscount (string locationId, string discountId)

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
    public class V1DeleteDiscountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var discountId = discountId_example;  // string | The ID of the discount to delete.

            try
            {
                // Deletes an existing discount.
                V1Discount result = apiInstance.V1DeleteDiscount(locationId, discountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1DeleteDiscount: " + e.Message );
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

<a name="v1deletefee"></a>
# **V1DeleteFee**
> V1Fee V1DeleteFee (string locationId, string feeId)

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
    public class V1DeleteFeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the fee's associated location.
            var feeId = feeId_example;  // string | The ID of the fee to delete.

            try
            {
                // Deletes an existing fee (tax).
                V1Fee result = apiInstance.V1DeleteFee(locationId, feeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1DeleteFee: " + e.Message );
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

<a name="v1deleteitem"></a>
# **V1DeleteItem**
> V1Item V1DeleteItem (string locationId, string itemId)

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
    public class V1DeleteItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The ID of the item to modify.

            try
            {
                // Deletes an existing item and all item variations associated with it.
                V1Item result = apiInstance.V1DeleteItem(locationId, itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1DeleteItem: " + e.Message );
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

<a name="v1deletemodifierlist"></a>
# **V1DeleteModifierList**
> V1ModifierList V1DeleteModifierList (string locationId, string modifierListId)

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
    public class V1DeleteModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to delete.

            try
            {
                // Deletes an existing item modifier list and all modifier options associated with it.
                V1ModifierList result = apiInstance.V1DeleteModifierList(locationId, modifierListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1DeleteModifierList: " + e.Message );
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

<a name="v1deletemodifieroption"></a>
# **V1DeleteModifierOption**
> V1ModifierOption V1DeleteModifierOption (string locationId, string modifierListId, string modifierOptionId)

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
    public class V1DeleteModifierOptionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to delete.
            var modifierOptionId = modifierOptionId_example;  // string | The ID of the modifier list to edit.

            try
            {
                // Deletes an existing item modifier option from a modifier list.
                V1ModifierOption result = apiInstance.V1DeleteModifierOption(locationId, modifierListId, modifierOptionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1DeleteModifierOption: " + e.Message );
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

<a name="v1deletepage"></a>
# **V1DeletePage**
> V1Page V1DeletePage (string locationId, string pageId)

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
    public class V1DeletePageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the Favorites page's associated location.
            var pageId = pageId_example;  // string | The ID of the page to delete.

            try
            {
                // Deletes an existing Favorites page and all of its cells.
                V1Page result = apiInstance.V1DeletePage(locationId, pageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1DeletePage: " + e.Message );
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

<a name="v1deletepagecell"></a>
# **V1DeletePageCell**
> V1Page V1DeletePageCell (string locationId, string pageId, string row = null, string column = null)

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
    public class V1DeletePageCellExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the Favorites page's associated location.
            var pageId = pageId_example;  // string | The ID of the page to delete.
            var row = row_example;  // string | The row of the cell to clear. Always an integer between 0 and 4, inclusive. Row 0 is the top row. (optional) 
            var column = column_example;  // string | The column of the cell to clear. Always an integer between 0 and 4, inclusive. Column 0 is the leftmost column. (optional) 

            try
            {
                // Deletes a cell from a Favorites page in Square Register.
                V1Page result = apiInstance.V1DeletePageCell(locationId, pageId, row, column);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1DeletePageCell: " + e.Message );
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

<a name="v1deletevariation"></a>
# **V1DeleteVariation**
> V1Variation V1DeleteVariation (string locationId, string itemId, string variationId)

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
    public class V1DeleteVariationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The ID of the item to delete.
            var variationId = variationId_example;  // string | The ID of the variation to delete.

            try
            {
                // Deletes an existing item variation from an item.
                V1Variation result = apiInstance.V1DeleteVariation(locationId, itemId, variationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1DeleteVariation: " + e.Message );
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

<a name="v1listcategories"></a>
# **V1ListCategories**
> List<V1Category> V1ListCategories (string locationId)

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
    public class V1ListCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list categories for.

            try
            {
                // Lists all of a location's item categories.
                List&lt;V1Category&gt; result = apiInstance.V1ListCategories(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1ListCategories: " + e.Message );
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

<a name="v1listdiscounts"></a>
# **V1ListDiscounts**
> List<V1Discount> V1ListDiscounts (string locationId)

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
    public class V1ListDiscountsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list categories for.

            try
            {
                // Lists all of a location's discounts.
                List&lt;V1Discount&gt; result = apiInstance.V1ListDiscounts(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1ListDiscounts: " + e.Message );
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

<a name="v1listfees"></a>
# **V1ListFees**
> List<V1Fee> V1ListFees (string locationId)

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
    public class V1ListFeesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list fees for.

            try
            {
                // Lists all of a location's fees (taxes).
                List&lt;V1Fee&gt; result = apiInstance.V1ListFees(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1ListFees: " + e.Message );
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

<a name="v1listinventory"></a>
# **V1ListInventory**
> List<V1InventoryEntry> V1ListInventory (string locationId, int? limit = null)

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
    public class V1ListInventoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var limit = 56;  // int? | The maximum number of inventory entries to return in a single response. This value cannot exceed 1000. (optional) 

            try
            {
                // Provides inventory information for all of a merchant's inventory-enabled item variations.
                List&lt;V1InventoryEntry&gt; result = apiInstance.V1ListInventory(locationId, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1ListInventory: " + e.Message );
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

<a name="v1listitems"></a>
# **V1ListItems**
> List<V1Item> V1ListItems (string locationId)

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
    public class V1ListItemsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list items for.

            try
            {
                // Provides summary information for all of a location's items.
                List&lt;V1Item&gt; result = apiInstance.V1ListItems(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1ListItems: " + e.Message );
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

<a name="v1listmodifierlists"></a>
# **V1ListModifierLists**
> List<V1ModifierList> V1ListModifierLists (string locationId)

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
    public class V1ListModifierListsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list modifier lists for.

            try
            {
                // Lists all of a location's modifier lists.
                List&lt;V1ModifierList&gt; result = apiInstance.V1ListModifierLists(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1ListModifierLists: " + e.Message );
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

<a name="v1listpages"></a>
# **V1ListPages**
> List<V1Page> V1ListPages (string locationId)

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
    public class V1ListPagesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the location to list Favorites pages for.

            try
            {
                // Lists all of a location's Favorites pages in Square Register.
                List&lt;V1Page&gt; result = apiInstance.V1ListPages(locationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1ListPages: " + e.Message );
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

<a name="v1removefee"></a>
# **V1RemoveFee**
> V1Item V1RemoveFee (string locationId, string itemId, string feeId)

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
    public class V1RemoveFeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the fee's associated location.
            var itemId = itemId_example;  // string | The ID of the item to add the fee to.
            var feeId = feeId_example;  // string | The ID of the fee to apply.

            try
            {
                // Removes a fee assocation from an item, meaning the fee is no longer automatically applied to the item in Square Register.
                V1Item result = apiInstance.V1RemoveFee(locationId, itemId, feeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1RemoveFee: " + e.Message );
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

<a name="v1removemodifierlist"></a>
# **V1RemoveModifierList**
> V1Item V1RemoveModifierList (string locationId, string modifierListId, string itemId)

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
    public class V1RemoveModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to remove.
            var itemId = itemId_example;  // string | The ID of the item to remove the modifier list from.

            try
            {
                // Removes a modifier list association from an item, meaning modifier options from the list can no longer be applied to the item.
                V1Item result = apiInstance.V1RemoveModifierList(locationId, modifierListId, itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1RemoveModifierList: " + e.Message );
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

<a name="v1retrieveitem"></a>
# **V1RetrieveItem**
> V1Item V1RetrieveItem (string locationId, string itemId)

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
    public class V1RetrieveItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The item's ID.

            try
            {
                // Provides the details for a single item, including associated modifier lists and fees.
                V1Item result = apiInstance.V1RetrieveItem(locationId, itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1RetrieveItem: " + e.Message );
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

<a name="v1retrievemodifierlist"></a>
# **V1RetrieveModifierList**
> V1ModifierList V1RetrieveModifierList (string locationId, string modifierListId)

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
    public class V1RetrieveModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The modifier list's ID.

            try
            {
                // Provides the details for a single modifier list.
                V1ModifierList result = apiInstance.V1RetrieveModifierList(locationId, modifierListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1RetrieveModifierList: " + e.Message );
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

<a name="v1updatecategory"></a>
# **V1UpdateCategory**
> V1Category V1UpdateCategory (string locationId, string categoryId, V1Category body)

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
    public class V1UpdateCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the category's associated location.
            var categoryId = categoryId_example;  // string | The ID of the category to edit.
            var body = new V1Category(); // V1Category | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies the details of an existing item category.
                V1Category result = apiInstance.V1UpdateCategory(locationId, categoryId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1UpdateCategory: " + e.Message );
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

<a name="v1updatediscount"></a>
# **V1UpdateDiscount**
> V1Discount V1UpdateDiscount (string locationId, string discountId, V1Discount body)

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
    public class V1UpdateDiscountExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the category's associated location.
            var discountId = discountId_example;  // string | The ID of the discount to edit.
            var body = new V1Discount(); // V1Discount | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies the details of an existing discount.
                V1Discount result = apiInstance.V1UpdateDiscount(locationId, discountId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1UpdateDiscount: " + e.Message );
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

<a name="v1updatefee"></a>
# **V1UpdateFee**
> V1Fee V1UpdateFee (string locationId, string feeId, V1Fee body)

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
    public class V1UpdateFeeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the fee's associated location.
            var feeId = feeId_example;  // string | The ID of the fee to edit.
            var body = new V1Fee(); // V1Fee | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies the details of an existing fee (tax).
                V1Fee result = apiInstance.V1UpdateFee(locationId, feeId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1UpdateFee: " + e.Message );
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

<a name="v1updateitem"></a>
# **V1UpdateItem**
> V1Item V1UpdateItem (string locationId, string itemId, V1Item body)

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
    public class V1UpdateItemExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The ID of the item to modify.
            var body = new V1Item(); // V1Item | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies the core details of an existing item.
                V1Item result = apiInstance.V1UpdateItem(locationId, itemId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1UpdateItem: " + e.Message );
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

<a name="v1updatemodifierlist"></a>
# **V1UpdateModifierList**
> V1ModifierList V1UpdateModifierList (string locationId, string modifierListId, V1UpdateModifierListRequest body)

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
    public class V1UpdateModifierListExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to edit.
            var body = new V1UpdateModifierListRequest(); // V1UpdateModifierListRequest | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies the details of an existing item modifier list.
                V1ModifierList result = apiInstance.V1UpdateModifierList(locationId, modifierListId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1UpdateModifierList: " + e.Message );
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

<a name="v1updatemodifieroption"></a>
# **V1UpdateModifierOption**
> V1ModifierOption V1UpdateModifierOption (string locationId, string modifierListId, string modifierOptionId, V1ModifierOption body)

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
    public class V1UpdateModifierOptionExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var modifierListId = modifierListId_example;  // string | The ID of the modifier list to edit.
            var modifierOptionId = modifierOptionId_example;  // string | The ID of the modifier list to edit.
            var body = new V1ModifierOption(); // V1ModifierOption | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies the details of an existing item modifier option.
                V1ModifierOption result = apiInstance.V1UpdateModifierOption(locationId, modifierListId, modifierOptionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1UpdateModifierOption: " + e.Message );
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

<a name="v1updatepage"></a>
# **V1UpdatePage**
> V1Page V1UpdatePage (string locationId, string pageId, V1Page body)

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
    public class V1UpdatePageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the Favorites page's associated location
            var pageId = pageId_example;  // string | The ID of the page to modify.
            var body = new V1Page(); // V1Page | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies the details of a Favorites page in Square Register.
                V1Page result = apiInstance.V1UpdatePage(locationId, pageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1UpdatePage: " + e.Message );
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

<a name="v1updatepagecell"></a>
# **V1UpdatePageCell**
> V1Page V1UpdatePageCell (string locationId, string pageId, V1PageCell body)

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
    public class V1UpdatePageCellExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the Favorites page's associated location.
            var pageId = pageId_example;  // string | The ID of the page the cell belongs to.
            var body = new V1PageCell(); // V1PageCell | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies a cell of a Favorites page in Square Register.
                V1Page result = apiInstance.V1UpdatePageCell(locationId, pageId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1UpdatePageCell: " + e.Message );
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

<a name="v1updatevariation"></a>
# **V1UpdateVariation**
> V1Variation V1UpdateVariation (string locationId, string itemId, string variationId, V1Variation body)

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
    public class V1UpdateVariationExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ItemsApi();
            var locationId = locationId_example;  // string | The ID of the item's associated location.
            var itemId = itemId_example;  // string | The ID of the item to modify.
            var variationId = variationId_example;  // string | The ID of the variation to modify.
            var body = new V1Variation(); // V1Variation | An object containing the fields to POST for the request.  See the corresponding object definition for field details.

            try
            {
                // Modifies the details of an existing item variation.
                V1Variation result = apiInstance.V1UpdateVariation(locationId, itemId, variationId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ItemsApi.V1UpdateVariation: " + e.Message );
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

