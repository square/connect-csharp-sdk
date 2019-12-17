![Square logo]

# Square Connect .NET SDK Technical Reference

---
## The Square Connect .NET SDK is retired (EOL) as of 2019-12-17 and will no longer receive bug fixes or product updates.
---


[![Build Status](https://travis-ci.org/square/connect-csharp-sdk.svg?branch=master)](https://travis-ci.org/square/connect-csharp-sdk)
[![NuGet version](https://badge.fury.io/nu/Square.Connect.svg)](https://badge.fury.io/nu/Square.Connect)
[![Apache-2 license](https://img.shields.io/badge/license-Apache2-brightgreen.svg)](https://www.apache.org/licenses/LICENSE-2.0)
==================

**If you have feedback about the new SDKs, or just want to talk to other Square Developers, request an invite to the new [slack community for Square Developers](https://squ.re/2GUW1SQ)**

This repository contains the released C# client SDK. Check out our [API
specification repository](https://github.com/square/connect-api-specification)
for the specification and template files we used to generate this.


## Frameworks supported
- .NET Standard 2.0

## Usage
### **Option 1: Obtain from [NuGet package manager](https://www.nuget.org/packages/Square.Connect/) (Recommended)**
```
PM> Install-Package Square.Connect
```

### **Option 2: Generating DLLs from source**

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
        readonly Configuration configuration;
        public Example()
        {
            this.configuration = new Configuration(new ApiClient("https://connect.squareup.com"));
            this.configuration.AccessToken = "YOUR_ACCESS_TOKEN";
        }

        // Retrieving your location IDs
        public void RetrieveLocations()
        {
            LocationsApi _locationsApi = new LocationsApi(this.configuration);
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
            Money money = new Money(amount, currency);

            string nonce = "YOUR_NONCE";
            string locationId = "YOUR_LOCATION_ID";
            CreatePaymentRequest body = new CreatePaymentRequest(SourceId: nonce, IdempotencyKey: idempotencyKey, AmountMoney: money, LocationId: locationId);
            PaymentsApi paymentsApi = new PaymentsApi(this.configuration);
            var response = paymentsApi.CreatePayment(body);
        }
    }
}
```
More examples are available at [connect-api-examples](https://github.com/square/connect-api-examples)

### How to configure sandbox environment
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
        readonly Configuration configuration;
        public Example()
        {
            this.configuration = new Configuration(new ApiClient("https://connect.squareupsandbox.com"));
            this.configuration.AccessToken = "YOUR_SANDBOX_ACCESS_TOKEN";
            LocationsApi locationsApi = new LocationsApi(this.configuration);
        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to [Square Connect Documentation](https://docs.connect.squareup.com/)

Class | Method | HTTP request
------------ | ------------- | -------------
*ApplePayApi* | [**RegisterDomain**](ApplePayApi.md#registerdomain) | **POST** /v2/apple-pay/domains
*CatalogApi* | [**BatchDeleteCatalogObjects**](CatalogApi.md#batchdeletecatalogobjects) | **POST** /v2/catalog/batch-delete
*CatalogApi* | [**BatchRetrieveCatalogObjects**](CatalogApi.md#batchretrievecatalogobjects) | **POST** /v2/catalog/batch-retrieve
*CatalogApi* | [**BatchUpsertCatalogObjects**](CatalogApi.md#batchupsertcatalogobjects) | **POST** /v2/catalog/batch-upsert
*CatalogApi* | [**CatalogInfo**](CatalogApi.md#cataloginfo) | **GET** /v2/catalog/info
*CatalogApi* | [**DeleteCatalogObject**](CatalogApi.md#deletecatalogobject) | **DELETE** /v2/catalog/object/{object_id}
*CatalogApi* | [**ListCatalog**](CatalogApi.md#listcatalog) | **GET** /v2/catalog/list
*CatalogApi* | [**RetrieveCatalogObject**](CatalogApi.md#retrievecatalogobject) | **GET** /v2/catalog/object/{object_id}
*CatalogApi* | [**SearchCatalogObjects**](CatalogApi.md#searchcatalogobjects) | **POST** /v2/catalog/search
*CatalogApi* | [**UpdateItemModifierLists**](CatalogApi.md#updateitemmodifierlists) | **POST** /v2/catalog/update-item-modifier-lists
*CatalogApi* | [**UpdateItemTaxes**](CatalogApi.md#updateitemtaxes) | **POST** /v2/catalog/update-item-taxes
*CatalogApi* | [**UpsertCatalogObject**](CatalogApi.md#upsertcatalogobject) | **POST** /v2/catalog/object
*CheckoutApi* | [**CreateCheckout**](CheckoutApi.md#createcheckout) | **POST** /v2/locations/{location_id}/checkouts
*CustomersApi* | [**CreateCustomer**](CustomersApi.md#createcustomer) | **POST** /v2/customers
*CustomersApi* | [**CreateCustomerCard**](CustomersApi.md#createcustomercard) | **POST** /v2/customers/{customer_id}/cards
*CustomersApi* | [**DeleteCustomer**](CustomersApi.md#deletecustomer) | **DELETE** /v2/customers/{customer_id}
*CustomersApi* | [**DeleteCustomerCard**](CustomersApi.md#deletecustomercard) | **DELETE** /v2/customers/{customer_id}/cards/{card_id}
*CustomersApi* | [**ListCustomers**](CustomersApi.md#listcustomers) | **GET** /v2/customers
*CustomersApi* | [**RetrieveCustomer**](CustomersApi.md#retrievecustomer) | **GET** /v2/customers/{customer_id}
*CustomersApi* | [**SearchCustomers**](CustomersApi.md#searchcustomers) | **POST** /v2/customers/search
*CustomersApi* | [**UpdateCustomer**](CustomersApi.md#updatecustomer) | **PUT** /v2/customers/{customer_id}
*EmployeesApi* | [**ListEmployees**](EmployeesApi.md#listemployees) | **GET** /v2/employees
*EmployeesApi* | [**RetrieveEmployee**](EmployeesApi.md#retrieveemployee) | **GET** /v2/employees/{id}
*InventoryApi* | [**BatchChangeInventory**](InventoryApi.md#batchchangeinventory) | **POST** /v2/inventory/batch-change
*InventoryApi* | [**BatchRetrieveInventoryChanges**](InventoryApi.md#batchretrieveinventorychanges) | **POST** /v2/inventory/batch-retrieve-changes
*InventoryApi* | [**BatchRetrieveInventoryCounts**](InventoryApi.md#batchretrieveinventorycounts) | **POST** /v2/inventory/batch-retrieve-counts
*InventoryApi* | [**RetrieveInventoryAdjustment**](InventoryApi.md#retrieveinventoryadjustment) | **GET** /v2/inventory/adjustment/{adjustment_id}
*InventoryApi* | [**RetrieveInventoryChanges**](InventoryApi.md#retrieveinventorychanges) | **GET** /v2/inventory/{catalog_object_id}/changes
*InventoryApi* | [**RetrieveInventoryCount**](InventoryApi.md#retrieveinventorycount) | **GET** /v2/inventory/{catalog_object_id}
*InventoryApi* | [**RetrieveInventoryPhysicalCount**](InventoryApi.md#retrieveinventoryphysicalcount) | **GET** /v2/inventory/physical-count/{physical_count_id}
*LaborApi* | [**CreateBreakType**](LaborApi.md#createbreaktype) | **POST** /v2/labor/break-types
*LaborApi* | [**CreateShift**](LaborApi.md#createshift) | **POST** /v2/labor/shifts
*LaborApi* | [**DeleteBreakType**](LaborApi.md#deletebreaktype) | **DELETE** /v2/labor/break-types/{id}
*LaborApi* | [**DeleteShift**](LaborApi.md#deleteshift) | **DELETE** /v2/labor/shifts/{id}
*LaborApi* | [**GetBreakType**](LaborApi.md#getbreaktype) | **GET** /v2/labor/break-types/{id}
*LaborApi* | [**GetEmployeeWage**](LaborApi.md#getemployeewage) | **GET** /v2/labor/employee-wages/{id}
*LaborApi* | [**GetShift**](LaborApi.md#getshift) | **GET** /v2/labor/shifts/{id}
*LaborApi* | [**ListBreakTypes**](LaborApi.md#listbreaktypes) | **GET** /v2/labor/break-types
*LaborApi* | [**ListEmployeeWages**](LaborApi.md#listemployeewages) | **GET** /v2/labor/employee-wages
*LaborApi* | [**ListWorkweekConfigs**](LaborApi.md#listworkweekconfigs) | **GET** /v2/labor/workweek-configs
*LaborApi* | [**SearchShifts**](LaborApi.md#searchshifts) | **POST** /v2/labor/shifts/search
*LaborApi* | [**UpdateBreakType**](LaborApi.md#updatebreaktype) | **PUT** /v2/labor/break-types/{id}
*LaborApi* | [**UpdateShift**](LaborApi.md#updateshift) | **PUT** /v2/labor/shifts/{id}
*LaborApi* | [**UpdateWorkweekConfig**](LaborApi.md#updateworkweekconfig) | **PUT** /v2/labor/workweek-configs/{id}
*LocationsApi* | [**CreateLocation**](LocationsApi.md#createlocation) | **POST** /v2/locations
*LocationsApi* | [**ListLocations**](LocationsApi.md#listlocations) | **GET** /v2/locations
*LocationsApi* | [**RetrieveLocation**](LocationsApi.md#retrievelocation) | **GET** /v2/locations/{location_id}
*LocationsApi* | [**UpdateLocation**](LocationsApi.md#updatelocation) | **PUT** /v2/locations/{location_id}
*MerchantsApi* | [**ListMerchants**](MerchantsApi.md#listmerchants) | **GET** /v2/merchants
*MerchantsApi* | [**RetrieveMerchant**](MerchantsApi.md#retrievemerchant) | **GET** /v2/merchants/{merchant_id}
*MobileAuthorizationApi* | [**CreateMobileAuthorizationCode**](MobileAuthorizationApi.md#createmobileauthorizationcode) | **POST** /mobile/authorization-code
*OAuthApi* | [**ObtainToken**](OAuthApi.md#obtaintoken) | **POST** /oauth2/token
*OAuthApi* | [**RenewToken**](OAuthApi.md#renewtoken) | **POST** /oauth2/clients/{client_id}/access-token/renew
*OAuthApi* | [**RevokeToken**](OAuthApi.md#revoketoken) | **POST** /oauth2/revoke
*OrdersApi* | [**BatchRetrieveOrders**](OrdersApi.md#batchretrieveorders) | **POST** /v2/locations/{location_id}/orders/batch-retrieve
*OrdersApi* | [**CreateOrder**](OrdersApi.md#createorder) | **POST** /v2/locations/{location_id}/orders
*OrdersApi* | [**PayOrder**](OrdersApi.md#payorder) | **POST** /v2/orders/{order_id}/pay
*OrdersApi* | [**SearchOrders**](OrdersApi.md#searchorders) | **POST** /v2/orders/search
*OrdersApi* | [**UpdateOrder**](OrdersApi.md#updateorder) | **PUT** /v2/locations/{location_id}/orders/{order_id}
*PaymentsApi* | [**CancelPayment**](PaymentsApi.md#cancelpayment) | **POST** /v2/payments/{payment_id}/cancel
*PaymentsApi* | [**CancelPaymentByIdempotencyKey**](PaymentsApi.md#cancelpaymentbyidempotencykey) | **POST** /v2/payments/cancel
*PaymentsApi* | [**CompletePayment**](PaymentsApi.md#completepayment) | **POST** /v2/payments/{payment_id}/complete
*PaymentsApi* | [**CreatePayment**](PaymentsApi.md#createpayment) | **POST** /v2/payments
*PaymentsApi* | [**GetPayment**](PaymentsApi.md#getpayment) | **GET** /v2/payments/{payment_id}
*PaymentsApi* | [**ListPayments**](PaymentsApi.md#listpayments) | **GET** /v2/payments
*RefundsApi* | [**GetPaymentRefund**](RefundsApi.md#getpaymentrefund) | **GET** /v2/refunds/{refund_id}
*RefundsApi* | [**ListPaymentRefunds**](RefundsApi.md#listpaymentrefunds) | **GET** /v2/refunds
*RefundsApi* | [**RefundPayment**](RefundsApi.md#refundpayment) | **POST** /v2/refunds
*ReportingApi* | [**ListAdditionalRecipientReceivableRefunds**](ReportingApi.md#listadditionalrecipientreceivablerefunds) | **GET** /v2/locations/{location_id}/additional-recipient-receivable-refunds
*ReportingApi* | [**ListAdditionalRecipientReceivables**](ReportingApi.md#listadditionalrecipientreceivables) | **GET** /v2/locations/{location_id}/additional-recipient-receivables
*TransactionsApi* | [**CaptureTransaction**](TransactionsApi.md#capturetransaction) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/capture
*TransactionsApi* | [**Charge**](TransactionsApi.md#charge) | **POST** /v2/locations/{location_id}/transactions
*TransactionsApi* | [**CreateRefund**](TransactionsApi.md#createrefund) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/refund
*TransactionsApi* | [**ListRefunds**](TransactionsApi.md#listrefunds) | **GET** /v2/locations/{location_id}/refunds
*TransactionsApi* | [**ListTransactions**](TransactionsApi.md#listtransactions) | **GET** /v2/locations/{location_id}/transactions
*TransactionsApi* | [**RetrieveTransaction**](TransactionsApi.md#retrievetransaction) | **GET** /v2/locations/{location_id}/transactions/{transaction_id}
*TransactionsApi* | [**VoidTransaction**](TransactionsApi.md#voidtransaction) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/void
*V1EmployeesApi* | [**CreateEmployee**](V1EmployeesApi.md#createemployee) | **POST** /v1/me/employees
*V1EmployeesApi* | [**CreateEmployeeRole**](V1EmployeesApi.md#createemployeerole) | **POST** /v1/me/roles
*V1EmployeesApi* | [**CreateTimecard**](V1EmployeesApi.md#createtimecard) | **POST** /v1/me/timecards
*V1EmployeesApi* | [**DeleteTimecard**](V1EmployeesApi.md#deletetimecard) | **DELETE** /v1/me/timecards/{timecard_id}
*V1EmployeesApi* | [**ListCashDrawerShifts**](V1EmployeesApi.md#listcashdrawershifts) | **GET** /v1/{location_id}/cash-drawer-shifts
*V1EmployeesApi* | [**ListEmployeeRoles**](V1EmployeesApi.md#listemployeeroles) | **GET** /v1/me/roles
*V1EmployeesApi* | [**ListEmployees**](V1EmployeesApi.md#listemployees) | **GET** /v1/me/employees
*V1EmployeesApi* | [**ListTimecardEvents**](V1EmployeesApi.md#listtimecardevents) | **GET** /v1/me/timecards/{timecard_id}/events
*V1EmployeesApi* | [**ListTimecards**](V1EmployeesApi.md#listtimecards) | **GET** /v1/me/timecards
*V1EmployeesApi* | [**RetrieveCashDrawerShift**](V1EmployeesApi.md#retrievecashdrawershift) | **GET** /v1/{location_id}/cash-drawer-shifts/{shift_id}
*V1EmployeesApi* | [**RetrieveEmployee**](V1EmployeesApi.md#retrieveemployee) | **GET** /v1/me/employees/{employee_id}
*V1EmployeesApi* | [**RetrieveEmployeeRole**](V1EmployeesApi.md#retrieveemployeerole) | **GET** /v1/me/roles/{role_id}
*V1EmployeesApi* | [**RetrieveTimecard**](V1EmployeesApi.md#retrievetimecard) | **GET** /v1/me/timecards/{timecard_id}
*V1EmployeesApi* | [**UpdateEmployee**](V1EmployeesApi.md#updateemployee) | **PUT** /v1/me/employees/{employee_id}
*V1EmployeesApi* | [**UpdateEmployeeRole**](V1EmployeesApi.md#updateemployeerole) | **PUT** /v1/me/roles/{role_id}
*V1EmployeesApi* | [**UpdateTimecard**](V1EmployeesApi.md#updatetimecard) | **PUT** /v1/me/timecards/{timecard_id}
*V1ItemsApi* | [**AdjustInventory**](V1ItemsApi.md#adjustinventory) | **POST** /v1/{location_id}/inventory/{variation_id}
*V1ItemsApi* | [**ApplyFee**](V1ItemsApi.md#applyfee) | **PUT** /v1/{location_id}/items/{item_id}/fees/{fee_id}
*V1ItemsApi* | [**ApplyModifierList**](V1ItemsApi.md#applymodifierlist) | **PUT** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id}
*V1ItemsApi* | [**CreateCategory**](V1ItemsApi.md#createcategory) | **POST** /v1/{location_id}/categories
*V1ItemsApi* | [**CreateDiscount**](V1ItemsApi.md#creatediscount) | **POST** /v1/{location_id}/discounts
*V1ItemsApi* | [**CreateFee**](V1ItemsApi.md#createfee) | **POST** /v1/{location_id}/fees
*V1ItemsApi* | [**CreateItem**](V1ItemsApi.md#createitem) | **POST** /v1/{location_id}/items
*V1ItemsApi* | [**CreateModifierList**](V1ItemsApi.md#createmodifierlist) | **POST** /v1/{location_id}/modifier-lists
*V1ItemsApi* | [**CreateModifierOption**](V1ItemsApi.md#createmodifieroption) | **POST** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options
*V1ItemsApi* | [**CreatePage**](V1ItemsApi.md#createpage) | **POST** /v1/{location_id}/pages
*V1ItemsApi* | [**CreateVariation**](V1ItemsApi.md#createvariation) | **POST** /v1/{location_id}/items/{item_id}/variations
*V1ItemsApi* | [**DeleteCategory**](V1ItemsApi.md#deletecategory) | **DELETE** /v1/{location_id}/categories/{category_id}
*V1ItemsApi* | [**DeleteDiscount**](V1ItemsApi.md#deletediscount) | **DELETE** /v1/{location_id}/discounts/{discount_id}
*V1ItemsApi* | [**DeleteFee**](V1ItemsApi.md#deletefee) | **DELETE** /v1/{location_id}/fees/{fee_id}
*V1ItemsApi* | [**DeleteItem**](V1ItemsApi.md#deleteitem) | **DELETE** /v1/{location_id}/items/{item_id}
*V1ItemsApi* | [**DeleteModifierList**](V1ItemsApi.md#deletemodifierlist) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id}
*V1ItemsApi* | [**DeleteModifierOption**](V1ItemsApi.md#deletemodifieroption) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id}
*V1ItemsApi* | [**DeletePage**](V1ItemsApi.md#deletepage) | **DELETE** /v1/{location_id}/pages/{page_id}
*V1ItemsApi* | [**DeletePageCell**](V1ItemsApi.md#deletepagecell) | **DELETE** /v1/{location_id}/pages/{page_id}/cells
*V1ItemsApi* | [**DeleteVariation**](V1ItemsApi.md#deletevariation) | **DELETE** /v1/{location_id}/items/{item_id}/variations/{variation_id}
*V1ItemsApi* | [**ListCategories**](V1ItemsApi.md#listcategories) | **GET** /v1/{location_id}/categories
*V1ItemsApi* | [**ListDiscounts**](V1ItemsApi.md#listdiscounts) | **GET** /v1/{location_id}/discounts
*V1ItemsApi* | [**ListFees**](V1ItemsApi.md#listfees) | **GET** /v1/{location_id}/fees
*V1ItemsApi* | [**ListInventory**](V1ItemsApi.md#listinventory) | **GET** /v1/{location_id}/inventory
*V1ItemsApi* | [**ListItems**](V1ItemsApi.md#listitems) | **GET** /v1/{location_id}/items
*V1ItemsApi* | [**ListModifierLists**](V1ItemsApi.md#listmodifierlists) | **GET** /v1/{location_id}/modifier-lists
*V1ItemsApi* | [**ListPages**](V1ItemsApi.md#listpages) | **GET** /v1/{location_id}/pages
*V1ItemsApi* | [**RemoveFee**](V1ItemsApi.md#removefee) | **DELETE** /v1/{location_id}/items/{item_id}/fees/{fee_id}
*V1ItemsApi* | [**RemoveModifierList**](V1ItemsApi.md#removemodifierlist) | **DELETE** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id}
*V1ItemsApi* | [**RetrieveItem**](V1ItemsApi.md#retrieveitem) | **GET** /v1/{location_id}/items/{item_id}
*V1ItemsApi* | [**RetrieveModifierList**](V1ItemsApi.md#retrievemodifierlist) | **GET** /v1/{location_id}/modifier-lists/{modifier_list_id}
*V1ItemsApi* | [**UpdateCategory**](V1ItemsApi.md#updatecategory) | **PUT** /v1/{location_id}/categories/{category_id}
*V1ItemsApi* | [**UpdateDiscount**](V1ItemsApi.md#updatediscount) | **PUT** /v1/{location_id}/discounts/{discount_id}
*V1ItemsApi* | [**UpdateFee**](V1ItemsApi.md#updatefee) | **PUT** /v1/{location_id}/fees/{fee_id}
*V1ItemsApi* | [**UpdateItem**](V1ItemsApi.md#updateitem) | **PUT** /v1/{location_id}/items/{item_id}
*V1ItemsApi* | [**UpdateModifierList**](V1ItemsApi.md#updatemodifierlist) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id}
*V1ItemsApi* | [**UpdateModifierOption**](V1ItemsApi.md#updatemodifieroption) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id}
*V1ItemsApi* | [**UpdatePage**](V1ItemsApi.md#updatepage) | **PUT** /v1/{location_id}/pages/{page_id}
*V1ItemsApi* | [**UpdatePageCell**](V1ItemsApi.md#updatepagecell) | **PUT** /v1/{location_id}/pages/{page_id}/cells
*V1ItemsApi* | [**UpdateVariation**](V1ItemsApi.md#updatevariation) | **PUT** /v1/{location_id}/items/{item_id}/variations/{variation_id}
*V1LocationsApi* | [**ListLocations**](V1LocationsApi.md#listlocations) | **GET** /v1/me/locations
*V1LocationsApi* | [**RetrieveBusiness**](V1LocationsApi.md#retrievebusiness) | **GET** /v1/me
*V1TransactionsApi* | [**CreateRefund**](V1TransactionsApi.md#createrefund) | **POST** /v1/{location_id}/refunds
*V1TransactionsApi* | [**ListBankAccounts**](V1TransactionsApi.md#listbankaccounts) | **GET** /v1/{location_id}/bank-accounts
*V1TransactionsApi* | [**ListOrders**](V1TransactionsApi.md#listorders) | **GET** /v1/{location_id}/orders
*V1TransactionsApi* | [**ListPayments**](V1TransactionsApi.md#listpayments) | **GET** /v1/{location_id}/payments
*V1TransactionsApi* | [**ListRefunds**](V1TransactionsApi.md#listrefunds) | **GET** /v1/{location_id}/refunds
*V1TransactionsApi* | [**ListSettlements**](V1TransactionsApi.md#listsettlements) | **GET** /v1/{location_id}/settlements
*V1TransactionsApi* | [**RetrieveBankAccount**](V1TransactionsApi.md#retrievebankaccount) | **GET** /v1/{location_id}/bank-accounts/{bank_account_id}
*V1TransactionsApi* | [**RetrieveOrder**](V1TransactionsApi.md#retrieveorder) | **GET** /v1/{location_id}/orders/{order_id}
*V1TransactionsApi* | [**RetrievePayment**](V1TransactionsApi.md#retrievepayment) | **GET** /v1/{location_id}/payments/{payment_id}
*V1TransactionsApi* | [**RetrieveSettlement**](V1TransactionsApi.md#retrievesettlement) | **GET** /v1/{location_id}/settlements/{settlement_id}
*V1TransactionsApi* | [**UpdateOrder**](V1TransactionsApi.md#updateorder) | **PUT** /v1/{location_id}/orders/{order_id}


## Documentation for Models

 - [Model.AdditionalRecipient](AdditionalRecipient.md)
 - [Model.AdditionalRecipientReceivable](AdditionalRecipientReceivable.md)
 - [Model.AdditionalRecipientReceivableRefund](AdditionalRecipientReceivableRefund.md)
 - [Model.Address](Address.md)
 - [Model.BalancePaymentDetails](BalancePaymentDetails.md)
 - [Model.BatchChangeInventoryRequest](BatchChangeInventoryRequest.md)
 - [Model.BatchChangeInventoryResponse](BatchChangeInventoryResponse.md)
 - [Model.BatchDeleteCatalogObjectsRequest](BatchDeleteCatalogObjectsRequest.md)
 - [Model.BatchDeleteCatalogObjectsResponse](BatchDeleteCatalogObjectsResponse.md)
 - [Model.BatchRetrieveCatalogObjectsRequest](BatchRetrieveCatalogObjectsRequest.md)
 - [Model.BatchRetrieveCatalogObjectsResponse](BatchRetrieveCatalogObjectsResponse.md)
 - [Model.BatchRetrieveInventoryChangesRequest](BatchRetrieveInventoryChangesRequest.md)
 - [Model.BatchRetrieveInventoryChangesResponse](BatchRetrieveInventoryChangesResponse.md)
 - [Model.BatchRetrieveInventoryCountsRequest](BatchRetrieveInventoryCountsRequest.md)
 - [Model.BatchRetrieveInventoryCountsResponse](BatchRetrieveInventoryCountsResponse.md)
 - [Model.BatchRetrieveOrdersRequest](BatchRetrieveOrdersRequest.md)
 - [Model.BatchRetrieveOrdersResponse](BatchRetrieveOrdersResponse.md)
 - [Model.BatchUpsertCatalogObjectsRequest](BatchUpsertCatalogObjectsRequest.md)
 - [Model.BatchUpsertCatalogObjectsResponse](BatchUpsertCatalogObjectsResponse.md)
 - [Model.BreakType](BreakType.md)
 - [Model.BusinessHours](BusinessHours.md)
 - [Model.BusinessHoursPeriod](BusinessHoursPeriod.md)
 - [Model.CancelPaymentByIdempotencyKeyRequest](CancelPaymentByIdempotencyKeyRequest.md)
 - [Model.CancelPaymentByIdempotencyKeyResponse](CancelPaymentByIdempotencyKeyResponse.md)
 - [Model.CancelPaymentRequest](CancelPaymentRequest.md)
 - [Model.CancelPaymentResponse](CancelPaymentResponse.md)
 - [Model.CaptureTransactionRequest](CaptureTransactionRequest.md)
 - [Model.CaptureTransactionResponse](CaptureTransactionResponse.md)
 - [Model.Card](Card.md)
 - [Model.CardPaymentDetails](CardPaymentDetails.md)
 - [Model.CashPaymentDetails](CashPaymentDetails.md)
 - [Model.CatalogCategory](CatalogCategory.md)
 - [Model.CatalogDiscount](CatalogDiscount.md)
 - [Model.CatalogIdMapping](CatalogIdMapping.md)
 - [Model.CatalogImage](CatalogImage.md)
 - [Model.CatalogInfoRequest](CatalogInfoRequest.md)
 - [Model.CatalogInfoResponse](CatalogInfoResponse.md)
 - [Model.CatalogInfoResponseLimits](CatalogInfoResponseLimits.md)
 - [Model.CatalogItem](CatalogItem.md)
 - [Model.CatalogItemModifierListInfo](CatalogItemModifierListInfo.md)
 - [Model.CatalogItemOption](CatalogItemOption.md)
 - [Model.CatalogItemOptionForItem](CatalogItemOptionForItem.md)
 - [Model.CatalogItemOptionValue](CatalogItemOptionValue.md)
 - [Model.CatalogItemOptionValueForItemVariation](CatalogItemOptionValueForItemVariation.md)
 - [Model.CatalogItemVariation](CatalogItemVariation.md)
 - [Model.CatalogMeasurementUnit](CatalogMeasurementUnit.md)
 - [Model.CatalogModifier](CatalogModifier.md)
 - [Model.CatalogModifierList](CatalogModifierList.md)
 - [Model.CatalogModifierOverride](CatalogModifierOverride.md)
 - [Model.CatalogObject](CatalogObject.md)
 - [Model.CatalogObjectBatch](CatalogObjectBatch.md)
 - [Model.CatalogPricingRule](CatalogPricingRule.md)
 - [Model.CatalogProductSet](CatalogProductSet.md)
 - [Model.CatalogQuery](CatalogQuery.md)
 - [Model.CatalogQueryCustomAttributeUsage](CatalogQueryCustomAttributeUsage.md)
 - [Model.CatalogQueryExact](CatalogQueryExact.md)
 - [Model.CatalogQueryFilteredItems](CatalogQueryFilteredItems.md)
 - [Model.CatalogQueryFilteredItemsCustomAttributeFilter](CatalogQueryFilteredItemsCustomAttributeFilter.md)
 - [Model.CatalogQueryItemVariationsForItemOptionValues](CatalogQueryItemVariationsForItemOptionValues.md)
 - [Model.CatalogQueryItemsForItemOptions](CatalogQueryItemsForItemOptions.md)
 - [Model.CatalogQueryItemsForModifierList](CatalogQueryItemsForModifierList.md)
 - [Model.CatalogQueryItemsForTax](CatalogQueryItemsForTax.md)
 - [Model.CatalogQueryPrefix](CatalogQueryPrefix.md)
 - [Model.CatalogQueryRange](CatalogQueryRange.md)
 - [Model.CatalogQuerySortedAttribute](CatalogQuerySortedAttribute.md)
 - [Model.CatalogQueryText](CatalogQueryText.md)
 - [Model.CatalogTax](CatalogTax.md)
 - [Model.CatalogTimePeriod](CatalogTimePeriod.md)
 - [Model.CatalogV1Id](CatalogV1Id.md)
 - [Model.ChargeRequest](ChargeRequest.md)
 - [Model.ChargeRequestAdditionalRecipient](ChargeRequestAdditionalRecipient.md)
 - [Model.ChargeResponse](ChargeResponse.md)
 - [Model.Checkout](Checkout.md)
 - [Model.CompletePaymentRequest](CompletePaymentRequest.md)
 - [Model.CompletePaymentResponse](CompletePaymentResponse.md)
 - [Model.Coordinates](Coordinates.md)
 - [Model.CreateBreakTypeRequest](CreateBreakTypeRequest.md)
 - [Model.CreateBreakTypeResponse](CreateBreakTypeResponse.md)
 - [Model.CreateCatalogImageRequest](CreateCatalogImageRequest.md)
 - [Model.CreateCatalogImageResponse](CreateCatalogImageResponse.md)
 - [Model.CreateCheckoutRequest](CreateCheckoutRequest.md)
 - [Model.CreateCheckoutResponse](CreateCheckoutResponse.md)
 - [Model.CreateCustomerCardRequest](CreateCustomerCardRequest.md)
 - [Model.CreateCustomerCardResponse](CreateCustomerCardResponse.md)
 - [Model.CreateCustomerRequest](CreateCustomerRequest.md)
 - [Model.CreateCustomerResponse](CreateCustomerResponse.md)
 - [Model.CreateLocationRequest](CreateLocationRequest.md)
 - [Model.CreateLocationResponse](CreateLocationResponse.md)
 - [Model.CreateMobileAuthorizationCodeRequest](CreateMobileAuthorizationCodeRequest.md)
 - [Model.CreateMobileAuthorizationCodeResponse](CreateMobileAuthorizationCodeResponse.md)
 - [Model.CreateOrderRequest](CreateOrderRequest.md)
 - [Model.CreateOrderRequestDiscount](CreateOrderRequestDiscount.md)
 - [Model.CreateOrderRequestLineItem](CreateOrderRequestLineItem.md)
 - [Model.CreateOrderRequestModifier](CreateOrderRequestModifier.md)
 - [Model.CreateOrderRequestTax](CreateOrderRequestTax.md)
 - [Model.CreateOrderResponse](CreateOrderResponse.md)
 - [Model.CreatePaymentRequest](CreatePaymentRequest.md)
 - [Model.CreatePaymentResponse](CreatePaymentResponse.md)
 - [Model.CreateRefundRequest](CreateRefundRequest.md)
 - [Model.CreateRefundResponse](CreateRefundResponse.md)
 - [Model.CreateShiftRequest](CreateShiftRequest.md)
 - [Model.CreateShiftResponse](CreateShiftResponse.md)
 - [Model.Customer](Customer.md)
 - [Model.CustomerCreationSourceFilter](CustomerCreationSourceFilter.md)
 - [Model.CustomerFilter](CustomerFilter.md)
 - [Model.CustomerGroupInfo](CustomerGroupInfo.md)
 - [Model.CustomerPreferences](CustomerPreferences.md)
 - [Model.CustomerQuery](CustomerQuery.md)
 - [Model.CustomerSort](CustomerSort.md)
 - [Model.DateRange](DateRange.md)
 - [Model.DeleteBreakTypeRequest](DeleteBreakTypeRequest.md)
 - [Model.DeleteBreakTypeResponse](DeleteBreakTypeResponse.md)
 - [Model.DeleteCatalogObjectRequest](DeleteCatalogObjectRequest.md)
 - [Model.DeleteCatalogObjectResponse](DeleteCatalogObjectResponse.md)
 - [Model.DeleteCustomerCardRequest](DeleteCustomerCardRequest.md)
 - [Model.DeleteCustomerCardResponse](DeleteCustomerCardResponse.md)
 - [Model.DeleteCustomerRequest](DeleteCustomerRequest.md)
 - [Model.DeleteCustomerResponse](DeleteCustomerResponse.md)
 - [Model.DeleteShiftRequest](DeleteShiftRequest.md)
 - [Model.DeleteShiftResponse](DeleteShiftResponse.md)
 - [Model.Device](Device.md)
 - [Model.Employee](Employee.md)
 - [Model.EmployeeWage](EmployeeWage.md)
 - [Model.Error](Error.md)
 - [Model.ExternalPaymentDetails](ExternalPaymentDetails.md)
 - [Model.GetBreakTypeRequest](GetBreakTypeRequest.md)
 - [Model.GetBreakTypeResponse](GetBreakTypeResponse.md)
 - [Model.GetEmployeeWageRequest](GetEmployeeWageRequest.md)
 - [Model.GetEmployeeWageResponse](GetEmployeeWageResponse.md)
 - [Model.GetPaymentRefundRequest](GetPaymentRefundRequest.md)
 - [Model.GetPaymentRefundResponse](GetPaymentRefundResponse.md)
 - [Model.GetPaymentRequest](GetPaymentRequest.md)
 - [Model.GetPaymentResponse](GetPaymentResponse.md)
 - [Model.GetShiftRequest](GetShiftRequest.md)
 - [Model.GetShiftResponse](GetShiftResponse.md)
 - [Model.InventoryAdjustment](InventoryAdjustment.md)
 - [Model.InventoryChange](InventoryChange.md)
 - [Model.InventoryCount](InventoryCount.md)
 - [Model.InventoryPhysicalCount](InventoryPhysicalCount.md)
 - [Model.InventoryTransfer](InventoryTransfer.md)
 - [Model.ItemVariationLocationOverrides](ItemVariationLocationOverrides.md)
 - [Model.ListAdditionalRecipientReceivableRefundsRequest](ListAdditionalRecipientReceivableRefundsRequest.md)
 - [Model.ListAdditionalRecipientReceivableRefundsResponse](ListAdditionalRecipientReceivableRefundsResponse.md)
 - [Model.ListAdditionalRecipientReceivablesRequest](ListAdditionalRecipientReceivablesRequest.md)
 - [Model.ListAdditionalRecipientReceivablesResponse](ListAdditionalRecipientReceivablesResponse.md)
 - [Model.ListBreakTypesRequest](ListBreakTypesRequest.md)
 - [Model.ListBreakTypesResponse](ListBreakTypesResponse.md)
 - [Model.ListCatalogRequest](ListCatalogRequest.md)
 - [Model.ListCatalogResponse](ListCatalogResponse.md)
 - [Model.ListCustomersRequest](ListCustomersRequest.md)
 - [Model.ListCustomersResponse](ListCustomersResponse.md)
 - [Model.ListEmployeeWagesRequest](ListEmployeeWagesRequest.md)
 - [Model.ListEmployeeWagesResponse](ListEmployeeWagesResponse.md)
 - [Model.ListEmployeesRequest](ListEmployeesRequest.md)
 - [Model.ListEmployeesResponse](ListEmployeesResponse.md)
 - [Model.ListLocationsRequest](ListLocationsRequest.md)
 - [Model.ListLocationsResponse](ListLocationsResponse.md)
 - [Model.ListMerchantsRequest](ListMerchantsRequest.md)
 - [Model.ListMerchantsResponse](ListMerchantsResponse.md)
 - [Model.ListPaymentRefundsRequest](ListPaymentRefundsRequest.md)
 - [Model.ListPaymentRefundsResponse](ListPaymentRefundsResponse.md)
 - [Model.ListPaymentsRequest](ListPaymentsRequest.md)
 - [Model.ListPaymentsResponse](ListPaymentsResponse.md)
 - [Model.ListRefundsRequest](ListRefundsRequest.md)
 - [Model.ListRefundsResponse](ListRefundsResponse.md)
 - [Model.ListTransactionsRequest](ListTransactionsRequest.md)
 - [Model.ListTransactionsResponse](ListTransactionsResponse.md)
 - [Model.ListWorkweekConfigsRequest](ListWorkweekConfigsRequest.md)
 - [Model.ListWorkweekConfigsResponse](ListWorkweekConfigsResponse.md)
 - [Model.Location](Location.md)
 - [Model.MeasurementUnit](MeasurementUnit.md)
 - [Model.MeasurementUnitCustom](MeasurementUnitCustom.md)
 - [Model.Merchant](Merchant.md)
 - [Model.ModelBreak](ModelBreak.md)
 - [Model.Money](Money.md)
 - [Model.ObtainTokenRequest](ObtainTokenRequest.md)
 - [Model.ObtainTokenResponse](ObtainTokenResponse.md)
 - [Model.Order](Order.md)
 - [Model.OrderEntry](OrderEntry.md)
 - [Model.OrderFulfillment](OrderFulfillment.md)
 - [Model.OrderFulfillmentPickupDetails](OrderFulfillmentPickupDetails.md)
 - [Model.OrderFulfillmentRecipient](OrderFulfillmentRecipient.md)
 - [Model.OrderFulfillmentShipmentDetails](OrderFulfillmentShipmentDetails.md)
 - [Model.OrderLineItem](OrderLineItem.md)
 - [Model.OrderLineItemAppliedDiscount](OrderLineItemAppliedDiscount.md)
 - [Model.OrderLineItemAppliedTax](OrderLineItemAppliedTax.md)
 - [Model.OrderLineItemDiscount](OrderLineItemDiscount.md)
 - [Model.OrderLineItemModifier](OrderLineItemModifier.md)
 - [Model.OrderLineItemTax](OrderLineItemTax.md)
 - [Model.OrderMoneyAmounts](OrderMoneyAmounts.md)
 - [Model.OrderQuantityUnit](OrderQuantityUnit.md)
 - [Model.OrderReturn](OrderReturn.md)
 - [Model.OrderReturnDiscount](OrderReturnDiscount.md)
 - [Model.OrderReturnLineItem](OrderReturnLineItem.md)
 - [Model.OrderReturnLineItemModifier](OrderReturnLineItemModifier.md)
 - [Model.OrderReturnServiceCharge](OrderReturnServiceCharge.md)
 - [Model.OrderReturnTax](OrderReturnTax.md)
 - [Model.OrderRoundingAdjustment](OrderRoundingAdjustment.md)
 - [Model.OrderServiceCharge](OrderServiceCharge.md)
 - [Model.OrderSource](OrderSource.md)
 - [Model.PayOrderRequest](PayOrderRequest.md)
 - [Model.PayOrderResponse](PayOrderResponse.md)
 - [Model.Payment](Payment.md)
 - [Model.PaymentRefund](PaymentRefund.md)
 - [Model.ProcessingFee](ProcessingFee.md)
 - [Model.Refund](Refund.md)
 - [Model.RefundPaymentRequest](RefundPaymentRequest.md)
 - [Model.RefundPaymentResponse](RefundPaymentResponse.md)
 - [Model.RegisterDomainRequest](RegisterDomainRequest.md)
 - [Model.RegisterDomainResponse](RegisterDomainResponse.md)
 - [Model.RenewTokenRequest](RenewTokenRequest.md)
 - [Model.RenewTokenResponse](RenewTokenResponse.md)
 - [Model.RetrieveCatalogObjectRequest](RetrieveCatalogObjectRequest.md)
 - [Model.RetrieveCatalogObjectResponse](RetrieveCatalogObjectResponse.md)
 - [Model.RetrieveCustomerRequest](RetrieveCustomerRequest.md)
 - [Model.RetrieveCustomerResponse](RetrieveCustomerResponse.md)
 - [Model.RetrieveEmployeeRequest](RetrieveEmployeeRequest.md)
 - [Model.RetrieveEmployeeResponse](RetrieveEmployeeResponse.md)
 - [Model.RetrieveInventoryAdjustmentRequest](RetrieveInventoryAdjustmentRequest.md)
 - [Model.RetrieveInventoryAdjustmentResponse](RetrieveInventoryAdjustmentResponse.md)
 - [Model.RetrieveInventoryChangesRequest](RetrieveInventoryChangesRequest.md)
 - [Model.RetrieveInventoryChangesResponse](RetrieveInventoryChangesResponse.md)
 - [Model.RetrieveInventoryCountRequest](RetrieveInventoryCountRequest.md)
 - [Model.RetrieveInventoryCountResponse](RetrieveInventoryCountResponse.md)
 - [Model.RetrieveInventoryPhysicalCountRequest](RetrieveInventoryPhysicalCountRequest.md)
 - [Model.RetrieveInventoryPhysicalCountResponse](RetrieveInventoryPhysicalCountResponse.md)
 - [Model.RetrieveLocationRequest](RetrieveLocationRequest.md)
 - [Model.RetrieveLocationResponse](RetrieveLocationResponse.md)
 - [Model.RetrieveMerchantRequest](RetrieveMerchantRequest.md)
 - [Model.RetrieveMerchantResponse](RetrieveMerchantResponse.md)
 - [Model.RetrieveTransactionRequest](RetrieveTransactionRequest.md)
 - [Model.RetrieveTransactionResponse](RetrieveTransactionResponse.md)
 - [Model.RevokeTokenRequest](RevokeTokenRequest.md)
 - [Model.RevokeTokenResponse](RevokeTokenResponse.md)
 - [Model.SearchCatalogObjectsRequest](SearchCatalogObjectsRequest.md)
 - [Model.SearchCatalogObjectsResponse](SearchCatalogObjectsResponse.md)
 - [Model.SearchCustomersRequest](SearchCustomersRequest.md)
 - [Model.SearchCustomersResponse](SearchCustomersResponse.md)
 - [Model.SearchOrdersCustomerFilter](SearchOrdersCustomerFilter.md)
 - [Model.SearchOrdersDateTimeFilter](SearchOrdersDateTimeFilter.md)
 - [Model.SearchOrdersFilter](SearchOrdersFilter.md)
 - [Model.SearchOrdersFulfillmentFilter](SearchOrdersFulfillmentFilter.md)
 - [Model.SearchOrdersQuery](SearchOrdersQuery.md)
 - [Model.SearchOrdersRequest](SearchOrdersRequest.md)
 - [Model.SearchOrdersResponse](SearchOrdersResponse.md)
 - [Model.SearchOrdersSort](SearchOrdersSort.md)
 - [Model.SearchOrdersSourceFilter](SearchOrdersSourceFilter.md)
 - [Model.SearchOrdersStateFilter](SearchOrdersStateFilter.md)
 - [Model.SearchShiftsRequest](SearchShiftsRequest.md)
 - [Model.SearchShiftsResponse](SearchShiftsResponse.md)
 - [Model.Shift](Shift.md)
 - [Model.ShiftFilter](ShiftFilter.md)
 - [Model.ShiftQuery](ShiftQuery.md)
 - [Model.ShiftSort](ShiftSort.md)
 - [Model.ShiftWage](ShiftWage.md)
 - [Model.ShiftWorkday](ShiftWorkday.md)
 - [Model.SourceApplication](SourceApplication.md)
 - [Model.StandardUnitDescription](StandardUnitDescription.md)
 - [Model.StandardUnitDescriptionGroup](StandardUnitDescriptionGroup.md)
 - [Model.Tender](Tender.md)
 - [Model.TenderCardDetails](TenderCardDetails.md)
 - [Model.TenderCashDetails](TenderCashDetails.md)
 - [Model.TimeRange](TimeRange.md)
 - [Model.Transaction](Transaction.md)
 - [Model.UpdateBreakTypeRequest](UpdateBreakTypeRequest.md)
 - [Model.UpdateBreakTypeResponse](UpdateBreakTypeResponse.md)
 - [Model.UpdateCustomerRequest](UpdateCustomerRequest.md)
 - [Model.UpdateCustomerResponse](UpdateCustomerResponse.md)
 - [Model.UpdateItemModifierListsRequest](UpdateItemModifierListsRequest.md)
 - [Model.UpdateItemModifierListsResponse](UpdateItemModifierListsResponse.md)
 - [Model.UpdateItemTaxesRequest](UpdateItemTaxesRequest.md)
 - [Model.UpdateItemTaxesResponse](UpdateItemTaxesResponse.md)
 - [Model.UpdateLocationRequest](UpdateLocationRequest.md)
 - [Model.UpdateLocationResponse](UpdateLocationResponse.md)
 - [Model.UpdateOrderRequest](UpdateOrderRequest.md)
 - [Model.UpdateOrderResponse](UpdateOrderResponse.md)
 - [Model.UpdateShiftRequest](UpdateShiftRequest.md)
 - [Model.UpdateShiftResponse](UpdateShiftResponse.md)
 - [Model.UpdateWorkweekConfigRequest](UpdateWorkweekConfigRequest.md)
 - [Model.UpdateWorkweekConfigResponse](UpdateWorkweekConfigResponse.md)
 - [Model.UpsertCatalogObjectRequest](UpsertCatalogObjectRequest.md)
 - [Model.UpsertCatalogObjectResponse](UpsertCatalogObjectResponse.md)
 - [Model.V1AdjustInventoryRequest](V1AdjustInventoryRequest.md)
 - [Model.V1ApplyFeeRequest](V1ApplyFeeRequest.md)
 - [Model.V1ApplyModifierListRequest](V1ApplyModifierListRequest.md)
 - [Model.V1BankAccount](V1BankAccount.md)
 - [Model.V1CashDrawerEvent](V1CashDrawerEvent.md)
 - [Model.V1CashDrawerShift](V1CashDrawerShift.md)
 - [Model.V1Category](V1Category.md)
 - [Model.V1CreateCategoryRequest](V1CreateCategoryRequest.md)
 - [Model.V1CreateDiscountRequest](V1CreateDiscountRequest.md)
 - [Model.V1CreateEmployeeRoleRequest](V1CreateEmployeeRoleRequest.md)
 - [Model.V1CreateFeeRequest](V1CreateFeeRequest.md)
 - [Model.V1CreateItemRequest](V1CreateItemRequest.md)
 - [Model.V1CreateModifierListRequest](V1CreateModifierListRequest.md)
 - [Model.V1CreateModifierOptionRequest](V1CreateModifierOptionRequest.md)
 - [Model.V1CreatePageRequest](V1CreatePageRequest.md)
 - [Model.V1CreateRefundRequest](V1CreateRefundRequest.md)
 - [Model.V1CreateVariationRequest](V1CreateVariationRequest.md)
 - [Model.V1DeleteCategoryRequest](V1DeleteCategoryRequest.md)
 - [Model.V1DeleteDiscountRequest](V1DeleteDiscountRequest.md)
 - [Model.V1DeleteFeeRequest](V1DeleteFeeRequest.md)
 - [Model.V1DeleteItemRequest](V1DeleteItemRequest.md)
 - [Model.V1DeleteModifierListRequest](V1DeleteModifierListRequest.md)
 - [Model.V1DeleteModifierOptionRequest](V1DeleteModifierOptionRequest.md)
 - [Model.V1DeletePageCellRequest](V1DeletePageCellRequest.md)
 - [Model.V1DeletePageRequest](V1DeletePageRequest.md)
 - [Model.V1DeleteTimecardRequest](V1DeleteTimecardRequest.md)
 - [Model.V1DeleteTimecardResponse](V1DeleteTimecardResponse.md)
 - [Model.V1DeleteVariationRequest](V1DeleteVariationRequest.md)
 - [Model.V1Discount](V1Discount.md)
 - [Model.V1Employee](V1Employee.md)
 - [Model.V1EmployeeRole](V1EmployeeRole.md)
 - [Model.V1Fee](V1Fee.md)
 - [Model.V1InventoryEntry](V1InventoryEntry.md)
 - [Model.V1Item](V1Item.md)
 - [Model.V1ItemImage](V1ItemImage.md)
 - [Model.V1ListBankAccountsRequest](V1ListBankAccountsRequest.md)
 - [Model.V1ListBankAccountsResponse](V1ListBankAccountsResponse.md)
 - [Model.V1ListCashDrawerShiftsRequest](V1ListCashDrawerShiftsRequest.md)
 - [Model.V1ListCashDrawerShiftsResponse](V1ListCashDrawerShiftsResponse.md)
 - [Model.V1ListCategoriesRequest](V1ListCategoriesRequest.md)
 - [Model.V1ListCategoriesResponse](V1ListCategoriesResponse.md)
 - [Model.V1ListDiscountsRequest](V1ListDiscountsRequest.md)
 - [Model.V1ListDiscountsResponse](V1ListDiscountsResponse.md)
 - [Model.V1ListEmployeeRolesRequest](V1ListEmployeeRolesRequest.md)
 - [Model.V1ListEmployeeRolesResponse](V1ListEmployeeRolesResponse.md)
 - [Model.V1ListEmployeesRequest](V1ListEmployeesRequest.md)
 - [Model.V1ListEmployeesResponse](V1ListEmployeesResponse.md)
 - [Model.V1ListFeesRequest](V1ListFeesRequest.md)
 - [Model.V1ListFeesResponse](V1ListFeesResponse.md)
 - [Model.V1ListInventoryRequest](V1ListInventoryRequest.md)
 - [Model.V1ListInventoryResponse](V1ListInventoryResponse.md)
 - [Model.V1ListItemsRequest](V1ListItemsRequest.md)
 - [Model.V1ListItemsResponse](V1ListItemsResponse.md)
 - [Model.V1ListLocationsRequest](V1ListLocationsRequest.md)
 - [Model.V1ListLocationsResponse](V1ListLocationsResponse.md)
 - [Model.V1ListModifierListsRequest](V1ListModifierListsRequest.md)
 - [Model.V1ListModifierListsResponse](V1ListModifierListsResponse.md)
 - [Model.V1ListOrdersRequest](V1ListOrdersRequest.md)
 - [Model.V1ListOrdersResponse](V1ListOrdersResponse.md)
 - [Model.V1ListPagesRequest](V1ListPagesRequest.md)
 - [Model.V1ListPagesResponse](V1ListPagesResponse.md)
 - [Model.V1ListPaymentsRequest](V1ListPaymentsRequest.md)
 - [Model.V1ListPaymentsResponse](V1ListPaymentsResponse.md)
 - [Model.V1ListRefundsRequest](V1ListRefundsRequest.md)
 - [Model.V1ListRefundsResponse](V1ListRefundsResponse.md)
 - [Model.V1ListSettlementsRequest](V1ListSettlementsRequest.md)
 - [Model.V1ListSettlementsResponse](V1ListSettlementsResponse.md)
 - [Model.V1ListTimecardEventsRequest](V1ListTimecardEventsRequest.md)
 - [Model.V1ListTimecardEventsResponse](V1ListTimecardEventsResponse.md)
 - [Model.V1ListTimecardsRequest](V1ListTimecardsRequest.md)
 - [Model.V1ListTimecardsResponse](V1ListTimecardsResponse.md)
 - [Model.V1Merchant](V1Merchant.md)
 - [Model.V1MerchantLocationDetails](V1MerchantLocationDetails.md)
 - [Model.V1ModifierList](V1ModifierList.md)
 - [Model.V1ModifierOption](V1ModifierOption.md)
 - [Model.V1Money](V1Money.md)
 - [Model.V1Order](V1Order.md)
 - [Model.V1OrderHistoryEntry](V1OrderHistoryEntry.md)
 - [Model.V1Page](V1Page.md)
 - [Model.V1PageCell](V1PageCell.md)
 - [Model.V1Payment](V1Payment.md)
 - [Model.V1PaymentDiscount](V1PaymentDiscount.md)
 - [Model.V1PaymentItemDetail](V1PaymentItemDetail.md)
 - [Model.V1PaymentItemization](V1PaymentItemization.md)
 - [Model.V1PaymentModifier](V1PaymentModifier.md)
 - [Model.V1PaymentSurcharge](V1PaymentSurcharge.md)
 - [Model.V1PaymentTax](V1PaymentTax.md)
 - [Model.V1PhoneNumber](V1PhoneNumber.md)
 - [Model.V1Refund](V1Refund.md)
 - [Model.V1RemoveFeeRequest](V1RemoveFeeRequest.md)
 - [Model.V1RemoveModifierListRequest](V1RemoveModifierListRequest.md)
 - [Model.V1RetrieveBankAccountRequest](V1RetrieveBankAccountRequest.md)
 - [Model.V1RetrieveBusinessRequest](V1RetrieveBusinessRequest.md)
 - [Model.V1RetrieveCashDrawerShiftRequest](V1RetrieveCashDrawerShiftRequest.md)
 - [Model.V1RetrieveEmployeeRequest](V1RetrieveEmployeeRequest.md)
 - [Model.V1RetrieveEmployeeRoleRequest](V1RetrieveEmployeeRoleRequest.md)
 - [Model.V1RetrieveItemRequest](V1RetrieveItemRequest.md)
 - [Model.V1RetrieveModifierListRequest](V1RetrieveModifierListRequest.md)
 - [Model.V1RetrieveOrderRequest](V1RetrieveOrderRequest.md)
 - [Model.V1RetrievePaymentRequest](V1RetrievePaymentRequest.md)
 - [Model.V1RetrieveSettlementRequest](V1RetrieveSettlementRequest.md)
 - [Model.V1RetrieveTimecardRequest](V1RetrieveTimecardRequest.md)
 - [Model.V1Settlement](V1Settlement.md)
 - [Model.V1SettlementEntry](V1SettlementEntry.md)
 - [Model.V1Tender](V1Tender.md)
 - [Model.V1Timecard](V1Timecard.md)
 - [Model.V1TimecardEvent](V1TimecardEvent.md)
 - [Model.V1UpdateCategoryRequest](V1UpdateCategoryRequest.md)
 - [Model.V1UpdateDiscountRequest](V1UpdateDiscountRequest.md)
 - [Model.V1UpdateEmployeeRequest](V1UpdateEmployeeRequest.md)
 - [Model.V1UpdateEmployeeRoleRequest](V1UpdateEmployeeRoleRequest.md)
 - [Model.V1UpdateFeeRequest](V1UpdateFeeRequest.md)
 - [Model.V1UpdateItemRequest](V1UpdateItemRequest.md)
 - [Model.V1UpdateModifierListRequest](V1UpdateModifierListRequest.md)
 - [Model.V1UpdateModifierOptionRequest](V1UpdateModifierOptionRequest.md)
 - [Model.V1UpdateOrderRequest](V1UpdateOrderRequest.md)
 - [Model.V1UpdatePageCellRequest](V1UpdatePageCellRequest.md)
 - [Model.V1UpdatePageRequest](V1UpdatePageRequest.md)
 - [Model.V1UpdateTimecardRequest](V1UpdateTimecardRequest.md)
 - [Model.V1UpdateVariationRequest](V1UpdateVariationRequest.md)
 - [Model.V1Variation](V1Variation.md)
 - [Model.VoidTransactionRequest](VoidTransactionRequest.md)
 - [Model.VoidTransactionResponse](VoidTransactionResponse.md)
 - [Model.WorkweekConfig](WorkweekConfig.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth2"></a>
### oauth2

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: `https://connect.squareup.com/oauth2/authorize`
- **Scopes**:
  - BANK_ACCOUNTS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to bank account information associated with the targeted Square account. For example, to call the Connect v1 ListBankAccounts endpoint.
  - CUSTOMERS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to customer information. For example, to call the ListCustomers endpoint.
  - CUSTOMERS_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to customer information. For example, to create and update customer profiles.
  - EMPLOYEES_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to employee profile information. For example, to call the Connect v1 Employees API.
  - EMPLOYEES_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to employee profile information. For example, to create and modify employee profiles.
  - INVENTORY_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to inventory information. For example, to call the RetrieveInventoryCount endpoint.
  - INVENTORY_WRITE: __HTTP Method__:  &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to inventory information. For example, to call the BatchChangeInventory endpoint.
  - ITEMS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to business and location information. For example, to obtain a location ID for subsequent activity.
  - ITEMS_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to product catalog information. For example, to modify or add to a product catalog.
  - MERCHANT_PROFILE_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to business and location information. For example, to obtain a location ID for subsequent activity.
  - ORDERS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to order information. For example, to call the BatchRetrieveOrders endpoint.
  - ORDERS_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to order information. For example, to call the CreateCheckout endpoint.
  - PAYMENTS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to transaction and refund information. For example, to call the RetrieveTransaction endpoint.
  - PAYMENTS_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to transaction and refunds information. For example, to process payments with the Payments or Checkout API.
  - PAYMENTS_WRITE_ADDITIONAL_RECIPIENTS: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Allow third party applications to deduct a portion of each transaction amount. __Required__ to use multiparty transaction functionality with the Payments API.
  - PAYMENTS_WRITE_IN_PERSON: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to payments and refunds information. For example, to process in-person payments.
  - SETTLEMENTS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to settlement (deposit) information. For example, to call the Connect v1 ListSettlements endpoint.
  - TIMECARDS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to employee timecard information. For example, to call the Connect v2 SearchShifts endpoint.
  - TIMECARDS_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to employee shift information. For example, to create and modify employee shifts.
  - TIMECARDS_SETTINGS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to employee timecard settings information. For example, to call the GetBreakType endpoint.
  - TIMECARDS_SETTINGS_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to employee timecard settings information. For example, to call the UpdateBreakType endpoint.

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

[//]: # "Link anchor definitions"
[Square Logo]: https://docs.connect.squareup.com/images/github/github-square-logo.svg
