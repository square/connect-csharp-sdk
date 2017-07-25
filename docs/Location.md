# Square.Connect.Model.Location
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The location&#39;s unique ID. | [optional] 
**Name** | **string** | The location&#39;s name. | [optional] 
**Address** | [**Address**](Address.md) | The location&#39;s physical address. | [optional] 
**Timezone** | **string** | The [IANA Timezone Database](https://www.iana.org/time-zones) identifier for the location&#39;s timezone. | [optional] 
**Capabilities** | **List<CapabilitiesEnum>** | Indicates which Square features are enabled for the location.  See [LocationCapability](#type-locationcapability) for possible values. | [optional] 
**Status** | **StatusEnum** | The location&#39;s status  See [LocationStatus](#type-locationstatus) for possible values. | [optional] 


## List<CapabilitiesEnum>

Name | Value
------------ | -------------
**PROCESSING** | "CREDIT_CARD_PROCESSING"


## StatusEnum

Name | Value
------------ | -------------
**ACTIVE** | "ACTIVE"
**INACTIVE** | "INACTIVE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

