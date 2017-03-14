# Square Connect V2 C# SDK [![Build Status](https://travis-ci.org/square/connect-csharp-sdk.svg?branch=master)](https://travis-ci.org/square/connect-csharp-sdk)[![NuGet version](https://badge.fury.io/nu/Square.Connect.svg)](https://badge.fury.io/nu/Square.Connect)

This repository contains the released C# client SDK. Check out our [API
specification repository](https://github.com/square/connect-api-specification)
for the specification and template files we used to generate this.

## Frameworks supported
- .NET 4.5 or later

## Usage
### **Obtain from [NuGet package manager](https://www.nuget.org/packages/Square.Connect/) (Recommended)** 
```
PM> Install-Package Square.Connect
```

### **Generating DLLs from source**

#### Dependencies
- [RestSharp] (https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET] (https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

The DLLs included in the package may not be the latest version. We recommned using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
PM> Install-Package RestSharp
PM> Install-Package Newtonsoft.Json
```

Option 1: Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Option 2: Import the `Square.Connect/Square.Connect.csproj` to your solution and build from VS

Then include the DLLs (under the `bin` folder) in the C# project, 

- RestSharp.dll
- Newtonsoft.Json.dll
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
            LocationApi _locationApi = new LocationApi();
            var response = _locationApi.ListLocations();
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
            TransactionApi transactionApi = new TransactionApi();
            var response = transactionApi.Charge(locationId, body);
        }
    }
}
```
More examples are available at [connect-api-examples](https://github.com/square/connect-api-examples)

## Documentation for API Endpoints

All URIs are relative to [Square Connect V2 Documentation](https://docs.connect.squareup.com/api/connect/v2/#navsection-endpoints)

Class | Method | HTTP request 
------------ | ------------- | ------------- 
*CheckoutApi* | [**CreateCheckout**](docs/CheckoutApi.md#createcheckout) | **POST** /v2/locations/{location_id}/checkouts
*CustomerApi* | [**CreateCustomer**](docs/CustomerApi.md#createcustomer) | **POST** /v2/customers
*CustomerApi* | [**DeleteCustomer**](docs/CustomerApi.md#deletecustomer) | **DELETE** /v2/customers/{customer_id}
*CustomerApi* | [**ListCustomers**](docs/CustomerApi.md#listcustomers) | **GET** /v2/customers
*CustomerApi* | [**RetrieveCustomer**](docs/CustomerApi.md#retrievecustomer) | **GET** /v2/customers/{customer_id}
*CustomerApi* | [**UpdateCustomer**](docs/CustomerApi.md#updatecustomer) | **PUT** /v2/customers/{customer_id}
*CustomerCardApi* | [**CreateCustomerCard**](docs/CustomerCardApi.md#createcustomercard) | **POST** /v2/customers/{customer_id}/cards
*CustomerCardApi* | [**DeleteCustomerCard**](docs/CustomerCardApi.md#deletecustomercard) | **DELETE** /v2/customers/{customer_id}/cards/{card_id}
*EmployeesApi* | [**V1CreateEmployee**](docs/EmployeesApi.md#v1createemployee) | **POST** /v1/me/employees
*EmployeesApi* | [**V1CreateEmployeeRole**](docs/EmployeesApi.md#v1createemployeerole) | **POST** /v1/me/roles
*EmployeesApi* | [**V1CreateTimecard**](docs/EmployeesApi.md#v1createtimecard) | **POST** /v1/me/timecards
*EmployeesApi* | [**V1DeleteTimecard**](docs/EmployeesApi.md#v1deletetimecard) | **DELETE** /v1/me/timecards/{timecard_id}
*EmployeesApi* | [**V1ListCashDrawerShifts**](docs/EmployeesApi.md#v1listcashdrawershifts) | **GET** /v1/{location_id}/cash-drawer-shifts
*EmployeesApi* | [**V1ListEmployeeRoles**](docs/EmployeesApi.md#v1listemployeeroles) | **GET** /v1/me/roles
*EmployeesApi* | [**V1ListEmployees**](docs/EmployeesApi.md#v1listemployees) | **GET** /v1/me/employees
*EmployeesApi* | [**V1ListTimecardEvents**](docs/EmployeesApi.md#v1listtimecardevents) | **GET** /v1/me/timecards/{timecard_id}/events
*EmployeesApi* | [**V1ListTimecards**](docs/EmployeesApi.md#v1listtimecards) | **GET** /v1/me/timecards
*EmployeesApi* | [**V1RetrieveCashDrawerShift**](docs/EmployeesApi.md#v1retrievecashdrawershift) | **GET** /v1/{location_id}/cash-drawer-shifts/{shift_id}
*EmployeesApi* | [**V1RetrieveEmployee**](docs/EmployeesApi.md#v1retrieveemployee) | **GET** /v1/me/employees/{employee_id}
*EmployeesApi* | [**V1RetrieveEmployeeRole**](docs/EmployeesApi.md#v1retrieveemployeerole) | **GET** /v1/me/roles/{role_id}
*EmployeesApi* | [**V1RetrieveTimecard**](docs/EmployeesApi.md#v1retrievetimecard) | **GET** /v1/me/timecards/{timecard_id}
*EmployeesApi* | [**V1UpdateEmployee**](docs/EmployeesApi.md#v1updateemployee) | **PUT** /v1/me/employees/{employee_id}
*EmployeesApi* | [**V1UpdateEmployeeRole**](docs/EmployeesApi.md#v1updateemployeerole) | **PUT** /v1/me/roles/{role_id}
*EmployeesApi* | [**V1UpdateTimecard**](docs/EmployeesApi.md#v1updatetimecard) | **PUT** /v1/me/timecards/{timecard_id}
*ItemsApi* | [**V1AdjustInventory**](docs/ItemsApi.md#v1adjustinventory) | **POST** /v1/{location_id}/inventory/{variation_id}
*ItemsApi* | [**V1ApplyFee**](docs/ItemsApi.md#v1applyfee) | **PUT** /v1/{location_id}/items/{item_id}/fees/{fee_id}
*ItemsApi* | [**V1ApplyModifierList**](docs/ItemsApi.md#v1applymodifierlist) | **PUT** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id}
*ItemsApi* | [**V1CreateCategory**](docs/ItemsApi.md#v1createcategory) | **POST** /v1/{location_id}/categories
*ItemsApi* | [**V1CreateDiscount**](docs/ItemsApi.md#v1creatediscount) | **POST** /v1/{location_id}/discounts
*ItemsApi* | [**V1CreateFee**](docs/ItemsApi.md#v1createfee) | **POST** /v1/{location_id}/fees
*ItemsApi* | [**V1CreateItem**](docs/ItemsApi.md#v1createitem) | **POST** /v1/{location_id}/items
*ItemsApi* | [**V1CreateModifierList**](docs/ItemsApi.md#v1createmodifierlist) | **POST** /v1/{location_id}/modifier-lists
*ItemsApi* | [**V1CreateModifierOption**](docs/ItemsApi.md#v1createmodifieroption) | **POST** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options
*ItemsApi* | [**V1CreatePage**](docs/ItemsApi.md#v1createpage) | **POST** /v1/{location_id}/pages
*ItemsApi* | [**V1CreateVariation**](docs/ItemsApi.md#v1createvariation) | **POST** /v1/{location_id}/items/{item_id}/variations
*ItemsApi* | [**V1DeleteCategory**](docs/ItemsApi.md#v1deletecategory) | **DELETE** /v1/{location_id}/categories/{category_id}
*ItemsApi* | [**V1DeleteDiscount**](docs/ItemsApi.md#v1deletediscount) | **DELETE** /v1/{location_id}/discounts/{discount_id}
*ItemsApi* | [**V1DeleteFee**](docs/ItemsApi.md#v1deletefee) | **DELETE** /v1/{location_id}/fees/{fee_id}
*ItemsApi* | [**V1DeleteItem**](docs/ItemsApi.md#v1deleteitem) | **DELETE** /v1/{location_id}/items/{item_id}
*ItemsApi* | [**V1DeleteModifierList**](docs/ItemsApi.md#v1deletemodifierlist) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id}
*ItemsApi* | [**V1DeleteModifierOption**](docs/ItemsApi.md#v1deletemodifieroption) | **DELETE** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id}
*ItemsApi* | [**V1DeletePage**](docs/ItemsApi.md#v1deletepage) | **DELETE** /v1/{location_id}/pages/{page_id}
*ItemsApi* | [**V1DeletePageCell**](docs/ItemsApi.md#v1deletepagecell) | **DELETE** /v1/{location_id}/pages/{page_id}/cells
*ItemsApi* | [**V1DeleteVariation**](docs/ItemsApi.md#v1deletevariation) | **DELETE** /v1/{location_id}/items/{item_id}/variations/{variation_id}
*ItemsApi* | [**V1ListCategories**](docs/ItemsApi.md#v1listcategories) | **GET** /v1/{location_id}/categories
*ItemsApi* | [**V1ListDiscounts**](docs/ItemsApi.md#v1listdiscounts) | **GET** /v1/{location_id}/discounts
*ItemsApi* | [**V1ListFees**](docs/ItemsApi.md#v1listfees) | **GET** /v1/{location_id}/fees
*ItemsApi* | [**V1ListInventory**](docs/ItemsApi.md#v1listinventory) | **GET** /v1/{location_id}/inventory
*ItemsApi* | [**V1ListItems**](docs/ItemsApi.md#v1listitems) | **GET** /v1/{location_id}/items
*ItemsApi* | [**V1ListModifierLists**](docs/ItemsApi.md#v1listmodifierlists) | **GET** /v1/{location_id}/modifier-lists
*ItemsApi* | [**V1ListPages**](docs/ItemsApi.md#v1listpages) | **GET** /v1/{location_id}/pages
*ItemsApi* | [**V1RemoveFee**](docs/ItemsApi.md#v1removefee) | **DELETE** /v1/{location_id}/items/{item_id}/fees/{fee_id}
*ItemsApi* | [**V1RemoveModifierList**](docs/ItemsApi.md#v1removemodifierlist) | **DELETE** /v1/{location_id}/items/{item_id}/modifier-lists/{modifier_list_id}
*ItemsApi* | [**V1RetrieveItem**](docs/ItemsApi.md#v1retrieveitem) | **GET** /v1/{location_id}/items/{item_id}
*ItemsApi* | [**V1RetrieveModifierList**](docs/ItemsApi.md#v1retrievemodifierlist) | **GET** /v1/{location_id}/modifier-lists/{modifier_list_id}
*ItemsApi* | [**V1UpdateCategory**](docs/ItemsApi.md#v1updatecategory) | **PUT** /v1/{location_id}/categories/{category_id}
*ItemsApi* | [**V1UpdateDiscount**](docs/ItemsApi.md#v1updatediscount) | **PUT** /v1/{location_id}/discounts/{discount_id}
*ItemsApi* | [**V1UpdateFee**](docs/ItemsApi.md#v1updatefee) | **PUT** /v1/{location_id}/fees/{fee_id}
*ItemsApi* | [**V1UpdateItem**](docs/ItemsApi.md#v1updateitem) | **PUT** /v1/{location_id}/items/{item_id}
*ItemsApi* | [**V1UpdateModifierList**](docs/ItemsApi.md#v1updatemodifierlist) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id}
*ItemsApi* | [**V1UpdateModifierOption**](docs/ItemsApi.md#v1updatemodifieroption) | **PUT** /v1/{location_id}/modifier-lists/{modifier_list_id}/modifier-options/{modifier_option_id}
*ItemsApi* | [**V1UpdatePage**](docs/ItemsApi.md#v1updatepage) | **PUT** /v1/{location_id}/pages/{page_id}
*ItemsApi* | [**V1UpdatePageCell**](docs/ItemsApi.md#v1updatepagecell) | **PUT** /v1/{location_id}/pages/{page_id}/cells
*ItemsApi* | [**V1UpdateVariation**](docs/ItemsApi.md#v1updatevariation) | **PUT** /v1/{location_id}/items/{item_id}/variations/{variation_id}
*LocationApi* | [**ListLocations**](docs/LocationApi.md#listlocations) | **GET** /v2/locations
*LocationApi* | [**V1ListLocations**](docs/LocationApi.md#v1listlocations) | **GET** /v1/me/locations
*LocationApi* | [**V1RetrieveBusiness**](docs/LocationApi.md#v1retrievebusiness) | **GET** /v1/me
*RefundApi* | [**CreateRefund**](docs/RefundApi.md#createrefund) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/refund
*RefundApi* | [**ListRefunds**](docs/RefundApi.md#listrefunds) | **GET** /v2/locations/{location_id}/refunds
*TransactionApi* | [**CaptureTransaction**](docs/TransactionApi.md#capturetransaction) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/capture
*TransactionApi* | [**Charge**](docs/TransactionApi.md#charge) | **POST** /v2/locations/{location_id}/transactions
*TransactionApi* | [**ListTransactions**](docs/TransactionApi.md#listtransactions) | **GET** /v2/locations/{location_id}/transactions
*TransactionApi* | [**RetrieveTransaction**](docs/TransactionApi.md#retrievetransaction) | **GET** /v2/locations/{location_id}/transactions/{transaction_id}
*TransactionApi* | [**VoidTransaction**](docs/TransactionApi.md#voidtransaction) | **POST** /v2/locations/{location_id}/transactions/{transaction_id}/void
*TransactionsApi* | [**V1CreateRefund**](docs/TransactionsApi.md#v1createrefund) | **POST** /v1/{location_id}/refunds
*TransactionsApi* | [**V1ListBankAccounts**](docs/TransactionsApi.md#v1listbankaccounts) | **GET** /v1/{location_id}/bank-accounts
*TransactionsApi* | [**V1ListOrders**](docs/TransactionsApi.md#v1listorders) | **GET** /v1/{location_id}/orders
*TransactionsApi* | [**V1ListPayments**](docs/TransactionsApi.md#v1listpayments) | **GET** /v1/{location_id}/payments
*TransactionsApi* | [**V1ListRefunds**](docs/TransactionsApi.md#v1listrefunds) | **GET** /v1/{location_id}/refunds
*TransactionsApi* | [**V1ListSettlements**](docs/TransactionsApi.md#v1listsettlements) | **GET** /v1/{location_id}/settlements
*TransactionsApi* | [**V1RetrieveBankAccount**](docs/TransactionsApi.md#v1retrievebankaccount) | **GET** /v1/{location_id}/bank-accounts/{bank_account_id}
*TransactionsApi* | [**V1RetrieveOrder**](docs/TransactionsApi.md#v1retrieveorder) | **GET** /v1/{location_id}/orders/{order_id}
*TransactionsApi* | [**V1RetrievePayment**](docs/TransactionsApi.md#v1retrievepayment) | **GET** /v1/{location_id}/payments/{payment_id}
*TransactionsApi* | [**V1RetrieveSettlement**](docs/TransactionsApi.md#v1retrievesettlement) | **GET** /v1/{location_id}/settlements/{settlement_id}
*TransactionsApi* | [**V1UpdateOrder**](docs/TransactionsApi.md#v1updateorder) | **PUT** /v1/{location_id}/orders/{order_id}


## Documentation for Models

 - [Model.Address](docs/Address.md)
 - [Model.CaptureTransactionRequest](docs/CaptureTransactionRequest.md)
 - [Model.CaptureTransactionResponse](docs/CaptureTransactionResponse.md)
 - [Model.Card](docs/Card.md)
 - [Model.ChargeRequest](docs/ChargeRequest.md)
 - [Model.ChargeResponse](docs/ChargeResponse.md)
 - [Model.Checkout](docs/Checkout.md)
 - [Model.CreateCheckoutRequest](docs/CreateCheckoutRequest.md)
 - [Model.CreateCheckoutResponse](docs/CreateCheckoutResponse.md)
 - [Model.CreateCustomerCardRequest](docs/CreateCustomerCardRequest.md)
 - [Model.CreateCustomerCardResponse](docs/CreateCustomerCardResponse.md)
 - [Model.CreateCustomerRequest](docs/CreateCustomerRequest.md)
 - [Model.CreateCustomerResponse](docs/CreateCustomerResponse.md)
 - [Model.CreateOrderRequest](docs/CreateOrderRequest.md)
 - [Model.CreateOrderRequestLineItem](docs/CreateOrderRequestLineItem.md)
 - [Model.CreateOrderRequestOrder](docs/CreateOrderRequestOrder.md)
 - [Model.CreateRefundRequest](docs/CreateRefundRequest.md)
 - [Model.CreateRefundResponse](docs/CreateRefundResponse.md)
 - [Model.Customer](docs/Customer.md)
 - [Model.CustomerGroupInfo](docs/CustomerGroupInfo.md)
 - [Model.CustomerPreferences](docs/CustomerPreferences.md)
 - [Model.DeleteCustomerCardRequest](docs/DeleteCustomerCardRequest.md)
 - [Model.DeleteCustomerCardResponse](docs/DeleteCustomerCardResponse.md)
 - [Model.DeleteCustomerRequest](docs/DeleteCustomerRequest.md)
 - [Model.DeleteCustomerResponse](docs/DeleteCustomerResponse.md)
 - [Model.Device](docs/Device.md)
 - [Model.Error](docs/Error.md)
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
 - [Model.Order](docs/Order.md)
 - [Model.OrderLineItem](docs/OrderLineItem.md)
 - [Model.Refund](docs/Refund.md)
 - [Model.RetrieveCustomerRequest](docs/RetrieveCustomerRequest.md)
 - [Model.RetrieveCustomerResponse](docs/RetrieveCustomerResponse.md)
 - [Model.RetrieveTransactionRequest](docs/RetrieveTransactionRequest.md)
 - [Model.RetrieveTransactionResponse](docs/RetrieveTransactionResponse.md)
 - [Model.Tender](docs/Tender.md)
 - [Model.TenderCardDetails](docs/TenderCardDetails.md)
 - [Model.TenderCashDetails](docs/TenderCashDetails.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.UpdateCustomerRequest](docs/UpdateCustomerRequest.md)
 - [Model.UpdateCustomerResponse](docs/UpdateCustomerResponse.md)
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
- **Authorization URL**: `https://connect.squareup.com/oauth2/authorize?<PARAMETERS>`
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
  - ORDERS_READ: GET endpoints related to a merchant&#39;s Square online store.
  - ORDERS_WRITE: POST, PUT, and DELETE endpoints related to a merchant&#39;s Square online store
  - EMPLOYEES_READ: GET endpoints related to employee management
  - EMPLOYEES_WRITE: POST, PUT, and DELETE endpoints related to employee management
  - TIMECARDS_READ: GET endpoints related to employee timecards
  - TIMECARDS_WRITE: POST, PUT, and DELETE endpoints related to employee timecards


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
