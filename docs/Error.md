# Square.Connect.Model.Error
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | CategoryEnum |  | 
**Code** | CodeEnum |  | 
**Detail** | string |  | [optional] 
**Field** | string |  | [optional] 


## CategoryEnum

Name | Value
------------ | -------------
**ApiError** | "API_ERROR"
**AuthenticationError** | "AUTHENTICATION_ERROR"
**InvalidRequestError** | "INVALID_REQUEST_ERROR"
**RateLimitError** | "RATE_LIMIT_ERROR"
**PaymentMethodError** | "PAYMENT_METHOD_ERROR"
**RefundError** | "REFUND_ERROR"


## CodeEnum

Name | Value
------------ | -------------
**InternalServerError** | "INTERNAL_SERVER_ERROR"
**Unauthorized** | "UNAUTHORIZED"
**AccessTokenExpired** | "ACCESS_TOKEN_EXPIRED"
**AccessTokenRevoked** | "ACCESS_TOKEN_REVOKED"
**Forbidden** | "FORBIDDEN"
**InsufficientScopes** | "INSUFFICIENT_SCOPES"
**ApplicationDisabled** | "APPLICATION_DISABLED"
**V1Application** | "V1_APPLICATION"
**V1AccessToken** | "V1_ACCESS_TOKEN"
**CardProcessingNotEnabled** | "CARD_PROCESSING_NOT_ENABLED"
**BadRequest** | "BAD_REQUEST"
**MissingRequiredParameter** | "MISSING_REQUIRED_PARAMETER"
**IncorrectType** | "INCORRECT_TYPE"
**InvalidTime** | "INVALID_TIME"
**InvalidTimeRange** | "INVALID_TIME_RANGE"
**InvalidValue** | "INVALID_VALUE"
**InvalidCursor** | "INVALID_CURSOR"
**UnknownQueryParameter** | "UNKNOWN_QUERY_PARAMETER"
**ConflictingParameters** | "CONFLICTING_PARAMETERS"
**ExpectedJsonBody** | "EXPECTED_JSON_BODY"
**InvalidSortOrder** | "INVALID_SORT_ORDER"
**ValueTooLong** | "VALUE_TOO_LONG"
**ValueTooLow** | "VALUE_TOO_LOW"
**ExpectedBoolean** | "EXPECTED_BOOLEAN"
**ExpectedInteger** | "EXPECTED_INTEGER"
**ExpectedFloat** | "EXPECTED_FLOAT"
**ExpectedString** | "EXPECTED_STRING"
**ExpectedObject** | "EXPECTED_OBJECT"
**ExpectedArray** | "EXPECTED_ARRAY"
**InvalidArrayValue** | "INVALID_ARRAY_VALUE"
**InvalidEnumValue** | "INVALID_ENUM_VALUE"
**InvalidContentType** | "INVALID_CONTENT_TYPE"
**InvalidFormValue** | "INVALID_FORM_VALUE"
**OneInstrumentExpected** | "ONE_INSTRUMENT_EXPECTED"
**NoFieldsSet** | "NO_FIELDS_SET"
**CardDeclined** | "CARD_DECLINED"
**CardExpired** | "CARD_EXPIRED"
**VerifyCvvFailure** | "VERIFY_CVV_FAILURE"
**VerifyAvsFailure** | "VERIFY_AVS_FAILURE"
**InvalidExpiration** | "INVALID_EXPIRATION"
**InvalidExpirationYear** | "INVALID_EXPIRATION_YEAR"
**InvalidExpirationDate** | "INVALID_EXPIRATION_DATE"
**InvalidCard** | "INVALID_CARD"
**DelayedTransactionExpired** | "DELAYED_TRANSACTION_EXPIRED"
**DelayedTransactionCanceled** | "DELAYED_TRANSACTION_CANCELED"
**DelayedTransactionCaptured** | "DELAYED_TRANSACTION_CAPTURED"
**DelayedTransactionFailed** | "DELAYED_TRANSACTION_FAILED"
**CardTokenExpired** | "CARD_TOKEN_EXPIRED"
**CardTokenUsed** | "CARD_TOKEN_USED"
**AmountTooHigh** | "AMOUNT_TOO_HIGH"
**UnsupportedInstrumentType** | "UNSUPPORTED_INSTRUMENT_TYPE"
**RefundAmountInvalid** | "REFUND_AMOUNT_INVALID"
**RefundAlreadyPending** | "REFUND_ALREADY_PENDING"
**PaymentNotRefundable** | "PAYMENT_NOT_REFUNDABLE"
**InvalidCardData** | "INVALID_CARD_DATA"
**NotFound** | "NOT_FOUND"
**RequestTimeout** | "REQUEST_TIMEOUT"
**RequestEntityTooLarge** | "REQUEST_ENTITY_TOO_LARGE"
**UnsupportedMediaType** | "UNSUPPORTED_MEDIA_TYPE"
**RateLimited** | "RATE_LIMITED"
**NotImplemented** | "NOT_IMPLEMENTED"
**ServiceUnavailable** | "SERVICE_UNAVAILABLE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

