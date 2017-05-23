# Square.Connect.Model.CatalogQuery
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SortedAttributeQuery** | [**CatalogQuerySortedAttribute**](CatalogQuerySortedAttribute.md) | A query that returns all objects, sorted by the given attribute. | [optional] 
**ExactQuery** | [**CatalogQueryExact**](CatalogQueryExact.md) | A query that returns only objects for which the given (string-valued) attribute has the given case-insensitive value. | [optional] 
**PrefixQuery** | [**CatalogQueryPrefix**](CatalogQueryPrefix.md) | A query that returns only objects for which the given (string-valued) attribute has the given case-insensitive prefix. | [optional] 
**RangeQuery** | [**CatalogQueryRange**](CatalogQueryRange.md) | A query that returns only objects for which the given (integer-valued) attribute lies in the given range. | [optional] 
**TextQuery** | [**CatalogQueryText**](CatalogQueryText.md) | A query that returns only objects whose searchable attributes contain all of the given keywords as prefixes. For example, if a [CatalogItem](#type-catalogitem) contains attributes &#x60;{\&quot;name\&quot;: \&quot;t-shirt\&quot;}&#x60; and &#x60;{\&quot;description\&quot;: \&quot;Small, Red\&quot;}&#x60;, it will be matched by the query &#x60;{\&quot;keywords\&quot;: [\&quot;shirt\&quot;, \&quot;sm\&quot;, \&quot;re\&quot;]}&#x60;. | [optional] 
**ItemsForTaxQuery** | [**CatalogQueryItemsForTax**](CatalogQueryItemsForTax.md) | A query that returns all [CatalogItem](#type-catalogitem)s that have any of the given [CatalogTax](#type-catalogtax)es enabled. | [optional] 
**ItemsForModifierListQuery** | [**CatalogQueryItemsForModifierList**](CatalogQueryItemsForModifierList.md) | A query that returns all [CatalogItem](#type-catalogitem)s that have any of the given [CatalogModifierList](#type-catalogmodifierlist)s enabled. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

