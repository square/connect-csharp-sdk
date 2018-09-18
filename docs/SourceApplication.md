# Square.Connect.Model.SourceApplication
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Product** | **ProductEnum** | Read-only [Product](#type-product) type for the application. | [optional] 
**ApplicationId** | **string** | Read-only Square ID assigned to the application. Only used for [Product](#type-product) type &#x60;EXTERNAL_API&#x60;. | [optional] 
**Name** | **string** | Read-only display name assigned to the application (e.g. &#x60;\&quot;Custom Application\&quot;&#x60;, &#x60;\&quot;Square POS 4.74 for Android\&quot;&#x60;). | [optional] 


## ProductEnum

Name | Value
------------ | -------------
**SQUAREPOS** | "SQUARE_POS"
**EXTERNALAPI** | "EXTERNAL_API"
**BILLING** | "BILLING"
**APPOINTMENTS** | "APPOINTMENTS"
**INVOICES** | "INVOICES"
**ONLINESTORE** | "ONLINE_STORE"
**PAYROLL** | "PAYROLL"
**OTHER** | "OTHER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

