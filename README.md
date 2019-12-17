![Square logo]

# Square Connect .NET SDK - RETIRED

---

[![Build Status](https://travis-ci.org/square/connect-csharp-sdk.svg?branch=master)](https://travis-ci.org/square/connect-csharp-sdk)
[![NuGet version](https://badge.fury.io/nu/Square.Connect.svg)](https://badge.fury.io/nu/Square.Connect)
[![Apache-2 license](https://img.shields.io/badge/license-Apache2-brightgreen.svg)](https://www.apache.org/licenses/LICENSE-2.0)
==================

## NOTICE: Square Connect .NET SDK retired

The Square Connect .NET SDK is retired (EOL) as of 2019-12-17 and will no longer
receive bug fixes or product updates. To continue receiving API and SDK
improvements, please follow the instructions below to migrate to the new
[Square .NET SDK].


The old Connect SDK documentation is available under the
[`/docs` folder](./docs/README.md).

<br/>

---

* [Migrate to the Square .NET SDK](#migrate-to-the-square-net-sdk)
  * [Update your package](#update-your-package)
  * [Update your code](#update-your-code)
* [Example code migration](#example-code-migration)
* [Ask the Community](#ask-the-community)

---

<br/>

## Migrate to the Square .NET SDK

Follow the instructions below to migrate your apps from the deprecated
`Square.Connect` library to the new `Square` library.

### Update your package

Replace `Square.Connect` with the new `Square` package and update the version.

### Update your code

1. Change all instances of `using Square.Connect.Api` to `using Square`.
1. Change all instances of `using Square.Connect.Model` to `using Square.Models`.
1. Remove all instances of `using Square.Connect.Client`.
1. Add a reference to `using Square.Exceptions` to anything that calls an endpoint.
1. Update client instantiation to follow the method outlined below.

To simplify your code, we also recommend that you use method chaining to access
APIs instead of explicitly instantiating multiple clients.

#### Client instantiation

```csharp
SquareClient square = new SquareClient.Builder()
    .Environment(Square.Environment.Sandbox)
    .AccessToken("YOUR_SANDBOX_ACCESS_TOKEN")
    .Build();
// e.g to fetch a list of locations
var response = square.LocationsApi.ListLocationsAsync();
```

<br/>

---

<br/>

## Example code migration

As a specific example, consider the code used to create a new customer
profile with the following `CreateCustomerRequest` object:

```csharp
var bodyAddress = new Address.Builder()
    .AddressLine1("500 Electric Ave")
    .AddressLine2("Suite 600")
    .Locality("New York")
    .AdministrativeDistrictLevel1("NY")
    .PostalCode("10003")
    .Country("US")
    .Build();
var body = new CreateCustomerRequest.Builder()
    .GivenName("Amelia")
    .FamilyName("Earhart")
    .EmailAddress("Amelia.Earhart@example.com")
    .Address(bodyAddress)
    .PhoneNumber("1-212-555-4240")
    .ReferenceId("YOUR_REFERENCE_ID")
    .Note("a customer")
    .Build();
```

With the deprecated `Square.Connect` library, this is how you instantiate a client
for the Customers API, format the request, and call the endpoint:

```csharp
using System;
using System.Diagnostics;
using Square.Connect.Api;
using Square.Connect.Client;
using Square.Connect.Model;

// Instantiate the client
var configuration = new Configuration(new ApiClient("https://connect.squareupsandbox.com"));
configuration.AccessToken = "YOUR_SANDBOX_ACCESS_TOKEN";
var customersApi = new CustomersApi(configuration);

// Call the endpoint and handle the response
try
{
  // CreateCustomer
  CreateCustomerResponse result = customersApi.CreateCustomer(body);
  Debug.WriteLine(result);
}
catch (Exception e)
{
  Debug.Print("Exception when calling CustomersApi.CreateCustomer: " + e.Message );
}
```

Now consider equivalent code using the new `Square` library:

```csharp
using Square;
using Square.Models;
using Square.Exceptions;

// Instantiate the client
SquareClient square = new SquareClient.Builder()
    .Environment(Square.Environment.Sandbox)
    .AccessToken("YOUR_SQUARE_ACCESS_TOKEN")
    .Build();

// Call the endpoint and handle the response
try
{
    CreateCustomerResponse result = square.CustomersApi.CreateCustomerAsync(body).Result;
    // Business logic
}
catch (APIException e)
{
    // Error Handling
};
```

That's it!

What was once a multi-block process can be handled in 1 line of code. Migrating
to the `Square` library reduces boilerplate and lets you focus on the parts of
your code that really matter.

<br/>

---

<br/>

## Ask the community

Please join us in our [Square developer community] if you have any questions!


[//]: # "Link anchor definitions"
[Square Logo]: https://docs.connect.squareup.com/images/github/github-square-logo.svg
[Square .NET SDK gem]: https://github.com/square/square-dotnet-sdk
[Square developer community]: https://squ.re/slack
