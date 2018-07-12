# Square.Connect.Model.CustomerSort
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **FieldEnum** | The field to sort the results on. It could be the total money spent at the merchant, the date of the first visit (etc). See [CustomerSortField](#type-customersortfield) for possible values. Default value: &#x60;DEFAULT&#x60;. | [optional] 
**Order** | **OrderEnum** | Indicates the order in which results should be displayed based on the value of the sort field. String comparisons use standard alphabetic comparison to determine order. Strings representing numbers are sorted as strings. See [SortOrder](#type-sortorder) for possible values. Default value: &#x60;ASC&#x60;. | [optional] 


## FieldEnum

Name | Value
------------ | -------------
**DEFAULT** | "DEFAULT"
**CREATEDAT** | "CREATED_AT"


## OrderEnum

Name | Value
------------ | -------------
**DESC** | "DESC"
**ASC** | "ASC"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

