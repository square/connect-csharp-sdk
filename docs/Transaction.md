# Square.Connect.Model.Transaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | string | The transaction&#39;s unique ID. | [optional] 
**LocationId** | string | The ID of the transaction&#39;s associated location. | [optional] 
**CreatedAt** | string | The time when the transaction was created, in RFC 3339 format. | [optional] 
**Tenders** | List<Tender> | Descriptions of the tenders used to pay for the transaction. | [optional] 
**Refunds** | List<Refund> | An array of any refunds associated with the transaction. | [optional] 
**ReferenceId** | string | If the transaction was created with the **Charge** endpoint, this value is the same as the value provided as the &#x60;reference_id&#x60; parameter in the request to that endpoint. | [optional] 
**Product** | ProductEnum | The product that processed the transaction. | [optional] 


## ProductEnum

Name | Value
------------ | -------------
**Register** | "REGISTER"
**ExternalApi** | "EXTERNAL_API"
**Billing** | "BILLING"
**Appointments** | "APPOINTMENTS"
**Invoices** | "INVOICES"
**OnlineStore** | "ONLINE_STORE"
**Payroll** | "PAYROLL"
**Other** | "OTHER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

