# Square.Connect.Model.V1Item
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The item&#39;s ID. Must be unique among all entity IDs ever provided on behalf of the merchant. You can never reuse an ID. This value can include alphanumeric characters, dashes (-), and underscores (_). | [optional] 
**Name** | **string** | The item&#39;s name. | [optional] 
**Description** | **string** | The item&#39;s description. | [optional] 
**Type** | **TypeEnum** | The item&#39;s type. This value is NORMAL for almost all items. | [optional] 
**Color** | **ColorEnum** | The color of the discount&#39;s display label in Square Register, if not the default color. The default color is 9da2a6. | [optional] 
**Abbreviation** | **string** | The text of the item&#39;s display label in Square Register. Only up to the first five characters of the string are used. | [optional] 
**Visibility** | **VisibilityEnum** | Indicates whether the item is viewable from the merchant&#39;s online store (PUBLIC) or PRIVATE. | [optional] 
**AvailableOnline** | **bool?** | If true, the item can be added to shipping orders from the merchant&#39;s online store. | [optional] 
**MasterImage** | [**V1ItemImage**](V1ItemImage.md) | The item&#39;s master image, if any. | [optional] 
**Category** | [**V1Category**](V1Category.md) | The category the item belongs to, if any. | [optional] 
**Variations** | [**List&lt;V1Variation&gt;**](V1Variation.md) | The item&#39;s variations. You must specify at least one variation. | [optional] 
**ModifierLists** | [**List&lt;V1Variation&gt;**](V1Variation.md) | The modifier lists that apply to the item, if any. | [optional] 
**Fees** | [**List&lt;V1Fee&gt;**](V1Fee.md) | The fees that apply to the item, if any. | [optional] 
**Taxable** | **bool?** | Deprecated. This field is not used. | [optional] 
**CategoryId** | **string** | The ID of the item&#39;s category, if any. | [optional] 
**AvailableForPickup** | **bool?** | If true, the item can be added to pickup orders from the merchant&#39;s online store. Default value: false | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**NORMAL** | "NORMAL"
**GIFTCARD** | "GIFT_CARD"
**OTHER** | "OTHER"


## ColorEnum

Name | Value
------------ | -------------
**_9da2a6** | "9da2a6"
**_4ab200** | "4ab200"
**_0b8000** | "0b8000"
**_2952cc** | "2952cc"
**A82ee5** | "a82ee5"
**E5457a** | "e5457a"
**B21212** | "b21212"
**_593c00** | "593c00"
**E5BF00** | "e5BF00"


## VisibilityEnum

Name | Value
------------ | -------------
**PUBLIC** | "PUBLIC"
**PRIVATE** | "PRIVATE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

