# identityserver4-quickstarts

The official documentation for these Identity Server 4 quickstarts can be found on the [official website](https://docs.identityserver.io/en/latest/quickstarts/0_overview.html). The goal of these is to provide step by step instructions for various common IdentityServer scenarios.

The purpose of this repository is to track my implementation of these quickstarts while I follow the official documentation. Thus, it is recommended that one refer to the official documentation for a more complete picture of the inner workings of Identity Server 4.

## Protecting an API using Client Credentials

---

This first quickstart is the most basic scenario for protecting APIs using IdentityServer. Here we define an API and a Client with which to access it. The client requests an access token from the Identity Server using its client ID and secret and then uses the token to gain access to the API.
