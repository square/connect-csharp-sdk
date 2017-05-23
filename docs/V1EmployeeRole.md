# Square.Connect.Model.V1EmployeeRole
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The role&#39;s unique ID, Can only be set by Square. | [optional] 
**Name** | **string** | The role&#39;s merchant-defined name. | 
**Permissions** | **List<PermissionsEnum>** | The role&#39;s permissions. | 
**IsOwner** | **bool?** | If true, employees with this role have all permissions, regardless of the values indicated in permissions. | [optional] 
**CreatedAt** | **string** | The time when the employee entity was created, in ISO 8601 format. Is set by Square when the Role is created. | [optional] 
**UpdatedAt** | **string** | The time when the employee entity was most recently updated, in ISO 8601 format. Is set by Square when the Role updated. | [optional] 


## List<PermissionsEnum>

Name | Value
------------ | -------------
**ACCESSSALESHISTORY** | "REGISTER_ACCESS_SALES_HISTORY"
**APPLYRESTRICTEDDISCOUNTS** | "REGISTER_APPLY_RESTRICTED_DISCOUNTS"
**CHANGESETTINGS** | "REGISTER_CHANGE_SETTINGS"
**EDITITEM** | "REGISTER_EDIT_ITEM"
**ISSUEREFUNDS** | "REGISTER_ISSUE_REFUNDS"
**OPENCASHDRAWEROUTSIDESALE** | "REGISTER_OPEN_CASH_DRAWER_OUTSIDE_SALE"
**VIEWSUMMARYREPORTS** | "REGISTER_VIEW_SUMMARY_REPORTS"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

