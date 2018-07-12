# Square.Connect.Model.CustomerCreationSourceFilter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | **List<ValuesEnum>** | The list of creation sources used as filtering criteria. See [CustomerCreationSource](#type-customercreationsource) for possible values. | [optional] 
**Rule** | **RuleEnum** | Indicates whether a customer profile matching the filter criteria should be included in the result or excluded from the result. Default: &#x60;INCLUDE&#x60;. See [CustomerInclusionExclusion](#type-customerinclusionexclusion) for possible values. | [optional] 


## List<ValuesEnum>

Name | Value
------------ | -------------
**OTHER** | "OTHER"
**APPOINTMENTS** | "APPOINTMENTS"
**COUPON** | "COUPON"
**DELETIONRECOVERY** | "DELETION_RECOVERY"
**DIRECTORY** | "DIRECTORY"
**EGIFTING** | "EGIFTING"
**EMAILCOLLECTION** | "EMAIL_COLLECTION"
**FEEDBACK** | "FEEDBACK"
**IMPORT** | "IMPORT"
**INVOICES** | "INVOICES"
**LOYALTY** | "LOYALTY"
**MARKETING** | "MARKETING"
**MERGE** | "MERGE"
**ONLINESTORE** | "ONLINE_STORE"
**INSTANTPROFILE** | "INSTANT_PROFILE"
**TERMINAL** | "TERMINAL"
**THIRDPARTY** | "THIRD_PARTY"
**THIRDPARTYIMPORT** | "THIRD_PARTY_IMPORT"
**UNMERGERECOVERY** | "UNMERGE_RECOVERY"


## RuleEnum

Name | Value
------------ | -------------
**INCLUDE** | "INCLUDE"
**EXCLUDE** | "EXCLUDE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

