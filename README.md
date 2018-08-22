Square Connect C# SDK [![Build Status](https://travis-ci.org/square/connect-csharp-sdk.svg?branch=master)](https://travis-ci.org/square/connect-csharp-sdk)[![NuGet version](https://badge.fury.io/nu/Square.Connect.svg)](https://badge.fury.io/nu/Square.Connect)
==================

**If you have feedback about the new SDKs, or just want to talk to other Square Developers, request an invite to the new [slack community for Square Developers](https://squ.re/2GUW1SQ)**

This repository contains the released C# client SDK. Check out our [API
specification repository](https://github.com/square/connect-api-specification)
for the specification and template files we used to generate this.

## Frameworks supported
- .NET Standard 2.0

## Usage
### **Obtain from [NuGet package manager](https://www.nuget.org/packages/Square.Connect/) (Recommended)**
```
PM> Install-Package Square.Connect
```

### **Generating DLLs from source**

#### Dependencies
- [RestSharp] (https://www.nuget.org/packages/RestSharp) - 106.3.1 or later
- [Json.NET] (https://www.nuget.org/packages/Newtonsoft.Json/) - 11.0.2 or later

Option 1: Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Option 2: Import the `Square.Connect/Square.Connect.csproj` to your solution and build from VS

Then include the DLLs (under the `bin` folder) in the C# project,

- Square.Connect.dll

## Getting Started

Use the namespaces:
```csharp
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;
```

### Example:

```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class Example
    {
        public Example()
        {
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
        }

        // Retrieving your location IDs
        public void RetrieveLocations()
        {
            LocationsApi _locationsApi = new LocationsApi();
            var response = _locationsApi.ListLocations();
        }

        // Charge the card nonce
        public void ChargeNonce()
        {
            // Every payment you process for a given business have a unique idempotency key.
            // If you're unsure whether a particular payment succeeded, you can reattempt
            // it with the same idempotency key without worrying about double charging
            // the buyer.
            string idempotencyKey = Guid.NewGuid().ToString();

            // Monetary amounts are specified in the smallest unit of the applicable currency.
            // This amount is in cents. It's also hard-coded for $1, which is not very useful.
            int amount = 100;
            string currency = "USD";
            Money money = new Money(amount, Money.ToCurrencyEnum(currency));

            string nonce = "YOUR_NONCE";
            string locationId = "YOUR_LOCATION_ID";
            ChargeRequest body = new ChargeRequest(AmountMoney: money, IdempotencyKey: idempotencyKey, CardNonce: nonce);
            TransactionsApi transactionsApi = new TransactionsApi();
            var response = transactionsApi.Charge(locationId, body);
        }
    }
}
```
More examples are available at [connect-api-examples](https://github.com/square/connect-api-examples)

## Documentation for API Endpoints

All URIs are relative to [Square Connect Documentation](https://docs.connect.squareup.com/)

Class | Method | HTTP request
------------ | ------------- | -------------
*ApplePayApi* | [**RegisterDomain**](docs/ApplePayApi.md#registerdomain) | **POST** /v2/apple-pay/domains
*CatalogApi* | [**BatchDeleteCatalogObjects**](docs/CatalogApi.md#batchdeletecatalogobjects) | **POST** /v2/catalog/batch-delete
*CatalogApi* | [**BatchRetrieveCatalogObjects**](docs/CatalogApi.md#batchretrievecatalogobjects) | **POST** /v2/catalog/batch-retrieve
*CatalogApi* | [**BatchUpsertCatalogObjects**](docs/CatalogApi.md#batchupsertcatalogobjects) | **POST** /v2/catalog/batch-upsert
*CatalogApi* | [**CatalogInfo**](docs/CatalogApi.md#cataloginfo) | **GET** /v2/catalog/info
*CatalogApi* | [**DeleteCatalogObject**](docs/CatalogApi.md#deletecatalogobject) | **DELETE** /v2/catalog/object/{object_id}
*CatalogApi* | [**ListCatalog**](docs/CatalogApi.md#listcatalog) | **GET** /v2/catalog/list
*CatalogApi* | [**RetrieveCatalogObject**](docs/CatalogApi.md#retrievecatalogobject) | **GET** /v2/catalog/object/{object_id}
*CatalogApi* | [**SearchCatalogObjects**](docs/CatalogApi.md#searchcatalogobjects) | **POST** /v2/catalog/search
*CatalogApi* | [**UpdateItemModifierLists**](docs/CatalogApi.md#updateitemmodifierlists) | **POST** /v2/catalog/update-item-modifier-lists
*CatalogApi* | [**UpdateItemTaxes**](docs/CatalogApi.md#updateitemtaxes) | **POST** /v2/catalog/update-item-taxes
*CatalogApi* | [**UpsertCatalogObject**](docs/CatalogApi.md#upsertcatalogobject) | **POST** /v2/catalog/object
*CheckoutApi* | [**CreateCheckout**](docs/CheckoutApi.md#createcheckout) | **POST** /v2/locations/{location_id}/checkouts
*CustomersApi* | [**CreateCustomer**](docs/CustomersApi.md#createcustomer) | **POST** /v2/customers
*CustomersApi* | [**CreateCustomerCard**](docs/CustomersApi.md#createcustomercard) | **POST** /v2/customers/{customer_id}/cards
*CustomersApi* | [**DeleteCustomer**](docs/CustomersApi.md#deletecustomer) | **DELETE** /v2/customers/{customer_id}
*CustomersApi* | [**DeleteCustomerCard**](docs/CustomersApi.md#deletecustomercard) | **DELETE** /v2/customers/{customer_id}/cards/{card_id}
*CustomersApi* | [**ListCustomers**](docs/CustomersApi.md#listcustomers) | **GET** /v2/customers
*CustomersApi* | [**RetrieveCustomer**](docs/CustomersApi.md#retrievecustomer) | **GET** /v2/customers/{customer_id}
*CustomersApi* | [**SearchCustomers**](docs/CustomersApi.md#searchcustomers) | **POST** /v2/customers/search
*CustomersApi* | [**UpdateCustomer**](docs/CustomersApi.md#updatecustomer) | **PUT** /v2/customers/{customer_id}
*LocationsApi* | [**ListLocations**](docs/LocationsApi.md#listlocations) | **GET** /v2/locations
*MobileAuthorizationApi* | [**CreateMobileAuthorizationCode**](docs/MobileAuthorizationApi.md#createmobileauthorizationcode) | **POST** /mobile/authorization-code
*OAuthApi* | [**ObtainToken**](docs/OAuthApi.md#obtaintoken) | **POST** /oauth2/token
*OAuthApi* | [**RenewToken**](docs/OAuthApi.md#renewtoken) | **POST** /oauth2/clients/{client_id}/access-token/renew
*OAuthApi* | [**RevokeToken**](docs/OAuthApi.md#revoketoken) | **POST** /oauth2/revoke
*OrdersApi* | [**BatchRetrieveOrders**](docs/OrdersApi.md#batchretrieveorders) | **POST** /v2/locations/{location_id}/orders/batch-retrieve
*OrdersApi* | [**CreateOrder**](docs/OrdersApi.md#createorder) | **POST** /v2/locations/{location_id}/orders
*ReportingApi* | [**ListAdditionalRecipientReceivableRefunds**](docs/ReportingApi.md#listadditionalrecipientreceivablerefunds) | **GET** /v2/locations/{location_id}/additional-recipient-receivable-refunds
*ReportingApi* | [**ListAdditionalRecipientReceivables**](docs/ReportingApi.md#listadditionalrecipientreceivables) | **GET** /v2/locations/{location_id}/additional-recipient-receivables
*TransactionsApi* | [**CaptureTransaction**](docs/TransactionsApi.md#capturetransaction) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/capture
*TransactionsApi* | [**Charge**](docs/TransactionsApi.md#charge) | **POST** /v2/locations/{location_id}/transactions
*TransactionsApi* | [**CreateRefund**](docs/TransactionsApi.md#createrefund) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/refund
*TransactionsApi* | [**ListRefunds**](docs/TransactionsApi.md#listrefunds) | **GET** /v2/locations/{location_id}/refunds
*TransactionsApi* | [**ListTransactions**](docs/TransactionsApi.md#listtransactions) | **GET** /v2/locations/{location_id}/transactions
*TransactionsApi* | [**RetrieveTransaction**](docs/TransactionsApi.md#retrievetransaction) | **GET** /v2/locations/{location_id}/transactions/{transaction_id}
*TransactionsApi* | [**VoidTransaction**](docs/TransactionsApi.md#voidtransaction) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/void
*V1EmployeesApi* | [**CreateEmployee**](docs/V1EmployeesApi.md#createemployee) | **POST** /v1/me/employees
*V1EmployeesApi* | [**CreateEmployeeRole**](docs/V1EmployeesApi.md#createemployeerole) | **POST** /v1/me/roles
*V1EmployeesApi* | [**CreateTimecard**](docs/V1EmployeesApi.md#createtimecard) | **POST** /v1/me/timecards
*V1EmployeesApi* | [**DeleteTimecard**](docs/V1EmployeesApi.md#deletetimecard) | **DELETE** /v1/me/timecards/{timecard_id}
*V1EmployeesApi* | [**ListCashDrawerShifts**](docs/V1EmployeesApi.md#listcashdrawershifts) | **GET** /v1/{location_id}/cash-drawer-shifts
*V1EmployeesApi* | [**ListEmployeeRoles**](docs/V1EmployeesApi.md#listemployeeroles) | **GET** /v1/me/roles
*V1EmployeesApi* | [**ListEmployees**](docs/V1EmployeesApi.md#listemployees) | **GET** /v1/me/employees
*V1EmployeesApi* | [**ListTimecardEvents**](docs/V1EmployeesApi.md#listtimecardevents) | **GET** /v1/me/timecards/{timecard_id}/events
*V1EmployeesApi* | [**ListTimecards**](docs/V1EmployeesApi.md#listtimecards) | **GET** /v1/me/timecards
*V1EmployeesApi* | [**RetrieveCashDrawerShift**](docs/V1EmployeesApi.md#retrievecashdrawershift) | **GET** /v1/{location_id}/cash-drawer-shifts/{shift_id}
*V1EmployeesApi* | [**RetrieveEmployee**](docs/V1EmployeesApi.md#retrieveemployee) | **GET** /v1/me/employees/{employee_id}
*V1EmployeesApi* | [**RetrieveEmployeeRole**](docs/V1EmployeesApi.md#retrieveemployeerole) | **GET** /v1/me/roles/{role_id}
*V1EmployeesApi* | [**RetrieveTimecard**](docs/V1EmployeesApi.md#retrievetimecard) | **GET** /v1/me/timecards/{timecard_id}
*V1EmployeesApi* | [**UpdateEmployee**](docs/V1EmployeesApi.md#updateemployee) | **PUT** /v1/me/employees/{employee_id}
*V1EmployeesApi* | [**UpdateEmployeeRole**](docs/V1EmployeesApi.md#updateemployeerole) | **PUT** /v1/me/roles/{role_id}
*V1EmployeesApi* | [**UpdateTimecard**](docs/V1EmployeesApi.md#updatetimecard) | **PUT** /v1/me/timecards/{timecard_id}
*V1ItemsApi* | [**AdjustInventory**](docs/V1ItemsApi.md#adjustinventory) | **POST** /v1/{location_id}/inventory/{variation_id}
*V1ItemsApi* | [**ApplyFee**](docs/V1ItemsApi.md#applyfee) | **PUT** /v1/{location_id}/items/{item_id}/fees/{fee_id}
*V1ItemsApi* | [**ApplyModifierList**](docs/V1ItemsApi.md#applymodifierlist) | **PUT** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id}
*V1ItemsApi* | [**CreateCategory**](docs/V1ItemsApi.md#createcategory) | **POST** /v1/{location_id}/categories
*V1ItemsApi* | [**CreateDiscount**](docs/V1ItemsApi.md#creatediscount) | **POST** /v1/{location_id}/discounts
*V1ItemsApi* | [**CreateFee**](docs/V1ItemsApi.md#createfee) | **POST** /v1/{location_id}/fees
*V1ItemsApi* | [**CreateItem**](docs/V1ItemsApi.md#createitem) | **POST** /v1/{location_id}/items
*V1ItemsApi* | [**CreateModifierList**](docs/V1ItemsApi.md#createmodifierlist) | **POST** /v1/{location_id}/modifier-lists
*V1ItemsApi* | [**CreateModifierOption**](docs/V1ItemsApi.md#createmodifieroption) | **POST** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options
*V1ItemsApi* | [**CreatePage**](docs/V1ItemsApi.md#createpage) | **POST** /v1/{location_id}/pages
*V1ItemsApi* | [**CreateVariation**](docs/V1ItemsApi.md#createvariation) | **POST** /v1/{location_id}/items/{item_id}/variations
*V1ItemsApi* | [**DeleteCategory**](docs/V1ItemsApi.md#deletecategory) | **DELETE** /v1/{location_id}/categories/{category_id}
*V1ItemsApi* | [**DeleteDiscount**](docs/V1ItemsApi.md#deletediscount) | **DELETE** /v1/{location_id}/discounts/{discount_id}
*V1ItemsApi* | [**DeleteFee**](docs/V1ItemsApi.md#deletefee) | **DELETE** /v1/{location_id}/fees/{fee_id}
*V1ItemsApi* | [**DeleteItem**](docs/V1ItemsApi.md#deleteitem) | **DELETE** /v1/{location_id}/items/{item_id}
*V1ItemsApi* | [**DeleteModifierList**](docs/V1ItemsApi.md#deletemodifierlist) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id}
*V1ItemsApi* | [**DeleteModifierOption**](docs/V1ItemsApi.md#deletemodifieroption) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id}
*V1ItemsApi* | [**DeletePage**](docs/V1ItemsApi.md#deletepage) | **DELETE** /v1/{location_id}/pages/{page_id}
*V1ItemsApi* | [**DeletePageCell**](docs/V1ItemsApi.md#deletepagecell) | **DELETE** /v1/{location_id}/pages/{page_id}/cells
*V1ItemsApi* | [**DeleteVariation**](docs/V1ItemsApi.md#deletevariation) | **DELETE** /v1/{location_id}/items/{item_id}/variations/{variation_id}
*V1ItemsApi* | [**ListCategories**](docs/V1ItemsApi.md#listcategories) | **GET** /v1/{location_id}/categories
*V1ItemsApi* | [**ListDiscounts**](docs/V1ItemsApi.md#listdiscounts) | **GET** /v1/{location_id}/discounts
*V1ItemsApi* | [**ListFees**](docs/V1ItemsApi.md#listfees) | **GET** /v1/{location_id}/fees
*V1ItemsApi* | [**ListInventory**](docs/V1ItemsApi.md#listinventory) | **GET** /v1/{location_id}/inventory
*V1ItemsApi* | [**ListItems**](docs/V1ItemsApi.md#listitems) | **GET** /v1/{location_id}/items
*V1ItemsApi* | [**ListModifierLists**](docs/V1ItemsApi.md#listmodifierlists) | **GET** /v1/{location_id}/modifier-lists
*V1ItemsApi* | [**ListPages**](docs/V1ItemsApi.md#listpages) | **GET** /v1/{location_id}/pages
*V1ItemsApi* | [**RemoveFee**](docs/V1ItemsApi.md#removefee) | **DELETE** /v1/{location_id}/items/{item_id}/fees/{fee_id}
*V1ItemsApi* | [**RemoveModifierList**](docs/V1ItemsApi.md#removemodifierlist) | **DELETE** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id}
*V1ItemsApi* | [**RetrieveItem**](docs/V1ItemsApi.md#retrieveitem) | **GET** /v1/{location_id}/items/{item_id}
*V1ItemsApi* | [**RetrieveModifierList**](docs/V1ItemsApi.md#retrievemodifierlist) | **GET** /v1/{location_id}/modifier-lists/{modifier_list_id}
*V1ItemsApi* | [**UpdateCategory**](docs/V1ItemsApi.md#updatecategory) | **PUT** /v1/{location_id}/categories/{category_id}
*V1ItemsApi* | [**UpdateDiscount**](docs/V1ItemsApi.md#updatediscount) | **PUT** /v1/{location_id}/discounts/{discount_id}
*V1ItemsApi* | [**UpdateFee**](docs/V1ItemsApi.md#updatefee) | **PUT** /v1/{location_id}/fees/{fee_id}
*V1ItemsApi* | [**UpdateItem**](docs/V1ItemsApi.md#updateitem) | **PUT** /v1/{location_id}/items/{item_id}
*V1ItemsApi* | [**UpdateModifierList**](docs/V1ItemsApi.md#updatemodifierlist) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id}
*V1ItemsApi* | [**UpdateModifierOption**](docs/V1ItemsApi.md#updatemodifieroption) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id}
*V1ItemsApi* | [**UpdatePage**](docs/V1ItemsApi.md#updatepage) | **PUT** /v1/{location_id}/pages/{page_id}
*V1ItemsApi* | [**UpdatePageCell**](docs/V1ItemsApi.md#updatepagecell) | **PUT** /v1/{location_id}/pages/{page_id}/cells
*V1ItemsApi* | [**UpdateVariation**](docs/V1ItemsApi.md#updatevariation) | **PUT** /v1/{location_id}/items/{item_id}/variations/{variation_id}
*V1LocationsApi* | [**ListLocations**](docs/V1LocationsApi.md#listlocations) | **GET** /v1/me/locations
*V1LocationsApi* | [**RetrieveBusiness**](docs/V1LocationsApi.md#retrievebusiness) | **GET** /v1/me
*V1TransactionsApi* | [**CreateRefund**](docs/V1TransactionsApi.md#createrefund) | **POST** /v1/{location_id}/refunds
*V1TransactionsApi* | [**ListBankAccounts**](docs/V1TransactionsApi.md#listbankaccounts) | **GET** /v1/{location_id}/bank-accounts
*V1TransactionsApi* | [**ListOrders**](docs/V1TransactionsApi.md#listorders) | **GET** /v1/{location_id}/orders
*V1TransactionsApi* | [**ListPayments**](docs/V1TransactionsApi.md#listpayments) | **GET** /v1/{location_id}/payments
*V1TransactionsApi* | [**ListRefunds**](docs/V1TransactionsApi.md#listrefunds) | **GET** /v1/{location_id}/refunds
*V1TransactionsApi* | [**ListSettlements**](docs/V1TransactionsApi.md#listsettlements) | **GET** /v1/{location_id}/settlements
*V1TransactionsApi* | [**RetrieveBankAccount**](docs/V1TransactionsApi.md#retrievebankaccount) | **GET** /v1/{location_id}/bank-accounts/{bank_account_id}
*V1TransactionsApi* | [**RetrieveOrder**](docs/V1TransactionsApi.md#retrieveorder) | **GET** /v1/{location_id}/orders/{order_id}
*V1TransactionsApi* | [**RetrievePayment**](docs/V1TransactionsApi.md#retrievepayment) | **GET** /v1/{location_id}/payments/{payment_id}
*V1TransactionsApi* | [**RetrieveSettlement**](docs/V1TransactionsApi.md#retrievesettlement) | **GET** /v1/{location_id}/settlements/{settlement_id}
*V1TransactionsApi* | [**UpdateOrder**](docs/V1TransactionsApi.md#updateorder) | **PUT** /v1/{location_id}/orders/{order_id}


## Documentation for Models

 - [Model.AdditionalRecipient](docs/AdditionalRecipient.md)
 - [Model.AdditionalRecipientReceivable](docs/AdditionalRecipientReceivable.md)
 - [Model.AdditionalRecipientReceivableRefund](docs/AdditionalRecipientReceivableRefund.md)
 - [Model.Address](docs/Address.md)
 - [Model.BatchDeleteCatalogObjectsRequest](docs/BatchDeleteCatalogObjectsRequest.md)
 - [Model.BatchDeleteCatalogObjectsResponse](docs/BatchDeleteCatalogObjectsResponse.md)
 - [Model.BatchRetrieveCatalogObjectsRequest](docs/BatchRetrieveCatalogObjectsRequest.md)
 - [Model.BatchRetrieveCatalogObjectsResponse](docs/BatchRetrieveCatalogObjectsResponse.md)
 - [Model.BatchRetrieveOrdersRequest](docs/BatchRetrieveOrdersRequest.md)
 - [Model.BatchRetrieveOrdersResponse](docs/BatchRetrieveOrdersResponse.md)
 - [Model.BatchUpsertCatalogObjectsRequest](docs/BatchUpsertCatalogObjectsRequest.md)
 - [Model.BatchUpsertCatalogObjectsResponse](docs/BatchUpsertCatalogObjectsResponse.md)
 - [Model.CaptureTransactionRequest](docs/CaptureTransactionRequest.md)
 - [Model.CaptureTransactionResponse](docs/CaptureTransactionResponse.md)
 - [Model.Card](docs/Card.md)
 - [Model.CatalogCategory](docs/CatalogCategory.md)
 - [Model.CatalogDiscount](docs/CatalogDiscount.md)
 - [Model.CatalogIdMapping](docs/CatalogIdMapping.md)
 - [Model.CatalogInfoRequest](docs/CatalogInfoRequest.md)
 - [Model.CatalogInfoResponse](docs/CatalogInfoResponse.md)
 - [Model.CatalogInfoResponseLimits](docs/CatalogInfoResponseLimits.md)
 - [Model.CatalogItem](docs/CatalogItem.md)
 - [Model.CatalogItemModifierListInfo](docs/CatalogItemModifierListInfo.md)
 - [Model.CatalogItemVariation](docs/CatalogItemVariation.md)
 - [Model.CatalogModifier](docs/CatalogModifier.md)
 - [Model.CatalogModifierList](docs/CatalogModifierList.md)
 - [Model.CatalogModifierOverride](docs/CatalogModifierOverride.md)
 - [Model.CatalogObject](docs/CatalogObject.md)
 - [Model.CatalogObjectBatch](docs/CatalogObjectBatch.md)
 - [Model.CatalogQuery](docs/CatalogQuery.md)
 - [Model.CatalogQueryExact](docs/CatalogQueryExact.md)
 - [Model.CatalogQueryItemsForModifierList](docs/CatalogQueryItemsForModifierList.md)
 - [Model.CatalogQueryItemsForTax](docs/CatalogQueryItemsForTax.md)
 - [Model.CatalogQueryPrefix](docs/CatalogQueryPrefix.md)
 - [Model.CatalogQueryRange](docs/CatalogQueryRange.md)
 - [Model.CatalogQuerySortedAttribute](docs/CatalogQuerySortedAttribute.md)
 - [Model.CatalogQueryText](docs/CatalogQueryText.md)
 - [Model.CatalogTax](docs/CatalogTax.md)
 - [Model.CatalogV1Id](docs/CatalogV1Id.md)
 - [Model.ChargeRequest](docs/ChargeRequest.md)
 - [Model.ChargeRequestAdditionalRecipient](docs/ChargeRequestAdditionalRecipient.md)
 - [Model.ChargeResponse](docs/ChargeResponse.md)
 - [Model.Checkout](docs/Checkout.md)
 - [Model.CreateCheckoutRequest](docs/CreateCheckoutRequest.md)
 - [Model.CreateCheckoutResponse](docs/CreateCheckoutResponse.md)
 - [Model.CreateCustomerCardRequest](docs/CreateCustomerCardRequest.md)
 - [Model.CreateCustomerCardResponse](docs/CreateCustomerCardResponse.md)
 - [Model.CreateCustomerRequest](docs/CreateCustomerRequest.md)
 - [Model.CreateCustomerResponse](docs/CreateCustomerResponse.md)
 - [Model.CreateMobileAuthorizationCodeRequest](docs/CreateMobileAuthorizationCodeRequest.md)
 - [Model.CreateMobileAuthorizationCodeResponse](docs/CreateMobileAuthorizationCodeResponse.md)
 - [Model.CreateOrderRequest](docs/CreateOrderRequest.md)
 - [Model.CreateOrderRequestDiscount](docs/CreateOrderRequestDiscount.md)
 - [Model.CreateOrderRequestLineItem](docs/CreateOrderRequestLineItem.md)
 - [Model.CreateOrderRequestModifier](docs/CreateOrderRequestModifier.md)
 - [Model.CreateOrderRequestTax](docs/CreateOrderRequestTax.md)
 - [Model.CreateOrderResponse](docs/CreateOrderResponse.md)
 - [Model.CreateRefundRequest](docs/CreateRefundRequest.md)
 - [Model.CreateRefundResponse](docs/CreateRefundResponse.md)
 - [Model.Customer](docs/Customer.md)
 - [Model.CustomerCreationSourceFilter](docs/CustomerCreationSourceFilter.md)
 - [Model.CustomerFilter](docs/CustomerFilter.md)
 - [Model.CustomerGroupInfo](docs/CustomerGroupInfo.md)
 - [Model.CustomerPreferences](docs/CustomerPreferences.md)
 - [Model.CustomerQuery](docs/CustomerQuery.md)
 - [Model.CustomerSort](docs/CustomerSort.md)
 - [Model.DeleteCatalogObjectRequest](docs/DeleteCatalogObjectRequest.md)
 - [Model.DeleteCatalogObjectResponse](docs/DeleteCatalogObjectResponse.md)
 - [Model.DeleteCustomerCardRequest](docs/DeleteCustomerCardRequest.md)
 - [Model.DeleteCustomerCardResponse](docs/DeleteCustomerCardResponse.md)
 - [Model.DeleteCustomerRequest](docs/DeleteCustomerRequest.md)
 - [Model.DeleteCustomerResponse](docs/DeleteCustomerResponse.md)
 - [Model.Device](docs/Device.md)
 - [Model.Error](docs/Error.md)
 - [Model.ItemVariationLocationOverrides](docs/ItemVariationLocationOverrides.md)
 - [Model.ListAdditionalRecipientReceivableRefundsRequest](docs/ListAdditionalRecipientReceivableRefundsRequest.md)
 - [Model.ListAdditionalRecipientReceivableRefundsResponse](docs/ListAdditionalRecipientReceivableRefundsResponse.md)
 - [Model.ListAdditionalRecipientReceivablesRequest](docs/ListAdditionalRecipientReceivablesRequest.md)
 - [Model.ListAdditionalRecipientReceivablesResponse](docs/ListAdditionalRecipientReceivablesResponse.md)
 - [Model.ListCatalogRequest](docs/ListCatalogRequest.md)
 - [Model.ListCatalogResponse](docs/ListCatalogResponse.md)
 - [Model.ListCustomersRequest](docs/ListCustomersRequest.md)
 - [Model.ListCustomersResponse](docs/ListCustomersResponse.md)
 - [Model.ListLocationsRequest](docs/ListLocationsRequest.md)
 - [Model.ListLocationsResponse](docs/ListLocationsResponse.md)
 - [Model.ListRefundsRequest](docs/ListRefundsRequest.md)
 - [Model.ListRefundsResponse](docs/ListRefundsResponse.md)
 - [Model.ListTransactionsRequest](docs/ListTransactionsRequest.md)
 - [Model.ListTransactionsResponse](docs/ListTransactionsResponse.md)
 - [Model.Location](docs/Location.md)
 - [Model.Money](docs/Money.md)
 - [Model.ObtainTokenRequest](docs/ObtainTokenRequest.md)
 - [Model.ObtainTokenResponse](docs/ObtainTokenResponse.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderLineItem](docs/OrderLineItem.md)
 - [Model.OrderLineItemDiscount](docs/OrderLineItemDiscount.md)
 - [Model.OrderLineItemModifier](docs/OrderLineItemModifier.md)
 - [Model.OrderLineItemTax](docs/OrderLineItemTax.md)
 - [Model.Refund](docs/Refund.md)
 - [Model.RegisterDomainRequest](docs/RegisterDomainRequest.md)
 - [Model.RegisterDomainResponse](docs/RegisterDomainResponse.md)
 - [Model.RenewTokenRequest](docs/RenewTokenRequest.md)
 - [Model.RenewTokenResponse](docs/RenewTokenResponse.md)
 - [Model.RetrieveCatalogObjectRequest](docs/RetrieveCatalogObjectRequest.md)
 - [Model.RetrieveCatalogObjectResponse](docs/RetrieveCatalogObjectResponse.md)
 - [Model.RetrieveCustomerRequest](docs/RetrieveCustomerRequest.md)
 - [Model.RetrieveCustomerResponse](docs/RetrieveCustomerResponse.md)
 - [Model.RetrieveTransactionRequest](docs/RetrieveTransactionRequest.md)
 - [Model.RetrieveTransactionResponse](docs/RetrieveTransactionResponse.md)
 - [Model.RevokeTokenRequest](docs/RevokeTokenRequest.md)
 - [Model.RevokeTokenResponse](docs/RevokeTokenResponse.md)
 - [Model.SearchCatalogObjectsRequest](docs/SearchCatalogObjectsRequest.md)
 - [Model.SearchCatalogObjectsResponse](docs/SearchCatalogObjectsResponse.md)
 - [Model.SearchCustomersRequest](docs/SearchCustomersRequest.md)
 - [Model.SearchCustomersResponse](docs/SearchCustomersResponse.md)
 - [Model.Tender](docs/Tender.md)
 - [Model.TenderCardDetails](docs/TenderCardDetails.md)
 - [Model.TenderCashDetails](docs/TenderCashDetails.md)
 - [Model.TimeRange](docs/TimeRange.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.UpdateCustomerRequest](docs/UpdateCustomerRequest.md)
 - [Model.UpdateCustomerResponse](docs/UpdateCustomerResponse.md)
 - [Model.UpdateItemModifierListsRequest](docs/UpdateItemModifierListsRequest.md)
 - [Model.UpdateItemModifierListsResponse](docs/UpdateItemModifierListsResponse.md)
 - [Model.UpdateItemTaxesRequest](docs/UpdateItemTaxesRequest.md)
 - [Model.UpdateItemTaxesResponse](docs/UpdateItemTaxesResponse.md)
 - [Model.UpsertCatalogObjectRequest](docs/UpsertCatalogObjectRequest.md)
 - [Model.UpsertCatalogObjectResponse](docs/UpsertCatalogObjectResponse.md)
 - [Model.V1AdjustInventoryRequest](docs/V1AdjustInventoryRequest.md)
 - [Model.V1BankAccount](docs/V1BankAccount.md)
 - [Model.V1CashDrawerEvent](docs/V1CashDrawerEvent.md)
 - [Model.V1CashDrawerShift](docs/V1CashDrawerShift.md)
 - [Model.V1Category](docs/V1Category.md)
 - [Model.V1CreateRefundRequest](docs/V1CreateRefundRequest.md)
 - [Model.V1Discount](docs/V1Discount.md)
 - [Model.V1Employee](docs/V1Employee.md)
 - [Model.V1EmployeeRole](docs/V1EmployeeRole.md)
 - [Model.V1Fee](docs/V1Fee.md)
 - [Model.V1InventoryEntry](docs/V1InventoryEntry.md)
 - [Model.V1Item](docs/V1Item.md)
 - [Model.V1ItemImage](docs/V1ItemImage.md)
 - [Model.V1Merchant](docs/V1Merchant.md)
 - [Model.V1MerchantLocationDetails](docs/V1MerchantLocationDetails.md)
 - [Model.V1ModifierList](docs/V1ModifierList.md)
 - [Model.V1ModifierOption](docs/V1ModifierOption.md)
 - [Model.V1Money](docs/V1Money.md)
 - [Model.V1Order](docs/V1Order.md)
 - [Model.V1OrderHistoryEntry](docs/V1OrderHistoryEntry.md)
 - [Model.V1Page](docs/V1Page.md)
 - [Model.V1PageCell](docs/V1PageCell.md)
 - [Model.V1Payment](docs/V1Payment.md)
 - [Model.V1PaymentDiscount](docs/V1PaymentDiscount.md)
 - [Model.V1PaymentItemDetail](docs/V1PaymentItemDetail.md)
 - [Model.V1PaymentItemization](docs/V1PaymentItemization.md)
 - [Model.V1PaymentModifier](docs/V1PaymentModifier.md)
 - [Model.V1PaymentSurcharge](docs/V1PaymentSurcharge.md)
 - [Model.V1PaymentTax](docs/V1PaymentTax.md)
 - [Model.V1PhoneNumber](docs/V1PhoneNumber.md)
 - [Model.V1Refund](docs/V1Refund.md)
 - [Model.V1Settlement](docs/V1Settlement.md)
 - [Model.V1SettlementEntry](docs/V1SettlementEntry.md)
 - [Model.V1Tender](docs/V1Tender.md)
 - [Model.V1Timecard](docs/V1Timecard.md)
 - [Model.V1TimecardEvent](docs/V1TimecardEvent.md)
 - [Model.V1UpdateModifierListRequest](docs/V1UpdateModifierListRequest.md)
 - [Model.V1UpdateOrderRequest](docs/V1UpdateOrderRequest.md)
 - [Model.V1Variation](docs/V1Variation.md)
 - [Model.VoidTransactionRequest](docs/VoidTransactionRequest.md)
 - [Model.VoidTransactionResponse](docs/VoidTransactionResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth2"></a>
### oauth2

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: `https://connect.squareup.com/oauth2/authorize`
- **Scopes**: 
  - MERCHANT_PROFILE_READ: GET endpoints related to a merchant&#39;s business and location entities. Almost all Connect API applications need this permission in order to obtain a merchant&#39;s location IDs
  - PAYMENTS_READ: GET endpoints related to transactions and refunds
  - PAYMENTS_WRITE: POST, PUT, and DELETE endpoints related to transactions and refunds. E-commerce applications must request this permission
  - CUSTOMERS_READ:  GET endpoints related to customer management
  - CUSTOMERS_WRITE: POST, PUT, and DELETE endpoints related to customer management
  - SETTLEMENTS_READ: GET endpoints related to settlements (deposits)
  - BANK_ACCOUNTS_READ: GET endpoints related to a merchant&#39;s bank accounts
  - ITEMS_READ: GET endpoints related to a merchant&#39;s item library
  - ITEMS_WRITE: POST, PUT, and DELETE endpoints related to a merchant&#39;s item library
  - ORDERS_READ: GET endpoints related to a merchant&#39;s orders
  - ORDERS_WRITE: POST, PUT, and DELETE endpoints related to a merchant&#39;s orders
  - EMPLOYEES_READ: GET endpoints related to employee management
  - EMPLOYEES_WRITE: POST, PUT, and DELETE endpoints related to employee management
  - TIMECARDS_READ: GET endpoints related to employee timecards
  - TIMECARDS_WRITE: POST, PUT, and DELETE endpoints related to employee timecards
  - PAYMENTS_WRITE_ADDITIONAL_RECIPIENTS: Allow third party applications to deduct a portion of each transaction amount.
  - PAYMENTS_WRITE_IN_PERSON: POST, PUT, and DELETE endpoints. Grants write access to transaction and refunds information.

<a name="oauth2ClientSecret"></a>
### oauth2ClientSecret

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header


## Pagination of V1 Endpoints

V1 Endpoints return pagination information via HTTP headers. In order to obtain
response headers and extract the `batch_token` parameter you will need to follow
the following steps:

1. Use the full information endpoint methods of each API to get the ApiResponse object.
They are named as their simple counterpart with a `WithHttpInfo` suffix.
Hence `ListEmployeeRoles` would be called `ListEmployeeRolesWithHttpInfo`. This
method returns an `ApiResponse<List<V1EmployeeRole>>` object.

2. Use `string batchToken = response.BatchToken` to get the token and proceed to
get the following page if a token is present.

### Example

```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

namespace Example
{
    public class ListEmployeeRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new V1EmployeesApi();
            var order = order_example;  // string | The order in which employees are listed in the response, based on their created_at field.Default value: ASC  (optional)
            var limit = 56;  // int? | The maximum integer number of employee entities to return in a single response. Default 100, maximum 200. (optional)
            string batchToken = null;

            try
            {
                do {
                    // Provides summary information for all of a business's employee roles.
                    ApiResponse<List<V1EmployeeRole>> response = apiInstance.ListEmployeeRolesWithHttpInfo(order, limit, batchToken);
                    batchToken = response.BatchToken
                    Debug.WriteLine(response.Data);
                } while (batchToken != null);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling V1EmployeesApi.ListEmployeeRolesWithHttpInfo: " + e.Message );
            }
        }
    }
}
```

## Contributing

Send bug reports, feature requests, and code contributions to the [API
specifications repository](https://github.com/square/connect-api-specification),
as this repository contains only the generated SDK code.

## License

```
Copyright 2017 Square, Inc.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```
