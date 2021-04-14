# identityserver4-quickstarts

The official documentation for these Identity Server 4 quickstarts can be found on the [official website](https://docs.identityserver.io/en/latest/quickstarts/0_overview.html). The goal of these is to provide step by step instructions for various common IdentityServer scenarios.

The purpose of this repository is to track my implementation of these quickstarts while I follow the official documentation. Thus, it is recommended that readers refer to the official documentation for a more complete picture of the inner workings of Identity Server 4.

## Protecting an API using Client Credentials

---

This first quickstart is the most basic scenario for protecting APIs using IdentityServer. Here we define an API and a Client with which to access it. The client requests an access token from the Identity Server using its client ID and secret and then uses the token to gain access to the API.

## Interactive Applications with ASP.NET Core

---

This quickstart focusses on adding support for interactive user authentication via the OpenID Connect protocol to our IdentityServer. Once that's in place, we create an MVC application that uses IdentityServer for authentication.

## ASP.NET Core and API access

---

In this quickstart we will explore combining API access and user authentication.

## Adding a JavaScript client

---

This quckstart demonstrates how to build a JavaScript client, otherwise know as a "Single Page Application" (or "SPA").

Through this client the user will login to IdentityServer, invoke the web API with an access token issued by IdentityServer, and logout of IdentityServer.
