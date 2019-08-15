![Square logo]

# Square Connect .NET SDK

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
*EmployeesApi* | [**ListEmployees**](docs/EmployeesApi.md#listemployees) | **GET** /v2/employees
*EmployeesApi* | [**RetrieveEmployee**](docs/EmployeesApi.md#retrieveemployee) | **GET** /v2/employees/{id}
*InventoryApi* | [**BatchChangeInventory**](docs/InventoryApi.md#batchchangeinventory) | **POST** /v2/inventory/batch-change
*InventoryApi* | [**BatchRetrieveInventoryChanges**](docs/InventoryApi.md#batchretrieveinventorychanges) | **POST** /v2/inventory/batch-retrieve-changes
*InventoryApi* | [**BatchRetrieveInventoryCounts**](docs/InventoryApi.md#batchretrieveinventorycounts) | **POST** /v2/inventory/batch-retrieve-counts
*InventoryApi* | [**RetrieveInventoryAdjustment**](docs/InventoryApi.md#retrieveinventoryadjustment) | **GET** /v2/inventory/adjustment/{adjustment_id}
*InventoryApi* | [**RetrieveInventoryChanges**](docs/InventoryApi.md#retrieveinventorychanges) | **GET** /v2/inventory/{catalog_object_id}/changes
*InventoryApi* | [**RetrieveInventoryCount**](docs/InventoryApi.md#retrieveinventorycount) | **GET** /v2/inventory/{catalog_object_id}
*InventoryApi* | [**RetrieveInventoryPhysicalCount**](docs/InventoryApi.md#retrieveinventoryphysicalcount) | **GET** /v2/inventory/physical-count/{physical_count_id}
*LaborApi* | [**CreateBreakType**](docs/LaborApi.md#createbreaktype) | **POST** /v2/labor/break-types
*LaborApi* | [**CreateShift**](docs/LaborApi.md#createshift) | **POST** /v2/labor/shifts
*LaborApi* | [**DeleteBreakType**](docs/LaborApi.md#deletebreaktype) | **DELETE** /v2/labor/break-types/{id}
*LaborApi* | [**DeleteShift**](docs/LaborApi.md#deleteshift) | **DELETE** /v2/labor/shifts/{id}
*LaborApi* | [**GetBreakType**](docs/LaborApi.md#getbreaktype) | **GET** /v2/labor/break-types/{id}
*LaborApi* | [**GetEmployeeWage**](docs/LaborApi.md#getemployeewage) | **GET** /v2/labor/employee-wages/{id}
*LaborApi* | [**GetShift**](docs/LaborApi.md#getshift) | **GET** /v2/labor/shifts/{id}
*LaborApi* | [**ListBreakTypes**](docs/LaborApi.md#listbreaktypes) | **GET** /v2/labor/break-types
*LaborApi* | [**ListEmployeeWages**](docs/LaborApi.md#listemployeewages) | **GET** /v2/labor/employee-wages
*LaborApi* | [**ListWorkweekConfigs**](docs/LaborApi.md#listworkweekconfigs) | **GET** /v2/labor/workweek-configs
*LaborApi* | [**SearchShifts**](docs/LaborApi.md#searchshifts) | **POST** /v2/labor/shifts/search
*LaborApi* | [**UpdateBreakType**](docs/LaborApi.md#updatebreaktype) | **PUT** /v2/labor/break-types/{id}
*LaborApi* | [**UpdateShift**](docs/LaborApi.md#updateshift) | **PUT** /v2/labor/shifts/{id}
*LaborApi* | [**UpdateWorkweekConfig**](docs/LaborApi.md#updateworkweekconfig) | **PUT** /v2/labor/workweek-configs/{id}
*LocationsApi* | [**ListLocations**](docs/LocationsApi.md#listlocations) | **GET** /v2/locations
*MobileAuthorizationApi* | [**CreateMobileAuthorizationCode**](docs/MobileAuthorizationApi.md#createmobileauthorizationcode) | **POST** /mobile/authorization-code
*OAuthApi* | [**ObtainToken**](docs/OAuthApi.md#obtaintoken) | **POST** /oauth2/token
*OAuthApi* | [**RenewToken**](docs/OAuthApi.md#renewtoken) | **POST** /oauth2/clients/{client_id}/access-token/renew
*OAuthApi* | [**RevokeToken**](docs/OAuthApi.md#revoketoken) | **POST** /oauth2/revoke
*OrdersApi* | [**BatchRetrieveOrders**](docs/OrdersApi.md#batchretrieveorders) | **POST** /v2/locations/{location_id}/orders/batch-retrieve
*OrdersApi* | [**CreateOrder**](docs/OrdersApi.md#createorder) | **POST** /v2/locations/{location_id}/orders
*OrdersApi* | [**PayOrder**](docs/OrdersApi.md#payorder) | **POST** /v2/orders/{order_id}/pay
*OrdersApi* | [**SearchOrders**](docs/OrdersApi.md#searchorders) | **POST** /v2/orders/search
*OrdersApi* | [**UpdateOrder**](docs/OrdersApi.md#updateorder) | **PUT** /v2/locations/{location_id}/orders/{order_id}
*PaymentsApi* | [**CancelPayment**](docs/PaymentsApi.md#cancelpayment) | **POST** /v2/payments/{payment_id}/cancel
*PaymentsApi* | [**CancelPaymentByIdempotencyKey**](docs/PaymentsApi.md#cancelpaymentbyidempotencykey) | **POST** /v2/payments/cancel
*PaymentsApi* | [**CompletePayment**](docs/PaymentsApi.md#completepayment) | **POST** /v2/payments/{payment_id}/complete
*PaymentsApi* | [**CreatePayment**](docs/PaymentsApi.md#createpayment) | **POST** /v2/payments
*PaymentsApi* | [**GetPayment**](docs/PaymentsApi.md#getpayment) | **GET** /v2/payments/{payment_id}
*PaymentsApi* | [**ListPayments**](docs/PaymentsApi.md#listpayments) | **GET** /v2/payments
*RefundsApi* | [**GetPaymentRefund**](docs/RefundsApi.md#getpaymentrefund) | **GET** /v2/refunds/{refund_id}
*RefundsApi* | [**ListPaymentRefunds**](docs/RefundsApi.md#listpaymentrefunds) | **GET** /v2/refunds
*RefundsApi* | [**RefundPayment**](docs/RefundsApi.md#refundpayment) | **POST** /v2/refunds
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
 - [Model.BalancePaymentDetails](docs/BalancePaymentDetails.md)
 - [Model.BatchChangeInventoryRequest](docs/BatchChangeInventoryRequest.md)
 - [Model.BatchChangeInventoryResponse](docs/BatchChangeInventoryResponse.md)
 - [Model.BatchDeleteCatalogObjectsRequest](docs/BatchDeleteCatalogObjectsRequest.md)
 - [Model.BatchDeleteCatalogObjectsResponse](docs/BatchDeleteCatalogObjectsResponse.md)
 - [Model.BatchRetrieveCatalogObjectsRequest](docs/BatchRetrieveCatalogObjectsRequest.md)
 - [Model.BatchRetrieveCatalogObjectsResponse](docs/BatchRetrieveCatalogObjectsResponse.md)
 - [Model.BatchRetrieveInventoryChangesRequest](docs/BatchRetrieveInventoryChangesRequest.md)
 - [Model.BatchRetrieveInventoryChangesResponse](docs/BatchRetrieveInventoryChangesResponse.md)
 - [Model.BatchRetrieveInventoryCountsRequest](docs/BatchRetrieveInventoryCountsRequest.md)
 - [Model.BatchRetrieveInventoryCountsResponse](docs/BatchRetrieveInventoryCountsResponse.md)
 - [Model.BatchRetrieveOrdersRequest](docs/BatchRetrieveOrdersRequest.md)
 - [Model.BatchRetrieveOrdersResponse](docs/BatchRetrieveOrdersResponse.md)
 - [Model.BatchUpsertCatalogObjectsRequest](docs/BatchUpsertCatalogObjectsRequest.md)
 - [Model.BatchUpsertCatalogObjectsResponse](docs/BatchUpsertCatalogObjectsResponse.md)
 - [Model.BreakType](docs/BreakType.md)
 - [Model.BusinessHours](docs/BusinessHours.md)
 - [Model.BusinessHoursPeriod](docs/BusinessHoursPeriod.md)
 - [Model.CancelPaymentByIdempotencyKeyRequest](docs/CancelPaymentByIdempotencyKeyRequest.md)
 - [Model.CancelPaymentByIdempotencyKeyResponse](docs/CancelPaymentByIdempotencyKeyResponse.md)
 - [Model.CancelPaymentRequest](docs/CancelPaymentRequest.md)
 - [Model.CancelPaymentResponse](docs/CancelPaymentResponse.md)
 - [Model.CaptureTransactionRequest](docs/CaptureTransactionRequest.md)
 - [Model.CaptureTransactionResponse](docs/CaptureTransactionResponse.md)
 - [Model.Card](docs/Card.md)
 - [Model.CardPaymentDetails](docs/CardPaymentDetails.md)
 - [Model.CatalogCategory](docs/CatalogCategory.md)
 - [Model.CatalogDiscount](docs/CatalogDiscount.md)
 - [Model.CatalogIdMapping](docs/CatalogIdMapping.md)
 - [Model.CatalogImage](docs/CatalogImage.md)
 - [Model.CatalogInfoRequest](docs/CatalogInfoRequest.md)
 - [Model.CatalogInfoResponse](docs/CatalogInfoResponse.md)
 - [Model.CatalogInfoResponseLimits](docs/CatalogInfoResponseLimits.md)
 - [Model.CatalogItem](docs/CatalogItem.md)
 - [Model.CatalogItemModifierListInfo](docs/CatalogItemModifierListInfo.md)
 - [Model.CatalogItemOption](docs/CatalogItemOption.md)
 - [Model.CatalogItemOptionForItem](docs/CatalogItemOptionForItem.md)
 - [Model.CatalogItemOptionValue](docs/CatalogItemOptionValue.md)
 - [Model.CatalogItemOptionValueForItemVariation](docs/CatalogItemOptionValueForItemVariation.md)
 - [Model.CatalogItemVariation](docs/CatalogItemVariation.md)
 - [Model.CatalogMeasurementUnit](docs/CatalogMeasurementUnit.md)
 - [Model.CatalogModifier](docs/CatalogModifier.md)
 - [Model.CatalogModifierList](docs/CatalogModifierList.md)
 - [Model.CatalogModifierOverride](docs/CatalogModifierOverride.md)
 - [Model.CatalogObject](docs/CatalogObject.md)
 - [Model.CatalogObjectBatch](docs/CatalogObjectBatch.md)
 - [Model.CatalogPricingRule](docs/CatalogPricingRule.md)
 - [Model.CatalogProductSet](docs/CatalogProductSet.md)
 - [Model.CatalogQuery](docs/CatalogQuery.md)
 - [Model.CatalogQueryExact](docs/CatalogQueryExact.md)
 - [Model.CatalogQueryItemVariationsForItemOptionValues](docs/CatalogQueryItemVariationsForItemOptionValues.md)
 - [Model.CatalogQueryItemsForItemOptions](docs/CatalogQueryItemsForItemOptions.md)
 - [Model.CatalogQueryItemsForModifierList](docs/CatalogQueryItemsForModifierList.md)
 - [Model.CatalogQueryItemsForTax](docs/CatalogQueryItemsForTax.md)
 - [Model.CatalogQueryPrefix](docs/CatalogQueryPrefix.md)
 - [Model.CatalogQueryRange](docs/CatalogQueryRange.md)
 - [Model.CatalogQuerySortedAttribute](docs/CatalogQuerySortedAttribute.md)
 - [Model.CatalogQueryText](docs/CatalogQueryText.md)
 - [Model.CatalogTax](docs/CatalogTax.md)
 - [Model.CatalogTimePeriod](docs/CatalogTimePeriod.md)
 - [Model.CatalogV1Id](docs/CatalogV1Id.md)
 - [Model.ChargeRequest](docs/ChargeRequest.md)
 - [Model.ChargeRequestAdditionalRecipient](docs/ChargeRequestAdditionalRecipient.md)
 - [Model.ChargeResponse](docs/ChargeResponse.md)
 - [Model.Checkout](docs/Checkout.md)
 - [Model.CompletePaymentRequest](docs/CompletePaymentRequest.md)
 - [Model.CompletePaymentResponse](docs/CompletePaymentResponse.md)
 - [Model.Coordinates](docs/Coordinates.md)
 - [Model.CreateBreakTypeRequest](docs/CreateBreakTypeRequest.md)
 - [Model.CreateBreakTypeResponse](docs/CreateBreakTypeResponse.md)
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
 - [Model.CreatePaymentRequest](docs/CreatePaymentRequest.md)
 - [Model.CreatePaymentResponse](docs/CreatePaymentResponse.md)
 - [Model.CreateRefundRequest](docs/CreateRefundRequest.md)
 - [Model.CreateRefundResponse](docs/CreateRefundResponse.md)
 - [Model.CreateShiftRequest](docs/CreateShiftRequest.md)
 - [Model.CreateShiftResponse](docs/CreateShiftResponse.md)
 - [Model.Customer](docs/Customer.md)
 - [Model.CustomerCreationSourceFilter](docs/CustomerCreationSourceFilter.md)
 - [Model.CustomerFilter](docs/CustomerFilter.md)
 - [Model.CustomerGroupInfo](docs/CustomerGroupInfo.md)
 - [Model.CustomerPreferences](docs/CustomerPreferences.md)
 - [Model.CustomerQuery](docs/CustomerQuery.md)
 - [Model.CustomerSort](docs/CustomerSort.md)
 - [Model.DateRange](docs/DateRange.md)
 - [Model.DeleteBreakTypeRequest](docs/DeleteBreakTypeRequest.md)
 - [Model.DeleteBreakTypeResponse](docs/DeleteBreakTypeResponse.md)
 - [Model.DeleteCatalogObjectRequest](docs/DeleteCatalogObjectRequest.md)
 - [Model.DeleteCatalogObjectResponse](docs/DeleteCatalogObjectResponse.md)
 - [Model.DeleteCustomerCardRequest](docs/DeleteCustomerCardRequest.md)
 - [Model.DeleteCustomerCardResponse](docs/DeleteCustomerCardResponse.md)
 - [Model.DeleteCustomerRequest](docs/DeleteCustomerRequest.md)
 - [Model.DeleteCustomerResponse](docs/DeleteCustomerResponse.md)
 - [Model.DeleteShiftRequest](docs/DeleteShiftRequest.md)
 - [Model.DeleteShiftResponse](docs/DeleteShiftResponse.md)
 - [Model.Device](docs/Device.md)
 - [Model.Employee](docs/Employee.md)
 - [Model.EmployeeWage](docs/EmployeeWage.md)
 - [Model.Error](docs/Error.md)
 - [Model.GetBreakTypeRequest](docs/GetBreakTypeRequest.md)
 - [Model.GetBreakTypeResponse](docs/GetBreakTypeResponse.md)
 - [Model.GetEmployeeWageRequest](docs/GetEmployeeWageRequest.md)
 - [Model.GetEmployeeWageResponse](docs/GetEmployeeWageResponse.md)
 - [Model.GetPaymentRefundRequest](docs/GetPaymentRefundRequest.md)
 - [Model.GetPaymentRefundResponse](docs/GetPaymentRefundResponse.md)
 - [Model.GetPaymentRequest](docs/GetPaymentRequest.md)
 - [Model.GetPaymentResponse](docs/GetPaymentResponse.md)
 - [Model.GetShiftRequest](docs/GetShiftRequest.md)
 - [Model.GetShiftResponse](docs/GetShiftResponse.md)
 - [Model.InventoryAdjustment](docs/InventoryAdjustment.md)
 - [Model.InventoryChange](docs/InventoryChange.md)
 - [Model.InventoryCount](docs/InventoryCount.md)
 - [Model.InventoryPhysicalCount](docs/InventoryPhysicalCount.md)
 - [Model.InventoryTransfer](docs/InventoryTransfer.md)
 - [Model.ItemVariationLocationOverrides](docs/ItemVariationLocationOverrides.md)
 - [Model.ListAdditionalRecipientReceivableRefundsRequest](docs/ListAdditionalRecipientReceivableRefundsRequest.md)
 - [Model.ListAdditionalRecipientReceivableRefundsResponse](docs/ListAdditionalRecipientReceivableRefundsResponse.md)
 - [Model.ListAdditionalRecipientReceivablesRequest](docs/ListAdditionalRecipientReceivablesRequest.md)
 - [Model.ListAdditionalRecipientReceivablesResponse](docs/ListAdditionalRecipientReceivablesResponse.md)
 - [Model.ListBreakTypesRequest](docs/ListBreakTypesRequest.md)
 - [Model.ListBreakTypesResponse](docs/ListBreakTypesResponse.md)
 - [Model.ListCatalogRequest](docs/ListCatalogRequest.md)
 - [Model.ListCatalogResponse](docs/ListCatalogResponse.md)
 - [Model.ListCustomersRequest](docs/ListCustomersRequest.md)
 - [Model.ListCustomersResponse](docs/ListCustomersResponse.md)
 - [Model.ListEmployeeWagesRequest](docs/ListEmployeeWagesRequest.md)
 - [Model.ListEmployeeWagesResponse](docs/ListEmployeeWagesResponse.md)
 - [Model.ListEmployeesRequest](docs/ListEmployeesRequest.md)
 - [Model.ListEmployeesResponse](docs/ListEmployeesResponse.md)
 - [Model.ListLocationsRequest](docs/ListLocationsRequest.md)
 - [Model.ListLocationsResponse](docs/ListLocationsResponse.md)
 - [Model.ListPaymentRefundsRequest](docs/ListPaymentRefundsRequest.md)
 - [Model.ListPaymentRefundsResponse](docs/ListPaymentRefundsResponse.md)
 - [Model.ListPaymentsRequest](docs/ListPaymentsRequest.md)
 - [Model.ListPaymentsResponse](docs/ListPaymentsResponse.md)
 - [Model.ListRefundsRequest](docs/ListRefundsRequest.md)
 - [Model.ListRefundsResponse](docs/ListRefundsResponse.md)
 - [Model.ListTransactionsRequest](docs/ListTransactionsRequest.md)
 - [Model.ListTransactionsResponse](docs/ListTransactionsResponse.md)
 - [Model.ListWorkweekConfigsRequest](docs/ListWorkweekConfigsRequest.md)
 - [Model.ListWorkweekConfigsResponse](docs/ListWorkweekConfigsResponse.md)
 - [Model.Location](docs/Location.md)
 - [Model.MeasurementUnit](docs/MeasurementUnit.md)
 - [Model.MeasurementUnitCustom](docs/MeasurementUnitCustom.md)
 - [Model.ModelBreak](docs/ModelBreak.md)
 - [Model.Money](docs/Money.md)
 - [Model.ObtainTokenRequest](docs/ObtainTokenRequest.md)
 - [Model.ObtainTokenResponse](docs/ObtainTokenResponse.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderEntry](docs/OrderEntry.md)
 - [Model.OrderFulfillment](docs/OrderFulfillment.md)
 - [Model.OrderFulfillmentPickupDetails](docs/OrderFulfillmentPickupDetails.md)
 - [Model.OrderFulfillmentRecipient](docs/OrderFulfillmentRecipient.md)
 - [Model.OrderFulfillmentShipmentDetails](docs/OrderFulfillmentShipmentDetails.md)
 - [Model.OrderLineItem](docs/OrderLineItem.md)
 - [Model.OrderLineItemAppliedDiscount](docs/OrderLineItemAppliedDiscount.md)
 - [Model.OrderLineItemAppliedTax](docs/OrderLineItemAppliedTax.md)
 - [Model.OrderLineItemDiscount](docs/OrderLineItemDiscount.md)
 - [Model.OrderLineItemModifier](docs/OrderLineItemModifier.md)
 - [Model.OrderLineItemTax](docs/OrderLineItemTax.md)
 - [Model.OrderMoneyAmounts](docs/OrderMoneyAmounts.md)
 - [Model.OrderQuantityUnit](docs/OrderQuantityUnit.md)
 - [Model.OrderReturn](docs/OrderReturn.md)
 - [Model.OrderReturnDiscount](docs/OrderReturnDiscount.md)
 - [Model.OrderReturnLineItem](docs/OrderReturnLineItem.md)
 - [Model.OrderReturnLineItemModifier](docs/OrderReturnLineItemModifier.md)
 - [Model.OrderReturnServiceCharge](docs/OrderReturnServiceCharge.md)
 - [Model.OrderReturnTax](docs/OrderReturnTax.md)
 - [Model.OrderRoundingAdjustment](docs/OrderRoundingAdjustment.md)
 - [Model.OrderServiceCharge](docs/OrderServiceCharge.md)
 - [Model.OrderSource](docs/OrderSource.md)
 - [Model.PayOrderRequest](docs/PayOrderRequest.md)
 - [Model.PayOrderResponse](docs/PayOrderResponse.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.PaymentRefund](docs/PaymentRefund.md)
 - [Model.ProcessingFee](docs/ProcessingFee.md)
 - [Model.Refund](docs/Refund.md)
 - [Model.RefundPaymentRequest](docs/RefundPaymentRequest.md)
 - [Model.RefundPaymentResponse](docs/RefundPaymentResponse.md)
 - [Model.RegisterDomainRequest](docs/RegisterDomainRequest.md)
 - [Model.RegisterDomainResponse](docs/RegisterDomainResponse.md)
 - [Model.RenewTokenRequest](docs/RenewTokenRequest.md)
 - [Model.RenewTokenResponse](docs/RenewTokenResponse.md)
 - [Model.RetrieveCatalogObjectRequest](docs/RetrieveCatalogObjectRequest.md)
 - [Model.RetrieveCatalogObjectResponse](docs/RetrieveCatalogObjectResponse.md)
 - [Model.RetrieveCustomerRequest](docs/RetrieveCustomerRequest.md)
 - [Model.RetrieveCustomerResponse](docs/RetrieveCustomerResponse.md)
 - [Model.RetrieveEmployeeRequest](docs/RetrieveEmployeeRequest.md)
 - [Model.RetrieveEmployeeResponse](docs/RetrieveEmployeeResponse.md)
 - [Model.RetrieveInventoryAdjustmentRequest](docs/RetrieveInventoryAdjustmentRequest.md)
 - [Model.RetrieveInventoryAdjustmentResponse](docs/RetrieveInventoryAdjustmentResponse.md)
 - [Model.RetrieveInventoryChangesRequest](docs/RetrieveInventoryChangesRequest.md)
 - [Model.RetrieveInventoryChangesResponse](docs/RetrieveInventoryChangesResponse.md)
 - [Model.RetrieveInventoryCountRequest](docs/RetrieveInventoryCountRequest.md)
 - [Model.RetrieveInventoryCountResponse](docs/RetrieveInventoryCountResponse.md)
 - [Model.RetrieveInventoryPhysicalCountRequest](docs/RetrieveInventoryPhysicalCountRequest.md)
 - [Model.RetrieveInventoryPhysicalCountResponse](docs/RetrieveInventoryPhysicalCountResponse.md)
 - [Model.RetrieveLocationRequest](docs/RetrieveLocationRequest.md)
 - [Model.RetrieveLocationResponse](docs/RetrieveLocationResponse.md)
 - [Model.RetrieveTransactionRequest](docs/RetrieveTransactionRequest.md)
 - [Model.RetrieveTransactionResponse](docs/RetrieveTransactionResponse.md)
 - [Model.RevokeTokenRequest](docs/RevokeTokenRequest.md)
 - [Model.RevokeTokenResponse](docs/RevokeTokenResponse.md)
 - [Model.SearchCatalogObjectsRequest](docs/SearchCatalogObjectsRequest.md)
 - [Model.SearchCatalogObjectsResponse](docs/SearchCatalogObjectsResponse.md)
 - [Model.SearchCustomersRequest](docs/SearchCustomersRequest.md)
 - [Model.SearchCustomersResponse](docs/SearchCustomersResponse.md)
 - [Model.SearchOrdersCustomerFilter](docs/SearchOrdersCustomerFilter.md)
 - [Model.SearchOrdersDateTimeFilter](docs/SearchOrdersDateTimeFilter.md)
 - [Model.SearchOrdersFilter](docs/SearchOrdersFilter.md)
 - [Model.SearchOrdersFulfillmentFilter](docs/SearchOrdersFulfillmentFilter.md)
 - [Model.SearchOrdersQuery](docs/SearchOrdersQuery.md)
 - [Model.SearchOrdersRequest](docs/SearchOrdersRequest.md)
 - [Model.SearchOrdersResponse](docs/SearchOrdersResponse.md)
 - [Model.SearchOrdersSort](docs/SearchOrdersSort.md)
 - [Model.SearchOrdersSourceFilter](docs/SearchOrdersSourceFilter.md)
 - [Model.SearchOrdersStateFilter](docs/SearchOrdersStateFilter.md)
 - [Model.SearchShiftsRequest](docs/SearchShiftsRequest.md)
 - [Model.SearchShiftsResponse](docs/SearchShiftsResponse.md)
 - [Model.Shift](docs/Shift.md)
 - [Model.ShiftFilter](docs/ShiftFilter.md)
 - [Model.ShiftQuery](docs/ShiftQuery.md)
 - [Model.ShiftSort](docs/ShiftSort.md)
 - [Model.ShiftWage](docs/ShiftWage.md)
 - [Model.ShiftWorkday](docs/ShiftWorkday.md)
 - [Model.SourceApplication](docs/SourceApplication.md)
 - [Model.StandardUnitDescription](docs/StandardUnitDescription.md)
 - [Model.StandardUnitDescriptionGroup](docs/StandardUnitDescriptionGroup.md)
 - [Model.Tender](docs/Tender.md)
 - [Model.TenderCardDetails](docs/TenderCardDetails.md)
 - [Model.TenderCashDetails](docs/TenderCashDetails.md)
 - [Model.TimeRange](docs/TimeRange.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.UpdateBreakTypeRequest](docs/UpdateBreakTypeRequest.md)
 - [Model.UpdateBreakTypeResponse](docs/UpdateBreakTypeResponse.md)
 - [Model.UpdateCustomerRequest](docs/UpdateCustomerRequest.md)
 - [Model.UpdateCustomerResponse](docs/UpdateCustomerResponse.md)
 - [Model.UpdateItemModifierListsRequest](docs/UpdateItemModifierListsRequest.md)
 - [Model.UpdateItemModifierListsResponse](docs/UpdateItemModifierListsResponse.md)
 - [Model.UpdateItemTaxesRequest](docs/UpdateItemTaxesRequest.md)
 - [Model.UpdateItemTaxesResponse](docs/UpdateItemTaxesResponse.md)
 - [Model.UpdateOrderRequest](docs/UpdateOrderRequest.md)
 - [Model.UpdateOrderResponse](docs/UpdateOrderResponse.md)
 - [Model.UpdateShiftRequest](docs/UpdateShiftRequest.md)
 - [Model.UpdateShiftResponse](docs/UpdateShiftResponse.md)
 - [Model.UpdateWorkweekConfigRequest](docs/UpdateWorkweekConfigRequest.md)
 - [Model.UpdateWorkweekConfigResponse](docs/UpdateWorkweekConfigResponse.md)
 - [Model.UpsertCatalogObjectRequest](docs/UpsertCatalogObjectRequest.md)
 - [Model.UpsertCatalogObjectResponse](docs/UpsertCatalogObjectResponse.md)
 - [Model.V1AdjustInventoryRequest](docs/V1AdjustInventoryRequest.md)
 - [Model.V1ApplyFeeRequest](docs/V1ApplyFeeRequest.md)
 - [Model.V1ApplyModifierListRequest](docs/V1ApplyModifierListRequest.md)
 - [Model.V1BankAccount](docs/V1BankAccount.md)
 - [Model.V1CashDrawerEvent](docs/V1CashDrawerEvent.md)
 - [Model.V1CashDrawerShift](docs/V1CashDrawerShift.md)
 - [Model.V1Category](docs/V1Category.md)
 - [Model.V1CreateCategoryRequest](docs/V1CreateCategoryRequest.md)
 - [Model.V1CreateDiscountRequest](docs/V1CreateDiscountRequest.md)
 - [Model.V1CreateEmployeeRoleRequest](docs/V1CreateEmployeeRoleRequest.md)
 - [Model.V1CreateFeeRequest](docs/V1CreateFeeRequest.md)
 - [Model.V1CreateItemRequest](docs/V1CreateItemRequest.md)
 - [Model.V1CreateModifierListRequest](docs/V1CreateModifierListRequest.md)
 - [Model.V1CreateModifierOptionRequest](docs/V1CreateModifierOptionRequest.md)
 - [Model.V1CreatePageRequest](docs/V1CreatePageRequest.md)
 - [Model.V1CreateRefundRequest](docs/V1CreateRefundRequest.md)
 - [Model.V1CreateVariationRequest](docs/V1CreateVariationRequest.md)
 - [Model.V1DeleteCategoryRequest](docs/V1DeleteCategoryRequest.md)
 - [Model.V1DeleteDiscountRequest](docs/V1DeleteDiscountRequest.md)
 - [Model.V1DeleteFeeRequest](docs/V1DeleteFeeRequest.md)
 - [Model.V1DeleteItemRequest](docs/V1DeleteItemRequest.md)
 - [Model.V1DeleteModifierListRequest](docs/V1DeleteModifierListRequest.md)
 - [Model.V1DeleteModifierOptionRequest](docs/V1DeleteModifierOptionRequest.md)
 - [Model.V1DeletePageCellRequest](docs/V1DeletePageCellRequest.md)
 - [Model.V1DeletePageRequest](docs/V1DeletePageRequest.md)
 - [Model.V1DeleteTimecardRequest](docs/V1DeleteTimecardRequest.md)
 - [Model.V1DeleteTimecardResponse](docs/V1DeleteTimecardResponse.md)
 - [Model.V1DeleteVariationRequest](docs/V1DeleteVariationRequest.md)
 - [Model.V1Discount](docs/V1Discount.md)
 - [Model.V1Employee](docs/V1Employee.md)
 - [Model.V1EmployeeRole](docs/V1EmployeeRole.md)
 - [Model.V1Fee](docs/V1Fee.md)
 - [Model.V1InventoryEntry](docs/V1InventoryEntry.md)
 - [Model.V1Item](docs/V1Item.md)
 - [Model.V1ItemImage](docs/V1ItemImage.md)
 - [Model.V1ListBankAccountsRequest](docs/V1ListBankAccountsRequest.md)
 - [Model.V1ListBankAccountsResponse](docs/V1ListBankAccountsResponse.md)
 - [Model.V1ListCashDrawerShiftsRequest](docs/V1ListCashDrawerShiftsRequest.md)
 - [Model.V1ListCashDrawerShiftsResponse](docs/V1ListCashDrawerShiftsResponse.md)
 - [Model.V1ListCategoriesRequest](docs/V1ListCategoriesRequest.md)
 - [Model.V1ListCategoriesResponse](docs/V1ListCategoriesResponse.md)
 - [Model.V1ListDiscountsRequest](docs/V1ListDiscountsRequest.md)
 - [Model.V1ListDiscountsResponse](docs/V1ListDiscountsResponse.md)
 - [Model.V1ListEmployeeRolesRequest](docs/V1ListEmployeeRolesRequest.md)
 - [Model.V1ListEmployeeRolesResponse](docs/V1ListEmployeeRolesResponse.md)
 - [Model.V1ListEmployeesRequest](docs/V1ListEmployeesRequest.md)
 - [Model.V1ListEmployeesResponse](docs/V1ListEmployeesResponse.md)
 - [Model.V1ListFeesRequest](docs/V1ListFeesRequest.md)
 - [Model.V1ListFeesResponse](docs/V1ListFeesResponse.md)
 - [Model.V1ListInventoryRequest](docs/V1ListInventoryRequest.md)
 - [Model.V1ListInventoryResponse](docs/V1ListInventoryResponse.md)
 - [Model.V1ListItemsRequest](docs/V1ListItemsRequest.md)
 - [Model.V1ListItemsResponse](docs/V1ListItemsResponse.md)
 - [Model.V1ListLocationsRequest](docs/V1ListLocationsRequest.md)
 - [Model.V1ListLocationsResponse](docs/V1ListLocationsResponse.md)
 - [Model.V1ListModifierListsRequest](docs/V1ListModifierListsRequest.md)
 - [Model.V1ListModifierListsResponse](docs/V1ListModifierListsResponse.md)
 - [Model.V1ListOrdersRequest](docs/V1ListOrdersRequest.md)
 - [Model.V1ListOrdersResponse](docs/V1ListOrdersResponse.md)
 - [Model.V1ListPagesRequest](docs/V1ListPagesRequest.md)
 - [Model.V1ListPagesResponse](docs/V1ListPagesResponse.md)
 - [Model.V1ListPaymentsRequest](docs/V1ListPaymentsRequest.md)
 - [Model.V1ListPaymentsResponse](docs/V1ListPaymentsResponse.md)
 - [Model.V1ListRefundsRequest](docs/V1ListRefundsRequest.md)
 - [Model.V1ListRefundsResponse](docs/V1ListRefundsResponse.md)
 - [Model.V1ListSettlementsRequest](docs/V1ListSettlementsRequest.md)
 - [Model.V1ListSettlementsResponse](docs/V1ListSettlementsResponse.md)
 - [Model.V1ListTimecardEventsRequest](docs/V1ListTimecardEventsRequest.md)
 - [Model.V1ListTimecardEventsResponse](docs/V1ListTimecardEventsResponse.md)
 - [Model.V1ListTimecardsRequest](docs/V1ListTimecardsRequest.md)
 - [Model.V1ListTimecardsResponse](docs/V1ListTimecardsResponse.md)
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
 - [Model.V1RemoveFeeRequest](docs/V1RemoveFeeRequest.md)
 - [Model.V1RemoveModifierListRequest](docs/V1RemoveModifierListRequest.md)
 - [Model.V1RetrieveBankAccountRequest](docs/V1RetrieveBankAccountRequest.md)
 - [Model.V1RetrieveBusinessRequest](docs/V1RetrieveBusinessRequest.md)
 - [Model.V1RetrieveCashDrawerShiftRequest](docs/V1RetrieveCashDrawerShiftRequest.md)
 - [Model.V1RetrieveEmployeeRequest](docs/V1RetrieveEmployeeRequest.md)
 - [Model.V1RetrieveEmployeeRoleRequest](docs/V1RetrieveEmployeeRoleRequest.md)
 - [Model.V1RetrieveItemRequest](docs/V1RetrieveItemRequest.md)
 - [Model.V1RetrieveModifierListRequest](docs/V1RetrieveModifierListRequest.md)
 - [Model.V1RetrieveOrderRequest](docs/V1RetrieveOrderRequest.md)
 - [Model.V1RetrievePaymentRequest](docs/V1RetrievePaymentRequest.md)
 - [Model.V1RetrieveSettlementRequest](docs/V1RetrieveSettlementRequest.md)
 - [Model.V1RetrieveTimecardRequest](docs/V1RetrieveTimecardRequest.md)
 - [Model.V1Settlement](docs/V1Settlement.md)
 - [Model.V1SettlementEntry](docs/V1SettlementEntry.md)
 - [Model.V1Tender](docs/V1Tender.md)
 - [Model.V1Timecard](docs/V1Timecard.md)
 - [Model.V1TimecardEvent](docs/V1TimecardEvent.md)
 - [Model.V1UpdateCategoryRequest](docs/V1UpdateCategoryRequest.md)
 - [Model.V1UpdateDiscountRequest](docs/V1UpdateDiscountRequest.md)
 - [Model.V1UpdateEmployeeRequest](docs/V1UpdateEmployeeRequest.md)
 - [Model.V1UpdateEmployeeRoleRequest](docs/V1UpdateEmployeeRoleRequest.md)
 - [Model.V1UpdateFeeRequest](docs/V1UpdateFeeRequest.md)
 - [Model.V1UpdateItemRequest](docs/V1UpdateItemRequest.md)
 - [Model.V1UpdateModifierListRequest](docs/V1UpdateModifierListRequest.md)
 - [Model.V1UpdateModifierOptionRequest](docs/V1UpdateModifierOptionRequest.md)
 - [Model.V1UpdateOrderRequest](docs/V1UpdateOrderRequest.md)
 - [Model.V1UpdatePageCellRequest](docs/V1UpdatePageCellRequest.md)
 - [Model.V1UpdatePageRequest](docs/V1UpdatePageRequest.md)
 - [Model.V1UpdateTimecardRequest](docs/V1UpdateTimecardRequest.md)
 - [Model.V1UpdateVariationRequest](docs/V1UpdateVariationRequest.md)
 - [Model.V1Variation](docs/V1Variation.md)
 - [Model.VoidTransactionRequest](docs/VoidTransactionRequest.md)
 - [Model.VoidTransactionResponse](docs/VoidTransactionResponse.md)
 - [Model.WorkweekConfig](docs/WorkweekConfig.md)


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
  - ITEMS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to product catalog information. For example, to get an  item or a list of items.
  - ITEMS_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to product catalog information. For example, to modify or add to a product catalog.
  - MERCHANT_PROFILE_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to business and location information. For example, to obtain a location ID for subsequent activity.
  - ORDERS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to order information. For example, to call the BatchRetrieveOrders endpoint.
  - ORDERS_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to order information. For example, to call the CreateCheckout endpoint.
  - PAYMENTS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to transaction and refund information. For example, to call the RetrieveTransaction endpoint.
  - PAYMENTS_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to transaction and refunds information. For example, to process payments with the Transactions or Checkout API.
  - PAYMENTS_WRITE_ADDITIONAL_RECIPIENTS: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Allow third party applications to deduct a portion of each transaction amount. __Required__ to use multiparty transaction functionality with the Transactions API.
  - PAYMENTS_WRITE_IN_PERSON: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to transaction and refunds information. For example, to process in-person payments.
  - SETTLEMENTS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to settlement (deposit) information. For example, to call the Connect v1 ListSettlements endpoint.
  - TIMECARDS_READ: __HTTP Method__: &#x60;GET&#x60;  Grants read access to employee timecard information. For example, to call the Connect v1 ListTimecards endpoint.
  - TIMECARDS_WRITE: __HTTP Method__: &#x60;POST&#x60;, &#x60;PUT&#x60;, &#x60;DELETE&#x60;  Grants write access to employee timecard information. For example, to create and modify timecards.
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
