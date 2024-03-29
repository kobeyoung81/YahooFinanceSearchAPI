# YahooFinance.SearchTerm - the C# library for the Yahoo Finance Search API

This is the API from yahoo finance to search for symbols.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using YahooFinance.SearchTerm.Api;
using YahooFinance.SearchTerm.Client;
using YahooFinance.SearchTerm.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using YahooFinance.SearchTerm.Api;
using YahooFinance.SearchTerm.Client;
using YahooFinance.SearchTerm.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var term = term_example;  // string | pass an optional search string for looking up inventory

            try
            {
                // searches tickers
                List<SearchResponse> result = apiInstance.SearchTerm(term);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SearchTerm: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://finance.yahoo.com/_finance_doubledown/api/resource*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**SearchTerm**](docs/DefaultApi.md#searchterm) | **GET** /searchassist;searchTerm&#x3D;{term} | searches tickers

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.SearchResponse](docs/SearchResponse.md)
 - [Model.YahooTicker](docs/YahooTicker.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
