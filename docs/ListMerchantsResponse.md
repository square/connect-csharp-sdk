# Square.Connect.Model.ListMerchantsResponse

### Description

The response object returned by the [ListMerchant](#endpoint-listmerchant) endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Information on errors encountered during the request. | [optional] 
**Merchant** | [**List&lt;Merchant&gt;**](Merchant.md) | The requested &#x60;Merchant&#x60; entities. | [optional] 
**Cursor** | **int?** | If the  response is truncated, the cursor to use in next  request to fetch next set of objects. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

